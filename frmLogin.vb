Public Class frmLogin
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLoginId As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbBank As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLoginId = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbBank = New System.Windows.Forms.ComboBox
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Login id"
        '
        'txtLoginId
        '
        Me.txtLoginId.Location = New System.Drawing.Point(137, 96)
        Me.txtLoginId.Name = "txtLoginId"
        Me.txtLoginId.Size = New System.Drawing.Size(184, 21)
        Me.txtLoginId.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(137, 128)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(184, 21)
        Me.txtPassword.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Location = New System.Drawing.Point(168, 160)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 22)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnClose.Location = New System.Drawing.Point(246, 160)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 22)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(315, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Note: Login id and password is case-sensitive."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(0, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 5)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "System Login"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Bank"
        '
        'cbBank
        '
        Me.cbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBank.Location = New System.Drawing.Point(137, 65)
        Me.cbBank.Name = "cbBank"
        Me.cbBank.Size = New System.Drawing.Size(184, 21)
        Me.cbBank.TabIndex = 0
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(382, 250)
        Me.Controls.Add(Me.cbBank)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLoginId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Opacity = 0.97
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Delivery Report"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try
            ErrorProvider1.SetError(cbBank, "")
            ErrorProvider1.SetError(txtLoginId, "")
            ErrorProvider1.SetError(txtPassword, "")

            If (Trim(txtLoginId.Text) = "") Then
                ErrorProvider1.SetError(txtLoginId, "Login id cannot be blank.")
                Exit Sub
            End If

            If (Trim(txtPassword.Text) = "") Then
                ErrorProvider1.SetError(txtPassword, "Password cannot be blank.")
                Exit Sub
            End If

            If (Len(Trim(txtPassword.Text)) < PASSWORD_MIN_LEN) Then
                ErrorProvider1.SetError(txtPassword, "Password must be at least " & PASSWORD_MIN_LEN & " characters long.")
                Exit Sub
            End If

            If (Trim(txtPassword.Text) = Trim(txtLoginId.Text)) Then
                ErrorProvider1.SetError(txtPassword, "Password must not be the same as login id.")
                Exit Sub
            End If

            If (AcceptablePassword(Trim(txtPassword.Text)) = False) Then
                ErrorProvider1.SetError(txtPassword, "Password must contains mixture of uppercase, lowercase and number.")
                Exit Sub
            End If


            Dim lngBankId As Long
            Dim szLoginId As String
            Dim szPassword As String

            lngBankId = FindComboId(cbBank, cbBank.SelectedIndex)
            szLoginId = Trim(txtLoginId.Text)
            szPassword = Trim(txtPassword.Text)

            Select Case GetUserInfo(lngBankId, szLoginId, szPassword, UserInfo)
                Case LOGIN_OK
                    gszPassword = szPassword
                    UpdateAuditLog("User " & txtLoginId.Text & " logged in to the system", "Audit Log")
                    DialogResult = Windows.Forms.DialogResult.OK
                Case LOGIN_FAIL
                    ErrorProvider1.SetError(txtLoginId, "Invalid login id or password.")
                    UpdateAuditLog("Invalid login id or password for " & txtLoginId.Text, "Audit Log")
                    txtLoginId.SelectAll()
                    txtLoginId.Focus()
                Case LOGIN_BARRED
                    MessageBox.Show("This user has been barred from entering to the system. Please contact administrator.", "Barred user", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UpdateAuditLog(txtLoginId.Text & " user has been barred from entering to the system", "Audit Log")
                    txtLoginId.SelectAll()
                    txtLoginId.Focus()
                Case LOGIN_REVOKED
                    MessageBox.Show("This user has been revoked. You may have entered incorrect password for " & LOGIN_DEFAULT_RETRY & " times or more. Please contact administrator.", "Revoked user", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UpdateAuditLog(txtLoginId.Text & " user has been revoked", "Audit Log")
                    txtLoginId.SelectAll()
                    txtLoginId.Focus()
                Case LOGIN_DORMANT
                    MessageBox.Show("This user has been dormant for too long, and thus it has been revoked. Please contact administrator.", "Dormant user", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UpdateAuditLog(txtLoginId.Text & " user has been dormant for too long", "Audit Log")
                    txtLoginId.SelectAll()
                    txtLoginId.Focus()
                Case LOGIN_EXPIRED
                    MessageBox.Show("Password expired for this user, and thus it has been revoked. Please contact administrator.", "Expired Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UpdateAuditLog(txtLoginId.Text & " user password expired", "Audit Log")
                    txtLoginId.SelectAll()
                    txtLoginId.Focus()
                Case LOGIN_FIRST_TIME
                    ' Display the login dialog.
                    Dim dlgFirstTime As New frmFirstTime

                    If (dlgFirstTime.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        DialogResult = Windows.Forms.DialogResult.Abort
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show("frmLogin_btnOK_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ErrorProvider1.BlinkRate = 500

            LoadAllBank()

            txtLoginId.Text = ""
            txtPassword.Text = ""
            cbBank.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        cbBank.Focus()
    End Sub

    Private Sub LoadAllBank()
        Try
            Dim szSQL As String
            szSQL = "SELECT bank_id, bank_name FROM Bank WHERE bank_deleted=0 Order by bank_name ASC"

            LoadTableCombo(cbBank, szSQL)
            cbBank.Items.Insert(0, "")

        Catch ex As Exception
            MessageBox.Show("frmLogin_LoadAllBank: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub txtLogin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoginId.GotFocus, txtPassword.GotFocus

        Try
            Dim myTextBox As TextBox = sender
            myTextBox.SelectAll()

        Catch ex As Exception
            MessageBox.Show("frmLogin_txtLoginId_GotFocus: Exception-" & ex.Message)
        End Try

    End Sub

End Class
