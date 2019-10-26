Public Class btnBooking

    Private dateIni As DateTime
    Private dateStr As String = ""
    Private dateAngka As String = ""
    Private timeStr As String = ""
    Private counter As Long = 0
    Private patientName As String = "-"
    Private mrn As String = "-"
    Private cell1 As String = "-"
    Private cell2 As String = "-"
    Private sessionName As String = "-"
    Private sessionInt As String = -1
    Private bookingStatus As Long = -1
    Private idApp As String = "-1"
    Private appNote As String = "-"

    Public Property remarks As String
        Get
            Return appNote
        End Get
        Set(value As String)
            appNote = value
        End Set
    End Property

    Public Property nomorUrut As Long
        Get
            Return counter
        End Get
        Set(ByVal value As Long)
            counter = value
        End Set
    End Property

    Public Property sessionString As String
        Get
            Return sessionName
        End Get
        Set(ByVal value As String)
            sessionName = value
        End Set
    End Property

    Public Property sessionNo As String
        Get
            Return sessionInt
        End Get
        Set(ByVal value As String)
            sessionInt = value
        End Set
    End Property

    Public Property setStatus As Long
        Get
            Return bookingStatus
        End Get
        Set(ByVal value As Long)
            bookingStatus = value
        End Set
    End Property

    Public Property labelTanggal() As DateTime
        Get
            Return dateIni
        End Get
        Set(ByVal value As DateTime)
            dateIni = value
            dateStr = dateIni.Day & " " & NamaBulan(dateIni.Month) & " " & dateIni.Year
            timeStr = Format(dateIni.Hour, "0#") & ":" & Format(dateIni.Minute, "0#")
            dateAngka = dateIni.Day & " " & dateIni.Month & " " & dateIni.Year & " " & dateIni.Hour & " " & dateIni.Minute & " " & dateIni.Second
        End Set
    End Property

    Public Property namapasien As String
        Get
            Return patientName
        End Get
        Set(value As String)
            patientName = value
        End Set
    End Property

    Public Property norm As String
        Get
            Return mrn
        End Get
        Set(value As String)
            mrn = value
        End Set
    End Property

    Public Property notelp1 As String
        Get
            Return cell1
        End Get
        Set(value As String)
            cell1 = value
        End Set
    End Property

    Public Property notelp2 As String
        Get
            Return cell2
        End Get
        Set(value As String)
            cell2 = value
        End Set
    End Property

    Public Property id As String
        Get
            Return idApp
        End Get
        Set(value As String)
            idApp = value
        End Set
    End Property

    'Private isChanged As Boolean = False
    'Private Sub Button2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.TextChanged
    '    If Button2.Text.Contains("Slot Kosong") = False And isChanged = False Then
    '        Button2.Tag = Button2.Text '= tanggalAngka & "|" & intSession & "|" & nourut & "|" & namaPatient & "]" & mrn & "]" & cell1 & "]" & cell2

    '        tanggalIni = New DateTime(Button2.Tag.ToString.Split(" ")(2), Button2.Tag.ToString.Split(" ")(1), Button2.Tag.ToString.Split(" ")(0), Button2.Tag.ToString.Split(" ")(3), Button2.Tag.ToString.Split(" ")(4), Button2.Tag.ToString.Split(" ")(5).Split("|")(0))
    '        tanggalStr = tanggalIni.Day & " " & NamaBulan(tanggalIni.Month) & " " & tanggalIni.Year
    '        jamStr = Format(tanggalIni.Hour, "0#") & ":" & Format(tanggalIni.Minute, "0#")
    '        tanggalAngka = tanggalIni.Day & " " & tanggalIni.Month & " " & tanggalIni.Year & " " & tanggalIni.Hour & " " & tanggalIni.Minute & " " & tanggalIni.Second
    '        intSession = Button2.Tag.ToString.Split("|")(1)
    '        nourut = Button2.Tag.ToString.Split("|")(2)
    '        namaPatient = Button2.Tag.ToString.Split("|")(3).Split("]")(0)
    '        mrn = Button2.Tag.ToString.Split("|")(3).Split("]")(1)
    '        cell1 = Button2.Tag.ToString.Split("|")(3).Split("]")(2)
    '        cell2 = Button2.Tag.ToString.Split("|")(3).Split("]")(3)
    '        bookStat = Button2.Tag.ToString.Split("|")(3).Split("]")(4)
    '        idapp = Button2.Tag.ToString.Split("|")(3).Split("]")(5)

    '        If cell1 = "" And cell2 = "" Then
    '            MsgBox("Telepon tidak diisi", MsgBoxStyle.Exclamation, "Warning")
    '            Button2.Text = Button2.AccessibleDescription
    '            Exit Sub
    '        End If
    '        isChanged = True
    '        Button2.Tag = Button2.Text
    '        Label1.Text = nourut & "  "
    '        Button2.Text = "Waktu " & jamStr & " - Sesi " & namaSession & vbCrLf & namaPatient & " (" & mrn & ")" & vbCrLf & "Phone1 (" & cell1 & ") Phone2 (" & cell2 & ")"
    '        Button1.Tag = Button2.Tag
    '        Button3.Tag = Button2.Tag
    '        Button4.Tag = Button2.Tag
    '        setButton()
    '    End If
    'End Sub

    'Private Sub setButton()
    '    If Button2.Tag.ToString.Split("|")(3).Split("]")(4) = -1 Then
    '        Button2.Image = My.Resources.bookmarkGreen
    '        Button2.FlatAppearance.BorderColor = Color.Green
    '        Button1.Visible = False
    '        Button3.Visible = False
    '        Button4.Visible = False
    '    ElseIf Button2.Tag.ToString.Split("|")(3).Split("]")(4) = 0 Then
    '        Button2.Image = My.Resources.bookmarkOrange
    '        Button2.FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
    '        Button1.Visible = True
    '        Button3.Visible = True
    '        Button4.Visible = True
    '        Button1.BringToFront()
    '        Button4.BringToFront()
    '        Button3.BringToFront()
    '        Button2.BringToFront()
    '    ElseIf Button2.Tag.ToString.Split("|")(3).Split("]")(4) = 1 Then
    '        Button2.Image = My.Resources.bookmarkPurple
    '        Button2.FlatAppearance.BorderColor = Color.FromArgb(85, 19, 78)
    '        Button1.Visible = True
    '        Button3.Visible = True
    '        Button4.Visible = False
    '        Button1.BringToFront()
    '        Button3.BringToFront()
    '        Button2.BringToFront()
    '    ElseIf Button2.Tag.ToString.Split("|")(3).Split("]")(4) = 2 Then
    '        Button2.Image = My.Resources.bookmarkRed
    '        Button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0)
    '        Button1.Visible = True
    '        Button3.Visible = False
    '        Button4.Visible = False
    '        Button1.BringToFront()
    '        Button2.BringToFront()
    '    End If
    'End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub buildObj()
        'MsgBox(timeStr & vbCrLf & counter)
        If idApp = "-1" Then
            Button2.Text = "Waktu " & timeStr & " - Sesi " & sessionName & vbCrLf & "Slot Kosong"
            Label1.Text = counter & "  "
        Else
            If remarks = "" Then
                Button2.Text = "Waktu " & timeStr & " - Sesi " & sessionName & vbCrLf & patientName & " (" & mrn & ")" & vbCrLf & "Phone1 (" & cell1 & ") Phone2 (" & cell2 & ")"
            Else
                Button2.Text = "Waktu " & timeStr & " - Sesi " & sessionName & vbCrLf & patientName & " (" & mrn & ")" & vbCrLf & "Phone1 (" & cell1 & ") Phone2 (" & cell2 & ")" & vbCrLf & "Note: " & remarks
            End If
            Label1.Text = counter & "  "
        End If
        Button1.Tag = idApp & "|" & counter & "|" & dateAngka
        Button2.Tag = idApp & "|" & counter & "|" & dateAngka
        Button3.Tag = idApp & "|" & counter & "|" & dateAngka
        Button4.Tag = idApp & "|" & counter & "|" & dateAngka

        If idApp = "-1" Then
            Button2.Image = My.Resources.bookmarkGreen
            Button2.FlatAppearance.BorderColor = Color.Green
            Button1.Visible = False
            Button3.Visible = False
            Button4.Visible = False
        Else
            If bookingStatus = 0 Then
                Button2.Image = My.Resources.bookmarkOrange
                Button2.FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
                Button1.Visible = True
                Button3.Visible = True
                Button4.Visible = True
                Button1.BringToFront()
                Button4.BringToFront()
                Button3.BringToFront()
                Button2.BringToFront()
            ElseIf bookingStatus = 1 Then
                Button2.Image = My.Resources.bookmarkPurple
                Button2.FlatAppearance.BorderColor = Color.FromArgb(85, 19, 78)
                Button1.Visible = True
                Button3.Visible = True
                Button4.Visible = False
                Button1.BringToFront()
                Button3.BringToFront()
                Button2.BringToFront()
            ElseIf bookingStatus = 2 Then
                Button2.Image = My.Resources.bookmarkRed
                Button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0)
                Button1.Visible = True
                Button3.Visible = False
                Button4.Visible = False
                Button1.BringToFront()
                Button2.BringToFront()
            End If
        End If
    End Sub

End Class
