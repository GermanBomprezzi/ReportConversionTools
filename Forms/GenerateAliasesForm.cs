using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReportConversionTools.Forms
{
    public partial class GenerateAliasesForm : Form
    {
        public GenerateAliasesForm()
        {
            InitializeComponent();

            txtScriptsFolder.Text = DEFAULT_PATH;

            ChangeControlsVisibility(false);
        }

        string[] filePaths;
        string wordToFind;
        const string DEFAULT_PATH = @"D:\Projects\Motility\InfinityW\Reports\DatabaseScripts";

        private void dgvAliases_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Control)
            {
                dgvAliases.Rows.Clear();

                string clipboard = Clipboard.GetText();
                string[] lines = clipboard.Split('\n');

                foreach (string line in lines)
                {
                    dgvAliases.Rows.Add(line);
                }
            }
        }

        private void dgvAliases_SelectionChanged(object sender, EventArgs e)
        {
            if (filePaths == null)
                return;

            dgvFiles.Rows.Clear();

            string wordToFind =
                (string)dgvAliases.Rows[dgvAliases.CurrentCell.RowIndex]
                .Cells[0]
                .Value;


            if (wordToFind.EndsWith("\r"))
                wordToFind = wordToFind.Remove(wordToFind.Length - 1);

            wordToFind = wordToFind.Replace(" ", string.Empty);
            wordToFind += " AS";

            this.wordToFind = wordToFind;

            foreach (string path in filePaths)
            {
                string[] lines = File.ReadAllLines(path);
                var enumerator = lines.GetEnumerator();

                foreach (string line in lines)
                {
                    if (line.Contains(wordToFind))
                    {
                        dgvFiles.Rows.Add(path);

                        break;
                    }
                }
            }

            if (dgvFiles.Rows.Count == 0)
                txtFile.Clear();

        }

        private void dgvAliases_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            LoadFilePaths();
        }

        private void dgvFiles_SelectionChanged(object sender, EventArgs e)
        {
            string sqlFile =
                (string)dgvFiles.Rows[dgvFiles.CurrentCell.RowIndex]
                .Cells[0]
                .Value;

            txtFile.Text = File.ReadAllText(sqlFile);

            int index = txtFile.Text.IndexOf(wordToFind);

            while (index != -1)
            {
                txtFile.Select(index, wordToFind.Length);
                txtFile.SelectionColor = Color.Red;

                txtFile.SelectionStart = index;
                txtFile.Focus();

                index = txtFile.Text.IndexOf(wordToFind, index + wordToFind.Length);

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScriptsFolder.Text))
            {
                LoadFilePaths();
            }
            else
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtScriptsFolder.Text = folderBrowserDialog.SelectedPath;
                        LoadFilePaths();
                    }

                }
            }

            if (!lblInvalidPath.Visible)
            {
                txtScriptsFolder.Enabled = false;
                btnSelect.Visible = false;
                btnReset.Visible = true;
            }

            ChangeControlsVisibility(!lblInvalidPath.Visible);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtScriptsFolder.Enabled = true;
            dgvAliases.Rows.Clear();
            dgvFiles.Rows.Clear();
            txtFile.Clear();

            btnReset.Visible = false;
            btnSelect.Visible = true;

            ChangeControlsVisibility(false);
        }

        private void LoadFilePaths()
        {
            try
            {
                filePaths = Directory.GetFileSystemEntries(txtScriptsFolder.Text, "*", SearchOption.AllDirectories)
                    .Where(s => s.Contains(".sql"))
                    .ToArray();

                if (filePaths.Count() == 0)
                {
                    lblInvalidPath.Text = "no sql files were found!";
                    lblInvalidPath.Visible = true;
                }
                else
                {
                    lblInvalidPath.Visible = false;
                }
            }
            catch (ArgumentException)
            {
                lblInvalidPath.Visible = true;
            }
            catch (DirectoryNotFoundException)
            {
                lblInvalidPath.Text = "directory not found!";
                lblInvalidPath.Visible = true;
            }
            catch (UnauthorizedAccessException)
            {
                lblInvalidPath.Text = "unauthorized asccess!";
                lblInvalidPath.Visible = true;
            }

        }

        private void ChangeControlsVisibility(bool state)
        {
            dgvAliases.Visible = state;
            dgvFiles.Visible = state;
            txtFile.Visible = state;
            lblTutorial2.Visible = state;
            lblTutorial3.Visible = state;
        }
    }
}