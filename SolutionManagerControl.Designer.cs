namespace XrmToolBoxTool1
{
    partial class SolutionManagerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSolutions = new System.Windows.Forms.ListBox();
            this.btnLoadSolutions = new System.Windows.Forms.Button();
            this.btnExportSolution = new System.Windows.Forms.Button();
            this.btnImportSolution = new System.Windows.Forms.Button();
            this.grpExportOptions = new System.Windows.Forms.GroupBox();
            this.chkExportSettings = new System.Windows.Forms.CheckBox();
            this.chkExportAsManaged = new System.Windows.Forms.CheckBox();
            this.grpImportOptions = new System.Windows.Forms.GroupBox();
            this.chkSkipDependencies = new System.Windows.Forms.CheckBox();
            this.chkConvertToManaged = new System.Windows.Forms.CheckBox();
            this.chkOverwriteCustomizations = new System.Windows.Forms.CheckBox();
            this.chkPublishAfterImport = new System.Windows.Forms.CheckBox();
            this.grpExportOptions.SuspendLayout();
            this.grpImportOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSolutions
            // 
            this.lstSolutions.FormattingEnabled = true;
            this.lstSolutions.Location = new System.Drawing.Point(9, 10);
            this.lstSolutions.Margin = new System.Windows.Forms.Padding(2);
            this.lstSolutions.Name = "lstSolutions";
            this.lstSolutions.Size = new System.Drawing.Size(226, 147);
            this.lstSolutions.TabIndex = 0;
            // 
            // btnLoadSolutions
            // 
            this.btnLoadSolutions.Location = new System.Drawing.Point(9, 161);
            this.btnLoadSolutions.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadSolutions.Name = "btnLoadSolutions";
            this.btnLoadSolutions.Size = new System.Drawing.Size(225, 24);
            this.btnLoadSolutions.TabIndex = 1;
            this.btnLoadSolutions.Text = "Load Solutions";
            this.btnLoadSolutions.UseVisualStyleBackColor = true;
            this.btnLoadSolutions.Click += new System.EventHandler(this.btnLoadSolutions_Click);
            // 
            // btnExportSolution
            // 
            this.btnExportSolution.Location = new System.Drawing.Point(9, 190);
            this.btnExportSolution.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportSolution.Name = "btnExportSolution";
            this.btnExportSolution.Size = new System.Drawing.Size(225, 24);
            this.btnExportSolution.TabIndex = 2;
            this.btnExportSolution.Text = "Export Solution";
            this.btnExportSolution.UseVisualStyleBackColor = true;
            this.btnExportSolution.Click += new System.EventHandler(this.btnExportSolution_Click);
            // 
            // btnImportSolution
            // 
            this.btnImportSolution.Location = new System.Drawing.Point(9, 219);
            this.btnImportSolution.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportSolution.Name = "btnImportSolution";
            this.btnImportSolution.Size = new System.Drawing.Size(225, 24);
            this.btnImportSolution.TabIndex = 3;
            this.btnImportSolution.Text = "Import Solution";
            this.btnImportSolution.UseVisualStyleBackColor = true;
            this.btnImportSolution.Click += new System.EventHandler(this.btnImportSolution_Click);
            // 
            // grpExportOptions
            // 
            this.grpExportOptions.Controls.Add(this.chkExportSettings);
            this.grpExportOptions.Controls.Add(this.chkExportAsManaged);
            this.grpExportOptions.Location = new System.Drawing.Point(238, 10);
            this.grpExportOptions.Margin = new System.Windows.Forms.Padding(2);
            this.grpExportOptions.Name = "grpExportOptions";
            this.grpExportOptions.Padding = new System.Windows.Forms.Padding(2);
            this.grpExportOptions.Size = new System.Drawing.Size(188, 81);
            this.grpExportOptions.TabIndex = 4;
            this.grpExportOptions.TabStop = false;
            this.grpExportOptions.Text = "Export Options";
            // 
            // chkExportSettings
            // 
            this.chkExportSettings.AutoSize = true;
            this.chkExportSettings.Location = new System.Drawing.Point(4, 41);
            this.chkExportSettings.Margin = new System.Windows.Forms.Padding(2);
            this.chkExportSettings.Name = "chkExportSettings";
            this.chkExportSettings.Size = new System.Drawing.Size(162, 17);
            this.chkExportSettings.TabIndex = 1;
            this.chkExportSettings.Text = "Export Configuration Settings";
            this.chkExportSettings.UseVisualStyleBackColor = true;
            // 
            // chkExportAsManaged
            // 
            this.chkExportAsManaged.AutoSize = true;
            this.chkExportAsManaged.Location = new System.Drawing.Point(4, 20);
            this.chkExportAsManaged.Margin = new System.Windows.Forms.Padding(2);
            this.chkExportAsManaged.Name = "chkExportAsManaged";
            this.chkExportAsManaged.Size = new System.Drawing.Size(118, 17);
            this.chkExportAsManaged.TabIndex = 0;
            this.chkExportAsManaged.Text = "Export as Managed";
            this.chkExportAsManaged.UseVisualStyleBackColor = true;
            // 
            // grpImportOptions
            // 
            this.grpImportOptions.Controls.Add(this.chkSkipDependencies);
            this.grpImportOptions.Controls.Add(this.chkConvertToManaged);
            this.grpImportOptions.Controls.Add(this.chkOverwriteCustomizations);
            this.grpImportOptions.Controls.Add(this.chkPublishAfterImport);
            this.grpImportOptions.Location = new System.Drawing.Point(238, 96);
            this.grpImportOptions.Margin = new System.Windows.Forms.Padding(2);
            this.grpImportOptions.Name = "grpImportOptions";
            this.grpImportOptions.Padding = new System.Windows.Forms.Padding(2);
            this.grpImportOptions.Size = new System.Drawing.Size(188, 122);
            this.grpImportOptions.TabIndex = 5;
            this.grpImportOptions.TabStop = false;
            this.grpImportOptions.Text = "Import Options";
            // 
            // chkSkipDependencies
            // 
            this.chkSkipDependencies.AutoSize = true;
            this.chkSkipDependencies.Location = new System.Drawing.Point(4, 81);
            this.chkSkipDependencies.Margin = new System.Windows.Forms.Padding(2);
            this.chkSkipDependencies.Name = "chkSkipDependencies";
            this.chkSkipDependencies.Size = new System.Drawing.Size(145, 17);
            this.chkSkipDependencies.TabIndex = 3;
            this.chkSkipDependencies.Text = "Skip Dependency Check";
            this.chkSkipDependencies.UseVisualStyleBackColor = true;
            // 
            // chkConvertToManaged
            // 
            this.chkConvertToManaged.AutoSize = true;
            this.chkConvertToManaged.Location = new System.Drawing.Point(4, 61);
            this.chkConvertToManaged.Margin = new System.Windows.Forms.Padding(2);
            this.chkConvertToManaged.Name = "chkConvertToManaged";
            this.chkConvertToManaged.Size = new System.Drawing.Size(123, 17);
            this.chkConvertToManaged.TabIndex = 2;
            this.chkConvertToManaged.Text = "Convert to Managed";
            this.chkConvertToManaged.UseVisualStyleBackColor = true;
            // 
            // chkOverwriteCustomizations
            // 
            this.chkOverwriteCustomizations.AutoSize = true;
            this.chkOverwriteCustomizations.Checked = true;
            this.chkOverwriteCustomizations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwriteCustomizations.Location = new System.Drawing.Point(4, 41);
            this.chkOverwriteCustomizations.Margin = new System.Windows.Forms.Padding(2);
            this.chkOverwriteCustomizations.Name = "chkOverwriteCustomizations";
            this.chkOverwriteCustomizations.Size = new System.Drawing.Size(144, 17);
            this.chkOverwriteCustomizations.TabIndex = 1;
            this.chkOverwriteCustomizations.Text = "Overwrite Customizations";
            this.chkOverwriteCustomizations.UseVisualStyleBackColor = true;
            // 
            // chkPublishAfterImport
            // 
            this.chkPublishAfterImport.AutoSize = true;
            this.chkPublishAfterImport.Checked = true;
            this.chkPublishAfterImport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPublishAfterImport.Location = new System.Drawing.Point(4, 20);
            this.chkPublishAfterImport.Margin = new System.Windows.Forms.Padding(2);
            this.chkPublishAfterImport.Name = "chkPublishAfterImport";
            this.chkPublishAfterImport.Size = new System.Drawing.Size(117, 17);
            this.chkPublishAfterImport.TabIndex = 0;
            this.chkPublishAfterImport.Text = "Publish After Import";
            this.chkPublishAfterImport.UseVisualStyleBackColor = true;
            // 
            // SolutionManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpImportOptions);
            this.Controls.Add(this.grpExportOptions);
            this.Controls.Add(this.btnImportSolution);
            this.Controls.Add(this.btnExportSolution);
            this.Controls.Add(this.btnLoadSolutions);
            this.Controls.Add(this.lstSolutions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SolutionManagerControl";
            this.Size = new System.Drawing.Size(930, 472);
            this.Load += new System.EventHandler(this.SolutionManagerControl_Load);
            this.grpExportOptions.ResumeLayout(false);
            this.grpExportOptions.PerformLayout();
            this.grpImportOptions.ResumeLayout(false);
            this.grpImportOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox lstSolutions;
        private System.Windows.Forms.Button btnLoadSolutions;
        private System.Windows.Forms.Button btnExportSolution;
        private System.Windows.Forms.Button btnImportSolution;
        private System.Windows.Forms.GroupBox grpExportOptions;
        private System.Windows.Forms.CheckBox chkExportSettings;
        private System.Windows.Forms.CheckBox chkExportAsManaged;
        private System.Windows.Forms.GroupBox grpImportOptions;
        private System.Windows.Forms.CheckBox chkSkipDependencies;
        private System.Windows.Forms.CheckBox chkConvertToManaged;
        private System.Windows.Forms.CheckBox chkOverwriteCustomizations;
        private System.Windows.Forms.CheckBox chkPublishAfterImport;
        #endregion
    }
}
