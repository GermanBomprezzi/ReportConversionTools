namespace ReportConversionTools.Helpers
{
    partial class DataGridHelperForm
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
            this.dgvHelper = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelper)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHelper
            // 
            this.dgvHelper.AllowUserToOrderColumns = true;
            this.dgvHelper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHelper.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvHelper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHelper.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvHelper.Location = new System.Drawing.Point(12, 12);
            this.dgvHelper.Name = "dgvHelper";
            this.dgvHelper.RowHeadersWidth = 51;
            this.dgvHelper.RowTemplate.Height = 24;
            this.dgvHelper.Size = new System.Drawing.Size(1052, 679);
            this.dgvHelper.TabIndex = 0;
            // 
            // DataGridHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 703);
            this.Controls.Add(this.dgvHelper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DataGridHelperForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHelper;
    }
}