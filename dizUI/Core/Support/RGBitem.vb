Public Class RGBitem
    Public R As Integer
    Public G As Integer
    Public B As Integer

    Public Count As Single = 0

    Public Sub New(ByVal R1 As Integer, ByVal G1 As Integer, ByVal B1 As Integer, ByVal Count1 As Single)
        R = R1
        G = G1
        B = B1
        Count = Count1
    End Sub

    Public Function ReturnColor() As Color
        Dim R1 As Integer = 10 * R
        Dim G1 As Integer = 10 * G
        Dim B1 As Integer = 10 * B
        If R1 > 255 Then
            R1 = 255
        End If
        If G1 > 255 Then
            G1 = 255
        End If
        If B1 > 255 Then
            B1 = 255
        End If
        Return Color.FromArgb(R1, G1, B1)
    End Function
End Class
