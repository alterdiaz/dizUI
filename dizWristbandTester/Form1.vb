Public Class Form1

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim lst As New List(Of String)
        lst.Add(tboHeader.Text)
        lst.Add(tboNoRM.Text)
        lst.Add(tboTglLahir.Text)
        lst.Add(tboNoReg.Text)
        lst.Add(tboUmur.Text)
        lst.Add(tboFooter.Text)
        cetakWristband(lst)
    End Sub

    Private Sub cetakWristband(data As List(Of String))
        If data.Count <> 6 Then Exit Sub

        Dim strdata As String = tboContent.Text
        '"^XA^FWR^FO160,1340^BQ,2,5^FD*NOREG*^FS^CF0,60^FO190,1470^A0,90,60^FD*HEADER*^FS^CF0,50^FO160,1470^A0,50,40^FD*NORM*^FS^CF0,50^FO160,1880^A0,50,40^FD*TGLLAHIR*^FS^CF0,50^FO120,1470^A0,50,40^FD*NOREG*^FS^CF0,50^FO120,1880^A0,50,40^FD*UMUR*^FS^CF0,50^FO80,1470^A0,50,40^FD*FOOTER*^FS^CF0,50^XZ"
        '"^XA^FWR^FO85,1255^BQ,2,9^FD*NOREG*^FS^CF0,60^FO190,1470^A0,90,60^FD*HEADER*^FS^CF0,50^FO160,1470^A0,50,40^FD*NORM*^FS^CF0,50^FO160,1880^A0,50,40^FD*TGLLAHIR*^FS^CF0,50^FO120,1470^A0,50,40^FD*NOREG*^FS^CF0,50^FO120,1880^A0,50,40^FD*UMUR*^FS^CF0,50^FO80,1470^A0,50,40^FD*FOOTER*^FS^CF0,50^XZ"            '"^XA^FWR^FO85,855^BQ,2,9^FD*NOREG*^FS^CF0,60^FO225,1070^A0,50,40^FD*HEADER*^FS^CF0,50^FO180,1070^A0,50,40^FD*NORM*^FS^FO180,1480^A0,50,40^FD*TGLLAHIR*^FS^FO130,1070^A0,50,40^FD*NOREG*^FS^FO130,1480^A0,50,40^FD*UMUR*^FS^CF0,55^FO85,1070^A0,50,40^FD*FOOTER*^FS^XZ"
        Dim header As String = data(0)
        strdata = strdata.Replace("*HEADER*", header)
        Dim norm As String = data(1)
        strdata = strdata.Replace("*NORM*", norm)
        Dim tgllahir As String = data(2)
        strdata = strdata.Replace("*TGLLAHIR*", tgllahir)
        Dim noreg As String = data(3)
        strdata = strdata.Replace("*NOREG*", noreg)
        Dim umur As String = data(4)
        strdata = strdata.Replace("*UMUR*", umur)
        Dim footer As String = data(5)
        strdata = strdata.Replace("*FOOTER*", footer)

        Dim pw As New PrintingRaw.PrintingRaw
        pw.OpenPrinter(tboPrintName.Text)
        pw.StartDocPrinter()
        pw.Send(strdata)
        pw.EndPagePrinter()
        pw.EndDocPrinter()
        pw.ClosePrinter()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strpath As String = Application.StartupPath
        If strpath.Chars(strpath.Length - 1) <> "\" Then
            strpath &= "\"
        End If
        IO.File.WriteAllText(strpath & "PrinterName.txt", tboPrintName.Text)
        IO.File.WriteAllText(strpath & "Content.txt", tboContent.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strpath As String = Application.StartupPath
        If strpath.Chars(strpath.Length - 1) <> "\" Then
            strpath &= "\"
        End If
        If IO.File.Exists(strpath & "PrinterName.txt") Then
            tboPrintName.Text = IO.File.ReadAllText(strpath & "PrinterName.txt")
        End If
        If IO.File.Exists(strpath & "Content.txt") Then
            tboContent.Text = IO.File.ReadAllText(strpath & "Content.txt")
        End If
    End Sub

End Class
