Imports DevExpress.XtraEditors

Public Class frmSelectDevice

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        'If Me.WindowState = FormWindowState.Normal Then
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        'End If
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        bclose = False
        Me.Close()
    End Sub

    Dim imgBack As Image
    Dim it As DevExpress.XtraEditors.TileItem
    Private Sub createMenu()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select dl.iddevicelokasi,d.device,d.ipaddress,d.sharename,l.nama from sys_device d inner join devicelokasi dl on d.iddevice=dl.iddevice inner join lokasi l on dl.idlokasi=l.idlokasi where l.isdeleted=0 and dl.isdeleted=0", "printerlist")
        Dim ig As DevExpress.XtraEditors.TileGroup = Nothing
        ig = New DevExpress.XtraEditors.TileGroup
        ig.Name = "A"
        tcData.Groups.Add(ig)
        Dim cnt As Long = 1
        For Each dr As DataRow In sqls.dataTable("printerlist").Rows

            it = New DevExpress.XtraEditors.TileItem
            it.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always

            it.Image = Nothing
            it.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
            it.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            it.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Right

            it.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            it.BackgroundImage = My.Resources.tileSmall
            it.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            it.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside

            Dim elementDescription As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            elementDescription.Text = dr("device").ToString
            elementDescription.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft

            it.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 11.0!, FontStyle.Regular)
            it.AppearanceItem.Normal.ForeColor = Color.FromArgb(66, 66, 66)
            it.AppearanceItem.Normal.BorderColor = Color.OrangeRed
            it.AppearanceItem.Normal.Options.UseFont = True
            it.AppearanceItem.Normal.Options.UseBorderColor = True
            it.AppearanceItem.Normal.Options.UseBackColor = True
            it.AppearanceItem.Normal.Options.UseForeColor = True
            it.AppearanceItem.Normal.Options.UseTextOptions = True

            it.AppearanceItem.Hovered.Font = New System.Drawing.Font("Tahoma", 11.0!, FontStyle.Bold)
            it.AppearanceItem.Hovered.Options.UseFont = True
            it.AppearanceItem.Hovered.Options.UseBorderColor = True
            it.AppearanceItem.Hovered.Options.UseBackColor = True
            it.AppearanceItem.Hovered.Options.UseForeColor = True
            it.AppearanceItem.Hovered.Options.UseTextOptions = True

            it.AppearanceItem.Hovered.BackColor = Color.FromArgb(255, 255, 255)
            it.AppearanceItem.Hovered.ForeColor = Color.OrangeRed
            it.AppearanceItem.Hovered.BorderColor = Color.Purple

            it.Text = dr("device").ToString
            it.Id = cnt
            it.Name = dr("iddevicelokasi").ToString 'dsete.Tables(0).Rows(i).Item("nm_menu").ToString
            it.Tag = dr("sharename").ToString
            it.Elements.Add(elementDescription)
            it.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always
            it.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft

            tcData.Groups(0).Items.Add(it)
            cnt += 1
        Next
    End Sub

    Private Sub frmSelectDevice_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbDefault.Checked = True
        createMenu()
    End Sub

    Private devname As String = ""
    Public ReadOnly Property getdevicename() As String
        Get
            Return devname
        End Get
    End Property

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If devname = "" Then
            bclose = True
            dizMsgbox("Belum memilih device", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        Else
            bclose = False
            Me.Close()
        End If
    End Sub

    Private Sub tcData_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles tcData.ItemClick
        devname = e.Item.Tag
    End Sub

    Private Sub tcData_ItemCheckedChanged(sender As Object, e As TileItemEventArgs) Handles tcData.ItemCheckedChanged
        devname = e.Item.Tag
    End Sub

    Private Sub cbDefault_CheckedChanged(sender As Object, e As EventArgs) Handles cbDefault.CheckedChanged
        If cbDefault.Checked = False Then
            cbDefault.Text = "Non Aktif"
        Else
            cbDefault.Text = "Aktif"
        End If
    End Sub

    Dim bclose As Boolean = True
    Private Sub frmSelectDevice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = bclose
    End Sub

End Class