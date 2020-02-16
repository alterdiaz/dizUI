<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pContent = New System.Windows.Forms.Panel()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.pbScan = New System.Windows.Forms.PictureBox()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlField = New System.Windows.Forms.Panel()
        Me.btnWebcam = New System.Windows.Forms.Button()
        Me.btnNFC = New System.Windows.Forms.Button()
        Me.btnQR = New System.Windows.Forms.Button()
        Me.btnQRWebcam = New System.Windows.Forms.Button()
        Me.lnkNewUser = New System.Windows.Forms.LinkLabel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.tboPassword = New System.Windows.Forms.TextBox()
        Me.tboUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.tboScan = New System.Windows.Forms.TextBox()
        Me.tlpForm.SuspendLayout()
        Me.pContent.SuspendLayout()
        CType(Me.pbScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlField.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pContent, 1, 1)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(620, 300)
        Me.tlpForm.TabIndex = 0
        '
        'pContent
        '
        Me.pContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pContent.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_splash3
        Me.pContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pContent.Controls.Add(Me.btnCapture)
        Me.pContent.Controls.Add(Me.pbScan)
        Me.pContent.Controls.Add(Me.pbSync)
        Me.pContent.Controls.Add(Me.btnCancel)
        Me.pContent.Controls.Add(Me.pnlField)
        Me.pContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContent.Location = New System.Drawing.Point(2, 2)
        Me.pContent.Margin = New System.Windows.Forms.Padding(0)
        Me.pContent.Name = "pContent"
        Me.pContent.Size = New System.Drawing.Size(616, 296)
        Me.pContent.TabIndex = 0
        '
        'btnCapture
        '
        Me.btnCapture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCapture.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapture.FlatAppearance.BorderSize = 0
        Me.btnCapture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCapture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapture.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Location = New System.Drawing.Point(261, 228)
        Me.btnCapture.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(60, 24)
        Me.btnCapture.TabIndex = 32
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCapture.UseVisualStyleBackColor = False
        Me.btnCapture.Visible = False
        '
        'pbScan
        '
        Me.pbScan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbScan.BackColor = System.Drawing.Color.Black
        Me.pbScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbScan.Location = New System.Drawing.Point(6, 78)
        Me.pbScan.Margin = New System.Windows.Forms.Padding(0)
        Me.pbScan.Name = "pbScan"
        Me.pbScan.Size = New System.Drawing.Size(324, 182)
        Me.pbScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbScan.TabIndex = 31
        Me.pbScan.TabStop = False
        Me.pbScan.Visible = False
        '
        'pbSync
        '
        Me.pbSync.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbSync.BackColor = System.Drawing.Color.Transparent
        Me.pbSync.Image = Global.dizUI.My.Resources.Resources.loading2
        Me.pbSync.Location = New System.Drawing.Point(580, 259)
        Me.pbSync.Margin = New System.Windows.Forms.Padding(0)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSync.TabIndex = 30
        Me.pbSync.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = Global.dizUI.My.Resources.Resources.exit_n
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(576, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(40, 40)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pnlField
        '
        Me.pnlField.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlField.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlField.Controls.Add(Me.btnWebcam)
        Me.pnlField.Controls.Add(Me.btnNFC)
        Me.pnlField.Controls.Add(Me.btnQR)
        Me.pnlField.Controls.Add(Me.btnQRWebcam)
        Me.pnlField.Controls.Add(Me.lnkNewUser)
        Me.pnlField.Controls.Add(Me.btnOK)
        Me.pnlField.Controls.Add(Me.lblWarning)
        Me.pnlField.Controls.Add(Me.tboPassword)
        Me.pnlField.Controls.Add(Me.tboUsername)
        Me.pnlField.Controls.Add(Me.lblPassword)
        Me.pnlField.Controls.Add(Me.lblUsername)
        Me.pnlField.Controls.Add(Me.tboScan)
        Me.pnlField.Location = New System.Drawing.Point(336, 78)
        Me.pnlField.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlField.Name = "pnlField"
        Me.pnlField.Size = New System.Drawing.Size(274, 182)
        Me.pnlField.TabIndex = 0
        '
        'btnWebcam
        '
        Me.btnWebcam.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnWebcam.BackColor = System.Drawing.Color.Transparent
        Me.btnWebcam.BackgroundImage = Global.dizUI.My.Resources.Resources.sWebcam
        Me.btnWebcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWebcam.FlatAppearance.BorderSize = 0
        Me.btnWebcam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnWebcam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWebcam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWebcam.Location = New System.Drawing.Point(31, 115)
        Me.btnWebcam.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWebcam.Name = "btnWebcam"
        Me.btnWebcam.Size = New System.Drawing.Size(40, 40)
        Me.btnWebcam.TabIndex = 25
        Me.btnWebcam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWebcam.UseVisualStyleBackColor = False
        '
        'btnNFC
        '
        Me.btnNFC.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNFC.BackColor = System.Drawing.Color.Transparent
        Me.btnNFC.BackgroundImage = Global.dizUI.My.Resources.Resources.sNFC
        Me.btnNFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNFC.FlatAppearance.BorderSize = 0
        Me.btnNFC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNFC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnNFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNFC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNFC.Location = New System.Drawing.Point(175, 115)
        Me.btnNFC.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNFC.Name = "btnNFC"
        Me.btnNFC.Size = New System.Drawing.Size(40, 40)
        Me.btnNFC.TabIndex = 24
        Me.btnNFC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNFC.UseVisualStyleBackColor = False
        '
        'btnQR
        '
        Me.btnQR.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQR.BackColor = System.Drawing.Color.Transparent
        Me.btnQR.BackgroundImage = Global.dizUI.My.Resources.Resources.sQRcode
        Me.btnQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQR.FlatAppearance.BorderSize = 0
        Me.btnQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQR.Location = New System.Drawing.Point(127, 115)
        Me.btnQR.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQR.Name = "btnQR"
        Me.btnQR.Size = New System.Drawing.Size(40, 40)
        Me.btnQR.TabIndex = 23
        Me.btnQR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQR.UseVisualStyleBackColor = False
        '
        'btnQRWebcam
        '
        Me.btnQRWebcam.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQRWebcam.BackColor = System.Drawing.Color.Transparent
        Me.btnQRWebcam.BackgroundImage = Global.dizUI.My.Resources.Resources.sQRwebcam
        Me.btnQRWebcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQRWebcam.FlatAppearance.BorderSize = 0
        Me.btnQRWebcam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQRWebcam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnQRWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQRWebcam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQRWebcam.Location = New System.Drawing.Point(79, 114)
        Me.btnQRWebcam.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQRWebcam.Name = "btnQRWebcam"
        Me.btnQRWebcam.Size = New System.Drawing.Size(40, 40)
        Me.btnQRWebcam.TabIndex = 22
        Me.btnQRWebcam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQRWebcam.UseVisualStyleBackColor = False
        '
        'lnkNewUser
        '
        Me.lnkNewUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lnkNewUser.AutoSize = True
        Me.lnkNewUser.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lnkNewUser.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkNewUser.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lnkNewUser.Location = New System.Drawing.Point(72, 160)
        Me.lnkNewUser.Name = "lnkNewUser"
        Me.lnkNewUser.Size = New System.Drawing.Size(143, 14)
        Me.lnkNewUser.TabIndex = 21
        Me.lnkNewUser.TabStop = True
        Me.lnkNewUser.Text = "Buat akun baru, klik disini"
        Me.lnkNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImage = Global.dizUI.My.Resources.Resources.ok
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(222, 72)
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
        Me.lblWarning.Location = New System.Drawing.Point(5, 5)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(264, 19)
        Me.lblWarning.TabIndex = 6
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWarning.Visible = False
        '
        'tboPassword
        '
        Me.tboPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboPassword.Location = New System.Drawing.Point(86, 57)
        Me.tboPassword.MaxLength = 20
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
        Me.tboUsername.MaxLength = 500
        Me.tboUsername.Name = "tboUsername"
        Me.tboUsername.Size = New System.Drawing.Size(129, 22)
        Me.tboUsername.TabIndex = 1
        Me.tboUsername.Tag = "username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(19, 59)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 14)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(19, 31)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 14)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'tboScan
        '
        Me.tboScan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tboScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboScan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboScan.Location = New System.Drawing.Point(22, 85)
        Me.tboScan.MaxLength = 100
        Me.tboScan.Name = "tboScan"
        Me.tboScan.Size = New System.Drawing.Size(193, 22)
        Me.tboScan.TabIndex = 26
        Me.tboScan.Tag = ""
        Me.tboScan.UseSystemPasswordChar = True
        Me.tboScan.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(620, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Login"
        Me.tlpForm.ResumeLayout(False)
        Me.pContent.ResumeLayout(False)
        CType(Me.pbScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlField.ResumeLayout(False)
        Me.pnlField.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pContent As System.Windows.Forms.Panel
    Friend WithEvents pnlField As System.Windows.Forms.Panel
    Friend WithEvents tboPassword As System.Windows.Forms.TextBox
    Friend WithEvents tboUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Public WithEvents btnCancel As System.Windows.Forms.Button
    Public WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lnkNewUser As System.Windows.Forms.LinkLabel
    Friend WithEvents pbSync As PictureBox
    Public WithEvents btnWebcam As Button
    Public WithEvents btnNFC As Button
    Public WithEvents btnQR As Button
    Public WithEvents btnQRWebcam As Button
    Friend WithEvents tboScan As TextBox
    Friend WithEvents pbScan As PictureBox
    Public WithEvents btnCapture As Button
End Class
