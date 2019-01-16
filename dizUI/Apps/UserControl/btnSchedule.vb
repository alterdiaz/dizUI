Public Class btnSchedule
    Private tanggalIni As DateTime
    Private tanggalStr As String = ""
    Private tanggalAngka As String = ""
    Public Property labelTanggal() As DateTime
        Get
            Return tanggalIni
        End Get
        Set(ByVal value As DateTime)
            tanggalIni = value
            tanggalStr = tanggalIni.Day & " " & NamaBulan(tanggalIni.Month) & " " & tanggalIni.Year
            tanggalAngka = tanggalIni.Day & " " & tanggalIni.Month & " " & tanggalIni.Year
            Button1.Text = "Appointment Schedule" & vbCrLf & NamaHari(tanggalIni.DayOfWeek) & ", " & tanggalStr
            Button1.Tag = Format(value, "dd-MM-yyyy")
            If tanggalIni.DayOfWeek = DayOfWeek.Sunday Then
                Button1.BackColor = Color.FromArgb(255, 210, 210)
            Else
                Button1.BackColor = Color.White
            End If
        End Set
    End Property

End Class
