using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class SQLHighlightRichTextBox : RichTextBox
{
    private static readonly string[] keywords = {
        // Basic SQL keywords
        "SELECT", "FROM", "WHERE", "INSERT", "UPDATE", "DELETE", "CREATE", "ALTER", "DROP", "TABLE", "INDEX", "VIEW", "AS", "GO", "BEGIN",
        // Additional SQL functions
        "DECODE", "TRIM", "LTRIM", "RTRIM", "NVL", "COALESCE", "TO_DATE", "TO_CHAR", "TO_NUMBER",
        "SUBSTR", "INSTR", "LENGTH", "UPPER", "LOWER", "INITCAP", "ROUND", "TRUNC", "MOD",
        "SUM", "AVG", "COUNT", "MAX", "MIN", "GROUP BY", "HAVING", "ORDER BY", "CASE", "WHEN", "THEN", "ELSE", "END",
        "UNION", "INTERSECT", "MINUS", "JOIN", "INNER JOIN", "LEFT JOIN", "RIGHT JOIN", "FULL JOIN",
        "EXISTS", "IN", "LIKE", "BETWEEN", "IS NULL", "IS NOT NULL", "ISNULL"
    };

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        HighlightSQLSyntax();
    }

    private void HighlightSQLSyntax()
    {
        string text = this.Text;
        int selectionStart = this.SelectionStart;
        int selectionLength = this.SelectionLength;

        // Reset all text to default color
        this.SelectionStart = 0;
        this.SelectionLength = text.Length;
        this.SelectionColor = Color.Black;

        foreach (string keyword in keywords)
        {
            HighlightKeyword(text, keyword, Color.Blue);
        }

        // Highlight strings
        HighlightPattern(@"""[^""\\]*(?:\\.[^""\\]*)*""", Color.Red);
        HighlightPattern(@"'[^'\\]*(?:\\.[^'\\]*)*'", Color.Red);

        // Highlight comments
        HighlightPattern(@"--.*$", Color.Green, RegexOptions.Multiline);
        HighlightPattern(@"/\*[\s\S]*?\*/", Color.Green);

        // Highlight numbers
        HighlightPattern(@"\b\d+(\.\d+)?\b", Color.Purple);

        // Restore original selection
        this.SelectionStart = selectionStart;
        this.SelectionLength = selectionLength;
    }

    private void HighlightKeyword(string text, string keyword, Color color)
    {
        HighlightPattern($@"\b{keyword}\b", color, RegexOptions.IgnoreCase);
    }

    private void HighlightPattern(string pattern, Color color, RegexOptions options = RegexOptions.None)
    {
        Regex regex = new Regex(pattern, options);
        foreach (Match match in regex.Matches(this.Text))
        {
            this.SelectionStart = match.Index;
            this.SelectionLength = match.Length;
            this.SelectionColor = color;
        }
    }
}