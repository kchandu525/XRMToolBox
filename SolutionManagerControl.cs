using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox.Extensibility;

namespace XrmToolBoxTool1
{
    public partial class SolutionManagerControl : PluginControlBase
    {
        public SolutionManagerControl()
        {
            InitializeComponent();
        }

        private void SolutionManagerControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This tool helps you export and import solutions", null);
        }

        private void btnLoadSolutions_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadSolutions);
        }

        private void btnExportSolution_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ExportSolution);
        }

        private void btnImportSolution_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ImportSolution);
        }

        private void LoadSolutions()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading solutions...",
                Work = (worker, args) =>
                {
                    var query = new QueryExpression("solution");
                    query.ColumnSet.AddColumns("friendlyname", "uniquename", "version", "ismanaged");
                    query.Criteria.AddCondition("ismanaged", ConditionOperator.Equal, false);
                    query.AddOrder("friendlyname", OrderType.Ascending);

                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var solutions = (EntityCollection)args.Result;

                    // Create a list of anonymous objects with properly named properties
                    var solutionList = solutions.Entities.Select(s => new
                    {
                        FriendlyName = s.GetAttributeValue<string>("friendlyname"),
                        UniqueName = s.GetAttributeValue<string>("uniquename"),
                        Version = s.GetAttributeValue<string>("version")
                    }).ToList();

                    lstSolutions.DataSource = solutionList;
                    lstSolutions.DisplayMember = "FriendlyName"; // Must match the anonymous type property
                    lstSolutions.ValueMember = "UniqueName";      // Must match the anonymous type property
                }
            });
        }

        private void ExportSolution()
        {
            if (lstSolutions.SelectedItem == null)
            {
                MessageBox.Show("Please select a solution first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item as dynamic
            dynamic selectedSolution = lstSolutions.SelectedItem;
            string uniqueName = selectedSolution.UniqueName;
            string friendlyName = selectedSolution.FriendlyName;

            var sfd = new SaveFileDialog
            {
                FileName = $"{uniqueName}_{selectedSolution.Version}.zip",
                Filter = "ZIP Files (*.zip)|*.zip"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WorkAsync(new WorkAsyncInfo
                {
                    Message = $"Exporting {friendlyName}...",
                    Work = (worker, args) =>
                    {
                        var request = new OrganizationRequest("ExportSolution");
                        request.Parameters["SolutionName"] = uniqueName;
                        request.Parameters["Managed"] = chkExportAsManaged.Checked;
                        // ... rest of your parameters

                        var response = Service.Execute(request);
                        var exportFile = (byte[])response["ExportSolutionFile"];
                        File.WriteAllBytes(sfd.FileName, exportFile);

                        args.Result = friendlyName;
                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (args.Error != null)
                        {
                            MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        MessageBox.Show($"Solution '{args.Result}' exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                });
            }
        }

        private void ImportSolution()
        {
            var ofd = new OpenFileDialog
            {
                Filter = "ZIP Files (*.zip)|*.zip"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                WorkAsync(new WorkAsyncInfo
                {
                    Message = "Importing solution...",
                    Work = (worker, args) =>
                    {
                        var fileBytes = File.ReadAllBytes(ofd.FileName);
                        Guid importJobId = Guid.NewGuid(); // Generate a new GUID for the import job

                        var request = new OrganizationRequest("ImportSolution")
                        {
                            ["ImportJobId"] = importJobId, // This is the required parameter
                            ["CustomizationFile"] = fileBytes,
                            ["PublishWorkflows"] = chkPublishAfterImport.Checked,
                            ["OverwriteUnmanagedCustomizations"] = chkOverwriteCustomizations.Checked,
                            ["ConvertToManaged"] = chkConvertToManaged.Checked,
                            ["SkipProductUpdateDependencies"] = chkSkipDependencies.Checked,
                            ["HoldingSolution"] = false
                        };

                        var response = Service.Execute(request);
                        args.Result = Path.GetFileNameWithoutExtension(ofd.FileName);
                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (args.Error != null)
                        {
                            MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        MessageBox.Show($"Solution '{args.Result}' imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSolutions(); // Refresh the solution list
                    }
                });
            }
        }
    }
}
