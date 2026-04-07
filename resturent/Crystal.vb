Imports System.Data.SqlClient
Public Class Crystal


    Private Sub Crystal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from Orders where OrderitemID = @n1", conn)
        cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport1
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub

    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
    '    Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
    '    conn.Open()
    '    Dim cmd As New SqlCommand("select * from Orders where OrderitemID = @n1", conn)
    '    cmd.Parameters.AddWithValue("n1", txtidorder.Text)
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim dt As New DataTable
    '    dt.Clear()
    '    da.Fill(dt)
    '    conn.Close()
    '    Dim report As New CrystalReport1
    '    report.SetDataSource(dt)
    '    CrystalReportViewer1.ReportSource = report
    '    CrystalReportViewer1.Refresh()



    'End Sub
End Class