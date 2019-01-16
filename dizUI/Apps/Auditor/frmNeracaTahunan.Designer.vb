<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNeracaTahunan
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
        Me.gcRekening = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJanuari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFebruari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMaret = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcApril = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMei = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJuni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJuli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAgustus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSeptember = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcOktober = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNovember = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDesember = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Size = New System.Drawing.Size(828, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Neraca Tahunan"
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
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.gcData.Location = New System.Drawing.Point(0, 66)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(918, 334)
        Me.gcData.TabIndex = 13
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcRekening, Me.gcRemarks, Me.gcJanuari, Me.gcFebruari, Me.gcMaret, Me.gcApril, Me.gcMei, Me.gcJuni, Me.gcJuli, Me.gcAgustus, Me.gcSeptember, Me.gcOktober, Me.gcNovember, Me.gcDesember, Me.gcTotal})
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
        Me.gcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcID.AppearanceCell.Options.UseBackColor = True
        Me.gcID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idcoa"
        Me.gcID.MinWidth = 100
        Me.gcID.Name = "gcID"
        Me.gcID.Width = 100
        '
        'gcRekening
        '
        Me.gcRekening.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRekening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRekening.Caption = "Rekening"
        Me.gcRekening.FieldName = "coa"
        Me.gcRekening.MinWidth = 10
        Me.gcRekening.Name = "gcRekening"
        Me.gcRekening.OptionsColumn.AllowEdit = False
        Me.gcRekening.OptionsColumn.ReadOnly = True
        Me.gcRekening.Visible = True
        Me.gcRekening.VisibleIndex = 0
        Me.gcRekening.Width = 200
        '
        'gcRemarks
        '
        Me.gcRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRemarks.Caption = "Keterangan"
        Me.gcRemarks.FieldName = "remarks"
        Me.gcRemarks.MinWidth = 10
        Me.gcRemarks.Name = "gcRemarks"
        Me.gcRemarks.OptionsColumn.AllowEdit = False
        Me.gcRemarks.OptionsColumn.ReadOnly = True
        Me.gcRemarks.Visible = True
        Me.gcRemarks.VisibleIndex = 1
        Me.gcRemarks.Width = 200
        '
        'gcJanuari
        '
        Me.gcJanuari.AppearanceCell.Options.UseTextOptions = True
        Me.gcJanuari.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcJanuari.AppearanceHeader.Options.UseTextOptions = True
        Me.gcJanuari.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcJanuari.Caption = "Januari"
        Me.gcJanuari.DisplayFormat.FormatString = "{0:n2}"
        Me.gcJanuari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcJanuari.FieldName = "januari"
        Me.gcJanuari.MinWidth = 10
        Me.gcJanuari.Name = "gcJanuari"
        Me.gcJanuari.OptionsColumn.AllowEdit = False
        Me.gcJanuari.OptionsColumn.ReadOnly = True
        Me.gcJanuari.Visible = True
        Me.gcJanuari.VisibleIndex = 2
        Me.gcJanuari.Width = 150
        '
        'gcFebruari
        '
        Me.gcFebruari.AppearanceCell.Options.UseTextOptions = True
        Me.gcFebruari.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcFebruari.AppearanceHeader.Options.UseTextOptions = True
        Me.gcFebruari.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcFebruari.Caption = "Februari"
        Me.gcFebruari.DisplayFormat.FormatString = "{0:n2}"
        Me.gcFebruari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcFebruari.FieldName = "februari"
        Me.gcFebruari.Name = "gcFebruari"
        Me.gcFebruari.OptionsColumn.AllowEdit = False
        Me.gcFebruari.OptionsColumn.ReadOnly = True
        Me.gcFebruari.Visible = True
        Me.gcFebruari.VisibleIndex = 3
        '
        'gcMaret
        '
        Me.gcMaret.AppearanceCell.Options.UseTextOptions = True
        Me.gcMaret.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcMaret.AppearanceHeader.Options.UseTextOptions = True
        Me.gcMaret.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcMaret.Caption = "Maret"
        Me.gcMaret.DisplayFormat.FormatString = "{0:n2}"
        Me.gcMaret.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcMaret.FieldName = "maret"
        Me.gcMaret.Name = "gcMaret"
        Me.gcMaret.OptionsColumn.AllowEdit = False
        Me.gcMaret.OptionsColumn.ReadOnly = True
        Me.gcMaret.Visible = True
        Me.gcMaret.VisibleIndex = 4
        '
        'gcApril
        '
        Me.gcApril.AppearanceCell.Options.UseTextOptions = True
        Me.gcApril.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcApril.AppearanceHeader.Options.UseTextOptions = True
        Me.gcApril.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcApril.Caption = "April"
        Me.gcApril.DisplayFormat.FormatString = "{0:n2}"
        Me.gcApril.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcApril.FieldName = "april"
        Me.gcApril.Name = "gcApril"
        Me.gcApril.OptionsColumn.AllowEdit = False
        Me.gcApril.OptionsColumn.ReadOnly = True
        Me.gcApril.Visible = True
        Me.gcApril.VisibleIndex = 5
        '
        'gcMei
        '
        Me.gcMei.AppearanceCell.Options.UseTextOptions = True
        Me.gcMei.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcMei.AppearanceHeader.Options.UseTextOptions = True
        Me.gcMei.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcMei.Caption = "Mei"
        Me.gcMei.DisplayFormat.FormatString = "{0:n2}"
        Me.gcMei.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcMei.FieldName = "mei"
        Me.gcMei.Name = "gcMei"
        Me.gcMei.OptionsColumn.AllowEdit = False
        Me.gcMei.OptionsColumn.ReadOnly = True
        Me.gcMei.Visible = True
        Me.gcMei.VisibleIndex = 6
        '
        'gcJuni
        '
        Me.gcJuni.AppearanceCell.Options.UseTextOptions = True
        Me.gcJuni.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcJuni.AppearanceHeader.Options.UseTextOptions = True
        Me.gcJuni.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcJuni.Caption = "Juni"
        Me.gcJuni.DisplayFormat.FormatString = "{0:n2}"
        Me.gcJuni.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcJuni.FieldName = "juni"
        Me.gcJuni.Name = "gcJuni"
        Me.gcJuni.OptionsColumn.AllowEdit = False
        Me.gcJuni.OptionsColumn.ReadOnly = True
        Me.gcJuni.Visible = True
        Me.gcJuni.VisibleIndex = 7
        '
        'gcJuli
        '
        Me.gcJuli.AppearanceCell.Options.UseTextOptions = True
        Me.gcJuli.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcJuli.AppearanceHeader.Options.UseTextOptions = True
        Me.gcJuli.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcJuli.Caption = "Juli"
        Me.gcJuli.DisplayFormat.FormatString = "{0:n2}"
        Me.gcJuli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcJuli.FieldName = "juli"
        Me.gcJuli.Name = "gcJuli"
        Me.gcJuli.OptionsColumn.AllowEdit = False
        Me.gcJuli.OptionsColumn.ReadOnly = True
        Me.gcJuli.Visible = True
        Me.gcJuli.VisibleIndex = 8
        '
        'gcAgustus
        '
        Me.gcAgustus.AppearanceCell.Options.UseTextOptions = True
        Me.gcAgustus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcAgustus.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAgustus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAgustus.Caption = "Agustus"
        Me.gcAgustus.DisplayFormat.FormatString = "{0:n2}"
        Me.gcAgustus.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcAgustus.FieldName = "agustus"
        Me.gcAgustus.Name = "gcAgustus"
        Me.gcAgustus.OptionsColumn.AllowEdit = False
        Me.gcAgustus.OptionsColumn.ReadOnly = True
        Me.gcAgustus.Visible = True
        Me.gcAgustus.VisibleIndex = 9
        '
        'gcSeptember
        '
        Me.gcSeptember.AppearanceCell.Options.UseTextOptions = True
        Me.gcSeptember.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcSeptember.AppearanceHeader.Options.UseTextOptions = True
        Me.gcSeptember.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcSeptember.Caption = "September"
        Me.gcSeptember.DisplayFormat.FormatString = "{0:n2}"
        Me.gcSeptember.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcSeptember.FieldName = "september"
        Me.gcSeptember.Name = "gcSeptember"
        Me.gcSeptember.OptionsColumn.AllowEdit = False
        Me.gcSeptember.OptionsColumn.ReadOnly = True
        Me.gcSeptember.Visible = True
        Me.gcSeptember.VisibleIndex = 10
        '
        'gcOktober
        '
        Me.gcOktober.AppearanceCell.Options.UseTextOptions = True
        Me.gcOktober.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcOktober.AppearanceHeader.Options.UseTextOptions = True
        Me.gcOktober.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcOktober.Caption = "Oktober"
        Me.gcOktober.DisplayFormat.FormatString = "{0:n2}"
        Me.gcOktober.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcOktober.FieldName = "oktober"
        Me.gcOktober.Name = "gcOktober"
        Me.gcOktober.OptionsColumn.AllowEdit = False
        Me.gcOktober.OptionsColumn.ReadOnly = True
        Me.gcOktober.Visible = True
        Me.gcOktober.VisibleIndex = 11
        '
        'gcNovember
        '
        Me.gcNovember.AppearanceCell.Options.UseTextOptions = True
        Me.gcNovember.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcNovember.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNovember.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNovember.Caption = "November"
        Me.gcNovember.DisplayFormat.FormatString = "{0:n2}"
        Me.gcNovember.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcNovember.FieldName = "november"
        Me.gcNovember.Name = "gcNovember"
        Me.gcNovember.OptionsColumn.AllowEdit = False
        Me.gcNovember.OptionsColumn.ReadOnly = True
        Me.gcNovember.Visible = True
        Me.gcNovember.VisibleIndex = 12
        '
        'gcDesember
        '
        Me.gcDesember.AppearanceCell.Options.UseTextOptions = True
        Me.gcDesember.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcDesember.AppearanceHeader.Options.UseTextOptions = True
        Me.gcDesember.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDesember.Caption = "Desember"
        Me.gcDesember.DisplayFormat.FormatString = "{0:n2}"
        Me.gcDesember.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcDesember.FieldName = "desember"
        Me.gcDesember.Name = "gcDesember"
        Me.gcDesember.OptionsColumn.AllowEdit = False
        Me.gcDesember.OptionsColumn.ReadOnly = True
        Me.gcDesember.Visible = True
        Me.gcDesember.VisibleIndex = 13
        '
        'gcTotal
        '
        Me.gcTotal.AppearanceCell.Options.UseTextOptions = True
        Me.gcTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.gcTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcTotal.Caption = "Total"
        Me.gcTotal.DisplayFormat.FormatString = "{0:n2}"
        Me.gcTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.gcTotal.FieldName = "total"
        Me.gcTotal.Name = "gcTotal"
        Me.gcTotal.OptionsColumn.AllowEdit = False
        Me.gcTotal.OptionsColumn.ReadOnly = True
        Me.gcTotal.Visible = True
        Me.gcTotal.VisibleIndex = 14
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.Label1, 1, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 2, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 3
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(918, 36)
        Me.tlpField.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tahun"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(284, 8)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseFont = True
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
        Me.btnExport.Location = New System.Drawing.Point(818, 0)
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
        'frmNeracaTahunan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(922, 430)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNeracaTahunan"
        Me.ShowInTaskbar = False
        Me.Text = "Neraca Tahunan"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Public WithEvents btnExport As System.Windows.Forms.Button
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRekening As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcJanuari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents gcFebruari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMaret As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcApril As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMei As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcJuni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcJuli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAgustus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSeptember As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcOktober As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNovember As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDesember As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTotal As DevExpress.XtraGrid.Columns.GridColumn
End Class
