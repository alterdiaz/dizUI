<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectKaryawan))
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKaryawan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.teKaryawan = New DevExpress.XtraEditors.TextEdit()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.teDepartment = New DevExpress.XtraEditors.TextEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.teKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkGreen
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
        Me.tlpForm.Size = New System.Drawing.Size(411, 408)
        Me.tlpForm.TabIndex = 0
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.btnClose)
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(407, 30)
        Me.pTitle.TabIndex = 36
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(377, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Pilih Karyawan"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.BackgroundImage = Global.dizUI.My.Resources.Resources.exit_w
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(377, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 17
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Controls.Add(Me.lblInfo)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(407, 376)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcData.Location = New System.Drawing.Point(0, 88)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(407, 288)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcKaryawan, Me.gcDepartment})
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
        Me.gcID.FieldName = "idstaff"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcKaryawan
        '
        Me.gcKaryawan.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKaryawan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKaryawan.Caption = "Nama Karyawan"
        Me.gcKaryawan.FieldName = "nama"
        Me.gcKaryawan.Name = "gcKaryawan"
        Me.gcKaryawan.OptionsColumn.AllowEdit = False
        Me.gcKaryawan.OptionsColumn.ReadOnly = True
        Me.gcKaryawan.Visible = True
        Me.gcKaryawan.VisibleIndex = 0
        '
        'gcDepartment
        '
        Me.gcDepartment.AppearanceHeader.Options.UseTextOptions = True
        Me.gcDepartment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDepartment.Caption = "Department"
        Me.gcDepartment.FieldName = "department"
        Me.gcDepartment.Name = "gcDepartment"
        Me.gcDepartment.OptionsColumn.AllowEdit = False
        Me.gcDepartment.OptionsColumn.ReadOnly = True
        Me.gcDepartment.Visible = True
        Me.gcDepartment.VisibleIndex = 1
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 4
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Controls.Add(Me.lblKaryawan, 1, 1)
        Me.tlpField.Controls.Add(Me.teKaryawan, 2, 1)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 2)
        Me.tlpField.Controls.Add(Me.teDepartment, 2, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Size = New System.Drawing.Size(407, 58)
        Me.tlpField.TabIndex = 7
        '
        'lblKaryawan
        '
        Me.lblKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKaryawan.AutoSize = True
        Me.lblKaryawan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaryawan.Location = New System.Drawing.Point(102, 10)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(93, 14)
        Me.lblKaryawan.TabIndex = 9
        Me.lblKaryawan.Text = "Nama Karyawan"
        Me.lblKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teKaryawan
        '
        Me.teKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKaryawan.Enabled = False
        Me.teKaryawan.Location = New System.Drawing.Point(198, 7)
        Me.teKaryawan.Margin = New System.Windows.Forms.Padding(0)
        Me.teKaryawan.Name = "teKaryawan"
        Me.teKaryawan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKaryawan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKaryawan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKaryawan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teKaryawan.Properties.Appearance.Options.UseBackColor = True
        Me.teKaryawan.Properties.Appearance.Options.UseFont = True
        Me.teKaryawan.Properties.Appearance.Options.UseForeColor = True
        Me.teKaryawan.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKaryawan.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teKaryawan.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teKaryawan.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teKaryawan.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKaryawan.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.teKaryawan.Properties.AppearanceFocused.Options.UseFont = True
        Me.teKaryawan.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.teKaryawan.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKaryawan.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teKaryawan.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teKaryawan.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teKaryawan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKaryawan.Properties.MaxLength = 10
        Me.teKaryawan.Properties.NullText = "[Belum Diisi]"
        Me.teKaryawan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKaryawan.Properties.ReadOnly = True
        Me.teKaryawan.Size = New System.Drawing.Size(150, 20)
        Me.teKaryawan.TabIndex = 17
        Me.teKaryawan.Tag = ""
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(122, 34)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(73, 14)
        Me.lblDepartment.TabIndex = 26
        Me.lblDepartment.Text = "Department"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teDepartment
        '
        Me.teDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teDepartment.Enabled = False
        Me.teDepartment.Location = New System.Drawing.Point(198, 31)
        Me.teDepartment.Margin = New System.Windows.Forms.Padding(0)
        Me.teDepartment.Name = "teDepartment"
        Me.teDepartment.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDepartment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teDepartment.Properties.Appearance.Options.UseBackColor = True
        Me.teDepartment.Properties.Appearance.Options.UseFont = True
        Me.teDepartment.Properties.Appearance.Options.UseForeColor = True
        Me.teDepartment.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDepartment.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teDepartment.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teDepartment.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teDepartment.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDepartment.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.teDepartment.Properties.AppearanceFocused.Options.UseFont = True
        Me.teDepartment.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.teDepartment.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDepartment.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teDepartment.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teDepartment.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teDepartment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teDepartment.Properties.MaxLength = 10
        Me.teDepartment.Properties.NullText = "[Belum Diisi]"
        Me.teDepartment.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teDepartment.Properties.ReadOnly = True
        Me.teDepartment.Size = New System.Drawing.Size(150, 20)
        Me.teDepartment.TabIndex = 29
        Me.teDepartment.Tag = ""
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(407, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(327, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "PILIH"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(126, 173)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo.Size = New System.Drawing.Size(154, 30)
        Me.lblInfo.TabIndex = 17
        Me.lblInfo.Text = "Data Tidak Ditemukan"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSelectKaryawan
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(411, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSelectKaryawan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih Karyawan"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblKaryawan As System.Windows.Forms.Label
    Friend WithEvents teKaryawan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents teDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcKaryawan As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblInfo As Label
End Class
