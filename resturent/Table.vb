Public Class Table

    Sub clearr()
        txtID.Text = ""
        txtcap.Text = ""
        cmbstat.SelectedIndex = -1
    End Sub


    Private Sub Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlobj.FillDGV(DataGridView1, "Select tableId,Capacity,statuse from tablee", "tablees")
        cmbstat.Items.Add("Available")
        cmbstat.Items.Add("Unavailable")
    End Sub



    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim cap As String = txtcap.Text
        If Not Class1.IsNumericOnly(cap) Then
            MessageBox.Show("❌ Enter in caption only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbstat.SelectedIndex = -1 OrElse cmbstat.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an statuse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbstat.Focus()
            Exit Sub
        End If
        If cap = "" Then
            MessageBox.Show("Please enter  caption.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcap.Focus()
            Exit Sub
        End If
        Dim n As Integer = 0

        sqlobj.InsertStatement("insert into tablee  (Capacity,statuse,ReservationNo) values ('" & txtcap.Text & "','" & cmbstat.SelectedItem & "','" & n & "')")

        cmbstat.Items.Clear()
        clearr()
        Table_Load(Nothing, Nothing)

    End Sub



    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        iddelete = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtID.Text = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value
        txtcap.Text = Me.DataGridView1(1, Me.DataGridView1.CurrentRow.Index).Value
        cmbstat.SelectedItem = Me.DataGridView1(2, Me.DataGridView1.CurrentRow.Index).Value
    End Sub



    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click


        Dim cap As String = txtcap.Text
        If Not Class1.IsNumericOnly(cap) Then
            MessageBox.Show("❌ Enter in caption only number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbstat.SelectedIndex = -1 OrElse cmbstat.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an statuse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbstat.Focus()
            Exit Sub
        End If
        If cap = "" Then
            MessageBox.Show("Please enter  caption.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcap.Focus()
            Exit Sub
        End If



        sqlobj.UpdateStatement("update tablee  set Capacity='" & txtcap.Text & "' , statuse = '" & cmbstat.SelectedItem & "'  where tableId=" & txtID.Text)
        cmbstat.Items.Clear()
        clearr()
        Table_Load(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        If MsgBox("Are you sure Delete this Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            sqlobj.DeleteStatement(" delete from tablee where tableId=" & txtID.Text)
            cmbstat.Items.Clear()
            dst.Clear()
            clearr()
            Table_Load(Nothing, Nothing)

        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class