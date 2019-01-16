<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.tlData = New DevExpress.XtraTreeList.TreeList()
        Me.tlcIDicon = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.iicIcon = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.tlcFormName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.icbFrmName = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.tlcMenu = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcDesc = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcAsDialog = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.lueDialog = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ilicon = New System.Windows.Forms.ImageList(Me.components)
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        CType(Me.tlData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iicIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbFrmName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDialog, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(1024, 506)
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
        Me.pTitle.Size = New System.Drawing.Size(1020, 30)
        Me.pTitle.TabIndex = 36
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Teal
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(990, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Panel Menu"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(990, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(1020, 474)
        Me.pBody.TabIndex = 7
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.Controls.Add(Me.tlData, 1, 1)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 3
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(1020, 444)
        Me.tlpEntry.TabIndex = 17
        '
        'tlData
        '
        Me.tlData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlData.Appearance.Empty.Options.UseBackColor = True
        Me.tlData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlData.Appearance.EvenRow.Options.UseBackColor = True
        Me.tlData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlData.Appearance.OddRow.Options.UseBackColor = True
        Me.tlData.Appearance.TreeLine.BackColor2 = System.Drawing.Color.Black
        Me.tlData.Appearance.TreeLine.ForeColor = System.Drawing.Color.Black
        Me.tlData.Appearance.TreeLine.Options.UseBackColor = True
        Me.tlData.Appearance.TreeLine.Options.UseForeColor = True
        Me.tlData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tlData.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.tlcIDicon, Me.tlcFormName, Me.tlcMenu, Me.tlcDesc, Me.tlcAsDialog})
        Me.tlData.Cursor = System.Windows.Forms.Cursors.Default
        Me.tlData.DataSource = Nothing
        Me.tlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tlData.KeyFieldName = "idmenu"
        Me.tlData.Location = New System.Drawing.Point(6, 6)
        Me.tlData.Margin = New System.Windows.Forms.Padding(0)
        Me.tlData.Name = "tlData"
        Me.tlData.OptionsView.EnableAppearanceEvenRow = True
        Me.tlData.OptionsView.EnableAppearanceOddRow = True
        Me.tlData.ParentFieldName = "idparent"
        Me.tlData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.iicIcon, Me.lueDialog, Me.icbFrmName})
        Me.tlData.RowHeight = 40
        Me.tlData.Size = New System.Drawing.Size(1008, 432)
        Me.tlData.TabIndex = 0
        Me.tlData.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Solid
        '
        'tlcIDicon
        '
        Me.tlcIDicon.AppearanceCell.Options.UseTextOptions = True
        Me.tlcIDicon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.tlcIDicon.AppearanceHeader.Options.UseTextOptions = True
        Me.tlcIDicon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlcIDicon.Caption = "Icon"
        Me.tlcIDicon.ColumnEdit = Me.iicIcon
        Me.tlcIDicon.FieldName = "idiconmenu"
        Me.tlcIDicon.Name = "tlcIDicon"
        Me.tlcIDicon.Visible = True
        Me.tlcIDicon.VisibleIndex = 0
        '
        'iicIcon
        '
        Me.iicIcon.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.iicIcon.DropDownItemHeight = 40
        Me.iicIcon.Name = "iicIcon"
        Me.iicIcon.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder
        Me.iicIcon.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        '
        'tlcFormName
        '
        Me.tlcFormName.AppearanceCell.Options.UseTextOptions = True
        Me.tlcFormName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.tlcFormName.AppearanceHeader.Options.UseTextOptions = True
        Me.tlcFormName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlcFormName.Caption = "Form Name"
        Me.tlcFormName.ColumnEdit = Me.icbFrmName
        Me.tlcFormName.FieldName = "frmname"
        Me.tlcFormName.Name = "tlcFormName"
        Me.tlcFormName.Visible = True
        Me.tlcFormName.VisibleIndex = 1
        '
        'icbFrmName
        '
        Me.icbFrmName.AutoHeight = False
        Me.icbFrmName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbFrmName.Name = "icbFrmName"
        Me.icbFrmName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'tlcMenu
        '
        Me.tlcMenu.AppearanceCell.Options.UseTextOptions = True
        Me.tlcMenu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.tlcMenu.AppearanceHeader.Options.UseTextOptions = True
        Me.tlcMenu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlcMenu.Caption = "Menu Text"
        Me.tlcMenu.FieldName = "menuname"
        Me.tlcMenu.Name = "tlcMenu"
        Me.tlcMenu.Visible = True
        Me.tlcMenu.VisibleIndex = 2
        '
        'tlcDesc
        '
        Me.tlcDesc.AppearanceCell.Options.UseTextOptions = True
        Me.tlcDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.tlcDesc.AppearanceHeader.Options.UseTextOptions = True
        Me.tlcDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlcDesc.Caption = "Description"
        Me.tlcDesc.FieldName = "description"
        Me.tlcDesc.Name = "tlcDesc"
        Me.tlcDesc.Visible = True
        Me.tlcDesc.VisibleIndex = 4
        '
        'tlcAsDialog
        '
        Me.tlcAsDialog.AppearanceCell.Options.UseTextOptions = True
        Me.tlcAsDialog.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.tlcAsDialog.AppearanceHeader.Options.UseTextOptions = True
        Me.tlcAsDialog.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlcAsDialog.Caption = "As Dialog"
        Me.tlcAsDialog.ColumnEdit = Me.lueDialog
        Me.tlcAsDialog.FieldName = "asdialog"
        Me.tlcAsDialog.Name = "tlcAsDialog"
        Me.tlcAsDialog.Visible = True
        Me.tlcAsDialog.VisibleIndex = 3
        '
        'lueDialog
        '
        Me.lueDialog.AutoHeight = False
        Me.lueDialog.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueDialog.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lueDialog.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDialog.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "As Dialog")})
        Me.lueDialog.Name = "lueDialog"
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Controls.Add(Me.btnDelete)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(1020, 30)
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
        Me.btnNew.Location = New System.Drawing.Point(800, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 26
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
        Me.btnSave.Location = New System.Drawing.Point(860, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 24
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
        Me.btnDelete.Location = New System.Drawing.Point(940, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ilicon
        '
        Me.ilicon.ImageStream = CType(resources.GetObject("ilicon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilicon.TransparentColor = System.Drawing.Color.Transparent
        Me.ilicon.Images.SetKeyName(0, "_miniPNGfinance002.png")
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 506)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel Menu"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        CType(Me.tlData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iicIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbFrmName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDialog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents tlData As DevExpress.XtraTreeList.TreeList
    Friend WithEvents tlcIDicon As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcFormName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents iicIcon As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents tlcMenu As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcDesc As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcAsDialog As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents lueDialog As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents icbFrmName As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ilicon As System.Windows.Forms.ImageList
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
