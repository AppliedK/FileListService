using System;
using System.IO;

namespace FileListService
{
    internal class FilesList
    {
        private readonly string desktop;
        public FilesList()
        {
            desktop = @"C:\Users\dell\Desktop";
        }
        public void ListFiles()
        {
            var folderPath = Path.Combine(desktop, "Files");
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                WriteLog(file + " read at " + DateTime.Now.ToString());
            }
        }
        public void WriteLog(string message)
        {
            string filepath = Path.Combine(desktop, "list.txt");
            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                if (File.Exists(filepath))
                {
                    sw.WriteLine(message);
                }
            }
        }
    }
}
