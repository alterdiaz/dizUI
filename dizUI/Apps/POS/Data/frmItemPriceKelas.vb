Public Class frmItemPriceKelas
    Private Sub frmItemPriceKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpAMIGD2018011.spCompanyLogoCaptionSquare' table. You can move, or remove it, as needed.
        Me.SpCompanyLogoCaptionSquareTableAdapter.Fill(Me.SpAMIGD2018011.spCompanyLogoCaptionSquare)

    End Sub
End Class