using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReportConversionTools.Forms
{
    public partial class SearchAliasesForm : Form
    {
        public SearchAliasesForm()
        {
            InitializeComponent();

            txtScriptsFolder.Text = DEFAULTPATH;

            ChangeControlsVisibility(false);
        }

        string[] FILEPATHS;
        string WORDTOFIND;
        string DEFAULTPATH = @"D:\Projects\Motility\InfinityW\Reports\DatabaseScripts";

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
            if (FILEPATHS == null)
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

            WORDTOFIND = wordToFind;

            foreach (string path in FILEPATHS)
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

            int index = txtFile.Text.IndexOf(WORDTOFIND);

            while (index != -1)
            {
                txtFile.Select(index, WORDTOFIND.Length);
                txtFile.SelectionColor = Color.Red;

                txtFile.SelectionStart = index;
                txtFile.Focus();

                index = txtFile.Text.IndexOf(WORDTOFIND, index + WORDTOFIND.Length);

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            bool pathsLoaded = false;

            if (!string.IsNullOrEmpty(txtScriptsFolder.Text))
            {
                pathsLoaded = LoadFilePaths();
            }
            else
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtScriptsFolder.Text = folderBrowserDialog.SelectedPath;
                        pathsLoaded = LoadFilePaths();
                    }

                }
            }

            if (pathsLoaded)
            {
                txtScriptsFolder.Enabled = false;
                btnSelect.Visible = false;
                btnReset.Visible = true;
            }

            ChangeControlsVisibility(pathsLoaded);
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

        private bool LoadFilePaths()
        {
            try
            {
                FILEPATHS = Directory.GetFileSystemEntries(txtScriptsFolder.Text, "*", SearchOption.AllDirectories)
                    .Where(s => s.Contains(".sql"))
                    .ToArray();

                if (FILEPATHS.Count() == 0)
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


            // lblInvalidPath.Visible = false => Loaded successfully.
            // lblInvalidPath.Visible = true => Failed to load.
            return !lblInvalidPath.Visible;

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