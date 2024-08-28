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
    public partial class GenerateStoreProcedureForm : Form
    {
        public GenerateStoreProcedureForm()
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
                // read all columns
                readText = File.ReadAllText(CONSTANTS.COLUMNS_JSON_PATH);
                deserializedText = JsonConvert.DeserializeObject<List<Root>>(readText);
                dgvColumns.DataSource = deserializedText;

                // read all params
                readText = File.ReadAllText(CONSTANTS.PARAMS_JSON_PATH);
                deserializedText = JsonConvert.DeserializeObject<List<Root>>(readText);
                dgvParams.DataSource = deserializedText;

                // read all wheres
                readText = File.ReadAllText(CONSTANTS.WHERES_JSON_PATH);
                deserializedText = JsonConvert.DeserializeObject<List<Root>>(readText);
                dgvWheres.DataSource = deserializedText;

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
            txtSPName.Text = "SP_Name_Test";
            txtTempTableName.Text = "TempTable_Name_Test";
            txtViewName.Text = "View_Name_Test";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            DataGridViewRow selectedRow = dgv.SelectedRows[0];
            processRowSelection(selectedRow: selectedRow);
        }

        private void txtSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
            {
                /// tabControl1.SelectedIndex
                /// 0 = Params
                /// 1 = Columns
                /// 2 = Wheres

                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        ifTextExistsThenProcessRowSelection(dgvParams.Rows, searchText: $"@{txtSearch.Text}");
                        break;
                    case 1:
                        ifTextExistsThenProcessRowSelection(dgvColumns.Rows, searchText: txtSearch.Text);
                        break;
                    case 2:
                        ifTextExistsThenProcessRowSelection(dgvWheres.Rows, searchText: txtSearch.Text);
                        break;
                    default:
                        break;
                }
            }
        }

        public void ifTextExistsThenProcessRowSelection(DataGridViewRowCollection rows, string searchText)
        {
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[1].Value.ToString().ToUpper().Equals(searchText.ToUpper()))
                {
                    processRowSelection(selectedRow: row);

                    txtSearch.Focus();

                    lblSearch.Visible = true;

                    return;
                }
            }

            lblSearch.Visible = false;
        }

        private void processRowSelection(DataGridViewRow selectedRow)
        {
            // the selected row was previously selected
            if (selectedRow.DefaultCellStyle.BackColor == Color.LightGreen)
            {
                selectedRow.DefaultCellStyle.BackColor = Color.White;
                selectedRow.Cells[0].Value = false;
            } // the selected row wasn't previously selected
            else
            {
                selectedRow.DefaultCellStyle.BackColor = Color.LightGreen;
                selectedRow.Cells[0].Value = true;
            }

            selectedRow.Selected = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (btnGenerate.Text == CONSTANTS.GENERATE)
            {
                if (!checkRequires()) return;

                generateStoreProcedure();

                btnGenerate.Text = CONSTANTS.REFRESH;
                txtSPName.Enabled = false;
                txtTempTableName.Enabled = false;
                txtViewName.Enabled = false;
                txtSearch.Enabled = false;
                tabControl1.Enabled = false;
                chkCreateTempTableUsingView.Enabled = false;
            }
            else
            {
                loadConfigFiles();

                tabControl1.SelectedIndex = 0;

                btnGenerate.Text = CONSTANTS.GENERATE;
                txtSPName.Enabled = true;
                txtTempTableName.Enabled = true;
                txtViewName.Enabled = true;
                txtSearch.Enabled = true;
                tabControl1.Enabled = true;
                chkCreateTempTableUsingView.Enabled = true;

                txtSPName.Clear();
                txtViewName.Clear();
                txtTempTableName.Clear();
                txtSearch.Clear();
                lblSearch.Visible = false;
            }


        }

        private bool checkRequires()
        {
            lblReqSPName.Visible = string.IsNullOrEmpty(txtSPName.Text) ? true : false;
            lblReqTempTableName.Visible = string.IsNullOrEmpty(txtTempTableName.Text) ? true : false;
            lblReqViewName.Visible = string.IsNullOrEmpty(txtViewName.Text) ? true : false;

            if (lblReqSPName.Visible
                || lblReqTempTableName.Visible
                || lblReqViewName.Visible
               )
                return false;

            return true;
        }

        private void generateStoreProcedure()
        {
            replaceDefaultText(CONSTANTS.DEFAULT_SRPT, txtSPName.Text);
            replaceDefaultText(CONSTANTS.DEFAULT_TABLE, txtTempTableName.Text);
            replaceDefaultText(CONSTANTS.DEFAULT_VIEW, txtViewName.Text);

            string formattedText;

            formattedText = writeLine(rows: dgvParams.Rows);
            replaceDefaultText(CONSTANTS.DEFAULT_PARAMS, formattedText);

            formattedText = writeLine(rows: dgvColumns.Rows);
            replaceDefaultText(CONSTANTS.DEFAULT_COLUMNS, formattedText);

            formattedText = writeLine(rows: dgvColumns.Rows, format: CONSTANTS.NAME);
            replaceDefaultText(CONSTANTS.DEFAULT_SELECT, formattedText);

            formattedText = writeLine(rows: dgvWheres.Rows, format: CONSTANTS.DEFINITION);
            replaceDefaultText(CONSTANTS.DEFAULT_WHERE, formattedText);
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

        private void chkCreateTempTableUsingView_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreateTempTableUsingView.Checked)
                txtResult.Text = txtResult.Text.Replace(
                    CONSTANTS.CREATE_TABLE_STRUCTURE    ,
                    CONSTANTS.VIEW_STRUCTURE);
            else
                txtResult.Text = txtResult.Text.Replace(
                    CONSTANTS.VIEW_STRUCTURE,
                    CONSTANTS.CREATE_TABLE_STRUCTURE);
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.TabStop = false;
        }
    }
}