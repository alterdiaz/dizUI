<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputerClient
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.nudJumlahPC = New DevExpress.XtraEditors.SpinEdit()
        Me.lbClient = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboIPAddress = New DevExpress.XtraEditors.TextEdit()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        CType(Me.nudJumlahPC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboIPAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.Panel1, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(370, 360)
        Me.tlpForm.TabIndex = 8
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.pBody.Controls.Add(Me.tlpTop)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(366, 328)
        Me.pBody.TabIndex = 7
        '
        'tlpTop
        '
        Me.tlpTop.ColumnCount = 4
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTop.Controls.Add(Me.Label3, 1, 5)
        Me.tlpTop.Controls.Add(Me.btnDelete, 2, 6)
        Me.tlpTop.Controls.Add(Me.nudJumlahPC, 2, 1)
        Me.tlpTop.Controls.Add(Me.lbClient, 2, 5)
        Me.tlpTop.Controls.Add(Me.Label1, 1, 1)
        Me.tlpTop.Controls.Add(Me.tboIPAddress, 2, 2)
        Me.tlpTop.Controls.Add(Me.lblLevel, 1, 2)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Location = New System.Drawing.Point(0, 30)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 8
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Size = New System.Drawing.Size(366, 298)
        Me.tlpTop.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Daftar Komputer Client"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(158, 267)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 24)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'nudJumlahPC
        '
        Me.nudJumlahPC.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudJumlahPC.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudJumlahPC.Location = New System.Drawing.Point(158, 9)
        Me.nudJumlahPC.Margin = New System.Windows.Forms.Padding(0)
        Me.nudJumlahPC.Name = "nudJumlahPC"
        Me.nudJumlahPC.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudJumlahPC.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudJumlahPC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudJumlahPC.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.nudJumlahPC.Properties.Appearance.Options.UseBackColor = True
        Me.nudJumlahPC.Properties.Appearance.Options.UseFont = True
        Me.nudJumlahPC.Properties.Appearance.Options.UseForeColor = True
        Me.nudJumlahPC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudJumlahPC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.nudJumlahPC.Properties.DisplayFormat.FormatString = "n0"
        Me.nudJumlahPC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudJumlahPC.Properties.EditFormat.FormatString = "n0"
        Me.nudJumlahPC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudJumlahPC.Properties.IsFloatValue = False
        Me.nudJumlahPC.Properties.Mask.EditMask = "N00"
        Me.nudJumlahPC.Properties.MaxLength = 3
        Me.nudJumlahPC.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudJumlahPC.Size = New System.Drawing.Size(43, 20)
        Me.nudJumlahPC.TabIndex = 57
        Me.nudJumlahPC.Tag = ""
        '
        'lbClient
        '
        Me.lbClient.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbClient.ForeColor = System.Drawing.Color.Black
        Me.lbClient.FormattingEnabled = True
        Me.lbClient.ItemHeight = 15
        Me.lbClient.Location = New System.Drawing.Point(158, 84)
        Me.lbClient.Margin = New System.Windows.Forms.Padding(0)
        Me.lbClient.Name = "lbClient"
        Me.lbClient.Size = New System.Drawing.Size(187, 182)
        Me.lbClient.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 14)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Max Komputer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tboIPAddress
        '
        Me.tboIPAddress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboIPAddress.Location = New System.Drawing.Point(158, 33)
        Me.tboIPAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.tboIPAddress.Name = "tboIPAddress"
        Me.tboIPAddress.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboIPAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboIPAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboIPAddress.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tboIPAddress.Properties.Appearance.Options.UseBackColor = True
        Me.tboIPAddress.Properties.Appearance.Options.UseFont = True
        Me.tboIPAddress.Properties.Appearance.Options.UseForeColor = True
        Me.tboIPAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboIPAddress.Properties.NullText = "[Kosong]"
        Me.tboIPAddress.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboIPAddress.Size = New System.Drawing.Size(187, 20)
        Me.tboIPAddress.TabIndex = 37
        Me.tboIPAddress.Tag = "namalengkap"
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(90, 36)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(65, 14)
        Me.lblLevel.TabIndex = 32
        Me.lblLevel.Text = "IP Address"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(266, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.pHeader.Size = New System.Drawing.Size(366, 30)
        Me.pHeader.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.pExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 30)
        Me.Panel1.TabIndex = 8
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
        Me.lblTitle.Size = New System.Drawing.Size(336, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Daftar Komputer Klien"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(336, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 12
        Me.pExit.TabStop = False
        '
        'frmComputerClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(370, 360)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComputerClient"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Komputer Klien"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpTop.PerformLayout()
        CType(Me.nudJumlahPC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboIPAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents tlpTop As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents tboIPAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbClient As System.Windows.Forms.ListBox
    Friend WithEvents nudJumlahPC As DevExpress.XtraEditors.SpinEdit
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
