Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrAMIGD201801

    Private Sub xrAMIGD201801_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcIDRM.Text = pID.Value
        If XrLabel53.Text = "Ya" Then
            pboStatPasien.Visible = True
            pboStatPasien.BringToFront()
        Else
            pboStatPasien.Visible = False
            pboStatPasien.SendToBack()
        End If
    End Sub

End Class