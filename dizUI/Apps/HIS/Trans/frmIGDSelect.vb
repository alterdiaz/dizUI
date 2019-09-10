Public Class frmIGDSelect

    'Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    '    If txtPilih = "" Then
    '        dizMsgbox("Jenis Pelayanan belum dipilih", dizMsgboxStyle.Peringatan, Me)
    '        Exit Sub
    '    End If
    '    bClose = False
    '    Me.Dispose()
    'End Sub

    Private txtPilih As String = ""
    Private Sub btnKonsultasi_Click(sender As Object, e As EventArgs) Handles btnIGD.Click, btnIGDelektif.Click
        txtPilih = sender.tag

        If sender.name = "btnIGD" Then
            btnIGD.BackColor = Color.Olive
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnIGDelektif" Then
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
        btnIGDelektif.BackColor = Color.Olive
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
        sqls.DMLQuery("select p.idparamedis as id,p.nama as content from paramedis p where p.isservice=1 and p.isdeleted=0 and p.paramedistype=2 order by p.nama asc", "igd")
        sqls.DMLQuery("select p.idparamedis as id,p.nama as content from paramedis p where p.isservice=1 and p.isdeleted=0 and p.paramedistype=2 order by p.nama asc", "umum")

        btnIGD.Enabled = True
        lblIGD.Visible = False
        btnIGDelektif.Enabled = True
        lblIGDelektif.Visible = False

        If sqls.getDataSet("igd") = 0 Then
            btnIGD.Enabled = False
            lblIGD.Visible = True
            btnIGDelektif.Enabled = False
            lblIGDelektif.Visible = True
        End If
    End Sub

    Public ReadOnly Property getStringPilih() As String
        Get
            Return txtPilih
        End Get
    End Property

End Class