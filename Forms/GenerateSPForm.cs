using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ReportConversionTools.Forms
{
    public partial class GenerateSPForm : Form
    {
        //private SQLHighlightRichTextBox sqlRichTextBox;

        public GenerateSPForm()
        {
            InitializeComponent();

            txtDictionaryFolder.Text = DEFAULT_PATH;
            txtClassPath.Text = DEFAULT_CLASS_PATH;

            paramDataTable.Columns.Add("Name", typeof(string));
            paramDataTable.Columns.Add("Description", typeof(string));
            paramDataTable.Columns.Add("WhereClause", typeof(string));

            //txtSQL.Text = File.ReadAllText(CONSTANTS.SP_DEFAULT_PATH);
            //txtSQL.Focus();

            lblSearchParam.Visible = false;
            txtSearchParam.Visible = false;
            dgvParameters.Visible = false;
            lblTutorial3.Visible = false;
            txtClass.Visible = false;


            //sqlRichTextBox = new SQLHighlightRichTextBox
            //{
            //    Dock = DockStyle.Fill,
            //    Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            //};

            //this.Controls.Add(sqlRichTextBox);

            //this.txtSQL.TextChanged += new System.EventHandler(this.txtSQL_TextChanged);


        }

        const string DEFAULT_PATH = @"ReportParameters.cs";
        const string DEFAULT_CLASS_PATH = @"ReportClass.vb";
        const string FIRST_LINE_OF_THE_DICTIONARY = "//PARAMETERS_START-->";
        const string LAST_LINE_OF_THE_DICTIONARY = "//<--PARAMETERS_END";

        const string FIRST_LINE_OF_THE_CLASS = "Private Function CreateFilter()";
        const string LAST_LINE_OF_THE_CLASS = "End Function";

        DataTable paramDataTable = new DataTable();

        private void btnSelect_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtDictionaryFolder.Text))
            {
                ReadDictionary();
            }
            else
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtDictionaryFolder.Text = folderBrowserDialog.SelectedPath;

                        ReadDictionary();
                    }

                }
            }

            ReadClass();

            ProcessSelect();
        }

        private void ProcessSelect()
        {
            if (!lblInvalidDictPath.Visible && !lblInvalidClassPath.Visible)
            {
                btnReset.Visible = true;
                btnSelect.Visible = false;

                ChangeControlsVisibility(true);
            }
        }

        private void ReadDictionary()
        {
            string[] lines = null;

            ReadAllLines(ref lines, txtDictionaryFolder.Text, lblInvalidDictPath);

            if (lines == null)
                return;

            var startLineIndex = Array.FindIndex(lines, line => line.Contains(FIRST_LINE_OF_THE_DICTIONARY));
            var endLineIndex = Array.FindIndex(lines, line => line.Contains(LAST_LINE_OF_THE_DICTIONARY));

            if (startLineIndex == -1 || endLineIndex == -1)
                return;

            paramDataTable.Clear();

            for (int i = startLineIndex + 1; i < endLineIndex; i++)
            {
                var currentLine = lines[i].Split('"');

                var nameIndex = Array.FindIndex(currentLine, c => c.Contains("{")) + 1;
                var descriptionIndex = Array.FindIndex(currentLine, c => c.Trim().Contains("Description=")) + 1;
                var whereClauseIndex = Array.FindIndex(currentLine, c => c.Trim().Contains("WhereClause=")) + 1;

                paramDataTable.Rows.Add(
                    nameIndex != 0
                        ? $"@{currentLine[nameIndex]}"
                        : "",

                    descriptionIndex != 0
                        ? currentLine[descriptionIndex]
                        : "",

                    whereClauseIndex != 0
                        ? currentLine[whereClauseIndex]
                        : "");

            }

            dgvParameters.DataSource = paramDataTable;

        }

        private void ReadClass()
        {
            string[] lines = null;

            ReadAllLines(ref lines, txtClassPath.Text, lblInvalidClassPath);

            if (lines == null)
                return;

            var startLineIndex = Array.FindIndex(lines, line => line.Contains(FIRST_LINE_OF_THE_CLASS));
            var endLineIndex = Array.FindIndex(lines, line => line.Contains(LAST_LINE_OF_THE_CLASS));

            if (startLineIndex == -1 || endLineIndex == -1)
                return;

            txtSQL.Clear();

            for (int i = startLineIndex + 1; i < endLineIndex; i++)
            {
                txtClass.AppendText(lines[i] + "\n");
            }
        }

        private Exception ReadAllLines(ref string[] lines, string path, Label errorLabel)
        {
            try
            {
                lines = File.ReadAllLines(path);
            }
            catch (ArgumentException)
            {
                errorLabel.Visible = true;
            }
            catch (DirectoryNotFoundException)
            {
                errorLabel.Text = "directory not found!";
                errorLabel.Visible = true;
            }
            catch (UnauthorizedAccessException)
            {
                errorLabel.Text = "unauthorized asccess!";
                errorLabel.Visible = true;
            }
            catch (FileNotFoundException)
            {
                errorLabel.Text = "file not found!";
                errorLabel.Visible = true;
            }

            errorLabel.Visible = false;

            return null;
        }


        private void txtSearchParam_TextChanged(object sender, EventArgs e)
        {
            SearchParameter();
        }


        private void SearchParameter()
        {
            string searchParam = txtSearchParam.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchParam))
            {
                dgvParameters.DataSource = paramDataTable;
            }
            else
            {
                DataView dataView = new DataView(paramDataTable);

                dataView.RowFilter = $"Name LIKE '%{searchParam}%' OR Description LIKE '%{searchParam}%'";

                dgvParameters.DataSource = dataView;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Visible = false;
            btnSelect.Visible = true;

            ChangeControlsVisibility(false);
        }

        private void ChangeControlsVisibility(bool state)
        {
            lblSearchParam.Visible = state;
            txtSearchParam.Visible = state;
            dgvParameters.Visible = state;
            lblTutorial3.Visible = state;
            txtClass.Visible = state;

            txtDictionaryFolder.Enabled = !state;
            txtClassPath.Enabled = !state;
        }
    }
}
