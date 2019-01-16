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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblDBname = New System.Windows.Forms.Label
        Me.tboDBname = New System.Windows.Forms.TextBox
        Me.tboUsr = New System.Windows.Forms.TextBox
        Me.tboPass = New System.Windows.Forms.TextBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblPass = New System.Windows.Forms.Label
        Me.UpdSave = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnRun = New System.Windows.Forms.Button
        Me.tmrAuto = New System.Windows.Forms.Timer(Me.components)
        Me.lblIPSvr = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.nudPC = New System.Windows.Forms.NumericUpDown
        Me.lbClient = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.nudIPClient1 = New System.Windows.Forms.NumericUpDown
        Me.nudIPClient2 = New System.Windows.Forms.NumericUpDown
        Me.nudIPClient3 = New System.Windows.Forms.NumericUpDown
        Me.nudIPClient4 = New System.Windows.Forms.NumericUpDown
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.pbAppIcon = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tboLastCheck = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.xtcPage = New DevExpress.XtraTab.XtraTabControl
        Me.xtpClient = New DevExpress.XtraTab.XtraTabPage
        Me.xtpDatabase = New DevExpress.XtraTab.XtraTabPage
        Me.tboIPServer = New System.Windows.Forms.TextBox
        Me.xtpValidator = New DevExpress.XtraTab.XtraTabPage
        Me.xtpSender = New DevExpress.XtraTab.XtraTabPage
        Me.btnMinimize = New System.Windows.Forms.Button
        Me.nicon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmMinimize = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmRestore = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.nudPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIPClient1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIPClient2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIPClient3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIPClient4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.xtcPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcPage.SuspendLayout()
        Me.xtpClient.SuspendLayout()
        Me.xtpDatabase.SuspendLayout()
        Me.cmsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDBname
        '
        Me.lblDBname.AutoSize = True
        Me.lblDBname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBname.Location = New System.Drawing.Point(158, 48)
        Me.lblDBname.Name = "lblDBname"
        Me.lblDBname.Size = New System.Drawing.Size(57, 15)
        Me.lblDBname.TabIndex = 1
        Me.lblDBname.Text = "DB Name"
        '
        'tboDBname
        '
        Me.tboDBname.BackColor = System.Drawing.Color.White
        Me.tboDBname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboDBname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboDBname.Location = New System.Drawing.Point(250, 44)
        Me.tboDBname.Name = "tboDBname"
        Me.tboDBname.Size = New System.Drawing.Size(202, 23)
        Me.tboDBname.TabIndex = 3
        '
        'tboUsr
        '
        Me.tboUsr.BackColor = System.Drawing.Color.White
        Me.tboUsr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboUsr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboUsr.Location = New System.Drawing.Point(250, 73)
        Me.tboUsr.Name = "tboUsr"
        Me.tboUsr.Size = New System.Drawing.Size(202, 23)
        Me.tboUsr.TabIndex = 4
        '
        'tboPass
        '
        Me.tboPass.BackColor = System.Drawing.Color.White
        Me.tboPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboPass.Location = New System.Drawing.Point(250, 102)
        Me.tboPass.Name = "tboPass"
        Me.tboPass.Size = New System.Drawing.Size(202, 23)
        Me.tboPass.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(658, 29)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Application for Server"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(158, 77)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(44, 15)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "User ID"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(158, 106)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(57, 15)
        Me.lblPass.TabIndex = 8
        Me.lblPass.Text = "Password"
        '
        'UpdSave
        '
        Me.UpdSave.BackColor = System.Drawing.Color.Khaki
        Me.UpdSave.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.UpdSave.FlatAppearance.BorderSize = 2
        Me.UpdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdSave.Location = New System.Drawing.Point(250, 131)
        Me.UpdSave.Name = "UpdSave"
        Me.UpdSave.Size = New System.Drawing.Size(75, 30)
        Me.UpdSave.TabIndex = 13
        Me.UpdSave.Text = "Save"
        Me.UpdSave.UseVisualStyleBackColor = False
        Me.UpdSave.Visible = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnKeluar.FlatAppearance.BorderSize = 2
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(608, 0)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(50, 29)
        Me.btnKeluar.TabIndex = 14
        Me.btnKeluar.Text = "Exit"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRun.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnRun.FlatAppearance.BorderSize = 2
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(459, 163)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 30)
        Me.btnRun.TabIndex = 15
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'tmrAuto
        '
        Me.tmrAuto.Interval = 1000
        '
        'lblIPSvr
        '
        Me.lblIPSvr.AutoSize = True
        Me.lblIPSvr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPSvr.Location = New System.Drawing.Point(158, 19)
        Me.lblIPSvr.Name = "lblIPSvr"
        Me.lblIPSvr.Size = New System.Drawing.Size(52, 15)
        Me.lblIPSvr.TabIndex = 0
        Me.lblIPSvr.Text = "IP Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total PC Client"
        '
        'nudPC
        '
        Me.nudPC.BackColor = System.Drawing.Color.White
        Me.nudPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudPC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudPC.Location = New System.Drawing.Point(250, 17)
        Me.nudPC.Name = "nudPC"
        Me.nudPC.Size = New System.Drawing.Size(46, 23)
        Me.nudPC.TabIndex = 17
        Me.nudPC.ThousandsSeparator = True
        '
        'lbClient
        '
        Me.lbClient.BackColor = System.Drawing.Color.White
        Me.lbClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbClient.FormattingEnabled = True
        Me.lbClient.ItemHeight = 15
        Me.lbClient.Location = New System.Drawing.Point(250, 46)
        Me.lbClient.Name = "lbClient"
        Me.lbClient.Size = New System.Drawing.Size(202, 182)
        Me.lbClient.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "List PC Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "IP Client"
        '
        'nudIPClient1
        '
        Me.nudIPClient1.BackColor = System.Drawing.Color.White
        Me.nudIPClient1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudIPClient1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudIPClient1.Location = New System.Drawing.Point(250, 272)
        Me.nudIPClient1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudIPClient1.Name = "nudIPClient1"
        Me.nudIPClient1.Size = New System.Drawing.Size(46, 23)
        Me.nudIPClient1.TabIndex = 21
        Me.nudIPClient1.ThousandsSeparator = True
        Me.nudIPClient1.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'nudIPClient2
        '
        Me.nudIPClient2.BackColor = System.Drawing.Color.White
        Me.nudIPClient2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudIPClient2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudIPClient2.Location = New System.Drawing.Point(302, 272)
        Me.nudIPClient2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudIPClient2.Name = "nudIPClient2"
        Me.nudIPClient2.Size = New System.Drawing.Size(46, 23)
        Me.nudIPClient2.TabIndex = 22
        Me.nudIPClient2.ThousandsSeparator = True
        Me.nudIPClient2.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'nudIPClient3
        '
        Me.nudIPClient3.BackColor = System.Drawing.Color.White
        Me.nudIPClient3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudIPClient3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudIPClient3.Location = New System.Drawing.Point(354, 272)
        Me.nudIPClient3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudIPClient3.Name = "nudIPClient3"
        Me.nudIPClient3.Size = New System.Drawing.Size(46, 23)
        Me.nudIPClient3.TabIndex = 23
        Me.nudIPClient3.ThousandsSeparator = True
        Me.nudIPClient3.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'nudIPClient4
        '
        Me.nudIPClient4.BackColor = System.Drawing.Color.White
        Me.nudIPClient4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudIPClient4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudIPClient4.Location = New System.Drawing.Point(406, 272)
        Me.nudIPClient4.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudIPClient4.Name = "nudIPClient4"
        Me.nudIPClient4.Size = New System.Drawing.Size(46, 23)
        Me.nudIPClient4.TabIndex = 24
        Me.nudIPClient4.ThousandsSeparator = True
        Me.nudIPClient4.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemove.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnRemove.FlatAppearance.BorderSize = 2
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(250, 236)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(202, 30)
        Me.btnRemove.TabIndex = 29
        Me.btnRemove.Text = "Delete Selected IP PC Client"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(250, 301)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(202, 30)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add to List PC Client"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'pbAppIcon
        '
        Me.pbAppIcon.BackColor = System.Drawing.Color.Purple
        Me.pbAppIcon.Image = Global.dizServer.My.Resources.Resources.SingleLogoDiznetServer64
        Me.pbAppIcon.Location = New System.Drawing.Point(0, 0)
        Me.pbAppIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.pbAppIcon.Name = "pbAppIcon"
        Me.pbAppIcon.Size = New System.Drawing.Size(29, 29)
        Me.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAppIcon.TabIndex = 9
        Me.pbAppIcon.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Last Check"
        '
        'tboLastCheck
        '
        Me.tboLastCheck.BackColor = System.Drawing.Color.White
        Me.tboLastCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboLastCheck.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboLastCheck.Location = New System.Drawing.Point(250, 167)
        Me.tboLastCheck.Name = "tboLastCheck"
        Me.tboLastCheck.ReadOnly = True
        Me.tboLastCheck.Size = New System.Drawing.Size(202, 23)
        Me.tboLastCheck.TabIndex = 32
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(662, 466)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.xtcPage)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Controls.Add(Me.pbAppIcon)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 464)
        Me.Panel1.TabIndex = 0
        '
        'xtcPage
        '
        Me.xtcPage.Location = New System.Drawing.Point(4, 33)
        Me.xtcPage.Margin = New System.Windows.Forms.Padding(4)
        Me.xtcPage.Name = "xtcPage"
        Me.xtcPage.SelectedTabPage = Me.xtpClient
        Me.xtcPage.Size = New System.Drawing.Size(650, 427)
        Me.xtcPage.TabIndex = 35
        Me.xtcPage.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpClient, Me.xtpDatabase, Me.xtpValidator, Me.xtpSender})
        '
        'xtpClient
        '
        Me.xtpClient.Controls.Add(Me.nudPC)
        Me.xtpClient.Controls.Add(Me.lbClient)
        Me.xtpClient.Controls.Add(Me.Label3)
        Me.xtpClient.Controls.Add(Me.Label4)
        Me.xtpClient.Controls.Add(Me.Label2)
        Me.xtpClient.Controls.Add(Me.nudIPClient1)
        Me.xtpClient.Controls.Add(Me.nudIPClient2)
        Me.xtpClient.Controls.Add(Me.nudIPClient3)
        Me.xtpClient.Controls.Add(Me.btnAdd)
        Me.xtpClient.Controls.Add(Me.nudIPClient4)
        Me.xtpClient.Controls.Add(Me.btnRemove)
        Me.xtpClient.Name = "xtpClient"
        Me.xtpClient.Size = New System.Drawing.Size(643, 398)
        Me.xtpClient.Text = "Komputer Client"
        '
        'xtpDatabase
        '
        Me.xtpDatabase.Controls.Add(Me.tboLastCheck)
        Me.xtpDatabase.Controls.Add(Me.lblIPSvr)
        Me.xtpDatabase.Controls.Add(Me.tboIPServer)
        Me.xtpDatabase.Controls.Add(Me.Label1)
        Me.xtpDatabase.Controls.Add(Me.UpdSave)
        Me.xtpDatabase.Controls.Add(Me.btnRun)
        Me.xtpDatabase.Controls.Add(Me.lblPass)
        Me.xtpDatabase.Controls.Add(Me.lblUser)
        Me.xtpDatabase.Controls.Add(Me.tboPass)
        Me.xtpDatabase.Controls.Add(Me.tboUsr)
        Me.xtpDatabase.Controls.Add(Me.tboDBname)
        Me.xtpDatabase.Controls.Add(Me.lblDBname)
        Me.xtpDatabase.Name = "xtpDatabase"
        Me.xtpDatabase.Size = New System.Drawing.Size(643, 398)
        Me.xtpDatabase.Text = "Database Setting"
        '
        'tboIPServer
        '
        Me.tboIPServer.BackColor = System.Drawing.Color.White
        Me.tboIPServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboIPServer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboIPServer.Location = New System.Drawing.Point(250, 15)
        Me.tboIPServer.Name = "tboIPServer"
        Me.tboIPServer.Size = New System.Drawing.Size(202, 23)
        Me.tboIPServer.TabIndex = 34
        '
        'xtpValidator
        '
        Me.xtpValidator.Name = "xtpValidator"
        Me.xtpValidator.Size = New System.Drawing.Size(643, 398)
        Me.xtpValidator.Text = "Data Validator"
        '
        'xtpSender
        '
        Me.xtpSender.Name = "xtpSender"
        Me.xtpSender.Size = New System.Drawing.Size(643, 398)
        Me.xtpSender.Text = "Data Checker"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Khaki
        Me.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnMinimize.FlatAppearance.BorderSize = 2
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(558, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(50, 29)
        Me.btnMinimize.TabIndex = 33
        Me.btnMinimize.Text = "Min"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'nicon
        '
        Me.nicon.ContextMenuStrip = Me.cmsMenu
        Me.nicon.Icon = CType(resources.GetObject("nicon.Icon"), System.Drawing.Icon)
        Me.nicon.Text = "diznet Server"
        Me.nicon.Visible = True
        '
        'cmsMenu
        '
        Me.cmsMenu.BackColor = System.Drawing.Color.DarkKhaki
        Me.cmsMenu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmMinimize, Me.tsmRestore, Me.ToolStripSeparator1, Me.tsmExit})
        Me.cmsMenu.Name = "cmsMenu"
        Me.cmsMenu.Size = New System.Drawing.Size(155, 76)
        '
        'tsmMinimize
        '
        Me.tsmMinimize.Name = "tsmMinimize"
        Me.tsmMinimize.Size = New System.Drawing.Size(154, 22)
        Me.tsmMinimize.Text = "Minimize"
        '
        'tsmRestore
        '
        Me.tsmRestore.Name = "tsmRestore"
        Me.tsmRestore.Size = New System.Drawing.Size(154, 22)
        Me.tsmRestore.Text = "Show Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(151, 6)
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(154, 22)
        Me.tsmExit.Text = "Exit"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnRun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnKeluar
        Me.ClientSize = New System.Drawing.Size(662, 466)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application for Server"
        CType(Me.nudPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIPClient1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIPClient2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIPClient3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIPClient4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.xtcPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcPage.ResumeLayout(False)
        Me.xtpClient.ResumeLayout(False)
        Me.xtpClient.PerformLayout()
        Me.xtpDatabase.ResumeLayout(False)
        Me.xtpDatabase.PerformLayout()
        Me.cmsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDBname As System.Windows.Forms.Label
    Friend WithEvents tboDBname As System.Windows.Forms.TextBox
    Friend WithEvents tboUsr As System.Windows.Forms.TextBox
    Friend WithEvents tboPass As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents pbAppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents UpdSave As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents tmrAuto As System.Windows.Forms.Timer
    Friend WithEvents lblIPSvr As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudPC As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbClient As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudIPClient1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudIPClient2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudIPClient3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudIPClient4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tboLastCheck As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents nicon As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents tboIPServer As System.Windows.Forms.TextBox
    Friend WithEvents cmsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmMinimize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xtcPage As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpClient As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpDatabase As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpValidator As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpSender As DevExpress.XtraTab.XtraTabPage

End Class
