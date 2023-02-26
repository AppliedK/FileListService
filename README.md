# FileListService
Simple Windows Service. To list files contained inside 'Files' folder; the folder located at Desktop. 
The service can run with and without System.Timers.Timer class.

What is Windows Service?
Windows service is a program which runs in the background and the program has no user interface to interact with the users.
So, windows service is a background process. When Windows service is installed, the Process ID of the service can be found in the Services tab of Task Manager.
A Service has its name, description, status(Running, Disabled, Paused etc.) etc. We can set them during coding of the service.
When Service is installed, the service can be run in mode such as Manual or Automatic. Service Status can be Start, Stop, Pause, Resume, Restart etc.

How to install a Windows Service using ?
We can install a Windows Service using 'Developer Command Prompt' of Visual Studio or by using CMD.
Run the Visual Studio as Administrator. Buid the application. 
Open the Developer Command Prompt by following the steps Tools > Command Line > Developer Command Prompt
The Developer Command Prompt can be openrun separately from Visual Studio in older versions of Visual Studio.
Type the command installutil -i <full path of the application exe file> in the Developer Command Prompt and press Enter.
If application is built correctly, the service will get installed.
In case of CMD, when CMD is open, we go to the path of installutil.exe using CMD command. The syntax is as follows.
CD <path of installutil> 
The path of installutil.exe is C:\Windows\Microsoft.NET\Framework\v4.0.30319
C:\Windows\Microsoft.NET\Framework\v4.0.30319> installutil -i <full path of the service application exe file>
To get the full path of the application exe file, go inside the bin folder of the project. If project is build in Debug/Release mode, then go to Debug/Release folder.
For example, C:\Users\dell\Desktop\Learn Windows Service\FileListService\bin\Debug\FileListService.exe is the path of the exe at my system.
Precautions Before Service Installation
Run the CMD or Visual Studio as Administrator.
The project must have used 'Add Installer' during application development.
Project is 'build' or 'ReBuild'



