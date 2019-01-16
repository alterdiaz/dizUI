Public Class btnBookingR

    Private tanggalIni As DateTime
    Private tanggalStr As String = ""
    Private jamStr As String = ""
    Private tanggalAngka As String = ""
    Private nourut As Integer = 0
    Private namaPatient As String = "-"
    Private mrn As String = "-"
    Private cell1 As String = "-"
    Private cell2 As String = "-"
    Private namaSession As String = "-"
    Private intSession As Integer = -1
    Private bookStat As Integer = -1
    Private idapp As Integer = -1
    Public Property nomorUrut() As Integer
        Get
            Return nourut
        End Get
        Set(ByVal value As Integer)
            nourut = value
            If namaPatient = "-" Then
                Button2.Text = "Waktu " & jamStr & " - Sesi " & namaSession & vbCrLf & "Slot Kosong"
                Label1.Text = nourut & "  "
            Else
                Button2.Text = "Waktu " & jamStr & " - Sesi " & namaSession & vbCrLf & namaPatient & " (" & mrn & ")" & vbCrLf & "Phone1 (" & cell1 & ") Phone2 (" & cell2 & ")"
                Label1.Text = nourut & "  "
            End If
            Button2.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
            Button1.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
        End Set
    End Property

    Public Property sessionString() As String
        Get
            Return namaSession
        End Get
        Set(ByVal value As String)
            namaSession = value
            If namaPatient = "-" Then
                Button2.Text = "Waktu " & jamStr & " - Sesi " & namaSession & vbCrLf & "Slot Kosong"
                Label1.Text = nourut & "  "
            Else
                Button2.Text = "Waktu " & jamStr & " - Sesi " & namaSession & vbCrLf & namaPatient & " (" & mrn & ")" & vbCrLf & "Phone1 (" & cell1 & ") Phone2 (" & cell2 & ")"
                Label1.Text = nourut & "  "
            End If
            Button2.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
            Button1.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
        End Set
    End Property

    Public Property sessionInt As Integer
        Get
            Return intSession
        End Get
        Set(ByVal value As Integer)
            intSession = value
            Button2.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
            Button1.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
            setButton()
        End Set
    End Property

    Public Property setStatus As Integer
        Get
            Return bookStat
        End Get
        Set(ByVal value As Integer)
            bookStat = value
            Button2.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
            Button1.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
        End Set
    End Property

    Public Property labelTanggal() As DateTime
        Get
            Return tanggalIni
        End Get
        Set(ByVal value As DateTime)
            tanggalIni = value
            tanggalStr = tanggalIni.Day & " " & NamaBulan(tanggalIni.Month) & " " & tanggalIni.Year
            jamStr = Format(tanggalIni.Hour, "0#") & ":" & Format(tanggalIni.Minute, "0#")
            tanggalAngka = tanggalIni.Day & " " & tanggalIni.Month & " " & tanggalIni.Year & " " & tanggalIni.Hour & " " & tanggalIni.Minute & " " & tanggalIni.Second
            If namaPatient = "-" Then
                Button2.Text = "Waktu " & jamStr & " - Sesi " & namaSession & vbCrLf & "Slot Kosong"
                Label1.Text = nourut & "  "
            Else
                Button2.Text = "Waktu " & jamStr & " - Sesi " & namaSession & vbCrLf & namaPatient & " (" & mrn & ")" & vbCrLf & "Phone1 (" & cell1 & ") Phone2 (" & cell2 & ")"
                Label1.Text = nourut & "  "
            End If
            Button2.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
            Button1.Tag = tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2 & "]" & bookStat & "]" & idapp
        End Set
    End Property

    Private isChanged As Boolean = False
    Private Sub Button2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.TextChanged
        If Button2.Text.Contains("Slot Kosong") = False And isChanged = False Then
            Button2.Tag = Button2.Text '= tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2

            tanggalIni = New DateTime(Button2.Tag.ToString.Split(" ")(2), Button2.Tag.ToString.Split(" ")(1), Button2.Tag.ToString.Split(" ")(0), Button2.Tag.ToString.Split(" ")(3), Button2.Tag.ToString.Split(" ")(4), Button2.Tag.ToString.Split(" ")(5).Split("|")(0))
            tanggalStr = tanggalIni.Day & " " & NamaBulan(tanggalIni.Month) & " " & tanggalIni.Year
            jamStr = Format(tanggalIni.Hour, "0#") & ":" & Format(tanggalIni.Minute, "0#")
            tanggalAngka = tanggalIni.Day & " " & tanggalIni.Month & " " & tanggalIni.Year & " " & tanggalIni.Hour & " " & tanggalIni.Minute & " " & tanggalIni.Second
            intSession = Button2.Tag.ToString.Split("|")(1)
            nourut = Button2.Tag.ToString.Split("|")(2)
            namaPatient = Button2.Tag.ToString.Split("|")(3).Split("]")(0)
            mrn = Button2.Tag.ToString.Split("|")(3).Split("]")(1)
            cell1 = Button2.Tag.ToString.Split("|")(3).Split("]")(2)
            cell2 = Button2.Tag.ToString.Split("|")(3).Split("]")(3)
            bookStat = Button2.Tag.ToString.Split("|")(3).Split("]")(4)
            idapp = Button2.Tag.ToString.Split("|")(3).Split("]")(5)

            If cell1 = "" And cell2 = "" Then
                dizMsgbox("Telepon tidak diisi", dizMsgboxStyle.Peringatan)
                Button2.Text = Button2.AccessibleDescription
                Exit Sub
            End If
            isChanged = True
            Button2.Tag = Button2.Text
            Label1.Text = nourut & "  "
            Button2.Text = "Waktu " & jamStr & " - Sesi " & namaSession & vbCrLf & namaPatient & " (" & mrn & ")" & vbCrLf & "Phone1 (" & cell1 & ") Phone2 (" & cell2 & ")"
            Button1.Tag = Button2.Tag
            setButton()
        End If
    End Sub

    Private Sub setButton()
        'MsgBox(Button2.Tag.ToString)
        If Button2.Tag.ToString.Split("|")(3).Split("]")(4) = -1 Then
            Button2.Image = My.Resources.bookmarkGreen
            Button2.FlatAppearance.BorderColor = Color.Green
            Button1.Visible = False
        ElseIf Button2.Tag.ToString.Split("|")(3).Split("]")(4) = 1 Then
            Button2.Image = My.Resources.bookmarkOrange
            Button2.FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
            Button1.Visible = True
            Button1.BringToFront()
            Button2.BringToFront()
        ElseIf Button2.Tag.ToString.Split("|")(3).Split("]")(4) = 2 Then
            Button2.Image = My.Resources.bookmarkPurple
            Button2.FlatAppearance.BorderColor = Color.FromArgb(85, 19, 78)
            Button1.Visible = True
            Button1.BringToFront()
            Button2.BringToFront()
        ElseIf Button2.Tag.ToString.Split("|")(3).Split("]")(4) = 3 Then
            Button2.Image = My.Resources.bookmarkRed
            Button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0)
            Button1.Visible = True
            Button1.BringToFront()
            Button2.BringToFront()
        End If
    End Sub

End Class
