Imports System.Data
Imports System.Data.SqlClient

Public Class orders
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        orders_Load(Nothing, Nothing)

        txttable.Visible = True

        DataGridView3.Visible = True
        lblchose.Visible = True

        PictureBox1.Visible = True
        refresh.Visible = True
        'cmboffer.Items.Clear()
        'lstcategory.Items.Clear()

    End Sub
    Private Sub orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txttotal.BorderStyle = BorderStyle.None
        cmboffer.Items.Clear()
        lstcategory.Items.Clear()

        sqlobj.fillCombobox(cmboffer, "Select * from offers where statuss = 'Active' ", "offerss", "offername")
        sqlobj.fillCombobox(cmbstuff, "Select namestaff from staff where idposition = '5' ", "staffs", "namestaff")

        sqlobj.fillListbox(lstcategory, "select menuname from category", "categorys", "menuname")
        sqlobj.FillDGV(DataGridView1, "select IdItem,nameItem,price from Item", "Items")
        DataGridView2.Columns(0).Width = 20
        DataGridView2.Columns(6).Width = 54
        DataGridView2.Columns(5).Width = 50
        cmbstuff.Visible = False
        txttable.Visible = False
        txtaddile.Visible = False
        DataGridView3.Visible = False
        lblchose.Visible = False
        lbladdres.Visible = False
        lblemp.Visible = False
        PictureBox1.Visible = False
        refresh.Visible = False
        sqlobj.FillDGV(DataGridView3, "select tableId,Capacity from tablee where statuse = 'Available' ", "tablees")
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.RowHeadersVisible = False
        DataGridView2.RowHeadersVisible = False
        'DataGridView2.GridColor = Color.Transparent
        'DataGridView1.GridColor = Color.Transparent
        DataGridView1.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
        DataGridView2.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeight = 90

        Label3.Visible = False
        PictureBox3.Visible = False


    End Sub

    Private Sub lstcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstcategory.SelectedIndexChanged
        dst.Clear()
        DataGridView1.DataSource = Nothing
        da.SelectCommand = New SqlCommand
        da.SelectCommand.CommandText = "select menuId from category where menuname='" & lstcategory.SelectedItem & "'"
        da.SelectCommand.Connection = con
        dst = New DataSet
        da.Fill(dst, "categno")
        Dim categno = dst.Tables("categno").Rows(0).Item("menuId")
        sqlobj.FillDGV(DataGridView1, "select IdItem,nameItem,price from Item where menuId =" & categno, "Items")
        sqlobj.FillDGV(DataGridView3, "select tableId,Capacity from tablee where statuse = 'Available' ", "tablees")
    End Sub



    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick


        Dim pos = DataGridView1.CurrentRow.Index
        Dim Nitem As String = DataGridView1.Rows(pos).Cells("nameItem").Value
        Dim Iprice = DataGridView1.Rows(pos).Cells("price").Value
        Dim id = DataGridView1.Rows(pos).Cells("IdItem").Value
        For i = 0 To DataGridView2.Rows.Count - 1
            If DataGridView2.Rows(i).Cells(1).Value = Nitem Then
                MsgBox("this item is  add", vbMsgBoxRight + MsgBoxStyle.Information, "|Sorry..")
                Return
            End If
        Next

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(1).Value IsNot Nothing AndAlso row.Cells(1).Value.ToString() = "Total" Then
                DataGridView2.Rows.Remove(row)
                Exit For
            End If
        Next


        'For i = 0 To DataGridView2.Rows.Count - 1
        '    Dim lastrow = DataGridView2.Rows.Count - 1
        '    If DataGridView2.Rows(i).Cells(1).Value = "Total" Then
        '        DataGridView2.Rows.RemoveAt(lastrow)

        '    End If
        'Next

        'DataGridView2.Rows.Add()
        Dim rowcount = DataGridView2.Rows.Add()
        DataGridView2.Rows(rowcount).Cells(0).Value = id
        DataGridView2.Rows(rowcount).Cells(1).Value = Nitem
        DataGridView2.Rows(rowcount).Cells(2).Value = Iprice
        DataGridView2.Rows(rowcount).Cells(3).Value = "1"
        DataGridView2.Rows(rowcount).Cells(4).Value = 1 * Iprice
        DataGridView2.Rows(rowcount).Cells(5).Value = "+"
        DataGridView2.Rows(rowcount).Cells(6).Value = "-"

        Dim total As Double = 0
        For Each row As DataGridViewRow In DataGridView2.Rows

            total += (row.Cells(4).Value)
            'total += Convert.ToDecimal(row.Cells(4).Value)
        Next

        Dim rowtotal As Integer = DataGridView2.Rows.Add()
        DataGridView2.Rows(rowtotal).Cells(1).Value = "Total"

        DataGridView2.Rows(rowtotal).Cells(4).Value = total

        DataGridView2.Rows(rowtotal).DefaultCellStyle.BackColor = Color.FromArgb(252, 115, 4)
        DataGridView2.Rows(rowtotal).DefaultCellStyle.ForeColor = Color.White
        txttotal.Text = total.ToString

        txtfinal.Text = total





        Dim net As Double
        Dim net1 As Double

        Dim sum As Double = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            sum += (row.Cells(4).Value)
        Next

        Dim total1 = sum \ 2
        Dim total3 = total1 - (total1 * (offerper / 100))

        txtfinal.Text = total3

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim pos = DataGridView2.CurrentRow.Index
        Dim oldunit As Integer = DataGridView2.Rows(pos).Cells(3).Value
        Dim price = DataGridView2.Rows(pos).Cells(2).Value
        Dim newunit As Integer

        If e.ColumnIndex = 5 Then
            newunit = oldunit + 1
            DataGridView2.Rows(pos).Cells(3).Value = newunit
            DataGridView2.Rows(pos).Cells(4).Value = newunit * price

            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(1).Value IsNot Nothing AndAlso row.Cells(1).Value.ToString() = "Total" Then
                    DataGridView2.Rows.Remove(row)
                    Exit For
                End If
            Next
            Dim total As Double = 0
            For Each row As DataGridViewRow In DataGridView2.Rows
                total += (row.Cells(4).Value)
            Next

            Dim rowtotal As Integer = DataGridView2.Rows.Add()
            DataGridView2.Rows(rowtotal).Cells(1).Value = "Total"

            DataGridView2.Rows(rowtotal).Cells(4).Value = total

            DataGridView2.Rows(rowtotal).DefaultCellStyle.BackColor = Color.FromArgb(252, 115, 4)
            DataGridView2.Rows(rowtotal).DefaultCellStyle.ForeColor = Color.White

            txttotal.Text = total.ToString

            txtfinal.Text = total



            Dim net As Double
            Dim net1 As Double

            Dim sum As Double = 0
            For Each row As DataGridViewRow In DataGridView2.Rows
                sum += (row.Cells(4).Value)
            Next

            Dim total1 = sum \ 2
            Dim total3 = total1 - (total1 * (offerper / 100))

            txtfinal.Text = total3


        End If







        If e.ColumnIndex = 6 Then
            If oldunit = 1 Then
                DataGridView2.Rows.RemoveAt(pos)

            Else
                newunit = oldunit - 1
                DataGridView2.Rows(pos).Cells(3).Value = newunit
                DataGridView2.Rows(pos).Cells(4).Value = newunit * price

            End If


            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(1).Value IsNot Nothing AndAlso row.Cells(1).Value.ToString() = "Total" Then
                    DataGridView2.Rows.Remove(row)
                    Exit For
                End If
            Next
            Dim total As Double = 0
            For Each row As DataGridViewRow In DataGridView2.Rows
                total += (row.Cells(4).Value)
            Next

            Dim rowtotal As Integer = DataGridView2.Rows.Add()
            DataGridView2.Rows(rowtotal).Cells(1).Value = "Total"

            DataGridView2.Rows(rowtotal).Cells(4).Value = total

            DataGridView2.Rows(rowtotal).DefaultCellStyle.BackColor = Color.FromArgb(252, 115, 4)
            DataGridView2.Rows(rowtotal).DefaultCellStyle.ForeColor = Color.White

            txttotal.Text = total.ToString

            txtfinal.Text = total




            Dim net As Double
            Dim net1 As Double

            Dim sum As Double = 0
            For Each row As DataGridViewRow In DataGridView2.Rows
                sum += (row.Cells(4).Value)
            Next

            Dim total1 = sum \ 2
            Dim total3 = total1 - (total1 * (offerper / 100))

            txtfinal.Text = total3

        End If




    End Sub

    Private Sub cmboffer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboffer.SelectedIndexChanged
        Module1.offerper = sqlobj.getnumber("Select discountPercentage from offers where offername = '" & cmboffer.SelectedItem & "'", "offerse", "discountPercentage")

        txtofferper.Text = Module1.offerper
        Dim sum As Double = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            sum += (row.Cells(4).Value)
        Next

        Dim total1 = sum \ 2
        Dim total3 = total1 - (total1 * (offerper / 100))

        txtfinal.Text = total3
    End Sub

    Private Sub offerper_TextChanged(sender As Object, e As EventArgs)


        If txtofferper.Text = "" Then
            txtofferper.Text = 0

        End If


        Dim net As Integer
        Dim net1 As Integer

        Dim sum As Double = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            sum += (row.Cells(4).Value)
        Next

        Dim total1 As Integer = sum \ 2
        Dim total As Integer = total1 - (total1 * (offerper / 100))

        txtfinal.Text = total





    End Sub


    Private Sub txtofferper_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        DataGridView2.Rows.Clear()
        txtfinal.Text = ""
        txtofferper.Text = ""
        txttotal.Text = ""
        'cmboffer.SelectedIndex = -1
        cmbstuff.SelectedIndex = -1
        txttable.Text = ""
        txtaddile.Text = ""

    End Sub

    Private Sub btnitem_Click(sender As Object, e As EventArgs) Handles btnitem.Click
        sqlobj.FillDGV(DataGridView1, "select IdItem,nameItem,price from Item", "Items")
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()

        form2.Show()

    End Sub

    Private Sub radiodelevary_CheckedChanged(sender As Object, e As EventArgs) Handles radiodelevary.CheckedChanged
        If radiodelevary.Checked Then
            cmbstuff.Visible = True
            txttable.Visible = False
            txtaddile.Visible = True
            DataGridView3.Visible = False
            lblchose.Visible = False
            txttable.Text = ""
            lbladdres.Visible = True
            lblemp.Visible = True
            PictureBox1.Visible = False
            refresh.Visible = False
            Label3.Visible = False
            PictureBox3.Visible = False


        End If
    End Sub

    Private Sub radiotable_CheckedChanged(sender As Object, e As EventArgs) Handles radiotable.CheckedChanged
        If radiotable.Checked Then
            cmbstuff.Visible = False
            txttable.Visible = True
            txtaddile.Visible = False
            DataGridView3.Visible = True
            lblchose.Visible = True
            lbladdres.Visible = False
            lblemp.Visible = False
            txtaddile.Text = ""
            cmbstuff.SelectedIndex = -1
            PictureBox1.Visible = False
            Label3.Visible = True
            PictureBox3.Visible = True


            refresh.Visible = False
        End If
    End Sub






    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim tableid As Integer = Me.DataGridView3(0, Me.DataGridView3.CurrentRow.Index).Value
        txttable.Text = tableid
    End Sub









    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If txtcustomer.Text = "" Then
            MessageBox.Show("Please select the  customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcustomer.Focus()
            Exit Sub
        End If


        'Dim valuee1 As Integer = Convert.ToInt32(txtfinal.Text)
        'txtfinal.Text = valuee1
        Dim status As String = ""
        Dim table As Integer = 0

        If cmboffer.SelectedIndex <> -1 Then
            offerpersent = sqlobj.getnumber("Select offerId from offers where offername= '" & cmboffer.SelectedItem & "'", "offerpersent", "offerId")

        Else


            offerpersent = 8

        End If

        If radiodelevary.Checked Then
            status = "Take Away"
            idstaff = sqlobj.getnumber("Select IdStaff from staff where namestaff= '" & cmbstuff.SelectedItem & "'", "idstaff", "IdStaff")
            sqlobj.InsertStatement("insert into delivery (dates,addres,Employee) values ('" & dateorder.Value & "','" & txtaddile.Text & "','" & idstaff & "')")


            If con.State = ConnectionState.Closed Then
                con.Open()

            End If


            Dim cdmm2 As New SqlCommand("select max(delivaryid) As maxId2 from delivery ", con)
            Dim maxId2 As Integer = Convert.ToInt32(cdmm2.ExecuteScalar())
            'Dim value As String = txtfinal.Text
            'Dim v2 As Integer = value.IndexOf(",")
            'If v2 <> -1 Then
            '    value = value.Substring(0, v2)
            'End If
            con.Close()
            sqlobj.InsertStatement("insert into Ordersitem (CustomerID,OrderDate,TotalPrice,offer,Delivery) values ('" & txtcustomer.Text & "','" & dateorder.Value & "','" & txtfinal.Text & "','" & offerpersent & "','" & maxId2 & "')")

        ElseIf radiotable.Checked Then

            table = txttable.Text
            Dim s As String = table
            status = "On Table : " + s

            'Dim value As Integer = Convert.ToInt32(txtfinal.Text)
            'Dim value As String = txtfinal.Text
            'Dim v2 As Integer = value.IndexOf(",")
            'If v2 <> -1 Then
            '    value = value.Substring(0, v2)
            'End If
            sqlobj.InsertStatement("insert into Ordersitem (CustomerID,OrderDate,TotalPrice,offer,tableId) values ('" & txtcustomer.Text & "','" & dateorder.Value & "','" & txtfinal.Text & "','" & offerpersent & "','" & txttable.Text & "')")
            'sqlobj.UpdateStatement("update staff set Email='" & txtemaill.Text & "', namestaff = '" & txtname.Text & "',  DOB='" & DateTimePicker1.Value & "',  phonenum='" & txtnum.Text & "',  addres='" & cmbadd.SelectedItem & "',  salary ='" & txtsal.Text & "', idposition =" & posnumber & "  where IdStaff=" & txtid.Text)
            Dim avai = "Unavailable"
            sqlobj.UpdateStatement("update tablee set statuse='" & avai & "'  where tableId=" & txttable.Text)



        End If


        dst.Clear()
        'txtcustomer.Text = ""



        If con.State = ConnectionState.Closed Then
            con.Open()



        End If


        Dim cdmm As New SqlCommand("select max(OrderitemID) As maxId from Ordersitem ", con)
        Dim maxId As Integer = Convert.ToInt32(cdmm.ExecuteScalar())


        con.Close()



        If con.State = ConnectionState.Closed Then
            con.Open()

        End If

        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim valuee As Integer = row.Cells(0).Value

            Dim qry As New SqlCommand("select nameItem from Item where IdItem = " & valuee, con)
            Dim qry1 As String = qry.ExecuteScalar()

            Dim per As Integer
            If txtofferper.Text = "" Then
                per = 0
            Else
                per = txtofferper.Text
            End If
            Dim per2 As Integer = Convert.ToInt32(per)
            If Not row.IsNewRow AndAlso row.Index < DataGridView2.Rows.Count - 2 Then
                Dim cdm As New SqlCommand("insert into Orders (IdItem,quantity,OrderitemID,price,ItemName,pesent,totaloffer,stutas,cutomerid) values (@IdItem,@quantity,@orderid,@price,@itemname,@persent,@total,@stat,@cutomer)", con)
                cdm.Parameters.AddWithValue("@IdItem", row.Cells(0).Value)
                cdm.Parameters.AddWithValue("@quantity", row.Cells(3).Value)
                cdm.Parameters.AddWithValue("@price", row.Cells(2).Value)
                cdm.Parameters.AddWithValue("@orderid", maxId)
                cdm.Parameters.AddWithValue("@itemname", qry1)
                cdm.Parameters.AddWithValue("@persent", per2)
                cdm.Parameters.AddWithValue("@stat", status)
                cdm.Parameters.AddWithValue("@total", txtfinal.Text)
                cdm.Parameters.AddWithValue("@cutomer", txtcustomer.Text)
                cdm.CommandType = CommandType.Text
                cdm.ExecuteNonQuery()
            End If
        Next



        con.Close()


        'Dim avai = "Unavailable"
        'sqlobj.UpdateStatement("update tablee set statuse='" & avai & "'  where tableId=" & txttable.Text)


        MessageBox.Show("done insert", "done", MessageBoxButtons.OK, MessageBoxIcon.Information)




        DataGridView2.Rows.Clear()
        txtcustomer.Text = ""
        txtfinal.Text = ""
        txtofferper.Text = ""
        txttotal.Text = ""
        'cmboffer.SelectedIndex = -1
        txttable.Text = ""
        txtaddile.Text = ""
        cmbstuff.SelectedIndex = -1
        dateorder.Value = Date.Now
        con.Open()

        Dim cdmm3 As New SqlCommand("select offer from Ordersitem where OrderitemID=" & maxId, con)

        Dim off As Integer = Convert.ToInt32(cdmm3.ExecuteScalar())
        If off = 8 Then
            Crystal.txtidorder.Text = maxId
            'Me.Hide()
            Crystal.Show()
        Else
            crystal22.txtid.Text = maxId
            'Me.Hide()
            crystal22.Show()
        End If

        con.Close()
        'Crystal.txtidorder.Text = maxId
        'Me.Hide()
        'Crystal.Show()


    End Sub



    'Private Sub Guna2GradientButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
    '    customer.Show()
    'End Sub



    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from Item where nameItem like'%" & txtempsearch.Text & "%'", "Items")
    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub lblchose_Click(sender As Object, e As EventArgs) Handles lblchose.Click
        Uptable.Show()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    orders_Load(Nothing, Nothing)

    '    txttable.Visible = True

    '    DataGridView3.Visible = True
    '    lblchose.Visible = True

    '    PictureBox1.Visible = True
    '    refresh.Visible = True
    '    cmboffer.Items.Clear()
    '    lstcategory.Items.Clear()

    'End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        customer.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        uptable3.Show()

    End Sub
End Class