using System;
using System.ServiceProcess;
using System.Timers;

namespace FileListService
{
    /// <summary>
    /// Uncomment the code commented to run the service after lapse of 60000 milliseconds
    /// timer.Interval = 60000; implies that when timer ticks after 60000 milliseconds, event fires
    /// which fires the event handler delegate method OnElaspedListFiles
    /// timer.AutoReset=false; will run the service only once after lapse of 60000 milliseconds but
    /// service will take as much time as needed to complete the task 'OnElaspedListFiles'
    /// timer.AutoReset=true; will run the service again after lapse of 60000 milliseconds
    /// timer.Enabled=true allows timer to tick.
    /// </summary>
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
