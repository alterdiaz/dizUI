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
        Me.lblDBtype = New System.Windows.Forms.Label()
        Me.lueDBtype = New DevExpress.XtraEditors.LookUpEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        CType(Me.tboDBname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBsvr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBuid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDBpwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDBtype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(507, 223)
        Me.tlpForm.TabIndex = 8
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.DarkKhaki
        Me.pBody.Controls.Add(Me.tlpTop)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(503, 191)
        Me.pBody.TabIndex = 7
        '
        'tlpTop
        '
        Me.tlpTop.ColumnCount = 4
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Controls.Add(Me.tboDBname, 2, 1)
        Me.tlpTop.Controls.Add(Me.tboDBsvr, 2, 2)
        Me.tlpTop.Controls.Add(Me.tboDBport, 2, 3)
        Me.tlpTop.Controls.Add(Me.tboDBuid, 2, 4)
        Me.tlpTop.Controls.Add(Me.tboDBpwd, 2, 5)
        Me.tlpTop.Controls.Add(Me.lblDBport, 1, 3)
        Me.tlpTop.Controls.Add(Me.lblDBsvr, 1, 2)
        Me.tlpTop.Controls.Add(Me.lblDBname, 1, 1)
        Me.tlpTop.Controls.Add(Me.lblDBuid, 1, 4)
        Me.tlpTop.Controls.Add(Me.lblDBpwd, 1, 5)
        Me.tlpTop.Controls.Add(Me.lblDBtype, 1, 6)
        Me.tlpTop.Controls.Add(Me.lueDBtype, 2, 6)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Location = New System.Drawing.Point(0, 30)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 8
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTop.Size = New System.Drawing.Size(503, 161)
        Me.tlpTop.TabIndex = 5
        '
        'tboDBname
        '
        Me.tboDBname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboDBname.Location = New System.Drawing.Point(176, 10)
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
        Me.tboDBsvr.Location = New System.Drawing.Point(176, 34)
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
        Me.tboDBport.Location = New System.Drawing.Point(176, 58)
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
        Me.tboDBuid.Location = New System.Drawing.Point(176, 82)
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
        Me.tboDBpwd.Location = New System.Drawing.Point(176, 106)
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
        Me.tboDBpwd.Size = New System.Drawing.Size(187, 20)
        Me.tboDBpwd.TabIndex = 36
        Me.tboDBpwd.Tag = "namalengkap"
        '
        'lblDBport
        '
        Me.lblDBport.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDBport.AutoSize = True
        Me.lblDBport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBport.Location = New System.Drawing.Point(89, 61)
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
        Me.lblDBsvr.Location = New System.Drawing.Point(69, 37)
        Me.lblDBsvr.Name = "lblDBsvr"
        Me.lblDBsvr.Size = New System.Drawing.Size(104, 14)
        Me.lblDBsvr.TabIndex = 32
        Me.lblDBsvr.Text = "IP Address Server"
        Me.lblDBsvr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDBname
        '
        Me.lblDBname.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDBname.AutoSize = True
        Me.lblDBname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBname.Location = New System.Drawing.Point(82, 13)
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
        Me.lblDBuid.Location = New System.Drawing.Point(112, 85)
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
        Me.lblDBpwd.Location = New System.Drawing.Point(115, 109)
        Me.lblDBpwd.Name = "lblDBpwd"
        Me.lblDBpwd.Size = New System.Drawing.Size(58, 14)
        Me.lblDBpwd.TabIndex = 50
        Me.lblDBpwd.Text = "Password"
        Me.lblDBpwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDBtype
        '
        Me.lblDBtype.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDBtype.AutoSize = True
        Me.lblDBtype.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBtype.Location = New System.Drawing.Point(86, 133)
        Me.lblDBtype.Name = "lblDBtype"
        Me.lblDBtype.Size = New System.Drawing.Size(87, 14)
        Me.lblDBtype.TabIndex = 51
        Me.lblDBtype.Text = "Jenis Database"
        Me.lblDBtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueDBtype
        '
        Me.lueDBtype.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueDBtype.Location = New System.Drawing.Point(176, 130)
        Me.lueDBtype.Margin = New System.Windows.Forms.Padding(0)
        Me.lueDBtype.Name = "lueDBtype"
        Me.lueDBtype.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueDBtype.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDBtype.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueDBtype.Properties.Appearance.Options.UseBackColor = True
        Me.lueDBtype.Properties.Appearance.Options.UseFont = True
        Me.lueDBtype.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueDBtype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDBtype.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueDBtype.Properties.NullText = "[Isian belum dipilih]"
        Me.lueDBtype.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueDBtype.Size = New System.Drawing.Size(126, 20)
        Me.lueDBtype.TabIndex = 56
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
        Me.pHeader.Size = New System.Drawing.Size(503, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(443, 0)
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
        Me.pTitle.Size = New System.Drawing.Size(503, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(473, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Pengaturan Database"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(473, 0)
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
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(507, 223)
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
        CType(Me.tboDBname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBsvr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBuid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDBpwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDBtype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblDBtype As System.Windows.Forms.Label
    Friend WithEvents lueDBtype As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tboDBname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboDBsvr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboDBport As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboDBuid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tboDBpwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
