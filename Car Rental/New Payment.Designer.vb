<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Payment))
        Dim Total_AmountLabel As System.Windows.Forms.Label
        Dim Type_of_PaymentLabel As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim Transaction_DateLabel As System.Windows.Forms.Label
        Me.Car_RentalDataSet = New Car_Rental.Car_RentalDataSet()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New Car_Rental.Car_RentalDataSetTableAdapters.PaymentTableAdapter()
        Me.TableAdapterManager = New Car_Rental.Car_RentalDataSetTableAdapters.TableAdapterManager()
        Me.PaymentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PaymentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Total_AmountLabel1 = New System.Windows.Forms.Label()
        Me.Type_of_PaymentLabel1 = New System.Windows.Forms.Label()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceLabel1 = New System.Windows.Forms.Label()
        Me.Transaction_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Total_AmountLabel = New System.Windows.Forms.Label()
        Type_of_PaymentLabel = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        Transaction_DateLabel = New System.Windows.Forms.Label()
        CType(Me.Car_RentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Car_RentalDataSet
        '
        Me.Car_RentalDataSet.DataSetName = "Car_RentalDataSet"
        Me.Car_RentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.Car_RentalDataSet
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApplicationTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Car_ReportTableAdapter = Nothing
        Me.TableAdapterManager.CarsTableAdapter = Nothing
        Me.TableAdapterManager.Cash_ReportTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Me.PaymentTableAdapter
        Me.TableAdapterManager.UpdateOrder = Car_Rental.Car_RentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentBindingNavigator
        '
        Me.PaymentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PaymentBindingNavigator.BindingSource = Me.PaymentBindingSource
        Me.PaymentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PaymentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PaymentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PaymentBindingNavigatorSaveItem})
        Me.PaymentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PaymentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PaymentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PaymentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PaymentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PaymentBindingNavigator.Name = "PaymentBindingNavigator"
        Me.PaymentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PaymentBindingNavigator.Size = New System.Drawing.Size(391, 25)
        Me.PaymentBindingNavigator.TabIndex = 0
        Me.PaymentBindingNavigator.Text = "BindingNavigator1"
        Me.PaymentBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PaymentBindingNavigatorSaveItem
        '
        Me.PaymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaymentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaymentBindingNavigatorSaveItem.Name = "PaymentBindingNavigatorSaveItem"
        Me.PaymentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PaymentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Total_AmountLabel
        '
        Total_AmountLabel.AutoSize = True
        Total_AmountLabel.Location = New System.Drawing.Point(12, 9)
        Total_AmountLabel.Name = "Total_AmountLabel"
        Total_AmountLabel.Size = New System.Drawing.Size(116, 21)
        Total_AmountLabel.TabIndex = 1
        Total_AmountLabel.Text = "Total Amount:"
        '
        'Total_AmountLabel1
        '
        Me.Total_AmountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Total Amount", True))
        Me.Total_AmountLabel1.Location = New System.Drawing.Point(134, 9)
        Me.Total_AmountLabel1.Name = "Total_AmountLabel1"
        Me.Total_AmountLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Total_AmountLabel1.TabIndex = 2
        Me.Total_AmountLabel1.Text = "Label1"
        '
        'Type_of_PaymentLabel
        '
        Type_of_PaymentLabel.AutoSize = True
        Type_of_PaymentLabel.Location = New System.Drawing.Point(12, 47)
        Type_of_PaymentLabel.Name = "Type_of_PaymentLabel"
        Type_of_PaymentLabel.Size = New System.Drawing.Size(142, 21)
        Type_of_PaymentLabel.TabIndex = 3
        Type_of_PaymentLabel.Text = "Type of Payment:"
        '
        'Type_of_PaymentLabel1
        '
        Me.Type_of_PaymentLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Type of Payment", True))
        Me.Type_of_PaymentLabel1.Location = New System.Drawing.Point(160, 47)
        Me.Type_of_PaymentLabel1.Name = "Type_of_PaymentLabel1"
        Me.Type_of_PaymentLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Type_of_PaymentLabel1.TabIndex = 4
        Me.Type_of_PaymentLabel1.Text = "Label1"
        '
        'PaymentLabel
        '
        PaymentLabel.AutoSize = True
        PaymentLabel.Location = New System.Drawing.Point(12, 85)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(78, 21)
        PaymentLabel.TabIndex = 5
        PaymentLabel.Text = "Payment:"
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Payment", True))
        Me.PaymentTextBox.Location = New System.Drawing.Point(96, 82)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(100, 29)
        Me.PaymentTextBox.TabIndex = 6
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(12, 123)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(72, 21)
        BalanceLabel.TabIndex = 7
        BalanceLabel.Text = "Balance:"
        AddHandler BalanceLabel.Click, AddressOf Me.BalanceLabel_Click
        '
        'BalanceLabel1
        '
        Me.BalanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Balance", True))
        Me.BalanceLabel1.Location = New System.Drawing.Point(90, 123)
        Me.BalanceLabel1.Name = "BalanceLabel1"
        Me.BalanceLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BalanceLabel1.TabIndex = 8
        Me.BalanceLabel1.Text = "Label1"
        '
        'Transaction_DateLabel
        '
        Transaction_DateLabel.AutoSize = True
        Transaction_DateLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Transaction_DateLabel.Location = New System.Drawing.Point(12, 181)
        Transaction_DateLabel.Name = "Transaction_DateLabel"
        Transaction_DateLabel.Size = New System.Drawing.Size(114, 19)
        Transaction_DateLabel.TabIndex = 9
        Transaction_DateLabel.Text = "Transaction Date:"
        '
        'Transaction_DateDateTimePicker
        '
        Me.Transaction_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentBindingSource, "Transaction Date", True))
        Me.Transaction_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Transaction_DateDateTimePicker.Location = New System.Drawing.Point(132, 174)
        Me.Transaction_DateDateTimePicker.Name = "Transaction_DateDateTimePicker"
        Me.Transaction_DateDateTimePicker.Size = New System.Drawing.Size(120, 29)
        Me.Transaction_DateDateTimePicker.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'New_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(382, 209)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Transaction_DateLabel)
        Me.Controls.Add(Me.Transaction_DateDateTimePicker)
        Me.Controls.Add(BalanceLabel)
        Me.Controls.Add(Me.BalanceLabel1)
        Me.Controls.Add(PaymentLabel)
        Me.Controls.Add(Me.PaymentTextBox)
        Me.Controls.Add(Type_of_PaymentLabel)
        Me.Controls.Add(Me.Type_of_PaymentLabel1)
        Me.Controls.Add(Total_AmountLabel)
        Me.Controls.Add(Me.Total_AmountLabel1)
        Me.Controls.Add(Me.PaymentBindingNavigator)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "New_Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_Payment"
        CType(Me.Car_RentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentBindingNavigator.ResumeLayout(False)
        Me.PaymentBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub BalanceLabel_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Friend WithEvents Car_RentalDataSet As Car_RentalDataSet
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As Car_RentalDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents TableAdapterManager As Car_RentalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PaymentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Total_AmountLabel1 As Label
    Friend WithEvents Type_of_PaymentLabel1 As Label
    Friend WithEvents PaymentTextBox As TextBox
    Friend WithEvents BalanceLabel1 As Label
    Friend WithEvents Transaction_DateDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
