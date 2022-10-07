Imports System.Data.SqlClient
Public Class Car_Rented
    Dim con As New SqlConnection("Data Source=LAPTOP-S4BBQ22C\OCAMPO;Initial Catalog=Car Rental;Integrated Security=True")

    Private Sub Car_ReportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Car_ReportBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Car_ReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Car_RentalDataSet)

    End Sub

    Private Sub Car_Rented_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_RentalDataSet.Car_Report' table. You can move, or remove it, as needed.
        Me.Car_ReportTableAdapter.Fill(Me.Car_RentalDataSet.Car_Report)

    End Sub
End Class