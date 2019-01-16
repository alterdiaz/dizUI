<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLevel
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
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDuserdata = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDassuper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUserLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUserData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSuperUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.lueSuperUser = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueUserData = New DevExpress.XtraEditors.LookUpEdit()
        Me.teNama = New DevExpress.XtraEditors.TextEdit()
        Me.lblSuperUser = New System.Windows.Forms.Label()
        Me.lblUserData = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpTop.SuspendLayout()
        CType(Me.lueSuperUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUserData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.tlpForm.Size = New System.Drawing.Size(442, 522)
        Me.tlpForm.TabIndex = 8
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpTop)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(438, 490)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 130)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(438, 360)
        Me.gcData.TabIndex = 9
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
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcIDuserdata, Me.gcIDassuper, Me.gcUserLevel, Me.gcUserData, Me.gcSuperUser})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "iduserlevel"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcIDuserdata
        '
        Me.gcIDuserdata.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDuserdata.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDuserdata.Caption = "IDuserdata"
        Me.gcIDuserdata.FieldName = "iduserdata"
        Me.gcIDuserdata.Name = "gcIDuserdata"
        Me.gcIDuserdata.OptionsColumn.AllowEdit = False
        Me.gcIDuserdata.OptionsColumn.ReadOnly = True
        '
        'gcIDassuper
        '
        Me.gcIDassuper.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDassuper.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDassuper.Caption = "IDassuper"
        Me.gcIDassuper.FieldName = "idassuper"
        Me.gcIDassuper.Name = "gcIDassuper"
        Me.gcIDassuper.OptionsColumn.AllowEdit = False
        Me.gcIDassuper.OptionsColumn.ReadOnly = True
        '
        'gcUserLevel
        '
        Me.gcUserLevel.AppearanceHeader.Options.UseTextOptions = True
        Me.gcUserLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcUserLevel.Caption = "User Level"
        Me.gcUserLevel.FieldName = "userlevel"
        Me.gcUserLevel.Name = "gcUserLevel"
        Me.gcUserLevel.OptionsColumn.AllowEdit = False
        Me.gcUserLevel.OptionsColumn.ReadOnly = True
        Me.gcUserLevel.Visible = True
        Me.gcUserLevel.VisibleIndex = 0
        '
        'gcUserData
        '
        Me.gcUserData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcUserData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcUserData.Caption = "User Data"
        Me.gcUserData.FieldName = "userdata"
        Me.gcUserData.Name = "gcUserData"
        Me.gcUserData.OptionsColumn.AllowEdit = False
        Me.gcUserData.OptionsColumn.ReadOnly = True
        Me.gcUserData.Visible = True
        Me.gcUserData.VisibleIndex = 1
        '
        'gcSuperUser
        '
        Me.gcSuperUser.AppearanceHeader.Options.UseTextOptions = True
        Me.gcSuperUser.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcSuperUser.Caption = "Super User"
        Me.gcSuperUser.FieldName = "assuper"
        Me.gcSuperUser.Name = "gcSuperUser"
        Me.gcSuperUser.OptionsColumn.AllowEdit = False
        Me.gcSuperUser.OptionsColumn.ReadOnly = True
        Me.gcSuperUser.Visible = True
        Me.gcSuperUser.VisibleIndex = 2
        '
        'tlpTop
        '
        Me.tlpTop.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpTop.ColumnCount = 4
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Controls.Add(Me.lueSuperUser, 2, 3)
        Me.tlpTop.Controls.Add(Me.lueUserData, 2, 2)
        Me.tlpTop.Controls.Add(Me.teNama, 2, 1)
        Me.tlpTop.Controls.Add(Me.lblSuperUser, 1, 3)
        Me.tlpTop.Controls.Add(Me.lblUserData, 1, 2)
        Me.tlpTop.Controls.Add(Me.lblLevel, 1, 1)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTop.Location = New System.Drawing.Point(0, 30)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 5
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Size = New System.Drawing.Size(438, 100)
        Me.tlpTop.TabIndex = 5
        '
        'lueSuperUser
        '
        Me.lueSuperUser.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueSuperUser.Location = New System.Drawing.Point(194, 64)
        Me.lueSuperUser.Margin = New System.Windows.Forms.Padding(0)
        Me.lueSuperUser.Name = "lueSuperUser"
        Me.lueSuperUser.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSuperUser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSuperUser.Properties.Appearance.Options.UseBackColor = True
        Me.lueSuperUser.Properties.Appearance.Options.UseFont = True
        Me.lueSuperUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSuperUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSuperUser.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idgeneral", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("generalcode", "Status Data")})
        Me.lueSuperUser.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSuperUser.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSuperUser.Size = New System.Drawing.Size(134, 20)
        Me.lueSuperUser.TabIndex = 46
        '
        'lueUserData
        '
        Me.lueUserData.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUserData.Location = New System.Drawing.Point(194, 40)
        Me.lueUserData.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUserData.Name = "lueUserData"
        Me.lueUserData.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUserData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUserData.Properties.Appearance.Options.UseBackColor = True
        Me.lueUserData.Properties.Appearance.Options.UseFont = True
        Me.lueUserData.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUserData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUserData.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idgeneral", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("generalcode", "Status Data")})
        Me.lueUserData.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUserData.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueUserData.Size = New System.Drawing.Size(134, 20)
        Me.lueUserData.TabIndex = 46
        '
        'teNama
        '
        Me.teNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNama.Location = New System.Drawing.Point(194, 16)
        Me.teNama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNama.Name = "teNama"
        Me.teNama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.Appearance.Options.UseBackColor = True
        Me.teNama.Properties.Appearance.Options.UseFont = True
        Me.teNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNama.Properties.NullText = "[Kosong]"
        Me.teNama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNama.Size = New System.Drawing.Size(134, 20)
        Me.teNama.TabIndex = 36
        Me.teNama.Tag = "userlevel"
        '
        'lblSuperUser
        '
        Me.lblSuperUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSuperUser.AutoSize = True
        Me.lblSuperUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperUser.Location = New System.Drawing.Point(124, 67)
        Me.lblSuperUser.Name = "lblSuperUser"
        Me.lblSuperUser.Size = New System.Drawing.Size(67, 14)
        Me.lblSuperUser.TabIndex = 32
        Me.lblSuperUser.Text = "Super User"
        Me.lblSuperUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserData
        '
        Me.lblUserData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUserData.AutoSize = True
        Me.lblUserData.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserData.Location = New System.Drawing.Point(131, 43)
        Me.lblUserData.Name = "lblUserData"
        Me.lblUserData.Size = New System.Drawing.Size(60, 14)
        Me.lblUserData.TabIndex = 32
        Me.lblUserData.Text = "User Data"
        Me.lblUserData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(128, 19)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(63, 14)
        Me.lblLevel.TabIndex = 32
        Me.lblLevel.Text = "User Level"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pHeader.Size = New System.Drawing.Size(438, 30)
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
        Me.btnNew.Location = New System.Drawing.Point(298, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 21
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
        Me.btnSave.Location = New System.Drawing.Point(358, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(438, 30)
        Me.pTitle.TabIndex = 36
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(408, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Tingkat Pengguna"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(408, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'frmUserLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(442, 522)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserLevel"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tingkat Pengguna"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpTop.ResumeLayout(False)
        Me.tlpTop.PerformLayout()
        CType(Me.lueSuperUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUserData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents tlpTop As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSuperUser As System.Windows.Forms.Label
    Friend WithEvents lblUserData As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents teNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueUserData As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueSuperUser As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDuserdata As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDassuper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcUserLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcUserData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSuperUser As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
