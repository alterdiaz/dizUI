Public Class frmTestMessage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bott As Telegram.Bot.TelegramBotClient
        Dim YourBotTokenHere = "944321638:AAHo1VKJUDcA0DLFYLCQSPpyqxPDYasQGmU"
        bott = New Telegram.Bot.TelegramBotClient(YourBotTokenHere)
        bott.SendTextMessageAsync(TextBox1.Text, TextBox2.Text, Telegram.Bot.Types.Enums.ParseMode.Markdown, False, False, 0, Nothing)
    End Sub

End Class