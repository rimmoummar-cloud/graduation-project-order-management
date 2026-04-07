Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Me.Guna2ProgressBar1.Value = Guna2ProgressBar1.Value + 1
        'If Guna2ProgressBar1.Value >= 100 Then
        '    Timer1.Stop()
        '    login2.Show()
        '    Me.Hide()

        'End If
        Timer1.Start()
        CircleProgressBar1.Increment(22)

        If CircleProgressBar1.Value = 600 Then
            Timer1.Stop()

            Me.Hide()
            login2.Show()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = True

    End Sub


End Class
