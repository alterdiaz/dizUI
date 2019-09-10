Public Class frmAPSnonAPSSelect

    'Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    '    If txtPilih = "" Then
    '        dizMsgbox("Jenis Pelayanan belum dipilih", dizMsgboxStyle.Peringatan, Me)
    '        Exit Sub
    '    End If
    '    bClose = False
    '    Me.Dispose()
    'End Sub

    Private txtPilih As String = ""
    Private kdpelayanan As String = ""
    Public Sub New(strpelayanan As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        kdpelayanan = strpelayanan
    End Sub

    Private Sub btnKonsultasi_Click(sender As Object, e As EventArgs) Handles btnAPS.Click, btnReguler.Click
        txtPilih = sender.tag

        If sender.name = "btnAPS" Then
            btnAPS.BackColor = Color.Olive
            btnReguler.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnReguler" Then
            btnAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnReguler.BackColor = Color.Olive
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtPilih = ""
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = bClose
    End Sub

    Private Sub frmPelayananSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sqls As New SQLs(dbstring)
        If kdpelayanan = "RAD" Then
            sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and s.idspesialis in (select [value] from sys_appsetting where variable in ('IDSPRad')) order by s.nama,p.nama asc", "listdokter")
        ElseIf kdpelayanan = "LAB" Then
            sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and s.idspesialis in (select [value] from sys_appsetting where variable in ('IDSPPK')) order by s.nama,p.nama asc", "listdokter")
        End If

        btnAPS.Enabled = True
        lblAPS.Visible = False
        btnReguler.Enabled = True
        lblReguler.Visible = False

        If sqls.getDataSet("listdokter") = 0 Then
            btnAPS.Enabled = False
            lblAPS.Visible = True
            btnReguler.Enabled = False
            lblReguler.Visible = True
        End If
    End Sub

    Public ReadOnly Property getStringPilih() As String
        Get
            Return txtPilih
        End Get
    End Property

End Class