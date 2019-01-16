Public Class frmIconManager


    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> Public Shared Function ReleaseCapture() As Boolean
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

    Private Sub frmIconManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnnSave.Enabled = False
        btnfSave.Enabled = False

        lbliSize.Text = ""
        lblSize.Text = ""
        lblFiles.Text = ""
        LoadData()
    End Sub

    Private Sub LoadData()
        GC.Collect()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idiconmenu,imagesicon,filename,datetime,cast(sizewidth as varchar(10)) + ' x ' + cast(sizeheight as varchar(10)) as size from sys_iconmenu", "data")
        gcData.DataSource = sqls.dataTable("data")
    End Sub

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

    Private img As Image = Nothing
    Private imgByteArray As Byte() = Nothing
    Private imgMemoryStream As IO.MemoryStream

    Private Sub btnnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnSave.Click
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

    Private Sub btnfBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfBrowse.Click
        btnfSave.Enabled = False
        tboPath.Clear()
        lblFiles.Text = ""

        Dim open As New FolderBrowserDialog
        open.SelectedPath = pathIcon
        open.ShowNewFolderButton = False

        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strPath As String = open.SelectedPath
            Dim arrFile() As String = IO.Directory.GetFiles(strPath, "*.png")
            lboFilenames.Items.Clear()
            lboFilenames.Items.AddRange(arrFile)
            tboPath.Text = strPath
            lblFiles.Text = lboFilenames.Items.Count & " files"
            btnfSave.Enabled = True
        End If
    End Sub

    Private Sub btnfSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfSave.Click
        Me.Cursor = Cursors.WaitCursor
        Dim strList As New List(Of String)
            Dim retval As Boolean = False
            For Each Str As String In lboFilenames.Items
                img = Image.FromFile(Str)
                imgMemoryStream = New IO.MemoryStream()
                If Str.Contains("png") Then
                    img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
                End If
                imgByteArray = imgMemoryStream.GetBuffer()

                Dim sqls As New SQLs(dbstring)
                Dim idimages As String = GenerateGUID()
                Dim dtsql As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)

                field.AddRange(New String() {"idiconmenu", "datetime", "filename", "sizewidth", "sizeheight", "imagesicon"})
                value.AddRange(New Object() {idimages, nowTime, Str, img.Size.Width, img.Size.Height, imgByteArray})
                dtsql.datasetSave("sys_iconmenu", idimages, field, value, False)

                If retval = False Then
                    strList.Add(IO.Path.GetFileName(Str))
                End If
                Threading.Thread.Sleep(100)
                GC.Collect()

                img.Dispose()
                imgMemoryStream.Dispose()
                img = Nothing
                imgByteArray = Nothing
                imgMemoryStream = Nothing
            Next

            If strList.Count = 0 Then
                dizmsgbox("Image telah diupload", dizMsgboxStyle.info, Me)
            Else
                Dim strTemp As String = ""
                For Each StrTmp As String In strList
                    strTemp &= strTemp & vbCrLf
                Next
                dizMsgbox("Beberapa Images gagal diupload" & vbCrLf & "Daftar File akan muncul setelah ini", dizMsgboxStyle.Peringatan, Me)
                Dim strFile As String = pathTemp & Format(nowTime, "ddMMyyyyHHmmssffff") & ".txt"
                IO.File.WriteAllText(strFile, strTemp)
                Diagnostics.Process.Start(strFile)
            End If
            Me.Cursor = Cursors.Default
            btnfSave.Enabled = False
            tboPath.Clear()
            lblFiles.Text = ""

            LoadData()
    End Sub

    Private Sub lvImages_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles lvImages.FocusedRowChanged
        Dim col As DataRow
        col = lvImages.GetFocusedDataRow
            tboDescription.Text = col("filename")
            lbliSize.Text = col("size")
    End Sub

End Class