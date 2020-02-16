<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.niNotify = New System.Windows.Forms.NotifyIcon()
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip()
        Me.tsmiTampilkan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiForceClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.lblProses = New System.Windows.Forms.Label()
        Me.pnlField = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.tboPassword = New System.Windows.Forms.TextBox()
        Me.tboUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.tmrRM = New System.Windows.Forms.Timer()
        Me.tmrCek = New System.Windows.Forms.Timer()
        Me.tmrIRNA = New System.Windows.Forms.Timer()
        Me.tmrIGD = New System.Windows.Forms.Timer()
        Me.tmrIRJ = New System.Windows.Forms.Timer()
        Me.tmrNotes = New System.Windows.Forms.Timer()
        Me.tmrIRM = New System.Windows.Forms.Timer()
        Me.tmrProses = New System.Windows.Forms.Timer()
        Me.cmsMenu.SuspendLayout()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlField.SuspendLayout()
        Me.SuspendLayout()
        '
        'niNotify
        '
        Me.niNotify.ContextMenuStrip = Me.cmsMenu
        Me.niNotify.Icon = CType(resources.GetObject("niNotify.Icon"), System.Drawing.Icon)
        Me.niNotify.Text = "Sistem Notifikasi"
        Me.niNotify.Visible = True
        '
        'cmsMenu
        '
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTampilkan, Me.ToolStripSeparator1, Me.tsmiLogout, Me.tsmiKeluar, Me.ToolStripSeparator2, Me.tsmiForceClose})
        Me.cmsMenu.Name = "cmsMenu"
        Me.cmsMenu.Size = New System.Drawing.Size(139, 104)
        '
        'tsmiTampilkan
        '
        Me.tsmiTampilkan.Name = "tsmiTampilkan"
        Me.tsmiTampilkan.Size = New System.Drawing.Size(138, 22)
        Me.tsmiTampilkan.Text = "Tampilkan"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(135, 6)
        '
        'tsmiLogout
        '
        Me.tsmiLogout.Name = "tsmiLogout"
        Me.tsmiLogout.Size = New System.Drawing.Size(138, 22)
        Me.tsmiLogout.Text = "Log out"
        '
        'tsmiKeluar
        '
        Me.tsmiKeluar.Name = "tsmiKeluar"
        Me.tsmiKeluar.Size = New System.Drawing.Size(138, 22)
        Me.tsmiKeluar.Text = "Tutup"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(135, 6)
        '
        'tsmiForceClose
        '
        Me.tsmiForceClose.Name = "tsmiForceClose"
        Me.tsmiForceClose.Size = New System.Drawing.Size(138, 22)
        Me.tsmiForceClose.Text = "Tutup Paksa"
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(423, 76)
        Me.tlpForm.TabIndex = 1
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.PictureBox1)
        Me.pTitle.Controls.Add(Me.btnMinimize)
        Me.pTitle.Controls.Add(Me.btnMaximize)
        Me.pTitle.Controls.Add(Me.btnExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(419, 30)
        Me.pTitle.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(30, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(299, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Sistem Notifikasi"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.dizNotifikasi.My.Resources.Resources.dizNotif2nb
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = Global.dizNotifikasi.My.Resources.Resources.min_w
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(329, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 23
        Me.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = Global.dizNotifikasi.My.Resources.Resources.max_w
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.Location = New System.Drawing.Point(359, 0)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(30, 30)
        Me.btnMaximize.TabIndex = 22
        Me.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.dizNotifikasi.My.Resources.Resources.exit_w
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(389, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(30, 30)
        Me.btnExit.TabIndex = 21
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.DarkKhaki
        Me.pBody.Controls.Add(Me.pbSync)
        Me.pBody.Controls.Add(Me.lblProses)
        Me.pBody.Controls.Add(Me.pnlField)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(419, 44)
        Me.pBody.TabIndex = 7
        '
        'pbSync
        '
        Me.pbSync.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbSync.BackColor = System.Drawing.Color.Transparent
        Me.pbSync.Image = Global.dizNotifikasi.My.Resources.Resources.loading2
        Me.pbSync.Location = New System.Drawing.Point(7, 7)
        Me.pbSync.Margin = New System.Windows.Forms.Padding(0)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSync.TabIndex = 31
        Me.pbSync.TabStop = False
        '
        'lblProses
        '
        Me.lblProses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProses.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProses.ForeColor = System.Drawing.Color.Black
        Me.lblProses.Location = New System.Drawing.Point(60, 13)
        Me.lblProses.Name = "lblProses"
        Me.lblProses.Size = New System.Drawing.Size(299, 19)
        Me.lblProses.TabIndex = 32
        Me.lblProses.Text = "Sedang proses"
        Me.lblProses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlField
        '
        Me.pnlField.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlField.BackColor = System.Drawing.Color.Transparent
        Me.pnlField.Controls.Add(Me.Label1)
        Me.pnlField.Controls.Add(Me.btnOK)
        Me.pnlField.Controls.Add(Me.lblWarning)
        Me.pnlField.Controls.Add(Me.tboPassword)
        Me.pnlField.Controls.Add(Me.tboUsername)
        Me.pnlField.Controls.Add(Me.lblPassword)
        Me.pnlField.Controls.Add(Me.lblUsername)
        Me.pnlField.Location = New System.Drawing.Point(56, 8)
        Me.pnlField.Name = "pnlField"
        Me.pnlField.Size = New System.Drawing.Size(307, 114)
        Me.pnlField.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Menunggu login dari aplikasi induk / login manual"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = Global.dizNotifikasi.My.Resources.Resources.ok
        Me.btnOK.Location = New System.Drawing.Point(243, 36)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(40, 40)
        Me.btnOK.TabIndex = 20
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblWarning
        '
        Me.lblWarning.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWarning.Location = New System.Drawing.Point(3, 5)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(299, 19)
        Me.lblWarning.TabIndex = 6
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWarning.Visible = False
        '
        'tboPassword
        '
        Me.tboPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboPassword.Location = New System.Drawing.Point(86, 58)
        Me.tboPassword.MaxLength = 10
        Me.tboPassword.Name = "tboPassword"
        Me.tboPassword.Size = New System.Drawing.Size(129, 22)
        Me.tboPassword.TabIndex = 2
        Me.tboPassword.Tag = "password"
        Me.tboPassword.UseSystemPasswordChar = True
        '
        'tboUsername
        '
        Me.tboUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tboUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboUsername.Location = New System.Drawing.Point(86, 29)
        Me.tboUsername.MaxLength = 10
        Me.tboUsername.Name = "tboUsername"
        Me.tboUsername.Size = New System.Drawing.Size(129, 22)
        Me.tboUsername.TabIndex = 1
        Me.tboUsername.Tag = "username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(15, 61)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 14)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(15, 32)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 14)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'tmrRM
        '
        Me.tmrRM.Interval = 1000
        '
        'tmrCek
        '
        Me.tmrCek.Interval = 1000
        '
        'tmrIRNA
        '
        Me.tmrIRNA.Interval = 1000
        '
        'tmrIGD
        '
        Me.tmrIGD.Interval = 1000
        '
        'tmrIRJ
        '
        Me.tmrIRJ.Interval = 1000
        '
        'tmrNotes
        '
        Me.tmrNotes.Interval = 1000
        '
        'tmrIRM
        '
        Me.tmrIRM.Interval = 1000
        '
        'tmrProses
        '
        Me.tmrProses.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(423, 76)
        Me.Controls.Add(Me.tlpForm)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Notifikasi"
        Me.cmsMenu.ResumeLayout(False)
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlField.ResumeLayout(False)
        Me.pnlField.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents niNotify As System.Windows.Forms.NotifyIcon
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents btnMinimize As System.Windows.Forms.Button
    Public WithEvents btnMaximize As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlField As Panel
    Public WithEvents btnOK As Button
    Friend WithEvents lblWarning As Label
    Friend WithEvents tboPassword As TextBox
    Friend WithEvents tboUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents tmrRM As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents pbSync As PictureBox
    Friend WithEvents tmrCek As Timer
    Friend WithEvents tmrIRNA As Timer
    Friend WithEvents tmrIGD As Timer
    Friend WithEvents tmrIRJ As Timer
    Friend WithEvents cmsMenu As ContextMenuStrip
    Friend WithEvents tsmiTampilkan As ToolStripMenuItem
    Friend WithEvents tsmiKeluar As ToolStripMenuItem
    Friend WithEvents lblProses As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmiLogout As ToolStripMenuItem
    Friend WithEvents tmrNotes As Timer
    Friend WithEvents tmrIRM As Timer
    Friend WithEvents tmrProses As Timer
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmiForceClose As ToolStripMenuItem
End Class
