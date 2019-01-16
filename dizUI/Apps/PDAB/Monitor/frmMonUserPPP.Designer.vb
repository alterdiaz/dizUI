<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonUserPPP
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
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rimeNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.seSaldoSesudah = New DevExpress.XtraEditors.SpinEdit()
        Me.seSaldoSebelum = New DevExpress.XtraEditors.SpinEdit()
        Me.lueBank = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPengajuanNo = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.lblSebelum = New System.Windows.Forms.Label()
        Me.lblSesudah = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.seSaldoSesudah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seSaldoSebelum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.RowCount = 2
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpForm.Size = New System.Drawing.Size(790, 430)
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
        Me.lblTitle.Text = "Monitoring Pengajuan Penerimaan dan Pengeluaran Uang Bank (User)"
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
        Me.pBody.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 400)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.gcData.Location = New System.Drawing.Point(0, 94)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rimeNote})
        Me.gcData.Size = New System.Drawing.Size(786, 306)
        Me.gcData.TabIndex = 13
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.NewItemRowText = "Tambah Data Disini"
        Me.gvData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.RowAutoHeight = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.OptionsView.ShowViewCaption = True
        Me.gvData.ViewCaption = " "
        '
        'rimeNote
        '
        Me.rimeNote.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeNote.Name = "rimeNote"
        Me.rimeNote.ReadOnly = True
        Me.rimeNote.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.seSaldoSesudah, 4, 2)
        Me.tlpField.Controls.Add(Me.seSaldoSebelum, 2, 2)
        Me.tlpField.Controls.Add(Me.lueBank, 4, 1)
        Me.tlpField.Controls.Add(Me.Label1, 3, 1)
        Me.tlpField.Controls.Add(Me.lblPengajuanNo, 1, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 2, 1)
        Me.tlpField.Controls.Add(Me.lblSebelum, 1, 2)
        Me.tlpField.Controls.Add(Me.lblSesudah, 3, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 64)
        Me.tlpField.TabIndex = 7
        '
        'seSaldoSesudah
        '
        Me.seSaldoSesudah.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seSaldoSesudah.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seSaldoSesudah.Location = New System.Drawing.Point(548, 34)
        Me.seSaldoSesudah.Margin = New System.Windows.Forms.Padding(0)
        Me.seSaldoSesudah.Name = "seSaldoSesudah"
        Me.seSaldoSesudah.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seSaldoSesudah.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seSaldoSesudah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seSaldoSesudah.Properties.Appearance.Options.UseBackColor = True
        Me.seSaldoSesudah.Properties.Appearance.Options.UseFont = True
        Me.seSaldoSesudah.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seSaldoSesudah.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.seSaldoSesudah.Properties.DisplayFormat.FormatString = "n2"
        Me.seSaldoSesudah.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seSaldoSesudah.Properties.EditFormat.FormatString = "n2"
        Me.seSaldoSesudah.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seSaldoSesudah.Properties.IsFloatValue = False
        Me.seSaldoSesudah.Properties.Mask.EditMask = "N00"
        Me.seSaldoSesudah.Properties.MaxLength = 16
        Me.seSaldoSesudah.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.seSaldoSesudah.Properties.ReadOnly = True
        Me.seSaldoSesudah.Size = New System.Drawing.Size(150, 20)
        Me.seSaldoSesudah.TabIndex = 52
        Me.seSaldoSesudah.Tag = ""
        '
        'seSaldoSebelum
        '
        Me.seSaldoSebelum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seSaldoSebelum.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seSaldoSebelum.Location = New System.Drawing.Point(218, 34)
        Me.seSaldoSebelum.Margin = New System.Windows.Forms.Padding(0)
        Me.seSaldoSebelum.Name = "seSaldoSebelum"
        Me.seSaldoSebelum.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seSaldoSebelum.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seSaldoSebelum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seSaldoSebelum.Properties.Appearance.Options.UseBackColor = True
        Me.seSaldoSebelum.Properties.Appearance.Options.UseFont = True
        Me.seSaldoSebelum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seSaldoSebelum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.seSaldoSebelum.Properties.DisplayFormat.FormatString = "n2"
        Me.seSaldoSebelum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seSaldoSebelum.Properties.EditFormat.FormatString = "n2"
        Me.seSaldoSebelum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seSaldoSebelum.Properties.IsFloatValue = False
        Me.seSaldoSebelum.Properties.Mask.EditMask = "N00"
        Me.seSaldoSebelum.Properties.MaxLength = 16
        Me.seSaldoSebelum.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.seSaldoSebelum.Properties.ReadOnly = True
        Me.seSaldoSebelum.Size = New System.Drawing.Size(150, 20)
        Me.seSaldoSebelum.TabIndex = 52
        Me.seSaldoSebelum.Tag = ""
        '
        'lueBank
        '
        Me.lueBank.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBank.Location = New System.Drawing.Point(548, 10)
        Me.lueBank.Margin = New System.Windows.Forms.Padding(0)
        Me.lueBank.Name = "lueBank"
        Me.lueBank.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueBank.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueBank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueBank.Properties.Appearance.Options.UseBackColor = True
        Me.lueBank.Properties.Appearance.Options.UseFont = True
        Me.lueBank.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueBank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBank.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idbank", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bank", "Bank"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("remarks", "Remarks")})
        Me.lueBank.Properties.NullText = "[Isian belum dipilih]"
        Me.lueBank.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueBank.Size = New System.Drawing.Size(150, 20)
        Me.lueBank.TabIndex = 49
        Me.lueBank.Tag = "idbank"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(512, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Bank"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPengajuanNo
        '
        Me.lblPengajuanNo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPengajuanNo.AutoSize = True
        Me.lblPengajuanNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPengajuanNo.Location = New System.Drawing.Point(165, 13)
        Me.lblPengajuanNo.Name = "lblPengajuanNo"
        Me.lblPengajuanNo.Size = New System.Drawing.Size(50, 14)
        Me.lblPengajuanNo.TabIndex = 22
        Me.lblPengajuanNo.Text = "Tanggal"
        Me.lblPengajuanNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(218, 10)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHeaderHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHighlight.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceWeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceWeekNumber.Options.UseFont = True
        Me.deTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggal.Size = New System.Drawing.Size(104, 20)
        Me.deTanggal.TabIndex = 31
        '
        'lblSebelum
        '
        Me.lblSebelum.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSebelum.AutoSize = True
        Me.lblSebelum.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSebelum.Location = New System.Drawing.Point(128, 37)
        Me.lblSebelum.Name = "lblSebelum"
        Me.lblSebelum.Size = New System.Drawing.Size(87, 14)
        Me.lblSebelum.TabIndex = 53
        Me.lblSebelum.Text = "Saldo Sebelum"
        Me.lblSebelum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSesudah
        '
        Me.lblSesudah.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSesudah.AutoSize = True
        Me.lblSesudah.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSesudah.Location = New System.Drawing.Point(459, 37)
        Me.lblSesudah.Name = "lblSesudah"
        Me.lblSesudah.Size = New System.Drawing.Size(86, 14)
        Me.lblSesudah.TabIndex = 54
        Me.lblSesudah.Text = "Saldo Sesudah"
        Me.lblSesudah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnExport)
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
        Me.btnExport.Location = New System.Drawing.Point(686, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 30)
        Me.btnExport.TabIndex = 15
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
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
        'frmMonUserPPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 430)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMonUserPPP"
        Me.ShowInTaskbar = False
        Me.Text = "Monitoring Pengajuan Penerimaan dan Pengeluaran Uang Bank (User)"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.seSaldoSesudah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seSaldoSebelum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblPengajuanNo As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Public WithEvents btnExport As System.Windows.Forms.Button
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lueBank As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents seSaldoSesudah As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seSaldoSebelum As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblSebelum As System.Windows.Forms.Label
    Friend WithEvents lblSesudah As System.Windows.Forms.Label
    Friend WithEvents rimeNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
