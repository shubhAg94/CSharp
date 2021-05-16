using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
namespace LSPExampleSQLFile
{
    //Problem Without LSP on enhancement
    /// <summary>
    /// OK. We are done with our part. The functionality looks good for now. After some time our lead might tell us 
    /// that we may have a few read-only files in the application folder, so we need to restrict the flow whenever it tries to do a save on them.
    ///OK.We can do that by creating a "ReadOnlySqlFile" class that inherits the "SqlFile" class and 
    ///we need to alter the SaveTextIntoFiles() method by introducing a condition to prevent calling the SaveText() method on ReadOnlySqlFile instances.
    /// </summary>
    public class SqlFile1
    {
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
    public class ReadOnlySqlFile : SqlFile1
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
            /* Throw an exception when app flow tries to do save. */
            throw new IOException("Can't Save");
        }
    }

    //To avoid an exception we need to modify "SqlFileManager" by adding one condition to the loop.
    public class SqlFileManager1
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
                //Check whether the current file object is read only or not.If yes, skip calling it's  
                // SaveText() method to skip the exception.  

                if (objFile is ReadOnlySqlFile)
                    objFile.SaveText();
            }
        }
    }

    //Here we altered the SaveTextIntoFiles() method in the SqlFileManager class to determine 
    //whether or not the instance is of ReadOnlySqlFile to avoid the exception. 
    //We can't use this ReadOnlySqlFile class as a substitute of its parent without altering SqlFileManager code. 
    //So we can say that this design is not following LSP. Let's make this design follow the LSP. 
    //Here we will introduce interfaces to make the SqlFileManager class independent from the rest of the blocks.
}
