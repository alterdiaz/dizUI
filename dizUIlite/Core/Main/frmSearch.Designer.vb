<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rimeNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.tlpPaging = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPaging.SuspendLayout()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.SaddleBrown
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
        Me.tlpForm.Size = New System.Drawing.Size(790, 494)
        Me.tlpForm.TabIndex = 0
        '
        'pTitle
        '
        Me.pTitle.BackColor = System.Drawing.Color.SaddleBrown
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.btnClose)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(786, 30)
        Me.pTitle.TabIndex = 36
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(756, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Pencarian"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnClose.BackgroundImage = Global.dizUIlite.My.Resources.Resources.exit_w
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(756, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpPaging)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Controls.Add(Me.lblInfo)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 462)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
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
        Me.gcData.Location = New System.Drawing.Point(319, 30)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rimeNote})
        Me.gcData.Size = New System.Drawing.Size(467, 397)
        Me.gcData.TabIndex = 12
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
        Me.gvData.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.NewItemRowText = "Tambah Data Disini"
        Me.gvData.OptionsFind.AlwaysVisible = True
        Me.gvData.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.gvData.OptionsFind.FindNullPrompt = "Input pencarian"
        Me.gvData.OptionsFind.ShowCloseButton = False
        Me.gvData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.RowAutoHeight = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'rimeNote
        '
        Me.rimeNote.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeNote.Name = "rimeNote"
        Me.rimeNote.ReadOnly = True
        Me.rimeNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        '
        'tlpPaging
        '
        Me.tlpPaging.AutoSize = True
        Me.tlpPaging.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpPaging.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tlpPaging.ColumnCount = 9
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPaging.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPaging.Controls.Add(Me.lblCounter, 4, 0)
        Me.tlpPaging.Controls.Add(Me.btnLast, 7, 0)
        Me.tlpPaging.Controls.Add(Me.btnNext, 5, 0)
        Me.tlpPaging.Controls.Add(Me.btnFirst, 1, 0)
        Me.tlpPaging.Controls.Add(Me.btnPrev, 3, 0)
        Me.tlpPaging.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpPaging.Location = New System.Drawing.Point(0, 427)
        Me.tlpPaging.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPaging.Name = "tlpPaging"
        Me.tlpPaging.RowCount = 2
        Me.tlpPaging.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPaging.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpPaging.Size = New System.Drawing.Size(786, 35)
        Me.tlpPaging.TabIndex = 14
        '
        'lblCounter
        '
        Me.lblCounter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCounter.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblCounter.ForeColor = System.Drawing.Color.White
        Me.lblCounter.Location = New System.Drawing.Point(316, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblCounter.Size = New System.Drawing.Size(154, 30)
        Me.lblCounter.TabIndex = 15
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLast.FlatAppearance.BorderSize = 0
        Me.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.White
        Me.btnLast.Location = New System.Drawing.Point(523, 0)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 30)
        Me.btnLast.TabIndex = 16
        Me.btnLast.Text = ">>"
        Me.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLast.UseMnemonic = False
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(473, 0)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(40, 30)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = ">"
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNext.UseMnemonic = False
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFirst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFirst.FlatAppearance.BorderSize = 0
        Me.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.White
        Me.btnFirst.Location = New System.Drawing.Point(223, 0)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(40, 30)
        Me.btnFirst.TabIndex = 16
        Me.btnFirst.Text = "<<"
        Me.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFirst.UseMnemonic = False
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.White
        Me.btnPrev.Location = New System.Drawing.Point(273, 0)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(40, 30)
        Me.btnPrev.TabIndex = 15
        Me.btnPrev.Text = "<"
        Me.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrev.UseMnemonic = False
        Me.btnPrev.UseVisualStyleBackColor = False
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
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
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
        Me.btnSave.Location = New System.Drawing.Point(706, 0)
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
        Me.lblInfo.Location = New System.Drawing.Point(81, 177)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo.Size = New System.Drawing.Size(154, 30)
        Me.lblInfo.TabIndex = 16
        Me.lblInfo.Text = "Data Tidak Ditemukan"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(790, 494)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pencarian"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPaging.ResumeLayout(False)
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rimeNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tlpPaging As TableLayoutPanel
    Public WithEvents btnLast As Button
    Public WithEvents btnNext As Button
    Public WithEvents btnFirst As Button
    Public WithEvents btnPrev As Button
    Friend WithEvents lblCounter As Label
    Friend WithEvents lblInfo As Label
End Class
