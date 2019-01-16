<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonAnggaranRutin
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
        Me.bgvData = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcCOA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRemarks = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngjan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealjan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngfeb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealfeb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngmar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealmar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngapr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealapr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngmei = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealmei = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngjun = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealjun = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand12 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngjul = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealjul = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngaug = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealaug = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngsept = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealsept = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngokt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealokt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand11 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngnov = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealnov = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand13 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngdes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealdes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand14 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAngtot = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRealtot = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPengajuanNo = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(790, 430)
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
        Me.lblTitle.Text = "Monitoring Anggaran Rutin"
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
        Me.pBody.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 400)
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
        Me.gcData.MainView = Me.bgvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(786, 330)
        Me.gcData.TabIndex = 13
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bgvData})
        '
        'bgvData
        '
        Me.bgvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.bgvData.Appearance.Empty.Options.UseBackColor = True
        Me.bgvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bgvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.bgvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bgvData.Appearance.OddRow.Options.UseBackColor = True
        Me.bgvData.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bgvData.Appearance.TopNewRow.Options.UseBackColor = True
        Me.bgvData.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.gridBand3, Me.gridBand4, Me.gridBand5, Me.gridBand6, Me.gridBand7, Me.gridBand12, Me.gridBand8, Me.gridBand9, Me.gridBand10, Me.gridBand11, Me.gridBand13, Me.gridBand14})
        Me.bgvData.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.gcID, Me.gcCOA, Me.gcRemarks, Me.gcAngjan, Me.gcRealjan, Me.gcAngfeb, Me.gcRealfeb, Me.gcAngmar, Me.gcRealmar, Me.gcAngapr, Me.gcRealapr, Me.gcAngmei, Me.gcRealmei, Me.gcAngjun, Me.gcRealjun, Me.gcAngjul, Me.gcRealjul, Me.gcAngaug, Me.gcRealaug, Me.gcAngsept, Me.gcRealsept, Me.gcAngokt, Me.gcRealokt, Me.gcAngnov, Me.gcRealnov, Me.gcAngdes, Me.gcRealdes, Me.gcAngtot, Me.gcRealtot})
        Me.bgvData.GridControl = Me.gcData
        Me.bgvData.Name = "bgvData"
        Me.bgvData.NewItemRowText = "Tambah Data Disini"
        Me.bgvData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.bgvData.OptionsView.ColumnAutoWidth = False
        Me.bgvData.OptionsView.EnableAppearanceEvenRow = True
        Me.bgvData.OptionsView.EnableAppearanceOddRow = True
        Me.bgvData.OptionsView.ShowGroupPanel = False
        Me.bgvData.OptionsView.ShowViewCaption = True
        Me.bgvData.ViewCaption = " "
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "Rekening"
        Me.GridBand1.Columns.Add(Me.gcID)
        Me.GridBand1.Columns.Add(Me.gcCOA)
        Me.GridBand1.Columns.Add(Me.gcRemarks)
        Me.GridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridBand1.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 150
        '
        'gcID
        '
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idanggaran"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcCOA
        '
        Me.gcCOA.AppearanceHeader.Options.UseTextOptions = True
        Me.gcCOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcCOA.Caption = "Kode"
        Me.gcCOA.FieldName = "coa"
        Me.gcCOA.Name = "gcCOA"
        Me.gcCOA.OptionsColumn.AllowEdit = False
        Me.gcCOA.OptionsColumn.ReadOnly = True
        Me.gcCOA.Visible = True
        '
        'gcRemarks
        '
        Me.gcRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRemarks.Caption = "Remarks"
        Me.gcRemarks.FieldName = "remarks"
        Me.gcRemarks.Name = "gcRemarks"
        Me.gcRemarks.OptionsColumn.AllowEdit = False
        Me.gcRemarks.OptionsColumn.ReadOnly = True
        Me.gcRemarks.Visible = True
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Januari"
        Me.gridBand2.Columns.Add(Me.gcAngjan)
        Me.gridBand2.Columns.Add(Me.gcRealjan)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 1
        Me.gridBand2.Width = 150
        '
        'gcAngjan
        '
        Me.gcAngjan.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngjan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngjan.Caption = "Anggaran"
        Me.gcAngjan.DisplayFormat.FormatString = "n2"
        Me.gcAngjan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngjan.FieldName = "angjan"
        Me.gcAngjan.Name = "gcAngjan"
        Me.gcAngjan.OptionsColumn.AllowEdit = False
        Me.gcAngjan.OptionsColumn.ReadOnly = True
        Me.gcAngjan.Visible = True
        '
        'gcRealjan
        '
        Me.gcRealjan.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealjan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealjan.Caption = "Realisasi"
        Me.gcRealjan.DisplayFormat.FormatString = "n2"
        Me.gcRealjan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealjan.FieldName = "realjan"
        Me.gcRealjan.Name = "gcRealjan"
        Me.gcRealjan.OptionsColumn.AllowEdit = False
        Me.gcRealjan.OptionsColumn.ReadOnly = True
        Me.gcRealjan.Visible = True
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand3.Caption = "Februari"
        Me.gridBand3.Columns.Add(Me.gcAngfeb)
        Me.gridBand3.Columns.Add(Me.gcRealfeb)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 2
        Me.gridBand3.Width = 150
        '
        'gcAngfeb
        '
        Me.gcAngfeb.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngfeb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngfeb.Caption = "Anggaran"
        Me.gcAngfeb.DisplayFormat.FormatString = "n2"
        Me.gcAngfeb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngfeb.FieldName = "angfeb"
        Me.gcAngfeb.Name = "gcAngfeb"
        Me.gcAngfeb.OptionsColumn.AllowEdit = False
        Me.gcAngfeb.OptionsColumn.ReadOnly = True
        Me.gcAngfeb.Visible = True
        '
        'gcRealfeb
        '
        Me.gcRealfeb.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealfeb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealfeb.Caption = "Realisasi"
        Me.gcRealfeb.DisplayFormat.FormatString = "n2"
        Me.gcRealfeb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealfeb.FieldName = "realfeb"
        Me.gcRealfeb.Name = "gcRealfeb"
        Me.gcRealfeb.OptionsColumn.AllowEdit = False
        Me.gcRealfeb.OptionsColumn.ReadOnly = True
        Me.gcRealfeb.Visible = True
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand4.Caption = "Maret"
        Me.gridBand4.Columns.Add(Me.gcAngmar)
        Me.gridBand4.Columns.Add(Me.gcRealmar)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 3
        Me.gridBand4.Width = 150
        '
        'gcAngmar
        '
        Me.gcAngmar.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngmar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngmar.Caption = "Anggaran"
        Me.gcAngmar.DisplayFormat.FormatString = "n2"
        Me.gcAngmar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngmar.FieldName = "angmar"
        Me.gcAngmar.Name = "gcAngmar"
        Me.gcAngmar.OptionsColumn.AllowEdit = False
        Me.gcAngmar.OptionsColumn.ReadOnly = True
        Me.gcAngmar.Visible = True
        '
        'gcRealmar
        '
        Me.gcRealmar.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealmar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealmar.Caption = "Realisasi"
        Me.gcRealmar.DisplayFormat.FormatString = "n2"
        Me.gcRealmar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealmar.FieldName = "realmar"
        Me.gcRealmar.Name = "gcRealmar"
        Me.gcRealmar.OptionsColumn.AllowEdit = False
        Me.gcRealmar.OptionsColumn.ReadOnly = True
        Me.gcRealmar.Visible = True
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand5.Caption = "April"
        Me.gridBand5.Columns.Add(Me.gcAngapr)
        Me.gridBand5.Columns.Add(Me.gcRealapr)
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 4
        Me.gridBand5.Width = 150
        '
        'gcAngapr
        '
        Me.gcAngapr.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngapr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngapr.Caption = "Anggaran"
        Me.gcAngapr.DisplayFormat.FormatString = "n2"
        Me.gcAngapr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngapr.FieldName = "angapr"
        Me.gcAngapr.Name = "gcAngapr"
        Me.gcAngapr.OptionsColumn.AllowEdit = False
        Me.gcAngapr.OptionsColumn.ReadOnly = True
        Me.gcAngapr.Visible = True
        '
        'gcRealapr
        '
        Me.gcRealapr.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealapr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealapr.Caption = "Realisasi"
        Me.gcRealapr.DisplayFormat.FormatString = "n2"
        Me.gcRealapr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealapr.FieldName = "realapr"
        Me.gcRealapr.Name = "gcRealapr"
        Me.gcRealapr.OptionsColumn.AllowEdit = False
        Me.gcRealapr.OptionsColumn.ReadOnly = True
        Me.gcRealapr.Visible = True
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand6.Caption = "Mei"
        Me.gridBand6.Columns.Add(Me.gcAngmei)
        Me.gridBand6.Columns.Add(Me.gcRealmei)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 5
        Me.gridBand6.Width = 150
        '
        'gcAngmei
        '
        Me.gcAngmei.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngmei.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngmei.Caption = "Anggaran"
        Me.gcAngmei.DisplayFormat.FormatString = "n2"
        Me.gcAngmei.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngmei.FieldName = "angmei"
        Me.gcAngmei.Name = "gcAngmei"
        Me.gcAngmei.OptionsColumn.AllowEdit = False
        Me.gcAngmei.OptionsColumn.ReadOnly = True
        Me.gcAngmei.Visible = True
        '
        'gcRealmei
        '
        Me.gcRealmei.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealmei.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealmei.Caption = "Realisasi"
        Me.gcRealmei.DisplayFormat.FormatString = "n2"
        Me.gcRealmei.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealmei.FieldName = "realmei"
        Me.gcRealmei.Name = "gcRealmei"
        Me.gcRealmei.OptionsColumn.AllowEdit = False
        Me.gcRealmei.OptionsColumn.ReadOnly = True
        Me.gcRealmei.Visible = True
        '
        'gridBand7
        '
        Me.gridBand7.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand7.Caption = "Juni"
        Me.gridBand7.Columns.Add(Me.gcAngjun)
        Me.gridBand7.Columns.Add(Me.gcRealjun)
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.VisibleIndex = 6
        Me.gridBand7.Width = 150
        '
        'gcAngjun
        '
        Me.gcAngjun.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngjun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngjun.Caption = "Anggaran"
        Me.gcAngjun.DisplayFormat.FormatString = "n2"
        Me.gcAngjun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngjun.FieldName = "angjun"
        Me.gcAngjun.Name = "gcAngjun"
        Me.gcAngjun.OptionsColumn.AllowEdit = False
        Me.gcAngjun.OptionsColumn.ReadOnly = True
        Me.gcAngjun.Visible = True
        '
        'gcRealjun
        '
        Me.gcRealjun.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealjun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealjun.Caption = "Realisasi"
        Me.gcRealjun.DisplayFormat.FormatString = "n2"
        Me.gcRealjun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealjun.FieldName = "realjun"
        Me.gcRealjun.Name = "gcRealjun"
        Me.gcRealjun.OptionsColumn.AllowEdit = False
        Me.gcRealjun.OptionsColumn.ReadOnly = True
        Me.gcRealjun.Visible = True
        '
        'gridBand12
        '
        Me.gridBand12.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand12.Caption = "Juli"
        Me.gridBand12.Columns.Add(Me.gcAngjul)
        Me.gridBand12.Columns.Add(Me.gcRealjul)
        Me.gridBand12.Name = "gridBand12"
        Me.gridBand12.VisibleIndex = 7
        Me.gridBand12.Width = 150
        '
        'gcAngjul
        '
        Me.gcAngjul.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngjul.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngjul.Caption = "Anggaran"
        Me.gcAngjul.DisplayFormat.FormatString = "n2"
        Me.gcAngjul.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngjul.FieldName = "angjul"
        Me.gcAngjul.Name = "gcAngjul"
        Me.gcAngjul.OptionsColumn.AllowEdit = False
        Me.gcAngjul.OptionsColumn.ReadOnly = True
        Me.gcAngjul.Visible = True
        '
        'gcRealjul
        '
        Me.gcRealjul.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealjul.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealjul.Caption = "Realisasi"
        Me.gcRealjul.DisplayFormat.FormatString = "n2"
        Me.gcRealjul.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealjul.FieldName = "realjul"
        Me.gcRealjul.Name = "gcRealjul"
        Me.gcRealjul.OptionsColumn.AllowEdit = False
        Me.gcRealjul.OptionsColumn.ReadOnly = True
        Me.gcRealjul.Visible = True
        '
        'gridBand8
        '
        Me.gridBand8.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand8.Caption = "Agustus"
        Me.gridBand8.Columns.Add(Me.gcAngaug)
        Me.gridBand8.Columns.Add(Me.gcRealaug)
        Me.gridBand8.Name = "gridBand8"
        Me.gridBand8.VisibleIndex = 8
        Me.gridBand8.Width = 150
        '
        'gcAngaug
        '
        Me.gcAngaug.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngaug.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngaug.Caption = "Anggaran"
        Me.gcAngaug.DisplayFormat.FormatString = "n2"
        Me.gcAngaug.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngaug.FieldName = "angaug"
        Me.gcAngaug.Name = "gcAngaug"
        Me.gcAngaug.OptionsColumn.AllowEdit = False
        Me.gcAngaug.OptionsColumn.ReadOnly = True
        Me.gcAngaug.Visible = True
        '
        'gcRealaug
        '
        Me.gcRealaug.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealaug.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealaug.Caption = "Realisasi"
        Me.gcRealaug.DisplayFormat.FormatString = "n2"
        Me.gcRealaug.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealaug.FieldName = "realaug"
        Me.gcRealaug.Name = "gcRealaug"
        Me.gcRealaug.OptionsColumn.AllowEdit = False
        Me.gcRealaug.OptionsColumn.ReadOnly = True
        Me.gcRealaug.Visible = True
        '
        'gridBand9
        '
        Me.gridBand9.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand9.Caption = "September"
        Me.gridBand9.Columns.Add(Me.gcAngsept)
        Me.gridBand9.Columns.Add(Me.gcRealsept)
        Me.gridBand9.Name = "gridBand9"
        Me.gridBand9.VisibleIndex = 9
        Me.gridBand9.Width = 150
        '
        'gcAngsept
        '
        Me.gcAngsept.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngsept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngsept.Caption = "Anggaran"
        Me.gcAngsept.DisplayFormat.FormatString = "n2"
        Me.gcAngsept.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngsept.FieldName = "angsept"
        Me.gcAngsept.Name = "gcAngsept"
        Me.gcAngsept.OptionsColumn.AllowEdit = False
        Me.gcAngsept.OptionsColumn.ReadOnly = True
        Me.gcAngsept.Visible = True
        '
        'gcRealsept
        '
        Me.gcRealsept.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealsept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealsept.Caption = "Realisasi"
        Me.gcRealsept.DisplayFormat.FormatString = "n2"
        Me.gcRealsept.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealsept.FieldName = "realsept"
        Me.gcRealsept.Name = "gcRealsept"
        Me.gcRealsept.OptionsColumn.AllowEdit = False
        Me.gcRealsept.OptionsColumn.ReadOnly = True
        Me.gcRealsept.Visible = True
        '
        'gridBand10
        '
        Me.gridBand10.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand10.Caption = "Oktober"
        Me.gridBand10.Columns.Add(Me.gcAngokt)
        Me.gridBand10.Columns.Add(Me.gcRealokt)
        Me.gridBand10.Name = "gridBand10"
        Me.gridBand10.VisibleIndex = 10
        Me.gridBand10.Width = 150
        '
        'gcAngokt
        '
        Me.gcAngokt.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngokt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngokt.Caption = "Anggaran"
        Me.gcAngokt.DisplayFormat.FormatString = "n2"
        Me.gcAngokt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngokt.FieldName = "angokt"
        Me.gcAngokt.Name = "gcAngokt"
        Me.gcAngokt.OptionsColumn.AllowEdit = False
        Me.gcAngokt.OptionsColumn.ReadOnly = True
        Me.gcAngokt.Visible = True
        '
        'gcRealokt
        '
        Me.gcRealokt.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealokt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealokt.Caption = "Realisasi"
        Me.gcRealokt.DisplayFormat.FormatString = "n2"
        Me.gcRealokt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealokt.FieldName = "realokt"
        Me.gcRealokt.Name = "gcRealokt"
        Me.gcRealokt.OptionsColumn.AllowEdit = False
        Me.gcRealokt.OptionsColumn.ReadOnly = True
        Me.gcRealokt.Visible = True
        '
        'gridBand11
        '
        Me.gridBand11.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand11.Caption = "November"
        Me.gridBand11.Columns.Add(Me.gcAngnov)
        Me.gridBand11.Columns.Add(Me.gcRealnov)
        Me.gridBand11.Name = "gridBand11"
        Me.gridBand11.VisibleIndex = 11
        Me.gridBand11.Width = 150
        '
        'gcAngnov
        '
        Me.gcAngnov.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngnov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngnov.Caption = "Anggaran"
        Me.gcAngnov.DisplayFormat.FormatString = "n2"
        Me.gcAngnov.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngnov.FieldName = "angnov"
        Me.gcAngnov.Name = "gcAngnov"
        Me.gcAngnov.OptionsColumn.AllowEdit = False
        Me.gcAngnov.OptionsColumn.ReadOnly = True
        Me.gcAngnov.Visible = True
        '
        'gcRealnov
        '
        Me.gcRealnov.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealnov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealnov.Caption = "Realisasi"
        Me.gcRealnov.DisplayFormat.FormatString = "n2"
        Me.gcRealnov.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealnov.FieldName = "realnov"
        Me.gcRealnov.Name = "gcRealnov"
        Me.gcRealnov.OptionsColumn.AllowEdit = False
        Me.gcRealnov.OptionsColumn.ReadOnly = True
        Me.gcRealnov.Visible = True
        '
        'gridBand13
        '
        Me.gridBand13.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand13.Caption = "Desember"
        Me.gridBand13.Columns.Add(Me.gcAngdes)
        Me.gridBand13.Columns.Add(Me.gcRealdes)
        Me.gridBand13.Name = "gridBand13"
        Me.gridBand13.VisibleIndex = 12
        Me.gridBand13.Width = 150
        '
        'gcAngdes
        '
        Me.gcAngdes.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngdes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngdes.Caption = "Anggaran"
        Me.gcAngdes.DisplayFormat.FormatString = "n2"
        Me.gcAngdes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngdes.FieldName = "angdes"
        Me.gcAngdes.Name = "gcAngdes"
        Me.gcAngdes.OptionsColumn.AllowEdit = False
        Me.gcAngdes.OptionsColumn.ReadOnly = True
        Me.gcAngdes.Visible = True
        '
        'gcRealdes
        '
        Me.gcRealdes.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealdes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealdes.Caption = "Realisasi"
        Me.gcRealdes.DisplayFormat.FormatString = "n2"
        Me.gcRealdes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealdes.FieldName = "realdes"
        Me.gcRealdes.Name = "gcRealdes"
        Me.gcRealdes.OptionsColumn.AllowEdit = False
        Me.gcRealdes.OptionsColumn.ReadOnly = True
        Me.gcRealdes.Visible = True
        '
        'gridBand14
        '
        Me.gridBand14.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand14.Caption = "Total"
        Me.gridBand14.Columns.Add(Me.gcAngtot)
        Me.gridBand14.Columns.Add(Me.gcRealtot)
        Me.gridBand14.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gridBand14.Name = "gridBand14"
        Me.gridBand14.VisibleIndex = 13
        Me.gridBand14.Width = 150
        '
        'gcAngtot
        '
        Me.gcAngtot.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAngtot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAngtot.Caption = "Anggaran"
        Me.gcAngtot.DisplayFormat.FormatString = "n2"
        Me.gcAngtot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAngtot.FieldName = "angtot"
        Me.gcAngtot.Name = "gcAngtot"
        Me.gcAngtot.OptionsColumn.AllowEdit = False
        Me.gcAngtot.OptionsColumn.ReadOnly = True
        Me.gcAngtot.Visible = True
        '
        'gcRealtot
        '
        Me.gcRealtot.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRealtot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRealtot.Caption = "Realisasi"
        Me.gcRealtot.DisplayFormat.FormatString = "n2"
        Me.gcRealtot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcRealtot.FieldName = "realtot"
        Me.gcRealtot.Name = "gcRealtot"
        Me.gcRealtot.OptionsColumn.AllowEdit = False
        Me.gcRealtot.OptionsColumn.ReadOnly = True
        Me.gcRealtot.Visible = True
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
        Me.tlpField.Controls.Add(Me.lblPengajuanNo, 1, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 2, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 3
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 40)
        Me.tlpField.TabIndex = 7
        '
        'lblPengajuanNo
        '
        Me.lblPengajuanNo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPengajuanNo.AutoSize = True
        Me.lblPengajuanNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPengajuanNo.Location = New System.Drawing.Point(128, 13)
        Me.lblPengajuanNo.Name = "lblPengajuanNo"
        Me.lblPengajuanNo.Size = New System.Drawing.Size(87, 14)
        Me.lblPengajuanNo.TabIndex = 22
        Me.lblPengajuanNo.Text = "Tahun Periode"
        Me.lblPengajuanNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(218, 10)
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
        Me.deTanggal.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.deTanggal.Properties.DisplayFormat.FormatString = "yyyy"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "yyyy"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "yyyy"
        Me.deTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deTanggal.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearsGroupView
        Me.deTanggal.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView
        Me.deTanggal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggal.Size = New System.Drawing.Size(104, 20)
        Me.deTanggal.TabIndex = 31
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnExport)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
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
        Me.btnExport.Location = New System.Drawing.Point(686, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 30)
        Me.btnExport.TabIndex = 15
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
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
        'frmMonAnggaranRutin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 430)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMonAnggaranRutin"
        Me.ShowInTaskbar = False
        Me.Text = "Monitoring Anggaran Rutin"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblPengajuanNo As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Public WithEvents btnExport As System.Windows.Forms.Button
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents bgvData As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents gcID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcCOA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRemarks As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngjan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealjan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngfeb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealfeb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngmar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealmar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngapr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealapr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngmei As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealmei As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngjun As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealjun As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngjul As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealjul As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngaug As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealaug As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngsept As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealsept As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngokt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealokt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngnov As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealnov As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngdes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealdes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAngtot As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcRealtot As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand12 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand10 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand11 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand13 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand14 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
