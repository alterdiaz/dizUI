<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingDB
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
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.tboInstance = New DevExpress.XtraEditors.TextEdit()
        Me.tboSkema = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboDBname = New DevExpress.XtraEditors.TextEdit()
        Me.tboDBsvr = New DevExpress.XtraEditors.TextEdit()
        Me.tboDBport = New DevExpress.XtraEditors.TextEdit()
        Me.tboDBuid = New DevExpress.XtraEditors.TextEdit()
        Me.tboDBpwd = New DevExpress.XtraEditors.TextEdit()
        Me.lblDBport = New System.Windows.Forms.Label()
        Me.lblDBsvr = New System.Windows.Forms.Label()
        Me.lblDBname = New System.Windows.Forms.Label()
        Me.lblDBuid = New System.Windows.Forms.Label()
        Me.lblDBpwd = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        CType(Me.tboInstance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboSkema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBsvr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBuid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBpwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(356, 240)
        Me.tlpForm.TabIndex = 8
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.tlpTop)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(352, 208)
        Me.pBody.TabIndex = 7
        '
        'tlpTop
        '
        Me.tlpTop.ColumnCount = 4
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Controls.Add(Me.tboInstance, 2, 5)
        Me.tlpTop.Controls.Add(Me.tboSkema, 2, 4)
        Me.tlpTop.Controls.Add(Me.Label2, 1, 5)
        Me.tlpTop.Controls.Add(Me.Label1, 1, 4)
        Me.tlpTop.Controls.Add(Me.tboDBname, 2, 1)
        Me.tlpTop.Controls.Add(Me.tboDBsvr, 2, 2)
        Me.tlpTop.Controls.Add(Me.tboDBport, 2, 3)
        Me.tlpTop.Controls.Add(Me.tboDBuid, 2, 6)
        Me.tlpTop.Controls.Add(Me.tboDBpwd, 2, 7)
        Me.tlpTop.Controls.Add(Me.lblDBport, 1, 3)
        Me.tlpTop.Controls.Add(Me.lblDBsvr, 1, 2)
        Me.tlpTop.Controls.Add(Me.lblDBname, 1, 1)
        Me.tlpTop.Controls.Add(Me.lblDBuid, 1, 6)
        Me.tlpTop.Controls.Add(Me.lblDBpwd, 1, 7)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Location = New System.Drawing.Point(0, 30)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 9
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTop.Size = New System.Drawing.Size(352, 178)
        Me.tlpTop.TabIndex = 5
        '
        'tboInstance
        '
        Me.tboInstance.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboInstance.Location = New System.Drawing.Point(136, 103)
        Me.tboInstance.Margin = New System.Windows.Forms.Padding(0)
        Me.tboInstance.Name = "tboInstance"
        Me.tboInstance.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboInstance.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboInstance.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboInstance.Properties.Appearance.Options.UseBackColor = True
        Me.tboInstance.Properties.Appearance.Options.UseFont = True
        Me.tboInstance.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboInstance.Properties.NullText = "[Kosong]"
        Me.tboInstance.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboInstance.Size = New System.Drawing.Size(187, 20)
        Me.tboInstance.TabIndex = 37
        Me.tboInstance.Tag = "namalengkap"
        '
        'tboSkema
        '
        Me.tboSkema.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboSkema.Location = New System.Drawing.Point(136, 79)
        Me.tboSkema.Margin = New System.Windows.Forms.Padding(0)
        Me.tboSkema.Name = "tboSkema"
        Me.tboSkema.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboSkema.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboSkema.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboSkema.Properties.Appearance.Options.UseBackColor = True
        Me.tboSkema.Properties.Appearance.Options.UseFont = True
        Me.tboSkema.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboSkema.Properties.NullText = "[Kosong]"
        Me.tboSkema.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboSkema.Size = New System.Drawing.Size(187, 20)
        Me.tboSkema.TabIndex = 37
        Me.tboSkema.Tag = "namalengkap"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Instance"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Skema"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tboDBname
        '
        Me.tboDBname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboDBname.Location = New System.Drawing.Point(136, 7)
        Me.tboDBname.Margin = New System.Windows.Forms.Padding(0)
        Me.tboDBname.Name = "tboDBname"
        Me.tboDBname.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboDBname.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboDBname.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboDBname.Properties.Appearance.Options.UseBackColor = True
        Me.tboDBname.Properties.Appearance.Options.UseFont = True
        Me.tboDBname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboDBname.Properties.NullText = "[Kosong]"
        Me.tboDBname.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboDBname.Size = New System.Drawing.Size(187, 20)
        Me.tboDBname.TabIndex = 36
        Me.tboDBname.Tag = "namalengkap"
        '
        'tboDBsvr
        '
        Me.tboDBsvr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboDBsvr.Location = New System.Drawing.Point(136, 31)
        Me.tboDBsvr.Margin = New System.Windows.Forms.Padding(0)
        Me.tboDBsvr.Name = "tboDBsvr"
        Me.tboDBsvr.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboDBsvr.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboDBsvr.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboDBsvr.Properties.Appearance.Options.UseBackColor = True
        Me.tboDBsvr.Properties.Appearance.Options.UseFont = True
        Me.tboDBsvr.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboDBsvr.Properties.NullText = "[Kosong]"
        Me.tboDBsvr.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboDBsvr.Size = New System.Drawing.Size(187, 20)
        Me.tboDBsvr.TabIndex = 36
        Me.tboDBsvr.Tag = "namalengkap"
        '
        'tboDBport
        '
        Me.tboDBport.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboDBport.Location = New System.Drawing.Point(136, 55)
        Me.tboDBport.Margin = New System.Windows.Forms.Padding(0)
        Me.tboDBport.Name = "tboDBport"
        Me.tboDBport.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboDBport.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboDBport.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboDBport.Properties.Appearance.Options.UseBackColor = True
        Me.tboDBport.Properties.Appearance.Options.UseFont = True
        Me.tboDBport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboDBport.Properties.NullText = "[Kosong]"
        Me.tboDBport.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboDBport.Size = New System.Drawing.Size(187, 20)
        Me.tboDBport.TabIndex = 36
        Me.tboDBport.Tag = "namalengkap"
        '
        'tboDBuid
        '
        Me.tboDBuid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboDBuid.Location = New System.Drawing.Point(136, 127)
        Me.tboDBuid.Margin = New System.Windows.Forms.Padding(0)
        Me.tboDBuid.Name = "tboDBuid"
        Me.tboDBuid.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboDBuid.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboDBuid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboDBuid.Properties.Appearance.Options.UseBackColor = True
        Me.tboDBuid.Properties.Appearance.Options.UseFont = True
        Me.tboDBuid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboDBuid.Properties.NullText = "[Kosong]"
        Me.tboDBuid.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboDBuid.Size = New System.Drawing.Size(187, 20)
        Me.tboDBuid.TabIndex = 36
        Me.tboDBuid.Tag = "namalengkap"
        '
        'tboDBpwd
        '
        Me.tboDBpwd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboDBpwd.Location = New System.Drawing.Point(136, 151)
        Me.tboDBpwd.Margin = New System.Windows.Forms.Padding(0)
        Me.tboDBpwd.Name = "tboDBpwd"
        Me.tboDBpwd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboDBpwd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboDBpwd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboDBpwd.Properties.Appearance.Options.UseBackColor = True
        Me.tboDBpwd.Properties.Appearance.Options.UseFont = True
        Me.tboDBpwd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboDBpwd.Properties.NullText = "[Kosong]"
        Me.tboDBpwd.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboDBpwd.Properties.UseSystemPasswordChar = True
        Me.tboDBpwd.Size = New System.Drawing.Size(187, 20)
        Me.tboDBpwd.TabIndex = 36
        Me.tboDBpwd.Tag = "namalengkap"
        '
        'lblDBport
        '
        Me.lblDBport.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDBport.AutoSize = True
        Me.lblDBport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBport.Location = New System.Drawing.Point(49, 58)
        Me.lblDBport.Name = "lblDBport"
        Me.lblDBport.Size = New System.Drawing.Size(84, 14)
        Me.lblDBport.TabIndex = 32
        Me.lblDBport.Text = "Database Port"
        Me.lblDBport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDBsvr
        '
        Me.lblDBsvr.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDBsvr.AutoSize = True
        Me.lblDBsvr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBsvr.Location = New System.Drawing.Point(41, 34)
        Me.lblDBsvr.Name = "lblDBsvr"
        Me.lblDBsvr.Size = New System.Drawing.Size(92, 14)
        Me.lblDBsvr.TabIndex = 32
        Me.lblDBsvr.Text = "IP/Nama Server"
        Me.lblDBsvr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDBname
        '
        Me.lblDBname.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDBname.AutoSize = True
        Me.lblDBname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBname.Location = New System.Drawing.Point(42, 10)
        Me.lblDBname.Name = "lblDBname"
        Me.lblDBname.Size = New System.Drawing.Size(91, 14)
        Me.lblDBname.TabIndex = 32
        Me.lblDBname.Text = "Nama Database"
        Me.lblDBname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDBuid
        '
        Me.lblDBuid.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDBuid.AutoSize = True
        Me.lblDBuid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBuid.Location = New System.Drawing.Point(72, 130)
        Me.lblDBuid.Name = "lblDBuid"
        Me.lblDBuid.Size = New System.Drawing.Size(61, 14)
        Me.lblDBuid.TabIndex = 49
        Me.lblDBuid.Text = "Username"
        Me.lblDBuid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDBpwd
        '
        Me.lblDBpwd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDBpwd.AutoSize = True
        Me.lblDBpwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBpwd.Location = New System.Drawing.Point(75, 154)
        Me.lblDBpwd.Name = "lblDBpwd"
        Me.lblDBpwd.Size = New System.Drawing.Size(58, 14)
        Me.lblDBpwd.TabIndex = 50
        Me.lblDBpwd.Text = "Password"
        Me.lblDBpwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(352, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(292, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 30)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(352, 30)
        Me.pTitle.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(322, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Pengaturan Database"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(322, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 12
        Me.pExit.TabStop = False
        '
        'frmSettingDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(356, 240)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingDB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengaturan Database"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpTop.PerformLayout()
        CType(Me.tboInstance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboSkema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBsvr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBuid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBpwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents tlpTop As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblDBport As System.Windows.Forms.Label
    Friend WithEvents lblDBsvr As System.Windows.Forms.Label
    Friend WithEvents lblDBname As System.Windows.Forms.Label
    Friend WithEvents lblDBuid As System.Windows.Forms.Label
    Friend WithEvents lblDBpwd As System.Windows.Forms.Label
    Friend WithEvents tboDBname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboDBsvr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboDBport As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboDBuid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboDBpwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents tboInstance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboSkema As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
