Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrAMIRJ201901
    Private Sub xrAMIRJ201901_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcIDRM.Text = pID.Value
    End Sub

End Class