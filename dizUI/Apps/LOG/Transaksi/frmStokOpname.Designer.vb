<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStokOpname
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
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riseQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lueDept = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueUnit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueCOAView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teTglTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.teNoTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dePeriode = New DevExpress.XtraEditors.DateEdit()
        Me.lblPeriode = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnImportFormat = New System.Windows.Forms.Button()
        Me.btnExportFormat = New System.Windows.Forms.Button()
        Me.rimeAddress = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.lblSep5 = New System.Windows.Forms.Label()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.lueDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTglTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dePeriode.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dePeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.rimeAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gcData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcData.Location = New System.Drawing.Point(0, 114)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rimeNote, Me.riseQty})
        Me.gcData.Size = New System.Drawing.Size(786, 286)
        Me.gcData.TabIndex = 13
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn23, Me.GridColumn2, Me.GridColumn3, Me.GridColumn24, Me.GridColumn5, Me.GridColumn6})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.NewItemRowText = "Tambah Data Disini"
        Me.gvData.OptionsDetail.ShowDetailTabs = False
        Me.gvData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.RowAutoHeight = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.OptionsView.ShowViewCaption = True
        Me.gvData.ViewCaption = "Stok Opname"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No."
        Me.GridColumn1.FieldName = "nomor"
        Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.Caption = "ID"
        Me.GridColumn23.FieldName = "iditem"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Item Grup"
        Me.GridColumn2.FieldName = "itemgrup"
        Me.GridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 97
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Kode"
        Me.GridColumn3.FieldName = "kode"
        Me.GridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 95
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn24.Caption = "Item"
        Me.GridColumn24.FieldName = "item"
        Me.GridColumn24.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 3
        Me.GridColumn24.Width = 96
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Qty"
        Me.GridColumn5.ColumnEdit = Me.riseQty
        Me.GridColumn5.DisplayFormat.FormatString = "n0"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "qty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 105
        '
        'riseQty
        '
        Me.riseQty.AutoHeight = False
        Me.riseQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riseQty.DisplayFormat.FormatString = "n0"
        Me.riseQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riseQty.EditFormat.FormatString = "n0"
        Me.riseQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riseQty.Name = "riseQty"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Qty Input"
        Me.GridColumn6.ColumnEdit = Me.riseQty
        Me.GridColumn6.DisplayFormat.FormatString = "n0"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "qtyinput"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 92
        '
        'rimeNote
        '
        Me.rimeNote.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeNote.Name = "rimeNote"
        Me.rimeNote.ReadOnly = True
        Me.rimeNote.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Olive
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
        Me.lblTitle.Text = "Stok Opname"
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
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.tlpField.Controls.Add(Me.lueDept, 4, 3)
        Me.tlpField.Controls.Add(Me.lueUnit, 2, 3)
        Me.tlpField.Controls.Add(Me.Label5, 3, 1)
        Me.tlpField.Controls.Add(Me.Label4, 1, 1)
        Me.tlpField.Controls.Add(Me.teTglTransaksi, 4, 1)
        Me.tlpField.Controls.Add(Me.teNoTransaksi, 2, 1)
        Me.tlpField.Controls.Add(Me.Label1, 1, 3)
        Me.tlpField.Controls.Add(Me.Label3, 3, 3)
        Me.tlpField.Controls.Add(Me.dePeriode, 2, 2)
        Me.tlpField.Controls.Add(Me.lblPeriode, 1, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 5
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 84)
        Me.tlpField.TabIndex = 7
        '
        'lueDept
        '
        Me.lueDept.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueDept.Location = New System.Drawing.Point(513, 56)
        Me.lueDept.Margin = New System.Windows.Forms.Padding(0)
        Me.lueDept.Name = "lueDept"
        Me.lueDept.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDept.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueDept.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueDept.Properties.Appearance.Options.UseBackColor = True
        Me.lueDept.Properties.Appearance.Options.UseFont = True
        Me.lueDept.Properties.Appearance.Options.UseForeColor = True
        Me.lueDept.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueDept.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDept.Properties.NullText = "[Isian belum dipilih]"
        Me.lueDept.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueDept.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.lueDept.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.lueDept.Properties.PopupView = Me.GridView9
        Me.lueDept.Properties.ShowFooter = False
        Me.lueDept.Properties.ShowPopupShadow = False
        Me.lueDept.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.lueDept.Size = New System.Drawing.Size(150, 20)
        Me.lueDept.TabIndex = 29
        '
        'GridView9
        '
        Me.GridView9.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView9.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView9.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn38, Me.GridColumn39})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView9.OptionsView.EnableAppearanceOddRow = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "ID"
        Me.GridColumn38.FieldName = "id"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.OptionsColumn.AllowEdit = False
        Me.GridColumn38.OptionsColumn.ReadOnly = True
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "Content"
        Me.GridColumn39.FieldName = "content"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.OptionsColumn.AllowEdit = False
        Me.GridColumn39.OptionsColumn.ReadOnly = True
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 0
        '
        'lueUnit
        '
        Me.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUnit.Location = New System.Drawing.Point(193, 56)
        Me.lueUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUnit.Name = "lueUnit"
        Me.lueUnit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUnit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueUnit.Properties.Appearance.Options.UseBackColor = True
        Me.lueUnit.Properties.Appearance.Options.UseFont = True
        Me.lueUnit.Properties.Appearance.Options.UseForeColor = True
        Me.lueUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnit.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUnit.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueUnit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.lueUnit.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.lueUnit.Properties.PopupView = Me.slueCOAView
        Me.lueUnit.Properties.ShowFooter = False
        Me.lueUnit.Properties.ShowPopupShadow = False
        Me.lueUnit.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.lueUnit.Size = New System.Drawing.Size(150, 20)
        Me.lueUnit.TabIndex = 29
        '
        'slueCOAView
        '
        Me.slueCOAView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueCOAView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueCOAView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueCOAView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueCOAView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn7})
        Me.slueCOAView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.slueCOAView.Name = "slueCOAView"
        Me.slueCOAView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.slueCOAView.OptionsView.EnableAppearanceEvenRow = True
        Me.slueCOAView.OptionsView.EnableAppearanceOddRow = True
        Me.slueCOAView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ID"
        Me.GridColumn4.FieldName = "id"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Content"
        Me.GridColumn7.FieldName = "content"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tgl.Transaksi"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 14)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "No. Transaksi"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teTglTransaksi
        '
        Me.teTglTransaksi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTglTransaksi.Enabled = False
        Me.teTglTransaksi.Location = New System.Drawing.Point(513, 8)
        Me.teTglTransaksi.Margin = New System.Windows.Forms.Padding(0)
        Me.teTglTransaksi.Name = "teTglTransaksi"
        Me.teTglTransaksi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teTglTransaksi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTglTransaksi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTglTransaksi.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teTglTransaksi.Properties.Appearance.Options.UseBackColor = True
        Me.teTglTransaksi.Properties.Appearance.Options.UseFont = True
        Me.teTglTransaksi.Properties.Appearance.Options.UseForeColor = True
        Me.teTglTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTglTransaksi.Properties.MaxLength = 300
        Me.teTglTransaksi.Properties.NullText = "[Belum Diisi]"
        Me.teTglTransaksi.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teTglTransaksi.Properties.ReadOnly = True
        Me.teTglTransaksi.Size = New System.Drawing.Size(190, 20)
        Me.teTglTransaksi.TabIndex = 20
        Me.teTglTransaksi.Tag = "kode"
        '
        'teNoTransaksi
        '
        Me.teNoTransaksi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoTransaksi.Enabled = False
        Me.teNoTransaksi.Location = New System.Drawing.Point(193, 8)
        Me.teNoTransaksi.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoTransaksi.Name = "teNoTransaksi"
        Me.teNoTransaksi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoTransaksi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoTransaksi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoTransaksi.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNoTransaksi.Properties.Appearance.Options.UseBackColor = True
        Me.teNoTransaksi.Properties.Appearance.Options.UseFont = True
        Me.teNoTransaksi.Properties.Appearance.Options.UseForeColor = True
        Me.teNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoTransaksi.Properties.MaxLength = 300
        Me.teNoTransaksi.Properties.NullText = "[Belum Diisi]"
        Me.teNoTransaksi.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoTransaksi.Properties.ReadOnly = True
        Me.teNoTransaksi.Size = New System.Drawing.Size(190, 20)
        Me.teNoTransaksi.TabIndex = 20
        Me.teNoTransaksi.Tag = "kode"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Unit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(437, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Department"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dePeriode
        '
        Me.dePeriode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dePeriode.EditValue = Nothing
        Me.dePeriode.Location = New System.Drawing.Point(193, 32)
        Me.dePeriode.Margin = New System.Windows.Forms.Padding(0)
        Me.dePeriode.Name = "dePeriode"
        Me.dePeriode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dePeriode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.Appearance.Options.UseBackColor = True
        Me.dePeriode.Properties.Appearance.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceDisabled.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceFocused.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.dePeriode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.dePeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dePeriode.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[False]
        Me.dePeriode.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dePeriode.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.dePeriode.Properties.DisplayFormat.FormatString = "yyyy-MM"
        Me.dePeriode.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dePeriode.Properties.EditFormat.FormatString = "yyyy-MM"
        Me.dePeriode.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dePeriode.Properties.Mask.EditMask = "yyyy-MM"
        Me.dePeriode.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dePeriode.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        Me.dePeriode.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
        Me.dePeriode.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.dePeriode.Size = New System.Drawing.Size(104, 20)
        Me.dePeriode.TabIndex = 32
        '
        'lblPeriode
        '
        Me.lblPeriode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPeriode.AutoSize = True
        Me.lblPeriode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriode.Location = New System.Drawing.Point(109, 35)
        Me.lblPeriode.Name = "lblPeriode"
        Me.lblPeriode.Size = New System.Drawing.Size(81, 14)
        Me.lblPeriode.TabIndex = 22
        Me.lblPeriode.Text = "Periode Bulan"
        Me.lblPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnSearch)
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Controls.Add(Me.btnDelete)
        Me.pHeader.Controls.Add(Me.btnImportFormat)
        Me.pHeader.Controls.Add(Me.btnExportFormat)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(506, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 30)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "CARI"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(566, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 27
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(626, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(706, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "VOID"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnImportFormat
        '
        Me.btnImportFormat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnImportFormat.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImportFormat.FlatAppearance.BorderSize = 0
        Me.btnImportFormat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnImportFormat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnImportFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportFormat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportFormat.Location = New System.Drawing.Point(120, 0)
        Me.btnImportFormat.Name = "btnImportFormat"
        Me.btnImportFormat.Size = New System.Drawing.Size(120, 30)
        Me.btnImportFormat.TabIndex = 24
        Me.btnImportFormat.Text = "IMPORT DATA"
        Me.btnImportFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportFormat.UseMnemonic = False
        Me.btnImportFormat.UseVisualStyleBackColor = False
        '
        'btnExportFormat
        '
        Me.btnExportFormat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExportFormat.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExportFormat.FlatAppearance.BorderSize = 0
        Me.btnExportFormat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnExportFormat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnExportFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportFormat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportFormat.Location = New System.Drawing.Point(0, 0)
        Me.btnExportFormat.Name = "btnExportFormat"
        Me.btnExportFormat.Size = New System.Drawing.Size(120, 30)
        Me.btnExportFormat.TabIndex = 23
        Me.btnExportFormat.Text = "EXPORT FORMAT"
        Me.btnExportFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportFormat.UseMnemonic = False
        Me.btnExportFormat.UseVisualStyleBackColor = False
        '
        'rimeAddress
        '
        Me.rimeAddress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeAddress.Name = "rimeAddress"
        Me.rimeAddress.ReadOnly = True
        Me.rimeAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
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
        'frmStokOpname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 430)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStokOpname"
        Me.ShowInTaskbar = False
        Me.Text = "Stok Opname"
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.lueDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTglTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dePeriode.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dePeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.rimeAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblPeriode As System.Windows.Forms.Label
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rimeAddress As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rimeNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dePeriode As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents riseQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents teNoTransaksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents teTglTransaksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Public WithEvents btnImportFormat As Button
    Public WithEvents btnExportFormat As Button
    Public WithEvents btnNew As Button
    Public WithEvents btnSave As Button
    Public WithEvents btnDelete As Button
    Public WithEvents btnSearch As Button
    Friend WithEvents lueUnit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueCOAView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueDept As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
End Class
