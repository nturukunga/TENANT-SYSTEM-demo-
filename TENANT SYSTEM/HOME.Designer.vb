<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeFrm
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        HseNoComboBox = New ComboBox()
        Label7 = New Label()
        BtnSave = New Button()
        BtnDelete = New Button()
        BtnAdd = New Button()
        DatagridTenants = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        NameCombobox = New ComboBox()
        EmailCombobox = New ComboBox()
        PhoneComboBox = New ComboBox()
        AddressComboBox = New ComboBox()
        IDCombobox = New ComboBox()
        LblDate = New Label()
        LblAddress = New Label()
        LblPhone = New Label()
        LblEmail = New Label()
        LblName = New Label()
        LblID = New Label()
        TabPage2 = New TabPage()
        StatusComboBox = New ComboBox()
        Label3 = New Label()
        PaymentsDatagrid = New DataGridView()
        SaveBtn = New Button()
        DeleteBtn = New Button()
        AddBtn = New Button()
        DateTimePicker2 = New DateTimePicker()
        Tenant_IDComboBox = New ComboBox()
        AmountComboBox = New ComboBox()
        MethodComboBox = New ComboBox()
        ComboBox10 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TabPage3 = New TabPage()
        DataGridViewTenantswithmostmonthsunpaid = New DataGridView()
        DataGridViewDebts = New DataGridView()
        ComboBoxLastpayDate = New ComboBox()
        Label8 = New Label()
        SaveButtn = New Button()
        DelButtn = New Button()
        AddButtn = New Button()
        ComboBoxTenant_ID = New ComboBox()
        ComboBoxDebt = New ComboBox()
        ComboBoxMonthsOwed = New ComboBox()
        ComboBoxID = New ComboBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        TabPage4 = New TabPage()
        DataGridView1 = New DataGridView()
        UpdateButton = New Button()
        SaveButton = New Button()
        DeleteButton = New Button()
        AddButton = New Button()
        ComboBox17 = New ComboBox()
        ComboBox18 = New ComboBox()
        ComboBox19 = New ComboBox()
        ComboBox20 = New ComboBox()
        Label9 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DatagridTenants, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PaymentsDatagrid, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(DataGridViewTenantswithmostmonthsunpaid, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewDebts, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(2, 1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(994, 580)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Black
        TabPage1.Controls.Add(HseNoComboBox)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(BtnSave)
        TabPage1.Controls.Add(BtnDelete)
        TabPage1.Controls.Add(BtnAdd)
        TabPage1.Controls.Add(DatagridTenants)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(NameCombobox)
        TabPage1.Controls.Add(EmailCombobox)
        TabPage1.Controls.Add(PhoneComboBox)
        TabPage1.Controls.Add(AddressComboBox)
        TabPage1.Controls.Add(IDCombobox)
        TabPage1.Controls.Add(LblDate)
        TabPage1.Controls.Add(LblAddress)
        TabPage1.Controls.Add(LblPhone)
        TabPage1.Controls.Add(LblEmail)
        TabPage1.Controls.Add(LblName)
        TabPage1.Controls.Add(LblID)
        TabPage1.ForeColor = SystemColors.ActiveBorder
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(986, 544)
        TabPage1.TabIndex = 3
        TabPage1.Text = "Tenants"
        ' 
        ' HseNoComboBox
        ' 
        HseNoComboBox.FormattingEnabled = True
        HseNoComboBox.Location = New Point(204, 147)
        HseNoComboBox.Name = "HseNoComboBox"
        HseNoComboBox.Size = New Size(205, 31)
        HseNoComboBox.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.LawnGreen
        Label7.Location = New Point(42, 150)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 23)
        Label7.TabIndex = 17
        Label7.Text = "HOUSE NO"
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(309, 225)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(112, 34)
        BtnSave.TabIndex = 16
        BtnSave.Text = "SAVE"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(174, 225)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(112, 34)
        BtnDelete.TabIndex = 15
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(42, 225)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(112, 34)
        BtnAdd.TabIndex = 14
        BtnAdd.Text = "ADD"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' DatagridTenants
        ' 
        DatagridTenants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DatagridTenants.Location = New Point(42, 318)
        DatagridTenants.Name = "DatagridTenants"
        DatagridTenants.RowHeadersWidth = 62
        DatagridTenants.Size = New Size(901, 175)
        DatagridTenants.TabIndex = 13
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(610, 118)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(366, 31)
        DateTimePicker1.TabIndex = 12
        ' 
        ' NameCombobox
        ' 
        NameCombobox.FormattingEnabled = True
        NameCombobox.Location = New Point(204, 65)
        NameCombobox.Name = "NameCombobox"
        NameCombobox.Size = New Size(205, 31)
        NameCombobox.TabIndex = 11
        ' 
        ' EmailCombobox
        ' 
        EmailCombobox.FormattingEnabled = True
        EmailCombobox.Location = New Point(204, 108)
        EmailCombobox.Name = "EmailCombobox"
        EmailCombobox.Size = New Size(205, 31)
        EmailCombobox.TabIndex = 10
        ' 
        ' PhoneComboBox
        ' 
        PhoneComboBox.FormattingEnabled = True
        PhoneComboBox.Location = New Point(610, 22)
        PhoneComboBox.Name = "PhoneComboBox"
        PhoneComboBox.Size = New Size(205, 31)
        PhoneComboBox.TabIndex = 9
        ' 
        ' AddressComboBox
        ' 
        AddressComboBox.FormattingEnabled = True
        AddressComboBox.Location = New Point(610, 65)
        AddressComboBox.Name = "AddressComboBox"
        AddressComboBox.Size = New Size(205, 31)
        AddressComboBox.TabIndex = 8
        ' 
        ' IDCombobox
        ' 
        IDCombobox.FormattingEnabled = True
        IDCombobox.Location = New Point(204, 22)
        IDCombobox.Name = "IDCombobox"
        IDCombobox.Size = New Size(205, 31)
        IDCombobox.TabIndex = 6
        ' 
        ' LblDate
        ' 
        LblDate.AutoSize = True
        LblDate.ForeColor = Color.LawnGreen
        LblDate.Location = New Point(448, 118)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(156, 23)
        LblDate.TabIndex = 5
        LblDate.Text = "MOVE IN DATE"
        ' 
        ' LblAddress
        ' 
        LblAddress.AutoSize = True
        LblAddress.ForeColor = Color.LawnGreen
        LblAddress.Location = New Point(448, 68)
        LblAddress.Name = "LblAddress"
        LblAddress.Size = New Size(107, 23)
        LblAddress.TabIndex = 4
        LblAddress.Text = "ADDRESS"
        ' 
        ' LblPhone
        ' 
        LblPhone.AutoSize = True
        LblPhone.ForeColor = Color.LawnGreen
        LblPhone.Location = New Point(448, 22)
        LblPhone.Name = "LblPhone"
        LblPhone.Size = New Size(82, 23)
        LblPhone.TabIndex = 3
        LblPhone.Text = "PHONE"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.ForeColor = Color.LawnGreen
        LblEmail.Location = New Point(42, 111)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(72, 23)
        LblEmail.TabIndex = 2
        LblEmail.Text = "EMAIL"
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.ForeColor = Color.LawnGreen
        LblName.Location = New Point(42, 68)
        LblName.Name = "LblName"
        LblName.Size = New Size(69, 23)
        LblName.TabIndex = 1
        LblName.Text = "NAME"
        ' 
        ' LblID
        ' 
        LblID.AutoSize = True
        LblID.ForeColor = Color.LawnGreen
        LblID.Location = New Point(60, 22)
        LblID.Name = "LblID"
        LblID.Size = New Size(31, 23)
        LblID.TabIndex = 0
        LblID.Text = "ID"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Black
        TabPage2.Controls.Add(StatusComboBox)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(PaymentsDatagrid)
        TabPage2.Controls.Add(SaveBtn)
        TabPage2.Controls.Add(DeleteBtn)
        TabPage2.Controls.Add(AddBtn)
        TabPage2.Controls.Add(DateTimePicker2)
        TabPage2.Controls.Add(Tenant_IDComboBox)
        TabPage2.Controls.Add(AmountComboBox)
        TabPage2.Controls.Add(MethodComboBox)
        TabPage2.Controls.Add(ComboBox10)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label6)
        TabPage2.ForeColor = SystemColors.ActiveBorder
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(986, 544)
        TabPage2.TabIndex = 4
        TabPage2.Text = "Payments"
        ' 
        ' StatusComboBox
        ' 
        StatusComboBox.FormattingEnabled = True
        StatusComboBox.Location = New Point(702, 19)
        StatusComboBox.Name = "StatusComboBox"
        StatusComboBox.Size = New Size(205, 31)
        StatusComboBox.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.LawnGreen
        Label3.Location = New Point(587, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 23)
        Label3.TabIndex = 34
        Label3.Text = "STATUS"
        ' 
        ' PaymentsDatagrid
        ' 
        PaymentsDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PaymentsDatagrid.Location = New Point(27, 312)
        PaymentsDatagrid.Name = "PaymentsDatagrid"
        PaymentsDatagrid.RowHeadersWidth = 62
        PaymentsDatagrid.Size = New Size(939, 215)
        PaymentsDatagrid.TabIndex = 33
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Location = New Point(428, 143)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(112, 34)
        SaveBtn.TabIndex = 31
        SaveBtn.Text = "SAVE"
        SaveBtn.UseVisualStyleBackColor = True
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Location = New Point(428, 100)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(112, 34)
        DeleteBtn.TabIndex = 30
        DeleteBtn.Text = "DELETE"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(428, 54)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(112, 34)
        AddBtn.TabIndex = 29
        AddBtn.Text = "ADD"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(28, 246)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(366, 31)
        DateTimePicker2.TabIndex = 28
        ' 
        ' Tenant_IDComboBox
        ' 
        Tenant_IDComboBox.FormattingEnabled = True
        Tenant_IDComboBox.Location = New Point(189, 65)
        Tenant_IDComboBox.Name = "Tenant_IDComboBox"
        Tenant_IDComboBox.Size = New Size(205, 31)
        Tenant_IDComboBox.TabIndex = 27
        ' 
        ' AmountComboBox
        ' 
        AmountComboBox.FormattingEnabled = True
        AmountComboBox.Location = New Point(189, 108)
        AmountComboBox.Name = "AmountComboBox"
        AmountComboBox.Size = New Size(205, 31)
        AmountComboBox.TabIndex = 26
        ' 
        ' MethodComboBox
        ' 
        MethodComboBox.FormattingEnabled = True
        MethodComboBox.Location = New Point(189, 152)
        MethodComboBox.Name = "MethodComboBox"
        MethodComboBox.Size = New Size(205, 31)
        MethodComboBox.TabIndex = 24
        ' 
        ' ComboBox10
        ' 
        ComboBox10.FormattingEnabled = True
        ComboBox10.Location = New Point(189, 22)
        ComboBox10.Name = "ComboBox10"
        ComboBox10.Size = New Size(205, 31)
        ComboBox10.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.LawnGreen
        Label1.Location = New Point(27, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 23)
        Label1.TabIndex = 22
        Label1.Text = "PAYMENT DATE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.LawnGreen
        Label2.Location = New Point(27, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 23)
        Label2.TabIndex = 21
        Label2.Text = "METHOD"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.LawnGreen
        Label4.Location = New Point(27, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 19
        Label4.Text = "AMOUNT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.LawnGreen
        Label5.Location = New Point(27, 68)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 23)
        Label5.TabIndex = 18
        Label5.Text = "TENANT_ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.LawnGreen
        Label6.Location = New Point(45, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 23)
        Label6.TabIndex = 17
        Label6.Text = "ID"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(DataGridViewTenantswithmostmonthsunpaid)
        TabPage3.Controls.Add(DataGridViewDebts)
        TabPage3.Controls.Add(ComboBoxLastpayDate)
        TabPage3.Controls.Add(Label8)
        TabPage3.Controls.Add(SaveButtn)
        TabPage3.Controls.Add(DelButtn)
        TabPage3.Controls.Add(AddButtn)
        TabPage3.Controls.Add(ComboBoxTenant_ID)
        TabPage3.Controls.Add(ComboBoxDebt)
        TabPage3.Controls.Add(ComboBoxMonthsOwed)
        TabPage3.Controls.Add(ComboBoxID)
        TabPage3.Controls.Add(Label10)
        TabPage3.Controls.Add(Label11)
        TabPage3.Controls.Add(Label12)
        TabPage3.Controls.Add(Label13)
        TabPage3.ForeColor = SystemColors.ActiveBorder
        TabPage3.Location = New Point(4, 32)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(986, 544)
        TabPage3.TabIndex = 5
        TabPage3.Text = "Debt Report"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewTenantswithmostmonthsunpaid
        ' 
        DataGridViewTenantswithmostmonthsunpaid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTenantswithmostmonthsunpaid.Location = New Point(604, 19)
        DataGridViewTenantswithmostmonthsunpaid.Name = "DataGridViewTenantswithmostmonthsunpaid"
        DataGridViewTenantswithmostmonthsunpaid.RowHeadersWidth = 62
        DataGridViewTenantswithmostmonthsunpaid.Size = New Size(360, 508)
        DataGridViewTenantswithmostmonthsunpaid.TabIndex = 51
        ' 
        ' DataGridViewDebts
        ' 
        DataGridViewDebts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewDebts.Location = New Point(25, 307)
        DataGridViewDebts.Name = "DataGridViewDebts"
        DataGridViewDebts.RowHeadersWidth = 62
        DataGridViewDebts.Size = New Size(550, 220)
        DataGridViewDebts.TabIndex = 50
        ' 
        ' ComboBoxLastpayDate
        ' 
        ComboBoxLastpayDate.FormattingEnabled = True
        ComboBoxLastpayDate.Location = New Point(214, 202)
        ComboBoxLastpayDate.Name = "ComboBoxLastpayDate"
        ComboBoxLastpayDate.Size = New Size(205, 31)
        ComboBoxLastpayDate.TabIndex = 49
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.LawnGreen
        Label8.Location = New Point(25, 202)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 23)
        Label8.TabIndex = 48
        Label8.Text = "LAST PAY DATE"
        ' 
        ' SaveButtn
        ' 
        SaveButtn.Location = New Point(463, 150)
        SaveButtn.Name = "SaveButtn"
        SaveButtn.Size = New Size(112, 34)
        SaveButtn.TabIndex = 47
        SaveButtn.Text = "SAVE"
        SaveButtn.UseVisualStyleBackColor = True
        ' 
        ' DelButtn
        ' 
        DelButtn.Location = New Point(463, 107)
        DelButtn.Name = "DelButtn"
        DelButtn.Size = New Size(112, 34)
        DelButtn.TabIndex = 46
        DelButtn.Text = "DELETE"
        DelButtn.UseVisualStyleBackColor = True
        ' 
        ' AddButtn
        ' 
        AddButtn.Location = New Point(463, 61)
        AddButtn.Name = "AddButtn"
        AddButtn.Size = New Size(112, 34)
        AddButtn.TabIndex = 45
        AddButtn.Text = "ADD"
        AddButtn.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxTenant_ID
        ' 
        ComboBoxTenant_ID.FormattingEnabled = True
        ComboBoxTenant_ID.Location = New Point(214, 72)
        ComboBoxTenant_ID.Name = "ComboBoxTenant_ID"
        ComboBoxTenant_ID.Size = New Size(205, 31)
        ComboBoxTenant_ID.TabIndex = 44
        ' 
        ' ComboBoxDebt
        ' 
        ComboBoxDebt.FormattingEnabled = True
        ComboBoxDebt.Location = New Point(214, 115)
        ComboBoxDebt.Name = "ComboBoxDebt"
        ComboBoxDebt.Size = New Size(205, 31)
        ComboBoxDebt.TabIndex = 43
        ' 
        ' ComboBoxMonthsOwed
        ' 
        ComboBoxMonthsOwed.FormattingEnabled = True
        ComboBoxMonthsOwed.Location = New Point(214, 159)
        ComboBoxMonthsOwed.Name = "ComboBoxMonthsOwed"
        ComboBoxMonthsOwed.Size = New Size(205, 31)
        ComboBoxMonthsOwed.TabIndex = 42
        ' 
        ' ComboBoxID
        ' 
        ComboBoxID.FormattingEnabled = True
        ComboBoxID.Location = New Point(214, 29)
        ComboBoxID.Name = "ComboBoxID"
        ComboBoxID.Size = New Size(205, 31)
        ComboBoxID.TabIndex = 41
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.LawnGreen
        Label10.Location = New Point(25, 162)
        Label10.Name = "Label10"
        Label10.Size = New Size(167, 23)
        Label10.TabIndex = 39
        Label10.Text = "MONTHS OWED"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.LawnGreen
        Label11.Location = New Point(25, 118)
        Label11.Name = "Label11"
        Label11.Size = New Size(65, 23)
        Label11.TabIndex = 38
        Label11.Text = "DEBT"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.LawnGreen
        Label12.Location = New Point(25, 75)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 23)
        Label12.TabIndex = 37
        Label12.Text = "TENANT_ID"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.LawnGreen
        Label13.Location = New Point(43, 29)
        Label13.Name = "Label13"
        Label13.Size = New Size(31, 23)
        Label13.TabIndex = 36
        Label13.Text = "ID"
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.Black
        TabPage4.Controls.Add(DataGridView1)
        TabPage4.Controls.Add(UpdateButton)
        TabPage4.Controls.Add(SaveButton)
        TabPage4.Controls.Add(DeleteButton)
        TabPage4.Controls.Add(AddButton)
        TabPage4.Controls.Add(ComboBox17)
        TabPage4.Controls.Add(ComboBox18)
        TabPage4.Controls.Add(ComboBox19)
        TabPage4.Controls.Add(ComboBox20)
        TabPage4.Controls.Add(Label9)
        TabPage4.Controls.Add(Label14)
        TabPage4.Controls.Add(Label15)
        TabPage4.Controls.Add(Label16)
        TabPage4.Location = New Point(4, 32)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(986, 544)
        TabPage4.TabIndex = 6
        TabPage4.Text = "Users"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(208, 259)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(513, 225)
        DataGridView1.TabIndex = 44
        ' 
        ' UpdateButton
        ' 
        UpdateButton.Location = New Point(609, 46)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(112, 34)
        UpdateButton.TabIndex = 43
        UpdateButton.Text = "UPDATE"
        UpdateButton.UseVisualStyleBackColor = True
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(609, 178)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(112, 34)
        SaveButton.TabIndex = 42
        SaveButton.Text = "SAVE"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(609, 135)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(112, 34)
        DeleteButton.TabIndex = 41
        DeleteButton.Text = "DELETE"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(609, 89)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(112, 34)
        AddButton.TabIndex = 40
        AddButton.Text = "ADD"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' ComboBox17
        ' 
        ComboBox17.FormattingEnabled = True
        ComboBox17.Location = New Point(370, 100)
        ComboBox17.Name = "ComboBox17"
        ComboBox17.Size = New Size(205, 31)
        ComboBox17.TabIndex = 39
        ' 
        ' ComboBox18
        ' 
        ComboBox18.FormattingEnabled = True
        ComboBox18.Location = New Point(370, 143)
        ComboBox18.Name = "ComboBox18"
        ComboBox18.Size = New Size(205, 31)
        ComboBox18.TabIndex = 38
        ' 
        ' ComboBox19
        ' 
        ComboBox19.FormattingEnabled = True
        ComboBox19.Location = New Point(370, 187)
        ComboBox19.Name = "ComboBox19"
        ComboBox19.Size = New Size(205, 31)
        ComboBox19.TabIndex = 37
        ' 
        ' ComboBox20
        ' 
        ComboBox20.FormattingEnabled = True
        ComboBox20.Location = New Point(370, 57)
        ComboBox20.Name = "ComboBox20"
        ComboBox20.Size = New Size(205, 31)
        ComboBox20.TabIndex = 36
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.LawnGreen
        Label9.Location = New Point(208, 190)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 23)
        Label9.TabIndex = 35
        Label9.Text = "ROLE"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.ForeColor = Color.LawnGreen
        Label14.Location = New Point(208, 146)
        Label14.Name = "Label14"
        Label14.Size = New Size(127, 23)
        Label14.TabIndex = 34
        Label14.Text = "PASSWORD"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.ForeColor = Color.LawnGreen
        Label15.Location = New Point(208, 103)
        Label15.Name = "Label15"
        Label15.Size = New Size(124, 23)
        Label15.TabIndex = 33
        Label15.Text = "USERNAME"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.ForeColor = Color.LawnGreen
        Label16.Location = New Point(226, 57)
        Label16.Name = "Label16"
        Label16.Size = New Size(31, 23)
        Label16.TabIndex = 32
        Label16.Text = "ID"
        ' 
        ' HomeFrm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 582)
        Controls.Add(TabControl1)
        Name = "HomeFrm"
        Text = "HOME"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(DatagridTenants, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PaymentsDatagrid, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(DataGridViewTenantswithmostmonthsunpaid, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewDebts, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DatagridTenants As DataGridView
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents NameCombobox As ComboBox
    Friend WithEvents EmailCombobox As ComboBox
    Friend WithEvents PhoneComboBox As ComboBox
    Friend WithEvents AddressComboBox As ComboBox
    Friend WithEvents IDCombobox As ComboBox
    Friend WithEvents LblDate As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblID As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Tenant_IDComboBox As ComboBox
    Friend WithEvents AmountComboBox As ComboBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PaymentsDatagrid As DataGridView
    Friend WithEvents MethodComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HseNoComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxLastpayDate As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SaveButtn As Button
    Friend WithEvents DelButtn As Button
    Friend WithEvents AddButtn As Button
    Friend WithEvents ComboBoxTenant_ID As ComboBox
    Friend WithEvents ComboBoxDebt As ComboBox
    Friend WithEvents ComboBoxMonthsOwed As ComboBox
    Friend WithEvents ComboBoxID As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridViewTenantswithmostmonthsunpaid As DataGridView
    Friend WithEvents DataGridViewDebts As DataGridView
    Friend WithEvents UpdateButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents ComboBox17 As ComboBox
    Friend WithEvents ComboBox18 As ComboBox
    Friend WithEvents ComboBox19 As ComboBox
    Friend WithEvents ComboBox20 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
