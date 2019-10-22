Imports System.Drawing.Printing

Public Class xrSJM212801
    Private Sub xrSJM212801_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcQR.Text = pID.Value
    End Sub

End Class