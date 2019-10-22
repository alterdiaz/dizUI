Imports System.Drawing.Printing

Public Class xrSJM

    Private Sub xrSJM_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcQR.Text = pID.Value
    End Sub

End Class