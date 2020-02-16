Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports WhatsAppApi
Imports WhatsAppApi.Account
Imports WhatsAppApi.Helper
Imports WhatsAppApi.Register
Imports WhatsAppApi.Response

Module Module1
    Sub Main()
        Dim tmpEncoding = Encoding.UTF8
        System.Console.OutputEncoding = Encoding.[Default]
        System.Console.InputEncoding = Encoding.[Default]
        Dim nickname As String = "WhatsApiNet"
        Dim sender As String = "6285695983939"
        Dim password As String = ""
        Dim target As String = "316********6"
        Dim wa As WhatsApp = New WhatsApp(sender, password, nickname, True)
        AddHandler wa.OnLoginSuccess, AddressOf wa_OnLoginSuccess
        AddHandler wa.OnLoginFailed, AddressOf wa_OnLoginFailed
        AddHandler wa.OnGetMessage, AddressOf wa_OnGetMessage
        AddHandler wa.OnGetMessageReceivedClient, AddressOf wa_OnGetMessageReceivedClient
        AddHandler wa.OnGetMessageReceivedServer, AddressOf wa_OnGetMessageReceivedServer
        AddHandler wa.OnNotificationPicture, AddressOf wa_OnNotificationPicture
        AddHandler wa.OnGetPresence, AddressOf wa_OnGetPresence
        AddHandler wa.OnGetGroupParticipants, AddressOf wa_OnGetGroupParticipants
        AddHandler wa.OnGetLastSeen, AddressOf wa_OnGetLastSeen
        AddHandler wa.OnGetTyping, AddressOf wa_OnGetTyping
        AddHandler wa.OnGetPaused, AddressOf wa_OnGetPaused
        AddHandler wa.OnGetMessageImage, AddressOf wa_OnGetMessageImage
        AddHandler wa.OnGetMessageAudio, AddressOf wa_OnGetMessageAudio
        AddHandler wa.OnGetMessageVideo, AddressOf wa_OnGetMessageVideo
        AddHandler wa.OnGetMessageLocation, AddressOf wa_OnGetMessageLocation
        AddHandler wa.OnGetMessageVcard, AddressOf wa_OnGetMessageVcard
        AddHandler wa.OnGetPhoto, AddressOf wa_OnGetPhoto
        AddHandler wa.OnGetPhotoPreview, AddressOf wa_OnGetPhotoPreview
        AddHandler wa.OnGetGroups, AddressOf wa_OnGetGroups
        AddHandler wa.OnGetSyncResult, AddressOf wa_OnGetSyncResult
        AddHandler wa.OnGetStatus, AddressOf wa_OnGetStatus
        AddHandler wa.OnGetPrivacySettings, AddressOf wa_OnGetPrivacySettings
        AddHandler DebugAdapter.Instance.OnPrintDebug, AddressOf Instance_OnPrintDebug
        wa.Connect()
        Dim datFile As String = getDatFileName(sender)
        Dim nextChallenge As Byte() = Nothing

        If File.Exists(datFile) Then

            Try
                Dim foo As String = File.ReadAllText(datFile)
                nextChallenge = Convert.FromBase64String(foo)
            Catch __unusedException1__ As Exception
            End Try
        End If

        wa.Login(nextChallenge)
        ProcessChat(wa, target)
        Console.ReadKey()
    End Sub

    Private Sub Instance_OnPrintDebug(ByVal value As Object)
        Console.WriteLine(value)
    End Sub

    Private Sub wa_OnGetPrivacySettings(ByVal settings As Dictionary(Of ApiBase.VisibilityCategory, ApiBase.VisibilitySetting))
        Throw New NotImplementedException()
    End Sub

    Private Sub wa_OnGetStatus(ByVal from As String, ByVal type As String, ByVal name As String, ByVal status As String)
        Console.WriteLine(String.Format("Got status from {0}: {1}", from, status))
    End Sub

    Private Function getDatFileName(ByVal pn As String) As String
        Dim filename As String = String.Format("{0}.next.dat", pn)
        Return Path.Combine(Directory.GetCurrentDirectory(), filename)
    End Function

    Private Sub wa_OnGetSyncResult(ByVal index As Integer, ByVal sid As String, ByVal existingUsers As Dictionary(Of String, String), ByVal failedNumbers As String())
        Console.WriteLine("Sync result for {0}:", sid)

        For Each item As KeyValuePair(Of String, String) In existingUsers
            Console.WriteLine("Existing: {0} (username {1})", item.Key, item.Value)
        Next

        For Each item As String In failedNumbers
            Console.WriteLine("Non-Existing: {0}", item)
        Next
    End Sub

    Private Sub wa_OnGetGroups(ByVal groups As WaGroupInfo())
        Console.WriteLine("Got groups:")

        For Each info As WaGroupInfo In groups
            Console.WriteLine(vbTab & "{0} {1}", info.subject, info.id)
        Next
    End Sub

    Private Sub wa_OnGetPhotoPreview(ByVal from As String, ByVal id As String, ByVal data As Byte())
        Console.WriteLine("Got preview photo for {0}", from)
        File.WriteAllBytes(String.Format("preview_{0}.jpg", from), data)
    End Sub

    Private Sub wa_OnGetPhoto(ByVal from As String, ByVal id As String, ByVal data As Byte())
        Console.WriteLine("Got full photo for {0}", from)
        File.WriteAllBytes(String.Format("{0}.jpg", from), data)
    End Sub

    Private Sub wa_OnGetMessageVcard(ByVal vcardNode As ProtocolTreeNode, ByVal from As String, ByVal id As String, ByVal name As String, ByVal data As Byte())
        Console.WriteLine("Got vcard ""{0}"" from {1}", name, from)
        File.WriteAllBytes(String.Format("{0}.vcf", name), data)
    End Sub

    Private Sub wa_OnGetMessageLocation(ByVal locationNode As ProtocolTreeNode, ByVal from As String, ByVal id As String, ByVal lon As Double, ByVal lat As Double, ByVal url As String, ByVal name As String, ByVal preview As Byte())
        Console.WriteLine("Got location from {0} ({1}, {2})", from, lat, lon)

        If Not String.IsNullOrEmpty(name) Then
            Console.WriteLine(vbTab & "{0}", name)
        End If

        File.WriteAllBytes(String.Format("{0}{1}.jpg", lat, lon), preview)
    End Sub

    Private Sub wa_OnGetMessageVideo(ByVal mediaNode As ProtocolTreeNode, ByVal from As String, ByVal id As String, ByVal fileName As String, ByVal fileSize As Integer, ByVal url As String, ByVal preview As Byte())
        Console.WriteLine("Got video from {0}", from, fileName)
        OnGetMedia(fileName, url, preview)
    End Sub

    Private Sub OnGetMedia(ByVal file As String, ByVal url As String, ByVal data As Byte())
        IO.File.WriteAllBytes(String.Format("preview_{0}.jpg", file), data)

        Using wc As WebClient = New WebClient()
            wc.DownloadFileAsync(New Uri(url), file, Nothing)
        End Using
    End Sub

    Private Sub wa_OnGetMessageAudio(ByVal mediaNode As ProtocolTreeNode, ByVal from As String, ByVal id As String, ByVal fileName As String, ByVal fileSize As Integer, ByVal url As String, ByVal preview As Byte())
        Console.WriteLine("Got audio from {0}", from, fileName)
        OnGetMedia(fileName, url, preview)
    End Sub

    Private Sub wa_OnGetMessageImage(ByVal mediaNode As ProtocolTreeNode, ByVal from As String, ByVal id As String, ByVal fileName As String, ByVal size As Integer, ByVal url As String, ByVal preview As Byte())
        Console.WriteLine("Got image from {0}", from, fileName)
        OnGetMedia(fileName, url, preview)
    End Sub

    Private Sub wa_OnGetPaused(ByVal from As String)
        Console.WriteLine("{0} stopped typing", from)
    End Sub

    Private Sub wa_OnGetTyping(ByVal from As String)
        Console.WriteLine("{0} is typing...", from)
    End Sub

    Private Sub wa_OnGetLastSeen(ByVal from As String, ByVal lastSeen As DateTime)
        Console.WriteLine("{0} last seen on {1}", from, lastSeen.ToString())
    End Sub

    Private Sub wa_OnGetMessageReceivedServer(ByVal from As String, ByVal id As String)
        Console.WriteLine("Message {0} to {1} received by server", id, from)
    End Sub

    Private Sub wa_OnGetMessageReceivedClient(ByVal from As String, ByVal id As String)
        Console.WriteLine("Message {0} to {1} received by client", id, from)
    End Sub

    Private Sub wa_OnGetGroupParticipants(ByVal gjid As String, ByVal jids As String())
        Console.WriteLine("Got participants from {0}:", gjid)

        For Each jid As String In jids
            Console.WriteLine(vbTab & "{0}", jid)
        Next
    End Sub

    Private Sub wa_OnGetPresence(ByVal from As String, ByVal type As String)
        Console.WriteLine("Presence from {0}: {1}", from, type)
    End Sub

    Private Sub wa_OnNotificationPicture(ByVal type As String, ByVal jid As String, ByVal id As String)
    End Sub

    Private Sub wa_OnGetMessage(ByVal node As ProtocolTreeNode, ByVal from As String, ByVal id As String, ByVal name As String, ByVal message As String, ByVal receipt_sent As Boolean)
        Console.WriteLine("Message from {0} {1}: {2}", name, from, message)
    End Sub

    Private Sub wa_OnLoginFailed(ByVal data As String)
        Console.WriteLine("Login failed. Reason: {0}", data)
    End Sub

    Private Sub wa_OnLoginSuccess(ByVal phoneNumber As String, ByVal data As Byte())
        Console.WriteLine("Login success. Next password:")
        Dim sdata As String = Convert.ToBase64String(data)
        Console.WriteLine(sdata)

        Try
            File.WriteAllText(getDatFileName(phoneNumber), sdata)
        Catch __unusedException1__ As Exception
        End Try
    End Sub

    Private Sub ProcessChat(ByVal wa As WhatsApp, ByVal dst As String)
        Dim thRecv = New Thread(Sub(t)

                                    Try

                                        While wa IsNot Nothing
                                            wa.PollMessages()
                                            Thread.Sleep(100)
                                            Continue While
                                        End While

                                    Catch __unusedThreadAbortException1__ As ThreadAbortException
                                    End Try
                                End Sub) With {
                .IsBackground = True
                                    }
        thRecv.Start()
        Dim usrMan As WhatsUserManager = New WhatsUserManager()
        Dim tmpUser = usrMan.CreateUser(dst, "User")

        While True
            Dim line As String = Console.ReadLine()
            If line Is Nothing AndAlso line.Length = 0 Then Continue While
            Dim command As String = line.Trim()

            Select Case command
                Case "/query"
                    Console.WriteLine("[] Interactive conversation with {0}:", tmpUser)
                Case "/accountinfo"
                    Console.WriteLine("[] Account Info: {0}", wa.GetAccountInfo().ToString())
                Case "/lastseen"
                    Console.WriteLine("[] Request last seen {0}", tmpUser)
                    wa.SendQueryLastOnline(tmpUser.GetFullJid())
                Case "/exit"
                    wa = Nothing
                    thRecv.Abort()
                    Return
                Case "/start"
                    wa.SendComposing(tmpUser.GetFullJid())
                Case "/pause"
                    wa.SendPaused(tmpUser.GetFullJid())
                Case Else
                    Console.WriteLine("[] Send message to {0}: {1}", tmpUser, line)
                    wa.SendMessage(tmpUser.GetFullJid(), line)
            End Select
        End While
    End Sub

End Module
