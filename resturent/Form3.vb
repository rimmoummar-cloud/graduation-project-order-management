Public Class Form3
    Sub clearr()
        txtId.Text = ""
        txtname.Text = ""
        txtnumber.Text = ""
        cmbaddres.SelectedIndex = -1
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select * from supplier", "suppliers")
        '        create table supplier(
        '--Idsupplier int identity Primary Key ,
        '--phonenum varchar(21)  Not null,
        '--namesupp varchar(50) Not null unique,
        '--addresse varchar(100) Not null,


    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim name As String = txtname.Text
        Dim phone As String = txtnumber.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Not Class1.IsValidPhoneNumber(phone) Then
            MessageBox.Show("❌ Phone number is ronge should be 8 number", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        If cmbaddres.SelectedIndex = -1 OrElse cmbaddres.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbaddres.Focus()
            Exit Sub
        End If




        sqlobj.InsertStatement("insert into supplier (phonenum,namesupp,addresse) values ('" & txtnumber.Text & "','" & txtname.Text & "','" & cmbaddres.SelectedItem & "')")
        dst.Clear()
        clearr()
        Form3_Load(Nothing, Nothing)

    End Sub




    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtId.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtnumber.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        txtname.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value
        cmbaddres.SelectedItem = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from supplier where Idsupplier=" & iddelete)
            dst.Clear()

            Form3_Load(Nothing, Nothing)

        End If
        clearr()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim name As String = txtname.Text
        Dim phone As String = txtnumber.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Not Class1.IsValidPhoneNumber(phone) Then
            MessageBox.Show("❌ Phone number is ronge should be 8 number", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        If cmbaddres.SelectedIndex = -1 OrElse cmbaddres.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbaddres.Focus()
            Exit Sub
        End If







        sqlobj.UpdateStatement("update supplier  set phonenum='" & txtnumber.Text & "'  ,  addresse ='" & cmbaddres.SelectedItem & "'   , namesupp ='" & txtname.Text & "'  where Idsupplier=" & txtId.Text)


        clearr()
        Form3_Load(Nothing, Nothing)

    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from supplier where namesupp like'%" & txtempsearch.Text & "%'", "suppliers")
    End Sub


End Class