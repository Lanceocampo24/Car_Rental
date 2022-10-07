Imports System.Data.SqlClient
Public Class Dashboard
    Dim con As New SqlConnection("Data Source=LAPTOP-S4BBQ22C\OCAMPO;Initial Catalog=Car Rental;Integrated Security=True")
    Sub switchpanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
        LogoPL.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchpanel(Rent)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchpanel(Payment_Section)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchpanel(Car_Rented)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        switchpanel(Add_Car)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LogoPL.Show()

    End Sub
End Class