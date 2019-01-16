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
        Me.tmrAuto = New System.Windows.Forms.Timer()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.btnDBSetting = New System.Windows.Forms.Button()
        Me.pLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.xtcGrup = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpUpload = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbcFilesUpload = New DevExpress.XtraEditors.ListBoxControl()
        Me.pFilename = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.xtpFiles = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbcFilesFTP = New DevExpress.XtraEditors.ListBoxControl()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lueJenis = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblJabatan = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnAppMin = New System.Windows.Forms.Button()
        Me.btnAppMax = New System.Windows.Forms.Button()
        Me.btnAppExit = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.xtcGrup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcGrup.SuspendLayout()
        Me.xtpUpload.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.lbcFilesUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pFilename.SuspendLayout()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpFiles.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.lbcFilesFTP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrAuto
        '
        Me.tmrAuto.Interval = 1000
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
        Me.tlpForm.RowCount = 2
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.Size = New System.Drawing.Size(734, 312)
        Me.tlpForm.TabIndex = 1
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.btnAppMin)
        Me.pTitle.Controls.Add(Me.btnAppMax)
        Me.pTitle.Controls.Add(Me.btnAppExit)
        Me.pTitle.Controls.Add(Me.btnDBSetting)
        Me.pTitle.Controls.Add(Me.pLogo)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(730, 30)
        Me.pTitle.TabIndex = 10
        '
        'btnDBSetting
        '
        Me.btnDBSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnDBSetting.BackgroundImage = Global.dizMonitorAntrianManagement.My.Resources.Resources.connection
        Me.btnDBSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDBSetting.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDBSetting.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDBSetting.FlatAppearance.BorderSize = 0
        Me.btnDBSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDBSetting.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBSetting.Location = New System.Drawing.Point(30, 0)
        Me.btnDBSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDBSetting.Name = "btnDBSetting"
        Me.btnDBSetting.Size = New System.Drawing.Size(30, 30)
        Me.btnDBSetting.TabIndex = 31
        Me.btnDBSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDBSetting.UseVisualStyleBackColor = False
        '
        'pLogo
        '
        Me.pLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pLogo.Image = Global.dizMonitorAntrianManagement.My.Resources.Resources.dizUploader
        Me.pLogo.Location = New System.Drawing.Point(0, 0)
        Me.pLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.Size = New System.Drawing.Size(30, 30)
        Me.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pLogo.TabIndex = 10
        Me.pLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(60, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(580, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Monitor Antrian Management"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.xtcGrup)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(730, 282)
        Me.pBody.TabIndex = 7
        '
        'xtcGrup
        '
        Me.xtcGrup.Appearance.BackColor = System.Drawing.Color.DarkKhaki
        Me.xtcGrup.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcGrup.Appearance.Options.UseBackColor = True
        Me.xtcGrup.Appearance.Options.UseFont = True
        Me.xtcGrup.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcGrup.AppearancePage.Header.Options.UseFont = True
        Me.xtcGrup.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcGrup.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcGrup.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcGrup.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcGrup.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcGrup.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcGrup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.xtcGrup.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.xtcGrup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcGrup.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcGrup.Location = New System.Drawing.Point(0, 66)
        Me.xtcGrup.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcGrup.Name = "xtcGrup"
        Me.xtcGrup.SelectedTabPage = Me.xtpUpload
        Me.xtcGrup.Size = New System.Drawing.Size(730, 216)
        Me.xtcGrup.TabIndex = 17
        Me.xtcGrup.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpUpload, Me.xtpFiles})
        '
        'xtpUpload
        '
        Me.xtpUpload.Controls.Add(Me.TableLayoutPanel1)
        Me.xtpUpload.Name = "xtpUpload"
        Me.xtpUpload.Size = New System.Drawing.Size(722, 185)
        Me.xtpUpload.Text = "UPLOAD"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.DarkKhaki
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbcFilesUpload, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.pFilename, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.teRemarks, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(722, 185)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(206, 154)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "UPLOAD"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Filename"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbcFilesUpload
        '
        Me.lbcFilesUpload.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbcFilesUpload.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbcFilesUpload.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbcFilesUpload.Appearance.Options.UseBackColor = True
        Me.lbcFilesUpload.Appearance.Options.UseFont = True
        Me.lbcFilesUpload.Appearance.Options.UseForeColor = True
        Me.lbcFilesUpload.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbcFilesUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbcFilesUpload.Location = New System.Drawing.Point(206, 54)
        Me.lbcFilesUpload.Margin = New System.Windows.Forms.Padding(0)
        Me.lbcFilesUpload.Name = "lbcFilesUpload"
        Me.lbcFilesUpload.Size = New System.Drawing.Size(450, 100)
        Me.lbcFilesUpload.TabIndex = 0
        '
        'pFilename
        '
        Me.pFilename.Controls.Add(Me.btnAdd)
        Me.pFilename.Controls.Add(Me.btnBrowse)
        Me.pFilename.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pFilename.Location = New System.Drawing.Point(206, 30)
        Me.pFilename.Margin = New System.Windows.Forms.Padding(0)
        Me.pFilename.Name = "pFilename"
        Me.pFilename.Size = New System.Drawing.Size(450, 24)
        Me.pFilename.TabIndex = 31
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(80, 0)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 24)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "TAMBAH KE LIST"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnBrowse.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(0, 0)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(80, 24)
        Me.btnBrowse.TabIndex = 17
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Daftar File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "untuk Upload"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teRemarks
        '
        Me.teRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRemarks.Location = New System.Drawing.Point(206, 8)
        Me.teRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teRemarks.Name = "teRemarks"
        Me.teRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teRemarks.Properties.Appearance.Options.UseFont = True
        Me.teRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRemarks.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teRemarks.Properties.MaxLength = 10
        Me.teRemarks.Properties.NullText = "[Belum Diisi]"
        Me.teRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRemarks.Size = New System.Drawing.Size(448, 20)
        Me.teRemarks.TabIndex = 29
        Me.teRemarks.Tag = "remarks"
        '
        'xtpFiles
        '
        Me.xtpFiles.Controls.Add(Me.TableLayoutPanel2)
        Me.xtpFiles.Name = "xtpFiles"
        Me.xtpFiles.Size = New System.Drawing.Size(722, 183)
        Me.xtpFiles.Text = "DAFTAR FILE"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.DarkKhaki
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnDelete, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbcFilesFTP, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(722, 183)
        Me.TableLayoutPanel2.TabIndex = 33
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Maroon
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(206, 154)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 28)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Daftar File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pada Monitor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbcFilesFTP
        '
        Me.lbcFilesFTP.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbcFilesFTP.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbcFilesFTP.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbcFilesFTP.Appearance.Options.UseBackColor = True
        Me.lbcFilesFTP.Appearance.Options.UseFont = True
        Me.lbcFilesFTP.Appearance.Options.UseForeColor = True
        Me.lbcFilesFTP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbcFilesFTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbcFilesFTP.Location = New System.Drawing.Point(206, 6)
        Me.lbcFilesFTP.Margin = New System.Windows.Forms.Padding(0)
        Me.lbcFilesFTP.Name = "lbcFilesFTP"
        Me.lbcFilesFTP.Size = New System.Drawing.Size(450, 148)
        Me.lbcFilesFTP.TabIndex = 1
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.BackColor = System.Drawing.Color.DarkKhaki
        Me.tlpField.ColumnCount = 5
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.lueJenis, 2, 1)
        Me.tlpField.Controls.Add(Me.lblJabatan, 1, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 3
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(730, 36)
        Me.tlpField.TabIndex = 16
        '
        'lueJenis
        '
        Me.lueJenis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenis.Location = New System.Drawing.Point(210, 8)
        Me.lueJenis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenis.Name = "lueJenis"
        Me.lueJenis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenis.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenis.Properties.Appearance.Options.UseFont = True
        Me.lueJenis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJenis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJenis.Size = New System.Drawing.Size(150, 20)
        Me.lueJenis.TabIndex = 29
        Me.lueJenis.Tag = ""
        '
        'lblJabatan
        '
        Me.lblJabatan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblJabatan.AutoSize = True
        Me.lblJabatan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJabatan.Location = New System.Drawing.Point(135, 11)
        Me.lblJabatan.Name = "lblJabatan"
        Me.lblJabatan.Size = New System.Drawing.Size(72, 14)
        Me.lblJabatan.TabIndex = 9
        Me.lblJabatan.Text = "Jenis Berkas"
        Me.lblJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(730, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnAppMin
        '
        Me.btnAppMin.BackColor = System.Drawing.Color.Transparent
        Me.btnAppMin.BackgroundImage = Global.dizMonitorAntrianManagement.My.Resources.Resources.min_n
        Me.btnAppMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppMin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAppMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppMin.FlatAppearance.BorderSize = 0
        Me.btnAppMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppMin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppMin.Location = New System.Drawing.Point(640, 0)
        Me.btnAppMin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppMin.Name = "btnAppMin"
        Me.btnAppMin.Size = New System.Drawing.Size(30, 30)
        Me.btnAppMin.TabIndex = 33
        Me.btnAppMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppMin.UseVisualStyleBackColor = False
        '
        'btnAppMax
        '
        Me.btnAppMax.BackColor = System.Drawing.Color.Transparent
        Me.btnAppMax.BackgroundImage = Global.dizMonitorAntrianManagement.My.Resources.Resources.max_n
        Me.btnAppMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppMax.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAppMax.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppMax.Enabled = False
        Me.btnAppMax.FlatAppearance.BorderSize = 0
        Me.btnAppMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppMax.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppMax.Location = New System.Drawing.Point(670, 0)
        Me.btnAppMax.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppMax.Name = "btnAppMax"
        Me.btnAppMax.Size = New System.Drawing.Size(30, 30)
        Me.btnAppMax.TabIndex = 34
        Me.btnAppMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppMax.UseVisualStyleBackColor = False
        '
        'btnAppExit
        '
        Me.btnAppExit.BackColor = System.Drawing.Color.Transparent
        Me.btnAppExit.BackgroundImage = Global.dizMonitorAntrianManagement.My.Resources.Resources.exit_n
        Me.btnAppExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAppExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppExit.FlatAppearance.BorderSize = 0
        Me.btnAppExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppExit.Location = New System.Drawing.Point(700, 0)
        Me.btnAppExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppExit.Name = "btnAppExit"
        Me.btnAppExit.Size = New System.Drawing.Size(30, 30)
        Me.btnAppExit.TabIndex = 32
        Me.btnAppExit.Tag = "exit"
        Me.btnAppExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(734, 312)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitor Antrian Management"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.xtcGrup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcGrup.ResumeLayout(False)
        Me.xtpUpload.ResumeLayout(False)
        Me.xtpUpload.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.lbcFilesUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pFilename.ResumeLayout(False)
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpFiles.ResumeLayout(False)
        Me.xtpFiles.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.lbcFilesFTP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrAuto As System.Windows.Forms.Timer
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblJabatan As System.Windows.Forms.Label
    Friend WithEvents teRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtcGrup As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpUpload As DevExpress.XtraTab.XtraTabPage
    Public WithEvents btnAdd As System.Windows.Forms.Button
    Public WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lbcFilesUpload As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xtpFiles As DevExpress.XtraTab.XtraTabPage
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lbcFilesFTP As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lueJenis As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pFilename As System.Windows.Forms.Panel
    Public WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pLogo As System.Windows.Forms.PictureBox
    Public WithEvents btnDBSetting As System.Windows.Forms.Button
    Public WithEvents btnAppMin As System.Windows.Forms.Button
    Public WithEvents btnAppMax As System.Windows.Forms.Button
    Public WithEvents btnAppExit As System.Windows.Forms.Button

End Class
