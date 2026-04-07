Imports System.Data
Imports System.Data.SqlClient
Public Class position
    Sub clearr()
        txtpos.Text = ""
        txtid.Text = ""
        txtdis.Text = ""
    End Sub
    Private Sub position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select * from Position", "positions")
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "PositionName"
        DataGridView1.Columns(2).HeaderText = "Desicription"

    End Sub







    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtid.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtpos.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        txtdis.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim name As String = txtpos.Text
        Dim dis As String = txtdis.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Class1.IsValidName(dis) Then
            MessageBox.Show("❌The discription is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If








        sqlobj.InsertStatement("insert into Position  (Namepos,DesPos) values ('" & txtpos.Text & "','" & txtdis.Text & "')")
        position_Load(Nothing, Nothing)

        clearr()

    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim name As String = txtpos.Text
        Dim dis As String = txtdis.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Class1.IsValidName(dis) Then
            MessageBox.Show("❌The discription is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If






        sqlobj.UpdateStatement("update Position  set Namepos='" & txtpos.Text & "', DesPos ='" & txtdis.Text & "' where idposition=" & txtid.Text)
        position_Load(Nothing, Nothing)
        clearr()

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from Position where idposition=" & iddelete)
        End If
        position_Load(Nothing, Nothing)
        clearr()
    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from Position where Namepos like'%" & txtempsearch.Text & "%'", "positions")
    End Sub


End Class