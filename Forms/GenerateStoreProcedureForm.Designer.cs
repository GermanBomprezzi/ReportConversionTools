namespace ReportConversionTools.Forms
{
    partial class GenerateStoreProcedureForm
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
            this.txtTempTableName = new System.Windows.Forms.TextBox();
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.chkColSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTempTableName = new System.Windows.Forms.Label();
            this.txtSPName = new System.Windows.Forms.TextBox();
            this.lblSPName = new System.Windows.Forms.Label();
            this.lblReqSPName = new System.Windows.Forms.Label();
            this.lblReqTempTableName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabParams = new System.Windows.Forms.TabPage();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.chkParamSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabColumns = new System.Windows.Forms.TabPage();
            this.tabWheres = new System.Windows.Forms.TabPage();
            this.dgvWheres = new System.Windows.Forms.DataGridView();
            this.chkWhereSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblViewName = new System.Windows.Forms.Label();
            this.txtViewName = new System.Windows.Forms.TextBox();
            this.lblReqViewName = new System.Windows.Forms.Label();
            this.chkCreateTempTableUsingView = new System.Windows.Forms.CheckBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            this.tabColumns.SuspendLayout();
            this.tabWheres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWheres)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTempTableName
            // 
            this.txtTempTableName.Location = new System.Drawing.Point(131, 34);
            this.txtTempTableName.Name = "txtTempTableName";
            this.txtTempTableName.Size = new System.Drawing.Size(330, 22);
            this.txtTempTableName.TabIndex = 1;
            this.txtTempTableName.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // dgvColumns
            // 
            this.dgvColumns.AllowUserToAddRows = false;
            this.dgvColumns.AllowUserToDeleteRows = false;
            this.dgvColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkColSelected});
            this.dgvColumns.Location = new System.Drawing.Point(6, 6);
            this.dgvColumns.MultiSelect = false;
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.ReadOnly = true;
            this.dgvColumns.RowHeadersWidth = 51;
            this.dgvColumns.RowTemplate.Height = 24;
            this.dgvColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColumns.Size = new System.Drawing.Size(593, 645);
            this.dgvColumns.StandardTab = true;
            this.dgvColumns.TabIndex = 100;
            this.dgvColumns.TabStop = false;
            this.dgvColumns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // chkColSelected
            // 
            this.chkColSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chkColSelected.HeaderText = "Selected";
            this.chkColSelected.MinimumWidth = 6;
            this.chkColSelected.Name = "chkColSelected";
            this.chkColSelected.ReadOnly = true;
            this.chkColSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkColSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkColSelected.Width = 90;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(627, 9);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(950, 865);
            this.txtResult.TabIndex = 100;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerate.Location = new System.Drawing.Point(521, 811);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 63);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTempTableName
            // 
            this.lblTempTableName.AutoSize = true;
            this.lblTempTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempTableName.Location = new System.Drawing.Point(9, 37);
            this.lblTempTableName.Name = "lblTempTableName";
            this.lblTempTableName.Size = new System.Drawing.Size(105, 16);
            this.lblTempTableName.TabIndex = 6;
            this.lblTempTableName.Text = "TEMP TABLE:";
            // 
            // txtSPName
            // 
            this.txtSPName.Location = new System.Drawing.Point(131, 6);
            this.txtSPName.Name = "txtSPName";
            this.txtSPName.Size = new System.Drawing.Size(330, 22);
            this.txtSPName.TabIndex = 0;
            this.txtSPName.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblSPName
            // 
            this.lblSPName.AutoSize = true;
            this.lblSPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPName.Location = new System.Drawing.Point(9, 9);
            this.lblSPName.Name = "lblSPName";
            this.lblSPName.Size = new System.Drawing.Size(78, 16);
            this.lblSPName.TabIndex = 8;
            this.lblSPName.Text = "SP NAME:";
            // 
            // lblReqSPName
            // 
            this.lblReqSPName.AutoSize = true;
            this.lblReqSPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqSPName.ForeColor = System.Drawing.Color.Red;
            this.lblReqSPName.Location = new System.Drawing.Point(467, 9);
            this.lblReqSPName.Name = "lblReqSPName";
            this.lblReqSPName.Size = new System.Drawing.Size(96, 16);
            this.lblReqSPName.TabIndex = 100;
            this.lblReqSPName.Text = "* REQUIRED";
            this.lblReqSPName.Visible = false;
            // 
            // lblReqTempTableName
            // 
            this.lblReqTempTableName.AutoSize = true;
            this.lblReqTempTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqTempTableName.ForeColor = System.Drawing.Color.Red;
            this.lblReqTempTableName.Location = new System.Drawing.Point(467, 37);
            this.lblReqTempTableName.Name = "lblReqTempTableName";
            this.lblReqTempTableName.Size = new System.Drawing.Size(96, 16);
            this.lblReqTempTableName.TabIndex = 101;
            this.lblReqTempTableName.Text = "* REQUIRED";
            this.lblReqTempTableName.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabParams);
            this.tabControl1.Controls.Add(this.tabColumns);
            this.tabControl1.Controls.Add(this.tabWheres);
            this.tabControl1.Location = new System.Drawing.Point(12, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 686);
            this.tabControl1.TabIndex = 100;
            this.tabControl1.TabStop = false;
            // 
            // tabParams
            // 
            this.tabParams.Controls.Add(this.dgvParams);
            this.tabParams.Location = new System.Drawing.Point(4, 25);
            this.tabParams.Name = "tabParams";
            this.tabParams.Padding = new System.Windows.Forms.Padding(3);
            this.tabParams.Size = new System.Drawing.Size(605, 657);
            this.tabParams.TabIndex = 0;
            this.tabParams.Text = "Parameters";
            this.tabParams.UseVisualStyleBackColor = true;
            // 
            // dgvParams
            // 
            this.dgvParams.AllowUserToAddRows = false;
            this.dgvParams.AllowUserToDeleteRows = false;
            this.dgvParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkParamSelected});
            this.dgvParams.Location = new System.Drawing.Point(6, 6);
            this.dgvParams.MultiSelect = false;
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.ReadOnly = true;
            this.dgvParams.RowHeadersWidth = 51;
            this.dgvParams.RowTemplate.Height = 24;
            this.dgvParams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParams.Size = new System.Drawing.Size(593, 645);
            this.dgvParams.StandardTab = true;
            this.dgvParams.TabIndex = 100;
            this.dgvParams.TabStop = false;
            this.dgvParams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // chkParamSelected
            // 
            this.chkParamSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chkParamSelected.HeaderText = "Selected";
            this.chkParamSelected.MinimumWidth = 6;
            this.chkParamSelected.Name = "chkParamSelected";
            this.chkParamSelected.ReadOnly = true;
            this.chkParamSelected.Width = 67;
            // 
            // tabColumns
            // 
            this.tabColumns.Controls.Add(this.dgvColumns);
            this.tabColumns.Location = new System.Drawing.Point(4, 25);
            this.tabColumns.Name = "tabColumns";
            this.tabColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabColumns.Size = new System.Drawing.Size(605, 657);
            this.tabColumns.TabIndex = 1;
            this.tabColumns.Text = "Columns";
            this.tabColumns.UseVisualStyleBackColor = true;
            // 
            // tabWheres
            // 
            this.tabWheres.Controls.Add(this.dgvWheres);
            this.tabWheres.Location = new System.Drawing.Point(4, 25);
            this.tabWheres.Name = "tabWheres";
            this.tabWheres.Padding = new System.Windows.Forms.Padding(3);
            this.tabWheres.Size = new System.Drawing.Size(605, 657);
            this.tabWheres.TabIndex = 2;
            this.tabWheres.Text = "Wheres";
            this.tabWheres.UseVisualStyleBackColor = true;
            // 
            // dgvWheres
            // 
            this.dgvWheres.AllowUserToAddRows = false;
            this.dgvWheres.AllowUserToDeleteRows = false;
            this.dgvWheres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWheres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWheres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkWhereSelected});
            this.dgvWheres.Location = new System.Drawing.Point(6, 6);
            this.dgvWheres.MultiSelect = false;
            this.dgvWheres.Name = "dgvWheres";
            this.dgvWheres.ReadOnly = true;
            this.dgvWheres.RowHeadersWidth = 51;
            this.dgvWheres.RowTemplate.Height = 24;
            this.dgvWheres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWheres.Size = new System.Drawing.Size(593, 645);
            this.dgvWheres.StandardTab = true;
            this.dgvWheres.TabIndex = 100;
            this.dgvWheres.TabStop = false;
            this.dgvWheres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // chkWhereSelected
            // 
            this.chkWhereSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chkWhereSelected.HeaderText = "Selected";
            this.chkWhereSelected.MinimumWidth = 6;
            this.chkWhereSelected.Name = "chkWhereSelected";
            this.chkWhereSelected.ReadOnly = true;
            this.chkWhereSelected.Width = 67;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(131, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(330, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSearch_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "SEARCH:";
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewName.Location = new System.Drawing.Point(9, 65);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(49, 16);
            this.lblViewName.TabIndex = 103;
            this.lblViewName.Text = "VIEW:";
            // 
            // txtViewName
            // 
            this.txtViewName.Location = new System.Drawing.Point(131, 62);
            this.txtViewName.Name = "txtViewName";
            this.txtViewName.Size = new System.Drawing.Size(330, 22);
            this.txtViewName.TabIndex = 2;
            this.txtViewName.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblReqViewName
            // 
            this.lblReqViewName.AutoSize = true;
            this.lblReqViewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqViewName.ForeColor = System.Drawing.Color.Red;
            this.lblReqViewName.Location = new System.Drawing.Point(467, 65);
            this.lblReqViewName.Name = "lblReqViewName";
            this.lblReqViewName.Size = new System.Drawing.Size(96, 16);
            this.lblReqViewName.TabIndex = 105;
            this.lblReqViewName.Text = "* REQUIRED";
            this.lblReqViewName.Visible = false;
            // 
            // chkCreateTempTableUsingView
            // 
            this.chkCreateTempTableUsingView.AutoSize = true;
            this.chkCreateTempTableUsingView.Location = new System.Drawing.Point(190, 811);
            this.chkCreateTempTableUsingView.Name = "chkCreateTempTableUsingView";
            this.chkCreateTempTableUsingView.Size = new System.Drawing.Size(305, 20);
            this.chkCreateTempTableUsingView.TabIndex = 106;
            this.chkCreateTempTableUsingView.TabStop = false;
            this.chkCreateTempTableUsingView.Text = "Create temporary table using the view structure";
            this.chkCreateTempTableUsingView.UseVisualStyleBackColor = true;
            this.chkCreateTempTableUsingView.CheckedChanged += new System.EventHandler(this.chkCreateTempTableUsingView_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Green;
            this.lblSearch.Location = new System.Drawing.Point(467, 93);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 16);
            this.lblSearch.TabIndex = 107;
            this.lblSearch.Text = "* FOUND IT!";
            this.lblSearch.Visible = false;
            // 
            // GenerateStoreProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1589, 880);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.chkCreateTempTableUsingView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblReqViewName);
            this.Controls.Add(this.txtViewName);
            this.Controls.Add(this.lblViewName);
            this.Controls.Add(this.lblReqTempTableName);
            this.Controls.Add(this.lblReqSPName);
            this.Controls.Add(this.lblSPName);
            this.Controls.Add(this.txtSPName);
            this.Controls.Add(this.lblTempTableName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtTempTableName);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateStoreProcedureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate store procedure";
            this.Load += new System.EventHandler(this.GenerateStoreProcedureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            this.tabColumns.ResumeLayout(false);
            this.tabWheres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWheres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempTableName;
        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTempTableName;
        private System.Windows.Forms.TextBox txtSPName;
        private System.Windows.Forms.Label lblSPName;
        private System.Windows.Forms.Label lblReqSPName;
        private System.Windows.Forms.Label lblReqTempTableName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabParams;
        private System.Windows.Forms.TabPage tabColumns;
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.TextBox txtViewName;
        private System.Windows.Forms.Label lblReqViewName;
        private System.Windows.Forms.TabPage tabWheres;
        private System.Windows.Forms.DataGridView dgvWheres;
        private System.Windows.Forms.CheckBox chkCreateTempTableUsingView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkParamSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkWhereSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColSelected;
        private System.Windows.Forms.Label lblSearch;
    }
}