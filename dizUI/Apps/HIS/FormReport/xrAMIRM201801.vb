Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrAMIRM201801

    Private Sub xrAMIRM201801_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcIDRM.Text = pID.Value
    End Sub

End Class