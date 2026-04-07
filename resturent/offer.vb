Public Class offer
    Sub clearr()
        txtitemname.Text = ""
        txtno.Text = ""
        txtdis.Text = ""
        Disper.Text = ""
        Stardate.Value = Date.Now
        cmbsts.SelectedIndex = -1


        enddate.Value = Date.Now
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click


        Dim name As String = txtitemname.Text
        Dim dis As String = txtdis.Text
        Dim per As String = Disper.Text


        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not Class1.IsValidName(dis) Then
            MessageBox.Show("❌The discription is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        If cmbsts.SelectedIndex = -1 OrElse cmbsts.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbsts.Focus()
            Exit Sub
        End If

        If Stardate.Value = Nothing Then
            MessageBox.Show("Please select a date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Stardate.Focus()
            Exit Sub
        End If

        If enddate.Value = Nothing Then
            MessageBox.Show("Please select a date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            enddate.Focus()
            Exit Sub
        End If


        If Not Class1.IsNumericOnly(per) Then
            MessageBox.Show("❌ Enter in discount only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If per = "" Then
            MessageBox.Show("Please enter  discount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Disper.Focus()
            Exit Sub
        End If

        Dim Start As DateTime = Stardate.Value

        Dim Endd As DateTime = enddate.Value

        If Start >= Endd Then
            MessageBox.Show("❌ Start date must be earlier than or equale to end date  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            enddate.Focus()
            Exit Sub
        End If





        sqlobj.InsertStatement("insert into offers (offername ,descriptions,discountPercentage,StartDate,EndDate,statuss) values ('" & txtitemname.Text & "','" & txtdis.Text & "','" & Disper.Text & "','" & Stardate.Value & "','" & enddate.Value & "','" & cmbsts.SelectedItem & "')")
        dst.Clear()
        cmbsts.Items.Clear()

        clearr()
        offer_Load(Nothing, Nothing)
    End Sub

    Private Sub offer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.BorderStyle = BorderStyle.None
        sqlobj.FillDGV(DataGridView1, "Select * from offers where offerId <> 8  ", "offerss")
        cmbsts.Items.Add("Active")
        cmbsts.Items.Add("Inactive")
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(2).HeaderText = "Description"
        DataGridView1.Columns(3).HeaderText = "Discount%"
        DataGridView1.Columns(4).HeaderText = "Start"
        DataGridView1.Columns(5).HeaderText = "End"
        DataGridView1.Columns(6).HeaderText = "Stutas"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from offers where offerId=" & iddelete)
            cmbsts.Items.Clear()
            dst.Clear()


            offer_Load(Nothing, Nothing)

        End If
        clearr()
    End Sub







    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtno.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtitemname.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        Disper.Text = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value
        txtdis.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value
        cmbsts.SelectedItem = Me.DataGridView1(6, Me.DataGridView1.CurrentRow.Index).Value

        Stardate.Value = Me.DataGridView1(4, Me.DataGridView1.CurrentRow.Index).Value
        enddate.Value = Me.DataGridView1(5, Me.DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click


        Dim name As String = txtitemname.Text
        Dim dis As String = txtdis.Text
        Dim per As String = Disper.Text


        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not Class1.IsValidName(dis) Then
            MessageBox.Show("❌The discription is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        If cmbsts.SelectedIndex = -1 OrElse cmbsts.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbsts.Focus()
            Exit Sub
        End If

        If Stardate.Value = Nothing Then
            MessageBox.Show("Please select a date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Stardate.Focus()
            Exit Sub
        End If

        If enddate.Value = Nothing Then
            MessageBox.Show("Please select a date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            enddate.Focus()
            Exit Sub
        End If


        If Not Class1.IsNumericOnly(per) Then
            MessageBox.Show("❌ Enter in discount only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If per = "" Then
            MessageBox.Show("Please enter  discount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Disper.Focus()
            Exit Sub
        End If




        sqlobj.UpdateStatement("update offers  set offername='" & txtitemname.Text & "', descriptions='" & txtdis.Text & "',  discountPercentage='" & Disper.Text & "',  StartDate='" & Stardate.Value & "',  enddate='" & enddate.Value & "',  statuss='" & cmbsts.SelectedItem & "' where offerId=" & txtno.Text)
        clearr()
        cmbsts.Items.Clear()
        offer_Load(Nothing, Nothing)
    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from offers where offername like'%" & txtempsearch.Text & "%'", "offerss")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class