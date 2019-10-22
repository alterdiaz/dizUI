Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrSPBLMA
    Private Sub xrSPBLMA_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcQR.Text = pID.Value
    End Sub

End Class