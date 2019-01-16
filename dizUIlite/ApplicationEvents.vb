Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 5000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            writeLog(rClose)
        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            nowTime = Now
            startTime = nowTime
            Me.MinimumSplashScreenDisplayTime = 5000
        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            writeLog("Error: " & e.Exception.Message)
        End Sub

    End Class

End Namespace

