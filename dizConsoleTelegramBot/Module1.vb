Imports System.IO
Imports System.Text
Imports System.Timers
Imports Telegram.Bot.Args
Imports System.Reflection

Module Module1

    Dim bott As Telegram.Bot.TelegramBotClient
    Sub initbot()
        If isBotError = False Then
            Dim YourBotTokenHere = "944321638:AAHo1VKJUDcA0DLFYLCQSPpyqxPDYasQGmU"
            bott = New Telegram.Bot.TelegramBotClient(YourBotTokenHere)

            RemoveHandler bott.OnUpdate, AddressOf OnUpdate
            RemoveHandler bott.OnMessage, AddressOf OnMessageReceived
            RemoveHandler bott.OnMessageEdited, AddressOf OnMessageEdited
            RemoveHandler bott.OnCallbackQuery, AddressOf OnCallbackQuery
            RemoveHandler bott.OnInlineQuery, AddressOf BotOnInlineQueryReceived
            RemoveHandler bott.OnInlineResultChosen, AddressOf BotOnChosenInlineResultReceived
            RemoveHandler bott.OnReceiveError, AddressOf BotOnReceiveError

            AddHandler bott.OnUpdate, AddressOf OnUpdate
            AddHandler bott.OnMessage, AddressOf OnMessageReceived
            AddHandler bott.OnMessageEdited, AddressOf OnMessageEdited
            AddHandler bott.OnCallbackQuery, AddressOf OnCallbackQuery
            AddHandler bott.OnInlineQuery, AddressOf BotOnInlineQueryReceived
            AddHandler bott.OnInlineResultChosen, AddressOf BotOnChosenInlineResultReceived
            AddHandler bott.OnReceiveError, AddressOf BotOnReceiveError

            isBotError = False
            If Not bott.IsReceiving Then bott.StartReceiving()
            Console.WriteLine("Bot Started")
        End If
    End Sub

    Private isBotError As Boolean = False
    Private Sub BotOnReceiveError(sender As Object, e As ReceiveErrorEventArgs)
        If isBotError = False Then
            isBotError = True
            Console.WriteLine("BotOnReceiveError")
        End If
    End Sub

    Private Sub BotOnChosenInlineResultReceived(sender As Object, e As ChosenInlineResultEventArgs)
        If isBotError = False Then
            Console.WriteLine("BotOnChosenInlineResultReceived")
        End If
    End Sub

    Private Sub BotOnInlineQueryReceived(sender As Object, e As InlineQueryEventArgs)
        If isBotError = False Then
            Console.WriteLine("BotOnInlineQueryReceived")
        End If
    End Sub

    Private Sub OnCallbackQuery(sender As Object, e As CallbackQueryEventArgs)
        If isBotError = False Then
            Console.WriteLine("OnCallbackQuery")
        End If
    End Sub

    Private Sub OnMessageEdited(sender As Object, e As MessageEventArgs)
        If isBotError = False Then
            Console.WriteLine(e.Message.Text)
        End If
    End Sub

    Private Sub OnUpdate(sender As Object, e As UpdateEventArgs)
        If isBotError = False Then
            Console.WriteLine("OnUpdate")
        End If
    End Sub

    Private Async Sub OnMessageReceived(sender As Object, e As MessageEventArgs)
        If isBotError = False Then
            Dim te As String = e.Message.From.Id.ToString & " " &
                        e.Message.From.FirstName & " " &
                        e.Message.From.Id & " " &
                        e.Message.From.IsBot & " " &
                        e.Message.From.LastName & " " & e.Message.From.Username

        Dim ID As String = e.Message.From.Id.ToString ' it is your id
            If e.Message.Type.Equals(Telegram.Bot.Types.Enums.MessageType.Text) Then
                Select Case True
                    Case e.Message.Text = "/start" 'response with the date and time
                        Await sendMessage(ID, "Perintah yang tersedia :" & vbCrLf & "/now untuk cek tanggal dan waktu" & vbCrLf & "/mytelegram untuk cek username telegram" & vbCrLf & "/help untuk bantuan lebih lanjut")
                    Case e.Message.Text = "/now" 'response with the date and time
                        Await sendMessage(ID, Format(Now, "dd-MM-yyyy HH:mm:ss"))
                    Case e.Message.Text = "/mytelegram" 'response with yor name and ID
                        Await sendMessage(ID, e.Message.From.Username & vbCrLf & e.Message.From.FirstName & " " & e.Message.From.LastName & vbCrLf & e.Message.From.Id.ToString)
                    Case e.Message.Text = "/help" 'response with yor name and ID
                        Await sendMessage(ID, "Goblok!!!")
                    Case e.Message.Text = "/sendfile"
                        Await sendDocument("249618110", "d:\AAA.png")
                    Case e.Message.Text.Split(" ")(0) = "/norm"
                        If e.Message.Text.Split(" ").Count <> 4 Then
                            Await sendMessage(ID, "PERINGATAN: Gunakan format berikut: /norm(spasi)KodePerusahaan(spasi)nomorrm 00-00-00-00(spasi)nomor identitas")
                        Else
                            Dim nick As String = e.Message.Text.Split(" ")(1)
                            Dim norm As String = e.Message.Text.Split(" ")(2)
                            Dim idno As String = e.Message.Text.Split(" ")(3)
                            Dim sqls As New SQLs(dbstring)
                            sqls.DMLQuery("select * from sys_appsetting where variable='CompanyNickname' and value='" & nick & "'", "getcompanynick")
                            If sqls.getDataSet("getcompanynick") = 0 Then
                                Await sendMessage(ID, "PERINGATAN: Kode Perusahaan tidak valid")
                                Exit Sub
                            Else
                                sqls.DMLQuery("select count(r.idregistrasi) as cnt,rm.nama,k.nomorkartu from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join (select top 1 * from kartu where isdeleted=0 and isprimary=1 and tablereff='PASIEN' and idreff=(select idrekammedis from rekammedis where dbo.fFormatNoRM(rekammedisno)='" & norm & "') order by createddate desc) k on k.idreff=rm.idrekammedis where r.isdeleted=0 and r.idrekammedis in (select idrekammedis from rekammedis where dbo.fFormatNoRM(rekammedisno)='" & norm & "') group by rm.nama,k.nomorkartu", "getreg")
                                Dim idno2 As String = sqls.getDataSet("getreg", 0, "nomorkartu")
                                If idno <> idno2 Then
                                    Await sendMessage(ID, "PERINGATAN: Nomor Identitas tidak terdaftar")
                                Else
                                    sqls.DMLQuery("select top 1 convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as regdate,p.nama as paramedis,d.department from registrasi r left join department d on r.iddepartment=d.iddepartment left join paramedis p on r.iddokterruangan=p.idparamedis where r.isdeleted=0 and r.idrekammedis in (select idrekammedis from rekammedis where dbo.fFormatNoRM(rekammedisno)='" & norm & "')", "getlast")

                                    Await sendMessage(ID, "No.RM " & norm & vbCrLf &
                                sqls.getDataSet("getreg", 0, "nama") & vbCrLf &
                                "Kunjungan Terakhir: " & vbCrLf &
                                sqls.getDataSet("getlast", 0, "regdate") & vbCrLf &
                                sqls.getDataSet("getlast", 0, "paramedis") & vbCrLf &
                                sqls.getDataSet("getlast", 0, "department"))
                                End If
                            End If
                        End If
                    Case Else
                        Await sendMessage(ID, "Perintah yang tersedia :" & vbCrLf & "/now untuk cek tanggal dan waktu" & vbCrLf & "/mytelegram untuk cek username telegram" & vbCrLf & "/help untuk bantuan lebih lanjut")
                End Select
                log(e.Message.Text & " ==> " & te)
            Else
                Dim t = "Perintah tidak ditemukan"
            log(e.Message.Text & " ==> " & te)
            Await sendMessage(ID, t)
        End If
        End If
    End Sub

    Public Async Function sendMessage(ByVal destID As String, ByVal text As String) As Task
        Try
            If isBotError = False Then
                Await bott.SendTextMessageAsync(destID, text, Telegram.Bot.Types.Enums.ParseMode.Markdown, False, False, 0, Nothing)
            End If
        Catch e As Exception
        End Try
    End Function

    Public Async Function sendDocument(destID As String, filepath As String) As Task
        Try
            If isBotError = False Then
                Dim f1 As FileStream = File.OpenRead(filepath)
                Dim str As Stream = f1

                Dim olfile As New Telegram.Bot.Types.InputFiles.InputOnlineFile(str, filepath)
                olfile.FileName = filepath
                Await bott.SendDocumentAsync(destID, olfile, Nothing, Telegram.Bot.Types.Enums.ParseMode.Default, False, 0, Nothing, Nothing)
            End If
        Catch e As Exception
            Console.WriteLine("BotErrorSendDocument" & vbCrLf & e.Message)
        End Try
    End Function

    Private Sub log(txt As String)
        Dim s = Now.ToString & " -- " & txt & vbCrLf
        Console.WriteLine(s)
        Dim folder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
        folder = If(folder.EndsWith("\"), folder, folder & "\") & "IsNotifier\Log\"
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If
        folder = folder & Now.Month.ToString.PadLeft(2, "0") & Now.Year & ".txt"
        File.AppendAllText(folder, s)
    End Sub

    Private dblite As String = ""
    Private dbstring As String = ""
    Private dbsvr As String = ""
    Private apppath As String = ""
    Private MonitorEnabled As Boolean = True

    Sub Main()
        apppath = System.AppDomain.CurrentDomain.BaseDirectory
        apppath = CheckAndRepairValidPath(apppath)
        Dim de As New dizEngine.engine
        dblite = apppath & de.processD("l59ruEcWFgphomWNjDb5gA==")
        dbstring = readSettingFile()

        initbot()

        ''Place Application in Hold Pattern until MonitorEnabled is False.	
        'Do While MonitorEnabled
        '    'If CInt(Format(Now, "ss")) >= intLoop Then
        '    If isBotError = True Then
        '            intLoop += 1
        '            If intLoop = 60 Then
        '                intLoop = 0
        '            End If
        '            isBotError = False
        '        Else
        '            intvLoop += 1
        '            If intvLoop > 4 Then
        '                intvLoop = 0
        '                initbot()
        '            End If
        '        End If
        '    'End If
        'Loop
        'tmrCek.Stop()
        Console.ReadLine()
    End Sub

    Public Function readSettingFile() As String
        Dim retval As String = ""
        'retval = IO.File.ReadAllLines(pathSetting & filename)(0)

        Dim myi As New SQLi(dblite)
        myi.DMLQuery("select databasename || '|' || ipserver || '|' || instance || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getdbstring")
        myi.DMLQuery("select ipserver from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getipsvr")
            If myi.getDataSet("getdbstring") > 0 Then
            dbsvr = myi.getDataSet("getipsvr", 0, "ipserver")
            retval = myi.getDataSet("getdbstring", 0, "dbstring")
        End If
        Return retval
    End Function

    Public Function CheckAndRepairValidPath(ByVal pathstring As String) As String
        Dim retval As String = ""
        If pathstring.Chars(pathstring.Length - 1) = "\" Then
            retval = pathstring
        Else
            retval = pathstring & "\"
        End If
        Return retval
    End Function

End Module
