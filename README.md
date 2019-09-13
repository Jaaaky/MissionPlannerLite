MissionPlannerLite
==============

MissionPlannerLite aims to be a light - lite - version of MissionPlanner that:

1. Runs as fast as possible on both Windows and Linux and doesn’t get slower when used for long.
2. Doesn’t collect/store data or do any sluggish background tasks
3. Supports Linux better - final target is to be as native to Linux as possible. Now it already runs faster on wine or mono.
4. Only includes features for real flights - no simulator, telemtery configurator or other secondary features that makes MissionPlanner very slow and sluggish when doing actual critical work.
5. Not a replacement, as you’d need MissionPlanner for seconday or rarely used features.

Lite patches/commits lives at MissionPlannerLite branch.
 
Now it could already be compiled on Linux using `https://www.mono-project.com/download/stable/`

After installation goes to MissionPlannerLite directory and run
`git checkout MissionPlannerLite`

`msbuild -r MissionPlanner.sln /t:MissionPlanner 
/p:Configuration=Release,Optimize=true,DebugSymbols=false 
/p:BuildProjectReferences=true`

Note: You've to use a case-insensitive filesystem on Linux. Or you can use WSL as it's case-insensitive by default.
Note: It could of course be compiled using Visual Studio normally.

Feedback is welcome :)

Original MissionPlanner Readme
==============

[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/ArduPilot/MissionPlanner?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Build status](https://ci.noaa.io/api/projects/status/2c5tbxr2wvcguihp?svg=true)](https://ci.noaa.io/project/meee1/missionplanner)

Website : http://ardupilot.org/planner/  
  
Forum : http://discuss.ardupilot.org/c/ground-control-software/mission-planner
  
Download latest stable version : http://firmware.ardupilot.org/Tools/MissionPlanner/MissionPlanner-latest.msi
  
Changelog : https://github.com/ArduPilot/MissionPlanner/blob/master/ChangeLog.txt  
  
License : https://github.com/ArduPilot/MissionPlanner/blob/master/COPYING.txt  


How to compile
==============

1. Install software

- Git
  https://git-for-windows.github.io/
  Select a file summarized as "Full installer for official Git for Windows"
   with the highest version
- TortoiseGit
  https://tortoisegit.org/
- Visual Studio
  http://www.visualstudio.com/downloads/download-visual-studio-vs
  Select "Visual Studio Community 2017 for Windows Desktop" version 15.3 or newer (to include .NET standard 2.0).
- Microsoft .NET 4.0
- .NET standard 2.0

2. Check out

- Create an empty folder anywhere
- In explorer left click and select "Git Clone"
  set URL https://github.com/ArduPilot/MissionPlanner
  OK

3. Build

- Open MissionPlanner.sln with Visual Studio 2017 for windows desktop.
- Compile.


-----------MONO-------------

run using 
mono MissionPlanner.exe

run debuging
MONO_LOG_LEVEL=debug mono MissionPlanner.exe

you need prereq's
sudo apt-get install mono-runtime libmono-system-windows-forms4.0-cil libmono-system-core4.0-cil libmono-winforms2.0-cil libmono-corlib2.0-cil libmono-system-management4.0-cil libmono-system-xml-linq4.0-cil


[![FlagCounter](https://s01.flagcounter.com/count2/A4bA/bg_FFFFFF/txt_000000/border_CCCCCC/columns_8/maxflags_40/viewers_0/labels_1/pageviews_0/flags_0/percent_0/)](https://info.flagcounter.com/A4bA)

