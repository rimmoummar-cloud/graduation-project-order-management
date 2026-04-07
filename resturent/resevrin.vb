Imports System.Threading
Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient
Public Class resevrin
    Dim tablen As Integer
    Dim sqlConnection As SqlConnection
    Dim connectionString As String = "Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True"
    'Dim employeeTable As New DataTable()
    'Dim attendanceTable As New DataTable()

    Public Property CustomerId As String

    Sub childform(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub



    Private Sub resevrin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White


        txtidcustoner.Text = CustomerId
        sqlobj.FillDGV(DataGridView1, "Select * from reservations", "reservationss")
        Dim avai = "Available"
        'sqlobj.fillCombobox(cmbtable, "Select * from tablee where statuse ='" & avai & "' ", "tables", "tableId")

        'Dim id As Integer = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value

        'DataGridView1.Visible = True




        'Dim conn As New SqlConnection("Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True")
        'Dim query As String = "select i.nameItem,  o.quantity, o.price from Orders o, Item i where o.IdItem = i.IdItem and o.OrderitemID = @id"

        'Dim cmd As New SqlCommand(query, conn)
        'cmd.Parameters.AddWithValue("@id", id)

        'Dim adapter As New SqlDataAdapter(cmd)
        'Dim table As New DataTable()
        'adapter.Fill(table)
        'dgv2.DataSource = table









    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim customer As String = txtidcustoner.Text

        If txttable.Text = "" Then
            MessageBox.Show("Please select an table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txttable.Focus()
            Exit Sub
        End If

        If datereserve.Value = Nothing Then
            MessageBox.Show("Please select a date .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            datereserve.Focus()
            Exit Sub
        End If
        If timereservdeg.Value = Nothing Then
            MessageBox.Show("Please enter a time .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            timereservdeg.Focus()
            Exit Sub
        End If



        If Not Class1.IsNumericOnly(customer) Then
            MessageBox.Show("❌ Enter in  customer id only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If customer = "" Then
            MessageBox.Show("Please enter  customer id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtidcustoner.Focus()
            Exit Sub
        End If



        If con.State = ConnectionState.Closed Then
            con.Open()

        End If



        Dim qry As New SqlCommand("select namecutomer from customer where Idcustomer = " & txtidcustoner.Text, con)
        Dim qry1 As String = qry.ExecuteScalar()

        con.Close()



        sqlobj.InsertStatement("insert into reservations (Idcustomer,tableId,datereser,timebegin,timeend,customername) values ('" & txtidcustoner.Text & "','" & txttable.Text & "','" & datereserve.Value & "','" & timereservdeg.Value & "','" & timereservend.Value & "','" & qry1 & "')")

        If con.State = ConnectionState.Closed Then
            con.Open()

        End If

        Dim cdmm2 As New SqlCommand("select max(reservationId) As maxId2 from reservations ", con)
        Dim maxId2 As Integer = Convert.ToInt32(cdmm2.ExecuteScalar())

        con.Close()
        Dim avai = "Unavailable"
        sqlobj.UpdateStatement("update tablee set statuse='" & avai & "' , ReservationNo = '" & maxId2 & "'  where tableId=" & txttable.Text)



        dst.Clear()

        txttable.Clear()

        resevrin_Load(Nothing, Nothing)

    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        customer.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim nn As Integer = txttable.Text
        Dim nnn As Integer = 0
        If nn <> tablen Then
            Dim avai1 = "Available"

            sqlobj.UpdateStatement("update tablee set statuse='" & avai1 & "' , ReservationNo = '" & nnn & "'  where tableId=" & tablen)
            Dim avai = "Unavailable"

            sqlobj.UpdateStatement("update tablee set statuse='" & avai & "' , ReservationNo = '" & txtidreserv.Text & "'  where tableId=" & txttable.Text)

        End If





        Dim customer As String = txtidcustoner.Text

        If txttable.Text = "" Then
            MessageBox.Show("Please select an table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txttable.Focus()
            Exit Sub
        End If

        If datereserve.Value = Nothing Then
                MessageBox.Show("Please select a date .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                datereserve.Focus()
                Exit Sub
            End If
            If timereservdeg.Value = Nothing Then
                MessageBox.Show("Please enter a time .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                timereservdeg.Focus()
                Exit Sub
            End If



            If Not Class1.IsNumericOnly(customer) Then
                MessageBox.Show("❌ Enter in  customer id only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If customer = "" Then
                MessageBox.Show("Please enter  customer id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtidcustoner.Focus()
                Exit Sub
            End If



            Try
                ' Get the selected row in the DataGridView
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Get the data from the selected row
                Dim reser As Integer = Convert.ToInt32(selectedRow.Cells(2).Value)
                Dim customer1 As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)
            'Dim status As String = If(rdbabscent.Checked, "Absent", "Present")
            Dim table As Object = If(txttable.Text IsNot Nothing, txttable.Text, DBNull.Value)
            Dim timeIn As TimeSpan = timereservdeg.Value.TimeOfDay
                Dim timeOut As TimeSpan = timereservend.Value.TimeOfDay

                ' Check if time out is greater than time in
                If timeOut > timeIn Then
                    Dim timeInString As String = timeIn.ToString("hh\:mm\:ss") ' Format as "hh:mm:ss"
                    Dim timeOutString As String = timeOut.ToString("hh\:mm\:ss") ' Format as "hh:mm:ss"

                    ' Update the database with the modified attendance data
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()
                        Dim updateQuery As String = "UPDATE reservations SET tableId = @tableId,Idcustomer = @Idcustomer, timeend = @timeend, timebegin = @timebegin WHERE reservationId = @reservationId"
                        Using cmd As New SqlCommand(updateQuery, connection)
                            cmd.Parameters.AddWithValue("@tableId", table)
                            'cmd.Parameters.AddWithValue("@reason", reason)
                            cmd.Parameters.AddWithValue("@timebegin", timeInString)
                            cmd.Parameters.AddWithValue("@timeend", timeOutString)
                            cmd.Parameters.AddWithValue("@Idcustomer", customer1)
                            cmd.Parameters.AddWithValue("@reservationId", reser)

                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Update the DataGridView with the changes
                    selectedRow.Cells(1).Value = table
                    'selectedRow.Cells("Reason").Value = reason
                    selectedRow.Cells(4).Value = timeIn.ToString()
                selectedRow.Cells(3).Value = timeOut.ToString()
                If con.State = ConnectionState.Closed Then
                    con.Open()

                End If



                Dim qry As New SqlCommand("select namecutomer from customer where Idcustomer = " & txtidcustoner.Text, con)
                Dim qry1 As String = qry.ExecuteScalar()

                con.Close()
                sqlobj.UpdateStatement("update reservations set customername='" & qry1 & "'  where reservationId=" & txtidreserv.Text)
                sqlobj.UpdateStatement("update reservations set Idcustomer ='" & txtidcustoner.Text & "'  where reservationId=" & txtidreserv.Text)
                resevrin_Load(Nothing, Nothing)
                ' Show success message
                'Dim msgbox As New MsgBox("Information ", "Changes applied successfully. ", My.Resources.acceptticon)
                'msgbox.ShowDialog()
                MessageBox.Show("Changes applied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtidcustoner.Clear()
                    txtidreserv.Clear()
                txttable.Clear()

                datereserve.Value = Date.Now
                    timereservend.Value = DateTime.Now
                    timereservdeg.Value = DateTime.Now

                Else
                    ' Show error message if time out is not greater than time in
                    'Dim msgbox As New MsgBox("Error ", "Time Out must be greater than Time In. ", My.Resources.failedicon)
                    'msgbox.ShowDialog()
                    MessageBox.Show("Time Out must be greater than Time In.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



        'sqlobj.UpdateStatement("update reservations set Idcustomer='" & txtidcustoner.Text & "', tableId = '" & cmbtable.SelectedItem & "',  reservationdate='" & datereserve.Value & "',  reservationtime='" & timereserv.Value & "'  where reservationId=" & txtidreserv.Text)
        'dst.Clear()

        'resevrin_Load(Nothing, Nothing)
    End Sub





    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value
        txtidreserv.Text = iddelete

        txtidcustoner.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txttable.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        tablen = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        Dim startdayy As String = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value.ToString()
        Dim starttime As TimeSpan = TimeSpan.ParseExact(startdayy, "hh\:mm\:ss", CultureInfo.InvariantCulture)
        timereservend.Value = DateTime.Today.Add(starttime)


        Dim end1 As String = Me.DataGridView1(4, Me.DataGridView1.CurrentRow.Index).Value.ToString()
        Dim end2 As TimeSpan = TimeSpan.ParseExact(end1, "hh\:mm\:ss", CultureInfo.InvariantCulture)
        timereservdeg.Value = DateTime.Today.Add(end2)

        'timereservend.Value = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value
        'timereservdeg.Value = Me.DataGridView1(4, Me.DataGridView1.CurrentRow.Index).Value
        datereserve.Value = Me.DataGridView1(5, Me.DataGridView1.CurrentRow.Index).Value

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        uptable2.Show()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim avai = "Available"
        Dim n As Integer = 0

        sqlobj.UpdateStatement("update tablee set statuse='" & avai & "' , ReservationNo = '" & n & "'  where tableId=" & txttable.Text)

        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from reservations where reservationId=" & iddelete)
            dst.Clear()

            resevrin_Load(Nothing, Nothing)

        End If

        txttable.Clear()
        txtidreserv.Clear()


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    'Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
    '    Dim avai = "Available"
    '    Dim n As Integer = 0

    '    sqlobj.UpdateStatement("update tablee set statuse='" & avai & "' , ReservationNo = '" & n & "'  where tableId=" & cmbtable.SelectedItem)

    '    If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
    '        sqlobj.DeleteStatement(" delete from reservations where reservationId=" & iddelete)
    '        dst.Clear()

    '        resevrin_Load(Nothing, Nothing)

    '    End If

    '    cmbtable.Items.Clear()

    'End Sub


End Class