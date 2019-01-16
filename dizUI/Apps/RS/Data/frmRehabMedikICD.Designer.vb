<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRehabMedikICD
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
        Me.gcICD = New DevExpress.XtraGrid.GridControl()
        Me.gvICD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riceCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teIRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lueRehabMedik2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.teIDiagnosa = New DevExpress.XtraEditors.TextEdit()
        Me.lueIICD = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBaruICD = New System.Windows.Forms.Button()
        Me.btnSimpanICD = New System.Windows.Forms.Button()
        Me.btnHapusICD = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcICD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvICD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riceCek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.teIRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRehabMedik2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIDiagnosa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIICD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpForm.Size = New System.Drawing.Size(790, 408)
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
        Me.lblTitle.Text = "Mapping ICF ICD"
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
        Me.pBody.Controls.Add(Me.gcICD)
        Me.pBody.Controls.Add(Me.TableLayoutPanel3)
        Me.pBody.Controls.Add(Me.Panel3)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 378)
        Me.pBody.TabIndex = 7
        '
        'gcICD
        '
        Me.gcICD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcICD.Location = New System.Drawing.Point(0, 126)
        Me.gcICD.MainView = Me.gvICD
        Me.gcICD.Margin = New System.Windows.Forms.Padding(0)
        Me.gcICD.Name = "gcICD"
        Me.gcICD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.riceCek})
        Me.gcICD.Size = New System.Drawing.Size(786, 252)
        Me.gcICD.TabIndex = 11
        Me.gcICD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvICD})
        '
        'gvICD
        '
        Me.gvICD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvICD.Appearance.Empty.Options.UseBackColor = True
        Me.gvICD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvICD.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvICD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvICD.Appearance.OddRow.Options.UseBackColor = True
        Me.gvICD.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvICD.Appearance.Row.Options.UseFont = True
        Me.gvICD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn7, Me.GridColumn5, Me.GridColumn13, Me.gcKode, Me.gcNama, Me.GridColumn9})
        Me.gvICD.GridControl = Me.gcICD
        Me.gvICD.Name = "gvICD"
        Me.gvICD.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.gvICD.OptionsFind.FindNullPrompt = "Input pencarian"
        Me.gvICD.OptionsFind.ShowCloseButton = False
        Me.gvICD.OptionsView.EnableAppearanceEvenRow = True
        Me.gvICD.OptionsView.EnableAppearanceOddRow = True
        Me.gvICD.OptionsView.RowAutoHeight = True
        Me.gvICD.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.Caption = "ID"
        Me.GridColumn8.FieldName = "idrehabmedikicd"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "IDRehab"
        Me.GridColumn7.FieldName = "idrehabmedik"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Cek"
        Me.GridColumn5.ColumnEdit = Me.riceCek
        Me.GridColumn5.FieldName = "cek"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 37
        '
        'riceCek
        '
        Me.riceCek.AutoHeight = False
        Me.riceCek.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style6
        Me.riceCek.Name = "riceCek"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "IDICD"
        Me.GridColumn13.FieldName = "idicd"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'gcKode
        '
        Me.gcKode.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKode.Caption = "Kode"
        Me.gcKode.FieldName = "kode"
        Me.gcKode.MaxWidth = 58
        Me.gcKode.MinWidth = 58
        Me.gcKode.Name = "gcKode"
        Me.gcKode.OptionsColumn.AllowEdit = False
        Me.gcKode.OptionsColumn.ReadOnly = True
        Me.gcKode.Visible = True
        Me.gcKode.VisibleIndex = 0
        Me.gcKode.Width = 58
        '
        'gcNama
        '
        Me.gcNama.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNama.Caption = "Diagnosa"
        Me.gcNama.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcNama.FieldName = "diagnosa"
        Me.gcNama.Name = "gcNama"
        Me.gcNama.OptionsColumn.AllowEdit = False
        Me.gcNama.OptionsColumn.ReadOnly = True
        Me.gcNama.Visible = True
        Me.gcNama.VisibleIndex = 1
        Me.gcNama.Width = 274
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ReadOnly = True
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Remarks"
        Me.GridColumn9.FieldName = "remarks"
        Me.GridColumn9.MinWidth = 50
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 342
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 3, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.teIRemarks, 4, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lueRehabMedik2, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.teIDiagnosa, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lueIICD, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 30)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(786, 96)
        Me.TableLayoutPanel3.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Remarks"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teIRemarks
        '
        Me.teIRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teIRemarks.Location = New System.Drawing.Point(538, 68)
        Me.teIRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teIRemarks.Name = "teIRemarks"
        Me.teIRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teIRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teIRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teIRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teIRemarks.Properties.Appearance.Options.UseFont = True
        Me.teIRemarks.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teIRemarks.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teIRemarks.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teIRemarks.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teIRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teIRemarks.Properties.MaxLength = 300
        Me.teIRemarks.Properties.NullText = "[Belum Diisi]"
        Me.teIRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teIRemarks.Properties.ReadOnly = True
        Me.teIRemarks.Size = New System.Drawing.Size(150, 20)
        Me.teIRemarks.TabIndex = 52
        Me.teIRemarks.Tag = "remarks"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(180, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 14)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Kode"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 14)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Diagnosa"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueRehabMedik2
        '
        Me.lueRehabMedik2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueRehabMedik2.Location = New System.Drawing.Point(218, 8)
        Me.lueRehabMedik2.Margin = New System.Windows.Forms.Padding(0)
        Me.lueRehabMedik2.Name = "lueRehabMedik2"
        Me.lueRehabMedik2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueRehabMedik2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueRehabMedik2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueRehabMedik2.Properties.Appearance.Options.UseBackColor = True
        Me.lueRehabMedik2.Properties.Appearance.Options.UseFont = True
        Me.lueRehabMedik2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueRehabMedik2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRehabMedik2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueRehabMedik2.Properties.NullText = "[Isian belum dipilih]"
        Me.lueRehabMedik2.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueRehabMedik2.Size = New System.Drawing.Size(197, 20)
        Me.lueRehabMedik2.TabIndex = 49
        Me.lueRehabMedik2.Tag = "idrehabmedik"
        '
        'teIDiagnosa
        '
        Me.teIDiagnosa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teIDiagnosa.Location = New System.Drawing.Point(218, 68)
        Me.teIDiagnosa.Margin = New System.Windows.Forms.Padding(0)
        Me.teIDiagnosa.Name = "teIDiagnosa"
        Me.teIDiagnosa.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teIDiagnosa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teIDiagnosa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teIDiagnosa.Properties.Appearance.Options.UseBackColor = True
        Me.teIDiagnosa.Properties.Appearance.Options.UseFont = True
        Me.teIDiagnosa.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teIDiagnosa.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teIDiagnosa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teIDiagnosa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teIDiagnosa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teIDiagnosa.Properties.MaxLength = 300
        Me.teIDiagnosa.Properties.NullText = "[Belum Diisi]"
        Me.teIDiagnosa.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teIDiagnosa.Properties.ReadOnly = True
        Me.teIDiagnosa.Size = New System.Drawing.Size(197, 20)
        Me.teIDiagnosa.TabIndex = 51
        Me.teIDiagnosa.Tag = "diagnosa"
        '
        'lueIICD
        '
        Me.lueIICD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueIICD.Location = New System.Drawing.Point(218, 44)
        Me.lueIICD.Margin = New System.Windows.Forms.Padding(0)
        Me.lueIICD.Name = "lueIICD"
        Me.lueIICD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueIICD.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueIICD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueIICD.Properties.Appearance.Options.UseBackColor = True
        Me.lueIICD.Properties.Appearance.Options.UseFont = True
        Me.lueIICD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueIICD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIICD.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueIICD.Properties.NullText = "[Isian belum dipilih]"
        Me.lueIICD.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueIICD.Size = New System.Drawing.Size(150, 20)
        Me.lueIICD.TabIndex = 54
        Me.lueIICD.Tag = "idicd"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(139, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Rehab Medik"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnBaruICD)
        Me.Panel3.Controls.Add(Me.btnSimpanICD)
        Me.Panel3.Controls.Add(Me.btnHapusICD)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(786, 30)
        Me.Panel3.TabIndex = 12
        '
        'btnBaruICD
        '
        Me.btnBaruICD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBaruICD.FlatAppearance.BorderSize = 0
        Me.btnBaruICD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBaruICD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnBaruICD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaruICD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaruICD.Location = New System.Drawing.Point(566, 0)
        Me.btnBaruICD.Name = "btnBaruICD"
        Me.btnBaruICD.Size = New System.Drawing.Size(60, 30)
        Me.btnBaruICD.TabIndex = 21
        Me.btnBaruICD.Text = "BARU"
        Me.btnBaruICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaruICD.UseVisualStyleBackColor = True
        '
        'btnSimpanICD
        '
        Me.btnSimpanICD.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSimpanICD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSimpanICD.FlatAppearance.BorderSize = 0
        Me.btnSimpanICD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSimpanICD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSimpanICD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanICD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanICD.Location = New System.Drawing.Point(626, 0)
        Me.btnSimpanICD.Name = "btnSimpanICD"
        Me.btnSimpanICD.Size = New System.Drawing.Size(80, 30)
        Me.btnSimpanICD.TabIndex = 15
        Me.btnSimpanICD.Text = "SIMPAN"
        Me.btnSimpanICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSimpanICD.UseVisualStyleBackColor = False
        '
        'btnHapusICD
        '
        Me.btnHapusICD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHapusICD.FlatAppearance.BorderSize = 0
        Me.btnHapusICD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnHapusICD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnHapusICD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusICD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusICD.Location = New System.Drawing.Point(706, 0)
        Me.btnHapusICD.Name = "btnHapusICD"
        Me.btnHapusICD.Size = New System.Drawing.Size(80, 30)
        Me.btnHapusICD.TabIndex = 20
        Me.btnHapusICD.Text = "HAPUS"
        Me.btnHapusICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHapusICD.UseVisualStyleBackColor = True
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
        'frmRehabMedikICD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRehabMedikICD"
        Me.ShowInTaskbar = False
        Me.Text = "Mapping ICF ICD"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcICD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvICD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riceCek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.teIRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRehabMedik2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIDiagnosa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIICD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents gcICD As DevExpress.XtraGrid.GridControl
    Public WithEvents gvICD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riceCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lueRehabMedik2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label10 As Label
    Public WithEvents Panel3 As Panel
    Public WithEvents btnSimpanICD As Button
    Friend WithEvents teIRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents teIDiagnosa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueIICD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As Label
    Public WithEvents btnBaruICD As Button
    Public WithEvents btnHapusICD As Button
End Class
