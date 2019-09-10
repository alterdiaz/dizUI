Public Class xrRegistrasiSlip382801

    Private Sub xrRegistrasiSlip382801_DataSourceRowChanged(sender As Object, e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = "REG-" & pID.Value
    End Sub

End Class