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
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlField = New System.Windows.Forms.Panel()
        Me.lnkNewUser = New System.Windows.Forms.LinkLabel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.tboPassword = New System.Windows.Forms.TextBox()
        Me.tboUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pContent.SuspendLayout()
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
        Me.tlpForm.Size = New System.Drawing.Size(464, 162)
        Me.tlpForm.TabIndex = 0
        '
        'pContent
        '
        Me.pContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pContent.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_msgbox
        Me.pContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pContent.Controls.Add(Me.pbSync)
        Me.pContent.Controls.Add(Me.btnCancel)
        Me.pContent.Controls.Add(Me.pnlField)
        Me.pContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContent.Location = New System.Drawing.Point(2, 2)
        Me.pContent.Margin = New System.Windows.Forms.Padding(0)
        Me.pContent.Name = "pContent"
        Me.pContent.Size = New System.Drawing.Size(460, 158)
        Me.pContent.TabIndex = 0
        '
        'pbSync
        '
        Me.pbSync.BackColor = System.Drawing.Color.Transparent
        Me.pbSync.Image = Global.dizUI.My.Resources.Resources.loading2
        Me.pbSync.Location = New System.Drawing.Point(6, 126)
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
        Me.btnCancel.Location = New System.Drawing.Point(420, 0)
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
        Me.pnlField.BackColor = System.Drawing.Color.Transparent
        Me.pnlField.Controls.Add(Me.lnkNewUser)
        Me.pnlField.Controls.Add(Me.btnOK)
        Me.pnlField.Controls.Add(Me.lblWarning)
        Me.pnlField.Controls.Add(Me.tboPassword)
        Me.pnlField.Controls.Add(Me.tboUsername)
        Me.pnlField.Controls.Add(Me.lblPassword)
        Me.pnlField.Controls.Add(Me.lblUsername)
        Me.pnlField.Location = New System.Drawing.Point(78, 19)
        Me.pnlField.Name = "pnlField"
        Me.pnlField.Size = New System.Drawing.Size(307, 114)
        Me.pnlField.TabIndex = 0
        '
        'lnkNewUser
        '
        Me.lnkNewUser.AutoSize = True
        Me.lnkNewUser.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lnkNewUser.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkNewUser.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lnkNewUser.Location = New System.Drawing.Point(83, 89)
        Me.lnkNewUser.Name = "lnkNewUser"
        Me.lnkNewUser.Size = New System.Drawing.Size(143, 14)
        Me.lnkNewUser.TabIndex = 21
        Me.lnkNewUser.TabStop = True
        Me.lnkNewUser.Text = "Buat akun baru, klik disini"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImage = Global.dizUI.My.Resources.Resources.ok
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(464, 162)
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
End Class
