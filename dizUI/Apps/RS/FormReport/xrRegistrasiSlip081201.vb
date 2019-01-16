Public Class xrRegistrasiSlip081201

    Private Sub xrRegistrasiSlip081201_DataSourceRowChanged(sender As Object, e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = "REG-" & pID.Value
    End Sub

End Class