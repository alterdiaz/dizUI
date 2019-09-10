Public Class frmWristbandSelect

    'Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    '    If txtPilih = "" Then
    '        dizMsgbox("Jenis RM belum dipilih", dizMsgboxStyle.Peringatan, Me)
    '        Exit Sub
    '    End If
    '    bClose = False
    '    Me.Dispose()
    'End Sub

    Private txtPilih As String = ""
    Private Sub btnKonsultasi_Click(sender As Object, e As EventArgs) Handles btnDewasa.Click, btnAnak.Click
        txtPilih = sender.tag
        If sender.name = "btnDewasa" Then
            btnDewasa.BackColor = Color.Olive
            btnAnak.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnAnak" Then
            btnDewasa.BackColor = Color.FromArgb(64, 0, 64)
            btnAnak.BackColor = Color.Olive
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
    Public ReadOnly Property getStringPilih() As String
        Get
            Return txtPilih
        End Get
    End Property

End Class