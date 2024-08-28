using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ReportConversionTools.Models;
using ReportConversionTools.Resources;

namespace ReportConversionTools.Forms
{
    public partial class GenerateTestForm : Form
    {
        public GenerateTestForm()
        {
            InitializeComponent();
        }

        private void GenerateStoreProcedureForm_Load(object sender, EventArgs e)
        {
            loadConfigFiles();

#if DEBUG
            debugParameters();
#endif
        }

        private void loadConfigFiles()
        {
            string readText;
            List<Root> deserializedText;

            try
            {
                // read default text
                readText = File.ReadAllText(CONSTANTS.SP_DEFAULT_PATH);
                txtResult.Text = readText;
            }
            catch (FileNotFoundException)
            {
                throw;
            }

        }

        private void debugParameters()
        {
            txtReportName.Text = "Report_Name_Test";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (btnGenerate.Text == CONSTANTS.GENERATE)
            {
                if (!checkRequires()) return;

                generateStoreProcedure();

                btnGenerate.Text = CONSTANTS.REFRESH;
                txtReportName.Enabled = false;
            }
            else
            {
                loadConfigFiles();

                btnGenerate.Text = CONSTANTS.GENERATE;
                txtReportName.Enabled = true;

                txtReportName.Clear();
 
            }


        }

        private bool checkRequires()
        {
            lblReqReportName.Visible = string.IsNullOrEmpty(txtReportName.Text) ? true : false;

            if (lblReqReportName.Visible)
                return false;

            return true;
        }

        private void generateStoreProcedure()
        {
            replaceDefaultText(CONSTANTS.DEFAULT_SRPT, txtReportName.Text);

            string formattedText;

            //formattedText = writeLine(rows: dgvParams.Rows);
            //replaceDefaultText(CONSTANTS.DEFAULT_PARAMS, formattedText);
        }

        private string writeLine(DataGridViewRowCollection rows, string format = null)
        {
            string name;
            string definition;
            string formattedText = string.Empty;
            foreach (DataGridViewRow row in rows)
            {
                if (row.DefaultCellStyle.BackColor != Color.LightGreen)
                    continue;

                name = (string)row.Cells[1].Value;
                definition = (string)row.Cells[2].Value;
                switch (format)
                {
                    case CONSTANTS.NAME:
                        formattedText += $"{name},\n\t\t";
                        break;
                    case CONSTANTS.DEFINITION:
                        formattedText += $"{definition}\n\t\t";
                        break;
                    default:
                        formattedText += $"{name} {definition.ToUpper()},\n\t\t";
                        break;
                }
            }

            if (formattedText.Length != 0 && (format == null || format == CONSTANTS.NAME))
            {
                formattedText = removeLastComma(oldText: formattedText);
            }

            return formattedText;
        }

        private void replaceDefaultText(string oldText, string newText)
        {
            switch (oldText)
            {
                case CONSTANTS.DEFAULT_SRPT:
                    txtResult.Text = txtResult.Text.Replace(oldText, newText);
                    break;
                case CONSTANTS.DEFAULT_TABLE:
                    txtResult.Text = txtResult.Text.Replace(oldText, newText);
                    break;
                case CONSTANTS.DEFAULT_VIEW:
                    txtResult.Text = txtResult.Text.Replace(oldText, newText);
                    break;
                case CONSTANTS.DEFAULT_COLUMNS:
                    txtResult.Text = txtResult.Text.Replace(oldText, newText);
                    break;
                case CONSTANTS.DEFAULT_SELECT:
                    txtResult.Text = txtResult.Text.Replace(oldText, newText);
                    break;
                case CONSTANTS.DEFAULT_WHERE:
                    txtResult.Text = txtResult.Text.Replace(oldText, newText);
                    break;
                case CONSTANTS.DEFAULT_PARAMS:
                    txtResult.Text = txtResult.Text.Replace(oldText, newText);
                    break;
                default:
                    break;
            }
        }

        private string removeLastComma(string oldText)
        {
            return oldText.Substring(0, oldText.Length - 4);
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.TabStop = false;
        }
    }
}