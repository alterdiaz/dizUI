<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tmrWaktu = New System.Windows.Forms.Timer(Me.components)
        Me.pResize = New System.Windows.Forms.Panel()
        Me.ttCtrl = New System.Windows.Forms.ToolTip(Me.components)
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.pbNotification = New System.Windows.Forms.PictureBox()
        Me.lblUserActive = New System.Windows.Forms.Label()
        Me.btnServer = New System.Windows.Forms.Button()
        Me.btnNote = New System.Windows.Forms.Button()
        Me.btnMemo = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.tcTile = New DevExpress.XtraEditors.TileControl()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JabatanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KodeAkuntansiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengajuanUangMukaPembelianBiayaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTaskList = New DevExpress.XtraEditors.GroupControl()
        Me.pnTaskList = New System.Windows.Forms.Panel()
        Me.tlpTaskList = New System.Windows.Forms.TableLayoutPanel()
        Me.bwServer = New System.ComponentModel.BackgroundWorker()
        Me.lblQuota = New System.Windows.Forms.Label()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcSearch = New DevExpress.XtraEditors.GroupControl()
        Me.teSearch = New DevExpress.XtraEditors.TextEdit()
        Me.pForm = New System.Windows.Forms.Panel()
        Me.tlpHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAppBorder = New System.Windows.Forms.Button()
        Me.pLogo = New System.Windows.Forms.PictureBox()
        Me.btnAppMin = New System.Windows.Forms.Button()
        Me.btnAppMax = New System.Windows.Forms.Button()
        Me.btnAppExit = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDBSetting = New System.Windows.Forms.Button()
        Me.btnCompList = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTaskManager = New System.Windows.Forms.Button()
        Me.tlpFooter = New System.Windows.Forms.TableLayoutPanel()
        Me.pFooter = New System.Windows.Forms.Panel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pMain = New System.Windows.Forms.Panel()
        CType(Me.pbNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlTaskList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTaskList.SuspendLayout()
        Me.pnTaskList.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.gcSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcSearch.SuspendLayout()
        CType(Me.teSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpHeader.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.tlpFooter.SuspendLayout()
        Me.pFooter.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.pMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrWaktu
        '
        Me.tmrWaktu.Interval = 1000
        '
        'pResize
        '
        Me.pResize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pResize.BackColor = System.Drawing.Color.OrangeRed
        Me.pResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.pResize.Location = New System.Drawing.Point(992, 592)
        Me.pResize.Margin = New System.Windows.Forms.Padding(0)
        Me.pResize.Name = "pResize"
        Me.pResize.Size = New System.Drawing.Size(8, 8)
        Me.pResize.TabIndex = 4
        '
        'ttCtrl
        '
        Me.ttCtrl.AutomaticDelay = 3000
        Me.ttCtrl.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'msMenu
        '
        Me.msMenu.AllowMerge = False
        Me.msMenu.AutoSize = False
        Me.msMenu.BackColor = System.Drawing.Color.Transparent
        Me.msMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.msMenu.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.msMenu.GripMargin = New System.Windows.Forms.Padding(0)
        Me.msMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.msMenu.Location = New System.Drawing.Point(106, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Padding = New System.Windows.Forms.Padding(0)
        Me.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.msMenu.Size = New System.Drawing.Size(724, 30)
        Me.msMenu.TabIndex = 0
        Me.msMenu.Text = "mainMenu"
        Me.ttCtrl.SetToolTip(Me.msMenu, "Main menu")
        '
        'lblNotification
        '
        Me.lblNotification.BackColor = System.Drawing.Color.Transparent
        Me.lblNotification.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNotification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNotification.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblNotification.ForeColor = System.Drawing.Color.White
        Me.lblNotification.Location = New System.Drawing.Point(36, 0)
        Me.lblNotification.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(701, 31)
        Me.lblNotification.TabIndex = 3
        Me.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttCtrl.SetToolTip(Me.lblNotification, "User notification")
        '
        'pbNotification
        '
        Me.pbNotification.BackColor = System.Drawing.Color.Transparent
        Me.pbNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNotification.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbNotification.Location = New System.Drawing.Point(4, 0)
        Me.pbNotification.Margin = New System.Windows.Forms.Padding(0)
        Me.pbNotification.Name = "pbNotification"
        Me.pbNotification.Size = New System.Drawing.Size(32, 31)
        Me.pbNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbNotification.TabIndex = 4
        Me.pbNotification.TabStop = False
        Me.ttCtrl.SetToolTip(Me.pbNotification, "User notification")
        '
        'lblUserActive
        '
        Me.lblUserActive.BackColor = System.Drawing.Color.Transparent
        Me.lblUserActive.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUserActive.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblUserActive.ForeColor = System.Drawing.Color.White
        Me.lblUserActive.Location = New System.Drawing.Point(737, 0)
        Me.lblUserActive.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUserActive.Name = "lblUserActive"
        Me.lblUserActive.Size = New System.Drawing.Size(255, 31)
        Me.lblUserActive.TabIndex = 2
        Me.lblUserActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttCtrl.SetToolTip(Me.lblUserActive, "User login")
        '
        'btnServer
        '
        Me.btnServer.BackColor = System.Drawing.Color.Transparent
        Me.btnServer.BackgroundImage = Global.dizUI.My.Resources.Resources.client
        Me.btnServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnServer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnServer.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnServer.FlatAppearance.BorderSize = 0
        Me.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServer.Location = New System.Drawing.Point(846, 0)
        Me.btnServer.Margin = New System.Windows.Forms.Padding(0)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Size = New System.Drawing.Size(30, 30)
        Me.btnServer.TabIndex = 24
        Me.btnServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttCtrl.SetToolTip(Me.btnServer, "Performance Status")
        Me.btnServer.UseVisualStyleBackColor = False
        '
        'btnNote
        '
        Me.btnNote.BackColor = System.Drawing.Color.Transparent
        Me.btnNote.BackgroundImage = Global.dizUI.My.Resources.Resources.notes
        Me.btnNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNote.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNote.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNote.FlatAppearance.BorderSize = 0
        Me.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote.Location = New System.Drawing.Point(876, 0)
        Me.btnNote.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNote.Name = "btnNote"
        Me.btnNote.Size = New System.Drawing.Size(30, 30)
        Me.btnNote.TabIndex = 27
        Me.btnNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttCtrl.SetToolTip(Me.btnNote, "Catatan")
        Me.btnNote.UseVisualStyleBackColor = False
        '
        'btnMemo
        '
        Me.btnMemo.BackColor = System.Drawing.Color.Transparent
        Me.btnMemo.BackgroundImage = Global.dizUI.My.Resources.Resources.memo
        Me.btnMemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMemo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMemo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMemo.FlatAppearance.BorderSize = 0
        Me.btnMemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemo.Location = New System.Drawing.Point(906, 0)
        Me.btnMemo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMemo.Name = "btnMemo"
        Me.btnMemo.Size = New System.Drawing.Size(30, 30)
        Me.btnMemo.TabIndex = 26
        Me.btnMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttCtrl.SetToolTip(Me.btnMemo, "Memo & Disposisi")
        Me.btnMemo.UseVisualStyleBackColor = False
        '
        'btnMessage
        '
        Me.btnMessage.BackColor = System.Drawing.Color.Transparent
        Me.btnMessage.BackgroundImage = Global.dizUI.My.Resources.Resources.message
        Me.btnMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMessage.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMessage.FlatAppearance.BorderSize = 0
        Me.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMessage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessage.Location = New System.Drawing.Point(936, 0)
        Me.btnMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(30, 30)
        Me.btnMessage.TabIndex = 28
        Me.btnMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttCtrl.SetToolTip(Me.btnMessage, "Obrolan")
        Me.btnMessage.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnProfile.BackgroundImage = Global.dizUI.My.Resources.Resources.profile
        Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(966, 0)
        Me.btnProfile.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(30, 30)
        Me.btnProfile.TabIndex = 25
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttCtrl.SetToolTip(Me.btnProfile, "Profil Pengguna")
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'tcTile
        '
        Me.tcTile.AllowDrag = False
        Me.tcTile.AllowItemHover = True
        Me.tcTile.AllowSelectedItemBorder = False
        Me.tcTile.AppearanceGroupHighlighting.HoveredMaskColor = System.Drawing.Color.Black
        Me.tcTile.AppearanceGroupHighlighting.MaskColor = System.Drawing.Color.Black
        Me.tcTile.AppearanceGroupText.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.tcTile.AppearanceGroupText.ForeColor = System.Drawing.Color.Purple
        Me.tcTile.AppearanceGroupText.Options.UseFont = True
        Me.tcTile.AppearanceGroupText.Options.UseForeColor = True
        Me.tcTile.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tcTile.AppearanceItem.Hovered.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tcTile.AppearanceItem.Hovered.Options.UseBackColor = True
        Me.tcTile.AppearanceItem.Hovered.Options.UseFont = True
        Me.tcTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tcTile.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Purple
        Me.tcTile.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tcTile.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tcTile.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.tcTile.AppearanceItem.Normal.Options.UseFont = True
        Me.tcTile.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.tcTile.AppearanceItem.Selected.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tcTile.AppearanceItem.Selected.Options.UseBackColor = True
        Me.tcTile.AppearanceItem.Selected.Options.UseFont = True
        Me.tcTile.AppearanceText.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tcTile.AppearanceText.Options.UseFont = True
        Me.tcTile.BackColor = System.Drawing.Color.Transparent
        Me.tcTile.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_body
        Me.tcTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tcTile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTile.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never
        Me.tcTile.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.RandomSegmentedFade
        Me.tcTile.Location = New System.Drawing.Point(0, 0)
        Me.tcTile.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.tcTile.LookAndFeel.UseDefaultLookAndFeel = False
        Me.tcTile.Margin = New System.Windows.Forms.Padding(0)
        Me.tcTile.MaxId = 12
        Me.tcTile.Name = "tcTile"
        Me.tcTile.OptionsAdaptiveLayout.ScrollMode = DevExpress.XtraEditors.TileControlAdaptiveLayoutScrollMode.ItemScrolling
        Me.tcTile.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tcTile.ScrollButtonFadeAnimationTime = 1000
        Me.tcTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar
        Me.tcTile.ShowGroupText = True
        Me.tcTile.Size = New System.Drawing.Size(996, 505)
        Me.tcTile.TabIndex = 5
        Me.tcTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengaturanToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(60, 30)
        Me.SystemToolStripMenuItem.Text = "Sistem"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JabatanToolStripMenuItem, Me.JabatanToolStripMenuItem1, Me.KaryaToolStripMenuItem, Me.KodeAkuntansiToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(49, 30)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'JabatanToolStripMenuItem
        '
        Me.JabatanToolStripMenuItem.Name = "JabatanToolStripMenuItem"
        Me.JabatanToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.JabatanToolStripMenuItem.Text = "Department"
        '
        'JabatanToolStripMenuItem1
        '
        Me.JabatanToolStripMenuItem1.Name = "JabatanToolStripMenuItem1"
        Me.JabatanToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.JabatanToolStripMenuItem1.Text = "Jabatan"
        '
        'KaryaToolStripMenuItem
        '
        Me.KaryaToolStripMenuItem.Name = "KaryaToolStripMenuItem"
        Me.KaryaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KaryaToolStripMenuItem.Text = "Karyawan"
        '
        'KodeAkuntansiToolStripMenuItem
        '
        Me.KodeAkuntansiToolStripMenuItem.Name = "KodeAkuntansiToolStripMenuItem"
        Me.KodeAkuntansiToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KodeAkuntansiToolStripMenuItem.Text = "Kode Akuntansi"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengajuanUangMukaPembelianBiayaToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(76, 30)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PengajuanUangMukaPembelianBiayaToolStripMenuItem
        '
        Me.PengajuanUangMukaPembelianBiayaToolStripMenuItem.Name = "PengajuanUangMukaPembelianBiayaToolStripMenuItem"
        Me.PengajuanUangMukaPembelianBiayaToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.PengajuanUangMukaPembelianBiayaToolStripMenuItem.Text = "Pengajuan Uang Muka, Pembelian, Biaya"
        '
        'MonitorToolStripMenuItem
        '
        Me.MonitorToolStripMenuItem.Name = "MonitorToolStripMenuItem"
        Me.MonitorToolStripMenuItem.Size = New System.Drawing.Size(66, 30)
        Me.MonitorToolStripMenuItem.Text = "Monitor"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(62, 30)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'pnlTaskList
        '
        Me.pnlTaskList.Appearance.BackColor = System.Drawing.Color.Silver
        Me.pnlTaskList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.pnlTaskList.Appearance.Options.UseBackColor = True
        Me.pnlTaskList.Appearance.Options.UseFont = True
        Me.pnlTaskList.AppearanceCaption.BackColor = System.Drawing.Color.Silver
        Me.pnlTaskList.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTaskList.AppearanceCaption.Options.UseBackColor = True
        Me.pnlTaskList.AppearanceCaption.Options.UseFont = True
        Me.pnlTaskList.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.pnlTaskList.Controls.Add(Me.pnTaskList)
        Me.pnlTaskList.FireScrollEventOnMouseWheel = True
        Me.pnlTaskList.Location = New System.Drawing.Point(3, 62)
        Me.pnlTaskList.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTaskList.Name = "pnlTaskList"
        Me.pnlTaskList.Size = New System.Drawing.Size(260, 300)
        Me.pnlTaskList.TabIndex = 7
        Me.pnlTaskList.Text = "Recents Panel"
        Me.pnlTaskList.Visible = False
        '
        'pnTaskList
        '
        Me.pnTaskList.AutoScroll = True
        Me.pnTaskList.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnTaskList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnTaskList.Controls.Add(Me.tlpTaskList)
        Me.pnTaskList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnTaskList.ForeColor = System.Drawing.Color.Black
        Me.pnTaskList.Location = New System.Drawing.Point(2, 23)
        Me.pnTaskList.Margin = New System.Windows.Forms.Padding(0)
        Me.pnTaskList.Name = "pnTaskList"
        Me.pnTaskList.Size = New System.Drawing.Size(256, 275)
        Me.pnTaskList.TabIndex = 1
        '
        'tlpTaskList
        '
        Me.tlpTaskList.BackColor = System.Drawing.Color.Transparent
        Me.tlpTaskList.ColumnCount = 3
        Me.tlpTaskList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpTaskList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTaskList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpTaskList.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTaskList.Location = New System.Drawing.Point(0, 0)
        Me.tlpTaskList.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTaskList.Name = "tlpTaskList"
        Me.tlpTaskList.RowCount = 3
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpTaskList.Size = New System.Drawing.Size(256, 34)
        Me.tlpTaskList.TabIndex = 1
        '
        'bwServer
        '
        Me.bwServer.WorkerSupportsCancellation = True
        '
        'lblQuota
        '
        Me.lblQuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblQuota.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuota.ForeColor = System.Drawing.Color.White
        Me.lblQuota.Location = New System.Drawing.Point(1, 537)
        Me.lblQuota.Margin = New System.Windows.Forms.Padding(0)
        Me.lblQuota.Name = "lblQuota"
        Me.lblQuota.Size = New System.Drawing.Size(150, 24)
        Me.lblQuota.TabIndex = 8
        Me.lblQuota.Text = "Kuota Tersisa : 500"
        Me.lblQuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblQuota.Visible = False
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.Transparent
        Me.pBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBody.Controls.Add(Me.gcSearch)
        Me.pBody.Controls.Add(Me.tcTile)
        Me.pBody.Controls.Add(Me.pForm)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(0, 60)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(996, 505)
        Me.pBody.TabIndex = 1
        '
        'gcSearch
        '
        Me.gcSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcSearch.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gcSearch.Appearance.Options.UseBackColor = True
        Me.gcSearch.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcSearch.AppearanceCaption.Options.UseFont = True
        Me.gcSearch.Controls.Add(Me.teSearch)
        Me.gcSearch.Location = New System.Drawing.Point(773, 0)
        Me.gcSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.gcSearch.Name = "gcSearch"
        Me.gcSearch.Padding = New System.Windows.Forms.Padding(4)
        Me.gcSearch.Size = New System.Drawing.Size(200, 52)
        Me.gcSearch.TabIndex = 9
        Me.gcSearch.Text = "Cari Menu"
        Me.gcSearch.Visible = False
        '
        'teSearch
        '
        Me.teSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teSearch.Location = New System.Drawing.Point(6, 27)
        Me.teSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.teSearch.Name = "teSearch"
        Me.teSearch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teSearch.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teSearch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSearch.Properties.Appearance.Options.UseBackColor = True
        Me.teSearch.Properties.Appearance.Options.UseFont = True
        Me.teSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teSearch.Properties.MaxLength = 50
        Me.teSearch.Properties.NullText = "[Belum Diisi]"
        Me.teSearch.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teSearch.Size = New System.Drawing.Size(188, 20)
        Me.teSearch.TabIndex = 22
        Me.teSearch.Tag = ""
        '
        'pForm
        '
        Me.pForm.BackColor = System.Drawing.Color.Transparent
        Me.pForm.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_body
        Me.pForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pForm.Location = New System.Drawing.Point(106, 36)
        Me.pForm.Margin = New System.Windows.Forms.Padding(0)
        Me.pForm.Name = "pForm"
        Me.pForm.Size = New System.Drawing.Size(996, 505)
        Me.pForm.TabIndex = 8
        '
        'tlpHeader
        '
        Me.tlpHeader.AutoSize = True
        Me.tlpHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpHeader.BackColor = System.Drawing.Color.Transparent
        Me.tlpHeader.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_header
        Me.tlpHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlpHeader.ColumnCount = 1
        Me.tlpHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHeader.Controls.Add(Me.pTitle, 0, 0)
        Me.tlpHeader.Controls.Add(Me.pHeader, 0, 1)
        Me.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHeader.Location = New System.Drawing.Point(0, 0)
        Me.tlpHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpHeader.Name = "tlpHeader"
        Me.tlpHeader.RowCount = 2
        Me.tlpHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpHeader.Size = New System.Drawing.Size(996, 60)
        Me.tlpHeader.TabIndex = 0
        '
        'pTitle
        '
        Me.pTitle.BackColor = System.Drawing.Color.Transparent
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.btnLogin)
        Me.pTitle.Controls.Add(Me.Label1)
        Me.pTitle.Controls.Add(Me.btnAppBorder)
        Me.pTitle.Controls.Add(Me.pLogo)
        Me.pTitle.Controls.Add(Me.btnAppMin)
        Me.pTitle.Controls.Add(Me.btnAppMax)
        Me.pTitle.Controls.Add(Me.btnAppExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(0, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(996, 30)
        Me.pTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(30, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Size = New System.Drawing.Size(736, 30)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(766, 0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(90, 30)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Tag = ""
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(856, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "|"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAppBorder
        '
        Me.btnAppBorder.BackColor = System.Drawing.Color.Transparent
        Me.btnAppBorder.BackgroundImage = Global.dizUI.My.Resources.Resources.bordersingle_n
        Me.btnAppBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppBorder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAppBorder.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppBorder.FlatAppearance.BorderSize = 0
        Me.btnAppBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppBorder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppBorder.Location = New System.Drawing.Point(876, 0)
        Me.btnAppBorder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppBorder.Name = "btnAppBorder"
        Me.btnAppBorder.Size = New System.Drawing.Size(30, 30)
        Me.btnAppBorder.TabIndex = 23
        Me.btnAppBorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppBorder.UseVisualStyleBackColor = False
        '
        'pLogo
        '
        Me.pLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pLogo.Image = Global.dizUI.My.Resources.Resources.dizLive
        Me.pLogo.Location = New System.Drawing.Point(0, 0)
        Me.pLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.Size = New System.Drawing.Size(30, 30)
        Me.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pLogo.TabIndex = 0
        Me.pLogo.TabStop = False
        '
        'btnAppMin
        '
        Me.btnAppMin.BackColor = System.Drawing.Color.Transparent
        Me.btnAppMin.BackgroundImage = Global.dizUI.My.Resources.Resources.min_n
        Me.btnAppMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppMin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAppMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppMin.FlatAppearance.BorderSize = 0
        Me.btnAppMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppMin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppMin.Location = New System.Drawing.Point(906, 0)
        Me.btnAppMin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppMin.Name = "btnAppMin"
        Me.btnAppMin.Size = New System.Drawing.Size(30, 30)
        Me.btnAppMin.TabIndex = 24
        Me.btnAppMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppMin.UseVisualStyleBackColor = False
        '
        'btnAppMax
        '
        Me.btnAppMax.BackColor = System.Drawing.Color.Transparent
        Me.btnAppMax.BackgroundImage = Global.dizUI.My.Resources.Resources.max_n
        Me.btnAppMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppMax.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAppMax.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppMax.FlatAppearance.BorderSize = 0
        Me.btnAppMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppMax.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppMax.Location = New System.Drawing.Point(936, 0)
        Me.btnAppMax.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppMax.Name = "btnAppMax"
        Me.btnAppMax.Size = New System.Drawing.Size(30, 30)
        Me.btnAppMax.TabIndex = 25
        Me.btnAppMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppMax.UseVisualStyleBackColor = False
        '
        'btnAppExit
        '
        Me.btnAppExit.BackColor = System.Drawing.Color.Transparent
        Me.btnAppExit.BackgroundImage = Global.dizUI.My.Resources.Resources.exit_n
        Me.btnAppExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAppExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppExit.FlatAppearance.BorderSize = 0
        Me.btnAppExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppExit.Location = New System.Drawing.Point(966, 0)
        Me.btnAppExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppExit.Name = "btnAppExit"
        Me.btnAppExit.Size = New System.Drawing.Size(30, 30)
        Me.btnAppExit.TabIndex = 22
        Me.btnAppExit.Tag = "exit"
        Me.btnAppExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppExit.UseVisualStyleBackColor = False
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.Transparent
        Me.pHeader.Controls.Add(Me.msMenu)
        Me.pHeader.Controls.Add(Me.Label3)
        Me.pHeader.Controls.Add(Me.btnDBSetting)
        Me.pHeader.Controls.Add(Me.btnCompList)
        Me.pHeader.Controls.Add(Me.Label2)
        Me.pHeader.Controls.Add(Me.btnServer)
        Me.pHeader.Controls.Add(Me.btnNote)
        Me.pHeader.Controls.Add(Me.btnMemo)
        Me.pHeader.Controls.Add(Me.btnMessage)
        Me.pHeader.Controls.Add(Me.btnProfile)
        Me.pHeader.Controls.Add(Me.btnTaskManager)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pHeader.Location = New System.Drawing.Point(0, 30)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(996, 30)
        Me.pHeader.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(90, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 30)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "|"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDBSetting
        '
        Me.btnDBSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnDBSetting.BackgroundImage = Global.dizUI.My.Resources.Resources.connection
        Me.btnDBSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDBSetting.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDBSetting.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDBSetting.FlatAppearance.BorderSize = 0
        Me.btnDBSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDBSetting.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBSetting.Location = New System.Drawing.Point(60, 0)
        Me.btnDBSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDBSetting.Name = "btnDBSetting"
        Me.btnDBSetting.Size = New System.Drawing.Size(30, 30)
        Me.btnDBSetting.TabIndex = 30
        Me.btnDBSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDBSetting.UseVisualStyleBackColor = False
        '
        'btnCompList
        '
        Me.btnCompList.BackColor = System.Drawing.Color.Transparent
        Me.btnCompList.BackgroundImage = Global.dizUI.My.Resources.Resources.formlist
        Me.btnCompList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCompList.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCompList.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCompList.FlatAppearance.BorderSize = 0
        Me.btnCompList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompList.Location = New System.Drawing.Point(30, 0)
        Me.btnCompList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCompList.Name = "btnCompList"
        Me.btnCompList.Size = New System.Drawing.Size(30, 30)
        Me.btnCompList.TabIndex = 29
        Me.btnCompList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompList.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(830, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 30)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "|"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTaskManager
        '
        Me.btnTaskManager.BackColor = System.Drawing.Color.Transparent
        Me.btnTaskManager.BackgroundImage = Global.dizUI.My.Resources.Resources.recent
        Me.btnTaskManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTaskManager.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnTaskManager.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTaskManager.FlatAppearance.BorderSize = 0
        Me.btnTaskManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTaskManager.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaskManager.Location = New System.Drawing.Point(0, 0)
        Me.btnTaskManager.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTaskManager.Name = "btnTaskManager"
        Me.btnTaskManager.Size = New System.Drawing.Size(30, 30)
        Me.btnTaskManager.TabIndex = 31
        Me.btnTaskManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTaskManager.UseVisualStyleBackColor = False
        '
        'tlpFooter
        '
        Me.tlpFooter.AutoSize = True
        Me.tlpFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpFooter.BackColor = System.Drawing.Color.Transparent
        Me.tlpFooter.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_footer
        Me.tlpFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlpFooter.ColumnCount = 1
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFooter.Controls.Add(Me.pFooter, 0, 0)
        Me.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpFooter.ForeColor = System.Drawing.Color.Black
        Me.tlpFooter.Location = New System.Drawing.Point(0, 565)
        Me.tlpFooter.Name = "tlpFooter"
        Me.tlpFooter.RowCount = 1
        Me.tlpFooter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFooter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpFooter.Size = New System.Drawing.Size(996, 31)
        Me.tlpFooter.TabIndex = 1
        '
        'pFooter
        '
        Me.pFooter.BackColor = System.Drawing.Color.Transparent
        Me.pFooter.Controls.Add(Me.lblNotification)
        Me.pFooter.Controls.Add(Me.pbNotification)
        Me.pFooter.Controls.Add(Me.lblUserActive)
        Me.pFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pFooter.Location = New System.Drawing.Point(0, 0)
        Me.pFooter.Margin = New System.Windows.Forms.Padding(0)
        Me.pFooter.Name = "pFooter"
        Me.pFooter.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pFooter.Size = New System.Drawing.Size(996, 31)
        Me.pFooter.TabIndex = 3
        '
        'tlpMain
        '
        Me.tlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tlpMain.ColumnCount = 3
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpMain.Controls.Add(Me.pMain, 1, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1000, 600)
        Me.tlpMain.TabIndex = 9
        '
        'pMain
        '
        Me.pMain.Controls.Add(Me.pBody)
        Me.pMain.Controls.Add(Me.lblQuota)
        Me.pMain.Controls.Add(Me.tlpHeader)
        Me.pMain.Controls.Add(Me.tlpFooter)
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(2, 2)
        Me.pMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(996, 596)
        Me.pMain.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pResize)
        Me.Controls.Add(Me.tlpMain)
        Me.Controls.Add(Me.pnlTaskList)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMenu
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbNotification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlTaskList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTaskList.ResumeLayout(False)
        Me.pnTaskList.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        CType(Me.gcSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcSearch.ResumeLayout(False)
        CType(Me.teSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpHeader.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.tlpFooter.ResumeLayout(False)
        Me.pFooter.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.pMain.ResumeLayout(False)
        Me.pMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pFooter As System.Windows.Forms.Panel
    Friend WithEvents lblNotification As System.Windows.Forms.Label
    Friend WithEvents lblUserActive As System.Windows.Forms.Label
    Friend WithEvents tcTile As DevExpress.XtraEditors.TileControl
    Friend WithEvents pForm As System.Windows.Forms.Panel
    Friend WithEvents pbNotification As System.Windows.Forms.PictureBox
    Friend WithEvents tmrWaktu As System.Windows.Forms.Timer
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents PengaturanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JabatanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KodeAkuntansiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengajuanUangMukaPembelianBiayaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tlpFooter As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ttCtrl As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlTaskList As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnTaskList As System.Windows.Forms.Panel
    Friend WithEvents tlpTaskList As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pResize As System.Windows.Forms.Panel
    Friend WithEvents bwServer As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblQuota As System.Windows.Forms.Label
    Public WithEvents btnAppBorder As System.Windows.Forms.Button
    Public WithEvents btnAppExit As System.Windows.Forms.Button
    Public WithEvents btnAppMax As System.Windows.Forms.Button
    Public WithEvents btnAppMin As System.Windows.Forms.Button
    Public WithEvents btnServer As System.Windows.Forms.Button
    Public WithEvents btnMessage As System.Windows.Forms.Button
    Public WithEvents btnNote As System.Windows.Forms.Button
    Public WithEvents btnMemo As System.Windows.Forms.Button
    Public WithEvents btnProfile As System.Windows.Forms.Button
    Public WithEvents btnCompList As System.Windows.Forms.Button
    Public WithEvents btnTaskManager As System.Windows.Forms.Button
    Public WithEvents btnDBSetting As System.Windows.Forms.Button
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents pMain As Panel
    Friend WithEvents gcSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents teSearch As DevExpress.XtraEditors.TextEdit
End Class
