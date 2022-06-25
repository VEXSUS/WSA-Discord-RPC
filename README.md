<a href="url"><img src="https://i.imgur.com/Z719RMu.png" align="left" height="64" width="64" ></a>

# Introducing - WSA Discord RPC ! 

Discord Rich presence for Windows Subsystem for Android. Created with love in germany by R4D1 Software 💖

# Installation

First, you need to download the latest installer from the [Releases](https://github.com/VEXSUS/WSA-Discord-RPC/releases/tag/1.4.0_stable) tab. There you can choose between pre-release and stable release versions. (At the moment only stable version is available. Windows Insider and pre-release versions will be released soon)

## Windows 11 Registry
As of version 1.4.0, the WSA Discord RPC uses a method of writing values to an .ini file. We have abandoned the use of the Windows 11 registry for security reasons. The program continues to run in administrator mode due to the fact that it needs to remove remnants that were left in the registry after the previous installation. Because the previous uninstallers of the program do not remove the registry entries with these values.

* OneDriveSync - This value is used to sync with the "OneDrive" folder in Windows 11.
* OneDriveDIR - The path to your OneDrive folder
* InstallationID - This value will allow future identification of the given installation on the user's computer. This way, if the user is sending diagnostic data, we will know exactly who is sending it, without the need to know their for example serial numbers, ip address etc. Each installation id is UNIQUE !
* RunOnProgramStartup - This registry entry is responsible for whether or not you want the status to appear on discord when you run the program. (By default this feature is enabled after initial setup).
* TrayMode - Value which checks at program startup whether to enter "Tray Mode".

## Screenshots
* While Windows Subsystem for Android is enabled but nothing is running. (Idling) 💤😴

![](https://i.imgur.com/MSTHchm.png)

* While Windows Subsystem for Android settings is enabled

![](https://i.imgur.com/Rmm7cYl.png)

* While Windows Subsystem for Android is enabled but an application is running, for example "Amazon Appstore".

![](https://i.imgur.com/024F25C.png)

* App-specific support for changing the Discord Rich Presence image to the app's logo. Currently these applications support this option:
```
Amazon Appstore, F-Droid, Termux, Facebook and Facebook Lite, Messenger, 
Google Authenticator, Twitch, Twitter and Twitter Lite
```

* If you wonder where the program menu is, find the program icon in the taskbar and right-click on it 😎
* Refreshed tray menu with Windows 11 rounded corners ! 💙

![](https://i.imgur.com/yTKbRZt.png)

* Larger graphical menu (refreshed!) 💞

![](https://i.imgur.com/4A00326.png)

## Roadmap (2022/06 - 2022/07)

- [x] Greater code optimization.
- [x] Fixing of known bugs.
- [ ] [⚠️ IN V2 Version] Adding the ability to style Discord Rich Presence separately for each application. (Users will be able to create their own discord api on [https://discordapp.com/developers](https://discordapp.com/developers) and implement it in registry or config file).
- [x] Adding the creation of a configuration file so that the user can edit the program parameters more easily.
- [ ] [⚠️ IN V2 Version] Adding an intelligent and self-learning program update system. The update system will check which program compilation number fits your current operating system.

## Known issues
Known issues are available under [Releases](https://github.com/VEXSUS/WSA-Discord-RPC/releases/tag/1.4.0_stable). When we release the latest build of an application, we also include what doesn't work or what could potentially not work at all or not properly.


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

# License
Copyright ©️ R4D1 Software 2022-2023 - All Rights Reserved
Unauthorized copying of this source code through any medium for
commercial purposes without notifying the code author is strictly prohibited.
Forking the project on Github is allowed.
Removing author credits in the program and code is prohibited.
If any of these rules are directly violated. There may be legal consequences.
Written by Michał Marszał <support@vexsus.eu>, June 2022.
