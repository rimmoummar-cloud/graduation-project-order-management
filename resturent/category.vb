Public Class category
    Sub clearr()
        txtid.Text = ""

        txtmenu.Text = ""

    End Sub

    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select * from category", "categorys")
    End Sub




    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtid.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtmenu.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from category where menuname like'%" & txtempsearch.Text & "%'", "categorys")
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click



        Dim name As String = txtmenu.Text

        If Not Class1.IsValidName(Name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        con.Close()


        sqlobj.InsertStatement("insert into category (menuname) values ('" & txtmenu.Text & "')")
        dst.Clear()
        clearr()
        category_Load(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click


        Dim name As String = txtmenu.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        sqlobj.UpdateStatement("update category  set menuname='" & txtmenu.Text & "' where menuId=" & txtid.Text)
        clearr()
        category_Load(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from category where menuId=" & iddelete)
            dst.Clear()

            category_Load(Nothing, Nothing)

        End If
        clearr()
    End Sub


End Class