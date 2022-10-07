Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Rent
    Dim con As New SqlConnection("Data Source=LAPTOP-S4BBQ22C\OCAMPO;Initial Catalog=Car Rental;Integrated Security=True")
    Dim cmd As SqlCommand

    Private Sub ApplicationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ApplicationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ApplicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Car_RentalDataSet)

    End Sub

    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_RentalDataSet.Cars' table. You can move, or remove it, as needed.
        Me.CarsTableAdapter.Fill(Me.Car_RentalDataSet.Cars)
        Transaction_DateLabel1.Text = DateAndTime.Now()

    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, con)
        con.Open()
        command.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Camera.Show()

    End Sub

    Private Sub Return_DateDateTimePicker_ValueChanged_1(sender As Object, e As EventArgs) Handles Return_DateDateTimePicker.ValueChanged
        If True Then

            Dim dt1 As DateTime = Convert.ToDateTime(Pick_up_DateDateTimePicker.Text)
            Dim dt2 As DateTime = Convert.ToDateTime(Return_DateDateTimePicker.Text)
            Dim ts As TimeSpan = dt2.Subtract(dt1)
            If Convert.ToInt32(ts.Days) >= 0 Then
                Total_DaysLabel1.Text = Convert.ToInt32(ts.Days)
                Total_AmountLabel1.Text = Total_DaysLabel1.Text * Rental_fee_per_DayLabel1.Text
            Else
                MessageBox.Show("Invalid Input")
            End If
        End If
    End Sub

    Private Sub PaymentTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles PaymentTextBox.TextChanged
        BalanceLabel1.Text = Total_AmountLabel1.Text - Val(PaymentTextBox.Text)
    End Sub

    Private Sub Type_of_PaymentComboBox_Click(sender As Object, e As EventArgs) Handles Type_of_PaymentComboBox.Click
        Type_of_PaymentComboBox.Items.Clear()
        Type_of_PaymentComboBox.Items.Add("Cash")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images, |*.png; *.bmp; *.jpg; *.gif; *.ico;")
                .FilterIndex = 4

            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PicturePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim insertquery As String
        insertquery = "INSERT INTO [Application] ([Last Name],[First Name],[Middle Name],[Address],[Valid ID's],[License ID No],[Contact No],[Work],[Purpose of rent],[Picture]) VALUES('" + Last_NameTextBox.Text + "','" + First_NameTextBox.Text + "','" + Middle_NameTextBox.Text + "','" + AddressTextBox.Text + "','" + Valid_ID_sCheckedListBox.Text + "','" + License_ID_NoTextBox.Text + "','" + Contact_NoTextBox.Text + "','" + WorkTextBox.Text + "','" + Purpose_of_RentTextBox.Text + "','" + PicturePictureBox.Text + "')"
        ExecuteQuery(insertquery)
        insertquery = "INSERT INTO [Car Report] ([Category],[Model],[Brand],[Pick up Date],[Return Date],[Transaction Date]) VALUES('" + CategoryLabel1.Text + "','" + ModelLabel1.Text + "','" + BrandLabel1.Text + "','" + Pick_up_DateDateTimePicker.Text + "','" + Return_DateDateTimePicker.Text + "','" + Transaction_DateLabel1.Text + "')"
        ExecuteQuery(insertquery)
        insertquery = "INSERT INTO [Cash Report] ([Category],[Model],[Brand],[Rental fee per Day],[Total Days],[Total Amount],[Type of Payment],[Payment],[Transaction Date]) VALUES('" + CategoryLabel1.Text + "','" + ModelLabel1.Text + "','" + BrandLabel1.Text + "','" + Rental_fee_per_DayLabel1.Text + "','" + Total_DaysLabel1.Text + "','" + Total_AmountLabel1.Text + "','" + Type_of_PaymentComboBox.Text + "','" + PaymentTextBox.Text + "','" + Transaction_DateLabel1.Text + "')"
        ExecuteQuery(insertquery)
        insertquery = "INSERT INTO [Payment] ([Name],[Pick up Location],[Drop off Location],[Pick up Date],[Return Date],[Total Days],[Total Amount],[Type of Payment],[Payment],[Balance],[Transaction Date]) VALUES('" + NameLabel1.Text + "','" + Pick_up_LocationTextBox.Text + "','" + Drop_off_LocationTextBox.Text + "','" + Pick_up_DateDateTimePicker.Text + "','" + Return_DateDateTimePicker.Text + "','" + Total_DaysLabel1.Text + "','" + Total_AmountLabel1.Text + "','" + Type_of_PaymentComboBox.Text + "','" + PaymentTextBox.Text + "','" + BalanceLabel1.Text + "','" + Transaction_DateLabel1.Text + "')"
        ExecuteQuery(insertquery)
        MsgBox(" Rent Success! ")

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()

        Last_NameTextBox.Clear()
        First_NameTextBox.Clear()
        Middle_NameTextBox.Clear()
        AddressTextBox.Clear()
        Valid_ID_sCheckedListBox.ClearSelected()
        License_ID_NoTextBox.Clear()
        Contact_NoTextBox.Clear()
        WorkTextBox.Clear()
        Purpose_of_RentTextBox.Clear()
        CategoryLabel1.ResetText()
        ModelLabel1.ResetText()
        BrandLabel1.ResetText()
        TransmissionLabel1.ResetText()
        'Rental_fee_per_DayLabel1.ResetText()
        NameLabel1.ResetText()
        Pick_up_LocationTextBox.Clear()
        Drop_off_LocationTextBox.Clear()
        Pick_up_DateDateTimePicker.ResetText()
        Return_DateDateTimePicker.ResetText()
        'Total_DaysLabel1.ResetText()
        'Total_AmountLabel1.ResetText()
        Type_of_PaymentComboBox.ResetText()
        PaymentTextBox.Clear()
        'BalanceLabel1.ResetText()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font_name As String = "Times New Roman"
        Dim font_size As Integer = 16
        Dim csz As New PaperSize("Custom Paper Size", 1, 2)
        ' PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSize = csz
        Dim interval As Integer = 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 20, interval)
        interval += 30

        e.Graphics.DrawString("                             E'n'L Car Rental", New Font(font_name, 11, FontStyle.Bold), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 20, interval)
        interval += 30

        e.Graphics.DrawString("Name : " + NameLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Category : " + CategoryLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Brand : " + BrandLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Model : " + ModelLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Rental Fee per Day : Php " + Rental_fee_per_DayLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Pick Up Location : " + Pick_up_LocationTextBox.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Drop off Location : " + Drop_off_LocationTextBox.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Pick up Date : " + Pick_up_DateDateTimePicker.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Return Date : " + Return_DateDateTimePicker.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Total of Days : " + Total_DaysLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Total Amount : Php " + Total_AmountLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Total of Payment : " + Type_of_PaymentComboBox.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Payment : Php " + PaymentTextBox.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Balance : Php " + BalanceLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30

        e.Graphics.DrawString("Transaction Date: " + Transaction_DateLabel1.Text, New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 25, interval)
        interval += 30
    End Sub

    Private Sub NameLabel1_Click_1(sender As Object, e As EventArgs) Handles NameLabel1.Click
        NameLabel1.Text = First_NameTextBox.Text + " " + Last_NameTextBox.Text
    End Sub
End Class