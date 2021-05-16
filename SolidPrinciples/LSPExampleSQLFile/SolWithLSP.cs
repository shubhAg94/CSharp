using System;
using System.Collections.Generic;
using System.Text;


//https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
namespace LSPExampleSQLFile
{
    public interface IReadableSqlFile
    {
        string LoadText();
    }
    public interface IWritableSqlFile
    {
        void SaveText();
    }

    //Now we implement IReadableSqlFile through the ReadOnlySqlFile class that reads only the text from read-only files.
    public class ReadOnlySqlFile_WithLSP : IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            string str = "Test";
            /* Code to read text from sql file */
            return str;
        }
    }

    //Here we implement both IWritableSqlFile and IReadableSqlFile in a SqlFile class by which we can read and write files.
    public class SqlFile_WithLSP : IWritableSqlFile, IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            string str = "Test";
            /* Code to read text from sql file */
            return str;
        }
        public void SaveText()
        {
            /* Code to save text into sql file */
        }
    }

    //Now the design of the SqlFileManager class becomes like this:
    public class SqlFileManager_WithLSP
    {
        public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in aLstReadableFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
        {
            foreach (var objFile in aLstWritableFiles)
            {
                objFile.SaveText();
            }
        }
    }
}
