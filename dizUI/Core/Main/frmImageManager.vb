Public Class frmImageManager

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private img As Image = Nothing
    Private imgByteArray As Byte() = Nothing
    Private imgMemoryStream As IO.MemoryStream
    Private Sub btnnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnBrowse.Click
        btnnSave.Enabled = False
        tboFilename.Clear()
        lblSize.Text = ""

        Dim open As New OpenFileDialog
        open.AddExtension = False
        open.AutoUpgradeEnabled = True
        open.CheckFileExists = True
        open.CheckPathExists = True
        open.DefaultExt = "png"
        open.Filter = "PNG Images|*.png"
        open.FilterIndex = 1
        open.InitialDirectory = pathIcon
        open.Multiselect = False
        open.ShowHelp = False

        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            img = Nothing
            imgByteArray = Nothing
            imgMemoryStream = Nothing

            tboFilename.Text = open.FileName
            img = Image.FromFile(tboFilename.Text)
            lblSize.Text = img.Size.Width & " x " & img.Size.Height
            imgMemoryStream = New IO.MemoryStream()
            If tboFilename.Text.Contains("png") Then
                img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
            End If
            imgByteArray = imgMemoryStream.GetBuffer()
            btnnSave.Enabled = True
        End If
    End Sub

    Private Sub btnnSave_Click(sender As Object, e As EventArgs) Handles btnnSave.Click
        Dim sqls As New SQLs(dbstring)
        Dim idimages As String = GenerateGUID()
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"idimages", "datetime", "filename", "sizewidth", "sizeheight", "images"})
        value.AddRange(New Object() {idimages, nowTime, tboFilename.Text, img.Size.Width, img.Size.Height, imgByteArray})

        If dtsql.datasetSave("sys_images", idimages, field, value, False) = True Then
            dizMsgbox("Image telah diupload", dizMsgboxStyle.Info, Me)
            btnnSave.Enabled = False
            tboFilename.Clear()
            lblSize.Text = ""

            LoadData()
        Else
            dizMsgbox("Image gagal diupload", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub frmImageManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblSize.Text = ""
        chbInfo.Checked = False
        cboProfilePicture.Checked = False
        tboDescription.Text = ""
        tboFilename.Text = ""
        tboNewDescription.Text = ""

        LoadData()
    End Sub

    Private Sub LoadData()
        GC.Collect()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idiconmenu,imagesicon,filename,datetime,cast(sizewidth as varchar(10)) + ' x ' + cast(sizeheight as varchar(10)) as size from sys_iconmenu", "data")
        gcImages.DataSource = sqls.dataTable("data")
    End Sub

End Class