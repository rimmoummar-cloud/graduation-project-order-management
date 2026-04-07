Imports System.Data
Imports System.Data.SqlClient

Public Class staffin
    Sub clearr()
        txtid.Text = ""
        txtname.Text = ""
        txtemaill.Text = ""
        DateTimePicker1.Value = Date.Now
        txtnum.Text = ""
        cmbadd.SelectedIndex = -1
        txtsal.Text = ""
        cmbpost.SelectedIndex = -1
    End Sub
    Private Sub staffin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select * from staff", "staffs")
        sqlobj.fillCombobox(cmbpost, "Select * from Position", "positions", "Namepos")


        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None

        DataGridView1.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
        DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)



        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 110, 93)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White






    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim name As String = txtname.Text
        Dim phone As String = txtnum.Text
        Dim email As String = txtemaill.Text
        Dim salary As String = txtsal.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Not Class1.IsValidPhoneNumber(phone) Then
            MessageBox.Show("❌ Phone number is ronge should be 8 number", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Not Class1.IsValidEmail(email) Then
            MessageBox.Show("❌ ronge email should contain @ and gmail.com ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If cmbadd.SelectedIndex = -1 OrElse cmbadd.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbadd.Focus()
            Exit Sub
        End If

        If DateTimePicker1.Value = Nothing Then
            MessageBox.Show("Please select a date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        If cmbpost.SelectedIndex = -1 OrElse cmbpost.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbpost.Focus()
            Exit Sub
        End If

        If Not Class1.IsNumericOnly(salary) Then
            MessageBox.Show("❌ Enter in salary only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If salary = "" Then
            MessageBox.Show("Please enter  caption.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtsal.Focus()
            Exit Sub
        End If
        con.Close()


        If con.State = ConnectionState.Closed Then
            con.Open()

        End If



        Dim qry As New SqlCommand("select Namepos from Position where idposition = " & posnumber, con)
        Dim qry1 As String = qry.ExecuteScalar()
        con.Close()

        sqlobj.InsertStatement("insert into staff (namestaff,Email,DOB,phonenum,addres,salary,idposition,Position) values ('" & txtname.Text & "','" & txtemaill.Text & "','" & DateTimePicker1.Value & "','" & txtnum.Text & "','" & cmbadd.SelectedItem & "','" & txtsal.Text & "','" & posnumber & "','" & qry1 & "')")
        dst.Clear()
        txtemaill.Clear()
        txtid.Clear()
        txtname.Clear()
        txtnum.Clear()
        txtsal.Clear()

        cmbpost.Items.Clear()
        staffin_Load(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click


        Dim name As String = txtname.Text
        Dim phone As String = txtnum.Text
        Dim email As String = txtemaill.Text
        Dim salary As String = txtsal.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Not Class1.IsValidPhoneNumber(phone) Then
            MessageBox.Show("❌ Phone number is ronge should be 8 number", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Not Class1.IsValidEmail(email) Then
            MessageBox.Show("❌ ronge email should contain @ and gmail.com ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If cmbadd.SelectedIndex = -1 OrElse cmbadd.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbadd.Focus()
            Exit Sub
        End If

        If DateTimePicker1.Value = Nothing Then
            MessageBox.Show("Please select a date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        If cmbpost.SelectedIndex = -1 OrElse cmbpost.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbpost.Focus()
            Exit Sub
        End If

        If Not Class1.IsNumericOnly(salary) Then
            MessageBox.Show("❌ Enter in salary only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If salary = "" Then
            MessageBox.Show("Please enter  caption.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtsal.Focus()
            Exit Sub
        End If




        sqlobj.UpdateStatement("update staff set Email='" & txtemaill.Text & "', namestaff = '" & txtname.Text & "',  DOB='" & DateTimePicker1.Value & "',  phonenum='" & txtnum.Text & "',  addres='" & cmbadd.SelectedItem & "',  salary ='" & txtsal.Text & "', idposition =" & posnumber & "  where IdStaff=" & txtid.Text)
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If



        Dim qry As New SqlCommand("select Namepos from Position where idposition = " & posnumber, con)
        Dim qry1 As String = qry.ExecuteScalar()
        con.Close()
        sqlobj.UpdateStatement("update staff set Position='" & qry1 & "'  where IdStaff=" & txtid.Text)

        dst.Clear()
        txtemaill.Clear()
        txtid.Clear()
        txtname.Clear()
        txtnum.Clear()
        txtsal.Clear()

        cmbpost.Items.Clear()
        staffin_Load(Nothing, Nothing)

    End Sub






    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtid.Text = iddelete
        'txtid.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtname.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value
        txtemaill.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value

        DateTimePicker1.Value = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value
        txtnum.Text = Me.DataGridView1(4, Me.DataGridView1.CurrentRow.Index).Value
        cmbadd.SelectedItem = Me.DataGridView1(5, Me.DataGridView1.CurrentRow.Index).Value
        txtsal.Text = Me.DataGridView1(6, Me.DataGridView1.CurrentRow.Index).Value
        Dim post = Me.DataGridView1(7, Me.DataGridView1.CurrentRow.Index).Value

        cmbpost.SelectedItem = sqlobj.getnames("select Namepos from Position where idposition=" & post, "positions", "Namepos")


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from staff where IdStaff=" & iddelete)
            dst.Clear()

            staffin_Load(Nothing, Nothing)

        End If
        txtemaill.Clear()
        txtid.Clear()
        txtname.Clear()
        txtnum.Clear()
        txtsal.Clear()


        cmbpost.Items.Clear()

    End Sub




    Private Sub cmbpost_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpost.SelectedIndexChanged

        posnumber = sqlobj.getnumber("Select idposition from Position where Namepos= '" & cmbpost.SelectedItem & "'", "posnumber", "idposition")

        'da.SelectCommand = New SqlCommand
        'da.SelectCommand.CommandText = "Select idposition from Position where Namepos='" & ComboBox2.SelectedItem & "'"
        'da.SelectCommand.Connection = con

        'dst = New DataSet
        'da.Fill(dst, "posnumber")
        'posnumber = dst.Tables("posnumber").Rows(0).Item("idposition")
    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from staff where namestaff like'%" & txtempsearch.Text & "%'", "staffs")
    End Sub



    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
        attendance.txtidstaff.Text = iddelete
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class