Imports System.Data
Imports System.Data.SqlClient

Public Class Allmenu
    Private Sub Allmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.fillCombobox(cmbcat, "Select menuname from category  ", "categorys", "menuname")
        sqlobj.FillDGV(DataGridView1, "select * from Item ", "Items")
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeight = 90


        'DataGridView1.Visible = False
    End Sub

    Private Sub cmbcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcat.SelectedIndexChanged

        'DataGridView1.Visible = True
        If con.State = ConnectionState.Closed Then
            con.Open()




        End If


        Dim cdmm As New SqlCommand("select menuId from category where menuname='" & cmbcat.SelectedItem & "'", con)
        Dim cat As Integer = Convert.ToInt32(cdmm.ExecuteScalar())
        sqlobj.FillDGV(DataGridView1, "select * from Item where menuId =" & cat, "Items")

        con.Close()




    End Sub
End Class