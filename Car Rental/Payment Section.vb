Public Class Payment_Section
    Private Sub PaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Car_RentalDataSet)

    End Sub

    Private Sub Payment_Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_RentalDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.Car_RentalDataSet.Payment)

    End Sub
End Class