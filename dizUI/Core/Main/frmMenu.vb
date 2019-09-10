Imports DevExpress.XtraEditors.Controls

Public Class frmMenu
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

    Private Sub frmMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadLOV()
        loadGrid()
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select i.idiconmenu,i.imagesicon,i.filename,right(replace(replace(i.filename,'\',''),':',''),22) as fakename from sys_iconmenu i order by i.idiconmenu asc", "icon")
        ilicon.Images.Clear()
        iicIcon.AutoHeight = True
        iicIcon.LargeImages = ilicon
        iicIcon.SmallImages = ilicon
        Dim img As Image = Nothing
        Dim lenStr As String = ""
        For i As Integer = 0 To sqls.getDataSet("icon").ToString.Length - 1
            If i = 0 Then
                lenStr = "0"
            Else
                lenStr &= "#"
            End If
        Next
        For i As Integer = 0 To sqls.getDataSet("icon") - 1
            Dim dr As DataRow = sqls.dataTable("icon").Rows(i)
            img = Nothing
            If IO.File.Exists(dr("filename")) Then
                img = Image.FromFile(pathIcon & dr("fakename"))
                ilicon.Images.Add(i, img)

                Dim someItem As ImageComboBoxItem = New ImageComboBoxItem
                someItem.Description = CStr(dr("idiconmenu")) 'Format(CStr(dr("idiconmenu")), lenStr) 'IO.Path.GetFileNameWithoutExtension(dr("filename"))
                someItem.ImageIndex = i 'dr("idiconmenu")
                someItem.Value = dr("idiconmenu")
                'MsgBox(i & " " & dr("idiconmenu") & " " & someItem.Description)
                iicIcon.Items.Add(someItem)
            End If
        Next
        'MsgBox(sqls.getDataSet("icon"))
        'MsgBox(ilicon.Images.Count)
        iicIcon.Sorted = True

        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select gc.idgeneral as id,gc.generalcode as content from sys_generalcode gc where gc.gctype='ASDIALOG' order by gc.idgeneral asc", "dialog")

        lueDialog.DataSource = mys.dataTable("dialog")
        lueDialog.BestFitMode = BestFitMode.BestFitResizePopup
            lueDialog.BestFit()

            lueDialog.ValueMember = "id"
            lueDialog.DisplayMember = "content"
        lueDialog.TextEditStyle = TextEditStyles.Standard

        icbFrmName.Items.Add("-")
        Dim col As New Generic.List(Of Type)
        Dim list() As System.Reflection.Assembly = AppDomain.CurrentDomain.GetAssemblies
        Dim projectname As String = My.Application.Info.AssemblyName
        For Each asm As Reflection.Assembly In list
            Dim types() As Type = asm.GetTypes()
            For Each t As Type In types
                If t.BaseType Is GetType(Windows.Forms.Form) Then
                    If t.ToString.Contains(projectname) Then
                        icbFrmName.Items.Add(t.ToString.Remove(0, projectname.Length + 1))
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select s.idmenu,s.idparent,s.idiconmenu,s.frmname,s.menuname,s.description,s.asdialog from sys_menu s order by s.idmenu asc, s.idparent asc", "data")
        tlData.DataSource = sqls.dataTable("data")
        tlData.ParentFieldName = "idparent"
        tlData.KeyFieldName = "idmenu"
        tlData.ExpandAll()
        tlData.BestFitVisibleOnly = True
        tlData.BestFitColumns()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        For Each ctrl As DevExpress.XtraTreeList.Nodes.TreeListNode In tlData.Nodes
            Dim dr As DataRow = tlData.GetDataRecordByNode(ctrl)
            'MsgBox(dr("frmname"))
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

    End Sub

End Class