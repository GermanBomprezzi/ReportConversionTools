namespace ReportConversionTools.Forms
{
    partial class CRUDConfigFilesForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.RichTextBox();
            this.cboxFile = new System.Windows.Forms.ComboBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.dgvFile = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtName_PreviewKeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME:";
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinition.Location = new System.Drawing.Point(12, 82);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(96, 16);
            this.lblDefinition.TabIndex = 3;
            this.lblDefinition.Text = "DEFINITION:";
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(123, 79);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(493, 229);
            this.txtDefinition.TabIndex = 2;
            this.txtDefinition.Text = "";
            this.txtDefinition.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtDefinition_PreviewKeyDown);
            // 
            // cboxFile
            // 
            this.cboxFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFile.FormattingEnabled = true;
            this.cboxFile.Items.AddRange(new object[] {
            "Columns",
            "Params",
            "Wheres"});
            this.cboxFile.Location = new System.Drawing.Point(123, 21);
            this.cboxFile.Name = "cboxFile";
            this.cboxFile.Size = new System.Drawing.Size(128, 24);
            this.cboxFile.TabIndex = 0;
            this.cboxFile.SelectedIndexChanged += new System.EventHandler(this.cboxFile_SelectedIndexChanged);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(12, 24);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(42, 16);
            this.lblFile.TabIndex = 102;
            this.lblFile.Text = "FILE:";
            // 
            // dgvFile
            // 
            this.dgvFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFile.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFile.Location = new System.Drawing.Point(623, 21);
            this.dgvFile.MultiSelect = false;
            this.dgvFile.Name = "dgvFile";
            this.dgvFile.ReadOnly = true;
            this.dgvFile.RowHeadersWidth = 51;
            this.dgvFile.RowTemplate.Height = 24;
            this.dgvFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFile.Size = new System.Drawing.Size(954, 853);
            this.dgvFile.TabIndex = 103;
            this.dgvFile.TabStop = false;
            this.dgvFile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnGenerate
            // 
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerate.Location = new System.Drawing.Point(516, 811);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 63);
            this.btnGenerate.TabIndex = 104;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteRow.Location = new System.Drawing.Point(516, 48);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(100, 29);
            this.btnDeleteRow.TabIndex = 105;
            this.btnDeleteRow.TabStop = false;
            this.btnDeleteRow.Text = "DELETE";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // CRUDConfigFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1589, 882);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgvFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.cboxFile);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CRUDConfigFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit json files";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.RichTextBox txtDefinition;
        private System.Windows.Forms.ComboBox cboxFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.DataGridView dgvFile;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDeleteRow;
    }
}