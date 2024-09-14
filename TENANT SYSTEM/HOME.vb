Imports MySql.Data.MySqlClient

Public Class HomeFrm

    ' On form load, populate all ComboBoxes and DataGridView
    Private Sub HomeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTenantsIntoComboBoxes()
        RefreshTenantDataGrid()
        LoadComboBoxData() ' For payment/debt ComboBox population
    End Sub

    ' Load tenants' details into ComboBoxes
    Private Sub LoadTenantsIntoComboBoxes()
        Try
            Dim connString As String = "server=localhost;user id=root;password=your_password;database=tenant_system"
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT tenant_id, name, email, house_no, phone, address FROM tenants"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear previous items
                        IDCombobox.Items.Clear()
                        NameCombobox.Items.Clear()
                        EmailCombobox.Items.Clear()
                        HseNoComboBox.Items.Clear()
                        PhoneComboBox.Items.Clear()
                        AddressComboBox.Items.Clear()

                        ' Populate ComboBoxes with tenant details
                        While reader.Read()
                            IDCombobox.Items.Add(reader("tenant_id").ToString())
                            NameCombobox.Items.Add(reader("name").ToString())
                            EmailCombobox.Items.Add(reader("email").ToString())
                            HseNoComboBox.Items.Add(reader("house_no").ToString())
                            PhoneComboBox.Items.Add(reader("phone").ToString())
                            AddressComboBox.Items.Add(reader("address").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        End Try
    End Sub

    ' Refresh the DataGridView with tenants' data
    Private Sub RefreshTenantDataGrid()
        Try
            Dim connString As String = "server=localhost;user id=root;password=your_password;database=tenant_system"
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT * FROM tenants"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DatagridTenants.DataSource = table ' Bind the data to DataGridView
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        End Try
    End Sub

    ' Add a new tenant
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim tenantName As String = InputBox("Enter Tenant Name:")
        Dim tenantEmail As String = InputBox("Enter Tenant Email:")
        Dim houseNo As String = InputBox("Enter House No:")
        Dim tenantPhone As String = InputBox("Enter Tenant Phone:")
        Dim tenantAddress As String = InputBox("Enter Tenant Address:")

        If String.IsNullOrEmpty(tenantName) OrElse String.IsNullOrEmpty(tenantEmail) Then
            MessageBox.Show("Tenant Name and Email are required.")
            Return
        End If

        Try
            Dim connString As String = "server=localhost;user id=root;password=your_password;database=tenant_system"
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO tenants (name, email, house_no, phone, address) VALUES (@name, @email, @house_no, @phone, @address)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", tenantName)
                    cmd.Parameters.AddWithValue("@email", tenantEmail)
                    cmd.Parameters.AddWithValue("@house_no", houseNo)
                    cmd.Parameters.AddWithValue("@phone", tenantPhone)
                    cmd.Parameters.AddWithValue("@address", tenantAddress)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Tenant added successfully.")
            LoadTenantsIntoComboBoxes() ' Refresh combo boxes
            RefreshTenantDataGrid()     ' Refresh data grid
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        End Try
    End Sub

    ' Delete selected tenant
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim selectedTenantID As String = IDCombobox.SelectedItem.ToString()

        If String.IsNullOrEmpty(selectedTenantID) Then
            MessageBox.Show("Please select a tenant to delete.")
            Return
        End If

        Try
            Dim connString As String = "server=localhost;user id=root;password=your_password;database=tenant_system"
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "DELETE FROM tenants WHERE tenant_id = @tenant_id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@tenant_id", selectedTenantID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Tenant deleted successfully.")
            LoadTenantsIntoComboBoxes() ' Refresh combo boxes
            RefreshTenantDataGrid()     ' Refresh data grid
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        End Try
    End Sub

    ' Save or update tenant details (for tenant update functionality)
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim tenantID As String = IDCombobox.SelectedItem.ToString()
        Dim tenantName As String = NameCombobox.SelectedItem.ToString()
        Dim tenantEmail As String = EmailCombobox.SelectedItem.ToString()
        Dim houseNo As String = HseNoComboBox.SelectedItem.ToString()
        Dim tenantPhone As String = PhoneComboBox.SelectedItem.ToString()
        Dim tenantAddress As String = AddressComboBox.SelectedItem.ToString()

        Try
            Dim connString As String = "server=localhost;user id=root;password=your_password;database=tenant_system"
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "UPDATE tenants SET name = @name, email = @email, house_no = @house_no, phone = @phone, address = @address WHERE tenant_id = @tenant_id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@tenant_id", tenantID)
                    cmd.Parameters.AddWithValue("@name", tenantName)
                    cmd.Parameters.AddWithValue("@email", tenantEmail)
                    cmd.Parameters.AddWithValue("@house_no", houseNo)
                    cmd.Parameters.AddWithValue("@phone", tenantPhone)
                    cmd.Parameters.AddWithValue("@address", tenantAddress)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Tenant updated successfully.")
            LoadTenantsIntoComboBoxes() ' Refresh combo boxes
            RefreshTenantDataGrid()     ' Refresh data grid
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        End Try
    End Sub

    ' Handle DataGridView cell click
    Private Sub DatagridTenants_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridTenants.CellContentClick
        Dim selectedRow As DataGridViewRow = DatagridTenants.Rows(e.RowIndex)
        IDCombobox.Text = selectedRow.Cells("tenant_id").Value.ToString()
        NameCombobox.Text = selectedRow.Cells("name").Value.ToString()
        EmailCombobox.Text = selectedRow.Cells("email").Value.ToString()
        HseNoComboBox.Text = selectedRow.Cells("house_no").Value.ToString()
        PhoneComboBox.Text = selectedRow.Cells("phone").Value.ToString()
        AddressComboBox.Text = selectedRow.Cells("address").Value.ToString()
    End Sub

    ' Load Payment and Debt ComboBox Data
    Private Sub LoadComboBoxData()
        Try
            Dim connString As String = "server=localhost;user id=root;password=your_password;database=tenant_system"
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Load tenant IDs
                Dim query As String = "SELECT tenant_id FROM tenants"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Tenant_IDComboBox.Items.Add(reader("tenant_id").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        End Try
    End Sub

    ' Save or Update Debt Information
    Private Sub SaveButtn_Click(sender As Object, e As EventArgs) Handles SaveButtn.Click
        Try
            Dim connString As String = "server=localhost;user id=root;password=your_password;database=tenant_system"
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "UPDATE debts SET debt_amount = @debt_amount, months_owed = @months_owed, last_payment_date = @last_payment_date WHERE tenant_id = @tenant_id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@tenant_id", ComboBoxID.Text)
                    cmd.Parameters.AddWithValue("@debt_amount", ComboBoxDebt.Text)
                    cmd.Parameters.AddWithValue("@months_owed", ComboBoxMonthsOwed.Text)
                    cmd.Parameters.AddWithValue("@last_payment_date", ComboBoxLastpayDate.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Debt updated successfully.")
                    ' Refresh debt data after saving
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        End Try
    End Sub

End Class
