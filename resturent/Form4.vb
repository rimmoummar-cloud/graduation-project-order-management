Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Form4

    Private Sub dateend_ValueChanged(sender As Object, e As EventArgs) Handles dateend.ValueChanged


        If con.State = ConnectionState.Closed Then
            con.Open()



        End If


        Dim salarysum As New SqlCommand("select sum(salary) as [Employee Salary] from staff", con)
        Dim salarysum1 As Integer = Convert.ToInt32(salarysum.ExecuteScalar())
        txtsalary.Text = salarysum1


        Dim totalpayment As New SqlCommand("select sum(totalprice) as [Total payment] from RawMaterials where dateorder between '" & datestart.Value & "' and '" & dateend.Value & "'", con)
        Dim totalpayment1 As Object = totalpayment.ExecuteScalar()
        Dim num As Integer = 0
        If totalpayment1 IsNot Nothing AndAlso Not IsDBNull(totalpayment1) Then
            num = Convert.ToInt32(totalpayment1)
            txtsupp.Text = num
        Else
            txtsupp.Text = 1
        End If



        Dim totalorder As New SqlCommand("select sum(TotalPrice) as [Total order] from Ordersitem where OrderDate between '" & datestart.Value & "' and '" & dateend.Value & "'", con)
        Dim totalorder1 As Object = totalorder.ExecuteScalar()
        Dim num1 As Integer = 0
        If totalorder1 IsNot Nothing AndAlso Not IsDBNull(totalorder1) Then
            num1 = Convert.ToInt32(totalorder1)
            txtorder.Text = num1
        Else
            txtorder.Text = 0
        End If

        Dim totorder As Integer = txtorder.Text
        Dim payy As Integer = txtsupp.Text
        Dim sal As Integer = txtsalary.Text
        Dim res As Integer = totorder - (payy + sal)
        txtresult.Text = res

        con.Close()
        Chart1.Series.Clear()

        Dim series As New Series("profit/loss")
        series.Points.AddXY("Employee's Salaries", txtsalary.Text)
        series.Points.AddXY("Total Orders", txtorder.Text)
        series.Points.AddXY("Supplier's Expenses", txtsupp.Text)
        series.Points.AddXY("Result", txtresult.Text)

        series.ChartType = SeriesChartType.Column
        Chart1.Series.Add(series)




        series.Points(0).Color = Color.Blue
        series.Points(1).Color = Color.Red
        series.Points(2).Color = Color.Green
        series.Points(3).Color = Color.Yellow

        If txtsalary.Text < 0 Then
            series.Points(0).Color = Color.Red
        End If

        If txtorder.Text < 0 Then
            series.Points(1).Color = Color.Red
        End If

        If txtsupp.Text < 0 Then
            series.Points(2).Color = Color.Red
        End If

        If txtresult.Text < 0 Then
            series.Points(3).Color = Color.Red
        End If









    End Sub

    Private Sub txtsave_Click(sender As Object, e As EventArgs) Handles txtsave.Click
        sqlobj.InsertStatement("insert into saveExpeness (TotalSalary,TotalPayment,totalOrder,Result,StartDate,EndDate) values ('" & txtsalary.Text & "','" & txtsupp.Text & "','" & txtorder.Text & "','" & txtresult.Text & "','" & datestart.Value & "','" & dateend.Value & "')")
        Form4_Load(Nothing, Nothing)
        Chart1.Visible = True
        'dst.Clear()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sqlobj.FillDGV(DataGridView1, "select * from saveExpeness", "saveExpenesss")
        Chart1.Visible = False
    End Sub

    'Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
    '    If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
    '        sqlobj.DeleteStatement(" delete from saveExpeness where idsave=" & ID.Text)
    '        'dst.Clear()
    '        'cmbcat.Items.Clear()
    '        ''cmboffer.Items.Clear()
    '        'txtitemname.Text = ""
    '        'txtprice.Text = ""
    '        'txtno.Text = ""
    '        Form4_Load(Nothing, Nothing)


    '    End If
    'End Sub


    'Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
    '    ID.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
    'End Sub
End Class