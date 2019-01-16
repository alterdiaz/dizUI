<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPPP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPPP))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.gvPenerimaanData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gctID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctIDParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctIDPengajuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctIDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctKDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctNomorUrut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctUntuk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeNote2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gctNoDokumen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctJumlahUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctDebetKredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctIDUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpPenerimaan2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUntuk = New System.Windows.Forms.Label()
        Me.tePenerimaanKeperluan = New DevExpress.XtraEditors.MemoEdit()
        Me.tlpPenerimaan1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAtasan = New System.Windows.Forms.Label()
        Me.lblJabatanAtasan = New System.Windows.Forms.Label()
        Me.tePenerimaanNoDokumen = New DevExpress.XtraEditors.TextEdit()
        Me.sePenerimaanUang = New DevExpress.XtraEditors.SpinEdit()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPenerimaanBaru = New System.Windows.Forms.Button()
        Me.btnPenerimaanSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.teRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lueCOA = New DevExpress.XtraEditors.LookUpEdit()
        Me.xtpPengeluaran = New DevExpress.XtraTab.XtraTabPage()
        Me.gcPengeluaranData = New DevExpress.XtraGrid.GridControl()
        Me.gvPengeluaranData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gckID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckIDParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckIDPengajuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckIDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckNomorUrut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckUntuk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeNote1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gckNoDokumen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckJumlahUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckDebetKredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gckIDUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpPengeluaran2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tePengeluaranKeperluan = New DevExpress.XtraEditors.MemoEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tlpPengeluaran1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tePengeluaranTanggalUMPB = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tePengeluaranNoUMPB = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tePengeluaranNoDokumen = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sePengeluaranUang = New DevExpress.XtraEditors.SpinEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPengeluaranSearch = New System.Windows.Forms.Button()
        Me.btnPengeluaranSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tabPenerimaan = New System.Windows.Forms.Button()
        Me.tabPengeluaran = New System.Windows.Forms.Button()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lblJumlahUang = New System.Windows.Forms.Label()
        Me.lblPengajuanNo = New System.Windows.Forms.Label()
        Me.tearuspengajuanNo = New DevExpress.XtraEditors.TextEdit()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lueBank = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.seTotalPengeluaran = New DevExpress.XtraEditors.SpinEdit()
        Me.seTotalPenerimaan = New DevExpress.XtraEditors.SpinEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lueJenis = New DevExpress.XtraEditors.LookUpEdit()
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
        CType(Me.rimeNote2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPenerimaan2.SuspendLayout()
        CType(Me.tePenerimaanKeperluan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPenerimaan1.SuspendLayout()
        CType(Me.tePenerimaanNoDokumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePenerimaanUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPengeluaran.SuspendLayout()
        CType(Me.gcPengeluaranData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPengeluaranData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeNote1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPengeluaran2.SuspendLayout()
        CType(Me.tePengeluaranKeperluan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPengeluaran1.SuspendLayout()
        CType(Me.tePengeluaranTanggalUMPB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePengeluaranNoUMPB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePengeluaranNoDokumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePengeluaranUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.tearuspengajuanNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTotalPengeluaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTotalPenerimaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Teal
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
        Me.pTitle.TabIndex = 11
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
        Me.lblTitle.Text = "Pengajuan Penerimaan dan Pengeluaran Uang Bank"
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
        Me.xtcPenerimaanPengeluaran.Location = New System.Drawing.Point(0, 140)
        Me.xtcPenerimaanPengeluaran.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.xtcPenerimaanPengeluaran.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xtcPenerimaanPengeluaran.MultiLine = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.Name = "xtcPenerimaanPengeluaran"
        Me.xtcPenerimaanPengeluaran.SelectedTabPage = Me.xtpPenerimaan
        Me.xtcPenerimaanPengeluaran.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.ShowToolTips = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcPenerimaanPengeluaran.Size = New System.Drawing.Size(786, 329)
        Me.xtcPenerimaanPengeluaran.TabIndex = 8
        Me.xtcPenerimaanPengeluaran.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpPenerimaan, Me.xtpPengeluaran})
        '
        'xtpPenerimaan
        '
        Me.xtpPenerimaan.Appearance.PageClient.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.xtpPenerimaan.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpPenerimaan.Controls.Add(Me.gcPenerimaanData)
        Me.xtpPenerimaan.Controls.Add(Me.tlpPenerimaan2)
        Me.xtpPenerimaan.Controls.Add(Me.tlpPenerimaan1)
        Me.xtpPenerimaan.Controls.Add(Me.TableLayoutPanel1)
        Me.xtpPenerimaan.Name = "xtpPenerimaan"
        Me.xtpPenerimaan.Size = New System.Drawing.Size(782, 325)
        Me.xtpPenerimaan.Text = "Penerimaan"
        '
        'gcPenerimaanData
        '
        Me.gcPenerimaanData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.ImageList = Me.ImageList1
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gcPenerimaanData.EmbeddedNavigator.Buttons.Remove.ImageIndex = 0
        Me.gcPenerimaanData.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None
        Me.gcPenerimaanData.Location = New System.Drawing.Point(0, 110)
        Me.gcPenerimaanData.MainView = Me.gvPenerimaanData
        Me.gcPenerimaanData.Name = "gcPenerimaanData"
        Me.gcPenerimaanData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rimeNote2})
        Me.gcPenerimaanData.Size = New System.Drawing.Size(782, 215)
        Me.gcPenerimaanData.TabIndex = 15
        Me.gcPenerimaanData.UseEmbeddedNavigator = True
        Me.gcPenerimaanData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPenerimaanData})
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "deleteitem20.png")
        '
        'gvPenerimaanData
        '
        Me.gvPenerimaanData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvPenerimaanData.Appearance.Empty.Options.UseBackColor = True
        Me.gvPenerimaanData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gctID, Me.gctIDParent, Me.gctIDPengajuan, Me.gctIDCOA, Me.gctKDCOA, Me.gctNomorUrut, Me.gctUntuk, Me.gctNoDokumen, Me.gctJumlahUang, Me.gctDebetKredit, Me.gctIDUnit})
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
        Me.gctKDCOA.VisibleIndex = 4
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
        Me.gctUntuk.ColumnEdit = Me.rimeNote2
        Me.gctUntuk.FieldName = "keperluan"
        Me.gctUntuk.Name = "gctUntuk"
        Me.gctUntuk.OptionsColumn.AllowEdit = False
        Me.gctUntuk.OptionsColumn.ReadOnly = True
        Me.gctUntuk.Visible = True
        Me.gctUntuk.VisibleIndex = 1
        '
        'rimeNote2
        '
        Me.rimeNote2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeNote2.Name = "rimeNote2"
        Me.rimeNote2.ReadOnly = True
        Me.rimeNote2.ScrollBars = System.Windows.Forms.ScrollBars.None
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
        'gctIDUnit
        '
        Me.gctIDUnit.Caption = "IDUnit"
        Me.gctIDUnit.FieldName = "idunit"
        Me.gctIDUnit.Name = "gctIDUnit"
        '
        'tlpPenerimaan2
        '
        Me.tlpPenerimaan2.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpPenerimaan2.ColumnCount = 4
        Me.tlpPenerimaan2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPenerimaan2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpPenerimaan2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.tlpPenerimaan2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPenerimaan2.Controls.Add(Me.lblUntuk, 1, 1)
        Me.tlpPenerimaan2.Controls.Add(Me.tePenerimaanKeperluan, 2, 1)
        Me.tlpPenerimaan2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPenerimaan2.Location = New System.Drawing.Point(0, 60)
        Me.tlpPenerimaan2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPenerimaan2.Name = "tlpPenerimaan2"
        Me.tlpPenerimaan2.RowCount = 3
        Me.tlpPenerimaan2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPenerimaan2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpPenerimaan2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPenerimaan2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPenerimaan2.Size = New System.Drawing.Size(782, 50)
        Me.tlpPenerimaan2.TabIndex = 12
        '
        'lblUntuk
        '
        Me.lblUntuk.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUntuk.AutoSize = True
        Me.lblUntuk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUntuk.Location = New System.Drawing.Point(152, 18)
        Me.lblUntuk.Name = "lblUntuk"
        Me.lblUntuk.Size = New System.Drawing.Size(61, 14)
        Me.lblUntuk.TabIndex = 41
        Me.lblUntuk.Text = "Keperluan"
        Me.lblUntuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePenerimaanKeperluan
        '
        Me.tePenerimaanKeperluan.Location = New System.Drawing.Point(216, 1)
        Me.tePenerimaanKeperluan.Margin = New System.Windows.Forms.Padding(0)
        Me.tePenerimaanKeperluan.Name = "tePenerimaanKeperluan"
        Me.tePenerimaanKeperluan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePenerimaanKeperluan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePenerimaanKeperluan.Properties.Appearance.Options.UseBackColor = True
        Me.tePenerimaanKeperluan.Properties.Appearance.Options.UseFont = True
        Me.tePenerimaanKeperluan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePenerimaanKeperluan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tePenerimaanKeperluan.Properties.MaxLength = 5000
        Me.tePenerimaanKeperluan.Properties.NullText = "[Belum Diisi]"
        Me.tePenerimaanKeperluan.Size = New System.Drawing.Size(480, 46)
        Me.tePenerimaanKeperluan.TabIndex = 42
        '
        'tlpPenerimaan1
        '
        Me.tlpPenerimaan1.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpPenerimaan1.ColumnCount = 6
        Me.tlpPenerimaan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPenerimaan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpPenerimaan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpPenerimaan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpPenerimaan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpPenerimaan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPenerimaan1.Controls.Add(Me.lblAtasan, 1, 1)
        Me.tlpPenerimaan1.Controls.Add(Me.lblJabatanAtasan, 3, 1)
        Me.tlpPenerimaan1.Controls.Add(Me.tePenerimaanNoDokumen, 2, 1)
        Me.tlpPenerimaan1.Controls.Add(Me.sePenerimaanUang, 4, 1)
        Me.tlpPenerimaan1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPenerimaan1.Location = New System.Drawing.Point(0, 30)
        Me.tlpPenerimaan1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPenerimaan1.Name = "tlpPenerimaan1"
        Me.tlpPenerimaan1.RowCount = 3
        Me.tlpPenerimaan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPenerimaan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPenerimaan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPenerimaan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPenerimaan1.Size = New System.Drawing.Size(782, 30)
        Me.tlpPenerimaan1.TabIndex = 11
        '
        'lblAtasan
        '
        Me.lblAtasan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAtasan.AutoSize = True
        Me.lblAtasan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtasan.Location = New System.Drawing.Point(114, 8)
        Me.lblAtasan.Name = "lblAtasan"
        Me.lblAtasan.Size = New System.Drawing.Size(99, 14)
        Me.lblAtasan.TabIndex = 28
        Me.lblAtasan.Text = "Nomor Dokumen"
        Me.lblAtasan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJabatanAtasan
        '
        Me.lblJabatanAtasan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblJabatanAtasan.AutoSize = True
        Me.lblJabatanAtasan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJabatanAtasan.Location = New System.Drawing.Point(467, 8)
        Me.lblJabatanAtasan.Name = "lblJabatanAtasan"
        Me.lblJabatanAtasan.Size = New System.Drawing.Size(76, 14)
        Me.lblJabatanAtasan.TabIndex = 36
        Me.lblJabatanAtasan.Text = "Jumlah Uang"
        Me.lblJabatanAtasan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePenerimaanNoDokumen
        '
        Me.tePenerimaanNoDokumen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePenerimaanNoDokumen.Location = New System.Drawing.Point(216, 5)
        Me.tePenerimaanNoDokumen.Margin = New System.Windows.Forms.Padding(0)
        Me.tePenerimaanNoDokumen.Name = "tePenerimaanNoDokumen"
        Me.tePenerimaanNoDokumen.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tePenerimaanNoDokumen.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePenerimaanNoDokumen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePenerimaanNoDokumen.Properties.Appearance.Options.UseBackColor = True
        Me.tePenerimaanNoDokumen.Properties.Appearance.Options.UseFont = True
        Me.tePenerimaanNoDokumen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePenerimaanNoDokumen.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tePenerimaanNoDokumen.Properties.MaxLength = 250
        Me.tePenerimaanNoDokumen.Properties.NullText = "[Belum Diisi]"
        Me.tePenerimaanNoDokumen.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePenerimaanNoDokumen.Size = New System.Drawing.Size(198, 20)
        Me.tePenerimaanNoDokumen.TabIndex = 47
        Me.tePenerimaanNoDokumen.Tag = "namareview"
        '
        'sePenerimaanUang
        '
        Me.sePenerimaanUang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.sePenerimaanUang.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePenerimaanUang.Location = New System.Drawing.Point(546, 5)
        Me.sePenerimaanUang.Margin = New System.Windows.Forms.Padding(0)
        Me.sePenerimaanUang.Name = "sePenerimaanUang"
        Me.sePenerimaanUang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.sePenerimaanUang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sePenerimaanUang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sePenerimaanUang.Properties.Appearance.Options.UseBackColor = True
        Me.sePenerimaanUang.Properties.Appearance.Options.UseFont = True
        Me.sePenerimaanUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.sePenerimaanUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.sePenerimaanUang.Properties.DisplayFormat.FormatString = "n2"
        Me.sePenerimaanUang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePenerimaanUang.Properties.EditFormat.FormatString = "n2"
        Me.sePenerimaanUang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePenerimaanUang.Properties.IsFloatValue = False
        Me.sePenerimaanUang.Properties.Mask.EditMask = "N00"
        Me.sePenerimaanUang.Properties.MaxLength = 11
        Me.sePenerimaanUang.Properties.MaxValue = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.sePenerimaanUang.Size = New System.Drawing.Size(150, 20)
        Me.sePenerimaanUang.TabIndex = 48
        Me.sePenerimaanUang.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lueCOA, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(782, 30)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnPenerimaanBaru)
        Me.Panel1.Controls.Add(Me.btnPenerimaanSave)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.teRemarks)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(304, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 32)
        Me.Panel1.TabIndex = 13
        '
        'btnPenerimaanBaru
        '
        Me.btnPenerimaanBaru.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPenerimaanBaru.FlatAppearance.BorderSize = 0
        Me.btnPenerimaanBaru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPenerimaanBaru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPenerimaanBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenerimaanBaru.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenerimaanBaru.Location = New System.Drawing.Point(212, 0)
        Me.btnPenerimaanBaru.Name = "btnPenerimaanBaru"
        Me.btnPenerimaanBaru.Size = New System.Drawing.Size(60, 32)
        Me.btnPenerimaanBaru.TabIndex = 17
        Me.btnPenerimaanBaru.Text = "BARU"
        Me.btnPenerimaanBaru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPenerimaanBaru.UseVisualStyleBackColor = False
        '
        'btnPenerimaanSave
        '
        Me.btnPenerimaanSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnPenerimaanSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPenerimaanSave.FlatAppearance.BorderSize = 0
        Me.btnPenerimaanSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPenerimaanSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPenerimaanSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenerimaanSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenerimaanSave.Location = New System.Drawing.Point(272, 0)
        Me.btnPenerimaanSave.Name = "btnPenerimaanSave"
        Me.btnPenerimaanSave.Size = New System.Drawing.Size(120, 32)
        Me.btnPenerimaanSave.TabIndex = 15
        Me.btnPenerimaanSave.Text = "SIMPAN DI TABEL"
        Me.btnPenerimaanSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPenerimaanSave.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 14)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Remarks"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'teRemarks
        '
        Me.teRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRemarks.Location = New System.Drawing.Point(127, 12)
        Me.teRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teRemarks.Name = "teRemarks"
        Me.teRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teRemarks.Properties.Appearance.Options.UseFont = True
        Me.teRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRemarks.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teRemarks.Properties.MaxLength = 500
        Me.teRemarks.Properties.NullText = "[Belum Diisi]"
        Me.teRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRemarks.Properties.ReadOnly = True
        Me.teRemarks.Size = New System.Drawing.Size(150, 20)
        Me.teRemarks.TabIndex = 59
        Me.teRemarks.Tag = ""
        Me.teRemarks.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 28)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Kode Rekening"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'lueCOA
        '
        Me.lueCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueCOA.Location = New System.Drawing.Point(86, 5)
        Me.lueCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.lueCOA.Name = "lueCOA"
        Me.lueCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueCOA.Properties.Appearance.Options.UseBackColor = True
        Me.lueCOA.Properties.Appearance.Options.UseFont = True
        Me.lueCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCOA.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idcoa", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("coa", "Kode Rekening"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("remarks", "Remarks")})
        Me.lueCOA.Properties.NullText = "[Isian belum dipilih]"
        Me.lueCOA.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueCOA.Size = New System.Drawing.Size(130, 20)
        Me.lueCOA.TabIndex = 58
        Me.lueCOA.Visible = False
        '
        'xtpPengeluaran
        '
        Me.xtpPengeluaran.Controls.Add(Me.gcPengeluaranData)
        Me.xtpPengeluaran.Controls.Add(Me.tlpPengeluaran2)
        Me.xtpPengeluaran.Controls.Add(Me.tlpPengeluaran1)
        Me.xtpPengeluaran.Controls.Add(Me.TableLayoutPanel4)
        Me.xtpPengeluaran.Name = "xtpPengeluaran"
        Me.xtpPengeluaran.Size = New System.Drawing.Size(782, 325)
        Me.xtpPengeluaran.Text = "Pengeluaran"
        '
        'gcPengeluaranData
        '
        Me.gcPengeluaranData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.ImageList = Me.ImageList1
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gcPengeluaranData.EmbeddedNavigator.Buttons.Remove.ImageIndex = 0
        Me.gcPengeluaranData.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None
        Me.gcPengeluaranData.Location = New System.Drawing.Point(0, 136)
        Me.gcPengeluaranData.MainView = Me.gvPengeluaranData
        Me.gcPengeluaranData.Name = "gcPengeluaranData"
        Me.gcPengeluaranData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rimeNote1})
        Me.gcPengeluaranData.Size = New System.Drawing.Size(782, 189)
        Me.gcPengeluaranData.TabIndex = 18
        Me.gcPengeluaranData.UseEmbeddedNavigator = True
        Me.gcPengeluaranData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPengeluaranData})
        '
        'gvPengeluaranData
        '
        Me.gvPengeluaranData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvPengeluaranData.Appearance.Empty.Options.UseBackColor = True
        Me.gvPengeluaranData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gckID, Me.gckIDParent, Me.gckIDPengajuan, Me.gckIDCOA, Me.gckNomorUrut, Me.gckUntuk, Me.gckNoDokumen, Me.gckJumlahUang, Me.gckDebetKredit, Me.gckCOA, Me.gckIDUnit})
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
        Me.gckUntuk.ColumnEdit = Me.rimeNote1
        Me.gckUntuk.FieldName = "keperluan"
        Me.gckUntuk.Name = "gckUntuk"
        Me.gckUntuk.OptionsColumn.AllowEdit = False
        Me.gckUntuk.OptionsColumn.ReadOnly = True
        Me.gckUntuk.Visible = True
        Me.gckUntuk.VisibleIndex = 1
        '
        'rimeNote1
        '
        Me.rimeNote1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeNote1.Name = "rimeNote1"
        Me.rimeNote1.ReadOnly = True
        Me.rimeNote1.ScrollBars = System.Windows.Forms.ScrollBars.None
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
        'gckCOA
        '
        Me.gckCOA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gckCOA.AppearanceCell.Options.UseBackColor = True
        Me.gckCOA.Caption = "Kode Rekening"
        Me.gckCOA.FieldName = "coa"
        Me.gckCOA.Name = "gckCOA"
        Me.gckCOA.OptionsColumn.AllowEdit = False
        Me.gckCOA.OptionsColumn.ReadOnly = True
        Me.gckCOA.Visible = True
        Me.gckCOA.VisibleIndex = 4
        '
        'gckIDUnit
        '
        Me.gckIDUnit.Caption = "IDUnit"
        Me.gckIDUnit.FieldName = "idunit"
        Me.gckIDUnit.Name = "gckIDUnit"
        '
        'tlpPengeluaran2
        '
        Me.tlpPengeluaran2.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpPengeluaran2.ColumnCount = 4
        Me.tlpPengeluaran2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengeluaran2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpPengeluaran2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.tlpPengeluaran2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengeluaran2.Controls.Add(Me.tePengeluaranKeperluan, 2, 1)
        Me.tlpPengeluaran2.Controls.Add(Me.Label3, 1, 1)
        Me.tlpPengeluaran2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPengeluaran2.Location = New System.Drawing.Point(0, 86)
        Me.tlpPengeluaran2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPengeluaran2.Name = "tlpPengeluaran2"
        Me.tlpPengeluaran2.RowCount = 3
        Me.tlpPengeluaran2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengeluaran2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpPengeluaran2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengeluaran2.Size = New System.Drawing.Size(782, 50)
        Me.tlpPengeluaran2.TabIndex = 16
        '
        'tePengeluaranKeperluan
        '
        Me.tePengeluaranKeperluan.Location = New System.Drawing.Point(216, 1)
        Me.tePengeluaranKeperluan.Margin = New System.Windows.Forms.Padding(0)
        Me.tePengeluaranKeperluan.Name = "tePengeluaranKeperluan"
        Me.tePengeluaranKeperluan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePengeluaranKeperluan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePengeluaranKeperluan.Properties.Appearance.Options.UseBackColor = True
        Me.tePengeluaranKeperluan.Properties.Appearance.Options.UseFont = True
        Me.tePengeluaranKeperluan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePengeluaranKeperluan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tePengeluaranKeperluan.Properties.MaxLength = 5000
        Me.tePengeluaranKeperluan.Properties.NullText = "[Belum Diisi]"
        Me.tePengeluaranKeperluan.Properties.ReadOnly = True
        Me.tePengeluaranKeperluan.Size = New System.Drawing.Size(480, 46)
        Me.tePengeluaranKeperluan.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Keperluan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpPengeluaran1
        '
        Me.tlpPengeluaran1.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpPengeluaran1.ColumnCount = 6
        Me.tlpPengeluaran1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengeluaran1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpPengeluaran1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpPengeluaran1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpPengeluaran1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpPengeluaran1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengeluaran1.Controls.Add(Me.tePengeluaranTanggalUMPB, 4, 1)
        Me.tlpPengeluaran1.Controls.Add(Me.Label7, 3, 1)
        Me.tlpPengeluaran1.Controls.Add(Me.tePengeluaranNoUMPB, 2, 1)
        Me.tlpPengeluaran1.Controls.Add(Me.Label4, 1, 2)
        Me.tlpPengeluaran1.Controls.Add(Me.tePengeluaranNoDokumen, 2, 2)
        Me.tlpPengeluaran1.Controls.Add(Me.Label5, 3, 2)
        Me.tlpPengeluaran1.Controls.Add(Me.sePengeluaranUang, 4, 2)
        Me.tlpPengeluaran1.Controls.Add(Me.Label6, 1, 1)
        Me.tlpPengeluaran1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPengeluaran1.Location = New System.Drawing.Point(0, 32)
        Me.tlpPengeluaran1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPengeluaran1.Name = "tlpPengeluaran1"
        Me.tlpPengeluaran1.RowCount = 4
        Me.tlpPengeluaran1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengeluaran1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengeluaran1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengeluaran1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengeluaran1.Size = New System.Drawing.Size(782, 54)
        Me.tlpPengeluaran1.TabIndex = 15
        '
        'tePengeluaranTanggalUMPB
        '
        Me.tePengeluaranTanggalUMPB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePengeluaranTanggalUMPB.Location = New System.Drawing.Point(546, 5)
        Me.tePengeluaranTanggalUMPB.Margin = New System.Windows.Forms.Padding(0)
        Me.tePengeluaranTanggalUMPB.Name = "tePengeluaranTanggalUMPB"
        Me.tePengeluaranTanggalUMPB.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tePengeluaranTanggalUMPB.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePengeluaranTanggalUMPB.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePengeluaranTanggalUMPB.Properties.Appearance.Options.UseBackColor = True
        Me.tePengeluaranTanggalUMPB.Properties.Appearance.Options.UseFont = True
        Me.tePengeluaranTanggalUMPB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePengeluaranTanggalUMPB.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tePengeluaranTanggalUMPB.Properties.MaxLength = 14
        Me.tePengeluaranTanggalUMPB.Properties.NullText = "[Belum Diisi]"
        Me.tePengeluaranTanggalUMPB.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePengeluaranTanggalUMPB.Properties.ReadOnly = True
        Me.tePengeluaranTanggalUMPB.Size = New System.Drawing.Size(135, 20)
        Me.tePengeluaranTanggalUMPB.TabIndex = 27
        Me.tePengeluaranTanggalUMPB.Tag = ""
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(458, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 14)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Tanggal UMPB"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePengeluaranNoUMPB
        '
        Me.tePengeluaranNoUMPB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePengeluaranNoUMPB.Location = New System.Drawing.Point(216, 5)
        Me.tePengeluaranNoUMPB.Margin = New System.Windows.Forms.Padding(0)
        Me.tePengeluaranNoUMPB.Name = "tePengeluaranNoUMPB"
        Me.tePengeluaranNoUMPB.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tePengeluaranNoUMPB.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePengeluaranNoUMPB.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePengeluaranNoUMPB.Properties.Appearance.Options.UseBackColor = True
        Me.tePengeluaranNoUMPB.Properties.Appearance.Options.UseFont = True
        Me.tePengeluaranNoUMPB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePengeluaranNoUMPB.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tePengeluaranNoUMPB.Properties.MaxLength = 12
        Me.tePengeluaranNoUMPB.Properties.NullText = "[Belum Diisi]"
        Me.tePengeluaranNoUMPB.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePengeluaranNoUMPB.Properties.ReadOnly = True
        Me.tePengeluaranNoUMPB.Size = New System.Drawing.Size(150, 20)
        Me.tePengeluaranNoUMPB.TabIndex = 26
        Me.tePengeluaranNoUMPB.Tag = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 14)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nomor Dokumen"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePengeluaranNoDokumen
        '
        Me.tePengeluaranNoDokumen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePengeluaranNoDokumen.Location = New System.Drawing.Point(216, 29)
        Me.tePengeluaranNoDokumen.Margin = New System.Windows.Forms.Padding(0)
        Me.tePengeluaranNoDokumen.Name = "tePengeluaranNoDokumen"
        Me.tePengeluaranNoDokumen.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tePengeluaranNoDokumen.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePengeluaranNoDokumen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePengeluaranNoDokumen.Properties.Appearance.Options.UseBackColor = True
        Me.tePengeluaranNoDokumen.Properties.Appearance.Options.UseFont = True
        Me.tePengeluaranNoDokumen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePengeluaranNoDokumen.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tePengeluaranNoDokumen.Properties.MaxLength = 250
        Me.tePengeluaranNoDokumen.Properties.NullText = "[Belum Diisi]"
        Me.tePengeluaranNoDokumen.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePengeluaranNoDokumen.Size = New System.Drawing.Size(198, 20)
        Me.tePengeluaranNoDokumen.TabIndex = 47
        Me.tePengeluaranNoDokumen.Tag = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(467, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 14)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Jumlah Uang"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sePengeluaranUang
        '
        Me.sePengeluaranUang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.sePengeluaranUang.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePengeluaranUang.Location = New System.Drawing.Point(546, 29)
        Me.sePengeluaranUang.Margin = New System.Windows.Forms.Padding(0)
        Me.sePengeluaranUang.Name = "sePengeluaranUang"
        Me.sePengeluaranUang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.sePengeluaranUang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sePengeluaranUang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sePengeluaranUang.Properties.Appearance.Options.UseBackColor = True
        Me.sePengeluaranUang.Properties.Appearance.Options.UseFont = True
        Me.sePengeluaranUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.sePengeluaranUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.sePengeluaranUang.Properties.DisplayFormat.FormatString = "n2"
        Me.sePengeluaranUang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePengeluaranUang.Properties.EditFormat.FormatString = "n2"
        Me.sePengeluaranUang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePengeluaranUang.Properties.IsFloatValue = False
        Me.sePengeluaranUang.Properties.Mask.EditMask = "N00"
        Me.sePengeluaranUang.Properties.MaxLength = 11
        Me.sePengeluaranUang.Properties.MaxValue = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.sePengeluaranUang.Properties.ReadOnly = True
        Me.sePengeluaranUang.Size = New System.Drawing.Size(150, 20)
        Me.sePengeluaranUang.TabIndex = 48
        Me.sePengeluaranUang.Tag = ""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(95, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 14)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "No Pengajuan UMPB"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 2, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(782, 32)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnPengeluaranSearch)
        Me.Panel2.Controls.Add(Me.btnPengeluaranSave)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(304, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(392, 32)
        Me.Panel2.TabIndex = 13
        '
        'btnPengeluaranSearch
        '
        Me.btnPengeluaranSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPengeluaranSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPengeluaranSearch.FlatAppearance.BorderSize = 0
        Me.btnPengeluaranSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPengeluaranSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPengeluaranSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengeluaranSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengeluaranSearch.Location = New System.Drawing.Point(212, 0)
        Me.btnPengeluaranSearch.Name = "btnPengeluaranSearch"
        Me.btnPengeluaranSearch.Size = New System.Drawing.Size(60, 32)
        Me.btnPengeluaranSearch.TabIndex = 17
        Me.btnPengeluaranSearch.Text = "CARI"
        Me.btnPengeluaranSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPengeluaranSearch.UseVisualStyleBackColor = False
        '
        'btnPengeluaranSave
        '
        Me.btnPengeluaranSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPengeluaranSave.FlatAppearance.BorderSize = 0
        Me.btnPengeluaranSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPengeluaranSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPengeluaranSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengeluaranSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengeluaranSave.Location = New System.Drawing.Point(272, 0)
        Me.btnPengeluaranSave.Name = "btnPengeluaranSave"
        Me.btnPengeluaranSave.Size = New System.Drawing.Size(120, 32)
        Me.btnPengeluaranSave.TabIndex = 15
        Me.btnPengeluaranSave.Text = "SIMPAN DI TABEL"
        Me.btnPengeluaranSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPengeluaranSave.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 110)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(786, 30)
        Me.TableLayoutPanel5.TabIndex = 15
        Me.TableLayoutPanel5.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.Panel3.Controls.Add(Me.tabPenerimaan)
        Me.Panel3.Controls.Add(Me.tabPengeluaran)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(218, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 30)
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
        Me.tabPenerimaan.Location = New System.Drawing.Point(260, 0)
        Me.tabPenerimaan.Name = "tabPenerimaan"
        Me.tabPenerimaan.Size = New System.Drawing.Size(110, 30)
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
        Me.tabPengeluaran.Location = New System.Drawing.Point(370, 0)
        Me.tabPengeluaran.Name = "tabPengeluaran"
        Me.tabPengeluaran.Size = New System.Drawing.Size(110, 30)
        Me.tabPengeluaran.TabIndex = 15
        Me.tabPengeluaran.Text = "PENGELUARAN"
        Me.tabPengeluaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tabPengeluaran.UseVisualStyleBackColor = False
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
        Me.tlpField.Controls.Add(Me.lblJumlahUang, 1, 2)
        Me.tlpField.Controls.Add(Me.lblPengajuanNo, 1, 1)
        Me.tlpField.Controls.Add(Me.tearuspengajuanNo, 2, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 4, 1)
        Me.tlpField.Controls.Add(Me.lblTanggal, 3, 1)
        Me.tlpField.Controls.Add(Me.lueBank, 2, 2)
        Me.tlpField.Controls.Add(Me.Label2, 3, 3)
        Me.tlpField.Controls.Add(Me.seTotalPengeluaran, 4, 3)
        Me.tlpField.Controls.Add(Me.seTotalPenerimaan, 4, 2)
        Me.tlpField.Controls.Add(Me.Label1, 3, 2)
        Me.tlpField.Controls.Add(Me.Label10, 1, 3)
        Me.tlpField.Controls.Add(Me.lueJenis, 2, 3)
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
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(548, 6)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHeaderHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHighlight.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceWeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceWeekNumber.Options.UseFont = True
        Me.deTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggal.Size = New System.Drawing.Size(135, 20)
        Me.deTanggal.TabIndex = 31
        Me.deTanggal.Tag = "tanggalaruspengajuan"
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
        'lueBank
        '
        Me.lueBank.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBank.Location = New System.Drawing.Point(218, 30)
        Me.lueBank.Margin = New System.Windows.Forms.Padding(0)
        Me.lueBank.Name = "lueBank"
        Me.lueBank.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueBank.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueBank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueBank.Properties.Appearance.Options.UseBackColor = True
        Me.lueBank.Properties.Appearance.Options.UseFont = True
        Me.lueBank.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueBank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBank.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idbank", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bank", "Bank"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("remarks", "Remarks")})
        Me.lueBank.Properties.NullText = "[Isian belum dipilih]"
        Me.lueBank.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueBank.Size = New System.Drawing.Size(198, 20)
        Me.lueBank.TabIndex = 48
        Me.lueBank.Tag = "idbank"
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
        Me.seTotalPengeluaran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
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
        'seTotalPenerimaan
        '
        Me.seTotalPenerimaan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seTotalPenerimaan.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTotalPenerimaan.Location = New System.Drawing.Point(548, 30)
        Me.seTotalPenerimaan.Margin = New System.Windows.Forms.Padding(0)
        Me.seTotalPenerimaan.Name = "seTotalPenerimaan"
        Me.seTotalPenerimaan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seTotalPenerimaan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seTotalPenerimaan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seTotalPenerimaan.Properties.Appearance.Options.UseBackColor = True
        Me.seTotalPenerimaan.Properties.Appearance.Options.UseFont = True
        Me.seTotalPenerimaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seTotalPenerimaan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(434, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 14)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Jumlah Penerimaan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(129, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 14)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Jenis Transaksi"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueJenis
        '
        Me.lueJenis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenis.Location = New System.Drawing.Point(218, 54)
        Me.lueJenis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenis.Name = "lueJenis"
        Me.lueJenis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueJenis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenis.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenis.Properties.Appearance.Options.UseFont = True
        Me.lueJenis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Jenis Transaksi")})
        Me.lueJenis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJenis.Size = New System.Drawing.Size(198, 20)
        Me.lueJenis.TabIndex = 54
        Me.lueJenis.Tag = "idbank"
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
        Me.btnNew.Location = New System.Drawing.Point(646, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "BARU"
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
        'frmPPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 499)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPPP"
        Me.ShowInTaskbar = False
        Me.Text = "Pengajuan Penerimaan dan Pengeluaran Uang Bank"
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
        CType(Me.rimeNote2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPenerimaan2.ResumeLayout(False)
        Me.tlpPenerimaan2.PerformLayout()
        CType(Me.tePenerimaanKeperluan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPenerimaan1.ResumeLayout(False)
        Me.tlpPenerimaan1.PerformLayout()
        CType(Me.tePenerimaanNoDokumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePenerimaanUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPengeluaran.ResumeLayout(False)
        CType(Me.gcPengeluaranData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPengeluaranData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeNote1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPengeluaran2.ResumeLayout(False)
        Me.tlpPengeluaran2.PerformLayout()
        CType(Me.tePengeluaranKeperluan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPengeluaran1.ResumeLayout(False)
        Me.tlpPengeluaran1.PerformLayout()
        CType(Me.tePengeluaranTanggalUMPB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePengeluaranNoUMPB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePengeluaranNoDokumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePengeluaranUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.tearuspengajuanNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTotalPengeluaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTotalPenerimaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Public WithEvents tlpPenerimaan1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblJabatanAtasan As System.Windows.Forms.Label
    Friend WithEvents lblAtasan As System.Windows.Forms.Label
    Friend WithEvents tePenerimaanNoDokumen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueBank As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents xtcPenerimaanPengeluaran As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpPenerimaan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpPengeluaran As DevExpress.XtraTab.XtraTabPage
    Public WithEvents tlpPenerimaan2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblUntuk As System.Windows.Forms.Label
    Friend WithEvents sePenerimaanUang As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents seTotalPenerimaan As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seTotalPengeluaran As DevExpress.XtraEditors.SpinEdit
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btnPenerimaanBaru As System.Windows.Forms.Button
    Public WithEvents btnPenerimaanSave As System.Windows.Forms.Button
    Public WithEvents tlpPengeluaran2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents tlpPengeluaran1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tePengeluaranNoDokumen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sePengeluaranUang As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents btnPengeluaranSearch As System.Windows.Forms.Button
    Public WithEvents btnPengeluaranSave As System.Windows.Forms.Button
    Friend WithEvents tePengeluaranTanggalUMPB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tePengeluaranNoUMPB As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents teRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gctIDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctKDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckIDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueCOA As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gctIDUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gckIDUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lueJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rimeNote2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rimeNote1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents tePengeluaranKeperluan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tePenerimaanKeperluan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
