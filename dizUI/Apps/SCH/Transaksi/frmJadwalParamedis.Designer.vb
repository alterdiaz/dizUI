<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJadwalParamedis
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
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn136 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn99 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn100 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn130 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpJadwal2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClearPengganti = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.teParamedis = New DevExpress.XtraEditors.TextEdit()
        Me.teSesi = New DevExpress.XtraEditors.TextEdit()
        Me.teJadwalAsal = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.teSpesialis = New DevExpress.XtraEditors.TextEdit()
        Me.teJamMulai = New DevExpress.XtraEditors.TimeEdit()
        Me.teJamSelesai = New DevExpress.XtraEditors.TimeEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.luePengganti = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tlpJadwal1 = New System.Windows.Forms.TableLayoutPanel()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpJadwal2.SuspendLayout()
        CType(Me.teParamedis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJadwalAsal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSpesialis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJamMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJamSelesai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePengganti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpJadwal1.SuspendLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
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
        Me.lblTitle.Text = "Jadwal Dokter Harian"
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
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpJadwal2)
        Me.pBody.Controls.Add(Me.tlpJadwal1)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 378)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcData.Location = New System.Drawing.Point(0, 174)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Margin = New System.Windows.Forms.Padding(0)
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(786, 204)
        Me.gcData.TabIndex = 131
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn44, Me.GridColumn136, Me.GridColumn47, Me.GridColumn48, Me.GridColumn6, Me.GridColumn5, Me.GridColumn4, Me.GridColumn3, Me.GridColumn7, Me.GridColumn2, Me.GridColumn99, Me.GridColumn100, Me.GridColumn130})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.RowAutoHeight = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.OptionsView.ShowViewCaption = True
        Me.gvData.ViewCaption = "Jadwal Dokter"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "idjadwalparamedis"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn44
        '
        Me.GridColumn44.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn44.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn44.Caption = "ID"
        Me.GridColumn44.FieldName = "idparamedis"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.OptionsColumn.AllowEdit = False
        Me.GridColumn44.OptionsColumn.ReadOnly = True
        '
        'GridColumn136
        '
        Me.GridColumn136.Caption = "ID ParamedisSpesialis"
        Me.GridColumn136.FieldName = "idparamedispengganti"
        Me.GridColumn136.Name = "GridColumn136"
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "jammulai"
        Me.GridColumn47.FieldName = "jammulai"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.OptionsColumn.AllowEdit = False
        Me.GridColumn47.OptionsColumn.ReadOnly = True
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "jamselesai"
        Me.GridColumn48.FieldName = "jamselesai"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.OptionsColumn.AllowEdit = False
        Me.GridColumn48.OptionsColumn.ReadOnly = True
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "jammulaipengganti"
        Me.GridColumn6.FieldName = "jammulaipengganti"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "jamselesaipengganti"
        Me.GridColumn5.FieldName = "jamselesaipengganti"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Paramedis"
        Me.GridColumn4.FieldName = "paramedis"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Spesialis"
        Me.GridColumn3.FieldName = "spesialis"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "idjadwalsesi"
        Me.GridColumn7.FieldName = "idjadwalsesi"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Sesi"
        Me.GridColumn2.FieldName = "jadwalsesi"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn99
        '
        Me.GridColumn99.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn99.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn99.Caption = "Jadwal Asal"
        Me.GridColumn99.FieldName = "jadwalasal"
        Me.GridColumn99.Name = "GridColumn99"
        Me.GridColumn99.OptionsColumn.AllowEdit = False
        Me.GridColumn99.OptionsColumn.ReadOnly = True
        Me.GridColumn99.Visible = True
        Me.GridColumn99.VisibleIndex = 3
        Me.GridColumn99.Width = 67
        '
        'GridColumn100
        '
        Me.GridColumn100.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn100.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn100.Caption = "Pengganti"
        Me.GridColumn100.FieldName = "paramedispengganti"
        Me.GridColumn100.Name = "GridColumn100"
        Me.GridColumn100.OptionsColumn.AllowEdit = False
        Me.GridColumn100.OptionsColumn.ReadOnly = True
        Me.GridColumn100.Visible = True
        Me.GridColumn100.VisibleIndex = 4
        '
        'GridColumn130
        '
        Me.GridColumn130.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn130.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn130.Caption = "Jadwal Pengganti"
        Me.GridColumn130.FieldName = "jadwalpengganti"
        Me.GridColumn130.Name = "GridColumn130"
        Me.GridColumn130.OptionsColumn.AllowEdit = False
        Me.GridColumn130.OptionsColumn.ReadOnly = True
        Me.GridColumn130.Visible = True
        Me.GridColumn130.VisibleIndex = 5
        Me.GridColumn130.Width = 127
        '
        'tlpJadwal2
        '
        Me.tlpJadwal2.AutoSize = True
        Me.tlpJadwal2.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpJadwal2.ColumnCount = 6
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal2.Controls.Add(Me.btnClearPengganti, 3, 3)
        Me.tlpJadwal2.Controls.Add(Me.Label3, 3, 1)
        Me.tlpJadwal2.Controls.Add(Me.teParamedis, 2, 0)
        Me.tlpJadwal2.Controls.Add(Me.teSesi, 2, 1)
        Me.tlpJadwal2.Controls.Add(Me.teJadwalAsal, 4, 1)
        Me.tlpJadwal2.Controls.Add(Me.Label1, 1, 0)
        Me.tlpJadwal2.Controls.Add(Me.Label15, 1, 1)
        Me.tlpJadwal2.Controls.Add(Me.teSpesialis, 4, 0)
        Me.tlpJadwal2.Controls.Add(Me.teJamMulai, 2, 4)
        Me.tlpJadwal2.Controls.Add(Me.teJamSelesai, 4, 4)
        Me.tlpJadwal2.Controls.Add(Me.Label4, 3, 4)
        Me.tlpJadwal2.Controls.Add(Me.Label18, 3, 0)
        Me.tlpJadwal2.Controls.Add(Me.Label10, 1, 4)
        Me.tlpJadwal2.Controls.Add(Me.luePengganti, 2, 3)
        Me.tlpJadwal2.Controls.Add(Me.Label2, 1, 3)
        Me.tlpJadwal2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpJadwal2.Location = New System.Drawing.Point(0, 66)
        Me.tlpJadwal2.Name = "tlpJadwal2"
        Me.tlpJadwal2.RowCount = 6
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal2.Size = New System.Drawing.Size(786, 108)
        Me.tlpJadwal2.TabIndex = 19
        '
        'btnClearPengganti
        '
        Me.btnClearPengganti.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClearPengganti.FlatAppearance.BorderSize = 0
        Me.btnClearPengganti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnClearPengganti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnClearPengganti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearPengganti.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPengganti.ForeColor = System.Drawing.Color.White
        Me.btnClearPengganti.Location = New System.Drawing.Point(397, 54)
        Me.btnClearPengganti.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnClearPengganti.Name = "btnClearPengganti"
        Me.btnClearPengganti.Size = New System.Drawing.Size(120, 24)
        Me.btnClearPengganti.TabIndex = 26
        Me.btnClearPengganti.Text = "CLEAR PENGGANTI"
        Me.btnClearPengganti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearPengganti.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(452, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Jadwal Asal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teParamedis
        '
        Me.teParamedis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teParamedis.Location = New System.Drawing.Point(243, 2)
        Me.teParamedis.Margin = New System.Windows.Forms.Padding(0)
        Me.teParamedis.Name = "teParamedis"
        Me.teParamedis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teParamedis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teParamedis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teParamedis.Properties.Appearance.Options.UseBackColor = True
        Me.teParamedis.Properties.Appearance.Options.UseFont = True
        Me.teParamedis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teParamedis.Properties.MaxLength = 300
        Me.teParamedis.Properties.NullText = "[Belum Diisi]"
        Me.teParamedis.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teParamedis.Size = New System.Drawing.Size(150, 20)
        Me.teParamedis.TabIndex = 116
        Me.teParamedis.Tag = "namapanggilan"
        '
        'teSesi
        '
        Me.teSesi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teSesi.Location = New System.Drawing.Point(243, 26)
        Me.teSesi.Margin = New System.Windows.Forms.Padding(0)
        Me.teSesi.Name = "teSesi"
        Me.teSesi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teSesi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSesi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSesi.Properties.Appearance.Options.UseBackColor = True
        Me.teSesi.Properties.Appearance.Options.UseFont = True
        Me.teSesi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teSesi.Properties.MaxLength = 300
        Me.teSesi.Properties.NullText = "[Belum Diisi]"
        Me.teSesi.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teSesi.Size = New System.Drawing.Size(150, 20)
        Me.teSesi.TabIndex = 116
        Me.teSesi.Tag = "namapanggilan"
        '
        'teJadwalAsal
        '
        Me.teJadwalAsal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJadwalAsal.Location = New System.Drawing.Point(523, 26)
        Me.teJadwalAsal.Margin = New System.Windows.Forms.Padding(0)
        Me.teJadwalAsal.Name = "teJadwalAsal"
        Me.teJadwalAsal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teJadwalAsal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJadwalAsal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJadwalAsal.Properties.Appearance.Options.UseBackColor = True
        Me.teJadwalAsal.Properties.Appearance.Options.UseFont = True
        Me.teJadwalAsal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJadwalAsal.Properties.MaxLength = 300
        Me.teJadwalAsal.Properties.NullText = "[Belum Diisi]"
        Me.teJadwalAsal.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teJadwalAsal.Size = New System.Drawing.Size(150, 20)
        Me.teJadwalAsal.TabIndex = 117
        Me.teJadwalAsal.Tag = "namapanggilan"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Paramedis"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(212, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 14)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Sesi"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teSpesialis
        '
        Me.teSpesialis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teSpesialis.Location = New System.Drawing.Point(523, 2)
        Me.teSpesialis.Margin = New System.Windows.Forms.Padding(0)
        Me.teSpesialis.Name = "teSpesialis"
        Me.teSpesialis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teSpesialis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSpesialis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSpesialis.Properties.Appearance.Options.UseBackColor = True
        Me.teSpesialis.Properties.Appearance.Options.UseFont = True
        Me.teSpesialis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teSpesialis.Properties.MaxLength = 300
        Me.teSpesialis.Properties.NullText = "[Belum Diisi]"
        Me.teSpesialis.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teSpesialis.Size = New System.Drawing.Size(150, 20)
        Me.teSpesialis.TabIndex = 116
        Me.teSpesialis.Tag = "namapanggilan"
        '
        'teJamMulai
        '
        Me.teJamMulai.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJamMulai.EditValue = New Date(2015, 8, 4, 0, 0, 0, 0)
        Me.teJamMulai.Location = New System.Drawing.Point(243, 80)
        Me.teJamMulai.Margin = New System.Windows.Forms.Padding(0)
        Me.teJamMulai.Name = "teJamMulai"
        Me.teJamMulai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJamMulai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJamMulai.Properties.Appearance.Options.UseBackColor = True
        Me.teJamMulai.Properties.Appearance.Options.UseFont = True
        Me.teJamMulai.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamMulai.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teJamMulai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamMulai.Properties.AppearanceFocused.Options.UseFont = True
        Me.teJamMulai.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamMulai.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teJamMulai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJamMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teJamMulai.Properties.DisplayFormat.FormatString = "HH:mm"
        Me.teJamMulai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.teJamMulai.Properties.EditFormat.FormatString = "HH:mm"
        Me.teJamMulai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.teJamMulai.Properties.Mask.EditMask = "HH:mm"
        Me.teJamMulai.Size = New System.Drawing.Size(60, 20)
        Me.teJamMulai.TabIndex = 119
        Me.teJamMulai.Tag = "jammulai"
        '
        'teJamSelesai
        '
        Me.teJamSelesai.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJamSelesai.EditValue = New Date(2015, 8, 4, 0, 0, 0, 0)
        Me.teJamSelesai.Location = New System.Drawing.Point(523, 80)
        Me.teJamSelesai.Margin = New System.Windows.Forms.Padding(0)
        Me.teJamSelesai.Name = "teJamSelesai"
        Me.teJamSelesai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJamSelesai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJamSelesai.Properties.Appearance.Options.UseBackColor = True
        Me.teJamSelesai.Properties.Appearance.Options.UseFont = True
        Me.teJamSelesai.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamSelesai.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teJamSelesai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamSelesai.Properties.AppearanceFocused.Options.UseFont = True
        Me.teJamSelesai.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamSelesai.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teJamSelesai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJamSelesai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teJamSelesai.Properties.DisplayFormat.FormatString = "HH:mm"
        Me.teJamSelesai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.teJamSelesai.Properties.EditFormat.FormatString = "HH:mm"
        Me.teJamSelesai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.teJamSelesai.Properties.Mask.EditMask = "HH:mm"
        Me.teJamSelesai.Size = New System.Drawing.Size(60, 20)
        Me.teJamSelesai.TabIndex = 120
        Me.teJamSelesai.Tag = "jamselesai"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 14)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Pengganti Selesai"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(470, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 14)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "Spesialis"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(148, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 14)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Pengganti Mulai"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'luePengganti
        '
        Me.luePengganti.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.luePengganti.Location = New System.Drawing.Point(243, 56)
        Me.luePengganti.Margin = New System.Windows.Forms.Padding(0)
        Me.luePengganti.Name = "luePengganti"
        Me.luePengganti.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.luePengganti.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePengganti.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.luePengganti.Properties.Appearance.Options.UseBackColor = True
        Me.luePengganti.Properties.Appearance.Options.UseFont = True
        Me.luePengganti.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.luePengganti.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePengganti.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.luePengganti.Properties.NullText = "[Isian belum dipilih]"
        Me.luePengganti.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.luePengganti.Size = New System.Drawing.Size(150, 20)
        Me.luePengganti.TabIndex = 115
        Me.luePengganti.Tag = "idjadwalsesi"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Pengganti"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpJadwal1
        '
        Me.tlpJadwal1.AutoSize = True
        Me.tlpJadwal1.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpJadwal1.ColumnCount = 6
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal1.Controls.Add(Me.deTanggal, 2, 1)
        Me.tlpJadwal1.Controls.Add(Me.Label5, 1, 1)
        Me.tlpJadwal1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpJadwal1.Location = New System.Drawing.Point(0, 30)
        Me.tlpJadwal1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpJadwal1.Name = "tlpJadwal1"
        Me.tlpJadwal1.RowCount = 3
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal1.Size = New System.Drawing.Size(786, 36)
        Me.tlpJadwal1.TabIndex = 129
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(243, 8)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.Appearance.Options.UseForeColor = True
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
        Me.deTanggal.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggal.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggal.Size = New System.Drawing.Size(110, 20)
        Me.deTanggal.TabIndex = 118
        Me.deTanggal.Tag = "tanggalmulai"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 14)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Tanggal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnExport.Location = New System.Drawing.Point(606, 0)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 30)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.green
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(706, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
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
        'frmJadwalParamedis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmJadwalParamedis"
        Me.ShowInTaskbar = False
        Me.Text = "Jadwal Dokter Harian"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpJadwal2.ResumeLayout(False)
        Me.tlpJadwal2.PerformLayout()
        CType(Me.teParamedis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJadwalAsal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSpesialis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJamMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJamSelesai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePengganti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpJadwal1.ResumeLayout(False)
        Me.tlpJadwal1.PerformLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents tlpJadwal1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents luePengganti As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents teJamSelesai As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents teJamMulai As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents btnExport As System.Windows.Forms.Button
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn136 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn99 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn130 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn100 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teSesi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSpesialis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teParamedis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teJadwalAsal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tlpJadwal2 As TableLayoutPanel
    Public WithEvents btnClearPengganti As Button
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
