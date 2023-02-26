using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileListService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// The Main method is executed first as entry point of the program
        /// The windows service is a class which derives all the properties and methods of
        /// ServiceBase class. Here we use array of ServiceBase variable named as ServicesToRun
        /// and initializes the ServicesToRun. The static method Run of ServiceBase class runs 
        /// all the service objects used to initialize the ServicesToRun variable.
        /// We could have just created a ServiceBase variable 'ServiceToRun' and initialized it 
        /// with ServicesToRun= new FileListService(); Then ServiceBase.Run(ServiceToRun);
        /// This will also work.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new FileListService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
