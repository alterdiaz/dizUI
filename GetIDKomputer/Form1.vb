Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Management
Imports System.Net
Imports System.Collections.Specialized

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = getBoardID()
    End Sub

    Public Function getBoardID() As String
        Dim strMotherBoardID As String = String.Empty
        Dim query As New SelectQuery("Win32_Processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strMotherBoardID = info("ProcessorId").ToString()
        Next
        Return strMotherBoardID
    End Function

End Class
