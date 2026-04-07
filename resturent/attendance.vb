Imports System.Threading
Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient
Public Class attendance
    Dim sqlConnection As SqlConnection
    Dim connectionString As String = "Data Source=DESKTOP-P6D2UFD\MSSQLSERVER02;Initial Catalog=resturentSql;Integrated Security=True"
    Dim employeeTable As New DataTable()
    Dim attendanceTable As New DataTable()




    'Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
    '    staffin.Show()
    'End Sub



    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None

        DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)



        sqlobj.FillDGV(DataGridView1, "Select * from attendance ", "attendances")
    End Sub





    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick


        'txtattid.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        'iddelete = txtattid.Text  ' Save the attendance ID for later use (e.g., delete or update)
        datetoday.Value = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        Dim startdayy As String = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value.ToString()
        Dim starttime As TimeSpan = TimeSpan.ParseExact(startdayy, "hh\:mm\:ss", CultureInfo.InvariantCulture)
        chechin.Value = DateTime.Today.Add(starttime)
        Dim enddayy As String = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value.ToString()
        Dim endTime As TimeSpan = TimeSpan.ParseExact(enddayy, "hh\:mm\:ss", CultureInfo.InvariantCulture)
        chickout.Value = DateTime.Today.Add(endTime)
        cmbsat.SelectedItem = Me.DataGridView1(4, Me.DataGridView1.CurrentRow.Index).Value
        txtidstaff.Text = Me.DataGridView1(5, Me.DataGridView1.CurrentRow.Index).Value




    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim staff As String = txtidstaff.Text

        If cmbsat.SelectedIndex = -1 OrElse cmbsat.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbsat.Focus()
            Exit Sub
        End If
        If Not Class1.IsNumericOnly(staff) Then
            MessageBox.Show("❌ Enter in ID staff only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If staff = "" Then
            MessageBox.Show("Please enter  ID staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtidstaff.Focus()
            Exit Sub
        End If




        If con.State = ConnectionState.Closed Then
            con.Open()

        End If



        Dim qry As New SqlCommand("select namestaff from staff where IdStaff = " & txtidstaff.Text, con)
        Dim qry1 As String = qry.ExecuteScalar()
        con.Close()



        sqlobj.InsertStatement("insert into attendance (dates,timein,timesout,statuts,IdStaff,StaffName) values ('" & datetoday.Value & "','" & chechin.Value & "','" & chickout.Value & "','" & cmbsat.SelectedItem & "','" & txtidstaff.Text & "','" & qry1 & "')")
        dst.Clear()
        txtidstaff.Clear()
        cmbsat.SelectedIndex = -1
        datetoday.Value = Date.Now
        chechin.Value = DateTime.Now
        chickout.Value = DateTime.Now
        attendance_Load(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim staff As String = txtidstaff.Text

        If cmbsat.SelectedIndex = -1 OrElse cmbsat.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbsat.Focus()
            Exit Sub
        End If
        If Not Class1.IsNumericOnly(staff) Then
            MessageBox.Show("❌ Enter in ID staff only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If staff = "" Then
            MessageBox.Show("Please enter  ID staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtidstaff.Focus()
            Exit Sub
        End If



        If con.State = ConnectionState.Closed Then
            con.Open()

        End If



        Dim qry As New SqlCommand("select namestaff from staff where IdStaff = " & txtidstaff.Text, con)
        Dim qry1 As String = qry.ExecuteScalar()
        con.Close()


        Try
            ' Get the selected row in the DataGridView
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Get the data from the selected row
            Dim employeeID As Integer = Convert.ToInt32(selectedRow.Cells(5).Value)
            'Dim status As String = If(rdbabscent.Checked, "Absent", "Present")
            Dim status As Object = If(cmbsat.SelectedItem IsNot Nothing, cmbsat.SelectedItem, DBNull.Value)
            Dim timeIn As TimeSpan = chechin.Value.TimeOfDay
            Dim timeOut As TimeSpan = chickout.Value.TimeOfDay

            ' Check if time out is greater than time in
            If timeOut > timeIn Then
                Dim timeInString As String = timeIn.ToString("hh\:mm\:ss") ' Format as "hh:mm:ss"
                Dim timeOutString As String = timeOut.ToString("hh\:mm\:ss") ' Format as "hh:mm:ss"

                ' Update the database with the modified attendance data
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim updateQuery As String = "UPDATE attendance SET statuts = @status,timein = @timeIn, timesout = @timeOut , StaffName =@staffname , IdStaff =@idstaff  WHERE IdStaff = @employeeID"
                    Using cmd As New SqlCommand(updateQuery, connection)
                        cmd.Parameters.AddWithValue("@status", status)
                        'cmd.Parameters.AddWithValue("@reason", reason)
                        cmd.Parameters.AddWithValue("@timeIn", timeInString)
                        cmd.Parameters.AddWithValue("@timeOut", timeOutString)
                        cmd.Parameters.AddWithValue("@employeeID", employeeID)
                        cmd.Parameters.AddWithValue("@staffname", qry1)
                        cmd.Parameters.AddWithValue("@idstaff", txtidstaff.Text)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Update the DataGridView with the changes
                selectedRow.Cells(4).Value = status
                'selectedRow.Cells("Reason").Value = reason
                selectedRow.Cells(2).Value = timeIn.ToString()
                selectedRow.Cells(3).Value = timeOut.ToString()

                ' Show success message
                'Dim msgbox As New MsgBox("Information ", "Changes applied successfully. ", My.Resources.acceptticon)
                'msgbox.ShowDialog()
                MessageBox.Show("Changes applied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtidstaff.Clear()
                cmbsat.SelectedIndex = -1
                datetoday.Value = Date.Now
                chechin.Value = DateTime.Now
                chickout.Value = DateTime.Now

            Else
                ' Show error message if time out is not greater than time in
                'Dim msgbox As New MsgBox("Error ", "Time Out must be greater than Time In. ", My.Resources.failedicon)
                'msgbox.ShowDialog()
                MessageBox.Show("Time Out must be greater than Time In.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        attendance_Load(Nothing, Nothing)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        StaffDVG.Show()
    End Sub
End Class