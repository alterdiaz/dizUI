<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotifbox
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
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.tmrWaktu = New System.Windows.Forms.Timer()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Navy
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
        Me.tlpForm.Size = New System.Drawing.Size(423, 162)
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
        Me.PictureBox1.Image = Global.dizNotifikasi.My.Resources.Resources.dizNotif
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
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pBody.Controls.Add(Me.btnOK)
        Me.pBody.Controls.Add(Me.pbLogo)
        Me.pBody.Controls.Add(Me.lblContent)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(419, 130)
        Me.pBody.TabIndex = 7
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
        Me.btnOK.Location = New System.Drawing.Point(15, 79)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(40, 40)
        Me.btnOK.TabIndex = 21
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.dizNotifikasi.My.Resources.Resources.ico_warning
        Me.pbLogo.Location = New System.Drawing.Point(15, 12)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(8)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(40, 40)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 15
        Me.pbLogo.TabStop = False
        '
        'lblContent
        '
        Me.lblContent.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblContent.Location = New System.Drawing.Point(71, 8)
        Me.lblContent.Margin = New System.Windows.Forms.Padding(8)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Padding = New System.Windows.Forms.Padding(8)
        Me.lblContent.Size = New System.Drawing.Size(340, 114)
        Me.lblContent.TabIndex = 10
        Me.lblContent.Text = "-"
        Me.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrWaktu
        '
        Me.tmrWaktu.Interval = 5000
        '
        'frmNotifbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(423, 162)
        Me.Controls.Add(Me.tlpForm)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotifbox"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOTH Notifications"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents btnMinimize As System.Windows.Forms.Button
    Public WithEvents btnMaximize As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Public WithEvents btnOK As Button
    Friend WithEvents tmrWaktu As Timer
End Class
