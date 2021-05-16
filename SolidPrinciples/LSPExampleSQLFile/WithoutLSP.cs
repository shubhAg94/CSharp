using System;
using System.Collections.Generic;
using System.Text;

//https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
namespace LSPExampleSQLFile
{
    //Without LSP
    public class SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            string str = "Test";
            /* Code to read text from sql file */
            return str;
        }

        public string SaveText()
        {
            string str = "Test";
            /* Code to save text into sql file */
            return str;
        }
    }
    public class SqlFileManager
    {
        public List<SqlFile> lstSqlFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in lstSqlFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                objFile.SaveText();
            }
        }
    }
}
