Public Class Materails
    Private Sub Materails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select * from RawMaterials", "RawMaterialss")
        sqlobj.fillCombobox(cmbsupp, "Select * from supplier", "suppliers", "namesupp")

    End Sub



    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtidraw.Text = iddelete

        txtnamerow.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        txtquan.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value

        DateTimePicker1.Value = Me.DataGridView1(4, Me.DataGridView1.CurrentRow.Index).Value
        txtprice.Text = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value
        cmbunit.SelectedItem = Me.DataGridView1(5, Me.DataGridView1.CurrentRow.Index).Value

        Dim supp = Me.DataGridView1(6, Me.DataGridView1.CurrentRow.Index).Value

        cmbsupp.SelectedItem = sqlobj.getnames("select namesupp from supplier where Idsupplier=" & supp, "suppliers", "namesupp")

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim name As String = txtnamerow.Text
        Dim price As String = txtprice.Text
        Dim quan As String = txtquan.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If




        If cmbsupp.SelectedIndex = -1 OrElse cmbsupp.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an suppleir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbsupp.Focus()
            Exit Sub
        End If

        If DateTimePicker1.Value = Nothing Then
            MessageBox.Show("Please select a date .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        If cmbunit.SelectedIndex = -1 OrElse cmbunit.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbunit.Focus()
            Exit Sub
        End If

        If Not Class1.IsNumericOnly(price) Then
            MessageBox.Show("❌ Enter in price only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If price = "" Then
            MessageBox.Show("Please enter  price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtprice.Focus()
            Exit Sub
        End If
        If Not Class1.IsNumericOnly(quan) Then
            MessageBox.Show("❌ Enter in quantity only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If quan = "" Then
            MessageBox.Show("Please enter  quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtquan.Focus()
            Exit Sub
        End If
        Dim pricee As Integer = txtprice.Text
        Dim quann As Integer = txtquan.Text
        Dim totalprice As Integer = pricee * quann





        sqlobj.InsertStatement("insert into RawMaterials (namemat,quantity,price,dateorder,unit,Idsupplier,totalprice) values ('" & txtnamerow.Text & "','" & txtquan.Text & "','" & txtprice.Text & "','" & DateTimePicker1.Value & "','" & cmbunit.SelectedItem & "','" & suppno & "','" & totalprice & "')")
        dst.Clear()

        cmbsupp.Items.Clear()
        txtidraw.Text = ""
        txtnamerow.Text = ""
        txtquan.Text = ""
        txtprice.Text = ""
        DateTimePicker1.Value = Date.Now
        cmbunit.SelectedIndex = -1
        Materails_Load(Nothing, Nothing)
    End Sub

    Private Sub cmbsupp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsupp.SelectedIndexChanged
        suppno = sqlobj.getnumber("Select Idsupplier from supplier where namesupp= '" & cmbsupp.SelectedItem & "'", "supp", "Idsupplier")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from RawMaterials where idmat=" & iddelete)
            dst.Clear()
            cmbsupp.Items.Clear()
            txtidraw.Text = ""
            txtnamerow.Text = ""
            txtquan.Text = ""
            txtprice.Text = ""
            DateTimePicker1.Value = Date.Now
            cmbunit.SelectedIndex = -1
            Materails_Load(Nothing, Nothing)

        End If
    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from RawMaterials where namemat like'%" & txtempsearch.Text & "%'", "RawMaterialsss")

    End Sub

    'Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    '    Dim name As String = txtnamerow.Text
    '    Dim price As String = txtprice.Text
    '    Dim quan As String = txtquan.Text

    '    If Not Class1.IsValidName(name) Then
    '        MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End If




    '    If cmbsupp.SelectedIndex = -1 OrElse cmbsupp.SelectedItem Is Nothing Then
    '        MessageBox.Show("Please select an suppleir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        cmbsupp.Focus()
    '        Exit Sub
    '    End If

    '    If DateTimePicker1.Value = Nothing Then
    '        MessageBox.Show("Please select a date .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        DateTimePicker1.Focus()
    '        Exit Sub
    '    End If

    '    If cmbunit.SelectedIndex = -1 OrElse cmbunit.SelectedItem Is Nothing Then
    '        MessageBox.Show("Please select an unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        cmbunit.Focus()
    '        Exit Sub
    '    End If

    '    If Not Class1.IsNumericOnly(price) Then
    '        MessageBox.Show("❌ Enter in price only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End If
    '    If price = "" Then
    '        MessageBox.Show("Please enter  price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtprice.Focus()
    '        Exit Sub
    '    End If
    '    If Not Class1.IsNumericOnly(quan) Then
    '        MessageBox.Show("❌ Enter in quantity only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End If
    '    If quan = "" Then
    '        MessageBox.Show("Please enter  quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtquan.Focus()
    '        Exit Sub
    '    End If





    '    sqlobj.UpdateStatement("update RawMaterials set namemat='" & txtnamerow.Text & "', quantity = '" & txtquan.Text & "', dateorder ='" & DateTimePicker1.Value & "',  price='" & txtprice.Text & "',  unit='" & cmbunit.SelectedItem & "',   Idsupplier =" & suppno & "  where idmat=" & txtidraw.Text)
    '    dst.Clear()
    '    cmbsupp.Items.Clear()
    '    txtidraw.Text = ""
    '    txtnamerow.Text = ""
    '    txtquan.Text = ""
    '    txtprice.Text = ""
    '    DateTimePicker1.Value = Date.Now
    '    cmbunit.SelectedIndex = -1
    '    Materails_Load(Nothing, Nothing)
    'End Sub


End Class