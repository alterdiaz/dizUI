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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmr = New System.Windows.Forms.Timer()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.pVideo = New System.Windows.Forms.Panel()
        Me.vspVideo = New AForge.Controls.VideoSourcePlayer()
        Me.pNote = New System.Windows.Forms.Panel()
        Me.lblNote2 = New System.Windows.Forms.Label()
        Me.lblNote1 = New System.Windows.Forms.Label()
        Me.pAntrian3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblParamedis3 = New System.Windows.Forms.Label()
        Me.lblRoom3 = New System.Windows.Forms.Label()
        Me.lblAntrian3 = New System.Windows.Forms.Label()
        Me.pAntrian2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblParamedis2 = New System.Windows.Forms.Label()
        Me.lblRoom2 = New System.Windows.Forms.Label()
        Me.lblAntrian2 = New System.Windows.Forms.Label()
        Me.pAntrian1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblParamedis1 = New System.Windows.Forms.Label()
        Me.lblRoom1 = New System.Windows.Forms.Label()
        Me.lblAntrian1 = New System.Windows.Forms.Label()
        Me.pboLogo = New System.Windows.Forms.PictureBox()
        Me.pVideo.SuspendLayout()
        Me.pNote.SuspendLayout()
        Me.pAntrian3.SuspendLayout()
        Me.pAntrian2.SuspendLayout()
        Me.pAntrian1.SuspendLayout()
        CType(Me.pboLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1267, 728)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'tmr
        '
        Me.tmr.Interval = 1000
        '
        'lblWaktu
        '
        Me.lblWaktu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWaktu.BackColor = System.Drawing.Color.Transparent
        Me.lblWaktu.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lblWaktu.ForeColor = System.Drawing.Color.Transparent
        Me.lblWaktu.Location = New System.Drawing.Point(1144, 0)
        Me.lblWaktu.Margin = New System.Windows.Forms.Padding(0)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(206, 64)
        Me.lblWaktu.TabIndex = 17
        Me.lblWaktu.Text = "Mar, 00 0000"
        Me.lblWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pVideo
        '
        Me.pVideo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pVideo.BackColor = System.Drawing.Color.Black
        Me.pVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pVideo.Controls.Add(Me.vspVideo)
        Me.pVideo.Location = New System.Drawing.Point(9, 77)
        Me.pVideo.Margin = New System.Windows.Forms.Padding(0)
        Me.pVideo.Name = "pVideo"
        Me.pVideo.Size = New System.Drawing.Size(930, 620)
        Me.pVideo.TabIndex = 20
        '
        'vspVideo
        '
        Me.vspVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.vspVideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vspVideo.Location = New System.Drawing.Point(0, 0)
        Me.vspVideo.Margin = New System.Windows.Forms.Padding(0)
        Me.vspVideo.Name = "vspVideo"
        Me.vspVideo.Size = New System.Drawing.Size(930, 620)
        Me.vspVideo.TabIndex = 0
        Me.vspVideo.Text = "VideoSourcePlayer1"
        Me.vspVideo.VideoSource = Nothing
        '
        'pNote
        '
        Me.pNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pNote.Controls.Add(Me.lblNote2)
        Me.pNote.Controls.Add(Me.lblNote1)
        Me.pNote.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.pNote.ForeColor = System.Drawing.Color.White
        Me.pNote.Location = New System.Drawing.Point(9, 715)
        Me.pNote.Margin = New System.Windows.Forms.Padding(0)
        Me.pNote.Name = "pNote"
        Me.pNote.Size = New System.Drawing.Size(1341, 40)
        Me.pNote.TabIndex = 21
        '
        'lblNote2
        '
        Me.lblNote2.BackColor = System.Drawing.Color.Black
        Me.lblNote2.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.lblNote2.ForeColor = System.Drawing.Color.White
        Me.lblNote2.Location = New System.Drawing.Point(670, 4)
        Me.lblNote2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNote2.Name = "lblNote2"
        Me.lblNote2.Size = New System.Drawing.Size(0, 33)
        Me.lblNote2.TabIndex = 8
        Me.lblNote2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNote1
        '
        Me.lblNote1.BackColor = System.Drawing.Color.Black
        Me.lblNote1.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.lblNote1.ForeColor = System.Drawing.Color.White
        Me.lblNote1.Location = New System.Drawing.Point(0, 3)
        Me.lblNote1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNote1.Name = "lblNote1"
        Me.lblNote1.Size = New System.Drawing.Size(0, 33)
        Me.lblNote1.TabIndex = 7
        Me.lblNote1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pAntrian3
        '
        Me.pAntrian3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pAntrian3.BackColor = System.Drawing.Color.Transparent
        Me.pAntrian3.BackgroundImage = Global.dizMonitorAntrian.My.Resources.Resources.slotantrian
        Me.pAntrian3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pAntrian3.Controls.Add(Me.Label9)
        Me.pAntrian3.Controls.Add(Me.lblParamedis3)
        Me.pAntrian3.Controls.Add(Me.lblRoom3)
        Me.pAntrian3.Controls.Add(Me.lblAntrian3)
        Me.pAntrian3.Location = New System.Drawing.Point(950, 491)
        Me.pAntrian3.Margin = New System.Windows.Forms.Padding(0)
        Me.pAntrian3.Name = "pAntrian3"
        Me.pAntrian3.Padding = New System.Windows.Forms.Padding(12)
        Me.pAntrian3.Size = New System.Drawing.Size(400, 207)
        Me.pAntrian3.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Italic)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 94)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 30)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "antrian ke"
        '
        'lblParamedis3
        '
        Me.lblParamedis3.AutoEllipsis = True
        Me.lblParamedis3.BackColor = System.Drawing.Color.Transparent
        Me.lblParamedis3.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblParamedis3.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.lblParamedis3.ForeColor = System.Drawing.Color.Black
        Me.lblParamedis3.Location = New System.Drawing.Point(12, 56)
        Me.lblParamedis3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblParamedis3.Name = "lblParamedis3"
        Me.lblParamedis3.Size = New System.Drawing.Size(376, 40)
        Me.lblParamedis3.TabIndex = 18
        Me.lblParamedis3.Text = "dr. Lewis  Lie, Sp.B FINACS"
        Me.lblParamedis3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRoom3
        '
        Me.lblRoom3.AutoEllipsis = True
        Me.lblRoom3.BackColor = System.Drawing.Color.Transparent
        Me.lblRoom3.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRoom3.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblRoom3.ForeColor = System.Drawing.Color.Black
        Me.lblRoom3.Location = New System.Drawing.Point(12, 12)
        Me.lblRoom3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRoom3.Name = "lblRoom3"
        Me.lblRoom3.Size = New System.Drawing.Size(376, 44)
        Me.lblRoom3.TabIndex = 19
        Me.lblRoom3.Text = "Exam 3"
        Me.lblRoom3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAntrian3
        '
        Me.lblAntrian3.AutoSize = True
        Me.lblAntrian3.BackColor = System.Drawing.Color.Transparent
        Me.lblAntrian3.Font = New System.Drawing.Font("Calibri", 100.0!, System.Drawing.FontStyle.Bold)
        Me.lblAntrian3.ForeColor = System.Drawing.Color.Black
        Me.lblAntrian3.Location = New System.Drawing.Point(109, 60)
        Me.lblAntrian3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAntrian3.Name = "lblAntrian3"
        Me.lblAntrian3.Size = New System.Drawing.Size(274, 164)
        Me.lblAntrian3.TabIndex = 21
        Me.lblAntrian3.Text = "001"
        Me.lblAntrian3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pAntrian2
        '
        Me.pAntrian2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pAntrian2.BackColor = System.Drawing.Color.Transparent
        Me.pAntrian2.BackgroundImage = Global.dizMonitorAntrian.My.Resources.Resources.slotantrian
        Me.pAntrian2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pAntrian2.Controls.Add(Me.Label5)
        Me.pAntrian2.Controls.Add(Me.lblParamedis2)
        Me.pAntrian2.Controls.Add(Me.lblRoom2)
        Me.pAntrian2.Controls.Add(Me.lblAntrian2)
        Me.pAntrian2.Location = New System.Drawing.Point(950, 284)
        Me.pAntrian2.Margin = New System.Windows.Forms.Padding(0)
        Me.pAntrian2.Name = "pAntrian2"
        Me.pAntrian2.Padding = New System.Windows.Forms.Padding(12)
        Me.pAntrian2.Size = New System.Drawing.Size(400, 207)
        Me.pAntrian2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 30)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "antrian ke"
        '
        'lblParamedis2
        '
        Me.lblParamedis2.AutoEllipsis = True
        Me.lblParamedis2.BackColor = System.Drawing.Color.Transparent
        Me.lblParamedis2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblParamedis2.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.lblParamedis2.ForeColor = System.Drawing.Color.Black
        Me.lblParamedis2.Location = New System.Drawing.Point(12, 56)
        Me.lblParamedis2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblParamedis2.Name = "lblParamedis2"
        Me.lblParamedis2.Size = New System.Drawing.Size(376, 40)
        Me.lblParamedis2.TabIndex = 18
        Me.lblParamedis2.Text = "dr. Henry Ricardo Handoyo, Sp.OT"
        Me.lblParamedis2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRoom2
        '
        Me.lblRoom2.AutoEllipsis = True
        Me.lblRoom2.BackColor = System.Drawing.Color.Transparent
        Me.lblRoom2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRoom2.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblRoom2.ForeColor = System.Drawing.Color.Black
        Me.lblRoom2.Location = New System.Drawing.Point(12, 12)
        Me.lblRoom2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRoom2.Name = "lblRoom2"
        Me.lblRoom2.Size = New System.Drawing.Size(376, 44)
        Me.lblRoom2.TabIndex = 19
        Me.lblRoom2.Text = "Exam 2"
        Me.lblRoom2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAntrian2
        '
        Me.lblAntrian2.AutoSize = True
        Me.lblAntrian2.BackColor = System.Drawing.Color.Transparent
        Me.lblAntrian2.Font = New System.Drawing.Font("Calibri", 100.0!, System.Drawing.FontStyle.Bold)
        Me.lblAntrian2.ForeColor = System.Drawing.Color.Black
        Me.lblAntrian2.Location = New System.Drawing.Point(109, 60)
        Me.lblAntrian2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAntrian2.Name = "lblAntrian2"
        Me.lblAntrian2.Size = New System.Drawing.Size(274, 164)
        Me.lblAntrian2.TabIndex = 21
        Me.lblAntrian2.Text = "001"
        Me.lblAntrian2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pAntrian1
        '
        Me.pAntrian1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pAntrian1.BackColor = System.Drawing.Color.Transparent
        Me.pAntrian1.BackgroundImage = Global.dizMonitorAntrian.My.Resources.Resources.slotantrian
        Me.pAntrian1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pAntrian1.Controls.Add(Me.Label3)
        Me.pAntrian1.Controls.Add(Me.lblParamedis1)
        Me.pAntrian1.Controls.Add(Me.lblRoom1)
        Me.pAntrian1.Controls.Add(Me.lblAntrian1)
        Me.pAntrian1.Location = New System.Drawing.Point(950, 77)
        Me.pAntrian1.Margin = New System.Windows.Forms.Padding(0)
        Me.pAntrian1.Name = "pAntrian1"
        Me.pAntrian1.Padding = New System.Windows.Forms.Padding(12)
        Me.pAntrian1.Size = New System.Drawing.Size(400, 207)
        Me.pAntrian1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 30)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "antrian ke"
        '
        'lblParamedis1
        '
        Me.lblParamedis1.AutoEllipsis = True
        Me.lblParamedis1.BackColor = System.Drawing.Color.Transparent
        Me.lblParamedis1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblParamedis1.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.lblParamedis1.ForeColor = System.Drawing.Color.Black
        Me.lblParamedis1.Location = New System.Drawing.Point(12, 56)
        Me.lblParamedis1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblParamedis1.Name = "lblParamedis1"
        Me.lblParamedis1.Size = New System.Drawing.Size(376, 40)
        Me.lblParamedis1.TabIndex = 18
        Me.lblParamedis1.Text = "Dr. Komang Agung I. S., Sp.OT"
        Me.lblParamedis1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRoom1
        '
        Me.lblRoom1.AutoEllipsis = True
        Me.lblRoom1.BackColor = System.Drawing.Color.Transparent
        Me.lblRoom1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRoom1.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblRoom1.ForeColor = System.Drawing.Color.Black
        Me.lblRoom1.Location = New System.Drawing.Point(12, 12)
        Me.lblRoom1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRoom1.Name = "lblRoom1"
        Me.lblRoom1.Size = New System.Drawing.Size(376, 44)
        Me.lblRoom1.TabIndex = 19
        Me.lblRoom1.Text = "Exam 1"
        Me.lblRoom1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAntrian1
        '
        Me.lblAntrian1.AutoSize = True
        Me.lblAntrian1.BackColor = System.Drawing.Color.Transparent
        Me.lblAntrian1.Font = New System.Drawing.Font("Calibri", 100.0!, System.Drawing.FontStyle.Bold)
        Me.lblAntrian1.ForeColor = System.Drawing.Color.Black
        Me.lblAntrian1.Location = New System.Drawing.Point(109, 60)
        Me.lblAntrian1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAntrian1.Name = "lblAntrian1"
        Me.lblAntrian1.Size = New System.Drawing.Size(274, 164)
        Me.lblAntrian1.TabIndex = 21
        Me.lblAntrian1.Text = "001"
        Me.lblAntrian1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pboLogo
        '
        Me.pboLogo.BackColor = System.Drawing.Color.Transparent
        Me.pboLogo.Location = New System.Drawing.Point(16, 0)
        Me.pboLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.pboLogo.Name = "pboLogo"
        Me.pboLogo.Size = New System.Drawing.Size(206, 64)
        Me.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pboLogo.TabIndex = 11
        Me.pboLogo.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pNote)
        Me.Controls.Add(Me.pVideo)
        Me.Controls.Add(Me.pAntrian3)
        Me.Controls.Add(Me.pAntrian2)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.pAntrian1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pboLogo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitor Queue"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pVideo.ResumeLayout(False)
        Me.pNote.ResumeLayout(False)
        Me.pAntrian3.ResumeLayout(False)
        Me.pAntrian3.PerformLayout()
        Me.pAntrian2.ResumeLayout(False)
        Me.pAntrian2.PerformLayout()
        Me.pAntrian1.ResumeLayout(False)
        Me.pAntrian1.PerformLayout()
        CType(Me.pboLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents pAntrian1 As System.Windows.Forms.Panel
    Friend WithEvents lblWaktu As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblParamedis1 As System.Windows.Forms.Label
    Friend WithEvents lblRoom1 As System.Windows.Forms.Label
    Friend WithEvents lblAntrian1 As System.Windows.Forms.Label
    Friend WithEvents pAntrian2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblParamedis2 As System.Windows.Forms.Label
    Friend WithEvents lblRoom2 As System.Windows.Forms.Label
    Friend WithEvents lblAntrian2 As System.Windows.Forms.Label
    Friend WithEvents pAntrian3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblParamedis3 As System.Windows.Forms.Label
    Friend WithEvents lblRoom3 As System.Windows.Forms.Label
    Friend WithEvents lblAntrian3 As System.Windows.Forms.Label
    Friend WithEvents pVideo As System.Windows.Forms.Panel
    Friend WithEvents pNote As System.Windows.Forms.Panel
    Friend WithEvents lblNote1 As System.Windows.Forms.Label
    Friend WithEvents vspVideo As AForge.Controls.VideoSourcePlayer
    Friend WithEvents lblNote2 As System.Windows.Forms.Label
   



End Class
