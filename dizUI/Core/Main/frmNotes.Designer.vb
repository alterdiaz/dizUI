<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotes
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
        Me.pBody = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pEntryNote = New System.Windows.Forms.Panel()
        Me.meNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitleNote = New System.Windows.Forms.Panel()
        Me.teUpdatedDate = New DevExpress.XtraEditors.TextEdit()
        Me.teCreatedDate = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lueNotes = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teTitle = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.pNotesList = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.deWarning = New DevExpress.XtraEditors.DateEdit()
        Me.btnClearWarningDate = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pEntryNote.SuspendLayout()
        CType(Me.meNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.pTitleNote.SuspendLayout()
        CType(Me.teUpdatedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCreatedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpEntry.SuspendLayout()
        Me.pNotesList.SuspendLayout()
        Me.pHeader.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.deWarning.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deWarning.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Maroon
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(1024, 600)
        Me.tlpForm.TabIndex = 1
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.TableLayoutPanel1)
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(1020, 568)
        Me.pBody.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pEntryNote, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(302, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(718, 538)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'pEntryNote
        '
        Me.pEntryNote.Controls.Add(Me.meNotes)
        Me.pEntryNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEntryNote.Location = New System.Drawing.Point(20, 92)
        Me.pEntryNote.Margin = New System.Windows.Forms.Padding(0)
        Me.pEntryNote.Name = "pEntryNote"
        Me.pEntryNote.Size = New System.Drawing.Size(678, 426)
        Me.pEntryNote.TabIndex = 0
        '
        'meNotes
        '
        Me.meNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.meNotes.Location = New System.Drawing.Point(0, 0)
        Me.meNotes.Name = "meNotes"
        Me.meNotes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meNotes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meNotes.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.meNotes.Properties.Appearance.Options.UseBackColor = True
        Me.meNotes.Properties.Appearance.Options.UseFont = True
        Me.meNotes.Properties.Appearance.Options.UseForeColor = True
        Me.meNotes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meNotes.Properties.MaxLength = 3000
        Me.meNotes.Size = New System.Drawing.Size(678, 426)
        Me.meNotes.TabIndex = 0
        Me.meNotes.Tag = "notes"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.pTitleNote, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.teTitle, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(678, 72)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'pTitleNote
        '
        Me.pTitleNote.Controls.Add(Me.teUpdatedDate)
        Me.pTitleNote.Controls.Add(Me.teCreatedDate)
        Me.pTitleNote.Controls.Add(Me.Label3)
        Me.pTitleNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitleNote.Location = New System.Drawing.Point(139, 24)
        Me.pTitleNote.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitleNote.Name = "pTitleNote"
        Me.pTitleNote.Size = New System.Drawing.Size(500, 24)
        Me.pTitleNote.TabIndex = 26
        '
        'teUpdatedDate
        '
        Me.teUpdatedDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUpdatedDate.Location = New System.Drawing.Point(248, 2)
        Me.teUpdatedDate.Margin = New System.Windows.Forms.Padding(0)
        Me.teUpdatedDate.Name = "teUpdatedDate"
        Me.teUpdatedDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUpdatedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUpdatedDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUpdatedDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teUpdatedDate.Properties.Appearance.Options.UseBackColor = True
        Me.teUpdatedDate.Properties.Appearance.Options.UseFont = True
        Me.teUpdatedDate.Properties.Appearance.Options.UseForeColor = True
        Me.teUpdatedDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUpdatedDate.Properties.NullText = "[Kosong]"
        Me.teUpdatedDate.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUpdatedDate.Properties.ReadOnly = True
        Me.teUpdatedDate.Size = New System.Drawing.Size(130, 20)
        Me.teUpdatedDate.TabIndex = 37
        Me.teUpdatedDate.Tag = ""
        '
        'teCreatedDate
        '
        Me.teCreatedDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teCreatedDate.EditValue = "[Kosong]"
        Me.teCreatedDate.Location = New System.Drawing.Point(0, 2)
        Me.teCreatedDate.Margin = New System.Windows.Forms.Padding(0)
        Me.teCreatedDate.Name = "teCreatedDate"
        Me.teCreatedDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teCreatedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teCreatedDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teCreatedDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teCreatedDate.Properties.Appearance.Options.UseBackColor = True
        Me.teCreatedDate.Properties.Appearance.Options.UseFont = True
        Me.teCreatedDate.Properties.Appearance.Options.UseForeColor = True
        Me.teCreatedDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teCreatedDate.Properties.NullText = "[Kosong]"
        Me.teCreatedDate.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teCreatedDate.Properties.ReadOnly = True
        Me.teCreatedDate.Size = New System.Drawing.Size(130, 20)
        Me.teCreatedDate.TabIndex = 36
        Me.teCreatedDate.Tag = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Diubah pada"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lueNotes
        '
        Me.lueNotes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueNotes.Location = New System.Drawing.Point(0, 2)
        Me.lueNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.lueNotes.Name = "lueNotes"
        Me.lueNotes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueNotes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueNotes.Properties.Appearance.Options.UseBackColor = True
        Me.lueNotes.Properties.Appearance.Options.UseFont = True
        Me.lueNotes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueNotes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNotes.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueNotes.Properties.NullText = "[Isian belum dipilih]"
        Me.lueNotes.Size = New System.Drawing.Size(130, 20)
        Me.lueNotes.TabIndex = 40
        Me.lueNotes.Tag = "isnote"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Judul Catatan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Jenis Catatan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'teTitle
        '
        Me.teTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTitle.Location = New System.Drawing.Point(139, 2)
        Me.teTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.teTitle.Name = "teTitle"
        Me.teTitle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTitle.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTitle.Properties.Appearance.Options.UseBackColor = True
        Me.teTitle.Properties.Appearance.Options.UseFont = True
        Me.teTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTitle.Properties.NullText = "[Kosong]"
        Me.teTitle.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teTitle.Size = New System.Drawing.Size(378, 20)
        Me.teTitle.TabIndex = 38
        Me.teTitle.Tag = "title"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Dibuat pada"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(300, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 538)
        Me.Panel1.TabIndex = 19
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Controls.Add(Me.pNotesList, 1, 1)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 3
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(300, 538)
        Me.tlpEntry.TabIndex = 17
        '
        'pNotesList
        '
        Me.pNotesList.AutoScroll = True
        Me.pNotesList.Controls.Add(Me.TableLayoutPanel2)
        Me.pNotesList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pNotesList.Location = New System.Drawing.Point(20, 20)
        Me.pNotesList.Margin = New System.Windows.Forms.Padding(0)
        Me.pNotesList.Name = "pNotesList"
        Me.pNotesList.Size = New System.Drawing.Size(260, 498)
        Me.pNotesList.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(260, 70)
        Me.TableLayoutPanel2.TabIndex = 0
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
        Me.btnNew.TabIndex = 25
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
        Me.btnSave.TabIndex = 17
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
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
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
        Me.pTitle.TabIndex = 8
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
        Me.lblTitle.Size = New System.Drawing.Size(990, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Catatan"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClearWarningDate)
        Me.Panel2.Controls.Add(Me.deWarning)
        Me.Panel2.Controls.Add(Me.lueNotes)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(139, 48)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 24)
        Me.Panel2.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Diingatkan pada"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'deWarning
        '
        Me.deWarning.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deWarning.EditValue = Nothing
        Me.deWarning.Location = New System.Drawing.Point(248, 2)
        Me.deWarning.Margin = New System.Windows.Forms.Padding(0)
        Me.deWarning.Name = "deWarning"
        Me.deWarning.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deWarning.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deWarning.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deWarning.Properties.Appearance.Options.UseBackColor = True
        Me.deWarning.Properties.Appearance.Options.UseFont = True
        Me.deWarning.Properties.Appearance.Options.UseForeColor = True
        Me.deWarning.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deWarning.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deWarning.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deWarning.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deWarning.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deWarning.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deWarning.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deWarning.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deWarning.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deWarning.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.deWarning.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deWarning.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.deWarning.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deWarning.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deWarning.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deWarning.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deWarning.Properties.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm"
        Me.deWarning.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deWarning.Properties.EditFormat.FormatString = "dd-MM-yyyy HH:mm"
        Me.deWarning.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deWarning.Properties.Mask.EditMask = "dd-MM-yyyy HH:mm"
        Me.deWarning.Size = New System.Drawing.Size(150, 20)
        Me.deWarning.TabIndex = 27
        Me.deWarning.Tag = "tanggaldatang"
        '
        'btnClearWarningDate
        '
        Me.btnClearWarningDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClearWarningDate.FlatAppearance.BorderSize = 0
        Me.btnClearWarningDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnClearWarningDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnClearWarningDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearWarningDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearWarningDate.ForeColor = System.Drawing.Color.White
        Me.btnClearWarningDate.Location = New System.Drawing.Point(402, 0)
        Me.btnClearWarningDate.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnClearWarningDate.Name = "btnClearWarningDate"
        Me.btnClearWarningDate.Size = New System.Drawing.Size(60, 24)
        Me.btnClearWarningDate.TabIndex = 42
        Me.btnClearWarningDate.Text = "CLEAR"
        Me.btnClearWarningDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearWarningDate.UseVisualStyleBackColor = False
        '
        'frmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNotes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catatan"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pEntryNote.ResumeLayout(False)
        CType(Me.meNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.pTitleNote.ResumeLayout(False)
        CType(Me.teUpdatedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCreatedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpEntry.ResumeLayout(False)
        Me.pNotesList.ResumeLayout(False)
        Me.pHeader.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.deWarning.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deWarning.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitleNote As System.Windows.Forms.Panel
    Friend WithEvents pEntryNote As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teUpdatedDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teCreatedDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents meNotes As DevExpress.XtraEditors.MemoEdit
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lueNotes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pNotesList As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents deWarning As DevExpress.XtraEditors.DateEdit
    Public WithEvents btnClearWarningDate As Button
End Class
