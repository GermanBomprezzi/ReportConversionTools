namespace ReportConversionTools.Forms
{
    partial class GenerateAliasesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAliases = new System.Windows.Forms.DataGridView();
            this.clnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblScriptsFolder = new System.Windows.Forms.Label();
            this.txtScriptsFolder = new System.Windows.Forms.TextBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.clnFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFile = new System.Windows.Forms.RichTextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTutorial1 = new System.Windows.Forms.Label();
            this.lblTutorial2 = new System.Windows.Forms.Label();
            this.lblTutorial3 = new System.Windows.Forms.Label();
            this.lblInvalidPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAliases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAliases
            // 
            this.dgvAliases.AllowUserToAddRows = false;
            this.dgvAliases.AllowUserToDeleteRows = false;
            this.dgvAliases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAliases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAliases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnColumn});
            this.dgvAliases.Location = new System.Drawing.Point(11, 133);
            this.dgvAliases.MultiSelect = false;
            this.dgvAliases.Name = "dgvAliases";
            this.dgvAliases.RowHeadersWidth = 51;
            this.dgvAliases.RowTemplate.Height = 24;
            this.dgvAliases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAliases.Size = new System.Drawing.Size(446, 745);
            this.dgvAliases.StandardTab = true;
            this.dgvAliases.TabIndex = 101;
            this.dgvAliases.TabStop = false;
            this.dgvAliases.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAliases_CellEndEdit);
            this.dgvAliases.SelectionChanged += new System.EventHandler(this.dgvAliases_SelectionChanged);
            this.dgvAliases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAliases_KeyDown);
            // 
            // clnColumn
            // 
            this.clnColumn.HeaderText = "Column";
            this.clnColumn.MinimumWidth = 6;
            this.clnColumn.Name = "clnColumn";
            // 
            // lblScriptsFolder
            // 
            this.lblScriptsFolder.AutoSize = true;
            this.lblScriptsFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScriptsFolder.Location = new System.Drawing.Point(12, 45);
            this.lblScriptsFolder.Name = "lblScriptsFolder";
            this.lblScriptsFolder.Size = new System.Drawing.Size(140, 16);
            this.lblScriptsFolder.TabIndex = 103;
            this.lblScriptsFolder.Text = "SCRIPTS FOLDER:";
            // 
            // txtScriptsFolder
            // 
            this.txtScriptsFolder.Location = new System.Drawing.Point(169, 42);
            this.txtScriptsFolder.Name = "txtScriptsFolder";
            this.txtScriptsFolder.Size = new System.Drawing.Size(444, 22);
            this.txtScriptsFolder.TabIndex = 104;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFolder});
            this.dgvFiles.Location = new System.Drawing.Point(464, 133);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersWidth = 51;
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(1089, 147);
            this.dgvFiles.StandardTab = true;
            this.dgvFiles.TabIndex = 107;
            this.dgvFiles.TabStop = false;
            this.dgvFiles.SelectionChanged += new System.EventHandler(this.dgvFiles_SelectionChanged);
            // 
            // clnFolder
            // 
            this.clnFolder.HeaderText = "Folder";
            this.clnFolder.MinimumWidth = 6;
            this.clnFolder.Name = "clnFolder";
            this.clnFolder.ReadOnly = true;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(463, 286);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(1090, 592);
            this.txtFile.TabIndex = 108;
            this.txtFile.Text = "";
            // 
            // btnSelect
            // 
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelect.Location = new System.Drawing.Point(619, 39);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 29);
            this.btnSelect.TabIndex = 109;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(619, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 29);
            this.btnReset.TabIndex = 110;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTutorial1
            // 
            this.lblTutorial1.AutoSize = true;
            this.lblTutorial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial1.Location = new System.Drawing.Point(12, 9);
            this.lblTutorial1.Name = "lblTutorial1";
            this.lblTutorial1.Size = new System.Drawing.Size(347, 16);
            this.lblTutorial1.TabIndex = 111;
            this.lblTutorial1.Text = "1) Choose the directory containing the MA scripts.";
            // 
            // lblTutorial2
            // 
            this.lblTutorial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial2.Location = new System.Drawing.Point(12, 72);
            this.lblTutorial2.Name = "lblTutorial2";
            this.lblTutorial2.Size = new System.Drawing.Size(446, 58);
            this.lblTutorial2.TabIndex = 112;
            this.lblTutorial2.Text = "2) Execute sp_help \'[name of view]\' to retrieve the column information. Then, cop" +
    "y the resulting columns using Ctrl + C and paste them here with Ctrl + V.";
            this.lblTutorial2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTutorial3
            // 
            this.lblTutorial3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial3.Location = new System.Drawing.Point(464, 72);
            this.lblTutorial3.Name = "lblTutorial3";
            this.lblTutorial3.Size = new System.Drawing.Size(446, 58);
            this.lblTutorial3.TabIndex = 113;
            this.lblTutorial3.Text = "3) Select the file that contains the selected column.";
            this.lblTutorial3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblInvalidPath
            // 
            this.lblInvalidPath.AutoSize = true;
            this.lblInvalidPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPath.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPath.Location = new System.Drawing.Point(725, 45);
            this.lblInvalidPath.Name = "lblInvalidPath";
            this.lblInvalidPath.Size = new System.Drawing.Size(91, 16);
            this.lblInvalidPath.TabIndex = 114;
            this.lblInvalidPath.Text = "invalid path!";
            this.lblInvalidPath.Visible = false;
            // 
            // GenerateAliasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1567, 890);
            this.Controls.Add(this.lblInvalidPath);
            this.Controls.Add(this.lblTutorial3);
            this.Controls.Add(this.lblTutorial2);
            this.Controls.Add(this.lblTutorial1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.txtScriptsFolder);
            this.Controls.Add(this.lblScriptsFolder);
            this.Controls.Add(this.dgvAliases);
            this.Controls.Add(this.btnReset);
            this.Name = "GenerateAliasesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERATE ALIASES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAliases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAliases;
        private System.Windows.Forms.Label lblScriptsFolder;
        private System.Windows.Forms.TextBox txtScriptsFolder;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFolder;
        private System.Windows.Forms.RichTextBox txtFile;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTutorial1;
        private System.Windows.Forms.Label lblTutorial2;
        private System.Windows.Forms.Label lblTutorial3;
        private System.Windows.Forms.Label lblInvalidPath;
    }
}