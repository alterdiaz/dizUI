Imports System.Drawing.Printing

Public Class xrBPB
    Private Sub xrBPB_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcQR.Text = pID.Value
    End Sub

End Class