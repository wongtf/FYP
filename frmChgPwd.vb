Public Class frmChgPwd
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewPwd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrent As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChgPwd))
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtNewPwd1 = New System.Windows.Forms.TextBox
        Me.txtNewPwd = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCurrent = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Current Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(0, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 5)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(315, 23)
        Me.Label4.TabIndex = 19
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
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(196, 134)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 22)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txtNewPwd1
        '
        Me.txtNewPwd1.Location = New System.Drawing.Point(164, 102)
        Me.txtNewPwd1.Name = "txtNewPwd1"
        Me.txtNewPwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd1.Size = New System.Drawing.Size(184, 21)
        Me.txtNewPwd1.TabIndex = 2
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(164, 70)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(184, 21)
        Me.txtNewPwd.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Reenter new password"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "New Password"
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(164, 38)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrent.Size = New System.Drawing.Size(184, 21)
        Me.txtCurrent.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmChgPwd
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(382, 250)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "frmChgPwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Change Password"
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
            ErrorProvider1.SetError(txtCurrent, "")
            ErrorProvider1.SetError(txtNewPwd, "")
            ErrorProvider1.SetError(txtNewPwd1, "")

            If (txtCurrent.Text = "") Then
                ErrorProvider1.SetError(txtCurrent, "Current Password cannot be blank.")
                Exit Sub
            End If

            If (Len(Trim(txtCurrent.Text)) < PASSWORD_MIN_LEN) Then
                ErrorProvider1.SetError(txtCurrent, "Current Password must be at least " & PASSWORD_MIN_LEN & " characters long.")
                Exit Sub
            End If

            If (AcceptablePassword(Trim(txtCurrent.Text)) = False) Then
                ErrorProvider1.SetError(txtCurrent, "Current Password must contains mixture of uppercase, lowercase and number.")
                Exit Sub
            End If

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

            Dim szCurrent As String
            Dim szNewPwd As String

            szCurrent = Trim(txtCurrent.Text)
            szNewPwd = Trim(txtNewPwd.Text)

            If (IsPasswordValid(UserInfo.Id, szCurrent) = True) Then

                If (SavePassword(UserInfo.Id, szCurrent, szNewPwd) = True) Then
                    UpdateAuditLog("User Password for " & UserInfo.Id & " updated", "Audit Log")
                    DialogResult = Windows.Forms.DialogResult.OK
                End If

            Else
                ErrorProvider1.SetError(txtCurrent, "Current password is invalid.")
                txtCurrent.SelectAll()
                txtCurrent.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("frmChgPwd_btnOK_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmChgPwd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Edit User Password", "Audit Log")
        ErrorProvider1.BlinkRate = 500
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrent.GotFocus, txtNewPwd.GotFocus, txtNewPwd1.GotFocus

        Try
            Dim myTextBox As TextBox = sender
            myTextBox.SelectAll()

        Catch ex As Exception
            MessageBox.Show("frmChgPwd_txtCurrent_GotFocus: Exception-" & ex.Message)
        End Try

    End Sub

End Class
