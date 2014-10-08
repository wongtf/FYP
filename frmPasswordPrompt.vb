Public Class frmPasswordPrompt

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If txtPassword.Text.Trim = gszPassword Then
            DialogResult = Windows.Forms.DialogResult.OK
            Close()
        Else
            MsgBox("Incorrect Password Entered.", MsgBoxStyle.Exclamation, "Incorrect Password")
            txtPassword.Focus()
            txtPassword.SelectAll()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub frmPasswordPrompt_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPassword.Focus()
    End Sub

    Private Sub frmPasswordPrompt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtPassword.Text = ""
    End Sub
End Class