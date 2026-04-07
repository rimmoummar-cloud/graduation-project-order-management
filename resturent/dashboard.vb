Imports System.Data.SqlClient
Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If con.State = ConnectionState.Closed Then
            con.Open()



        End If


        Dim salarysum As New SqlCommand("select count(OrderitemID)  from Ordersitem", con)
        Dim salarysum1 As Integer = Convert.ToInt32(salarysum.ExecuteScalar())
        lblorders.Text = salarysum1


        Dim salarysum2 As New SqlCommand("select count(Idcustomer)  from customer", con)
        Dim salarysum3 As Integer = Convert.ToInt32(salarysum2.ExecuteScalar())
        lblcustomer.Text = salarysum3


        Dim salarysum4 As New SqlCommand("select sum(TotalPrice)  from Ordersitem", con)
        Dim salarysum5 As Integer = Convert.ToInt32(salarysum4.ExecuteScalar())
        lblsales.Text = salarysum5


        Dim salarysum41 As New SqlCommand("select count(IdStaff)  from staff  where idposition = 6", con)
        Dim salarysum51 As Integer = Convert.ToInt32(salarysum41.ExecuteScalar())
        lblchef.Text = salarysum51


        Dim salarysum42 As New SqlCommand("select count(IdStaff)  from staff  where idposition = 3", con)
        Dim salarysum52 As Integer = Convert.ToInt32(salarysum42.ExecuteScalar())
        lblaccount.Text = salarysum52


        Dim salarysum43 As New SqlCommand("select count(IdStaff)  from staff  where idposition = 5", con)
        Dim salarysum53 As Integer = Convert.ToInt32(salarysum43.ExecuteScalar())
        lbldile.Text = salarysum53

        Dim salarysum44 As New SqlCommand("select count(OrderitemID)  from Ordersitem  where Delivery  is not null", con)
        Dim salarysum54 As Integer = Convert.ToInt32(salarysum44.ExecuteScalar())
        lblorderdil.Text = salarysum54


        Dim salarysum45 As New SqlCommand("select count(OrderitemID)  from Ordersitem  where tableId  is not null", con)
        Dim salarysum55 As Integer = Convert.ToInt32(salarysum45.ExecuteScalar())
        lblordertable.Text = salarysum55 + 2


        '"Select OrderitemID,CustomerID,OrderDate,TotalPrice,offer,Delivery from Ordersitem where Delivery is not null "









    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
End Class