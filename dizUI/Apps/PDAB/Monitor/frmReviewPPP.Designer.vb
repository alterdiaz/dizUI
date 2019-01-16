<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReviewPPP
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.xtcPenerimaanPengeluaran = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpPenerimaan = New DevExpress.XtraTab.XtraTabPage()
        Me.gcPenerimaanData = New DevExpress.XtraGrid.GridControl()
        Me.gvPenerimaanData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gctID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctIDParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctIDPengajuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctIDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctIDUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctNomorUrut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctUntuk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeNote1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gctNoDokumen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctJumlahUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctDebetKredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rceStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gctReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rteReason = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gctKDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpPengeluaran = New DevExpress.XtraTab.XtraTabPage()
        Me.gcPengeluaranData = New DevExpress.XtraGrid.GridControl()
        Me.gvPengeluaranData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gckID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckIDParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckIDPengajuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckIDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckIDUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckNomorUrut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckUntuk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeNote2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gckNoDokumen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckJumlahUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckDebetKredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rce2Status = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gckReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rte2Reason = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gckKDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tabPenerimaan = New System.Windows.Forms.Button()
        Me.tabPengeluaran = New System.Windows.Forms.Button()
        Me.tlpUntuk = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ceReject = New DevExpress.XtraEditors.CheckEdit()
        Me.ceCheck = New DevExpress.XtraEditors.CheckEdit()
        Me.teAlasan = New DevExpress.XtraEditors.TextEdit()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teTanggal = New DevExpress.XtraEditors.TextEdit()
        Me.teBank = New DevExpress.XtraEditors.TextEdit()
        Me.lblJumlahUang = New System.Windows.Forms.Label()
        Me.lblPengajuanNo = New System.Windows.Forms.Label()
        Me.tearuspengajuanNo = New DevExpress.XtraEditors.TextEdit()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.seTotalPenerimaan = New DevExpress.XtraEditors.SpinEdit()
        Me.seTotalPengeluaran = New DevExpress.XtraEditors.SpinEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.xtcPenerimaanPengeluaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcPenerimaanPengeluaran.SuspendLayout()
        Me.xtpPenerimaan.SuspendLayout()
        CType(Me.gcPenerimaanData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPenerimaanData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeNote1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rceStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rteReason, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPengeluaran.SuspendLayout()
        CType(Me.gcPengeluaranData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPengeluaranData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeNote2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rce2Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rte2Reason, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tlpUntuk.SuspendLayout()
        CType(Me.ceReject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAlasan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.teTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tearuspengajuanNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTotalPenerimaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTotalPengeluaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpForm.Size = New System.Drawing.Size(790, 499)
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
        Me.pTitle.Size = New System.Drawing.Size(786, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(696, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Review Pengajuan Penerimaan dan Pengeluaran Uang Bank"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(696, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(726, 0)
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
        Me.pExit.Location = New System.Drawing.Point(756, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.xtcPenerimaanPengeluaran)
        Me.pBody.Controls.Add(Me.TableLayoutPanel5)
        Me.pBody.Controls.Add(Me.tlpUntuk)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 469)
        Me.pBody.TabIndex = 7
        '
        'xtcPenerimaanPengeluaran
        '
        Me.xtcPenerimaanPengeluaran.Appearance.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.xtcPenerimaanPengeluaran.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcPenerimaanPengeluaran.Appearance.Options.UseBackColor = True
        Me.xtcPenerimaanPengeluaran.Appearance.Options.UseFont = True
        Me.xtcPenerimaanPengeluaran.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcPenerimaanPengeluaran.AppearancePage.Header.Options.UseFont = True
        Me.xtcPenerimaanPengeluaran.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcPenerimaanPengeluaran.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcPenerimaanPengeluaran.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcPenerimaanPengeluaran.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcPenerimaanPengeluaran.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcPenerimaanPengeluaran.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcPenerimaanPengeluaran.AppearancePage.PageClient.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.xtcPenerimaanPengeluaran.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcPenerimaanPengeluaran.AppearancePage.PageClient.Options.UseBackColor = True
        Me.xtcPenerimaanPengeluaran.AppearancePage.PageClient.Options.UseFont = True
        Me.xtcPenerimaanPengeluaran.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcPenerimaanPengeluaran.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.xtcPenerimaanPengeluaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcPenerimaanPengeluaran.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcPenerimaanPengeluaran.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.xtcPenerimaanPengeluaran.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never
        Me.xtcPenerimaanPengeluaran.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcPenerimaanPengeluaran.Location = New System.Drawing.Point(0, 222)
        Me.xtcPenerimaanPengeluaran.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.xtcPenerimaanPengeluaran.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xtcPenerimaanPengeluaran.MultiLine = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.Name = "xtcPenerimaanPengeluaran"
        Me.xtcPenerimaanPengeluaran.SelectedTabPage = Me.xtpPenerimaan
        Me.xtcPenerimaanPengeluaran.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.ShowToolTips = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.Size = New System.Drawing.Size(786, 247)
        Me.xtcPenerimaanPengeluaran.TabIndex = 8
        Me.xtcPenerimaanPengeluaran.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpPenerimaan, Me.xtpPengeluaran})
        '
        'xtpPenerimaan
        '
        Me.xtpPenerimaan.Appearance.PageClient.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.xtpPenerimaan.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpPenerimaan.Controls.Add(Me.gcPenerimaanData)
        Me.xtpPenerimaan.Name = "xtpPenerimaan"
        Me.xtpPenerimaan.Size = New System.Drawing.Size(782, 243)
        Me.xtpPenerimaan.Text = "Penerimaan"
        '
        'gcPenerimaanData
        '
        Me.gcPenerimaanData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPenerimaanData.Location = New System.Drawing.Point(0, 0)
        Me.gcPenerimaanData.MainView = Me.gvPenerimaanData
        Me.gcPenerimaanData.Name = "gcPenerimaanData"
        Me.gcPenerimaanData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rceStatus, Me.rteReason, Me.rimeNote1})
        Me.gcPenerimaanData.Size = New System.Drawing.Size(782, 243)
        Me.gcPenerimaanData.TabIndex = 15
        Me.gcPenerimaanData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPenerimaanData})
        '
        'gvPenerimaanData
        '
        Me.gvPenerimaanData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvPenerimaanData.Appearance.Empty.Options.UseBackColor = True
        Me.gvPenerimaanData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gctID, Me.gctIDParent, Me.gctIDPengajuan, Me.gctIDCOA, Me.gctIDUnit, Me.gctNomorUrut, Me.gctUntuk, Me.gctNoDokumen, Me.gctJumlahUang, Me.gctDebetKredit, Me.gctDelete, Me.gctReason, Me.gctKDCOA})
        Me.gvPenerimaanData.GridControl = Me.gcPenerimaanData
        Me.gvPenerimaanData.Name = "gvPenerimaanData"
        Me.gvPenerimaanData.OptionsView.RowAutoHeight = True
        Me.gvPenerimaanData.OptionsView.ShowFooter = True
        Me.gvPenerimaanData.OptionsView.ShowGroupPanel = False
        '
        'gctID
        '
        Me.gctID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gctID.AppearanceCell.Options.UseBackColor = True
        Me.gctID.Caption = "ID"
        Me.gctID.FieldName = "idaruspengajuandt"
        Me.gctID.Name = "gctID"
        Me.gctID.OptionsColumn.AllowEdit = False
        Me.gctID.OptionsColumn.ReadOnly = True
        '
        'gctIDParent
        '
        Me.gctIDParent.Caption = "IDParent"
        Me.gctIDParent.FieldName = "idaruspengajuan"
        Me.gctIDParent.Name = "gctIDParent"
        Me.gctIDParent.OptionsColumn.AllowEdit = False
        Me.gctIDParent.OptionsColumn.ReadOnly = True
        '
        'gctIDPengajuan
        '
        Me.gctIDPengajuan.Caption = "IDPengajuan"
        Me.gctIDPengajuan.FieldName = "idpengajuan"
        Me.gctIDPengajuan.Name = "gctIDPengajuan"
        Me.gctIDPengajuan.OptionsColumn.AllowEdit = False
        Me.gctIDPengajuan.OptionsColumn.ReadOnly = True
        '
        'gctIDCOA
        '
        Me.gctIDCOA.Caption = "IDCOA"
        Me.gctIDCOA.FieldName = "idcoa"
        Me.gctIDCOA.Name = "gctIDCOA"
        '
        'gctIDUnit
        '
        Me.gctIDUnit.Caption = "IDUnit"
        Me.gctIDUnit.FieldName = "idunit"
        Me.gctIDUnit.Name = "gctIDUnit"
        '
        'gctNomorUrut
        '
        Me.gctNomorUrut.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gctNomorUrut.AppearanceCell.Options.UseBackColor = True
        Me.gctNomorUrut.Caption = "No."
        Me.gctNomorUrut.FieldName = "nomorurut"
        Me.gctNomorUrut.Name = "gctNomorUrut"
        Me.gctNomorUrut.OptionsColumn.AllowEdit = False
        Me.gctNomorUrut.OptionsColumn.ReadOnly = True
        Me.gctNomorUrut.Visible = True
        Me.gctNomorUrut.VisibleIndex = 0
        '
        'gctUntuk
        '
        Me.gctUntuk.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gctUntuk.AppearanceCell.Options.UseBackColor = True
        Me.gctUntuk.Caption = "Untuk"
        Me.gctUntuk.ColumnEdit = Me.rimeNote1
        Me.gctUntuk.FieldName = "keperluan"
        Me.gctUntuk.Name = "gctUntuk"
        Me.gctUntuk.OptionsColumn.AllowEdit = False
        Me.gctUntuk.OptionsColumn.ReadOnly = True
        Me.gctUntuk.Visible = True
        Me.gctUntuk.VisibleIndex = 1
        '
        'rimeNote1
        '
        Me.rimeNote1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeNote1.Name = "rimeNote1"
        Me.rimeNote1.ReadOnly = True
        Me.rimeNote1.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'gctNoDokumen
        '
        Me.gctNoDokumen.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gctNoDokumen.AppearanceCell.Options.UseBackColor = True
        Me.gctNoDokumen.Caption = "No Dokumen"
        Me.gctNoDokumen.FieldName = "nodokumen"
        Me.gctNoDokumen.Name = "gctNoDokumen"
        Me.gctNoDokumen.OptionsColumn.AllowEdit = False
        Me.gctNoDokumen.OptionsColumn.ReadOnly = True
        Me.gctNoDokumen.Visible = True
        Me.gctNoDokumen.VisibleIndex = 2
        '
        'gctJumlahUang
        '
        Me.gctJumlahUang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gctJumlahUang.AppearanceCell.Options.UseBackColor = True
        Me.gctJumlahUang.Caption = "Jumlah Uang"
        Me.gctJumlahUang.DisplayFormat.FormatString = "{0:n2}"
        Me.gctJumlahUang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gctJumlahUang.FieldName = "jumlahuang"
        Me.gctJumlahUang.Name = "gctJumlahUang"
        Me.gctJumlahUang.OptionsColumn.AllowEdit = False
        Me.gctJumlahUang.OptionsColumn.ReadOnly = True
        Me.gctJumlahUang.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jumlahuang", "{0:n2}")})
        Me.gctJumlahUang.Visible = True
        Me.gctJumlahUang.VisibleIndex = 3
        '
        'gctDebetKredit
        '
        Me.gctDebetKredit.Caption = "DK"
        Me.gctDebetKredit.FieldName = "posisidk"
        Me.gctDebetKredit.Name = "gctDebetKredit"
        '
        'gctDelete
        '
        Me.gctDelete.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gctDelete.AppearanceCell.Options.UseBackColor = True
        Me.gctDelete.Caption = "Status"
        Me.gctDelete.ColumnEdit = Me.rceStatus
        Me.gctDelete.FieldName = "isdeleted"
        Me.gctDelete.Name = "gctDelete"
        Me.gctDelete.Visible = True
        Me.gctDelete.VisibleIndex = 4
        '
        'rceStatus
        '
        Me.rceStatus.AutoHeight = False
        Me.rceStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rceStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idgeneral", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("generalcode", "Status")})
        Me.rceStatus.Name = "rceStatus"
        Me.rceStatus.NullText = "[Belum dipilih]"
        '
        'gctReason
        '
        Me.gctReason.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gctReason.AppearanceCell.Options.UseBackColor = True
        Me.gctReason.Caption = "Delete Reason"
        Me.gctReason.ColumnEdit = Me.rteReason
        Me.gctReason.FieldName = "deletereason"
        Me.gctReason.Name = "gctReason"
        Me.gctReason.Visible = True
        Me.gctReason.VisibleIndex = 5
        '
        'rteReason
        '
        Me.rteReason.AutoHeight = False
        Me.rteReason.MaxLength = 500
        Me.rteReason.Name = "rteReason"
        '
        'gctKDCOA
        '
        Me.gctKDCOA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gctKDCOA.AppearanceCell.Options.UseBackColor = True
        Me.gctKDCOA.Caption = "Kode Rekening"
        Me.gctKDCOA.FieldName = "coa"
        Me.gctKDCOA.Name = "gctKDCOA"
        Me.gctKDCOA.OptionsColumn.AllowEdit = False
        Me.gctKDCOA.OptionsColumn.ReadOnly = True
        Me.gctKDCOA.Visible = True
        Me.gctKDCOA.VisibleIndex = 6
        '
        'xtpPengeluaran
        '
        Me.xtpPengeluaran.Controls.Add(Me.gcPengeluaranData)
        Me.xtpPengeluaran.Name = "xtpPengeluaran"
        Me.xtpPengeluaran.Size = New System.Drawing.Size(782, 243)
        Me.xtpPengeluaran.Text = "Pengeluaran"
        '
        'gcPengeluaranData
        '
        Me.gcPengeluaranData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPengeluaranData.Location = New System.Drawing.Point(0, 0)
        Me.gcPengeluaranData.MainView = Me.gvPengeluaranData
        Me.gcPengeluaranData.Name = "gcPengeluaranData"
        Me.gcPengeluaranData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rte2Reason, Me.rce2Status, Me.rimeNote2})
        Me.gcPengeluaranData.Size = New System.Drawing.Size(782, 243)
        Me.gcPengeluaranData.TabIndex = 18
        Me.gcPengeluaranData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPengeluaranData})
        '
        'gvPengeluaranData
        '
        Me.gvPengeluaranData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvPengeluaranData.Appearance.Empty.Options.UseBackColor = True
        Me.gvPengeluaranData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gckID, Me.gckIDParent, Me.gckIDPengajuan, Me.gckIDCOA, Me.gckIDUnit, Me.gckNomorUrut, Me.gckUntuk, Me.gckNoDokumen, Me.gckJumlahUang, Me.gckDebetKredit, Me.gckDelete, Me.gckReason, Me.gckKDCOA})
        Me.gvPengeluaranData.GridControl = Me.gcPengeluaranData
        Me.gvPengeluaranData.Name = "gvPengeluaranData"
        Me.gvPengeluaranData.OptionsView.RowAutoHeight = True
        Me.gvPengeluaranData.OptionsView.ShowFooter = True
        Me.gvPengeluaranData.OptionsView.ShowGroupPanel = False
        '
        'gckID
        '
        Me.gckID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckID.AppearanceCell.Options.UseBackColor = True
        Me.gckID.Caption = "ID"
        Me.gckID.FieldName = "idaruspengajuandt"
        Me.gckID.Name = "gckID"
        Me.gckID.OptionsColumn.AllowEdit = False
        Me.gckID.OptionsColumn.ReadOnly = True
        '
        'gckIDParent
        '
        Me.gckIDParent.Caption = "IDParent"
        Me.gckIDParent.FieldName = "idaruspengajuan"
        Me.gckIDParent.Name = "gckIDParent"
        Me.gckIDParent.OptionsColumn.AllowEdit = False
        Me.gckIDParent.OptionsColumn.ReadOnly = True
        '
        'gckIDPengajuan
        '
        Me.gckIDPengajuan.Caption = "IDPengajuan"
        Me.gckIDPengajuan.FieldName = "idpengajuan"
        Me.gckIDPengajuan.Name = "gckIDPengajuan"
        Me.gckIDPengajuan.OptionsColumn.AllowEdit = False
        Me.gckIDPengajuan.OptionsColumn.ReadOnly = True
        '
        'gckIDCOA
        '
        Me.gckIDCOA.Caption = "IDCOA"
        Me.gckIDCOA.FieldName = "idcoa"
        Me.gckIDCOA.Name = "gckIDCOA"
        '
        'gckIDUnit
        '
        Me.gckIDUnit.Caption = "IDUnit"
        Me.gckIDUnit.FieldName = "idunit"
        Me.gckIDUnit.Name = "gckIDUnit"
        '
        'gckNomorUrut
        '
        Me.gckNomorUrut.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckNomorUrut.AppearanceCell.Options.UseBackColor = True
        Me.gckNomorUrut.Caption = "No."
        Me.gckNomorUrut.FieldName = "nomorurut"
        Me.gckNomorUrut.Name = "gckNomorUrut"
        Me.gckNomorUrut.OptionsColumn.AllowEdit = False
        Me.gckNomorUrut.OptionsColumn.ReadOnly = True
        Me.gckNomorUrut.Visible = True
        Me.gckNomorUrut.VisibleIndex = 0
        '
        'gckUntuk
        '
        Me.gckUntuk.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckUntuk.AppearanceCell.Options.UseBackColor = True
        Me.gckUntuk.Caption = "Untuk"
        Me.gckUntuk.ColumnEdit = Me.rimeNote2
        Me.gckUntuk.FieldName = "keperluan"
        Me.gckUntuk.Name = "gckUntuk"
        Me.gckUntuk.OptionsColumn.AllowEdit = False
        Me.gckUntuk.OptionsColumn.ReadOnly = True
        Me.gckUntuk.Visible = True
        Me.gckUntuk.VisibleIndex = 1
        '
        'rimeNote2
        '
        Me.rimeNote2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeNote2.Name = "rimeNote2"
        Me.rimeNote2.ReadOnly = True
        Me.rimeNote2.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'gckNoDokumen
        '
        Me.gckNoDokumen.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckNoDokumen.AppearanceCell.Options.UseBackColor = True
        Me.gckNoDokumen.Caption = "No Dokumen"
        Me.gckNoDokumen.FieldName = "nodokumen"
        Me.gckNoDokumen.Name = "gckNoDokumen"
        Me.gckNoDokumen.OptionsColumn.AllowEdit = False
        Me.gckNoDokumen.OptionsColumn.ReadOnly = True
        Me.gckNoDokumen.Visible = True
        Me.gckNoDokumen.VisibleIndex = 2
        '
        'gckJumlahUang
        '
        Me.gckJumlahUang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckJumlahUang.AppearanceCell.Options.UseBackColor = True
        Me.gckJumlahUang.Caption = "Jumlah Uang"
        Me.gckJumlahUang.DisplayFormat.FormatString = "{0:n2}"
        Me.gckJumlahUang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gckJumlahUang.FieldName = "jumlahuang"
        Me.gckJumlahUang.Name = "gckJumlahUang"
        Me.gckJumlahUang.OptionsColumn.AllowEdit = False
        Me.gckJumlahUang.OptionsColumn.ReadOnly = True
        Me.gckJumlahUang.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jumlahuang", "{0:n2}")})
        Me.gckJumlahUang.Visible = True
        Me.gckJumlahUang.VisibleIndex = 3
        '
        'gckDebetKredit
        '
        Me.gckDebetKredit.Caption = "DK"
        Me.gckDebetKredit.FieldName = "posisidk"
        Me.gckDebetKredit.Name = "gckDebetKredit"
        '
        'gckDelete
        '
        Me.gckDelete.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckDelete.AppearanceCell.Options.UseBackColor = True
        Me.gckDelete.Caption = "Status"
        Me.gckDelete.ColumnEdit = Me.rce2Status
        Me.gckDelete.FieldName = "isdeleted"
        Me.gckDelete.Name = "gckDelete"
        Me.gckDelete.Visible = True
        Me.gckDelete.VisibleIndex = 4
        '
        'rce2Status
        '
        Me.rce2Status.AutoHeight = False
        Me.rce2Status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rce2Status.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idgeneral", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("generalcode", "Status")})
        Me.rce2Status.Name = "rce2Status"
        Me.rce2Status.NullText = "[Belum dipilih]"
        '
        'gckReason
        '
        Me.gckReason.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckReason.AppearanceCell.Options.UseBackColor = True
        Me.gckReason.Caption = "Delete Reason"
        Me.gckReason.ColumnEdit = Me.rte2Reason
        Me.gckReason.FieldName = "deletereason"
        Me.gckReason.Name = "gckReason"
        Me.gckReason.Visible = True
        Me.gckReason.VisibleIndex = 5
        '
        'rte2Reason
        '
        Me.rte2Reason.AutoHeight = False
        Me.rte2Reason.MaxLength = 500
        Me.rte2Reason.Name = "rte2Reason"
        '
        'gckKDCOA
        '
        Me.gckKDCOA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckKDCOA.AppearanceCell.Options.UseBackColor = True
        Me.gckKDCOA.Caption = "Kode Rekening"
        Me.gckKDCOA.FieldName = "coa"
        Me.gckKDCOA.Name = "gckKDCOA"
        Me.gckKDCOA.OptionsColumn.AllowEdit = False
        Me.gckKDCOA.OptionsColumn.ReadOnly = True
        Me.gckKDCOA.Visible = True
        Me.gckKDCOA.VisibleIndex = 6
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel3, 2, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 190)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(786, 32)
        Me.TableLayoutPanel5.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel3.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.Panel3.Controls.Add(Me.tabPenerimaan)
        Me.Panel3.Controls.Add(Me.tabPengeluaran)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(306, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(392, 32)
        Me.Panel3.TabIndex = 13
        '
        'tabPenerimaan
        '
        Me.tabPenerimaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tabPenerimaan.Dock = System.Windows.Forms.DockStyle.Right
        Me.tabPenerimaan.FlatAppearance.BorderSize = 0
        Me.tabPenerimaan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.tabPenerimaan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.tabPenerimaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabPenerimaan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPenerimaan.ForeColor = System.Drawing.Color.White
        Me.tabPenerimaan.Location = New System.Drawing.Point(172, 0)
        Me.tabPenerimaan.Name = "tabPenerimaan"
        Me.tabPenerimaan.Size = New System.Drawing.Size(110, 32)
        Me.tabPenerimaan.TabIndex = 17
        Me.tabPenerimaan.Text = "PENERIMAAN"
        Me.tabPenerimaan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tabPenerimaan.UseVisualStyleBackColor = False
        '
        'tabPengeluaran
        '
        Me.tabPengeluaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tabPengeluaran.Dock = System.Windows.Forms.DockStyle.Right
        Me.tabPengeluaran.FlatAppearance.BorderSize = 0
        Me.tabPengeluaran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.tabPengeluaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.tabPengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabPengeluaran.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPengeluaran.ForeColor = System.Drawing.Color.White
        Me.tabPengeluaran.Location = New System.Drawing.Point(282, 0)
        Me.tabPengeluaran.Name = "tabPengeluaran"
        Me.tabPengeluaran.Size = New System.Drawing.Size(110, 32)
        Me.tabPengeluaran.TabIndex = 15
        Me.tabPengeluaran.Text = "PENGELUARAN"
        Me.tabPengeluaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tabPengeluaran.UseVisualStyleBackColor = False
        '
        'tlpUntuk
        '
        Me.tlpUntuk.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpUntuk.ColumnCount = 4
        Me.tlpUntuk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUntuk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpUntuk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.tlpUntuk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUntuk.Controls.Add(Me.Label3, 1, 3)
        Me.tlpUntuk.Controls.Add(Me.ceReject, 2, 2)
        Me.tlpUntuk.Controls.Add(Me.ceCheck, 2, 1)
        Me.tlpUntuk.Controls.Add(Me.teAlasan, 2, 3)
        Me.tlpUntuk.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpUntuk.Location = New System.Drawing.Point(0, 110)
        Me.tlpUntuk.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpUntuk.Name = "tlpUntuk"
        Me.tlpUntuk.RowCount = 5
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUntuk.Size = New System.Drawing.Size(786, 80)
        Me.tlpUntuk.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Alasan Penolakan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ceReject
        '
        Me.ceReject.Location = New System.Drawing.Point(221, 31)
        Me.ceReject.Name = "ceReject"
        Me.ceReject.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ceReject.Properties.Appearance.Options.UseFont = True
        Me.ceReject.Properties.AutoHeight = False
        Me.ceReject.Properties.Caption = "Saya menolak pengajuan ini."
        Me.ceReject.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.ceReject.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ceReject.Size = New System.Drawing.Size(474, 18)
        Me.ceReject.TabIndex = 43
        '
        'ceCheck
        '
        Me.ceCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ceCheck.Location = New System.Drawing.Point(221, 7)
        Me.ceCheck.Name = "ceCheck"
        Me.ceCheck.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ceCheck.Properties.Appearance.Options.UseFont = True
        Me.ceCheck.Properties.AutoHeight = False
        Me.ceCheck.Properties.Caption = "Saya telah melakukan pengecekan data dengan berkas terkait."
        Me.ceCheck.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.ceCheck.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ceCheck.Size = New System.Drawing.Size(474, 18)
        Me.ceCheck.TabIndex = 42
        '
        'teAlasan
        '
        Me.teAlasan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teAlasan.Location = New System.Drawing.Point(218, 54)
        Me.teAlasan.Margin = New System.Windows.Forms.Padding(0)
        Me.teAlasan.Name = "teAlasan"
        Me.teAlasan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teAlasan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAlasan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAlasan.Properties.Appearance.Options.UseBackColor = True
        Me.teAlasan.Properties.Appearance.Options.UseFont = True
        Me.teAlasan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teAlasan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teAlasan.Properties.MaxLength = 500
        Me.teAlasan.Properties.NullText = "[Belum Diisi]"
        Me.teAlasan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teAlasan.Properties.ReadOnly = True
        Me.teAlasan.Size = New System.Drawing.Size(480, 20)
        Me.teAlasan.TabIndex = 44
        Me.teAlasan.Tag = "PengajuanNo"
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.teTanggal, 4, 1)
        Me.tlpField.Controls.Add(Me.teBank, 2, 2)
        Me.tlpField.Controls.Add(Me.lblJumlahUang, 1, 2)
        Me.tlpField.Controls.Add(Me.lblPengajuanNo, 1, 1)
        Me.tlpField.Controls.Add(Me.tearuspengajuanNo, 2, 1)
        Me.tlpField.Controls.Add(Me.lblTanggal, 3, 1)
        Me.tlpField.Controls.Add(Me.Label1, 1, 3)
        Me.tlpField.Controls.Add(Me.Label2, 3, 3)
        Me.tlpField.Controls.Add(Me.seTotalPenerimaan, 2, 3)
        Me.tlpField.Controls.Add(Me.seTotalPengeluaran, 4, 3)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 5
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 80)
        Me.tlpField.TabIndex = 7
        '
        'teTanggal
        '
        Me.teTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTanggal.Location = New System.Drawing.Point(548, 6)
        Me.teTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.teTanggal.Name = "teTanggal"
        Me.teTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.teTanggal.Properties.Appearance.Options.UseFont = True
        Me.teTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTanggal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teTanggal.Properties.MaxLength = 12
        Me.teTanggal.Properties.NullText = "[Belum Diisi]"
        Me.teTanggal.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teTanggal.Properties.ReadOnly = True
        Me.teTanggal.Size = New System.Drawing.Size(135, 20)
        Me.teTanggal.TabIndex = 26
        Me.teTanggal.Tag = "noaruspengajuan"
        '
        'teBank
        '
        Me.teBank.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBank.Location = New System.Drawing.Point(218, 30)
        Me.teBank.Margin = New System.Windows.Forms.Padding(0)
        Me.teBank.Name = "teBank"
        Me.teBank.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teBank.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBank.Properties.Appearance.Options.UseBackColor = True
        Me.teBank.Properties.Appearance.Options.UseFont = True
        Me.teBank.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBank.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teBank.Properties.MaxLength = 12
        Me.teBank.Properties.NullText = "[Belum Diisi]"
        Me.teBank.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teBank.Properties.ReadOnly = True
        Me.teBank.Size = New System.Drawing.Size(198, 20)
        Me.teBank.TabIndex = 26
        Me.teBank.Tag = "noaruspengajuan"
        '
        'lblJumlahUang
        '
        Me.lblJumlahUang.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblJumlahUang.AutoSize = True
        Me.lblJumlahUang.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUang.Location = New System.Drawing.Point(182, 33)
        Me.lblJumlahUang.Name = "lblJumlahUang"
        Me.lblJumlahUang.Size = New System.Drawing.Size(33, 14)
        Me.lblJumlahUang.TabIndex = 9
        Me.lblJumlahUang.Text = "Bank"
        Me.lblJumlahUang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPengajuanNo
        '
        Me.lblPengajuanNo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPengajuanNo.AutoSize = True
        Me.lblPengajuanNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPengajuanNo.Location = New System.Drawing.Point(111, 9)
        Me.lblPengajuanNo.Name = "lblPengajuanNo"
        Me.lblPengajuanNo.Size = New System.Drawing.Size(104, 14)
        Me.lblPengajuanNo.TabIndex = 22
        Me.lblPengajuanNo.Text = "Nomor Pengajuan"
        Me.lblPengajuanNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tearuspengajuanNo
        '
        Me.tearuspengajuanNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tearuspengajuanNo.Location = New System.Drawing.Point(218, 6)
        Me.tearuspengajuanNo.Margin = New System.Windows.Forms.Padding(0)
        Me.tearuspengajuanNo.Name = "tearuspengajuanNo"
        Me.tearuspengajuanNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tearuspengajuanNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tearuspengajuanNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tearuspengajuanNo.Properties.Appearance.Options.UseBackColor = True
        Me.tearuspengajuanNo.Properties.Appearance.Options.UseFont = True
        Me.tearuspengajuanNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tearuspengajuanNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tearuspengajuanNo.Properties.MaxLength = 12
        Me.tearuspengajuanNo.Properties.NullText = "[Belum Diisi]"
        Me.tearuspengajuanNo.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tearuspengajuanNo.Properties.ReadOnly = True
        Me.tearuspengajuanNo.Size = New System.Drawing.Size(150, 20)
        Me.tearuspengajuanNo.TabIndex = 25
        Me.tearuspengajuanNo.Tag = "noaruspengajuan"
        '
        'lblTanggal
        '
        Me.lblTanggal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(434, 9)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(111, 14)
        Me.lblTanggal.TabIndex = 29
        Me.lblTanggal.Text = "Tanggal Pengajuan"
        Me.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 14)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Jumlah Penerimaan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(430, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 14)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Jumlah Pengeluaran"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seTotalPenerimaan
        '
        Me.seTotalPenerimaan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seTotalPenerimaan.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTotalPenerimaan.Location = New System.Drawing.Point(218, 54)
        Me.seTotalPenerimaan.Margin = New System.Windows.Forms.Padding(0)
        Me.seTotalPenerimaan.Name = "seTotalPenerimaan"
        Me.seTotalPenerimaan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seTotalPenerimaan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seTotalPenerimaan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seTotalPenerimaan.Properties.Appearance.Options.UseBackColor = True
        Me.seTotalPenerimaan.Properties.Appearance.Options.UseFont = True
        Me.seTotalPenerimaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seTotalPenerimaan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.seTotalPenerimaan.Properties.DisplayFormat.FormatString = "n2"
        Me.seTotalPenerimaan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seTotalPenerimaan.Properties.EditFormat.FormatString = "n2"
        Me.seTotalPenerimaan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seTotalPenerimaan.Properties.IsFloatValue = False
        Me.seTotalPenerimaan.Properties.Mask.EditMask = "N00"
        Me.seTotalPenerimaan.Properties.MaxLength = 16
        Me.seTotalPenerimaan.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.seTotalPenerimaan.Properties.ReadOnly = True
        Me.seTotalPenerimaan.Size = New System.Drawing.Size(150, 20)
        Me.seTotalPenerimaan.TabIndex = 51
        Me.seTotalPenerimaan.Tag = ""
        '
        'seTotalPengeluaran
        '
        Me.seTotalPengeluaran.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seTotalPengeluaran.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTotalPengeluaran.Location = New System.Drawing.Point(548, 54)
        Me.seTotalPengeluaran.Margin = New System.Windows.Forms.Padding(0)
        Me.seTotalPengeluaran.Name = "seTotalPengeluaran"
        Me.seTotalPengeluaran.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seTotalPengeluaran.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seTotalPengeluaran.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seTotalPengeluaran.Properties.Appearance.Options.UseBackColor = True
        Me.seTotalPengeluaran.Properties.Appearance.Options.UseFont = True
        Me.seTotalPengeluaran.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seTotalPengeluaran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.seTotalPengeluaran.Properties.DisplayFormat.FormatString = "n2"
        Me.seTotalPengeluaran.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seTotalPengeluaran.Properties.EditFormat.FormatString = "n2"
        Me.seTotalPengeluaran.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seTotalPengeluaran.Properties.IsFloatValue = False
        Me.seTotalPengeluaran.Properties.Mask.EditMask = "N00"
        Me.seTotalPengeluaran.Properties.MaxLength = 16
        Me.seTotalPengeluaran.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.seTotalPengeluaran.Properties.ReadOnly = True
        Me.seTotalPengeluaran.Size = New System.Drawing.Size(150, 20)
        Me.seTotalPengeluaran.TabIndex = 52
        Me.seTotalPengeluaran.Tag = ""
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
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
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 30)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "CARI"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(706, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblSep5
        '
        Me.lblSep5.BackColor = System.Drawing.Color.Transparent
        Me.lblSep5.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSep5.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep5.Location = New System.Drawing.Point(74, 0)
        Me.lblSep5.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSep5.Name = "lblSep5"
        Me.lblSep5.Size = New System.Drawing.Size(16, 1)
        Me.lblSep5.TabIndex = 19
        Me.lblSep5.Text = "|"
        Me.lblSep5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmReviewPPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 499)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReviewPPP"
        Me.ShowInTaskbar = False
        Me.Text = "Review Pengajuan Penerimaan dan Pengeluaran Uang Bank"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.xtcPenerimaanPengeluaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcPenerimaanPengeluaran.ResumeLayout(False)
        Me.xtpPenerimaan.ResumeLayout(False)
        CType(Me.gcPenerimaanData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPenerimaanData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeNote1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rceStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rteReason, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPengeluaran.ResumeLayout(False)
        CType(Me.gcPengeluaranData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPengeluaranData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeNote2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rce2Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rte2Reason, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tlpUntuk.ResumeLayout(False)
        Me.tlpUntuk.PerformLayout()
        CType(Me.ceReject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAlasan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tearuspengajuanNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTotalPenerimaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTotalPengeluaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblJumlahUang As System.Windows.Forms.Label
    Friend WithEvents lblPengajuanNo As System.Windows.Forms.Label
    Friend WithEvents tearuspengajuanNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents xtcPenerimaanPengeluaran As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpPenerimaan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpPengeluaran As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents seTotalPenerimaan As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seTotalPengeluaran As DevExpress.XtraEditors.SpinEdit
    Public WithEvents gcPenerimaanData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvPenerimaanData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gctID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctIDParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctIDPengajuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctNomorUrut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctUntuk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctNoDokumen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctJumlahUang As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents gcPengeluaranData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvPengeluaranData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gckID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckIDParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckIDPengajuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckNomorUrut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckUntuk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckNoDokumen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckJumlahUang As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents tabPenerimaan As System.Windows.Forms.Button
    Public WithEvents tabPengeluaran As System.Windows.Forms.Button
    Friend WithEvents gctDebetKredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckDebetKredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teBank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teTanggal As DevExpress.XtraEditors.TextEdit
    Public WithEvents tlpUntuk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ceReject As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ceCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents teAlasan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gctDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rceStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rteReason As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gckDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rce2Status As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gckReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rte2Reason As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gckIDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckKDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctIDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctKDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rimeNote2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rimeNote1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents gctIDUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckIDUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
