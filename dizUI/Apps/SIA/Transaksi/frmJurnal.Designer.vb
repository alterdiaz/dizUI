<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJurnal
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
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDReff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTBReff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDCOALama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDDK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKDCOALama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.slueCOA = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcRekening = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNoDokumen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gcDebet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIsdeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueDeleted = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gcUnique = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueCOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lueNoBukti = New DevExpress.XtraEditors.LookUpEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNoBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(922, 430)
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
        Me.pTitle.Size = New System.Drawing.Size(918, 30)
        Me.pTitle.TabIndex = 14
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
        Me.lblTitle.Size = New System.Drawing.Size(828, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Jurnal"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(828, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(858, 0)
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
        Me.pExit.Location = New System.Drawing.Point(888, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(918, 400)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gcData.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(0)
        Me.gcData.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None
        Me.gcData.Location = New System.Drawing.Point(0, 70)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueCOA, Me.lueDeleted, Me.RepositoryItemMemoEdit1, Me.slueCOA})
        Me.gcData.Size = New System.Drawing.Size(918, 330)
        Me.gcData.TabIndex = 13
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcTanggal, Me.gcIDReff, Me.gcTBReff, Me.gcIDCOALama, Me.gcIDDK, Me.gcKDCOALama, Me.gcKDCOA, Me.gcRekening, Me.gcNoDokumen, Me.gcRemarks, Me.gcDebet, Me.gcIsdeleted, Me.gcUnique, Me.gcKredit, Me.gcSys})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.NewItemRowText = "Tambah Data Disini"
        Me.gvData.OptionsPrint.AutoWidth = False
        Me.gvData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.RowAutoHeight = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.OptionsView.ShowViewCaption = True
        Me.gvData.ViewCaption = " "
        '
        'gcID
        '
        Me.gcID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idjurnal"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcTanggal
        '
        Me.gcTanggal.AppearanceHeader.Options.UseTextOptions = True
        Me.gcTanggal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcTanggal.Caption = "Tanggal"
        Me.gcTanggal.FieldName = "tanggaljurnal"
        Me.gcTanggal.MinWidth = 120
        Me.gcTanggal.Name = "gcTanggal"
        Me.gcTanggal.OptionsColumn.AllowEdit = False
        Me.gcTanggal.OptionsColumn.ReadOnly = True
        Me.gcTanggal.Visible = True
        Me.gcTanggal.VisibleIndex = 0
        Me.gcTanggal.Width = 120
        '
        'gcIDReff
        '
        Me.gcIDReff.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDReff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDReff.Caption = "IDReff"
        Me.gcIDReff.FieldName = "idreff"
        Me.gcIDReff.Name = "gcIDReff"
        Me.gcIDReff.OptionsColumn.AllowEdit = False
        Me.gcIDReff.OptionsColumn.ReadOnly = True
        '
        'gcTBReff
        '
        Me.gcTBReff.AppearanceHeader.Options.UseTextOptions = True
        Me.gcTBReff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcTBReff.Caption = "TBReff"
        Me.gcTBReff.FieldName = "tbreff"
        Me.gcTBReff.Name = "gcTBReff"
        Me.gcTBReff.OptionsColumn.AllowEdit = False
        Me.gcTBReff.OptionsColumn.ReadOnly = True
        '
        'gcIDCOALama
        '
        Me.gcIDCOALama.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDCOALama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDCOALama.Caption = "IDCOALama"
        Me.gcIDCOALama.FieldName = "idcoalama"
        Me.gcIDCOALama.Name = "gcIDCOALama"
        Me.gcIDCOALama.OptionsColumn.AllowEdit = False
        Me.gcIDCOALama.OptionsColumn.ReadOnly = True
        '
        'gcIDDK
        '
        Me.gcIDDK.Caption = "IDDK"
        Me.gcIDDK.FieldName = "posisidk"
        Me.gcIDDK.Name = "gcIDDK"
        '
        'gcKDCOALama
        '
        Me.gcKDCOALama.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKDCOALama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKDCOALama.Caption = "Kd Rek Lama"
        Me.gcKDCOALama.FieldName = "coalama"
        Me.gcKDCOALama.MinWidth = 100
        Me.gcKDCOALama.Name = "gcKDCOALama"
        Me.gcKDCOALama.OptionsColumn.AllowEdit = False
        Me.gcKDCOALama.OptionsColumn.ReadOnly = True
        Me.gcKDCOALama.Visible = True
        Me.gcKDCOALama.VisibleIndex = 1
        Me.gcKDCOALama.Width = 100
        '
        'gcKDCOA
        '
        Me.gcKDCOA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcKDCOA.AppearanceCell.Options.UseBackColor = True
        Me.gcKDCOA.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKDCOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKDCOA.Caption = "Kode Rekening"
        Me.gcKDCOA.ColumnEdit = Me.slueCOA
        Me.gcKDCOA.FieldName = "idcoa"
        Me.gcKDCOA.MinWidth = 100
        Me.gcKDCOA.Name = "gcKDCOA"
        Me.gcKDCOA.Visible = True
        Me.gcKDCOA.VisibleIndex = 2
        Me.gcKDCOA.Width = 100
        '
        'slueCOA
        '
        Me.slueCOA.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.slueCOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCOA.Name = "slueCOA"
        Me.slueCOA.NullText = "[Belum dipilih]"
        Me.slueCOA.NullValuePrompt = "[Belum dipilih]"
        Me.slueCOA.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.slueCOA.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.slueCOA.ShowFooter = False
        Me.slueCOA.View = Me.GridView1
        Me.slueCOA.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.FindNullPrompt = "Input teks untuk cari"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gcRekening
        '
        Me.gcRekening.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRekening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRekening.Caption = "Rekening"
        Me.gcRekening.FieldName = "rekening"
        Me.gcRekening.MinWidth = 200
        Me.gcRekening.Name = "gcRekening"
        Me.gcRekening.OptionsColumn.AllowEdit = False
        Me.gcRekening.OptionsColumn.ReadOnly = True
        Me.gcRekening.Visible = True
        Me.gcRekening.VisibleIndex = 3
        Me.gcRekening.Width = 200
        '
        'gcNoDokumen
        '
        Me.gcNoDokumen.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNoDokumen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNoDokumen.Caption = "No Dokumen"
        Me.gcNoDokumen.FieldName = "nodokumen"
        Me.gcNoDokumen.Name = "gcNoDokumen"
        Me.gcNoDokumen.OptionsColumn.AllowEdit = False
        Me.gcNoDokumen.OptionsColumn.ReadOnly = True
        Me.gcNoDokumen.Visible = True
        Me.gcNoDokumen.VisibleIndex = 4
        '
        'gcRemarks
        '
        Me.gcRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRemarks.Caption = "Keterangan"
        Me.gcRemarks.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcRemarks.FieldName = "remarks"
        Me.gcRemarks.MinWidth = 200
        Me.gcRemarks.Name = "gcRemarks"
        Me.gcRemarks.OptionsColumn.AllowEdit = False
        Me.gcRemarks.OptionsColumn.ReadOnly = True
        Me.gcRemarks.Visible = True
        Me.gcRemarks.VisibleIndex = 5
        Me.gcRemarks.Width = 200
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ReadOnly = True
        Me.RepositoryItemMemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'gcDebet
        '
        Me.gcDebet.AppearanceCell.Options.UseTextOptions = True
        Me.gcDebet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcDebet.AppearanceHeader.Options.UseTextOptions = True
        Me.gcDebet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDebet.Caption = "Debet"
        Me.gcDebet.DisplayFormat.FormatString = "{0:n2}"
        Me.gcDebet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcDebet.FieldName = "debet"
        Me.gcDebet.MinWidth = 150
        Me.gcDebet.Name = "gcDebet"
        Me.gcDebet.OptionsColumn.AllowEdit = False
        Me.gcDebet.OptionsColumn.ReadOnly = True
        Me.gcDebet.Visible = True
        Me.gcDebet.VisibleIndex = 6
        Me.gcDebet.Width = 150
        '
        'gcIsdeleted
        '
        Me.gcIsdeleted.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcIsdeleted.AppearanceCell.Options.UseBackColor = True
        Me.gcIsdeleted.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIsdeleted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIsdeleted.Caption = "Status"
        Me.gcIsdeleted.ColumnEdit = Me.lueDeleted
        Me.gcIsdeleted.FieldName = "isdeleted"
        Me.gcIsdeleted.MinWidth = 80
        Me.gcIsdeleted.Name = "gcIsdeleted"
        Me.gcIsdeleted.Visible = True
        Me.gcIsdeleted.VisibleIndex = 8
        Me.gcIsdeleted.Width = 80
        '
        'lueDeleted
        '
        Me.lueDeleted.AutoHeight = False
        Me.lueDeleted.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDeleted.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Status")})
        Me.lueDeleted.Name = "lueDeleted"
        Me.lueDeleted.NullText = "[Belum dipilih]"
        '
        'gcUnique
        '
        Me.gcUnique.Caption = "IDUnique"
        Me.gcUnique.FieldName = "idunique"
        Me.gcUnique.Name = "gcUnique"
        '
        'gcKredit
        '
        Me.gcKredit.AppearanceCell.Options.UseTextOptions = True
        Me.gcKredit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcKredit.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKredit.Caption = "Kredit"
        Me.gcKredit.DisplayFormat.FormatString = "{0:n2}"
        Me.gcKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcKredit.FieldName = "kredit"
        Me.gcKredit.MinWidth = 150
        Me.gcKredit.Name = "gcKredit"
        Me.gcKredit.OptionsColumn.AllowEdit = False
        Me.gcKredit.OptionsColumn.ReadOnly = True
        Me.gcKredit.Visible = True
        Me.gcKredit.VisibleIndex = 7
        Me.gcKredit.Width = 150
        '
        'gcSys
        '
        Me.gcSys.Caption = "System"
        Me.gcSys.FieldName = "issystem"
        Me.gcSys.Name = "gcSys"
        '
        'lueCOA
        '
        Me.lueCOA.AutoHeight = False
        Me.lueCOA.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueCOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCOA.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idcoa", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("coa", "Kode Rekening"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("remarks", "Remarks")})
        Me.lueCOA.Name = "lueCOA"
        Me.lueCOA.NullText = "[Belum dipilih]"
        Me.lueCOA.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
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
        Me.tlpField.Controls.Add(Me.Label1, 1, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 2, 1)
        Me.tlpField.Controls.Add(Me.Label2, 3, 1)
        Me.tlpField.Controls.Add(Me.lueNoBukti, 4, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 3
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(918, 40)
        Me.tlpField.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(284, 10)
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
        Me.deTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deTanggal.Size = New System.Drawing.Size(104, 20)
        Me.deTanggal.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(558, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "No Bukti"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueNoBukti
        '
        Me.lueNoBukti.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueNoBukti.Location = New System.Drawing.Point(614, 10)
        Me.lueNoBukti.Margin = New System.Windows.Forms.Padding(0)
        Me.lueNoBukti.Name = "lueNoBukti"
        Me.lueNoBukti.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueNoBukti.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueNoBukti.Properties.Appearance.Options.UseBackColor = True
        Me.lueNoBukti.Properties.Appearance.Options.UseFont = True
        Me.lueNoBukti.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueNoBukti.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNoBukti.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nobukti", "No Bukti")})
        Me.lueNoBukti.Properties.NullText = "[Isian belum dipilih]"
        Me.lueNoBukti.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueNoBukti.Size = New System.Drawing.Size(140, 20)
        Me.lueNoBukti.TabIndex = 59
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnExport)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(918, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnExport
        '
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(738, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 30)
        Me.btnExport.TabIndex = 15
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(838, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 16
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
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "idcoa"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "COA"
        Me.GridColumn2.FieldName = "coa"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Remarks"
        Me.GridColumn3.FieldName = "remarks"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'frmJurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(922, 430)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmJurnal"
        Me.ShowInTaskbar = False
        Me.Text = "Jurnal"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCOA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNoBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Public WithEvents btnExport As System.Windows.Forms.Button
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDReff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTBReff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDCOALama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKDCOALama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRekening As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDebet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueCOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gcIsdeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueDeleted As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gcIDDK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents gcUnique As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lueNoBukti As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcSys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents gcNoDokumen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents slueCOA As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
