Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "Admin" And TextBox2.Text = "Admin") Then
            Dashboard.Show()
            Me.Hide()
        Else
            MsgBox("Error")
        End If
    End Sub
End Class
