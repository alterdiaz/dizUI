Public Class frmRegStatusSelect
    'Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    '    If txtPilih = "" Then
    '        dizMsgbox("Jenis Pelayanan belum dipilih", dizMsgboxStyle.Peringatan, Me)
    '        Exit Sub
    '    End If
    '    bClose = False
    '    Me.Dispose()
    'End Sub

    Private txtPilih As Long = 0
    Private Sub btnKonsultasi_Click(sender As Object, e As EventArgs) Handles btnBatal.Click, btnKabur.Click, btnKRSAPS.Click, btnKRSclosing.Click, btnMRS.Click, btnMeninggal.Click, btnRujuk.Click
        txtPilih = CLng(sender.tag)
        If sender.name = "btnBatal" Then
            btnBatal.BackColor = Color.Olive
            btnKabur.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSclosing.BackColor = Color.FromArgb(64, 0, 64)
            btnMRS.BackColor = Color.FromArgb(64, 0, 64)
            btnMeninggal.BackColor = Color.FromArgb(64, 0, 64)
            btnRujuk.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnKabur" Then
            btnBatal.BackColor = Color.FromArgb(64, 0, 64)
            btnKabur.BackColor = Color.Olive
            btnKRSAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSclosing.BackColor = Color.FromArgb(64, 0, 64)
            btnMRS.BackColor = Color.FromArgb(64, 0, 64)
            btnMeninggal.BackColor = Color.FromArgb(64, 0, 64)
            btnRujuk.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnKRSAPS" Then
            btnBatal.BackColor = Color.FromArgb(64, 0, 64)
            btnKabur.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSAPS.BackColor = Color.Olive
            btnKRSclosing.BackColor = Color.FromArgb(64, 0, 64)
            btnMRS.BackColor = Color.FromArgb(64, 0, 64)
            btnMeninggal.BackColor = Color.FromArgb(64, 0, 64)
            btnRujuk.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnKRSclosing" Then
            btnBatal.BackColor = Color.FromArgb(64, 0, 64)
            btnKabur.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSclosing.BackColor = Color.Olive
            btnMRS.BackColor = Color.FromArgb(64, 0, 64)
            btnMeninggal.BackColor = Color.FromArgb(64, 0, 64)
            btnRujuk.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnMRS" Then
            btnBatal.BackColor = Color.FromArgb(64, 0, 64)
            btnKabur.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSclosing.BackColor = Color.FromArgb(64, 0, 64)
            btnMRS.BackColor = Color.Olive
            btnMeninggal.BackColor = Color.FromArgb(64, 0, 64)
            btnRujuk.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnMeninggal" Then
            btnBatal.BackColor = Color.FromArgb(64, 0, 64)
            btnKabur.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSclosing.BackColor = Color.FromArgb(64, 0, 64)
            btnMRS.BackColor = Color.FromArgb(64, 0, 64)
            btnMeninggal.BackColor = Color.Olive
            btnRujuk.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnRujuk" Then
            btnBatal.BackColor = Color.FromArgb(64, 0, 64)
            btnKabur.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnKRSclosing.BackColor = Color.FromArgb(64, 0, 64)
            btnMRS.BackColor = Color.FromArgb(64, 0, 64)
            btnMeninggal.BackColor = Color.FromArgb(64, 0, 64)
            btnRujuk.BackColor = Color.Olive
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtPilih = CLng(0)
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = bClose
    End Sub

    Public ReadOnly Property getPilih() As Long
        Get
            Return txtPilih
        End Get
    End Property

End Class