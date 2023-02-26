using System;
using System.ServiceProcess;
using System.Timers;

namespace FileListService
{
    public partial class FileListService : ServiceBase
    {
        System.Timers.Timer timer;
        FilesList filesList;
        public FileListService()
        {
            InitializeComponent();
            //timer = new System.Timers.Timer();
            //timer.Enabled = true;
            //timer.Interval = 60000;
            //timer.AutoReset = false;
        }

        private void OnElaspedListFiles(object sender, ElapsedEventArgs e)
        {
            filesList = new FilesList();
            filesList.ListFiles();
        }

        protected override void OnStart(string[] args)
        {
            filesList = new FilesList();
            filesList.ListFiles();
            filesList.WriteLog("Service started at " + DateTime.Now.ToString());
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(OnElaspedListFiles);
        }

        protected override void OnStop()
        {
            //timer.Enabled = false;
            filesList.WriteLog("Service stopped at " + DateTime.Now.ToString());
        }
    }
}
