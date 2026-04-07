Public Class uptable2

    Dim pos As Integer


    'Public Class Uptable
    '    Dim pos As Integer
    '    Private Sub Uptable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        sqlobj.FillDGV(DataGridView1, "select tableId,Capacity from tablee where statuse = 'Unavailable' ", "tablees")
    '    End Sub

    '    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
    '        Dim avai = "Available"
    '        sqlobj.UpdateStatement("update tablee set statuse='" & avai & "'  where tableId=" & pos)

    '    End Sub

    '    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
    '        pos = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
    '    End Sub

    '    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    '        orders.PictureBox1.Visible = True
    '        orders.refresh.Visible = True
    '        Me.Hide()

    '    End Sub


    'End Class




    Private Sub uptable2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "select tableId,Capacity from tablee where statuse = 'Available' ", "tablees")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        resevrin.txttable.Text = pos
        Me.Hide()

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        pos = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
    End Sub
End Class