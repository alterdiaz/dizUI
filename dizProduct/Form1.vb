Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tboSrc.Text = ""
        tboKey1.Text = ""
        tboKey2.Text = ""
        nudLength.Value = 0
        cboFrom.SelectedValue = Nothing
        tboDst.Text = ""
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If tboSrc.Text = "" Then
            Exit Sub
        End If
        If tboKey1.Text = "" Then
            Exit Sub
        End If
        If tboKey2.Text = "" Then
            Exit Sub
        End If
        If nudLength.Value = 0 Then
            Exit Sub
        End If
        If cboFrom.Text = "" Then
            Exit Sub
        End If

        If cboFrom.Text = "Front" Then
            tboDst.Text = getGenerateCode(tboSrc.Text, tboKey1.Text, tboKey2.Text, nudLength.Value, getFrom.depan)
        ElseIf cboFrom.Text = "Behind" Then
            tboDst.Text = getGenerateCode(tboSrc.Text, tboKey1.Text, tboKey2.Text, nudLength.Value, getFrom.belakang)
        End If
    End Sub

    Public Enum getFrom
        depan = 0
        belakang = 1
    End Enum
    Public Function getGenerateCode(ByVal str As String, tokenkey1 As String, tokenkey2 As String, maxlength As Integer, getLengthFrom As getFrom) As String
        Dim retval As String = String.Empty
        If str = "" Then
            retval = ""
        Else
            For i As Integer = 0 To str.Length - 1
                If System.Text.RegularExpressions.Regex.IsMatch(str.Chars(i).ToString.ToUpper, "[A-Za-z0-9]") = True Then
                    retval &= str.Chars(i).ToString.ToUpper
                Else
                    retval &= ""
                End If
            Next
        End If

        If retval <> "" Then
            Dim engine As New dizEngine.engine()
            retval = engine.processE(retval)
            retval = engine.Encrypt(retval, tokenkey1)
            retval = engine.Encrypt(retval, tokenkey2)
            Dim tmp As String = retval
            retval = ""
            For i As Integer = 0 To tmp.Length - 1
                If System.Text.RegularExpressions.Regex.IsMatch(tmp.Chars(i).ToString.ToUpper, "[A-Za-z0-9]") = True Then
                    retval &= tmp.Chars(i).ToString.ToUpper
                Else
                    retval &= ""
                End If
            Next

            If retval.Length > maxlength Then
                If getLengthFrom = getFrom.depan Then
                    retval = retval.Remove(maxlength, retval.Length - maxlength)
                ElseIf getLengthFrom = getFrom.belakang Then
                    retval = retval.Substring(retval.Length - maxlength, maxlength)
                End If
            End If
        End If
        Return retval
    End Function


End Class
