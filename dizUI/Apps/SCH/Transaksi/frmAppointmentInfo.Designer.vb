<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointmentInfo
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
        Me.pMain = New System.Windows.Forms.Panel()
        Me.lblNoUrut = New System.Windows.Forms.Label()
        Me.lblNREG = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblBookTime = New System.Windows.Forms.Label()
        Me.lblBookingStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUpdatedDate = New System.Windows.Forms.Label()
        Me.lblUpdatedUser = New System.Windows.Forms.Label()
        Me.lblCreatedDate = New System.Windows.Forms.Label()
        Me.lblCreatedUser = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAppTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tePhone1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPhone1 = New System.Windows.Forms.Label()
        Me.tePhone2 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPhone2 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.teNote = New DevExpress.XtraEditors.TextEdit()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pMain.SuspendLayout()
        CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePhone1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePhone2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pMain
        '
        Me.pMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pMain.Controls.Add(Me.lblNoUrut)
        Me.pMain.Controls.Add(Me.lblNREG)
        Me.pMain.Controls.Add(Me.Label5)
        Me.pMain.Controls.Add(Me.Label12)
        Me.pMain.Controls.Add(Me.lblBookTime)
        Me.pMain.Controls.Add(Me.lblBookingStatus)
        Me.pMain.Controls.Add(Me.Label3)
        Me.pMain.Controls.Add(Me.lblUpdatedDate)
        Me.pMain.Controls.Add(Me.lblUpdatedUser)
        Me.pMain.Controls.Add(Me.lblCreatedDate)
        Me.pMain.Controls.Add(Me.lblCreatedUser)
        Me.pMain.Controls.Add(Me.Label21)
        Me.pMain.Controls.Add(Me.Label20)
        Me.pMain.Controls.Add(Me.Label19)
        Me.pMain.Controls.Add(Me.Label18)
        Me.pMain.Controls.Add(Me.lblBirthdate)
        Me.pMain.Controls.Add(Me.lblGender)
        Me.pMain.Controls.Add(Me.Label7)
        Me.pMain.Controls.Add(Me.Label6)
        Me.pMain.Controls.Add(Me.lblPatientName)
        Me.pMain.Controls.Add(Me.Label4)
        Me.pMain.Controls.Add(Me.lblAppTime)
        Me.pMain.Controls.Add(Me.Label2)
        Me.pMain.Controls.Add(Me.teAddress)
        Me.pMain.Controls.Add(Me.Label11)
        Me.pMain.Controls.Add(Me.Label10)
        Me.pMain.Controls.Add(Me.Label9)
        Me.pMain.Controls.Add(Me.Label8)
        Me.pMain.Controls.Add(Me.lblPhone1)
        Me.pMain.Controls.Add(Me.tePhone2)
        Me.pMain.Controls.Add(Me.lblPhone2)
        Me.pMain.Controls.Add(Me.lblAddress)
        Me.pMain.Controls.Add(Me.teNote)
        Me.pMain.Controls.Add(Me.lblNote)
        Me.pMain.Controls.Add(Me.tePhone1)
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 30)
        Me.pMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(565, 459)
        Me.pMain.TabIndex = 0
        '
        'lblNoUrut
        '
        Me.lblNoUrut.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblNoUrut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNoUrut.Image = Global.dizUI.My.Resources.Resources.ribbons
        Me.lblNoUrut.Location = New System.Drawing.Point(451, 7)
        Me.lblNoUrut.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNoUrut.Name = "lblNoUrut"
        Me.lblNoUrut.Size = New System.Drawing.Size(65, 65)
        Me.lblNoUrut.TabIndex = 61
        Me.lblNoUrut.Text = "9999 "
        Me.lblNoUrut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNREG
        '
        Me.lblNREG.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblNREG.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblNREG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblNREG.Location = New System.Drawing.Point(156, 85)
        Me.lblNREG.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNREG.Name = "lblNREG"
        Me.lblNREG.Size = New System.Drawing.Size(395, 24)
        Me.lblNREG.TabIndex = 60
        Me.lblNREG.Text = "21-08-2015 02:00:00"
        Me.lblNREG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(150, 24)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "No Registrasi"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 55)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label12.Size = New System.Drawing.Size(150, 24)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Tanggal Booking"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBookTime
        '
        Me.lblBookTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblBookTime.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblBookTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblBookTime.Location = New System.Drawing.Point(156, 55)
        Me.lblBookTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBookTime.Name = "lblBookTime"
        Me.lblBookTime.Size = New System.Drawing.Size(285, 24)
        Me.lblBookTime.TabIndex = 57
        Me.lblBookTime.Text = "21-08-2015 02:00:00"
        Me.lblBookTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBookingStatus
        '
        Me.lblBookingStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblBookingStatus.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblBookingStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblBookingStatus.Location = New System.Drawing.Point(156, 7)
        Me.lblBookingStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBookingStatus.Name = "lblBookingStatus"
        Me.lblBookingStatus.Size = New System.Drawing.Size(285, 24)
        Me.lblBookingStatus.TabIndex = 56
        Me.lblBookingStatus.Text = "21-08-2015 02:00:00"
        Me.lblBookingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(150, 24)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Status Booking"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUpdatedDate
        '
        Me.lblUpdatedDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblUpdatedDate.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblUpdatedDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblUpdatedDate.Location = New System.Drawing.Point(156, 426)
        Me.lblUpdatedDate.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUpdatedDate.Name = "lblUpdatedDate"
        Me.lblUpdatedDate.Size = New System.Drawing.Size(395, 24)
        Me.lblUpdatedDate.TabIndex = 54
        Me.lblUpdatedDate.Text = "21-08-2015 02:00:00"
        Me.lblUpdatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUpdatedUser
        '
        Me.lblUpdatedUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblUpdatedUser.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblUpdatedUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblUpdatedUser.Location = New System.Drawing.Point(156, 402)
        Me.lblUpdatedUser.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUpdatedUser.Name = "lblUpdatedUser"
        Me.lblUpdatedUser.Size = New System.Drawing.Size(395, 24)
        Me.lblUpdatedUser.TabIndex = 53
        Me.lblUpdatedUser.Text = "21-08-2015 02:00:00"
        Me.lblUpdatedUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCreatedDate
        '
        Me.lblCreatedDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblCreatedDate.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblCreatedDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblCreatedDate.Location = New System.Drawing.Point(156, 378)
        Me.lblCreatedDate.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCreatedDate.Name = "lblCreatedDate"
        Me.lblCreatedDate.Size = New System.Drawing.Size(395, 24)
        Me.lblCreatedDate.TabIndex = 52
        Me.lblCreatedDate.Text = "21-08-2015 02:00:00"
        Me.lblCreatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCreatedUser
        '
        Me.lblCreatedUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblCreatedUser.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblCreatedUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblCreatedUser.Location = New System.Drawing.Point(156, 354)
        Me.lblCreatedUser.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCreatedUser.Name = "lblCreatedUser"
        Me.lblCreatedUser.Size = New System.Drawing.Size(395, 24)
        Me.lblCreatedUser.TabIndex = 51
        Me.lblCreatedUser.Text = "21-08-2015 02:00:00"
        Me.lblCreatedUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(6, 426)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.Name = "Label21"
        Me.Label21.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label21.Size = New System.Drawing.Size(150, 24)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Diperbarui pada"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(6, 402)
        Me.Label20.Margin = New System.Windows.Forms.Padding(0)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label20.Size = New System.Drawing.Size(150, 24)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Diperbarui oleh"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(6, 378)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label19.Size = New System.Drawing.Size(150, 24)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Dibuat pada"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(6, 354)
        Me.Label18.Margin = New System.Windows.Forms.Padding(0)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label18.Size = New System.Drawing.Size(150, 24)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Dibuat oleh"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBirthdate
        '
        Me.lblBirthdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblBirthdate.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblBirthdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblBirthdate.Location = New System.Drawing.Point(156, 180)
        Me.lblBirthdate.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(395, 24)
        Me.lblBirthdate.TabIndex = 42
        Me.lblBirthdate.Text = "21-08-2015 02:00:00"
        Me.lblBirthdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblGender.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(156, 156)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(395, 24)
        Me.lblGender.TabIndex = 41
        Me.lblGender.Text = "21-08-2015 02:00:00"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 180)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(150, 24)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Tanggal Lahir"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 156)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(150, 24)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Jenis Kelamin"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPatientName
        '
        Me.lblPatientName.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblPatientName.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblPatientName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblPatientName.Location = New System.Drawing.Point(156, 109)
        Me.lblPatientName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(395, 47)
        Me.lblPatientName.TabIndex = 34
        Me.lblPatientName.Text = "21-08-2015 02:00:00"
        Me.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(150, 47)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "(No RM)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nama Pasien"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAppTime
        '
        Me.lblAppTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblAppTime.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblAppTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblAppTime.Location = New System.Drawing.Point(156, 31)
        Me.lblAppTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAppTime.Name = "lblAppTime"
        Me.lblAppTime.Size = New System.Drawing.Size(285, 24)
        Me.lblAppTime.TabIndex = 32
        Me.lblAppTime.Text = "21-08-2015 02:00:00"
        Me.lblAppTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Waktu Appointment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teAddress
        '
        Me.teAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.teAddress.Location = New System.Drawing.Point(155, 258)
        Me.teAddress.Name = "teAddress"
        Me.teAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.teAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teAddress.Properties.Appearance.Options.UseBackColor = True
        Me.teAddress.Properties.Appearance.Options.UseFont = True
        Me.teAddress.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teAddress.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teAddress.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teAddress.Properties.AppearanceFocused.Options.UseFont = True
        Me.teAddress.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teAddress.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teAddress.Properties.MaxLength = 5000
        Me.teAddress.Size = New System.Drawing.Size(395, 0)
        Me.teAddress.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 321)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label11.Size = New System.Drawing.Size(150, 30)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Catatan"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 258)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label10.Size = New System.Drawing.Size(150, 61)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Alamat"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(6, 234)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(150, 24)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Telepon 2"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 210)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(150, 24)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Telepon 1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePhone1
        '
        Me.tePhone1.Location = New System.Drawing.Point(155, 210)
        Me.tePhone1.Margin = New System.Windows.Forms.Padding(0)
        Me.tePhone1.Name = "tePhone1"
        Me.tePhone1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tePhone1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tePhone1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tePhone1.Properties.Appearance.Options.UseBackColor = True
        Me.tePhone1.Properties.Appearance.Options.UseFont = True
        Me.tePhone1.Properties.Appearance.Options.UseForeColor = True
        Me.tePhone1.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tePhone1.Properties.AppearanceDisabled.Options.UseFont = True
        Me.tePhone1.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tePhone1.Properties.AppearanceFocused.Options.UseFont = True
        Me.tePhone1.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tePhone1.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.tePhone1.Properties.AutoHeight = False
        Me.tePhone1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tePhone1.Properties.MaxLength = 20
        Me.tePhone1.Properties.NullText = "0"
        Me.tePhone1.Size = New System.Drawing.Size(395, 24)
        Me.tePhone1.TabIndex = 66
        Me.tePhone1.Tag = ""
        Me.tePhone1.Visible = False
        '
        'lblPhone1
        '
        Me.lblPhone1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblPhone1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblPhone1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblPhone1.Location = New System.Drawing.Point(155, 210)
        Me.lblPhone1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPhone1.Name = "lblPhone1"
        Me.lblPhone1.Size = New System.Drawing.Size(395, 24)
        Me.lblPhone1.TabIndex = 43
        Me.lblPhone1.Text = "21-08-2015 02:00:00"
        Me.lblPhone1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePhone2
        '
        Me.tePhone2.Location = New System.Drawing.Point(155, 234)
        Me.tePhone2.Margin = New System.Windows.Forms.Padding(0)
        Me.tePhone2.Name = "tePhone2"
        Me.tePhone2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tePhone2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tePhone2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tePhone2.Properties.Appearance.Options.UseBackColor = True
        Me.tePhone2.Properties.Appearance.Options.UseFont = True
        Me.tePhone2.Properties.Appearance.Options.UseForeColor = True
        Me.tePhone2.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tePhone2.Properties.AppearanceDisabled.Options.UseFont = True
        Me.tePhone2.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tePhone2.Properties.AppearanceFocused.Options.UseFont = True
        Me.tePhone2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tePhone2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.tePhone2.Properties.AutoHeight = False
        Me.tePhone2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tePhone2.Properties.MaxLength = 20
        Me.tePhone2.Properties.NullText = "0"
        Me.tePhone2.Size = New System.Drawing.Size(395, 24)
        Me.tePhone2.TabIndex = 65
        Me.tePhone2.Tag = ""
        Me.tePhone2.Visible = False
        '
        'lblPhone2
        '
        Me.lblPhone2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblPhone2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblPhone2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblPhone2.Location = New System.Drawing.Point(155, 234)
        Me.lblPhone2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPhone2.Name = "lblPhone2"
        Me.lblPhone2.Size = New System.Drawing.Size(395, 24)
        Me.lblPhone2.TabIndex = 44
        Me.lblPhone2.Text = "21-08-2015 02:00:00"
        Me.lblPhone2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(155, 258)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(395, 61)
        Me.lblAddress.TabIndex = 45
        Me.lblAddress.Text = "21-08-2015 02:00:00"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNote
        '
        Me.teNote.Location = New System.Drawing.Point(155, 321)
        Me.teNote.Margin = New System.Windows.Forms.Padding(0)
        Me.teNote.Name = "teNote"
        Me.teNote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.teNote.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teNote.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.teNote.Properties.Appearance.Options.UseBackColor = True
        Me.teNote.Properties.Appearance.Options.UseFont = True
        Me.teNote.Properties.Appearance.Options.UseForeColor = True
        Me.teNote.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teNote.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNote.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teNote.Properties.AppearanceFocused.Options.UseFont = True
        Me.teNote.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teNote.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNote.Properties.AutoHeight = False
        Me.teNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teNote.Properties.MaxLength = 100
        Me.teNote.Properties.NullText = "0"
        Me.teNote.Size = New System.Drawing.Size(395, 30)
        Me.teNote.TabIndex = 70
        Me.teNote.Tag = ""
        Me.teNote.Visible = False
        '
        'lblNote
        '
        Me.lblNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblNote.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblNote.Location = New System.Drawing.Point(155, 321)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(395, 30)
        Me.lblNote.TabIndex = 46
        Me.lblNote.Text = "21-08-2015 02:00:00"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpForm.Size = New System.Drawing.Size(569, 521)
        Me.tlpForm.TabIndex = 1
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
        Me.pTitle.Size = New System.Drawing.Size(565, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(475, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Appointment Info"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(475, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(505, 0)
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
        Me.pExit.Location = New System.Drawing.Point(535, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.pMain)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(565, 489)
        Me.pBody.TabIndex = 7
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnEdit)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(565, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(425, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(60, 30)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(485, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmAppointmentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 521)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAppointmentInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment Info"
        Me.pMain.ResumeLayout(False)
        CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePhone1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePhone2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pMain As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUpdatedDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdatedUser As System.Windows.Forms.Label
    Friend WithEvents lblCreatedDate As System.Windows.Forms.Label
    Friend WithEvents lblCreatedUser As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblPhone2 As System.Windows.Forms.Label
    Friend WithEvents lblPhone1 As System.Windows.Forms.Label
    Friend WithEvents lblBirthdate As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAppTime As System.Windows.Forms.Label
    Friend WithEvents lblBookingStatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblBookTime As System.Windows.Forms.Label
    Friend WithEvents lblNREG As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNoUrut As System.Windows.Forms.Label
    Friend WithEvents tePhone1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePhone2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teAddress As DevExpress.XtraEditors.MemoEdit
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnEdit As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents teNote As DevExpress.XtraEditors.TextEdit
End Class
