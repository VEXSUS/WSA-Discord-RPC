'---------------------------------------------------------------------------------'
'WSA Discord RPC - Source Code - Main Program                                     '
'Current Version of Source and App: v1.4.7_stable                                 '
'Author: Michał Marszał (https://github.com/VEXSUS)                               '
'Twitter: https://twitter.com/_VEXSUS                                             '
'---------------------------------------------------------------------------------'
'Copyright ©️ R4D1 Software 2022-2023 - All Rights Reserved                        '
'Unauthorized copying of this source code through any medium for                  '
'commercial purposes without notifying the code author is strictly prohibited.    '
'Forking the project on Github is allowed.                                        '
'Removing author credits in the program and code is prohibited.                   '
'If any of these rules are directly violated. There may be legal consequences.    '
'Written by Michał Marszał <contact@vexsus.eu>, July 2022                         '
'---------------------------------------------------------------------------------'

'---------------------------------------------------------------------------------'
'Thanks for making this libraries !                                               '
'DiscordRPC By DestroyerDarkNess And By: DanielRTRD (Example of Code)             '
'IniFile By Ludvik Jerabek                                                        '
'---------------------------------------------------------------------------------'
' * The above libraries are the property of their Authors.                        '
' * R4D1 Software organization has no rights                                      '
' * to misappropriate the intellectual property.                                  '
' * Thank you again for creating these libraries !                                '
'---------------------------------------------------------------------------------'

Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Public Class MainMenu
    Dim iniFile As New IniFile()
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion").GetValue("CurrentBuild") >= 22000 Then
            If File.Exists("settings.ini") Then
                iniFile.Load("settings.ini", Encoding.UTF8)
                MainMenu_Tabs.SquareColor = ColorTranslator.FromHtml(iniFile.GetKeyValue("personalization", "TabColor"))
                ExampleTab.SquareColor = ColorTranslator.FromHtml(iniFile.GetKeyValue("personalization", "TabColor"))
                If iniFile.GetKeyValue("main", "RunOnProgramStartup") = True Then
                    virtTimer.Start()
                    Discord_Initialize(APPLICATION_ID, Handlers, 1, 0)
                    Discord_UpdatePresence(_discordrpc)
                    checkBox_RunDiscordRPC.Checked = True
                    checkBox_RunDiscordRPC.Text = "Disable Discord RPC on program startup"
                Else
                    checkBox_RunDiscordRPC.Checked = False
                    checkBox_RunDiscordRPC.Text = "Enable Discord RPC on program startup"
                End If
                txt_Updates.Text = webClient.DownloadString(changelogAddress)
                checkForUpdates(label_UpdateInfo, label_lastChecked, txt_Updates, label_changelogTitle, button_CheckForUpdates, label_checkChannelUpdate)
                If iniFile.GetKeyValue("main", "TrayMode") = True Then
                    _tray.Visible = True
                    Me.WindowState = FormWindowState.Minimized
                    Me.ShowInTaskbar = False
                    Me.Visible = False
                    createContextMenu(_tray)
                End If
            Else
                migrationProcess()
                Application.Restart()
            End If
        Else
            MessageBox.Show("This program is for Windows 11 only, its features do not allow you to run it on Windows 10 or lower.", "WSA Discord RPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub
    Private Sub migrationProcess()
        Dim value As Integer = MainMenu_Tabs.SquareColor.ToArgb
        If checkKey IsNot Nothing Then
            checkKey.DeleteSubKeyTree("Software\WSA_Discord_RPC")
        End If
        If File.Exists("settings.ini") = False Then
            iniFile.AddSection("main").AddKey("OneDriveSync").Value = False
            iniFile.AddSection("main").AddKey("OneDriveDIR").Value = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\OneDrive\settings.ini"
            iniFile.AddSection("main").AddKey("InstallationID").Value = generateInstallationID
            iniFile.AddSection("main").AddKey("RunOnProgramStartup").Value = True
            iniFile.AddSection("main").AddKey("TrayMode").Value = False
            iniFile.AddSection("personalization").AddKey("TabColor").Value = "#" & value.ToString("X6").Substring(2)
            iniFile.Save("settings.ini", Encoding.UTF8)
        End If
    End Sub
    Private Sub button_PickTabColor_Click(sender As Object, e As EventArgs) Handles button_PickTabColor.Click
        tabColorDialog.ShowDialog()
        ExampleTab.SquareColor = Me.tabColorDialog.Color
    End Sub
    Private Sub button_SaveTabColor_Click(sender As Object, e As EventArgs) Handles button_SaveTabColor.Click
        Dim value As Integer = ExampleTab.SquareColor.ToArgb
        iniFile.SetKeyValue("personalization", "TabColor", "#" & value.ToString("X6").Substring(2))
        MainMenu_Tabs.SquareColor = ColorTranslator.FromHtml(iniFile.GetKeyValue("personalization", "TabColor"))
        iniFile.Save("settings.ini", Encoding.UTF8)
    End Sub
    Private Sub checkBox_RunDiscordRPC_CheckedChanged(sender As Object) Handles checkBox_RunDiscordRPC.CheckedChanged
        If checkBox_RunDiscordRPC.Checked Then
            iniFile.SetKeyValue("main", "RunOnProgramStartup", True)
            checkBox_RunDiscordRPC.Text = "Disable Discord RPC on program startup"
        Else
            iniFile.SetKeyValue("main", "RunOnProgramStartup", False)
            checkBox_RunDiscordRPC.Text = "Enable Discord RPC on program startup"
        End If
        iniFile.Save("settings.ini", Encoding.UTF8)
    End Sub
    Private Sub checkBox_RunTrayMode_CheckedChanged(sender As Object) Handles checkBox_RunTrayMode.CheckedChanged
        If checkBox_RunTrayMode.Checked Then
            iniFile.SetKeyValue("main", "TrayMode", True)
            _tray.Visible = True
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            createContextMenu(_tray)
        End If
        iniFile.Save("settings.ini", Encoding.UTF8)
    End Sub
    Private Sub button_CheckForUpdates_Click(sender As Object, e As EventArgs) Handles button_CheckForUpdates.Click
        If button_CheckForUpdates.Text = "Download updates" Then
            Process.Start("https://github.com/VEXSUS/WSA-Discord-RPC/releases/tag/" & webClient.DownloadString(currentAddress))
        Else
            checkForUpdates(label_UpdateInfo, label_lastChecked, txt_Updates, label_changelogTitle, button_CheckForUpdates, label_checkChannelUpdate)
        End If
    End Sub
End Class