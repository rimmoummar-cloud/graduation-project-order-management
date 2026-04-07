
Imports System.Data.SqlClient
Public Class drink
    Private Sub drink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from Ordersitem ", conn)
        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport8
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from Ordersitem where Delivery is not null", conn)

        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport8
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub btntable_Click(sender As Object, e As EventArgs) Handles btntable.Click
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from Ordersitem where  tableId is not null", conn)

        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport8
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from Ordersitem where OrderDate ='" & Guna2DateTimePicker1.Value.Date & "'", conn)
        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport8
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub
End Class