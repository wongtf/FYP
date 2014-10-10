Public Class frmFirstTime
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtNewPwd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirstTime))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtNewPwd1 = New System.Windows.Forms.TextBox
        Me.txtNewPwd = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(2, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 5)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(315, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Note: Password is case-sensitive."
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(274, 134)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 22)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "&Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(196, 134)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 22)
        Me.btnOK.TabIndex = 25
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txtNewPwd1
        '
        Me.txtNewPwd1.Location = New System.Drawing.Point(164, 102)
        Me.txtNewPwd1.Name = "txtNewPwd1"
        Me.txtNewPwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd1.Size = New System.Drawing.Size(184, 21)
        Me.txtNewPwd1.TabIndex = 24
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(164, 70)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(184, 21)
        Me.txtNewPwd.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Reenter new password"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "New Password"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(28, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 30)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = """First Time log-in"", ""revoked"" or ""reactivated"" user are required to reset their " & _
            "default password."
        '
        'frmFirstTime
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(382, 250)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtNewPwd1)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFirstTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Reset Password"
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
            ErrorProvider1.SetError(txtNewPwd, "")
            ErrorProvider1.SetError(txtNewPwd1, "")

            If (txtNewPwd.Text = "") Then
                ErrorProvider1.SetError(txtNewPwd, "New Password cannot be blank.")
                Exit Sub
            End If

            If (Len(Trim(txtNewPwd.Text)) < PASSWORD_MIN_LEN) Then
                ErrorProvider1.SetError(txtNewPwd, "New Password must be at least " & PASSWORD_MIN_LEN & " characters long.")
                Exit Sub
            End If

            If (AcceptablePassword(Trim(txtNewPwd.Text)) = False) Then
                ErrorProvider1.SetError(txtNewPwd, "New Password must contains mixture of uppercase, lowercase and number.")
                Exit Sub
            End If

            If (Trim(txtNewPwd.Text) = Trim(UserInfo.LoginId)) Then
                ErrorProvider1.SetError(txtNewPwd, "New Password must not be the same as login id.")
                Exit Sub
            End If

            If (Trim(txtNewPwd.Text) = DEFAULT_PASSWORD) Then
                ErrorProvider1.SetError(txtNewPwd, "Default password must not be use as new password.")
                Exit Sub
            End If

            If (txtNewPwd1.Text = "") Then
                ErrorProvider1.SetError(txtNewPwd1, "New Password cannot be blank.")
                Exit Sub
            End If

            If (txtNewPwd.Text <> txtNewPwd1.Text) Then
                ErrorProvider1.SetError(txtNewPwd1, "New Password does not match.")
                Exit Sub
            End If

            Dim szNewPwd As String

            szNewPwd = Trim(txtNewPwd.Text)

            If (SavePassword(UserInfo.Id, DEFAULT_PASSWORD, szNewPwd) = True) Then
                Dim szSQL As String
                Dim dwReturnRow As Integer

                Dim CryptographyFactory As New CryptoFactory
                Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")
                Dim szCipher As String = Cryptographer.Encrypt(szNewPwd)

                szSQL = "UPDATE Users SET usr_first_sign_in=0, usr_password='" & szCipher & "' WHERE usr_id=" & UserInfo.Id
                dwReturnRow = ExecuteSQL(szSQL)

                Select Case dwReturnRow
                    Case -1, 0
                        DialogResult = Windows.Forms.DialogResult.Abort
                    Case Else
                        DialogResult = Windows.Forms.DialogResult.OK
                        UpdateAuditLog("User password updated for userid " & UserInfo.Id, "Security")
                End Select
            Else
                DialogResult = Windows.Forms.DialogResult.Abort
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmChgPwd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ErrorProvider1.BlinkRate = 500
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewPwd.GotFocus, txtNewPwd1.GotFocus

        Try
            Dim myTextBox As TextBox = sender
            myTextBox.SelectAll()

        Catch ex As Exception

        End Try

    End Sub

End Class
