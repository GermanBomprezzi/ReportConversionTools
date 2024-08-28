using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ReportConversionTools.Models;
using ReportConversionTools.Resources;

namespace ReportConversionTools.Forms
{
    public partial class CRUDConfigFilesForm : Form
    {
        private string cboxFileSelectedItem;
        private string filePath;

        public CRUDConfigFilesForm()
        {
            InitializeComponent();
        }

        private void cboxFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxFileSelectedItem = cboxFile.SelectedItem.ToString().ToUpper();
            filePath = $"{CONSTANTS.CONFIG_FILES_PATH_ROOT}{cboxFileSelectedItem}.json";

            loadConfigFiles();
        }

        private void loadConfigFiles()
        {
            cboxFile.TabStop = false;

            string readText;
            try
            {
                readText = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException)
            {
                cboxFile.TabStop = true;
                throw;
            }

            List<Root> deserializedText = JsonConvert.DeserializeObject<List<Root>>(readText);

            dgvFile.DataSource = deserializedText;

            clearTextBoxes();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dgvFile.DataSource == null)
                return;

            Cursor = Cursors.WaitCursor;

            string jsonToFile = JsonConvert.SerializeObject(dgvFile.DataSource, Formatting.Indented);
            File.WriteAllText(filePath, jsonToFile);

            Cursor = Cursors.Default;

            MessageBox.Show(
                $"{cboxFileSelectedItem}.json was edited successfully!",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void txtName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
            {
                // complete both textboxes if the name already exists
                DataGridViewRow row = checkIfNameAlreadyExists(txtName.Text);
                if (row != null)
                {
                    txtName.Text = row.Cells[0].Value.ToString();
                    txtDefinition.Text = row.Cells[1].Value.ToString();
                    txtDefinition.SelectionStart = txtDefinition.TextLength;
                    txtDefinition.ScrollToCaret();
                }
            }
        }

        private void txtDefinition_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (dgvFile.DataSource == null)
                return;

            if (string.IsNullOrEmpty(txtDefinition.Text) || string.IsNullOrEmpty(txtName.Text))
                return;

            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
            {
                updateOrCreateRow();
            }

        }

        private void updateOrCreateRow()
        {
            DataGridViewRow row = checkIfNameAlreadyExists(txtName.Text);

            // all the param and column definitions should be in capital letters
            if (cboxFileSelectedItem != CONSTANTS.WHERES)
                txtDefinition.Text = txtDefinition.Text.ToUpper();

            if (row != null)
            {
                // update an existing row
                row.Cells[1].Value = txtDefinition.Text;
                clearTextBoxes();
            }
            else
            {
                // all the param names should start with @
                if (cboxFileSelectedItem == CONSTANTS.PARAMS && !txtName.Text.StartsWith("@"))
                    txtName.Text = $"@{txtName.Text}";

                // create a new row
                List<Root> ds = (List<Root>)dgvFile.DataSource;
                txtDefinition.Text = txtDefinition.Text.ToUpper();
                ds.Add(new Root { Name = txtName.Text, Definition = txtDefinition.Text });
                refreshDataSource(ds);
            }
        }

        private DataGridViewRow checkIfNameAlreadyExists(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            name = name
                .Replace("@", string.Empty)
                .Replace(" ", string.Empty)
                .ToUpper();

            // the param names always start with @
            if (cboxFileSelectedItem == CONSTANTS.PARAMS)
                name = $"@{name}";

            foreach (DataGridViewRow row in dgvFile.Rows)
            {
                if (row.Cells[0].Value.ToString().ToUpper().Equals(name))
                {
                    return row;
                }
            }

            return null;
        }

        private void clearTextBoxes()
        {
            txtName.Clear();
            txtDefinition.Clear();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (cboxFileSelectedItem == CONSTANTS.PARAMS)
            {
                if (!txtName.Text.StartsWith("@"))
                {
                    txtName.Text = $"@{txtName.Text}";
                }
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            DataGridViewRow selectedRow = dgv.SelectedRows[0];
            txtName.Text = (string)selectedRow.Cells[0].Value;
            txtDefinition.Text = (string)selectedRow.Cells[1].Value;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFile.Rows)
            {
                if (row.Cells[0].Value.Equals(txtName.Text))
                {
                    List<Root> ds = (List<Root>)dgvFile.DataSource;
                    ds.RemoveAt(row.Index);
                    refreshDataSource(ds);
                }
            }

        }

        private void refreshDataSource(List<Root> ds)
        {
            dgvFile.DataSource = null;
            dgvFile.DataSource = ds;
            clearTextBoxes();
        }


    }
}
