Imports System.Data
Imports System.Data.SqlClient

Public Class StaffDVG
    Private Sub StaffDVG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select * from staff", "staffs")


        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None

        DataGridView1.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
        DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)



        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

    End Sub



    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtid.Text = iddelete
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.Close()
        attendance.txtidstaff.Text = iddelete
    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from staff where namestaff like'%" & txtempsearch.Text & "%'", "staffs")
    End Sub
End Class