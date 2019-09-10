Public Class RGBindex
    Public Items As New Collection

    Public Sub AddItem(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer, ByVal Count As Single)
        If (R = 0 And G = 0 And B = 0) Or (R >= 25 And G >= 25 And B >= 25) Then
            Exit Sub
        End If
        For Each i As RGBItem In Items
            If i.R = R And i.G = G And i.B = B Then
                i.Count += Count
                Exit Sub
            End If
        Next
        Dim i2 As New RGBItem(R, G, B, Count)
        Items.Add(i2)
    End Sub

    Public Function GetDominantColor(ByVal Image As Bitmap) As Color
        If Image Is Nothing Then
            Return Color.White
        End If
        For i As Integer = 0 To Image.Width - 1
            For j As Integer = 0 To Image.Height - 1
                Dim c As Color = Image.GetPixel(i, j)
                If c.A = 255 Then
                    AddItem(c.R / 10, c.G / 10, c.B / 10, c.A / 255)
                End If
            Next
        Next
        If Items.Count = 0 Then
            Return Color.White
        End If
        Dim Dominant As RGBItem = Items(1)
        For Each i As RGBItem In Items
            If i.Count > Dominant.Count Then
                Dominant = i
            End If
        Next
        Return Dominant.ReturnColor
    End Function
End Class
