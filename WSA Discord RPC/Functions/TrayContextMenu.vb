Imports System.Text
Module TrayContextMenu
    Dim iniFile As New IniFile()
    Dim contextMenu As New ContextMenu
    Dim menuWSADiscordRPCBranding As New MenuItem("𝗪𝗦𝗔 𝗗𝗶𝘀𝗰𝗼𝗿𝗱 𝗥𝗶𝗰𝗵 𝗣𝗿𝗲𝘀𝗲𝗻𝗰𝗲")
    Dim menuSettings As New MenuItem("Settings")
    Dim menuWSAExit As New MenuItem("Exit")
    Dim menuWSAVersion As New MenuItem("Version: " + webClient.DownloadString(currentAddress))
    Public Sub createContextMenu(notifyIcon As NotifyIcon)
        iniFile.Load("settings.ini", Encoding.UTF8)
        contextMenu.MenuItems.Add(menuWSADiscordRPCBranding)
        contextMenu.MenuItems.Add(menuSettings)
        menuSettings.MenuItems.Add("Leave from tray mode", New EventHandler(AddressOf leaveTrayMode))
        If iniFile.GetKeyValue("main", "RunOnProgramStartup") = True Then
            menuSettings.MenuItems.Add("Disable Discord Rich Presence on program startup", New EventHandler(AddressOf disableRPCOnStartup))
        Else
            menuSettings.MenuItems.Add("Enable Discord Rich Presence on program startup", New EventHandler(AddressOf enableRPCOnStartup))
        End If
        contextMenu.MenuItems.Add(menuWSAExit)
        contextMenu.MenuItems.Add(menuWSAVersion)
        notifyIcon.ContextMenu = contextMenu

        AddHandler menuWSADiscordRPCBranding.Click, AddressOf menuWSADiscordRPCBranding_click
        AddHandler menuWSAExit.Click, AddressOf menuWSAExit_click
    End Sub
    Private Sub menuWSAExit_click(ByVal sender As Object, e As System.EventArgs)
        Application.Exit()
    End Sub
    Private Sub leaveTrayMode()
        iniFile.Load("settings.ini", Encoding.UTF8)
        iniFile.SetKeyValue("main", "TrayMode", False)
        iniFile.Save()
        Application.Restart()
    End Sub
    Private Sub disableRPCOnStartup()
        iniFile.Load("settings.ini", Encoding.UTF8)
        menuSettings.MenuItems.RemoveAt(1)
        iniFile.SetKeyValue("main", "RunOnProgramStartup", False)
        iniFile.Save()
        menuSettings.MenuItems.Add("Enable Discord Rich Presence on program startup", New EventHandler(AddressOf enableRPCOnStartup))
    End Sub
    Private Sub enableRPCOnStartup()
        iniFile.Load("settings.ini", Encoding.UTF8)
        menuSettings.MenuItems.RemoveAt(1)
        iniFile.SetKeyValue("main", "RunOnProgramStartup", True)
        iniFile.Save()
        menuSettings.MenuItems.Add("Disable Discord Rich Presence on program startup", New EventHandler(AddressOf disableRPCOnStartup))
    End Sub
    Private Sub menuWSADiscordRPCBranding_click(ByVal sender As Object, e As System.EventArgs)
        MessageBox.Show("Discord Rich Presence for Windows Subsystem for Android™️" & vbNewLine & "Version: " + webClient.DownloadString(currentAddress) & vbNewLine & "Author: " + getAuthor, "WSA Discord Rich Presence", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
