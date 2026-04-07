Public Class Delivery
    Private Sub Delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(dgv, "Select * from delivery", "deliverys")
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv.RowHeadersVisible = False
        dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
        dgv.BorderStyle = BorderStyle.None
        dgv.ColumnHeadersHeight = 90



    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(dgv, " select * from delivery where dates like'%" & txtempsearch.Text & "%'", "deliverys")
    End Sub
End Class