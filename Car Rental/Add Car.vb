Imports System.Data.SqlClient
Public Class Add_Car
    Dim con As New SqlConnection("Data Source=LAPTOP-S4BBQ22C\OCAMPO;Initial Catalog=Car Rental;Integrated Security=True")
    Private Sub CarsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CarsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Car_RentalDataSet)

    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, con)
        con.Open()
        command.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String
        insertquery = "INSERT INTO [Cars] ([Category],[Model],[Brand],[Transmission],[Rental fee per Day]) VALUES('" + CategoryTextBox.Text + "','" + ModelTextBox.Text + "','" + BrandTextBox.Text + "','" + TransmissionTextBox.Text + "','" + Rental_fee_per_DayTextBox.Text + "')"
        ExecuteQuery(insertquery)
        MsgBox(" Car Added ")

        CategoryTextBox.Clear()
        ModelTextBox.Clear()
        BrandTextBox.Clear()
        TransmissionTextBox.Clear()
        Rental_fee_per_DayTextBox.Clear()
    End Sub
End Class