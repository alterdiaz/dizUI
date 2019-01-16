Public Class xrPasienBaru01

    Private Sub xrPasienBaru01_DataSourceRowChanged(sender As Object, e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = pID.Value.ToString
    End Sub

End Class