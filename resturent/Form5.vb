Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form5
    Dim ErrorProvider1 As Object
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()

        login2.Show()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btngetpass.Visible = False

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Try
            If txtusername.Text = "" Then
                ErrorProvider1.SetError(txtusername, "Fill The Username")
            Else da.SelectCommand = New SqlCommand
                da.SelectCommand.CommandText = " select username,QuestionI,QuestionII from Users where username= '" & txtusername.Text & "'"
                da.SelectCommand.Connection = con
                dst = New DataSet
                Dim num = da.Fill(dst, "use")
                If num <> 0 Then
                    Dim ques1 = dst.Tables("use").Rows(0).Item("QuestionI")
                    Dim ques2 = dst.Tables("use").Rows(0).Item("QuestionII")
                    Dim type = dst.Tables("use").Rows(0).Item("username")
                    txtques1.Text = ques1
                    txtques2.Text = ques2
                    'Panel2.Visible = True
                    'Panel4.Visible = True
                    'Panel5.Visible = True
                    'Panel6.Visible = True
                    btngetpass.Visible = True
                    'PictureBox14.Visible = True
                Else
                    MsgBox("error")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btngetpass_Click(sender As Object, e As EventArgs) Handles btngetpass.Click
        Try
            If txtques1.Text = "" Then
                'ErrorProvider1.SetError(txtques1, "Choose Question No I")
                MessageBox.Show("❌Choose Question No I", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtansw1.Text = "" Then
                MessageBox.Show("❌Fill The Answer of Question II", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'ErrorProvider1.SetError(txtansw1, "Fill The Answer of Question I")
            ElseIf txtques2.Text = "" Then
                'ErrorProvider1.SetError(txtques2, "Choose Question No II")
                MessageBox.Show("❌Choose Question No II", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtansw2.Text = "" Then
                MessageBox.Show("❌Fill The Answer of Question II", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'ErrorProvider1.SetError(txtansw2, "Fill The Answer of Question II")


            Else da.SelectCommand = New SqlCommand
                da.SelectCommand.CommandText = " select username,passwords,QuestionI,answerI,QuestionII,answerII from Users where username= '" & txtusername.Text & "' and QuestionI= '" & txtques1.Text & "' and answerI='" & txtansw1.Text & "' and QuestionII='" & txtques2.Text & "' and answerII='" & txtansw2.Text & "'"

                da.SelectCommand.Connection = con

                dst = New DataSet
                Dim num = da.Fill(dst, "use")
                If num <> 0 Then
                    Dim pass = dst.Tables("use").Rows(0).Item("passwords")
                    Dim type = dst.Tables("use").Rows(0).Item("username")
                    ' MessageBox.Show("Your Password is: " & pass)

                    MsgBox("Your Password is : " + pass)


                    Me.Hide()
                    login2.Show()

                Else
                    ' MessageBox.Show("No access .. Check UserName")
                    MsgBox("Check your informations ")




                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class