using System.Windows.Forms;

namespace ReportConversionTools.Resources
{
    public static class CONSTANTS
    {
        public const string DEFAULT_SRPT = "DEFAULT_SRPT";
        public const string DEFAULT_TABLE = "DEFAULT_TABLE";
        public const string DEFAULT_VIEW = "DEFAULT_VIEW";
        public const string DEFAULT_COLUMNS = "DEFAULT_COLUMNS";
        public const string DEFAULT_SELECT = "DEFAULT_SELECT";
        public const string DEFAULT_WHERE = "DEFAULT_WHERE";
        public const string DEFAULT_PARAMS = "DEFAULT_PARAMS";


        public const string VIEW_STRUCTURE = "\n\tSELECT * INTO #DEFAULT_TABLE \n\tFROM [DEFAULT_VIEW] \n\tWHERE 1 = 0\n\n\t";
        public const string CREATE_TABLE_STRUCTURE = "\n\tCREATE TABLE #DEFAULT_TABLE (\n\t\tDEFAULT_COLUMNS\n\t)\n\t\n\t";

#if DEBUG
        public const string CONFIG_FILES_PATH_ROOT = "../../Resources/";
#else
        public static string CONFIG_FILES_PATH_ROOT = Application.StartupPath + "/Resources/";
#endif
        public static string PARAMS_JSON_PATH = CONFIG_FILES_PATH_ROOT + "params.json";
        public static string COLUMNS_JSON_PATH = CONFIG_FILES_PATH_ROOT + "columns.json";
        public static string WHERES_JSON_PATH = CONFIG_FILES_PATH_ROOT + "wheres.json";
        public static string SP_DEFAULT_PATH = CONFIG_FILES_PATH_ROOT + "sp_default.sql";

        public const string COLUMNS = "COLUMNS";
        public const string PARAMS = "PARAMS";
        public const string WHERES = "WHERES";

        public const string NAME = "NAME";
        public const string DEFINITION = "DEFINITION";

        public const string GENERATE = "GENERATE";
        public const string REFRESH = "REFRESH";
    }
}
