
Imports System.Data.SqlClient
Public Class EmployeeRepor
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub EmployeeRepor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from Staff ", conn)
        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport5
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
        sqlobj.fillCombobox(cmbpo, "Select * from Position", "positions", "Namepos")

    End Sub

    Private Sub cmbsupp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsupp.SelectedIndexChanged
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from staff where addres ='" & cmbsupp.SelectedItem & "'", conn)
        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport5
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged

        '"select * from employee where hiredate between '" & Guna2DateTimePicker1.Value.Date & "' and '" & Guna2DateTimePicker2.Value.Date & "'"
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from staff where DOB ='" & Guna2DateTimePicker1.Value.Date & "'", conn)
        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport5
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()




    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from staff where namestaff like'%" & txtname.Text & "%'", conn)
        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport5
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub cmbpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpo.SelectedIndexChanged
        '"select * from Employee where positionno = (select positionno from Position where positionname ='" & cmbposition.SelectedItem & "')"
        Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select * from staff where idposition =  (select idposition from Position where Namepos ='" & cmbpo.SelectedItem & "')", conn)
        'cmd.Parameters.AddWithValue("n1", txtidorder.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        conn.Close()
        Dim report As New CrystalReport5
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub
End Class