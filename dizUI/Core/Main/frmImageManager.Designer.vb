<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageManager
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
        Me.gcImages = New DevExpress.XtraGrid.GridControl()
        Me.lvImages = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.tboFilename = New System.Windows.Forms.TextBox()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.tboDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.tcControl = New System.Windows.Forms.TabControl()
        Me.tpInfo = New System.Windows.Forms.TabPage()
        Me.btniSave = New System.Windows.Forms.Button()
        Me.chbInfo = New System.Windows.Forms.CheckBox()
        Me.tpNew = New System.Windows.Forms.TabPage()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblNewDescription = New System.Windows.Forms.Label()
        Me.tboNewDescription = New System.Windows.Forms.TextBox()
        Me.cboProfilePicture = New System.Windows.Forms.CheckBox()
        Me.btnnBrowse = New System.Windows.Forms.Button()
        Me.btnnSave = New System.Windows.Forms.Button()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.pHeader = New System.Windows.Forms.Panel()
        CType(Me.gcImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcControl.SuspendLayout()
        Me.tpInfo.SuspendLayout()
        Me.tpNew.SuspendLayout()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcImages
        '
        Me.gcImages.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcImages.Location = New System.Drawing.Point(0, 30)
        Me.gcImages.MainView = Me.lvImages
        Me.gcImages.Name = "gcImages"
        Me.gcImages.Size = New System.Drawing.Size(670, 363)
        Me.gcImages.TabIndex = 0
        Me.gcImages.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvImages})
        '
        'lvImages
        '
        Me.lvImages.Appearance.ViewBackground.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.lvImages.Appearance.ViewBackground.Options.UseBackColor = True
        Me.lvImages.GridControl = Me.gcImages
        Me.lvImages.Name = "lvImages"
        Me.lvImages.TemplateCard = Nothing
        '
        'tboFilename
        '
        Me.tboFilename.BackColor = System.Drawing.Color.White
        Me.tboFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboFilename.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboFilename.Location = New System.Drawing.Point(77, 5)
        Me.tboFilename.MaxLength = 10
        Me.tboFilename.Name = "tboFilename"
        Me.tboFilename.ReadOnly = True
        Me.tboFilename.Size = New System.Drawing.Size(287, 22)
        Me.tboFilename.TabIndex = 4
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblFilename.Location = New System.Drawing.Point(6, 9)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(54, 14)
        Me.lblFilename.TabIndex = 3
        Me.lblFilename.Text = "Filename"
        '
        'tboDescription
        '
        Me.tboDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboDescription.Location = New System.Drawing.Point(77, 17)
        Me.tboDescription.MaxLength = 10
        Me.tboDescription.Name = "tboDescription"
        Me.tboDescription.Size = New System.Drawing.Size(352, 22)
        Me.tboDescription.TabIndex = 6
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(6, 20)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(67, 14)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Description"
        '
        'tcControl
        '
        Me.tcControl.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tcControl.Controls.Add(Me.tpInfo)
        Me.tcControl.Controls.Add(Me.tpNew)
        Me.tcControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcControl.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tcControl.Location = New System.Drawing.Point(0, 393)
        Me.tcControl.Multiline = True
        Me.tcControl.Name = "tcControl"
        Me.tcControl.SelectedIndex = 0
        Me.tcControl.Size = New System.Drawing.Size(670, 97)
        Me.tcControl.TabIndex = 7
        '
        'tpInfo
        '
        Me.tpInfo.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tpInfo.Controls.Add(Me.btniSave)
        Me.tpInfo.Controls.Add(Me.chbInfo)
        Me.tpInfo.Controls.Add(Me.lblDescription)
        Me.tpInfo.Controls.Add(Me.tboDescription)
        Me.tpInfo.Location = New System.Drawing.Point(4, 26)
        Me.tpInfo.Name = "tpInfo"
        Me.tpInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInfo.Size = New System.Drawing.Size(662, 67)
        Me.tpInfo.TabIndex = 1
        Me.tpInfo.Text = "Image Info"
        Me.tpInfo.UseVisualStyleBackColor = True
        '
        'btniSave
        '
        Me.btniSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btniSave.FlatAppearance.BorderSize = 0
        Me.btniSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btniSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btniSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btniSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniSave.Location = New System.Drawing.Point(579, 3)
        Me.btniSave.Name = "btniSave"
        Me.btniSave.Size = New System.Drawing.Size(80, 61)
        Me.btniSave.TabIndex = 12
        Me.btniSave.Text = "SAVE"
        Me.btniSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btniSave.UseVisualStyleBackColor = True
        '
        'chbInfo
        '
        Me.chbInfo.AutoSize = True
        Me.chbInfo.Location = New System.Drawing.Point(435, 18)
        Me.chbInfo.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chbInfo.Name = "chbInfo"
        Me.chbInfo.Size = New System.Drawing.Size(101, 18)
        Me.chbInfo.TabIndex = 7
        Me.chbInfo.Text = "Profile Picture"
        Me.chbInfo.UseVisualStyleBackColor = True
        '
        'tpNew
        '
        Me.tpNew.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tpNew.Controls.Add(Me.lblSize)
        Me.tpNew.Controls.Add(Me.lblNewDescription)
        Me.tpNew.Controls.Add(Me.tboNewDescription)
        Me.tpNew.Controls.Add(Me.tboFilename)
        Me.tpNew.Controls.Add(Me.cboProfilePicture)
        Me.tpNew.Controls.Add(Me.btnnBrowse)
        Me.tpNew.Controls.Add(Me.btnnSave)
        Me.tpNew.Controls.Add(Me.lblFilename)
        Me.tpNew.Location = New System.Drawing.Point(4, 26)
        Me.tpNew.Name = "tpNew"
        Me.tpNew.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNew.Size = New System.Drawing.Size(662, 67)
        Me.tpNew.TabIndex = 0
        Me.tpNew.Text = "Upload New Image"
        Me.tpNew.UseVisualStyleBackColor = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblSize.Location = New System.Drawing.Point(367, 33)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(103, 14)
        Me.lblSize.TabIndex = 18
        Me.lblSize.Text = "1000px x 1000px"
        '
        'lblNewDescription
        '
        Me.lblNewDescription.AutoSize = True
        Me.lblNewDescription.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblNewDescription.Location = New System.Drawing.Point(6, 33)
        Me.lblNewDescription.Name = "lblNewDescription"
        Me.lblNewDescription.Size = New System.Drawing.Size(67, 14)
        Me.lblNewDescription.TabIndex = 16
        Me.lblNewDescription.Text = "Description"
        '
        'tboNewDescription
        '
        Me.tboNewDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboNewDescription.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboNewDescription.Location = New System.Drawing.Point(77, 29)
        Me.tboNewDescription.MaxLength = 10
        Me.tboNewDescription.Name = "tboNewDescription"
        Me.tboNewDescription.Size = New System.Drawing.Size(287, 22)
        Me.tboNewDescription.TabIndex = 17
        '
        'cboProfilePicture
        '
        Me.cboProfilePicture.AutoSize = True
        Me.cboProfilePicture.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cboProfilePicture.Location = New System.Drawing.Point(370, 7)
        Me.cboProfilePicture.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cboProfilePicture.Name = "cboProfilePicture"
        Me.cboProfilePicture.Size = New System.Drawing.Size(101, 18)
        Me.cboProfilePicture.TabIndex = 15
        Me.cboProfilePicture.Text = "Profile Picture"
        Me.cboProfilePicture.UseVisualStyleBackColor = True
        '
        'btnnBrowse
        '
        Me.btnnBrowse.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnnBrowse.FlatAppearance.BorderSize = 0
        Me.btnnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnBrowse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnBrowse.Location = New System.Drawing.Point(499, 3)
        Me.btnnBrowse.Name = "btnnBrowse"
        Me.btnnBrowse.Size = New System.Drawing.Size(80, 61)
        Me.btnnBrowse.TabIndex = 14
        Me.btnnBrowse.Text = "BROWSE"
        Me.btnnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnBrowse.UseVisualStyleBackColor = True
        '
        'btnnSave
        '
        Me.btnnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnnSave.FlatAppearance.BorderSize = 0
        Me.btnnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnSave.Location = New System.Drawing.Point(579, 3)
        Me.btnnSave.Name = "btnnSave"
        Me.btnnSave.Size = New System.Drawing.Size(80, 61)
        Me.btnnSave.TabIndex = 13
        Me.btnnSave.Text = "SAVE"
        Me.btnnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnSave.UseVisualStyleBackColor = True
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
        Me.tlpForm.Size = New System.Drawing.Size(674, 522)
        Me.tlpForm.TabIndex = 8
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(670, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(640, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Manajemen Gambar"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(640, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.tcControl)
        Me.pBody.Controls.Add(Me.gcImages)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(670, 490)
        Me.pBody.TabIndex = 7
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(670, 30)
        Me.pHeader.TabIndex = 4
        '
        'frmImageManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(674, 522)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImageManager"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Gambar"
        CType(Me.gcImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcControl.ResumeLayout(False)
        Me.tpInfo.ResumeLayout(False)
        Me.tpInfo.PerformLayout()
        Me.tpNew.ResumeLayout(False)
        Me.tpNew.PerformLayout()
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcImages As DevExpress.XtraGrid.GridControl
    Friend WithEvents lvImages As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents tboFilename As System.Windows.Forms.TextBox
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents tboDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents tcControl As System.Windows.Forms.TabControl
    Friend WithEvents tpNew As System.Windows.Forms.TabPage
    Friend WithEvents tpInfo As System.Windows.Forms.TabPage
    Friend WithEvents chbInfo As System.Windows.Forms.CheckBox
    Public WithEvents btniSave As System.Windows.Forms.Button
    Friend WithEvents cboProfilePicture As System.Windows.Forms.CheckBox
    Public WithEvents btnnBrowse As System.Windows.Forms.Button
    Public WithEvents btnnSave As System.Windows.Forms.Button
    Friend WithEvents lblNewDescription As System.Windows.Forms.Label
    Friend WithEvents tboNewDescription As System.Windows.Forms.TextBox
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
