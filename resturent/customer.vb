Public Class customer
    Sub clearr()

        txtName.Text = ""
        txtemail.Text = ""
        txtid.Text = ""
        txtnumber.Text = ""
        cmdaddres.SelectedIndex = -1

    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select * from customer", "customers")

        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(2).HeaderText = "PhoneNumber"
        DataGridView1.Columns(3).HeaderText = "Email"
        DataGridView1.Columns(4).HeaderText = "Addres"
        cmdaddres.Items.Add("Saida")
        cmdaddres.Items.Add("bekaa")
        cmdaddres.Items.Add("tyre")

    End Sub





    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtid.Text = iddelete

        txtName.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        txtnumber.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value

        txtemail.Text = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value

        cmdaddres.SelectedItem = Me.DataGridView1(4, Me.DataGridView1.CurrentRow.Index).Value




    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim name As String = txtName.Text
        Dim phone As String = txtnumber.Text
        Dim email As String = txtemail.Text


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

        If cmdaddres.SelectedIndex = -1 OrElse cmdaddres.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmdaddres.Focus()
            Exit Sub
        End If







        sqlobj.InsertStatement("insert into customer (namecutomer,phonenumber,email,adddres) values ('" & txtName.Text & "','" & txtnumber.Text & "','" & txtemail.Text & "','" & cmdaddres.SelectedItem & "')")
        clearr()
        customer_Load(Nothing, Nothing)
        cmdaddres.Items.Clear()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click

        Dim name As String = txtName.Text
        Dim phone As String = txtnumber.Text
        Dim email As String = txtemail.Text


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

        If cmdaddres.SelectedIndex = -1 OrElse cmdaddres.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmdaddres.Focus()
            Exit Sub
        End If






        sqlobj.UpdateStatement("update customer  set namecutomer='" & txtName.Text & "', phonenumber ='" & txtnumber.Text & "',  email='" & txtemail.Text & "',  adddres='" & cmdaddres.SelectedItem & "' where Idcustomer=" & txtid.Text)
        clearr()
        cmdaddres.Items.Clear()
        customer_Load(Nothing, Nothing)

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from customer where Idcustomer=" & iddelete)
        End If
        clearr()
        cmdaddres.Items.Clear()
        customer_Load(Nothing, Nothing)

    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from customer where namecutomer like'%" & txtempsearch.Text & "%'", "customers")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
        resevrin.txtidcustoner.Text = iddelete
        orders.txtcustomer.Text = iddelete
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub
End Class