Public Class form2
    Sub childform(ByVal panel As Form)
        Panel11.Controls.Clear()
        panel.TopLevel = False
        Panel11.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MMM yyy hh:mm")
    End Sub

    Private Sub btnfood_Click_1(sender As Object, e As EventArgs) Handles btnfood.Click
        Panel8.Height = btnfood.Height
        Panel8.Top = btnfood.Top
        childform(food)
    End Sub

    Private Sub btnsteff_Click(sender As Object, e As EventArgs) Handles btnsteff.Click
        Panel8.Height = btnsteff.Height
        Panel8.Top = btnsteff.Top
        childform(Staff)
    End Sub

    Private Sub btnreserve_Click(sender As Object, e As EventArgs) Handles btnreserve.Click
        Panel8.Height = btnreserve.Height
        Panel8.Top = btnreserve.Top
        childform(reservation)
    End Sub

    Private Sub btnsupp_Click(sender As Object, e As EventArgs) Handles btnsupp.Click
        Panel8.Height = btnsupp.Height
        Panel8.Top = btnsupp.Top
        childform(Supplier)
    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        Panel8.Height = btnorder.Height
        Panel8.Top = btnorder.Top
        'childform(orders)
        Me.Hide()
        orders.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal

        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub txtsignout_Click(sender As Object, e As EventArgs) Handles txtsignout.Click
        Panel8.Height = txtsignout.Height
        Panel8.Top = txtsignout.Top
        Dim response As Integer
        response = MessageBox.Show("Are you sure to sign out ?", "Sign out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Me.Hide()
            login2.Show()
            login2.txtname.Clear()
            login2.txtpassword.Clear()
        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Panel8.Height = Guna2GradientButton1.Height
        Panel8.Top = Guna2GradientButton1.Top
        childform(Information)
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Panel8.Height = Guna2GradientButton2.Height
        Panel8.Top = Guna2GradientButton2.Top
        childform(dashboard)
    End Sub

    'Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
    '    Panel8.Height = Guna2GradientButton2.Height
    '    Panel8.Top = Guna2GradientButton2.Top
    '    childform(Form4)
    'End Sub
End Class