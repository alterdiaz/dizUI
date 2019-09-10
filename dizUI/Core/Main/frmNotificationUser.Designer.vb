<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotificationUser
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
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.pInBody = New System.Windows.Forms.Panel()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lueLevel = New DevExpress.XtraEditors.LookUpEdit()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueAktif = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.seQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.rimeRemarks = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNonAktif = New System.Windows.Forms.Button()
        Me.btnAktif = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        Me.pInBody.SuspendLayout()
        CType(Me.lueLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAktif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Maroon
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
        Me.tlpForm.Size = New System.Drawing.Size(704, 415)
        Me.tlpForm.TabIndex = 1
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(700, 30)
        Me.pTitle.TabIndex = 35
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Maroon
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(670, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Notifikasi Tingkat Pengguna"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(670, 0)
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
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(700, 383)
        Me.pBody.TabIndex = 7
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.Controls.Add(Me.pInBody, 1, 1)
        Me.tlpEntry.Controls.Add(Me.gcData, 1, 2)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 4
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(700, 353)
        Me.tlpEntry.TabIndex = 17
        '
        'pInBody
        '
        Me.pInBody.Controls.Add(Me.lblLevel)
        Me.pInBody.Controls.Add(Me.lueLevel)
        Me.pInBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pInBody.Location = New System.Drawing.Point(6, 6)
        Me.pInBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pInBody.Name = "pInBody"
        Me.pInBody.Size = New System.Drawing.Size(688, 24)
        Me.pInBody.TabIndex = 0
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(428, 5)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(107, 14)
        Me.lblLevel.TabIndex = 31
        Me.lblLevel.Text = "Tingkat Pengguna"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueLevel
        '
        Me.lueLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueLevel.Location = New System.Drawing.Point(538, 2)
        Me.lueLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.lueLevel.Name = "lueLevel"
        Me.lueLevel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueLevel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueLevel.Properties.Appearance.Options.UseBackColor = True
        Me.lueLevel.Properties.Appearance.Options.UseFont = True
        Me.lueLevel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLevel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userlevel", "User Level", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userdata", "User"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("assuper", "Super"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("iduserlevel", "id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueLevel.Properties.NullText = "[Isian belum dipilih]"
        Me.lueLevel.Size = New System.Drawing.Size(146, 20)
        Me.lueLevel.TabIndex = 30
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcData.Location = New System.Drawing.Point(6, 30)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Margin = New System.Windows.Forms.Padding(0)
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.seQty, Me.rimeRemarks, Me.lueAktif})
        Me.gcData.Size = New System.Drawing.Size(688, 317)
        Me.gcData.TabIndex = 9
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.Options.UseFont = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.Options.UseFont = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn1, Me.GridColumn2, Me.GridColumn6})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.FieldName = "iduserlevelnotification"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Kode"
        Me.GridColumn1.FieldName = "kode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Remarks"
        Me.GridColumn2.FieldName = "remarks"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Aktif"
        Me.GridColumn6.ColumnEdit = Me.lueAktif
        Me.GridColumn6.FieldName = "isaktif"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'lueAktif
        '
        Me.lueAktif.AutoHeight = False
        Me.lueAktif.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAktif.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueAktif.Name = "lueAktif"
        '
        'seQty
        '
        Me.seQty.AutoHeight = False
        Me.seQty.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.seQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seQty.DisplayFormat.FormatString = "n0"
        Me.seQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seQty.EditFormat.FormatString = "n0"
        Me.seQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seQty.IsFloatValue = False
        Me.seQty.Mask.EditMask = "N00"
        Me.seQty.Name = "seQty"
        '
        'rimeRemarks
        '
        Me.rimeRemarks.MaxLength = 200
        Me.rimeRemarks.Name = "rimeRemarks"
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnNonAktif)
        Me.pHeader.Controls.Add(Me.btnAktif)
        Me.pHeader.Controls.Add(Me.Label1)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(700, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnNonAktif
        '
        Me.btnNonAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNonAktif.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNonAktif.FlatAppearance.BorderSize = 0
        Me.btnNonAktif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNonAktif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNonAktif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNonAktif.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNonAktif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNonAktif.Location = New System.Drawing.Point(374, 0)
        Me.btnNonAktif.Name = "btnNonAktif"
        Me.btnNonAktif.Size = New System.Drawing.Size(130, 30)
        Me.btnNonAktif.TabIndex = 37
        Me.btnNonAktif.Text = "SEMUA NON-AKTIF"
        Me.btnNonAktif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNonAktif.UseVisualStyleBackColor = True
        '
        'btnAktif
        '
        Me.btnAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAktif.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAktif.FlatAppearance.BorderSize = 0
        Me.btnAktif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAktif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAktif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAktif.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAktif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAktif.Location = New System.Drawing.Point(504, 0)
        Me.btnAktif.Name = "btnAktif"
        Me.btnAktif.Size = New System.Drawing.Size(100, 30)
        Me.btnAktif.TabIndex = 35
        Me.btnAktif.Text = "SEMUA AKTIF"
        Me.btnAktif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAktif.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(604, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 30)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "|"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnSave.Location = New System.Drawing.Point(620, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmNotificationUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(704, 415)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNotificationUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notifikasi Tingkat Pengguna"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        Me.pInBody.ResumeLayout(False)
        Me.pInBody.PerformLayout()
        CType(Me.lueLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAktif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pInBody As System.Windows.Forms.Panel
    Friend WithEvents lueLevel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents rimeRemarks As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueAktif As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnNonAktif As Button
    Public WithEvents btnAktif As Button
    Public WithEvents Label1 As Label
End Class
