<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.UpdSave = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.tmrAuto = New System.Windows.Forms.Timer(Me.components)
        Me.cboAutoRun = New System.Windows.Forms.CheckBox()
        Me.pCounter = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblIPSvr = New System.Windows.Forms.Label()
        Me.lblDBname = New System.Windows.Forms.Label()
        Me.tboIPsvr = New System.Windows.Forms.TextBox()
        Me.tboDBname = New System.Windows.Forms.TextBox()
        Me.tboUsr = New System.Windows.Forms.TextBox()
        Me.tboPass = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboPort = New System.Windows.Forms.TextBox()
        Me.tboSkema = New System.Windows.Forms.TextBox()
        Me.tboInstance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbAppIcon = New System.Windows.Forms.PictureBox()
        Me.pCounter.SuspendLayout()
        CType(Me.pbAppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(382, 29)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Application Setting"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdSave
        '
        Me.UpdSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.UpdSave.BackColor = System.Drawing.Color.Khaki
        Me.UpdSave.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.UpdSave.FlatAppearance.BorderSize = 2
        Me.UpdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdSave.Location = New System.Drawing.Point(137, 300)
        Me.UpdSave.Name = "UpdSave"
        Me.UpdSave.Size = New System.Drawing.Size(75, 30)
        Me.UpdSave.TabIndex = 13
        Me.UpdSave.Text = "Save"
        Me.UpdSave.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnKeluar.FlatAppearance.BorderSize = 2
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(56, 300)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 30)
        Me.btnKeluar.TabIndex = 14
        Me.btnKeluar.Text = "Exit"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnRun
        '
        Me.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRun.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnRun.FlatAppearance.BorderSize = 2
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(218, 300)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(109, 30)
        Me.btnRun.TabIndex = 15
        Me.btnRun.Text = "Run Apps"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'tmrAuto
        '
        Me.tmrAuto.Interval = 1000
        '
        'cboAutoRun
        '
        Me.cboAutoRun.AutoSize = True
        Me.cboAutoRun.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.cboAutoRun.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboAutoRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAutoRun.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboAutoRun.Location = New System.Drawing.Point(137, 275)
        Me.cboAutoRun.Name = "cboAutoRun"
        Me.cboAutoRun.Size = New System.Drawing.Size(97, 19)
        Me.cboAutoRun.TabIndex = 16
        Me.cboAutoRun.Text = "Autorun Apps"
        Me.cboAutoRun.UseVisualStyleBackColor = True
        '
        'pCounter
        '
        Me.pCounter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pCounter.BackColor = System.Drawing.Color.Khaki
        Me.pCounter.Controls.Add(Me.btnCancel)
        Me.pCounter.Controls.Add(Me.lblCounter)
        Me.pCounter.Location = New System.Drawing.Point(335, 324)
        Me.pCounter.Name = "pCounter"
        Me.pCounter.Size = New System.Drawing.Size(358, 301)
        Me.pCounter.TabIndex = 17
        Me.pCounter.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(277, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblCounter
        '
        Me.lblCounter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCounter.Font = New System.Drawing.Font("Segoe UI", 22.0!)
        Me.lblCounter.Location = New System.Drawing.Point(6, 43)
        Me.lblCounter.Margin = New System.Windows.Forms.Padding(6)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(346, 252)
        Me.lblCounter.TabIndex = 0
        Me.lblCounter.Text = "Autorun Apps in:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 seconds"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIPSvr
        '
        Me.lblIPSvr.AutoSize = True
        Me.lblIPSvr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPSvr.Location = New System.Drawing.Point(53, 73)
        Me.lblIPSvr.Name = "lblIPSvr"
        Me.lblIPSvr.Size = New System.Drawing.Size(52, 15)
        Me.lblIPSvr.TabIndex = 0
        Me.lblIPSvr.Text = "IP Server"
        '
        'lblDBname
        '
        Me.lblDBname.AutoSize = True
        Me.lblDBname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBname.Location = New System.Drawing.Point(53, 102)
        Me.lblDBname.Name = "lblDBname"
        Me.lblDBname.Size = New System.Drawing.Size(57, 15)
        Me.lblDBname.TabIndex = 1
        Me.lblDBname.Text = "DB Name"
        '
        'tboIPsvr
        '
        Me.tboIPsvr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboIPsvr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboIPsvr.Location = New System.Drawing.Point(131, 71)
        Me.tboIPsvr.Name = "tboIPsvr"
        Me.tboIPsvr.Size = New System.Drawing.Size(196, 23)
        Me.tboIPsvr.TabIndex = 2
        '
        'tboDBname
        '
        Me.tboDBname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboDBname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboDBname.Location = New System.Drawing.Point(131, 100)
        Me.tboDBname.Name = "tboDBname"
        Me.tboDBname.Size = New System.Drawing.Size(196, 23)
        Me.tboDBname.TabIndex = 3
        '
        'tboUsr
        '
        Me.tboUsr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboUsr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboUsr.Location = New System.Drawing.Point(131, 216)
        Me.tboUsr.Name = "tboUsr"
        Me.tboUsr.Size = New System.Drawing.Size(196, 23)
        Me.tboUsr.TabIndex = 4
        '
        'tboPass
        '
        Me.tboPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboPass.Location = New System.Drawing.Point(131, 245)
        Me.tboPass.Name = "tboPass"
        Me.tboPass.Size = New System.Drawing.Size(196, 23)
        Me.tboPass.TabIndex = 5
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(53, 220)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(44, 15)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "User ID"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(53, 249)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(57, 15)
        Me.lblPass.TabIndex = 8
        Me.lblPass.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "DB Port"
        '
        'tboPort
        '
        Me.tboPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboPort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboPort.Location = New System.Drawing.Point(131, 129)
        Me.tboPort.Name = "tboPort"
        Me.tboPort.Size = New System.Drawing.Size(196, 23)
        Me.tboPort.TabIndex = 19
        '
        'tboSkema
        '
        Me.tboSkema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboSkema.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboSkema.Location = New System.Drawing.Point(131, 158)
        Me.tboSkema.Name = "tboSkema"
        Me.tboSkema.Size = New System.Drawing.Size(196, 23)
        Me.tboSkema.TabIndex = 20
        '
        'tboInstance
        '
        Me.tboInstance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboInstance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboInstance.Location = New System.Drawing.Point(131, 187)
        Me.tboInstance.Name = "tboInstance"
        Me.tboInstance.Size = New System.Drawing.Size(196, 23)
        Me.tboInstance.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Skema"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Instance"
        '
        'pbAppIcon
        '
        Me.pbAppIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbAppIcon.Image = Global.dizSetting.My.Resources.Resources.dizSvc1
        Me.pbAppIcon.Location = New System.Drawing.Point(0, 0)
        Me.pbAppIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.pbAppIcon.Name = "pbAppIcon"
        Me.pbAppIcon.Size = New System.Drawing.Size(29, 29)
        Me.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAppIcon.TabIndex = 9
        Me.pbAppIcon.TabStop = False
        '
        'frmSetting
        '
        Me.AcceptButton = Me.btnRun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnKeluar
        Me.ClientSize = New System.Drawing.Size(382, 344)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tboInstance)
        Me.Controls.Add(Me.tboSkema)
        Me.Controls.Add(Me.tboPort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboAutoRun)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.UpdSave)
        Me.Controls.Add(Me.pbAppIcon)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tboPass)
        Me.Controls.Add(Me.tboUsr)
        Me.Controls.Add(Me.tboDBname)
        Me.Controls.Add(Me.tboIPsvr)
        Me.Controls.Add(Me.lblDBname)
        Me.Controls.Add(Me.lblIPSvr)
        Me.Controls.Add(Me.pCounter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Setting"
        Me.pCounter.ResumeLayout(False)
        CType(Me.pbAppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbAppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents UpdSave As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents tmrAuto As System.Windows.Forms.Timer
    Friend WithEvents cboAutoRun As System.Windows.Forms.CheckBox
    Friend WithEvents pCounter As System.Windows.Forms.Panel
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblIPSvr As Label
    Friend WithEvents lblDBname As Label
    Friend WithEvents tboIPsvr As TextBox
    Friend WithEvents tboDBname As TextBox
    Friend WithEvents tboUsr As TextBox
    Friend WithEvents tboPass As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tboPort As TextBox
    Friend WithEvents tboSkema As TextBox
    Friend WithEvents tboInstance As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
