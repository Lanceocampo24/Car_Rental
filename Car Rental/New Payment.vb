Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class New_Payment
    Dim con As New SqlConnection("Data Source=LAPTOP-S4BBQ22C\OCAMPO;Initial Catalog=Car Rental;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub PaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Car_RentalDataSet)

    End Sub

    Private Sub New_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_RentalDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.Car_RentalDataSet.Payment)

    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, con)
        con.Open()
        command.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub PaymentTextBox_TextChanged(sender As Object, e As EventArgs)
        BalanceLabel1.Text = PaymentTextBox.Text - Total_AmountLabel1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim upquery As String
        upquery = " UPDATE DATA SET [Payment] ([Total Amount],[Payment],[Balance],[Transaction Date]) VALUES('" + Total_AmountLabel1.Text + "','" + PaymentTextBox.Text + "','" + BalanceLabel1.Text + "','" + Transaction_DateDateTimePicker.Text + "')"
        ExecuteQuery(upquery)
        upquery = " UPDATE DATA SET [Cash Report] ([Total Amount],[Payment],[Transaction Date]) VALUES('" + Total_AmountLabel1.Text + "','" + PaymentTextBox.Text + "','" + Transaction_DateDateTimePicker.Text + "')"
        ExecuteQuery(upquery)
        MsgBox(" Payment Success! ")

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font_name As String = "Times New Roman"
        Dim font_size As Integer = 16
        Dim csz As New PaperSize("Custom Paper Size", 1, 2)
        ' PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSize = csz
        Dim interval As Integer = 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 20, interval)
        interval += 30

        e.Graphics.DrawString("                     E'n'L Car Rental", New Font(font_name, 11, FontStyle.Bold), Brushes.Black, 25, interval)
        interval += 35

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 20, interval)
        interval += 30

        e.Graphics.DrawString("Total Amount :" + Total_AmountLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Total of Payment :" + Type_of_PaymentLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Payment :" + PaymentTextBox.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Balance :" + BalanceLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Transaction Date:" + Transaction_DateDateTimePicker.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30
    End Sub
End Class