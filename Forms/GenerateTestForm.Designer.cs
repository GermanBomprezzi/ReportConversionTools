namespace ReportConversionTools.Forms
{
    partial class GenerateTestForm
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
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.lblReportName = new System.Windows.Forms.Label();
            this.lblReqReportName = new System.Windows.Forms.Label();
            this.txtMAQuery = new System.Windows.Forms.RichTextBox();
            this.txtInfinityQuery = new System.Windows.Forms.RichTextBox();
            this.lblMAQuery = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReqMAQuery = new System.Windows.Forms.Label();
            this.lblReqInfinityQuery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(627, 9);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(950, 345);
            this.txtResult.TabIndex = 100;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerate.Location = new System.Drawing.Point(521, 291);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 63);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtReportName
            // 
            this.txtReportName.Location = new System.Drawing.Point(131, 6);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(330, 22);
            this.txtReportName.TabIndex = 0;
            this.txtReportName.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.Location = new System.Drawing.Point(9, 9);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(121, 16);
            this.lblReportName.TabIndex = 8;
            this.lblReportName.Text = "REPORT NAME:";
            // 
            // lblReqReportName
            // 
            this.lblReqReportName.AutoSize = true;
            this.lblReqReportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqReportName.ForeColor = System.Drawing.Color.Red;
            this.lblReqReportName.Location = new System.Drawing.Point(467, 9);
            this.lblReqReportName.Name = "lblReqReportName";
            this.lblReqReportName.Size = new System.Drawing.Size(96, 16);
            this.lblReqReportName.TabIndex = 100;
            this.lblReqReportName.Text = "* REQUIRED";
            this.lblReqReportName.Visible = false;
            // 
            // txtMAQuery
            // 
            this.txtMAQuery.Location = new System.Drawing.Point(12, 59);
            this.txtMAQuery.Name = "txtMAQuery";
            this.txtMAQuery.Size = new System.Drawing.Size(449, 101);
            this.txtMAQuery.TabIndex = 101;
            this.txtMAQuery.Text = "";
            // 
            // txtInfinityQuery
            // 
            this.txtInfinityQuery.Location = new System.Drawing.Point(12, 182);
            this.txtInfinityQuery.Name = "txtInfinityQuery";
            this.txtInfinityQuery.Size = new System.Drawing.Size(449, 101);
            this.txtInfinityQuery.TabIndex = 102;
            this.txtInfinityQuery.Text = "";
            // 
            // lblMAQuery
            // 
            this.lblMAQuery.AutoSize = true;
            this.lblMAQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAQuery.Location = new System.Drawing.Point(9, 40);
            this.lblMAQuery.Name = "lblMAQuery";
            this.lblMAQuery.Size = new System.Drawing.Size(90, 16);
            this.lblMAQuery.TabIndex = 103;
            this.lblMAQuery.Text = "MA QUERY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "INFINITY QUERY:";
            // 
            // lblReqMAQuery
            // 
            this.lblReqMAQuery.AutoSize = true;
            this.lblReqMAQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqMAQuery.ForeColor = System.Drawing.Color.Red;
            this.lblReqMAQuery.Location = new System.Drawing.Point(467, 59);
            this.lblReqMAQuery.Name = "lblReqMAQuery";
            this.lblReqMAQuery.Size = new System.Drawing.Size(96, 16);
            this.lblReqMAQuery.TabIndex = 105;
            this.lblReqMAQuery.Text = "* REQUIRED";
            this.lblReqMAQuery.Visible = false;
            // 
            // lblReqInfinityQuery
            // 
            this.lblReqInfinityQuery.AutoSize = true;
            this.lblReqInfinityQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqInfinityQuery.ForeColor = System.Drawing.Color.Red;
            this.lblReqInfinityQuery.Location = new System.Drawing.Point(467, 182);
            this.lblReqInfinityQuery.Name = "lblReqInfinityQuery";
            this.lblReqInfinityQuery.Size = new System.Drawing.Size(96, 16);
            this.lblReqInfinityQuery.TabIndex = 106;
            this.lblReqInfinityQuery.Text = "* REQUIRED";
            this.lblReqInfinityQuery.Visible = false;
            // 
            // GenerateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1589, 366);
            this.Controls.Add(this.lblReqInfinityQuery);
            this.Controls.Add(this.lblReqMAQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMAQuery);
            this.Controls.Add(this.txtInfinityQuery);
            this.Controls.Add(this.txtMAQuery);
            this.Controls.Add(this.lblReqReportName);
            this.Controls.Add(this.lblReportName);
            this.Controls.Add(this.txtReportName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtResult);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate store procedure";
            this.Load += new System.EventHandler(this.GenerateStoreProcedureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.Label lblReqReportName;
        private System.Windows.Forms.RichTextBox txtMAQuery;
        private System.Windows.Forms.RichTextBox txtInfinityQuery;
        private System.Windows.Forms.Label lblMAQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReqMAQuery;
        private System.Windows.Forms.Label lblReqInfinityQuery;
    }
}