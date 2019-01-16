Imports System.ComponentModel
Imports System.Configuration.Install

Public Class ProjectInstaller

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add initialization code after the call to InitializeComponent
        ServiceProcessInstaller1.Account = ServiceProcess.ServiceAccount.LocalSystem
        ServiceProcessInstaller1.Username = ""
        ServiceProcessInstaller1.Password = ""
    End Sub

End Class
