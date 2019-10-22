<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAlihDPJP
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
        Me.pBody = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.teCaseManager = New DevExpress.XtraEditors.TextEdit()
        Me.lueCaseManager = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSaveCase = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.teDPJP = New DevExpress.XtraEditors.TextEdit()
        Me.lueDPJP = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSaveDPJP = New System.Windows.Forms.Button()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teNama = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.teNoRM = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teNoRegistrasi = New DevExpress.XtraEditors.TextEdit()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.teCaseManager.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCaseManager.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.teDPJP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDPJP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoRegistrasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkGreen
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
        Me.tlpForm.Size = New System.Drawing.Size(690, 254)
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
        Me.pTitle.Size = New System.Drawing.Size(686, 30)
        Me.pTitle.TabIndex = 36
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(596, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Alih DPJP"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(596, 0)
        Me.pMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMinimize.Name = "pMinimize"
        Me.pMinimize.Size = New System.Drawing.Size(30, 30)
        Me.pMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMinimize.TabIndex = 12
        Me.pMinimize.TabStop = False
        '
        'pMaximize
        '
        Me.pMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMaximize.Image = Global.dizUI.My.Resources.Resources.max_w
        Me.pMaximize.Location = New System.Drawing.Point(626, 0)
        Me.pMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMaximize.Name = "pMaximize"
        Me.pMaximize.Size = New System.Drawing.Size(30, 30)
        Me.pMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMaximize.TabIndex = 11
        Me.pMaximize.TabStop = False
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(656, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.TableLayoutPanel4)
        Me.pBody.Controls.Add(Me.Panel2)
        Me.pBody.Controls.Add(Me.TableLayoutPanel2)
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(686, 222)
        Me.pBody.TabIndex = 7
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.teCaseManager, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lueCaseManager, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 186)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(686, 36)
        Me.TableLayoutPanel4.TabIndex = 11
        '
        'teCaseManager
        '
        Me.teCaseManager.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teCaseManager.Location = New System.Drawing.Point(163, 8)
        Me.teCaseManager.Margin = New System.Windows.Forms.Padding(0)
        Me.teCaseManager.Name = "teCaseManager"
        Me.teCaseManager.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teCaseManager.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teCaseManager.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teCaseManager.Properties.Appearance.Options.UseBackColor = True
        Me.teCaseManager.Properties.Appearance.Options.UseFont = True
        Me.teCaseManager.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teCaseManager.Properties.MaxLength = 300
        Me.teCaseManager.Properties.NullText = "[Belum Diisi]"
        Me.teCaseManager.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teCaseManager.Properties.ReadOnly = True
        Me.teCaseManager.Size = New System.Drawing.Size(180, 20)
        Me.teCaseManager.TabIndex = 19
        Me.teCaseManager.Tag = "jeniskartu"
        '
        'lueCaseManager
        '
        Me.lueCaseManager.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueCaseManager.Location = New System.Drawing.Point(463, 8)
        Me.lueCaseManager.Margin = New System.Windows.Forms.Padding(0)
        Me.lueCaseManager.Name = "lueCaseManager"
        Me.lueCaseManager.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueCaseManager.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueCaseManager.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueCaseManager.Properties.Appearance.Options.UseBackColor = True
        Me.lueCaseManager.Properties.Appearance.Options.UseFont = True
        Me.lueCaseManager.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueCaseManager.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueCaseManager.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCaseManager.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueCaseManager.Properties.NullText = "[Isian belum dipilih]"
        Me.lueCaseManager.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueCaseManager.Size = New System.Drawing.Size(180, 20)
        Me.lueCaseManager.TabIndex = 20
        Me.lueCaseManager.Tag = "idkelas"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 14)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Case Manager"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Case Manager Asal"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(110, 30)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CASE MANAGER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnSaveCase)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 156)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 30)
        Me.Panel2.TabIndex = 13
        '
        'btnSaveCase
        '
        Me.btnSaveCase.BackColor = System.Drawing.Color.Green
        Me.btnSaveCase.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveCase.FlatAppearance.BorderSize = 0
        Me.btnSaveCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSaveCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSaveCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCase.Location = New System.Drawing.Point(606, 0)
        Me.btnSaveCase.Name = "btnSaveCase"
        Me.btnSaveCase.Size = New System.Drawing.Size(80, 30)
        Me.btnSaveCase.TabIndex = 4
        Me.btnSaveCase.Text = "SIMPAN"
        Me.btnSaveCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveCase.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.teDPJP, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lueDPJP, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(686, 36)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'teDPJP
        '
        Me.teDPJP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teDPJP.Location = New System.Drawing.Point(163, 8)
        Me.teDPJP.Margin = New System.Windows.Forms.Padding(0)
        Me.teDPJP.Name = "teDPJP"
        Me.teDPJP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teDPJP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDPJP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDPJP.Properties.Appearance.Options.UseBackColor = True
        Me.teDPJP.Properties.Appearance.Options.UseFont = True
        Me.teDPJP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teDPJP.Properties.MaxLength = 300
        Me.teDPJP.Properties.NullText = "[Belum Diisi]"
        Me.teDPJP.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teDPJP.Properties.ReadOnly = True
        Me.teDPJP.Size = New System.Drawing.Size(180, 20)
        Me.teDPJP.TabIndex = 20
        Me.teDPJP.Tag = "jeniskartu"
        '
        'lueDPJP
        '
        Me.lueDPJP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueDPJP.Location = New System.Drawing.Point(463, 8)
        Me.lueDPJP.Margin = New System.Windows.Forms.Padding(0)
        Me.lueDPJP.Name = "lueDPJP"
        Me.lueDPJP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueDPJP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDPJP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueDPJP.Properties.Appearance.Options.UseBackColor = True
        Me.lueDPJP.Properties.Appearance.Options.UseFont = True
        Me.lueDPJP.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDPJP.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueDPJP.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueDPJP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueDPJP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDPJP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueDPJP.Properties.NullText = "[Isian belum dipilih]"
        Me.lueDPJP.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueDPJP.Size = New System.Drawing.Size(180, 20)
        Me.lueDPJP.TabIndex = 15
        Me.lueDPJP.Tag = "idlokasi"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(426, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "DPJP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DPJP Asal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(110, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DPJP"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnSaveDPJP)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 30)
        Me.Panel1.TabIndex = 12
        '
        'btnSaveDPJP
        '
        Me.btnSaveDPJP.BackColor = System.Drawing.Color.Green
        Me.btnSaveDPJP.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveDPJP.FlatAppearance.BorderSize = 0
        Me.btnSaveDPJP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSaveDPJP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSaveDPJP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveDPJP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDPJP.Location = New System.Drawing.Point(606, 0)
        Me.btnSaveDPJP.Name = "btnSaveDPJP"
        Me.btnSaveDPJP.Size = New System.Drawing.Size(80, 30)
        Me.btnSaveDPJP.TabIndex = 4
        Me.btnSaveDPJP.Text = "SIMPAN"
        Me.btnSaveDPJP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveDPJP.UseVisualStyleBackColor = False
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.teNama, 4, 2)
        Me.tlpField.Controls.Add(Me.Label7, 3, 2)
        Me.tlpField.Controls.Add(Me.teNoRM, 2, 2)
        Me.tlpField.Controls.Add(Me.Label1, 1, 2)
        Me.tlpField.Controls.Add(Me.teNoRegistrasi, 2, 1)
        Me.tlpField.Controls.Add(Me.lblKaryawan, 1, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(686, 60)
        Me.tlpField.TabIndex = 7
        '
        'teNama
        '
        Me.teNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNama.Location = New System.Drawing.Point(463, 32)
        Me.teNama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNama.Name = "teNama"
        Me.teNama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.Appearance.Options.UseBackColor = True
        Me.teNama.Properties.Appearance.Options.UseFont = True
        Me.teNama.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNama.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNama.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNama.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNama.Properties.MaxLength = 300
        Me.teNama.Properties.NullText = "[Belum Diisi]"
        Me.teNama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNama.Properties.ReadOnly = True
        Me.teNama.Size = New System.Drawing.Size(193, 20)
        Me.teNama.TabIndex = 19
        Me.teNama.Tag = "namapasien"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nama Pasien"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNoRM
        '
        Me.teNoRM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRM.EditValue = "00-00-00-00"
        Me.teNoRM.Location = New System.Drawing.Point(143, 32)
        Me.teNoRM.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRM.Name = "teNoRM"
        Me.teNoRM.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRM.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRM.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRM.Properties.Appearance.Options.UseFont = True
        Me.teNoRM.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRM.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNoRM.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNoRM.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRM.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNoRM.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNoRM.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teNoRM.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teNoRM.Properties.Mask.EditMask = "##-##-##-#0"
        Me.teNoRM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.teNoRM.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(48)
        Me.teNoRM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teNoRM.Properties.MaxLength = 300
        Me.teNoRM.Properties.NullText = "[Belum Diisi]"
        Me.teNoRM.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRM.Properties.ReadOnly = True
        Me.teNoRM.Size = New System.Drawing.Size(99, 20)
        Me.teNoRM.TabIndex = 15
        Me.teNoRM.Tag = "norm"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "No. Rekam Medis"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNoRegistrasi
        '
        Me.teNoRegistrasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRegistrasi.Location = New System.Drawing.Point(143, 8)
        Me.teNoRegistrasi.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRegistrasi.Name = "teNoRegistrasi"
        Me.teNoRegistrasi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRegistrasi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRegistrasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRegistrasi.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRegistrasi.Properties.Appearance.Options.UseFont = True
        Me.teNoRegistrasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRegistrasi.Properties.MaxLength = 300
        Me.teNoRegistrasi.Properties.NullText = "[Belum Diisi]"
        Me.teNoRegistrasi.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRegistrasi.Size = New System.Drawing.Size(200, 20)
        Me.teNoRegistrasi.TabIndex = 21
        Me.teNoRegistrasi.Tag = "namapanggilan"
        '
        'lblKaryawan
        '
        Me.lblKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKaryawan.AutoSize = True
        Me.lblKaryawan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaryawan.Location = New System.Drawing.Point(60, 11)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(80, 14)
        Me.lblKaryawan.TabIndex = 9
        Me.lblKaryawan.Text = "No. Registrasi"
        Me.lblKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(686, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(626, 0)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "CARI"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmAlihDPJP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAlihDPJP"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alih DPJP"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.teCaseManager.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCaseManager.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.teDPJP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDPJP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoRegistrasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblKaryawan As System.Windows.Forms.Label
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents teNoRegistrasi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNoRM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Public WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents teNama As DevExpress.XtraEditors.TextEdit
    Public WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lueDPJP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents teCaseManager As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pExit As PictureBox
    Public WithEvents btnNew As Button
    Friend WithEvents pMinimize As PictureBox
    Friend WithEvents pMaximize As PictureBox
    Friend WithEvents lueCaseManager As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents Panel2 As Panel
    Public WithEvents btnSaveCase As Button
    Friend WithEvents teDPJP As DevExpress.XtraEditors.TextEdit
    Public WithEvents Panel1 As Panel
    Public WithEvents btnSaveDPJP As Button
End Class
