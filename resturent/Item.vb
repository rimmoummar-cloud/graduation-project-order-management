Imports System.Data
Imports System.Data.SqlClient
Public Class Item
    Sub clearr()
        txtitemname.Text = ""
        txtno.Text = ""
        txtprice.Text = ""

        cmbcat.SelectedIndex = -1

    End Sub
    Private Sub Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select * from Item", "Items")
        sqlobj.fillCombobox(cmbcat, "Select * from category", "categorys", "menuname")
        'sqlobj.fillCombobox(cmboffer, "Select * from offers where statuss ='Active' ", "offerss", "offername")
        'DataGridView1.Columns(1).HeaderText = "Itemname"
        'DataGridView1.Columns(2).HeaderText = "Typeitem"
        'DataGridView1.Columns(3).HeaderText = "Price"
        'DataGridView1.Columns(4).HeaderText = "MenuId"
        'DataGridView1.Columns(5).HeaderText = "Idoffer"
        'DataGridView1.Columns(6).HeaderText = "ProducingDate"
        'DataGridView1.Columns(7).HeaderText = "ExpiryDate"
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtno.Text = iddelete

        txtitemname.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value

        txtprice.Text = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value


        Dim categ = Me.DataGridView1(3, Me.DataGridView1.CurrentRow.Index).Value
        cmbcat.SelectedItem = sqlobj.getnames("select menuname from category where menuId=" & categ, "categorys", "menuname")
        'Dim off = Me.DataGridView1(4, Me.DataGridView1.CurrentRow.Index).Value
        'cmboffer.SelectedItem = sqlobj.getnames("select offername from offers where offerId=" & off, "offerss", "offername")
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim name As String = txtitemname.Text


        Dim price As String = txtprice.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If




        If cmbcat.SelectedIndex = -1 OrElse cmbcat.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbcat.Focus()
            Exit Sub
        End If



        'If Not System.Text.RegularExpressions.Regex.IsMatch(price, "^\d+(\.\d+)?$") Then
        '    MessageBox.Show("✘ Enter a valid price (numbers and a decimal point only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If


        'If Not System.Text.RegularExpressions.Regex.IsMatch(price, "^\d+(\.\d{1,2})?$") Then
        '    MessageBox.Show("✘ Enter a valid price (numbers and one decimal point only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If


        If Not Class1.IsNumericOnly(price) Then
            MessageBox.Show("❌ Enter in price only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If price = "" Then
            MessageBox.Show("Please enter  price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtprice.Focus()
            Exit Sub
        End If


        sqlobj.InsertStatement("insert into Item (nameItem ,price,menuId) values ('" & txtitemname.Text & "','" & txtprice.Text & "','" & categno & "')")
        dst.Clear()
        cmbcat.Items.Clear()
        'cmboffer.Items.Clear()
        txtitemname.Text = ""
        txtprice.Text = ""

        Item_Load(Nothing, Nothing)





    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim name As String = txtitemname.Text


        Dim price As String = txtprice.Text

        If Not Class1.IsValidName(name) Then
            MessageBox.Show("❌The name is not valid  should contain only a letter or space", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If




        If cmbcat.SelectedIndex = -1 OrElse cmbcat.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbcat.Focus()
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(price, "^\d+(\.\d+)?$") Then
            MessageBox.Show("✘ Enter a valid price (numbers and a decimal point only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        'If Not System.Text.RegularExpressions.Regex.IsMatch(price, "^\d+(\.\d{1,2})?$") Then
        '    MessageBox.Show("✘ Enter a valid price (numbers and one decimal point only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If


        'If Not Class1.IsNumericOnly(price) Then
        '    MessageBox.Show("❌ Enter in price only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        If price = "" Then
            MessageBox.Show("Please enter  price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtprice.Focus()
            Exit Sub
        End If


        sqlobj.UpdateStatement("update Item  set nameItem='" & txtitemname.Text & "', price='" & txtprice.Text & "',    menuId=" & categno & "  where IdItem=" & txtno.Text)
        dst.Clear()
        cmbcat.Items.Clear()
        'cmboffer.Items.Clear()
        txtitemname.Text = ""
        txtprice.Text = ""
        txtno.Text = ""
        Item_Load(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from Item where IdItem=" & iddelete)
            dst.Clear()
            cmbcat.Items.Clear()
            'cmboffer.Items.Clear()
            txtitemname.Text = ""
            txtprice.Text = ""
            txtno.Text = ""
            Item_Load(Nothing, Nothing)

        End If

    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sqlobj.FillDGV(DataGridView1, " select * from Item where nameItem like'%" & txtempsearch.Text & "%'", "Items")
    End Sub

    Private Sub cmbcat_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbcat.SelectedIndexChanged
        categno = sqlobj.getnumber("Select menuId from category where menuname= '" & cmbcat.SelectedItem & "'", "categorys", "menuId")
    End Sub

    'Private Sub cmboffer_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    offid = sqlobj.getnumber("Select offerId from offers where offername= '" & cmboffer.SelectedItem & "'", "offerss", "offerId")
    'End Sub


End Class