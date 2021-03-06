﻿Public Class frmImagesUpload

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        PictureBox1.Image = My.Resources.defprofile200
        PictureBox1.Image.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
        imgByteArray = imgMemoryStream.GetBuffer()

        'Dim open As New OpenFileDialog
        'open.AddExtension = False
        'open.AutoUpgradeEnabled = True
        'open.CheckFileExists = True
        'open.CheckPathExists = True
        'open.DefaultExt = "jpg"
        'open.Filter = "JPG Images|*.jpg|PNG Images|*.png"
        'open.FilterIndex = 2
        'open.InitialDirectory = "D:\Developer\Riset\Desktop UI\Properties\Icons\vectory_mini\PNG"
        'open.Multiselect = False
        'open.ShowHelp = False

        'If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    TextBox1.Text = open.FileName
        '    PictureBox1.Image = Image.FromFile(TextBox1.Text)
        '    If TextBox1.Text.Contains("png") Then
        '        PictureBox1.Image.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
        '    ElseIf TextBox1.Text.Contains("jpg") Then
        '        PictureBox1.Image.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        '    End If
        '    imgByteArray = imgMemoryStream.GetBuffer()
        btnUpload.Enabled = True
        'End If
    End Sub

    Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
    Dim imgByteArray As Byte() = Nothing
    Private Sub frmIconUpload_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dbstring = readSettingFile()
        btnUpload.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub btnUpload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Dim mysqls As New SQLs(dbstring)
        mysqls.InsertImage("sys_images", "datetime,filename,sizewidth,sizeheight", "'" & Format(nowTime, "MM/dd/yyyy HH:mm:ss") & "','defPP1.png','" & PictureBox1.Image.Size.Width & "','" & PictureBox1.Image.Size.Height & "'", "images", "gambar", imgByteArray, False)
        mysqls.DMLQuery("select idimages from sys_images where replace(filename,' ','')='defPP1.png'", "getimgid")
        Dim idimages As String = mysqls.getDataSet("getimgid", 0, 0)
        'modSystem.loadData("idimages", "replace(filename,' ','')='defPP1.png'", "sys_images").Rows(0)(0)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.Clear()
        field.AddRange(New String() {"iduserimages", "idimages", "iduser", "description", "asprofile", "statusdata"})
        value.Clear()
        value.AddRange(New String() {-1, idimages, 1, "default", 1, 2})
        Dim dtsql As New dtsetSQLS(dbstring)
        dtsql.datasetSave("sys_userimages", -1, field, value, True)
        'MsgBox(sqls.InsertImage("sys_iconmenu", "datetime,filename,sizewidth,sizeheight", "'" & Format(nowTime, "MM/dd/yyyy HH:mm:ss") & "','" & TextBox1.Text & "','" & PictureBox1.Image.Size.Width & "','" & PictureBox1.Image.Size.Height & "'", "imagesicon", "gambar", imgByteArray, False))
        'MsgBox(modSystem.insertData("datetime|imagesicon|filename|sizewidth|sizeheight", Format(Nowtime, "") & "|@ imgByteArray|" & TextBox1.Text & "|" & PictureBox1.Size.Width & "|" & PictureBox1.Size.Height, "sys_iconmenu"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim open As New FolderBrowserDialog
        open.SelectedPath = "D:\Developer\Riset\Desktop UI\Properties\Icons\vectory_mini\PNG"
        open.ShowNewFolderButton = False

        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strPath As String = open.SelectedPath
            Dim arrFile() As String = IO.Directory.GetFiles(strPath, "*.png")
            lboFilenames.Items.Clear()
            lboFilenames.Items.AddRange(arrFile)
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor

        Dim img As Image = Nothing
        Dim retval As Boolean = False
        For Each Str As String In lboFilenames.Items
            img = Nothing
            img = Image.FromFile(Str)
            If Str.Contains("png") Then
                img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf TextBox1.Text.Contains("jpg") Then
                img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
            imgByteArray = imgMemoryStream.GetBuffer()
            Dim sqls As New SQLs(dbstring)
            retval = sqls.InsertImage("sys_iconmenu", "datetime,filename,sizewidth,sizeheight", "'" & Format(nowTime, "MM/dd/yyyy HH:mm:ss") & "','" & Str & "','" & img.Size.Width & "','" & img.Size.Height & "'", "imagesicon", "gambar", imgByteArray, False)
            If retval = False Then
                MsgBox(Str)
            End If
            Threading.Thread.Sleep(100)
            GC.Collect()
            img = Nothing
        Next
        Me.Cursor = Cursors.Default
    End Sub

End Class