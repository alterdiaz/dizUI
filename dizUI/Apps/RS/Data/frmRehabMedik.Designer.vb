<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRehabMedik
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
        Me.xtcRehab = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpRehab = New DevExpress.XtraTab.XtraTabPage()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcisdeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teRehabMedik = New DevExpress.XtraEditors.TextEdit()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnBaruRehab = New System.Windows.Forms.Button()
        Me.btnSimpanRehab = New System.Windows.Forms.Button()
        Me.btnHapusRehab = New System.Windows.Forms.Button()
        Me.xtpRehabDT = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gcDetil = New DevExpress.XtraGrid.GridControl()
        Me.gvDetil = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcbptype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lueICD = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueRehab = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teDiagnosa = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lueType = New DevExpress.XtraEditors.LookUpEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBaruDetil = New System.Windows.Forms.Button()
        Me.btnSimpanDetil = New System.Windows.Forms.Button()
        Me.btnHapusDetil = New System.Windows.Forms.Button()
        Me.xtpRehabICD = New DevExpress.XtraTab.XtraTabPage()
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
        Me.lueRehabMedik2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSimpanICD = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teIRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teIDiagnosa = New DevExpress.XtraEditors.TextEdit()
        Me.lueIICD = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnBaruICD = New System.Windows.Forms.Button()
        Me.btnHapusICD = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        CType(Me.xtcRehab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcRehab.SuspendLayout()
        Me.xtpRehab.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.teRehabMedik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.xtpRehabDT.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gcDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.lueICD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRehab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDiagnosa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.xtpRehabICD.SuspendLayout()
        CType(Me.gcICD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvICD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riceCek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.lueRehabMedik2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIDiagnosa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIICD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.xtcRehab, 1, 1)
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
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
        'xtcRehab
        '
        Me.xtcRehab.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcRehab.Appearance.Options.UseBackColor = True
        Me.xtcRehab.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcRehab.AppearancePage.Header.Options.UseFont = True
        Me.xtcRehab.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcRehab.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcRehab.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcRehab.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcRehab.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcRehab.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcRehab.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcRehab.AppearancePage.PageClient.Options.UseFont = True
        Me.xtcRehab.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcRehab.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcRehab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcRehab.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcRehab.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtcRehab.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcRehab.Location = New System.Drawing.Point(2, 30)
        Me.xtcRehab.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcRehab.Name = "xtcRehab"
        Me.xtcRehab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtcRehab.SelectedTabPage = Me.xtpRehab
        Me.xtcRehab.Size = New System.Drawing.Size(786, 378)
        Me.xtcRehab.TabIndex = 19
        Me.xtcRehab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpRehab, Me.xtpRehabDT, Me.xtpRehabICD})
        '
        'xtpRehab
        '
        Me.xtpRehab.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpRehab.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpRehab.Controls.Add(Me.pBody)
        Me.xtpRehab.Name = "xtpRehab"
        Me.xtpRehab.Size = New System.Drawing.Size(729, 372)
        Me.xtpRehab.Text = "REHAB"
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.OliveDrab
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(0, 0)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(729, 372)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 66)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(729, 306)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcisdeleted, Me.gcType, Me.gcStatData})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcID.AppearanceCell.Options.UseBackColor = True
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idrehabmedik"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcisdeleted
        '
        Me.gcisdeleted.Caption = "isdeleted"
        Me.gcisdeleted.FieldName = "isdeleted"
        Me.gcisdeleted.Name = "gcisdeleted"
        Me.gcisdeleted.OptionsColumn.AllowEdit = False
        Me.gcisdeleted.OptionsColumn.ReadOnly = True
        '
        'gcType
        '
        Me.gcType.AppearanceHeader.Options.UseTextOptions = True
        Me.gcType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcType.Caption = "Rehab Medik"
        Me.gcType.FieldName = "rehabmedik"
        Me.gcType.Name = "gcType"
        Me.gcType.OptionsColumn.AllowEdit = False
        Me.gcType.OptionsColumn.ReadOnly = True
        Me.gcType.Visible = True
        Me.gcType.VisibleIndex = 0
        '
        'gcStatData
        '
        Me.gcStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcStatData.Caption = "Status Data"
        Me.gcStatData.FieldName = "statdata"
        Me.gcStatData.Name = "gcStatData"
        Me.gcStatData.OptionsColumn.AllowEdit = False
        Me.gcStatData.OptionsColumn.ReadOnly = True
        Me.gcStatData.Visible = True
        Me.gcStatData.VisibleIndex = 1
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
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.teRehabMedik, 2, 1)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 3
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(729, 36)
        Me.tlpField.TabIndex = 7
        '
        'teRehabMedik
        '
        Me.teRehabMedik.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRehabMedik.Location = New System.Drawing.Point(189, 8)
        Me.teRehabMedik.Margin = New System.Windows.Forms.Padding(0)
        Me.teRehabMedik.Name = "teRehabMedik"
        Me.teRehabMedik.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRehabMedik.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRehabMedik.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRehabMedik.Properties.Appearance.Options.UseBackColor = True
        Me.teRehabMedik.Properties.Appearance.Options.UseFont = True
        Me.teRehabMedik.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRehabMedik.Properties.MaxLength = 300
        Me.teRehabMedik.Properties.NullText = "[Belum Diisi]"
        Me.teRehabMedik.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRehabMedik.Size = New System.Drawing.Size(197, 20)
        Me.teRehabMedik.TabIndex = 17
        Me.teRehabMedik.Tag = "diagnosa"
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(110, 11)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(76, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Rehab Medik"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnBaruRehab)
        Me.pHeader.Controls.Add(Me.btnSimpanRehab)
        Me.pHeader.Controls.Add(Me.btnHapusRehab)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(729, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnBaruRehab
        '
        Me.btnBaruRehab.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBaruRehab.FlatAppearance.BorderSize = 0
        Me.btnBaruRehab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBaruRehab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnBaruRehab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaruRehab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaruRehab.Location = New System.Drawing.Point(509, 0)
        Me.btnBaruRehab.Name = "btnBaruRehab"
        Me.btnBaruRehab.Size = New System.Drawing.Size(60, 30)
        Me.btnBaruRehab.TabIndex = 17
        Me.btnBaruRehab.Text = "BARU"
        Me.btnBaruRehab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaruRehab.UseVisualStyleBackColor = True
        '
        'btnSimpanRehab
        '
        Me.btnSimpanRehab.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSimpanRehab.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSimpanRehab.FlatAppearance.BorderSize = 0
        Me.btnSimpanRehab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSimpanRehab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSimpanRehab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanRehab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanRehab.Location = New System.Drawing.Point(569, 0)
        Me.btnSimpanRehab.Name = "btnSimpanRehab"
        Me.btnSimpanRehab.Size = New System.Drawing.Size(80, 30)
        Me.btnSimpanRehab.TabIndex = 15
        Me.btnSimpanRehab.Text = "SIMPAN"
        Me.btnSimpanRehab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSimpanRehab.UseVisualStyleBackColor = False
        '
        'btnHapusRehab
        '
        Me.btnHapusRehab.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHapusRehab.FlatAppearance.BorderSize = 0
        Me.btnHapusRehab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnHapusRehab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnHapusRehab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusRehab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusRehab.Location = New System.Drawing.Point(649, 0)
        Me.btnHapusRehab.Name = "btnHapusRehab"
        Me.btnHapusRehab.Size = New System.Drawing.Size(80, 30)
        Me.btnHapusRehab.TabIndex = 11
        Me.btnHapusRehab.Text = "HAPUS"
        Me.btnHapusRehab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHapusRehab.UseVisualStyleBackColor = True
        '
        'xtpRehabDT
        '
        Me.xtpRehabDT.Controls.Add(Me.Panel1)
        Me.xtpRehabDT.Name = "xtpRehabDT"
        Me.xtpRehabDT.Size = New System.Drawing.Size(729, 372)
        Me.xtpRehabDT.Text = "DETIL"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel1.Controls.Add(Me.gcDetil)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 372)
        Me.Panel1.TabIndex = 8
        '
        'gcDetil
        '
        Me.gcDetil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDetil.Location = New System.Drawing.Point(0, 126)
        Me.gcDetil.MainView = Me.gvDetil
        Me.gcDetil.Name = "gcDetil"
        Me.gcDetil.Size = New System.Drawing.Size(729, 246)
        Me.gcDetil.TabIndex = 10
        Me.gcDetil.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetil})
        '
        'gvDetil
        '
        Me.gvDetil.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvDetil.Appearance.Empty.Options.UseBackColor = True
        Me.gvDetil.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvDetil.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvDetil.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvDetil.Appearance.Row.Options.UseFont = True
        Me.gvDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn6, Me.gcbptype, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.gvDetil.GridControl = Me.gcDetil
        Me.gvDetil.Name = "gvDetil"
        Me.gvDetil.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetil.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetil.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "idrehabmedikdt"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "IDrehab"
        Me.GridColumn6.FieldName = "idicd"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'gcbptype
        '
        Me.gcbptype.Caption = "rehabmediktype"
        Me.gcbptype.FieldName = "rehabmediktype"
        Me.gcbptype.Name = "gcbptype"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "isdeleted"
        Me.GridColumn2.FieldName = "isdeleted"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Jenis"
        Me.GridColumn3.FieldName = "jenis"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Kode"
        Me.GridColumn4.FieldName = "kode"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Diagnosa"
        Me.GridColumn10.FieldName = "diagnosa"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Remarks"
        Me.GridColumn11.FieldName = "remarks"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Status Data"
        Me.GridColumn12.FieldName = "statdata"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lueICD, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lueRehab, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.teRemarks, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParent, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.teDiagnosa, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lueType, 4, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(729, 96)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(151, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 14)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Kode"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueICD
        '
        Me.lueICD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueICD.Location = New System.Drawing.Point(189, 44)
        Me.lueICD.Margin = New System.Windows.Forms.Padding(0)
        Me.lueICD.Name = "lueICD"
        Me.lueICD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueICD.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueICD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueICD.Properties.Appearance.Options.UseBackColor = True
        Me.lueICD.Properties.Appearance.Options.UseFont = True
        Me.lueICD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueICD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueICD.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueICD.Properties.NullText = "[Isian belum dipilih]"
        Me.lueICD.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueICD.Size = New System.Drawing.Size(150, 20)
        Me.lueICD.TabIndex = 49
        Me.lueICD.Tag = "idicd"
        '
        'lueRehab
        '
        Me.lueRehab.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueRehab.Location = New System.Drawing.Point(189, 8)
        Me.lueRehab.Margin = New System.Windows.Forms.Padding(0)
        Me.lueRehab.Name = "lueRehab"
        Me.lueRehab.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueRehab.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueRehab.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueRehab.Properties.Appearance.Options.UseBackColor = True
        Me.lueRehab.Properties.Appearance.Options.UseFont = True
        Me.lueRehab.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueRehab.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRehab.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueRehab.Properties.NullText = "[Isian belum dipilih]"
        Me.lueRehab.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueRehab.Size = New System.Drawing.Size(197, 20)
        Me.lueRehab.TabIndex = 49
        Me.lueRehab.Tag = "idrehabmedik"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(454, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Remarks"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teRemarks
        '
        Me.teRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRemarks.Location = New System.Drawing.Point(509, 68)
        Me.teRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teRemarks.Name = "teRemarks"
        Me.teRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teRemarks.Properties.Appearance.Options.UseFont = True
        Me.teRemarks.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teRemarks.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRemarks.Properties.MaxLength = 300
        Me.teRemarks.Properties.NullText = "[Belum Diisi]"
        Me.teRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRemarks.Properties.ReadOnly = True
        Me.teRemarks.Size = New System.Drawing.Size(150, 20)
        Me.teRemarks.TabIndex = 18
        Me.teRemarks.Tag = "remarks"
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(110, 11)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(76, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Rehab Medik"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(131, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Diagnosa"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teDiagnosa
        '
        Me.teDiagnosa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teDiagnosa.Location = New System.Drawing.Point(189, 68)
        Me.teDiagnosa.Margin = New System.Windows.Forms.Padding(0)
        Me.teDiagnosa.Name = "teDiagnosa"
        Me.teDiagnosa.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teDiagnosa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDiagnosa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDiagnosa.Properties.Appearance.Options.UseBackColor = True
        Me.teDiagnosa.Properties.Appearance.Options.UseFont = True
        Me.teDiagnosa.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDiagnosa.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teDiagnosa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDiagnosa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teDiagnosa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teDiagnosa.Properties.MaxLength = 300
        Me.teDiagnosa.Properties.NullText = "[Belum Diisi]"
        Me.teDiagnosa.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teDiagnosa.Properties.ReadOnly = True
        Me.teDiagnosa.Size = New System.Drawing.Size(197, 20)
        Me.teDiagnosa.TabIndex = 17
        Me.teDiagnosa.Tag = "diagnosa"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(473, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Jenis"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueType
        '
        Me.lueType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueType.Location = New System.Drawing.Point(509, 44)
        Me.lueType.Margin = New System.Windows.Forms.Padding(0)
        Me.lueType.Name = "lueType"
        Me.lueType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueType.Properties.Appearance.Options.UseBackColor = True
        Me.lueType.Properties.Appearance.Options.UseFont = True
        Me.lueType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueType.Properties.NullText = "[Isian belum dipilih]"
        Me.lueType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueType.Size = New System.Drawing.Size(150, 20)
        Me.lueType.TabIndex = 48
        Me.lueType.Tag = "rehabmediktype"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnBaruDetil)
        Me.Panel2.Controls.Add(Me.btnSimpanDetil)
        Me.Panel2.Controls.Add(Me.btnHapusDetil)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 30)
        Me.Panel2.TabIndex = 4
        '
        'btnBaruDetil
        '
        Me.btnBaruDetil.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBaruDetil.FlatAppearance.BorderSize = 0
        Me.btnBaruDetil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBaruDetil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnBaruDetil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaruDetil.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaruDetil.Location = New System.Drawing.Point(509, 0)
        Me.btnBaruDetil.Name = "btnBaruDetil"
        Me.btnBaruDetil.Size = New System.Drawing.Size(60, 30)
        Me.btnBaruDetil.TabIndex = 17
        Me.btnBaruDetil.Text = "BARU"
        Me.btnBaruDetil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaruDetil.UseVisualStyleBackColor = True
        '
        'btnSimpanDetil
        '
        Me.btnSimpanDetil.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSimpanDetil.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSimpanDetil.FlatAppearance.BorderSize = 0
        Me.btnSimpanDetil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSimpanDetil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSimpanDetil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanDetil.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanDetil.Location = New System.Drawing.Point(569, 0)
        Me.btnSimpanDetil.Name = "btnSimpanDetil"
        Me.btnSimpanDetil.Size = New System.Drawing.Size(80, 30)
        Me.btnSimpanDetil.TabIndex = 15
        Me.btnSimpanDetil.Text = "SIMPAN"
        Me.btnSimpanDetil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSimpanDetil.UseVisualStyleBackColor = False
        '
        'btnHapusDetil
        '
        Me.btnHapusDetil.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHapusDetil.FlatAppearance.BorderSize = 0
        Me.btnHapusDetil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnHapusDetil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnHapusDetil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusDetil.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusDetil.Location = New System.Drawing.Point(649, 0)
        Me.btnHapusDetil.Name = "btnHapusDetil"
        Me.btnHapusDetil.Size = New System.Drawing.Size(80, 30)
        Me.btnHapusDetil.TabIndex = 11
        Me.btnHapusDetil.Text = "HAPUS"
        Me.btnHapusDetil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHapusDetil.UseVisualStyleBackColor = True
        '
        'xtpRehabICD
        '
        Me.xtpRehabICD.Controls.Add(Me.gcICD)
        Me.xtpRehabICD.Controls.Add(Me.TableLayoutPanel3)
        Me.xtpRehabICD.Controls.Add(Me.Panel3)
        Me.xtpRehabICD.Name = "xtpRehabICD"
        Me.xtpRehabICD.Size = New System.Drawing.Size(729, 372)
        Me.xtpRehabICD.Text = "ICD"
        '
        'gcICD
        '
        Me.gcICD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcICD.Location = New System.Drawing.Point(0, 126)
        Me.gcICD.MainView = Me.gvICD
        Me.gcICD.Margin = New System.Windows.Forms.Padding(0)
        Me.gcICD.Name = "gcICD"
        Me.gcICD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.riceCek})
        Me.gcICD.Size = New System.Drawing.Size(729, 246)
        Me.gcICD.TabIndex = 8
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
        Me.TableLayoutPanel3.Controls.Add(Me.teIRemarks, 4, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 3, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.teIDiagnosa, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lueIICD, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lueRehabMedik2, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 1, 4)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(729, 96)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'lueRehabMedik2
        '
        Me.lueRehabMedik2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueRehabMedik2.Location = New System.Drawing.Point(189, 8)
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
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(110, 11)
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
        Me.Panel3.Size = New System.Drawing.Size(729, 30)
        Me.Panel3.TabIndex = 8
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
        Me.btnSimpanICD.Location = New System.Drawing.Point(569, 0)
        Me.btnSimpanICD.Name = "btnSimpanICD"
        Me.btnSimpanICD.Size = New System.Drawing.Size(80, 30)
        Me.btnSimpanICD.TabIndex = 15
        Me.btnSimpanICD.Text = "SIMPAN"
        Me.btnSimpanICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSimpanICD.UseVisualStyleBackColor = False
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
        Me.lblTitle.Text = "Rehab Medik"
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
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(454, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 14)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Remarks"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teIRemarks
        '
        Me.teIRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teIRemarks.Location = New System.Drawing.Point(509, 68)
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
        Me.teIRemarks.TabIndex = 58
        Me.teIRemarks.Tag = "remarks"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 14)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Kode"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Diagnosa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teIDiagnosa
        '
        Me.teIDiagnosa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teIDiagnosa.Location = New System.Drawing.Point(189, 68)
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
        Me.teIDiagnosa.TabIndex = 57
        Me.teIDiagnosa.Tag = "diagnosa"
        '
        'lueIICD
        '
        Me.lueIICD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueIICD.Location = New System.Drawing.Point(189, 44)
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
        Me.lueIICD.TabIndex = 60
        Me.lueIICD.Tag = "idicd"
        '
        'btnBaruICD
        '
        Me.btnBaruICD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBaruICD.FlatAppearance.BorderSize = 0
        Me.btnBaruICD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBaruICD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnBaruICD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaruICD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaruICD.Location = New System.Drawing.Point(509, 0)
        Me.btnBaruICD.Name = "btnBaruICD"
        Me.btnBaruICD.Size = New System.Drawing.Size(60, 30)
        Me.btnBaruICD.TabIndex = 19
        Me.btnBaruICD.Text = "BARU"
        Me.btnBaruICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaruICD.UseVisualStyleBackColor = True
        '
        'btnHapusICD
        '
        Me.btnHapusICD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHapusICD.FlatAppearance.BorderSize = 0
        Me.btnHapusICD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnHapusICD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnHapusICD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusICD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusICD.Location = New System.Drawing.Point(649, 0)
        Me.btnHapusICD.Name = "btnHapusICD"
        Me.btnHapusICD.Size = New System.Drawing.Size(80, 30)
        Me.btnHapusICD.TabIndex = 18
        Me.btnHapusICD.Text = "HAPUS"
        Me.btnHapusICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHapusICD.UseVisualStyleBackColor = True
        '
        'frmRehabMedik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRehabMedik"
        Me.ShowInTaskbar = False
        Me.Text = "Rehab Medik"
        Me.tlpForm.ResumeLayout(False)
        CType(Me.xtcRehab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcRehab.ResumeLayout(False)
        Me.xtpRehab.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teRehabMedik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.xtpRehabDT.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gcDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.lueICD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRehab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDiagnosa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.xtpRehabICD.ResumeLayout(False)
        Me.xtpRehabICD.PerformLayout()
        CType(Me.gcICD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvICD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riceCek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.lueRehabMedik2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIDiagnosa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIICD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnBaruRehab As System.Windows.Forms.Button
    Public WithEvents btnSimpanRehab As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents teRehabMedik As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnHapusRehab As System.Windows.Forms.Button
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcisdeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents gcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtcRehab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpRehab As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpRehabDT As DevExpress.XtraTab.XtraTabPage
    Public WithEvents Panel1 As Panel
    Public WithEvents Panel2 As Panel
    Public WithEvents btnBaruDetil As Button
    Public WithEvents btnSimpanDetil As Button
    Public WithEvents btnHapusDetil As Button
    Friend WithEvents xtpRehabICD As DevExpress.XtraTab.XtraTabPage
    Public WithEvents gcICD As DevExpress.XtraGrid.GridControl
    Public WithEvents gvICD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Panel3 As Panel
    Public WithEvents btnSimpanICD As Button
    Public WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lueRehab As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents teRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents lblParent As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents teDiagnosa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents lueICD As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents gcDetil As DevExpress.XtraGrid.GridControl
    Public WithEvents gvDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcbptype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lueRehabMedik2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label10 As Label
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riceCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teIRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents teIDiagnosa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents lueIICD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As Label
    Public WithEvents btnBaruICD As Button
    Public WithEvents btnHapusICD As Button
End Class
