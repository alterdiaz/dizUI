Public Class Form1

    Dim createdtmp As String = "ALTER TABLE dbo.#namatabel# ADD createdbytmp varchar(50) DEFAULT 0 NOT NULL"
    Dim updatedtmp As String = "ALTER TABLE dbo.#namatabel# ADD updatedbytmp varchar(50) NULL"
    Dim cekcrt As String = "select c.table_name,c.column_name from information_schema.columns c where c.column_name='createdby'"
    Dim cekupd As String = "select c.table_name,c.column_name from information_schema.columns c where c.column_name='updatedby'"
    Dim cektmpcrt As String = "select c.table_name,c.column_name from information_schema.columns c where c.column_name='createdbytmp'"
    Dim cektmpupd As String = "select c.table_name,c.column_name from information_schema.columns c where c.column_name='updatedbytmp'"
    Dim tmp As String = "ALTER TABLE dbo.#namatabel# ADD #namakolom#tmp varchar(50) NULL"
    Dim cektmp As String = "select c.table_name,c.column_name from information_schema.columns c where c.column_name='#namakolom#'"
    Dim cekcrttmp As String = "select c.table_name,c.column_name from information_schema.columns c where c.column_name='createdbytmp' and c.table_name='#namatabel#'"
    Dim cekupdtmp As String = "select c.table_name,c.column_name from information_schema.columns c where c.column_name='updatedbytmp' and c.table_name='#namatabel#'"
    Dim updateval As String = "update wi set wi.createdbytmp=us.idtmp from #namatabel# wi inner join sys_user us on wi.createdby=us.iduser"
    Dim dbstring As String = "POS216|127.0.0.1||1433|dbo|sa|sa"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(cekcrt, "allcrt")
        For i As Integer = 0 To sqls.getDataSet("allcrt") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("allcrt", i, "table_name")
            Dim tmpcrt As String = cekcrttmp.Replace("#namatabel#", nmtbl)
            sqls1.DMLQuery(tmpcrt, "cekcrt")
            If sqls1.getDataSet("cekcrt") = 0 Then
                tmpcrt = createdtmp.Replace("#namatabel#", nmtbl)
                sqls1.DMLQuery(tmpcrt, False)
            End If
            Label1.Text = "Cek Createdby " & i
            Threading.Thread.Sleep(500)
        Next

        sqls.DMLQuery(cekupd, "allupd")
        For i As Integer = 0 To sqls.getDataSet("allupd") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("allupd", i, "table_name")
            Dim tmpupd As String = cekupdtmp.Replace("#namatabel#", nmtbl)
            sqls1.DMLQuery(tmpupd, "cekupd")
            If sqls1.getDataSet("cekupd") = 0 Then
                tmpupd = updatedtmp.Replace("#namatabel#", nmtbl)
                sqls1.DMLQuery(tmpupd, False)

                tmpupd = updateval.Replace("#namatabel#", nmtbl)
                sqls1.DMLQuery(tmpupd, False)
            End If
            Label1.Text = "Cek updatedby " & i
            Threading.Thread.Sleep(500)
        Next
    End Sub

    Dim cekconstr As String = "SELECT OBJECT_NAME(PARENT_OBJECT_ID) AS TABLE_NAME,COL_NAME(PARENT_OBJECT_ID, PARENT_COLUMN_ID) AS COLUMN_NAME,NAME AS DEFAULT_CONSTRAINT_NAME FROM SYS.DEFAULT_CONSTRAINTS where OBJECT_NAME(PARENT_OBJECT_ID)='#namatabel#' and COL_NAME(PARENT_OBJECT_ID, PARENT_COLUMN_ID)='#namakolom#' and definition<>'(CONVERT([varchar](50),newid(),0))'"
    Dim cekconstr2 As String = "SELECT OBJECT_NAME(PARENT_OBJECT_ID) AS TABLE_NAME,COL_NAME(PARENT_OBJECT_ID, PARENT_COLUMN_ID) AS COLUMN_NAME,NAME AS DEFAULT_CONSTRAINT_NAME FROM SYS.DEFAULT_CONSTRAINTS where OBJECT_NAME(PARENT_OBJECT_ID)='#namatabel#' and COL_NAME(PARENT_OBJECT_ID, PARENT_COLUMN_ID)='#namakolom#'"
    Dim dropconstr As String = "ALTER TABLE dbo.#namatabel# DROP CONSTRAINT #namaconstr#"
    Dim renkolom As String = "EXEC sp_rename 'dbo.#namatabel#.#namakolom#', '#namakolom2#', 'COLUMN'"
    Dim dropkolom As String = "ALTER TABLE dbo.#namatabel# DROP COLUMN #namakolom#"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tmpstr As String = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(cektmpcrt, "allcrttmp")
        For i As Integer = 0 To sqls.getDataSet("allcrttmp") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("allcrttmp", i, "table_name")

            tmpstr = ""
            tmpstr = cekconstr.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "createdby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)

                tmpstr = ""
                tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namakolom#", "createdby")
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AB " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "createdbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "createdby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur C " & i
            Threading.Thread.Sleep(500)
        Next

        sqls.DMLQuery(cektmpupd, "alltmpupd")
        For i As Integer = 0 To sqls.getDataSet("alltmpupd") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("alltmpupd", i, "table_name")

            tmpstr = ""
            tmpstr = cekconstr2.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "updatedby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "updatedby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur AB " & i
            Threading.Thread.Sleep(500)

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "updatedbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "updatedby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur D " & i
            Threading.Thread.Sleep(500)
        Next

        tmpstr = ""
        tmpstr = cektmp.Replace("#namakolom#", "reviewedby")
        sqls.DMLQuery(tmpstr, "alltmprev")
        For i As Integer = 0 To sqls.getDataSet("alltmprev") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("alltmprev", i, "table_name")
            tmpstr = ""
            tmpstr = cekconstr2.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "reviewedby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "reviewedby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur AB " & i
            Threading.Thread.Sleep(500)

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "reviewedbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "reviewedby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur V " & i
            Threading.Thread.Sleep(500)
        Next

        tmpstr = ""
        tmpstr = cektmp.Replace("#namakolom#", "respondby")
        sqls.DMLQuery(tmpstr, "alltmpres")
        For i As Integer = 0 To sqls.getDataSet("alltmpres") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("alltmpres", i, "table_name")
            tmpstr = ""
            tmpstr = cekconstr2.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "respondby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "respondby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur AB " & i
            Threading.Thread.Sleep(500)

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "respondbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "respondby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur V " & i
            Threading.Thread.Sleep(500)
        Next

        tmpstr = ""
        tmpstr = cektmp.Replace("#namakolom#", "preparedby")
        sqls.DMLQuery(tmpstr, "alltmprep")
        For i As Integer = 0 To sqls.getDataSet("alltmprep") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("alltmprep", i, "table_name")
            tmpstr = ""
            tmpstr = cekconstr2.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "preparedby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "preparedby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur AB " & i
            Threading.Thread.Sleep(500)

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "preparedbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "preparedby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur V " & i
            Threading.Thread.Sleep(500)
        Next

        tmpstr = ""
        tmpstr = cektmp.Replace("#namakolom#", "lockby")
        sqls.DMLQuery(tmpstr, "alltmplock")
        For i As Integer = 0 To sqls.getDataSet("alltmplock") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("alltmplock", i, "table_name")
            tmpstr = ""
            tmpstr = cekconstr2.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "lockby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "lockby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur AB " & i
            Threading.Thread.Sleep(500)

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "lockbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "lockby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur V " & i
            Threading.Thread.Sleep(500)
        Next

        tmpstr = ""
        tmpstr = cektmp.Replace("#namakolom#", "receivedby")
        sqls.DMLQuery(tmpstr, "alltmprecv")
        For i As Integer = 0 To sqls.getDataSet("alltmprecv") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("alltmprecv", i, "table_name")
            tmpstr = ""
            tmpstr = cekconstr2.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "receivedby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "receivedby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur AB " & i
            Threading.Thread.Sleep(500)

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "receivedbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "receivedby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur V " & i
            Threading.Thread.Sleep(500)
        Next

        tmpstr = ""
        tmpstr = cektmp.Replace("#namakolom#", "lastby")
        sqls.DMLQuery(tmpstr, "alltmplast")
        For i As Integer = 0 To sqls.getDataSet("alltmplast") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("alltmplast", i, "table_name")
            tmpstr = ""
            tmpstr = cekconstr2.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "lastby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "lastby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur AB " & i
            Threading.Thread.Sleep(500)

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "lastbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "lastby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur V " & i
            Threading.Thread.Sleep(500)
        Next

        tmpstr = ""
        tmpstr = cektmp.Replace("#namakolom#", "forwardby")
        sqls.DMLQuery(tmpstr, "alltmpfor")
        For i As Integer = 0 To sqls.getDataSet("alltmpfor") - 1
            Dim sqls1 As New SQLs(dbstring)
            Dim nmtbl As String = sqls.getDataSet("alltmpfor", i, "table_name")
            tmpstr = ""
            tmpstr = cekconstr2.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "forwardby")
            sqls1.DMLQuery(tmpstr, "cekconstr")
            Label1.Text = "Restruktur A " & i
            Threading.Thread.Sleep(500)

            If sqls1.getDataSet("cekconstr") > 0 Then
                Dim nmcnstr As String = sqls1.getDataSet("cekconstr", 0, "DEFAULT_CONSTRAINT_NAME")

                tmpstr = ""
                tmpstr = dropconstr.Replace("#namatabel#", nmtbl)
                tmpstr = tmpstr.Replace("#namaconstr#", nmcnstr)
                sqls1.DMLQuery(tmpstr, False)
                Label1.Text = "Restruktur AA " & i
                Threading.Thread.Sleep(500)
            End If

            tmpstr = ""
            tmpstr = dropkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "forwardby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur AB " & i
            Threading.Thread.Sleep(500)

            tmpstr = ""
            tmpstr = renkolom.Replace("#namatabel#", nmtbl)
            tmpstr = tmpstr.Replace("#namakolom#", "forwardbytmp")
            tmpstr = tmpstr.Replace("#namakolom2#", "forwardby")
            sqls1.DMLQuery(tmpstr, False)
            Label1.Text = "Restruktur V " & i
            Threading.Thread.Sleep(500)
        Next
    End Sub

End Class
