Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrSPP
    Private Sub xrSPP_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcQR.Text = pID.Value
    End Sub

End Class