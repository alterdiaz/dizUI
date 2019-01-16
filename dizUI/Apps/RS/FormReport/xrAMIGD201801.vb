Imports DevExpress.XtraReports.UI

Public Class xrAMIGD201801
    Private Sub xrAMIGD201801_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = "ASMIGD-" & pID.Value
        If XrLabel53.Text = "Ya" Then
            pboStatPasien.Visible = True
            pboStatPasien.BringToFront()
        Else
            pboStatPasien.Visible = False
            pboStatPasien.SendToBack()
        End If
    End Sub

End Class