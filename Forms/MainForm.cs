using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportConversionTools.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<GenerateTestForm>().Count() == 1)
            {
                MessageBox.Show(
                    "Editing the configuration files while the SP generator is open is not allowed!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (Application.OpenForms.OfType<CRUDConfigFilesForm>().Count() == 0)
            {
                CRUDConfigFilesForm configFilesForm = new CRUDConfigFilesForm();
                configFilesForm.MdiParent = this;
                configFilesForm.Show();
            }

        }

        private void generateAliasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<GenerateAliasesForm>().Count() == 0)
            {
                GenerateAliasesForm searchAliasesForm = new GenerateAliasesForm();
                searchAliasesForm.MdiParent = this;
                searchAliasesForm.Show();
            }
        }


        private void generateSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<GenerateSPForm>().Count() == 0)
            {
                GenerateSPForm generateSPForm = new GenerateSPForm();
                generateSPForm.MdiParent = this;
                generateSPForm.Show();
            }
        }
    }
}
