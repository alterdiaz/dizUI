Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrAMIRNA201901

    Private Sub xrAMIRNA201901_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcIDRM.Text = pID.Value
    End Sub

End Class