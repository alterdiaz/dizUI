<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrasiPasienApp
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
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.xtcAdmisi = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpPasien = New DevExpress.XtraTab.XtraTabPage()
        Me.pPasien = New System.Windows.Forms.Panel()
        Me.xtpRegister = New DevExpress.XtraTab.XtraTabPage()
        Me.pRegister = New System.Windows.Forms.Panel()
        Me.xtpAppointment = New DevExpress.XtraTab.XtraTabPage()
        Me.pAppointment = New System.Windows.Forms.Panel()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcAdmisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcAdmisi.SuspendLayout()
        Me.xtpPasien.SuspendLayout()
        Me.xtpRegister.SuspendLayout()
        Me.xtpAppointment.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Controls.Add(Me.xtcAdmisi, 1, 1)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 2
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpForm.Size = New System.Drawing.Size(926, 619)
        Me.tlpForm.TabIndex = 0
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pMinimize)
        Me.pTitle.Controls.Add(Me.pMaximize)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(922, 30)
        Me.pTitle.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(832, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Admisi"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(832, 0)
        Me.pMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMinimize.Name = "pMinimize"
        Me.pMinimize.Size = New System.Drawing.Size(30, 30)
        Me.pMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMinimize.TabIndex = 8
        Me.pMinimize.TabStop = False
        '
        'pMaximize
        '
        Me.pMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMaximize.Image = Global.dizUI.My.Resources.Resources.max_w
        Me.pMaximize.Location = New System.Drawing.Point(862, 0)
        Me.pMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMaximize.Name = "pMaximize"
        Me.pMaximize.Size = New System.Drawing.Size(30, 30)
        Me.pMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMaximize.TabIndex = 7
        Me.pMaximize.TabStop = False
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(892, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'xtcAdmisi
        '
        Me.xtcAdmisi.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcAdmisi.Appearance.Options.UseBackColor = True
        Me.xtcAdmisi.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcAdmisi.AppearancePage.Header.Options.UseFont = True
        Me.xtcAdmisi.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcAdmisi.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcAdmisi.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcAdmisi.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcAdmisi.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcAdmisi.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcAdmisi.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcAdmisi.AppearancePage.PageClient.Options.UseFont = True
        Me.xtcAdmisi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcAdmisi.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcAdmisi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcAdmisi.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcAdmisi.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtcAdmisi.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical
        Me.xtcAdmisi.Location = New System.Drawing.Point(2, 30)
        Me.xtcAdmisi.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcAdmisi.Name = "xtcAdmisi"
        Me.xtcAdmisi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtcAdmisi.SelectedTabPage = Me.xtpPasien
        Me.xtcAdmisi.Size = New System.Drawing.Size(922, 589)
        Me.xtcAdmisi.TabIndex = 18
        Me.xtcAdmisi.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpPasien, Me.xtpRegister, Me.xtpAppointment})
        '
        'xtpPasien
        '
        Me.xtpPasien.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpPasien.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpPasien.Controls.Add(Me.pPasien)
        Me.xtpPasien.Margin = New System.Windows.Forms.Padding(0)
        Me.xtpPasien.Name = "xtpPasien"
        Me.xtpPasien.Size = New System.Drawing.Size(892, 583)
        Me.xtpPasien.Text = "PASIEN"
        '
        'pPasien
        '
        Me.pPasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pPasien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pPasien.Location = New System.Drawing.Point(0, 0)
        Me.pPasien.Margin = New System.Windows.Forms.Padding(0)
        Me.pPasien.Name = "pPasien"
        Me.pPasien.Size = New System.Drawing.Size(892, 583)
        Me.pPasien.TabIndex = 1
        '
        'xtpRegister
        '
        Me.xtpRegister.Controls.Add(Me.pRegister)
        Me.xtpRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.xtpRegister.Name = "xtpRegister"
        Me.xtpRegister.Size = New System.Drawing.Size(892, 583)
        Me.xtpRegister.Text = "REGISTER"
        '
        'pRegister
        '
        Me.pRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pRegister.Location = New System.Drawing.Point(0, 0)
        Me.pRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.pRegister.Name = "pRegister"
        Me.pRegister.Size = New System.Drawing.Size(892, 583)
        Me.pRegister.TabIndex = 2
        '
        'xtpAppointment
        '
        Me.xtpAppointment.Controls.Add(Me.pAppointment)
        Me.xtpAppointment.Name = "xtpAppointment"
        Me.xtpAppointment.Size = New System.Drawing.Size(892, 583)
        Me.xtpAppointment.Text = "APPOINTMENT"
        '
        'pAppointment
        '
        Me.pAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pAppointment.Location = New System.Drawing.Point(0, 0)
        Me.pAppointment.Margin = New System.Windows.Forms.Padding(0)
        Me.pAppointment.Name = "pAppointment"
        Me.pAppointment.Size = New System.Drawing.Size(892, 583)
        Me.pAppointment.TabIndex = 2
        '
        'frmRegistrasiPasienApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(926, 619)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrasiPasienApp"
        Me.ShowInTaskbar = False
        Me.Text = "Admisi"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcAdmisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcAdmisi.ResumeLayout(False)
        Me.xtpPasien.ResumeLayout(False)
        Me.xtpRegister.ResumeLayout(False)
        Me.xtpAppointment.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents pPasien As Panel
    Friend WithEvents xtcAdmisi As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpPasien As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpRegister As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpAppointment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pRegister As Panel
    Friend WithEvents pAppointment As Panel
End Class
