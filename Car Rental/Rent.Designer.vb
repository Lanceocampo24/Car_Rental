<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rent
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
        Dim Applcnt_IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Valid_ID_sLabel As System.Windows.Forms.Label
        Dim License_ID_NoLabel As System.Windows.Forms.Label
        Dim Contact_NoLabel As System.Windows.Forms.Label
        Dim WorkLabel As System.Windows.Forms.Label
        Dim Purpose_of_RentLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim TransmissionLabel As System.Windows.Forms.Label
        Dim Rental_fee_per_DayLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Pick_up_LocationLabel As System.Windows.Forms.Label
        Dim Drop_off_LocationLabel As System.Windows.Forms.Label
        Dim Pick_up_DateLabel As System.Windows.Forms.Label
        Dim Return_DateLabel As System.Windows.Forms.Label
        Dim Total_DaysLabel As System.Windows.Forms.Label
        Dim Total_AmountLabel As System.Windows.Forms.Label
        Dim Type_of_PaymentLabel As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rent))
        Dim Transaction_DateLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.ApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_RentalDataSet = New Car_Rental.Car_RentalDataSet()
        Me.Purpose_of_RentTextBox = New System.Windows.Forms.TextBox()
        Me.WorkTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NoTextBox = New System.Windows.Forms.TextBox()
        Me.License_ID_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Valid_ID_sCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Applcnt_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ApplicationTableAdapter = New Car_Rental.Car_RentalDataSetTableAdapters.ApplicationTableAdapter()
        Me.TableAdapterManager = New Car_Rental.Car_RentalDataSetTableAdapters.TableAdapterManager()
        Me.CarsTableAdapter = New Car_Rental.Car_RentalDataSetTableAdapters.CarsTableAdapter()
        Me.PaymentTableAdapter = New Car_Rental.Car_RentalDataSetTableAdapters.PaymentTableAdapter()
        Me.ApplicationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ApplicationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Rental_fee_per_DayLabel1 = New System.Windows.Forms.Label()
        Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransmissionLabel1 = New System.Windows.Forms.Label()
        Me.BrandLabel1 = New System.Windows.Forms.Label()
        Me.ModelLabel1 = New System.Windows.Forms.Label()
        Me.CategoryLabel1 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CarsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BalanceLabel1 = New System.Windows.Forms.Label()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.Type_of_PaymentComboBox = New System.Windows.Forms.ComboBox()
        Me.Total_AmountLabel1 = New System.Windows.Forms.Label()
        Me.Total_DaysLabel1 = New System.Windows.Forms.Label()
        Me.Return_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Pick_up_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Drop_off_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Pick_up_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Transaction_DateLabel1 = New System.Windows.Forms.Label()
        Applcnt_IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Valid_ID_sLabel = New System.Windows.Forms.Label()
        License_ID_NoLabel = New System.Windows.Forms.Label()
        Contact_NoLabel = New System.Windows.Forms.Label()
        WorkLabel = New System.Windows.Forms.Label()
        Purpose_of_RentLabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        TransmissionLabel = New System.Windows.Forms.Label()
        Rental_fee_per_DayLabel = New System.Windows.Forms.Label()
        IDLabel1 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Pick_up_LocationLabel = New System.Windows.Forms.Label()
        Drop_off_LocationLabel = New System.Windows.Forms.Label()
        Pick_up_DateLabel = New System.Windows.Forms.Label()
        Return_DateLabel = New System.Windows.Forms.Label()
        Total_DaysLabel = New System.Windows.Forms.Label()
        Total_AmountLabel = New System.Windows.Forms.Label()
        Type_of_PaymentLabel = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        Transaction_DateLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_RentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ApplicationBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Applcnt_IDLabel
        '
        Applcnt_IDLabel.AutoSize = True
        Applcnt_IDLabel.Location = New System.Drawing.Point(6, 34)
        Applcnt_IDLabel.Name = "Applcnt_IDLabel"
        Applcnt_IDLabel.Size = New System.Drawing.Size(98, 21)
        Applcnt_IDLabel.TabIndex = 0
        Applcnt_IDLabel.Text = "Applcnt ID:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(6, 69)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(94, 21)
        Last_NameLabel.TabIndex = 2
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(6, 104)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(96, 21)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Location = New System.Drawing.Point(6, 139)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(114, 21)
        Middle_NameLabel.TabIndex = 6
        Middle_NameLabel.Text = "Middle Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(6, 174)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(77, 21)
        AddressLabel.TabIndex = 8
        AddressLabel.Text = "Address:"
        '
        'Valid_ID_sLabel
        '
        Valid_ID_sLabel.AutoSize = True
        Valid_ID_sLabel.Location = New System.Drawing.Point(6, 206)
        Valid_ID_sLabel.Name = "Valid_ID_sLabel"
        Valid_ID_sLabel.Size = New System.Drawing.Size(87, 21)
        Valid_ID_sLabel.TabIndex = 10
        Valid_ID_sLabel.Text = "Valid ID's:"
        '
        'License_ID_NoLabel
        '
        License_ID_NoLabel.AutoSize = True
        License_ID_NoLabel.Location = New System.Drawing.Point(6, 291)
        License_ID_NoLabel.Name = "License_ID_NoLabel"
        License_ID_NoLabel.Size = New System.Drawing.Size(123, 21)
        License_ID_NoLabel.TabIndex = 12
        License_ID_NoLabel.Text = "License ID No:"
        '
        'Contact_NoLabel
        '
        Contact_NoLabel.AutoSize = True
        Contact_NoLabel.Location = New System.Drawing.Point(6, 326)
        Contact_NoLabel.Name = "Contact_NoLabel"
        Contact_NoLabel.Size = New System.Drawing.Size(101, 21)
        Contact_NoLabel.TabIndex = 14
        Contact_NoLabel.Text = "Contact No:"
        '
        'WorkLabel
        '
        WorkLabel.AutoSize = True
        WorkLabel.Location = New System.Drawing.Point(6, 361)
        WorkLabel.Name = "WorkLabel"
        WorkLabel.Size = New System.Drawing.Size(55, 21)
        WorkLabel.TabIndex = 16
        WorkLabel.Text = "Work:"
        '
        'Purpose_of_RentLabel
        '
        Purpose_of_RentLabel.AutoSize = True
        Purpose_of_RentLabel.Location = New System.Drawing.Point(6, 396)
        Purpose_of_RentLabel.Name = "Purpose_of_RentLabel"
        Purpose_of_RentLabel.Size = New System.Drawing.Size(137, 21)
        Purpose_of_RentLabel.TabIndex = 18
        Purpose_of_RentLabel.Text = "Purpose of Rent:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(229, 34)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(66, 21)
        PictureLabel.TabIndex = 20
        PictureLabel.Text = "Picture:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(6, 209)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 21)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(6, 237)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(82, 21)
        CategoryLabel.TabIndex = 3
        CategoryLabel.Text = "Category:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(274, 237)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(62, 21)
        ModelLabel.TabIndex = 5
        ModelLabel.Text = "Model:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(486, 237)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(59, 21)
        BrandLabel.TabIndex = 7
        BrandLabel.Text = "Brand:"
        '
        'TransmissionLabel
        '
        TransmissionLabel.AutoSize = True
        TransmissionLabel.Location = New System.Drawing.Point(6, 265)
        TransmissionLabel.Name = "TransmissionLabel"
        TransmissionLabel.Size = New System.Drawing.Size(113, 21)
        TransmissionLabel.TabIndex = 9
        TransmissionLabel.Text = "Transmission:"
        '
        'Rental_fee_per_DayLabel
        '
        Rental_fee_per_DayLabel.AutoSize = True
        Rental_fee_per_DayLabel.Location = New System.Drawing.Point(342, 265)
        Rental_fee_per_DayLabel.Name = "Rental_fee_per_DayLabel"
        Rental_fee_per_DayLabel.Size = New System.Drawing.Size(152, 21)
        Rental_fee_per_DayLabel.TabIndex = 11
        Rental_fee_per_DayLabel.Text = "Rental fee per Day:"
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(6, 25)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(33, 21)
        IDLabel1.TabIndex = 0
        IDLabel1.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(6, 57)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(57, 21)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Name:"
        '
        'Pick_up_LocationLabel
        '
        Pick_up_LocationLabel.AutoSize = True
        Pick_up_LocationLabel.Location = New System.Drawing.Point(6, 87)
        Pick_up_LocationLabel.Name = "Pick_up_LocationLabel"
        Pick_up_LocationLabel.Size = New System.Drawing.Size(142, 21)
        Pick_up_LocationLabel.TabIndex = 4
        Pick_up_LocationLabel.Text = "Pick up Location:"
        '
        'Drop_off_LocationLabel
        '
        Drop_off_LocationLabel.AutoSize = True
        Drop_off_LocationLabel.Location = New System.Drawing.Point(6, 122)
        Drop_off_LocationLabel.Name = "Drop_off_LocationLabel"
        Drop_off_LocationLabel.Size = New System.Drawing.Size(151, 21)
        Drop_off_LocationLabel.TabIndex = 6
        Drop_off_LocationLabel.Text = "Drop off Location:"
        '
        'Pick_up_DateLabel
        '
        Pick_up_DateLabel.AutoSize = True
        Pick_up_DateLabel.Location = New System.Drawing.Point(6, 158)
        Pick_up_DateLabel.Name = "Pick_up_DateLabel"
        Pick_up_DateLabel.Size = New System.Drawing.Size(110, 21)
        Pick_up_DateLabel.TabIndex = 8
        Pick_up_DateLabel.Text = "Pick up Date:"
        '
        'Return_DateLabel
        '
        Return_DateLabel.AutoSize = True
        Return_DateLabel.Location = New System.Drawing.Point(6, 193)
        Return_DateLabel.Name = "Return_DateLabel"
        Return_DateLabel.Size = New System.Drawing.Size(103, 21)
        Return_DateLabel.TabIndex = 10
        Return_DateLabel.Text = "Return Date:"
        '
        'Total_DaysLabel
        '
        Total_DaysLabel.AutoSize = True
        Total_DaysLabel.Location = New System.Drawing.Point(6, 226)
        Total_DaysLabel.Name = "Total_DaysLabel"
        Total_DaysLabel.Size = New System.Drawing.Size(95, 21)
        Total_DaysLabel.TabIndex = 12
        Total_DaysLabel.Text = "Total Days:"
        '
        'Total_AmountLabel
        '
        Total_AmountLabel.AutoSize = True
        Total_AmountLabel.Location = New System.Drawing.Point(378, 25)
        Total_AmountLabel.Name = "Total_AmountLabel"
        Total_AmountLabel.Size = New System.Drawing.Size(116, 21)
        Total_AmountLabel.TabIndex = 14
        Total_AmountLabel.Text = "Total Amount:"
        '
        'Type_of_PaymentLabel
        '
        Type_of_PaymentLabel.AutoSize = True
        Type_of_PaymentLabel.Location = New System.Drawing.Point(378, 57)
        Type_of_PaymentLabel.Name = "Type_of_PaymentLabel"
        Type_of_PaymentLabel.Size = New System.Drawing.Size(142, 21)
        Type_of_PaymentLabel.TabIndex = 16
        Type_of_PaymentLabel.Text = "Type of Payment:"
        '
        'PaymentLabel
        '
        PaymentLabel.AutoSize = True
        PaymentLabel.Location = New System.Drawing.Point(378, 89)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(78, 21)
        PaymentLabel.TabIndex = 18
        PaymentLabel.Text = "Payment:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(378, 121)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(72, 21)
        BalanceLabel.TabIndex = 20
        BalanceLabel.Text = "Balance:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(PictureLabel)
        Me.GroupBox1.Controls.Add(Me.PicturePictureBox)
        Me.GroupBox1.Controls.Add(Purpose_of_RentLabel)
        Me.GroupBox1.Controls.Add(Me.Purpose_of_RentTextBox)
        Me.GroupBox1.Controls.Add(WorkLabel)
        Me.GroupBox1.Controls.Add(Me.WorkTextBox)
        Me.GroupBox1.Controls.Add(Contact_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Contact_NoTextBox)
        Me.GroupBox1.Controls.Add(License_ID_NoLabel)
        Me.GroupBox1.Controls.Add(Me.License_ID_NoTextBox)
        Me.GroupBox1.Controls.Add(Valid_ID_sLabel)
        Me.GroupBox1.Controls.Add(Me.Valid_ID_sCheckedListBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Middle_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Middle_NameTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Controls.Add(Applcnt_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Applcnt_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(400, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 32)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 32)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Camera"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ApplicationBindingSource, "Picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(301, 34)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(193, 166)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePictureBox.TabIndex = 21
        Me.PicturePictureBox.TabStop = False
        '
        'ApplicationBindingSource
        '
        Me.ApplicationBindingSource.DataMember = "Application"
        Me.ApplicationBindingSource.DataSource = Me.Car_RentalDataSet
        '
        'Car_RentalDataSet
        '
        Me.Car_RentalDataSet.DataSetName = "Car_RentalDataSet"
        Me.Car_RentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Purpose_of_RentTextBox
        '
        Me.Purpose_of_RentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Purpose of Rent", True))
        Me.Purpose_of_RentTextBox.Location = New System.Drawing.Point(149, 393)
        Me.Purpose_of_RentTextBox.Name = "Purpose_of_RentTextBox"
        Me.Purpose_of_RentTextBox.Size = New System.Drawing.Size(146, 29)
        Me.Purpose_of_RentTextBox.TabIndex = 19
        '
        'WorkTextBox
        '
        Me.WorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Work", True))
        Me.WorkTextBox.Location = New System.Drawing.Point(67, 358)
        Me.WorkTextBox.Name = "WorkTextBox"
        Me.WorkTextBox.Size = New System.Drawing.Size(228, 29)
        Me.WorkTextBox.TabIndex = 17
        '
        'Contact_NoTextBox
        '
        Me.Contact_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Contact No", True))
        Me.Contact_NoTextBox.Location = New System.Drawing.Point(113, 323)
        Me.Contact_NoTextBox.Name = "Contact_NoTextBox"
        Me.Contact_NoTextBox.Size = New System.Drawing.Size(182, 29)
        Me.Contact_NoTextBox.TabIndex = 15
        '
        'License_ID_NoTextBox
        '
        Me.License_ID_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "License ID No", True))
        Me.License_ID_NoTextBox.Location = New System.Drawing.Point(135, 288)
        Me.License_ID_NoTextBox.Name = "License_ID_NoTextBox"
        Me.License_ID_NoTextBox.Size = New System.Drawing.Size(160, 29)
        Me.License_ID_NoTextBox.TabIndex = 13
        '
        'Valid_ID_sCheckedListBox
        '
        Me.Valid_ID_sCheckedListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ApplicationBindingSource, "Valid ID's", True))
        Me.Valid_ID_sCheckedListBox.FormattingEnabled = True
        Me.Valid_ID_sCheckedListBox.Items.AddRange(New Object() {"NBI", "SSS", "TIN"})
        Me.Valid_ID_sCheckedListBox.Location = New System.Drawing.Point(99, 206)
        Me.Valid_ID_sCheckedListBox.Name = "Valid_ID_sCheckedListBox"
        Me.Valid_ID_sCheckedListBox.Size = New System.Drawing.Size(68, 76)
        Me.Valid_ID_sCheckedListBox.TabIndex = 11
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(89, 171)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(206, 29)
        Me.AddressTextBox.TabIndex = 9
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Middle Name", True))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(119, 136)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(176, 29)
        Me.Middle_NameTextBox.TabIndex = 7
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(110, 101)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(185, 29)
        Me.First_NameTextBox.TabIndex = 5
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(110, 66)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(185, 29)
        Me.Last_NameTextBox.TabIndex = 3
        '
        'Applcnt_IDTextBox
        '
        Me.Applcnt_IDTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Applcnt_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Applcnt_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Applcnt ID", True))
        Me.Applcnt_IDTextBox.Location = New System.Drawing.Point(110, 31)
        Me.Applcnt_IDTextBox.Name = "Applcnt_IDTextBox"
        Me.Applcnt_IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Applcnt_IDTextBox.TabIndex = 1
        '
        'ApplicationTableAdapter
        '
        Me.ApplicationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApplicationTableAdapter = Me.ApplicationTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Car_ReportTableAdapter = Nothing
        Me.TableAdapterManager.CarsTableAdapter = Me.CarsTableAdapter
        Me.TableAdapterManager.Cash_ReportTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Me.PaymentTableAdapter
        Me.TableAdapterManager.UpdateOrder = Car_Rental.Car_RentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarsTableAdapter
        '
        Me.CarsTableAdapter.ClearBeforeFill = True
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'ApplicationBindingNavigator
        '
        Me.ApplicationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ApplicationBindingNavigator.BindingSource = Me.ApplicationBindingSource
        Me.ApplicationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ApplicationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ApplicationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ApplicationBindingNavigatorSaveItem})
        Me.ApplicationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ApplicationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ApplicationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ApplicationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ApplicationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ApplicationBindingNavigator.Name = "ApplicationBindingNavigator"
        Me.ApplicationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ApplicationBindingNavigator.Size = New System.Drawing.Size(1193, 25)
        Me.ApplicationBindingNavigator.TabIndex = 1
        Me.ApplicationBindingNavigator.Text = "BindingNavigator1"
        Me.ApplicationBindingNavigator.Visible = False
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        'ApplicationBindingNavigatorSaveItem
        '
        Me.ApplicationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ApplicationBindingNavigatorSaveItem.Image = CType(resources.GetObject("ApplicationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ApplicationBindingNavigatorSaveItem.Name = "ApplicationBindingNavigatorSaveItem"
        Me.ApplicationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ApplicationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Rental_fee_per_DayLabel)
        Me.GroupBox2.Controls.Add(Me.Rental_fee_per_DayLabel1)
        Me.GroupBox2.Controls.Add(TransmissionLabel)
        Me.GroupBox2.Controls.Add(Me.TransmissionLabel1)
        Me.GroupBox2.Controls.Add(BrandLabel)
        Me.GroupBox2.Controls.Add(Me.BrandLabel1)
        Me.GroupBox2.Controls.Add(ModelLabel)
        Me.GroupBox2.Controls.Add(Me.ModelLabel1)
        Me.GroupBox2.Controls.Add(CategoryLabel)
        Me.GroupBox2.Controls.Add(Me.CategoryLabel1)
        Me.GroupBox2.Controls.Add(IDLabel)
        Me.GroupBox2.Controls.Add(Me.IDTextBox)
        Me.GroupBox2.Controls.Add(Me.CarsDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(518, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 303)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cars"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(494, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Php"
        '
        'Rental_fee_per_DayLabel1
        '
        Me.Rental_fee_per_DayLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Rental fee per Day", True))
        Me.Rental_fee_per_DayLabel1.Location = New System.Drawing.Point(540, 265)
        Me.Rental_fee_per_DayLabel1.Name = "Rental_fee_per_DayLabel1"
        Me.Rental_fee_per_DayLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Rental_fee_per_DayLabel1.TabIndex = 12
        Me.Rental_fee_per_DayLabel1.Text = "-------------"
        '
        'CarsBindingSource
        '
        Me.CarsBindingSource.DataMember = "Cars"
        Me.CarsBindingSource.DataSource = Me.Car_RentalDataSet
        '
        'TransmissionLabel1
        '
        Me.TransmissionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Transmission", True))
        Me.TransmissionLabel1.Location = New System.Drawing.Point(125, 265)
        Me.TransmissionLabel1.Name = "TransmissionLabel1"
        Me.TransmissionLabel1.Size = New System.Drawing.Size(211, 23)
        Me.TransmissionLabel1.TabIndex = 10
        Me.TransmissionLabel1.Text = "-------------"
        '
        'BrandLabel1
        '
        Me.BrandLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Brand", True))
        Me.BrandLabel1.Location = New System.Drawing.Point(551, 237)
        Me.BrandLabel1.Name = "BrandLabel1"
        Me.BrandLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BrandLabel1.TabIndex = 8
        Me.BrandLabel1.Text = "-------------"
        '
        'ModelLabel1
        '
        Me.ModelLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Model", True))
        Me.ModelLabel1.Location = New System.Drawing.Point(342, 237)
        Me.ModelLabel1.Name = "ModelLabel1"
        Me.ModelLabel1.Size = New System.Drawing.Size(138, 23)
        Me.ModelLabel1.TabIndex = 6
        Me.ModelLabel1.Text = "-------------"
        '
        'CategoryLabel1
        '
        Me.CategoryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Category", True))
        Me.CategoryLabel1.Location = New System.Drawing.Point(94, 237)
        Me.CategoryLabel1.Name = "CategoryLabel1"
        Me.CategoryLabel1.Size = New System.Drawing.Size(174, 23)
        Me.CategoryLabel1.TabIndex = 4
        Me.CategoryLabel1.Text = "-------------"
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(43, 206)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 2
        '
        'CarsDataGridView
        '
        Me.CarsDataGridView.AutoGenerateColumns = False
        Me.CarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CarsDataGridView.DataSource = Me.CarsBindingSource
        Me.CarsDataGridView.Location = New System.Drawing.Point(6, 28)
        Me.CarsDataGridView.Name = "CarsDataGridView"
        Me.CarsDataGridView.Size = New System.Drawing.Size(652, 172)
        Me.CarsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Brand"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Transmission"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Transmission"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Rental fee per Day"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Rental fee per Day"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Transaction_DateLabel)
        Me.GroupBox3.Controls.Add(Me.Transaction_DateLabel1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(BalanceLabel)
        Me.GroupBox3.Controls.Add(Me.BalanceLabel1)
        Me.GroupBox3.Controls.Add(PaymentLabel)
        Me.GroupBox3.Controls.Add(Me.PaymentTextBox)
        Me.GroupBox3.Controls.Add(Type_of_PaymentLabel)
        Me.GroupBox3.Controls.Add(Me.Type_of_PaymentComboBox)
        Me.GroupBox3.Controls.Add(Total_AmountLabel)
        Me.GroupBox3.Controls.Add(Me.Total_AmountLabel1)
        Me.GroupBox3.Controls.Add(Total_DaysLabel)
        Me.GroupBox3.Controls.Add(Me.Total_DaysLabel1)
        Me.GroupBox3.Controls.Add(Return_DateLabel)
        Me.GroupBox3.Controls.Add(Me.Return_DateDateTimePicker)
        Me.GroupBox3.Controls.Add(Pick_up_DateLabel)
        Me.GroupBox3.Controls.Add(Me.Pick_up_DateDateTimePicker)
        Me.GroupBox3.Controls.Add(Drop_off_LocationLabel)
        Me.GroupBox3.Controls.Add(Me.Drop_off_LocationTextBox)
        Me.GroupBox3.Controls.Add(Pick_up_LocationLabel)
        Me.GroupBox3.Controls.Add(Me.Pick_up_LocationTextBox)
        Me.GroupBox3.Controls.Add(NameLabel)
        Me.GroupBox3.Controls.Add(Me.NameLabel1)
        Me.GroupBox3.Controls.Add(IDLabel1)
        Me.GroupBox3.Controls.Add(Me.IDTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(518, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(664, 260)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.Car_RentalDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(454, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 21)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Php"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(494, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Php"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(545, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 32)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BalanceLabel1
        '
        Me.BalanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Balance", True))
        Me.BalanceLabel1.Location = New System.Drawing.Point(500, 122)
        Me.BalanceLabel1.Name = "BalanceLabel1"
        Me.BalanceLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BalanceLabel1.TabIndex = 21
        Me.BalanceLabel1.Text = "-------------"
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Payment", True))
        Me.PaymentTextBox.Location = New System.Drawing.Point(462, 87)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(185, 29)
        Me.PaymentTextBox.TabIndex = 19
        '
        'Type_of_PaymentComboBox
        '
        Me.Type_of_PaymentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Type of Payment", True))
        Me.Type_of_PaymentComboBox.FormattingEnabled = True
        Me.Type_of_PaymentComboBox.Location = New System.Drawing.Point(526, 53)
        Me.Type_of_PaymentComboBox.Name = "Type_of_PaymentComboBox"
        Me.Type_of_PaymentComboBox.Size = New System.Drawing.Size(121, 29)
        Me.Type_of_PaymentComboBox.TabIndex = 17
        '
        'Total_AmountLabel1
        '
        Me.Total_AmountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Total Amount", True))
        Me.Total_AmountLabel1.Location = New System.Drawing.Point(540, 22)
        Me.Total_AmountLabel1.Name = "Total_AmountLabel1"
        Me.Total_AmountLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Total_AmountLabel1.TabIndex = 15
        Me.Total_AmountLabel1.Text = "-------------"
        '
        'Total_DaysLabel1
        '
        Me.Total_DaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Total Days", True))
        Me.Total_DaysLabel1.Location = New System.Drawing.Point(107, 226)
        Me.Total_DaysLabel1.Name = "Total_DaysLabel1"
        Me.Total_DaysLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Total_DaysLabel1.TabIndex = 13
        Me.Total_DaysLabel1.Text = "-------------"
        '
        'Return_DateDateTimePicker
        '
        Me.Return_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentBindingSource, "Return Date", True))
        Me.Return_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Return_DateDateTimePicker.Location = New System.Drawing.Point(115, 187)
        Me.Return_DateDateTimePicker.Name = "Return_DateDateTimePicker"
        Me.Return_DateDateTimePicker.Size = New System.Drawing.Size(119, 29)
        Me.Return_DateDateTimePicker.TabIndex = 11
        '
        'Pick_up_DateDateTimePicker
        '
        Me.Pick_up_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentBindingSource, "Pick up Date", True))
        Me.Pick_up_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Pick_up_DateDateTimePicker.Location = New System.Drawing.Point(122, 152)
        Me.Pick_up_DateDateTimePicker.Name = "Pick_up_DateDateTimePicker"
        Me.Pick_up_DateDateTimePicker.Size = New System.Drawing.Size(119, 29)
        Me.Pick_up_DateDateTimePicker.TabIndex = 9
        '
        'Drop_off_LocationTextBox
        '
        Me.Drop_off_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Drop off Location", True))
        Me.Drop_off_LocationTextBox.Location = New System.Drawing.Point(163, 119)
        Me.Drop_off_LocationTextBox.Name = "Drop_off_LocationTextBox"
        Me.Drop_off_LocationTextBox.Size = New System.Drawing.Size(209, 29)
        Me.Drop_off_LocationTextBox.TabIndex = 7
        '
        'Pick_up_LocationTextBox
        '
        Me.Pick_up_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Pick up Location", True))
        Me.Pick_up_LocationTextBox.Location = New System.Drawing.Point(154, 84)
        Me.Pick_up_LocationTextBox.Name = "Pick_up_LocationTextBox"
        Me.Pick_up_LocationTextBox.Size = New System.Drawing.Size(218, 29)
        Me.Pick_up_LocationTextBox.TabIndex = 5
        '
        'NameLabel1
        '
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(69, 57)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(206, 23)
        Me.NameLabel1.TabIndex = 3
        Me.NameLabel1.Text = "-------------"
        '
        'IDTextBox1
        '
        Me.IDTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IDTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "ID", True))
        Me.IDTextBox1.Location = New System.Drawing.Point(43, 22)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        'PrintDocument1
        '
        '
        'Transaction_DateLabel
        '
        Transaction_DateLabel.AutoSize = True
        Transaction_DateLabel.Location = New System.Drawing.Point(295, 226)
        Transaction_DateLabel.Name = "Transaction_DateLabel"
        Transaction_DateLabel.Size = New System.Drawing.Size(140, 21)
        Transaction_DateLabel.TabIndex = 26
        Transaction_DateLabel.Text = "Transaction Date:"
        '
        'Transaction_DateLabel1
        '
        Me.Transaction_DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Transaction Date", True))
        Me.Transaction_DateLabel1.Location = New System.Drawing.Point(441, 226)
        Me.Transaction_DateLabel1.Name = "Transaction_DateLabel1"
        Me.Transaction_DateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Transaction_DateLabel1.TabIndex = 27
        Me.Transaction_DateLabel1.Text = "---------"
        '
        'Rent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1196, 593)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ApplicationBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Rent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_RentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ApplicationBindingNavigator.ResumeLayout(False)
        Me.ApplicationBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Return_DateLabel_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Car_RentalDataSet As Car_RentalDataSet
    Friend WithEvents ApplicationBindingSource As BindingSource
    Friend WithEvents ApplicationTableAdapter As Car_RentalDataSetTableAdapters.ApplicationTableAdapter
    Friend WithEvents TableAdapterManager As Car_RentalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ApplicationBindingNavigator As BindingNavigator
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
    Friend WithEvents ApplicationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PicturePictureBox As PictureBox
    Friend WithEvents Purpose_of_RentTextBox As TextBox
    Friend WithEvents WorkTextBox As TextBox
    Friend WithEvents Contact_NoTextBox As TextBox
    Friend WithEvents License_ID_NoTextBox As TextBox
    Friend WithEvents Valid_ID_sCheckedListBox As CheckedListBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Middle_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Applcnt_IDTextBox As TextBox
    Friend WithEvents CarsTableAdapter As Car_RentalDataSetTableAdapters.CarsTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CarsBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As Car_RentalDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents Rental_fee_per_DayLabel1 As Label
    Friend WithEvents TransmissionLabel1 As Label
    Friend WithEvents BrandLabel1 As Label
    Friend WithEvents ModelLabel1 As Label
    Friend WithEvents CategoryLabel1 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CarsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents Drop_off_LocationTextBox As TextBox
    Friend WithEvents Pick_up_LocationTextBox As TextBox
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BalanceLabel1 As Label
    Friend WithEvents PaymentTextBox As TextBox
    Friend WithEvents Type_of_PaymentComboBox As ComboBox
    Friend WithEvents Total_AmountLabel1 As Label
    Friend WithEvents Total_DaysLabel1 As Label
    Friend WithEvents Return_DateDateTimePicker As DateTimePicker
    Friend WithEvents Pick_up_DateDateTimePicker As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Transaction_DateLabel1 As Label
End Class
