Imports System.IO
Imports System.Text
Module OneDriveSync
    Dim iniFile As New IniFile()
    Public Sub sync(txt As Label)
        iniFile.Load("settings.ini", Encoding.UTF8)
        If iniFile.GetKeyValue("main", "OneDriveSync") = True Then
            If File.Exists(iniFile.GetKeyValue("main", "OneDriveDIR")) Then
                If My.Settings.settingsMD5.ToString = getMD5("settings.ini").ToString Then
                    txt.ForeColor = Color.DarkGreen
                    txt.Text = "Synced !"
                Else
                    File.Delete(iniFile.GetKeyValue("main", "OneDriveDIR"))
                    File.Copy("settings.ini", iniFile.GetKeyValue("main", "OneDriveDIR"))
                    My.Settings.settingsMD5 = getMD5("settings.ini")
                    txt.ForeColor = Color.DarkGreen
                    txt.Text = "Synced !"
                End If
            Else
                File.Copy("settings.ini", iniFile.GetKeyValue("main", "OneDriveDIR"))
                My.Settings.settingsMD5 = getMD5("settings.ini")
                txt.ForeColor = Color.DarkGreen
                txt.Text = "Synced !"
            End If
        Else
            txt.ForeColor = Color.Red
            txt.Text = "Not Synced !"
        End If
    End Sub
End Module
