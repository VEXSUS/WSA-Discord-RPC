Imports System.Net
Module Updates
    Public Sub checkForUpdates(labelUpdate As Label, labelUpdate2 As Label, txt As RichTextBox, labelUpdate3 As Label, buttonTxt As ChromeButton, labelUpdate4 As Label)
        webClient.CachePolicy = New Cache.RequestCachePolicy(Cache.RequestCacheLevel.NoCacheNoStore)
        If webClient.DownloadString(currentAddress).ToString = currentVersion = False Then
            Try
                txt.Clear()
                labelUpdate3.Text = "Changelog for " & webClient.DownloadString(currentAddress) & ":"
                txt.Text = webClient.DownloadString(changelogAddress)
                MainMenu.pictureBox_Update.Image = My.Resources.updatewarn
                labelUpdate.Text = "Updates available"
                labelUpdate4.Text = "Available version: " & webClient.DownloadString(currentAddress)
                labelUpdate2.Text = "Last checked: " & DateTime.Now.ToString("MM.dd.yyyy, HH:mm")
                buttonTxt.Text = "Download updates"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                txt.Clear()
                labelUpdate3.Text = "Changelog for " & currentVersion & ":"
                txt.Text = webClient.DownloadString(changelogAddress)
                MainMenu.pictureBox_Update.Image = My.Resources.updateok
                labelUpdate.Text = "You're up to date"
                labelUpdate4.Text = "Version: " & currentVersion
                labelUpdate2.Text = "Last checked: " & DateTime.Now.ToString("MM.dd.yyyy, HH:mm")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Module
