Imports System.Net
Imports Microsoft.Win32

Module Config
    Public getAuthor As String = "Michał Marszał (https://github.com/VEXSUS)"
    Public webClient As New WebClient
    Public currentVersion As String = "1.4.2_stable"
    Public currentAddress As String = "https://raw.githubusercontent.com/VEXSUS/WSA-Discord-RPC/master/WSA%20Discord%20RPC/Updates/currentversion.txt"
    Public changelogAddress As String = "https://raw.githubusercontent.com/VEXSUS/WSA-Discord-RPC/master/WSA%20Discord%20RPC/Updates/changelog.txt"
    Public unixtime As ULong = (Date.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
    Public APPLICATION_ID As String = "975477902164516864"
    Public APP_Details As String
    Public APP_State As String
    Public APP_LargeImageName As String = "wsalogo"
    Public Handlers As DiscordEventHandlers = New DiscordEventHandlers With {.Ready = AddressOf IsReady}
    Public _discordrpc As DiscordRichPresence = New DiscordRichPresence With {.Details = APP_Details, .State = APP_State, .LargeImageKey = APP_LargeImageName, .LargeImageText = "WSA Discord RPC @ 1.4.0 @ https://github.com/VEXSUS", .StartTimestamp = unixtime}
    Public generateInstallationID As String = Guid.NewGuid.ToString
    Public checkKey As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\WSA_Discord_RPC", True)
    Public Sub IsReady(ByRef Request As DiscordUser)
        Diagnostics.Debug.Print("Discord initialized successfully!")
    End Sub
End Module
