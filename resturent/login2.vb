Public Class login2

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        da.SelectCommand = New SqlClient.SqlCommand
        da.SelectCommand.CommandText = "select username,passwords from Users where username ='" & txtname.Text & "' and passwords='" & txtpassword.Text & "'"
        da.SelectCommand.Connection = con


        dst = New DataSet
        Dim num = da.Fill(dst, "users")

        If num = 0 Then
            MessageBox.Show("Invalid username or password .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MsgBox("Welcome" & " " & txtname.Text)
            Me.Hide()
            form2.Show()
        End If
    End Sub




    Private Sub check_CheckedChanged(sender As Object, e As EventArgs) Handles check.CheckedChanged
        If check.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
            txtpassword.PasswordChar = ""
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub llforgpass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llforgpass.LinkClicked
        Me.Hide()

        Form5.Show()

    End Sub
End Class