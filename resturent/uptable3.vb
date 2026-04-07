Public Class uptable3
    Dim pos As Integer
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        pos = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
    End Sub



    Private Sub uptable3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        sqlobj.FillDGV(DataGridView1, "select tableId,Capacity,ReservationNo from tablee where  ReservationNo <> 0 ", "tablees")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        orders.txttable.Text = pos
        Me.Hide()

    End Sub
End Class