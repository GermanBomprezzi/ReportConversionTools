namespace ReportConversionTools.Forms
{
    partial class MainForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAliasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genSPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuItem,
            this.spMenuItem,
            this.testToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1320, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genViewMenuItem,
            this.searchAliasesToolStripMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewMenuItem.Text = "View";
            // 
            // genViewMenuItem
            // 
            this.genViewMenuItem.Name = "genViewMenuItem";
            this.genViewMenuItem.Size = new System.Drawing.Size(224, 26);
            this.genViewMenuItem.Text = "Generate";
            this.genViewMenuItem.Visible = false;
            // 
            // searchAliasesToolStripMenuItem
            // 
            this.searchAliasesToolStripMenuItem.Name = "searchAliasesToolStripMenuItem";
            this.searchAliasesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchAliasesToolStripMenuItem.Text = "Search aliases";
            this.searchAliasesToolStripMenuItem.Click += new System.EventHandler(this.searchAliasesToolStripMenuItem_Click);
            // 
            // spMenuItem
            // 
            this.spMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genSPMenuItem});
            this.spMenuItem.Name = "spMenuItem";
            this.spMenuItem.Size = new System.Drawing.Size(129, 24);
            this.spMenuItem.Text = "Store Procedure";
            this.spMenuItem.Visible = false;
            // 
            // genSPMenuItem
            // 
            this.genSPMenuItem.Name = "genSPMenuItem";
            this.genSPMenuItem.Size = new System.Drawing.Size(152, 26);
            this.genSPMenuItem.Text = "Generate";
            this.genSPMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Visible = false;
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Visible = false;
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.configurationToolStripMenuItem.Text = "Edit json files";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 714);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Conversion Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem spMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genSPMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAliasesToolStripMenuItem;
    }
}

