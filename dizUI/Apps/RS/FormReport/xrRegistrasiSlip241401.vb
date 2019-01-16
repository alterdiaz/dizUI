Public Class xrRegistrasiSlip241401

    Private Sub xrRegistrasiSlip241401_DataSourceRowChanged(sender As Object, e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = "REG-" & pID.Value
    End Sub

End Class