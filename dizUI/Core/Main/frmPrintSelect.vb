Public Class frmPrintSelect

    'Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    '    If txtPilih = "" Then
    '        dizMsgbox("Jenis Pelayanan belum dipilih", dizMsgboxStyle.Peringatan, Me)
    '        Exit Sub
    '    End If
    '    bClose = False
    '    Me.Dispose()
    'End Sub

    Private txtPilih As String = ""
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnPreview.Click, btnCetak.Click
        txtPilih = sender.tag
        If sender.name = "btnPreview" Then
            btnPreview.BackColor = Color.Olive
            btnCetak.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnCetak" Then
            btnPreview.BackColor = Color.FromArgb(64, 0, 64)
            btnCetak.BackColor = Color.Olive
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