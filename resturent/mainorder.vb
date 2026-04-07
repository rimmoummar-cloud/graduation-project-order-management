Imports System.Data
Imports System.Data.SqlClient
Public Class mainorder


    'Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
    '    sqlobj.FillDGV(dgv, "Select * from Ordersitem", "Ordersitems")
    '    btndiv.Visible = True
    '    btntable.Visible = True

    'End Sub

    Private Sub mainorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(dgv, "Select * from Ordersitem", "Ordersitems")
        btndiv.Visible = True
        btntable.Visible = True
        Label1.Visible = False


        dgv2.Visible = False

        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv.RowHeadersVisible = False
        dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
        dgv.BorderStyle = BorderStyle.None
        dgv.ColumnHeadersHeight = 90


        dgv2.EnableHeadersVisualStyles = False
        dgv2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        dgv2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv2.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv2.RowHeadersVisible = False
        dgv2.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
        dgv2.BorderStyle = BorderStyle.None
        dgv2.ColumnHeadersHeight = 90








    End Sub


    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick

        Dim id As Integer = Me.dgv(0, Me.dgv.CurrentRow.Index).Value

        dgv2.Visible = True




        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        Dim query As String = "select i.nameItem,  o.quantity, o.price from Orders o, Item i where o.IdItem = i.IdItem and o.OrderitemID = @id"

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", id)

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgv2.DataSource = table




    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        Label1.Visible = True
        dgv.Visible = True
        sqlobj.FillDGV(dgv, "Select OrderitemID,CustomerID,OrderDate,TotalPrice,offer,Delivery from Ordersitem where Delivery is not null ", "Ordersitems")
    End Sub

    Private Sub btntable_Click(sender As Object, e As EventArgs) Handles btntable.Click
        Label1.Visible = True
        dgv.Visible = True
        sqlobj.FillDGV(dgv, "Select OrderitemID,CustomerID,OrderDate,TotalPrice,offer,tableId from Ordersitem where tableId is not null ", "Ordersitems")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    'Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
    '    Label1.Visible = False
    '    btndiv.Visible = False
    '    btntable.Visible = False
    '    dgv.Visible = True
    '    dgv2.Visible = False
    '    sqlobj.FillDGV(dgv, "Select * from delivery", "deliverys")
    'End Sub


End Class