namespace ReportConversionTools.Forms
{
    partial class GenerateSPForm
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
            this.lblInvalidDictPath = new System.Windows.Forms.Label();
            this.lblTutorial1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtDictionaryFolder = new System.Windows.Forms.TextBox();
            this.lblDictPath = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvParameters = new System.Windows.Forms.DataGridView();
            this.lblSearchParam = new System.Windows.Forms.Label();
            this.txtSearchParam = new System.Windows.Forms.TextBox();
            this.txtSQL = new System.Windows.Forms.RichTextBox();
            this.txtClassPath = new System.Windows.Forms.TextBox();
            this.lblInfinityClass = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.RichTextBox();
            this.lblTutorial2 = new System.Windows.Forms.Label();
            this.lblInvalidClassPath = new System.Windows.Forms.Label();
            this.lblTutorial3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvalidDictPath
            // 
            this.lblInvalidDictPath.AutoSize = true;
            this.lblInvalidDictPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDictPath.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDictPath.Location = new System.Drawing.Point(616, 28);
            this.lblInvalidDictPath.Name = "lblInvalidDictPath";
            this.lblInvalidDictPath.Size = new System.Drawing.Size(91, 16);
            this.lblInvalidDictPath.TabIndex = 120;
            this.lblInvalidDictPath.Text = "invalid path!";
            this.lblInvalidDictPath.Visible = false;
            // 
            // lblTutorial1
            // 
            this.lblTutorial1.AutoSize = true;
            this.lblTutorial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial1.Location = new System.Drawing.Point(12, 9);
            this.lblTutorial1.Name = "lblTutorial1";
            this.lblTutorial1.Size = new System.Drawing.Size(267, 16);
            this.lblTutorial1.TabIndex = 119;
            this.lblTutorial1.Text = "1) Paste the path to the MA dictionary.";
            // 
            // btnSelect
            // 
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelect.Location = new System.Drawing.Point(723, 28);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 78);
            this.btnSelect.TabIndex = 117;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtDictionaryFolder
            // 
            this.txtDictionaryFolder.Location = new System.Drawing.Point(181, 28);
            this.txtDictionaryFolder.Name = "txtDictionaryFolder";
            this.txtDictionaryFolder.Size = new System.Drawing.Size(429, 22);
            this.txtDictionaryFolder.TabIndex = 116;
            // 
            // lblDictPath
            // 
            this.lblDictPath.AutoSize = true;
            this.lblDictPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDictPath.Location = new System.Drawing.Point(12, 31);
            this.lblDictPath.Name = "lblDictPath";
            this.lblDictPath.Size = new System.Drawing.Size(148, 16);
            this.lblDictPath.TabIndex = 115;
            this.lblDictPath.Text = "DICTIONARY PATH:";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(723, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 78);
            this.btnReset.TabIndex = 118;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvParameters
            // 
            this.dgvParameters.AllowUserToAddRows = false;
            this.dgvParameters.AllowUserToDeleteRows = false;
            this.dgvParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameters.Location = new System.Drawing.Point(15, 143);
            this.dgvParameters.MultiSelect = false;
            this.dgvParameters.Name = "dgvParameters";
            this.dgvParameters.RowHeadersWidth = 51;
            this.dgvParameters.RowTemplate.Height = 24;
            this.dgvParameters.Size = new System.Drawing.Size(808, 801);
            this.dgvParameters.StandardTab = true;
            this.dgvParameters.TabIndex = 121;
            this.dgvParameters.TabStop = false;
            // 
            // lblSearchParam
            // 
            this.lblSearchParam.AutoSize = true;
            this.lblSearchParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchParam.Location = new System.Drawing.Point(12, 118);
            this.lblSearchParam.Name = "lblSearchParam";
            this.lblSearchParam.Size = new System.Drawing.Size(130, 16);
            this.lblSearchParam.TabIndex = 122;
            this.lblSearchParam.Text = "SEARCH PARAM:";
            // 
            // txtSearchParam
            // 
            this.txtSearchParam.Location = new System.Drawing.Point(181, 115);
            this.txtSearchParam.Name = "txtSearchParam";
            this.txtSearchParam.Size = new System.Drawing.Size(429, 22);
            this.txtSearchParam.TabIndex = 123;
            this.txtSearchParam.TextChanged += new System.EventHandler(this.txtSearchParam_TextChanged);
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(37, 247);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(765, 650);
            this.txtSQL.TabIndex = 124;
            this.txtSQL.Text = "";
            this.txtSQL.Visible = false;
            // 
            // txtClassPath
            // 
            this.txtClassPath.Location = new System.Drawing.Point(181, 84);
            this.txtClassPath.Name = "txtClassPath";
            this.txtClassPath.Size = new System.Drawing.Size(429, 22);
            this.txtClassPath.TabIndex = 126;
            // 
            // lblInfinityClass
            // 
            this.lblInfinityClass.AutoSize = true;
            this.lblInfinityClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfinityClass.Location = new System.Drawing.Point(12, 87);
            this.lblInfinityClass.Name = "lblInfinityClass";
            this.lblInfinityClass.Size = new System.Drawing.Size(104, 16);
            this.lblInfinityClass.TabIndex = 125;
            this.lblInfinityClass.Text = "CLASS PATH:";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(829, 28);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(765, 916);
            this.txtClass.TabIndex = 127;
            this.txtClass.Text = "";
            // 
            // lblTutorial2
            // 
            this.lblTutorial2.AutoSize = true;
            this.lblTutorial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial2.Location = new System.Drawing.Point(12, 62);
            this.lblTutorial2.Name = "lblTutorial2";
            this.lblTutorial2.Size = new System.Drawing.Size(565, 16);
            this.lblTutorial2.TabIndex = 128;
            this.lblTutorial2.Text = "2) Paste the path to the Visual Basic class related to the report you\'re working " +
    "on.";
            // 
            // lblInvalidClassPath
            // 
            this.lblInvalidClassPath.AutoSize = true;
            this.lblInvalidClassPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidClassPath.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidClassPath.Location = new System.Drawing.Point(616, 87);
            this.lblInvalidClassPath.Name = "lblInvalidClassPath";
            this.lblInvalidClassPath.Size = new System.Drawing.Size(91, 16);
            this.lblInvalidClassPath.TabIndex = 129;
            this.lblInvalidClassPath.Text = "invalid path!";
            this.lblInvalidClassPath.Visible = false;
            // 
            // lblTutorial3
            // 
            this.lblTutorial3.AutoSize = true;
            this.lblTutorial3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial3.Location = new System.Drawing.Point(826, 9);
            this.lblTutorial3.Name = "lblTutorial3";
            this.lblTutorial3.Size = new System.Drawing.Size(686, 16);
            this.lblTutorial3.TabIndex = 130;
            this.lblTutorial3.Text = "3) Below, you can see the filter that the view or stored procedure will need for " +
    "generating the report.";
            // 
            // GenerateSPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1605, 954);
            this.Controls.Add(this.lblTutorial3);
            this.Controls.Add(this.lblInvalidClassPath);
            this.Controls.Add(this.lblTutorial2);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtClassPath);
            this.Controls.Add(this.lblInfinityClass);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.txtSearchParam);
            this.Controls.Add(this.lblSearchParam);
            this.Controls.Add(this.dgvParameters);
            this.Controls.Add(this.lblInvalidDictPath);
            this.Controls.Add(this.lblTutorial1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtDictionaryFolder);
            this.Controls.Add(this.lblDictPath);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GenerateSPForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERATE STORE PROCEDURE";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvalidDictPath;
        private System.Windows.Forms.Label lblTutorial1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtDictionaryFolder;
        private System.Windows.Forms.Label lblDictPath;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvParameters;
        private System.Windows.Forms.Label lblSearchParam;
        private System.Windows.Forms.TextBox txtSearchParam;
        private System.Windows.Forms.RichTextBox txtSQL;
        private System.Windows.Forms.TextBox txtClassPath;
        private System.Windows.Forms.Label lblInfinityClass;
        private System.Windows.Forms.RichTextBox txtClass;
        private System.Windows.Forms.Label lblTutorial2;
        private System.Windows.Forms.Label lblInvalidClassPath;
        private System.Windows.Forms.Label lblTutorial3;
    }
}