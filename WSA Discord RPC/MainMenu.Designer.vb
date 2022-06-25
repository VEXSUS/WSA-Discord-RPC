<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.tabColorDialog = New System.Windows.Forms.ColorDialog()
        Me._tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MainMenu_Theme = New WSA_Discord_RPC.ChromeThemeContainer()
        Me.MainMenu_Tabs = New WSA_Discord_RPC.ChromeTabcontrol()
        Me.Page_Updates = New System.Windows.Forms.TabPage()
        Me.Separator8 = New WSA_Discord_RPC.Separator()
        Me.txt_Updates = New System.Windows.Forms.RichTextBox()
        Me.label_changelogTitle = New System.Windows.Forms.Label()
        Me.Separator6 = New WSA_Discord_RPC.Separator()
        Me.button_CheckForUpdates = New WSA_Discord_RPC.ChromeButton()
        Me.label_checkChannelUpdate = New System.Windows.Forms.Label()
        Me.label_lastChecked = New System.Windows.Forms.Label()
        Me.label_UpdateInfo = New System.Windows.Forms.Label()
        Me.pictureBox_Update = New System.Windows.Forms.PictureBox()
        Me.Page_Logs = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Page_Settings = New System.Windows.Forms.TabPage()
        Me.label_SOON = New System.Windows.Forms.Label()
        Me.checkBox_automaticUpdates = New WSA_Discord_RPC.ChromeCheckbox()
        Me.label_OneDriveStatus = New System.Windows.Forms.Label()
        Me.label_OneDriveTXT = New System.Windows.Forms.Label()
        Me.Separator3 = New WSA_Discord_RPC.Separator()
        Me.Separator2 = New WSA_Discord_RPC.Separator()
        Me.checkBox_RunTrayMode = New WSA_Discord_RPC.ChromeCheckbox()
        Me.checkBox_RunDiscordRPC = New WSA_Discord_RPC.ChromeCheckbox()
        Me.Separator1 = New WSA_Discord_RPC.Separator()
        Me.button_OneDriveSync = New WSA_Discord_RPC.ChromeButton()
        Me.label_OneDriveDescription = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_OneDriveTitle = New System.Windows.Forms.Label()
        Me.Page_Personalization = New System.Windows.Forms.TabPage()
        Me.ExampleTab = New WSA_Discord_RPC.ChromeTabcontrol()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.button_SaveTabColor = New WSA_Discord_RPC.ChromeButton()
        Me.Separator7 = New WSA_Discord_RPC.Separator()
        Me.button_PickTabColor = New WSA_Discord_RPC.ChromeButton()
        Me.label_PersonalizationDescription2 = New System.Windows.Forms.Label()
        Me.Separator5 = New WSA_Discord_RPC.Separator()
        Me.label_PersonalizationDescription = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.label_PersonalizationTitle = New System.Windows.Forms.Label()
        Me.MainMenu_Theme.SuspendLayout()
        Me.MainMenu_Tabs.SuspendLayout()
        Me.Page_Updates.SuspendLayout()
        CType(Me.pictureBox_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Page_Logs.SuspendLayout()
        Me.Page_Settings.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Page_Personalization.SuspendLayout()
        Me.ExampleTab.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_tray
        '
        Me._tray.Icon = CType(resources.GetObject("_tray.Icon"), System.Drawing.Icon)
        Me._tray.Text = "WSA Discord Rich Presence - Tray"
        '
        'MainMenu_Theme
        '
        Me.MainMenu_Theme.BackColor = System.Drawing.Color.White
        Me.MainMenu_Theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenu_Theme.Controls.Add(Me.MainMenu_Tabs)
        Me.MainMenu_Theme.Customization = "AAAA/1paWv9ycnL/"
        Me.MainMenu_Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainMenu_Theme.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MainMenu_Theme.Image = Nothing
        Me.MainMenu_Theme.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu_Theme.Movable = True
        Me.MainMenu_Theme.Name = "MainMenu_Theme"
        Me.MainMenu_Theme.NoRounding = False
        Me.MainMenu_Theme.Sizable = False
        Me.MainMenu_Theme.Size = New System.Drawing.Size(387, 255)
        Me.MainMenu_Theme.SmartBounds = True
        Me.MainMenu_Theme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainMenu_Theme.TabIndex = 0
        Me.MainMenu_Theme.Text = "WSA Discord Rich Presence - Generation: V1"
        Me.MainMenu_Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MainMenu_Theme.Transparent = False
        '
        'MainMenu_Tabs
        '
        Me.MainMenu_Tabs.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.MainMenu_Tabs.Controls.Add(Me.Page_Updates)
        Me.MainMenu_Tabs.Controls.Add(Me.Page_Logs)
        Me.MainMenu_Tabs.Controls.Add(Me.Page_Personalization)
        Me.MainMenu_Tabs.Controls.Add(Me.Page_Settings)
        Me.MainMenu_Tabs.ItemSize = New System.Drawing.Size(30, 115)
        Me.MainMenu_Tabs.Location = New System.Drawing.Point(0, 32)
        Me.MainMenu_Tabs.Multiline = True
        Me.MainMenu_Tabs.Name = "MainMenu_Tabs"
        Me.MainMenu_Tabs.SelectedIndex = 0
        Me.MainMenu_Tabs.ShowOuterBorders = False
        Me.MainMenu_Tabs.Size = New System.Drawing.Size(384, 220)
        Me.MainMenu_Tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MainMenu_Tabs.SquareColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MainMenu_Tabs.TabIndex = 1
        '
        'Page_Updates
        '
        Me.Page_Updates.BackColor = System.Drawing.Color.White
        Me.Page_Updates.Controls.Add(Me.Separator8)
        Me.Page_Updates.Controls.Add(Me.txt_Updates)
        Me.Page_Updates.Controls.Add(Me.label_changelogTitle)
        Me.Page_Updates.Controls.Add(Me.Separator6)
        Me.Page_Updates.Controls.Add(Me.button_CheckForUpdates)
        Me.Page_Updates.Controls.Add(Me.label_checkChannelUpdate)
        Me.Page_Updates.Controls.Add(Me.label_lastChecked)
        Me.Page_Updates.Controls.Add(Me.label_UpdateInfo)
        Me.Page_Updates.Controls.Add(Me.pictureBox_Update)
        Me.Page_Updates.Location = New System.Drawing.Point(119, 4)
        Me.Page_Updates.Name = "Page_Updates"
        Me.Page_Updates.Padding = New System.Windows.Forms.Padding(3)
        Me.Page_Updates.Size = New System.Drawing.Size(261, 212)
        Me.Page_Updates.TabIndex = 3
        Me.Page_Updates.Text = "R4D1 Updater"
        '
        'Separator8
        '
        Me.Separator8.Location = New System.Drawing.Point(6, 229)
        Me.Separator8.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.Separator8.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Separator8.Name = "Separator8"
        Me.Separator8.Size = New System.Drawing.Size(249, 2)
        Me.Separator8.TabIndex = 14
        '
        'txt_Updates
        '
        Me.txt_Updates.BackColor = System.Drawing.Color.White
        Me.txt_Updates.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Updates.Location = New System.Drawing.Point(9, 116)
        Me.txt_Updates.Name = "txt_Updates"
        Me.txt_Updates.ReadOnly = True
        Me.txt_Updates.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txt_Updates.Size = New System.Drawing.Size(241, 91)
        Me.txt_Updates.TabIndex = 13
        Me.txt_Updates.Text = "***************************" & Global.Microsoft.VisualBasic.ChrW(10) & "Changelog for 0.0.0" & Global.Microsoft.VisualBasic.ChrW(10) & "***************************" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "* xy" &
    "z"
        '
        'label_changelogTitle
        '
        Me.label_changelogTitle.AutoSize = True
        Me.label_changelogTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_changelogTitle.Location = New System.Drawing.Point(6, 96)
        Me.label_changelogTitle.Name = "label_changelogTitle"
        Me.label_changelogTitle.Size = New System.Drawing.Size(175, 17)
        Me.label_changelogTitle.TabIndex = 12
        Me.label_changelogTitle.Text = "Changelog for 0.0.0_stable:"
        '
        'Separator6
        '
        Me.Separator6.Location = New System.Drawing.Point(6, 91)
        Me.Separator6.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.Separator6.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Separator6.Name = "Separator6"
        Me.Separator6.Size = New System.Drawing.Size(249, 2)
        Me.Separator6.TabIndex = 11
        '
        'button_CheckForUpdates
        '
        Me.button_CheckForUpdates.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.button_CheckForUpdates.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.button_CheckForUpdates.Image = Nothing
        Me.button_CheckForUpdates.Location = New System.Drawing.Point(88, 62)
        Me.button_CheckForUpdates.Name = "button_CheckForUpdates"
        Me.button_CheckForUpdates.NoRounding = False
        Me.button_CheckForUpdates.Size = New System.Drawing.Size(115, 23)
        Me.button_CheckForUpdates.TabIndex = 4
        Me.button_CheckForUpdates.Text = "Check for updates"
        Me.button_CheckForUpdates.Transparent = False
        '
        'label_checkChannelUpdate
        '
        Me.label_checkChannelUpdate.AutoSize = True
        Me.label_checkChannelUpdate.Location = New System.Drawing.Point(85, 44)
        Me.label_checkChannelUpdate.Name = "label_checkChannelUpdate"
        Me.label_checkChannelUpdate.Size = New System.Drawing.Size(111, 15)
        Me.label_checkChannelUpdate.TabIndex = 3
        Me.label_checkChannelUpdate.Text = "Version: 0.0.0_stable"
        '
        'label_lastChecked
        '
        Me.label_lastChecked.AutoSize = True
        Me.label_lastChecked.Location = New System.Drawing.Point(85, 28)
        Me.label_lastChecked.Name = "label_lastChecked"
        Me.label_lastChecked.Size = New System.Drawing.Size(168, 15)
        Me.label_lastChecked.TabIndex = 2
        Me.label_lastChecked.Text = "Last checked: 01.01.1970, 00:00"
        '
        'label_UpdateInfo
        '
        Me.label_UpdateInfo.AutoSize = True
        Me.label_UpdateInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_UpdateInfo.Location = New System.Drawing.Point(84, 6)
        Me.label_UpdateInfo.Name = "label_UpdateInfo"
        Me.label_UpdateInfo.Size = New System.Drawing.Size(140, 21)
        Me.label_UpdateInfo.TabIndex = 1
        Me.label_UpdateInfo.Text = "You're up to date"
        '
        'pictureBox_Update
        '
        Me.pictureBox_Update.Image = Global.WSA_Discord_RPC.My.Resources.Resources.updateok
        Me.pictureBox_Update.Location = New System.Drawing.Point(6, 6)
        Me.pictureBox_Update.Name = "pictureBox_Update"
        Me.pictureBox_Update.Size = New System.Drawing.Size(72, 72)
        Me.pictureBox_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox_Update.TabIndex = 0
        Me.pictureBox_Update.TabStop = False
        '
        'Page_Logs
        '
        Me.Page_Logs.Controls.Add(Me.RichTextBox1)
        Me.Page_Logs.Location = New System.Drawing.Point(119, 4)
        Me.Page_Logs.Name = "Page_Logs"
        Me.Page_Logs.Padding = New System.Windows.Forms.Padding(3)
        Me.Page_Logs.Size = New System.Drawing.Size(261, 212)
        Me.Page_Logs.TabIndex = 4
        Me.Page_Logs.Text = "App Logs"
        Me.Page_Logs.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(255, 206)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = "[January, 1, 1970] Initializing UNIX Time..."
        '
        'Page_Settings
        '
        Me.Page_Settings.BackColor = System.Drawing.Color.White
        Me.Page_Settings.Controls.Add(Me.label_SOON)
        Me.Page_Settings.Controls.Add(Me.checkBox_automaticUpdates)
        Me.Page_Settings.Controls.Add(Me.label_OneDriveStatus)
        Me.Page_Settings.Controls.Add(Me.label_OneDriveTXT)
        Me.Page_Settings.Controls.Add(Me.Separator3)
        Me.Page_Settings.Controls.Add(Me.Separator2)
        Me.Page_Settings.Controls.Add(Me.checkBox_RunTrayMode)
        Me.Page_Settings.Controls.Add(Me.checkBox_RunDiscordRPC)
        Me.Page_Settings.Controls.Add(Me.Separator1)
        Me.Page_Settings.Controls.Add(Me.button_OneDriveSync)
        Me.Page_Settings.Controls.Add(Me.label_OneDriveDescription)
        Me.Page_Settings.Controls.Add(Me.PictureBox1)
        Me.Page_Settings.Controls.Add(Me.label_OneDriveTitle)
        Me.Page_Settings.ImageIndex = 1
        Me.Page_Settings.Location = New System.Drawing.Point(119, 4)
        Me.Page_Settings.Name = "Page_Settings"
        Me.Page_Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Page_Settings.Size = New System.Drawing.Size(261, 212)
        Me.Page_Settings.TabIndex = 1
        Me.Page_Settings.Text = "Settings"
        '
        'label_SOON
        '
        Me.label_SOON.AutoSize = True
        Me.label_SOON.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_SOON.ForeColor = System.Drawing.Color.Red
        Me.label_SOON.Location = New System.Drawing.Point(168, 185)
        Me.label_SOON.Name = "label_SOON"
        Me.label_SOON.Size = New System.Drawing.Size(38, 13)
        Me.label_SOON.TabIndex = 15
        Me.label_SOON.Text = "SOON"
        '
        'checkBox_automaticUpdates
        '
        Me.checkBox_automaticUpdates.Checked = False
        Me.checkBox_automaticUpdates.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8="
        Me.checkBox_automaticUpdates.Enabled = False
        Me.checkBox_automaticUpdates.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.checkBox_automaticUpdates.Image = Nothing
        Me.checkBox_automaticUpdates.Location = New System.Drawing.Point(9, 185)
        Me.checkBox_automaticUpdates.Name = "checkBox_automaticUpdates"
        Me.checkBox_automaticUpdates.NoRounding = False
        Me.checkBox_automaticUpdates.Size = New System.Drawing.Size(164, 17)
        Me.checkBox_automaticUpdates.TabIndex = 14
        Me.checkBox_automaticUpdates.Text = "Enable automatic updates"
        Me.checkBox_automaticUpdates.Transparent = False
        '
        'label_OneDriveStatus
        '
        Me.label_OneDriveStatus.AutoSize = True
        Me.label_OneDriveStatus.ForeColor = System.Drawing.Color.Crimson
        Me.label_OneDriveStatus.Location = New System.Drawing.Point(99, 117)
        Me.label_OneDriveStatus.Name = "label_OneDriveStatus"
        Me.label_OneDriveStatus.Size = New System.Drawing.Size(74, 15)
        Me.label_OneDriveStatus.TabIndex = 11
        Me.label_OneDriveStatus.Text = "Not Synced !"
        '
        'label_OneDriveTXT
        '
        Me.label_OneDriveTXT.AutoSize = True
        Me.label_OneDriveTXT.Location = New System.Drawing.Point(6, 117)
        Me.label_OneDriveTXT.Name = "label_OneDriveTXT"
        Me.label_OneDriveTXT.Size = New System.Drawing.Size(94, 15)
        Me.label_OneDriveTXT.TabIndex = 10
        Me.label_OneDriveTXT.Text = "OneDrive Status:"
        '
        'Separator3
        '
        Me.Separator3.Location = New System.Drawing.Point(6, 112)
        Me.Separator3.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.Separator3.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(249, 2)
        Me.Separator3.TabIndex = 9
        '
        'Separator2
        '
        Me.Separator2.Location = New System.Drawing.Point(6, 208)
        Me.Separator2.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.Separator2.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(249, 2)
        Me.Separator2.TabIndex = 8
        '
        'checkBox_RunTrayMode
        '
        Me.checkBox_RunTrayMode.Checked = False
        Me.checkBox_RunTrayMode.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8="
        Me.checkBox_RunTrayMode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.checkBox_RunTrayMode.Image = Nothing
        Me.checkBox_RunTrayMode.Location = New System.Drawing.Point(9, 165)
        Me.checkBox_RunTrayMode.Name = "checkBox_RunTrayMode"
        Me.checkBox_RunTrayMode.NoRounding = False
        Me.checkBox_RunTrayMode.Size = New System.Drawing.Size(148, 17)
        Me.checkBox_RunTrayMode.TabIndex = 7
        Me.checkBox_RunTrayMode.Text = "Enable tray mode"
        Me.checkBox_RunTrayMode.Transparent = False
        '
        'checkBox_RunDiscordRPC
        '
        Me.checkBox_RunDiscordRPC.Checked = False
        Me.checkBox_RunDiscordRPC.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8="
        Me.checkBox_RunDiscordRPC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.checkBox_RunDiscordRPC.Image = Nothing
        Me.checkBox_RunDiscordRPC.Location = New System.Drawing.Point(9, 144)
        Me.checkBox_RunDiscordRPC.Name = "checkBox_RunDiscordRPC"
        Me.checkBox_RunDiscordRPC.NoRounding = False
        Me.checkBox_RunDiscordRPC.Size = New System.Drawing.Size(233, 17)
        Me.checkBox_RunDiscordRPC.TabIndex = 5
        Me.checkBox_RunDiscordRPC.Text = "Enable Discord RPC on program startup"
        Me.checkBox_RunDiscordRPC.Transparent = False
        '
        'Separator1
        '
        Me.Separator1.Location = New System.Drawing.Point(6, 136)
        Me.Separator1.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.Separator1.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(249, 2)
        Me.Separator1.TabIndex = 4
        '
        'button_OneDriveSync
        '
        Me.button_OneDriveSync.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.button_OneDriveSync.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.button_OneDriveSync.Image = Nothing
        Me.button_OneDriveSync.Location = New System.Drawing.Point(9, 83)
        Me.button_OneDriveSync.Name = "button_OneDriveSync"
        Me.button_OneDriveSync.NoRounding = False
        Me.button_OneDriveSync.Size = New System.Drawing.Size(91, 23)
        Me.button_OneDriveSync.TabIndex = 3
        Me.button_OneDriveSync.Text = "Turn on Sync!"
        Me.button_OneDriveSync.Transparent = False
        '
        'label_OneDriveDescription
        '
        Me.label_OneDriveDescription.AutoSize = True
        Me.label_OneDriveDescription.Location = New System.Drawing.Point(6, 34)
        Me.label_OneDriveDescription.Name = "label_OneDriveDescription"
        Me.label_OneDriveDescription.Size = New System.Drawing.Size(215, 45)
        Me.label_OneDriveDescription.TabIndex = 2
        Me.label_OneDriveDescription.Text = "As of version 1.4.0, we have introduced " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the option to sync the configuration " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "file using OneDrive."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WSA_Discord_RPC.My.Resources.Resources.onedrive
        Me.PictureBox1.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'label_OneDriveTitle
        '
        Me.label_OneDriveTitle.AutoSize = True
        Me.label_OneDriveTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_OneDriveTitle.Location = New System.Drawing.Point(39, 6)
        Me.label_OneDriveTitle.Name = "label_OneDriveTitle"
        Me.label_OneDriveTitle.Size = New System.Drawing.Size(160, 21)
        Me.label_OneDriveTitle.TabIndex = 0
        Me.label_OneDriveTitle.Text = "Sync with OneDrive"
        '
        'Page_Personalization
        '
        Me.Page_Personalization.BackColor = System.Drawing.Color.White
        Me.Page_Personalization.Controls.Add(Me.ExampleTab)
        Me.Page_Personalization.Controls.Add(Me.button_SaveTabColor)
        Me.Page_Personalization.Controls.Add(Me.Separator7)
        Me.Page_Personalization.Controls.Add(Me.button_PickTabColor)
        Me.Page_Personalization.Controls.Add(Me.label_PersonalizationDescription2)
        Me.Page_Personalization.Controls.Add(Me.Separator5)
        Me.Page_Personalization.Controls.Add(Me.label_PersonalizationDescription)
        Me.Page_Personalization.Controls.Add(Me.PictureBox3)
        Me.Page_Personalization.Controls.Add(Me.label_PersonalizationTitle)
        Me.Page_Personalization.ImageIndex = 3
        Me.Page_Personalization.Location = New System.Drawing.Point(119, 4)
        Me.Page_Personalization.Name = "Page_Personalization"
        Me.Page_Personalization.Padding = New System.Windows.Forms.Padding(3)
        Me.Page_Personalization.Size = New System.Drawing.Size(261, 212)
        Me.Page_Personalization.TabIndex = 2
        Me.Page_Personalization.Text = "Personalization"
        '
        'ExampleTab
        '
        Me.ExampleTab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.ExampleTab.Controls.Add(Me.TabPage1)
        Me.ExampleTab.ItemSize = New System.Drawing.Size(30, 115)
        Me.ExampleTab.Location = New System.Drawing.Point(168, 136)
        Me.ExampleTab.Multiline = True
        Me.ExampleTab.Name = "ExampleTab"
        Me.ExampleTab.SelectedIndex = 0
        Me.ExampleTab.ShowOuterBorders = False
        Me.ExampleTab.Size = New System.Drawing.Size(84, 32)
        Me.ExampleTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.ExampleTab.SquareColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ExampleTab.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(119, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(0, 24)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hey !"
        '
        'button_SaveTabColor
        '
        Me.button_SaveTabColor.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.button_SaveTabColor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.button_SaveTabColor.Image = Nothing
        Me.button_SaveTabColor.Location = New System.Drawing.Point(88, 136)
        Me.button_SaveTabColor.Name = "button_SaveTabColor"
        Me.button_SaveTabColor.NoRounding = False
        Me.button_SaveTabColor.Size = New System.Drawing.Size(73, 28)
        Me.button_SaveTabColor.TabIndex = 18
        Me.button_SaveTabColor.Text = "Save"
        Me.button_SaveTabColor.Transparent = False
        '
        'Separator7
        '
        Me.Separator7.Location = New System.Drawing.Point(3, 170)
        Me.Separator7.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.Separator7.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Separator7.Name = "Separator7"
        Me.Separator7.Size = New System.Drawing.Size(249, 2)
        Me.Separator7.TabIndex = 17
        '
        'button_PickTabColor
        '
        Me.button_PickTabColor.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.button_PickTabColor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.button_PickTabColor.Image = Nothing
        Me.button_PickTabColor.Location = New System.Drawing.Point(9, 136)
        Me.button_PickTabColor.Name = "button_PickTabColor"
        Me.button_PickTabColor.NoRounding = False
        Me.button_PickTabColor.Size = New System.Drawing.Size(73, 28)
        Me.button_PickTabColor.TabIndex = 16
        Me.button_PickTabColor.Text = "Pick Color"
        Me.button_PickTabColor.Transparent = False
        '
        'label_PersonalizationDescription2
        '
        Me.label_PersonalizationDescription2.AutoSize = True
        Me.label_PersonalizationDescription2.Location = New System.Drawing.Point(6, 87)
        Me.label_PersonalizationDescription2.Name = "label_PersonalizationDescription2"
        Me.label_PersonalizationDescription2.Size = New System.Drawing.Size(170, 45)
        Me.label_PersonalizationDescription2.TabIndex = 14
        Me.label_PersonalizationDescription2.Text = "Change the color of your tabs. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Below is a sample tab so you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can customize the" &
    " color."
        '
        'Separator5
        '
        Me.Separator5.Location = New System.Drawing.Point(6, 82)
        Me.Separator5.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.Separator5.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Separator5.Name = "Separator5"
        Me.Separator5.Size = New System.Drawing.Size(249, 2)
        Me.Separator5.TabIndex = 10
        '
        'label_PersonalizationDescription
        '
        Me.label_PersonalizationDescription.AutoSize = True
        Me.label_PersonalizationDescription.Location = New System.Drawing.Point(6, 34)
        Me.label_PersonalizationDescription.Name = "label_PersonalizationDescription"
        Me.label_PersonalizationDescription.Size = New System.Drawing.Size(210, 45)
        Me.label_PersonalizationDescription.TabIndex = 3
        Me.label_PersonalizationDescription.Text = "Customize the color scheme and style " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to your liking to make the program " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as co" &
    "mfortable to use as possible."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WSA_Discord_RPC.My.Resources.Resources.paint
        Me.PictureBox3.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'label_PersonalizationTitle
        '
        Me.label_PersonalizationTitle.AutoSize = True
        Me.label_PersonalizationTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_PersonalizationTitle.Location = New System.Drawing.Point(39, 6)
        Me.label_PersonalizationTitle.Name = "label_PersonalizationTitle"
        Me.label_PersonalizationTitle.Size = New System.Drawing.Size(129, 21)
        Me.label_PersonalizationTitle.TabIndex = 1
        Me.label_PersonalizationTitle.Text = "Personalization"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 255)
        Me.Controls.Add(Me.MainMenu_Theme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WSA Discord RPC - Version: 1.3.0"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MainMenu_Theme.ResumeLayout(False)
        Me.MainMenu_Tabs.ResumeLayout(False)
        Me.Page_Updates.ResumeLayout(False)
        Me.Page_Updates.PerformLayout()
        CType(Me.pictureBox_Update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Page_Logs.ResumeLayout(False)
        Me.Page_Settings.ResumeLayout(False)
        Me.Page_Settings.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Page_Personalization.ResumeLayout(False)
        Me.Page_Personalization.PerformLayout()
        Me.ExampleTab.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMenu_Theme As ChromeThemeContainer
    Friend WithEvents MainMenu_Tabs As ChromeTabcontrol
    Friend WithEvents Page_Settings As TabPage
    Friend WithEvents Page_Personalization As TabPage
    Friend WithEvents label_OneDriveTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents label_OneDriveDescription As Label
    Friend WithEvents button_OneDriveSync As ChromeButton
    Friend WithEvents Separator1 As Separator
    Friend WithEvents checkBox_RunDiscordRPC As ChromeCheckbox
    Friend WithEvents Separator2 As Separator
    Friend WithEvents checkBox_RunTrayMode As ChromeCheckbox
    Friend WithEvents label_OneDriveStatus As Label
    Friend WithEvents label_OneDriveTXT As Label
    Friend WithEvents Separator3 As Separator
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents label_PersonalizationTitle As Label
    Friend WithEvents Separator5 As Separator
    Friend WithEvents label_PersonalizationDescription As Label
    Friend WithEvents button_PickTabColor As ChromeButton
    Friend WithEvents label_PersonalizationDescription2 As Label
    Friend WithEvents Separator7 As Separator
    Friend WithEvents button_SaveTabColor As ChromeButton
    Friend WithEvents ExampleTab As ChromeTabcontrol
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tabColorDialog As ColorDialog
    Friend WithEvents checkBox_automaticUpdates As ChromeCheckbox
    Friend WithEvents Page_Updates As TabPage
    Friend WithEvents label_UpdateInfo As Label
    Friend WithEvents pictureBox_Update As PictureBox
    Friend WithEvents label_checkChannelUpdate As Label
    Friend WithEvents label_lastChecked As Label
    Friend WithEvents label_changelogTitle As Label
    Friend WithEvents Separator6 As Separator
    Friend WithEvents button_CheckForUpdates As ChromeButton
    Friend WithEvents Separator8 As Separator
    Friend WithEvents txt_Updates As RichTextBox
    Friend WithEvents _tray As NotifyIcon
    Friend WithEvents label_SOON As Label
    Friend WithEvents Page_Logs As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
