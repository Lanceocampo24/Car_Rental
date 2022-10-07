<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Car
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim TransmissionLabel As System.Windows.Forms.Label
        Dim Rental_fee_per_DayLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Car))
        Me.Car_RentalDataSet = New Car_Rental.Car_RentalDataSet()
        Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarsTableAdapter = New Car_Rental.Car_RentalDataSetTableAdapters.CarsTableAdapter()
        Me.TableAdapterManager = New Car_Rental.Car_RentalDataSetTableAdapters.TableAdapterManager()
        Me.CarsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CarsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.TransmissionTextBox = New System.Windows.Forms.TextBox()
        Me.Rental_fee_per_DayTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        TransmissionLabel = New System.Windows.Forms.Label()
        Rental_fee_per_DayLabel = New System.Windows.Forms.Label()
        CType(Me.Car_RentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CarsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 9)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 21)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(12, 48)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(82, 21)
        CategoryLabel.TabIndex = 3
        CategoryLabel.Text = "Category:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(12, 87)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(62, 21)
        ModelLabel.TabIndex = 5
        ModelLabel.Text = "Model:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(12, 126)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(59, 21)
        BrandLabel.TabIndex = 7
        BrandLabel.Text = "Brand:"
        '
        'TransmissionLabel
        '
        TransmissionLabel.AutoSize = True
        TransmissionLabel.Location = New System.Drawing.Point(12, 165)
        TransmissionLabel.Name = "TransmissionLabel"
        TransmissionLabel.Size = New System.Drawing.Size(113, 21)
        TransmissionLabel.TabIndex = 9
        TransmissionLabel.Text = "Transmission:"
        '
        'Rental_fee_per_DayLabel
        '
        Rental_fee_per_DayLabel.AutoSize = True
        Rental_fee_per_DayLabel.Location = New System.Drawing.Point(12, 204)
        Rental_fee_per_DayLabel.Name = "Rental_fee_per_DayLabel"
        Rental_fee_per_DayLabel.Size = New System.Drawing.Size(152, 21)
        Rental_fee_per_DayLabel.TabIndex = 11
        Rental_fee_per_DayLabel.Text = "Rental fee per Day:"
        '
        'Car_RentalDataSet
        '
        Me.Car_RentalDataSet.DataSetName = "Car_RentalDataSet"
        Me.Car_RentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarsBindingSource
        '
        Me.CarsBindingSource.DataMember = "Cars"
        Me.CarsBindingSource.DataSource = Me.Car_RentalDataSet
        '
        'CarsTableAdapter
        '
        Me.CarsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApplicationTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Car_ReportTableAdapter = Nothing
        Me.TableAdapterManager.CarsTableAdapter = Me.CarsTableAdapter
        Me.TableAdapterManager.Cash_ReportTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Car_Rental.Car_RentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarsBindingNavigator
        '
        Me.CarsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CarsBindingNavigator.BindingSource = Me.CarsBindingSource
        Me.CarsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CarsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CarsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CarsBindingNavigatorSaveItem})
        Me.CarsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CarsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CarsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CarsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CarsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CarsBindingNavigator.Name = "CarsBindingNavigator"
        Me.CarsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CarsBindingNavigator.Size = New System.Drawing.Size(263, 25)
        Me.CarsBindingNavigator.TabIndex = 0
        Me.CarsBindingNavigator.Text = "BindingNavigator1"
        Me.CarsBindingNavigator.Visible = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CarsBindingNavigatorSaveItem
        '
        Me.CarsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CarsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CarsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CarsBindingNavigatorSaveItem.Name = "CarsBindingNavigatorSaveItem"
        Me.CarsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.CarsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(51, 9)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 2
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(100, 45)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(170, 29)
        Me.CategoryTextBox.TabIndex = 4
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(80, 84)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(189, 29)
        Me.ModelTextBox.TabIndex = 6
        '
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Brand", True))
        Me.BrandTextBox.Location = New System.Drawing.Point(77, 123)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(192, 29)
        Me.BrandTextBox.TabIndex = 8
        '
        'TransmissionTextBox
        '
        Me.TransmissionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Transmission", True))
        Me.TransmissionTextBox.Location = New System.Drawing.Point(131, 162)
        Me.TransmissionTextBox.Name = "TransmissionTextBox"
        Me.TransmissionTextBox.Size = New System.Drawing.Size(139, 29)
        Me.TransmissionTextBox.TabIndex = 10
        '
        'Rental_fee_per_DayTextBox
        '
        Me.Rental_fee_per_DayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Rental fee per Day", True))
        Me.Rental_fee_per_DayTextBox.Location = New System.Drawing.Point(170, 201)
        Me.Rental_fee_per_DayTextBox.Name = "Rental_fee_per_DayTextBox"
        Me.Rental_fee_per_DayTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Rental_fee_per_DayTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 33)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Add_Car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(408, 242)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Rental_fee_per_DayLabel)
        Me.Controls.Add(Me.Rental_fee_per_DayTextBox)
        Me.Controls.Add(TransmissionLabel)
        Me.Controls.Add(Me.TransmissionTextBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.CarsBindingNavigator)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Add_Car"
        Me.Text = "Add_Car"
        CType(Me.Car_RentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CarsBindingNavigator.ResumeLayout(False)
        Me.CarsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Car_RentalDataSet As Car_RentalDataSet
    Friend WithEvents CarsBindingSource As BindingSource
    Friend WithEvents CarsTableAdapter As Car_RentalDataSetTableAdapters.CarsTableAdapter
    Friend WithEvents TableAdapterManager As Car_RentalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarsBindingNavigator As BindingNavigator
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
    Friend WithEvents CarsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents BrandTextBox As TextBox
    Friend WithEvents TransmissionTextBox As TextBox
    Friend WithEvents Rental_fee_per_DayTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
