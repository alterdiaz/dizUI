﻿Imports System.Drawing.Printing

Public Class xrSOB
    Private Sub xrStokOpname_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrbcQR.Text = pID.Value
    End Sub
End Class