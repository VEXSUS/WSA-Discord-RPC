Module WSADiscordRPC
    Public WithEvents virtTimer As New Timer()
    Public Sub discordRPC()
        Try
            Dim unixtime As ULong = (Date.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
            Discord_Initialize(APPLICATION_ID, Handlers, 1, 0)
            Discord_UpdatePresence(_discordrpc)
        Catch ex As Exception
            MsgBox("[ERROR]: " & ex.Message)
        End Try
    End Sub
    Public Async Sub virtTimer_Tick(sender As Object, e As EventArgs) Handles virtTimer.Tick
        Try
            Await Task.Delay(1000)
            For Each p As Process In Process.GetProcessesByName("WsaClient")
                If Process.GetProcessesByName("WsaSettings").Count > 0 Then
                    Discord_Initialize(APPLICATION_ID, Handlers, 1, 0)
                    _discordrpc.SmallImageKey = "settings"
                    _discordrpc.Details = "Configurating WSA Settings..."
                    Discord_UpdatePresence(_discordrpc)
                Else
                    _discordrpc.SmallImageKey = Nothing
                    _discordrpc.LargeImageKey = "wsalogo"
                    If p.MainWindowTitle = Nothing Then
                        _discordrpc.Details = "Idling..."
                        _discordrpc.State = Nothing
                    Else
                        If p.MainWindowTitle.Contains("Amazon Appstore") Then
                            _discordrpc.LargeImageKey = "amazonappstorelogo"
                        ElseIf p.MainWindowTitle.Contains("F-Droid") Then
                            _discordrpc.LargeImageKey = "fdroidlogo"
                        ElseIf p.MainWindowTitle.Contains("Termux") Then
                            _discordrpc.LargeImageKey = "termuxlogo"
                        ElseIf p.MainWindowTitle.Contains("Twitter Lite") Or p.MainWindowTitle.Contains("Twitter") Then
                            _discordrpc.LargeImageKey = "twitterlogo"
                        ElseIf p.MainWindowTitle.Equals("Lite") Then
                            _discordrpc.LargeImageKey = "facebooklitelogo"
                        ElseIf p.MainWindowTitle.Contains("Facebook") Then
                            _discordrpc.LargeImageKey = "facebook"
                        ElseIf p.MainWindowTitle.Contains("Messenger") Then
                            _discordrpc.LargeImageKey = "messengerlogo"
                        ElseIf p.MainWindowTitle.Contains("Authenticator") Then
                            _discordrpc.LargeImageKey = "authenticatorlogo"
                        ElseIf p.MainWindowTitle.Contains("Twitch") Then
                            _discordrpc.LargeImageKey = "twitchlogo"
                        End If
                        _discordrpc.State = p.MainWindowTitle
                        _discordrpc.Details = "Running (.APK)"
                    End If
                    Discord_UpdatePresence(_discordrpc)
                End If
            Next
        Catch ex As Exception
            MsgBox("[ERROR]: " & ex.Message)
        End Try
    End Sub
End Module
