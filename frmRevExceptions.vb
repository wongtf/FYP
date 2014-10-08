Public Class frmRevExceptions

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            ErrorProvider1.SetError(txtPAN, "")
            picOK.Visible = False
            picFail.Visible = False
            lbOld.Text = ""

            If (Trim(txtPAN.Text) = "") Then
                ErrorProvider1.SetError(txtPAN, "Account Number cannot be blank.")
                picFail.Visible = True
                Exit Sub
            End If

            Dim szSQL As String
            Dim dwReturnRow As Integer

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            szSQL = "EXEC sp_movereversedata '" & cbFileDate.Text & "','" & Trim(txtPAN.Text) & "'"

            dwReturnRow = ExecuteSQL(szSQL)
            If (dwReturnRow > 0) Then
                picOK.Visible = True
                lbOld.Text = txtPAN.Text

                UpdateAuditLog("Reverse destroy card for card no " & Trim(txtPAN.Text), "Production")

                txtPAN.Focus()
                txtPAN.Clear()
            Else
                ErrorProvider1.SetError(txtPAN, "Account Number is incorrect or update is not possible.")
                picFail.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show("frmRevException_btnOK_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub txtPAN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPAN.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnOK_Click(Me, e)
        End Select
    End Sub

    Private Sub frmRevExceptions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                DialogResult = Windows.Forms.DialogResult.Abort
        End Select
    End Sub

    Private Sub frmRevExceptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Reverse destroy card list", "Audit Log")
        'Get all report file name in TempReport table
        Dim myconn As New oledb.oledbConnection(gszConnString)
        Dim szSQL As String

        szSQL = "SELECT DISTINCT(data_filedate) FROM data ORDER BY data_filedate"

        cbFileDate.Items.Clear()

        Dim myCmd As New oledb.oledbCommand(szSQL, myconn)
        Dim datareader As OleDb.OleDbDataReader = Nothing

        myconn.Open()
        myCmd.CommandTimeout = 0
        datareader = myCmd.ExecuteReader()

        While datareader.Read()
            cbFileDate.Items.Add(datareader("data_filedate"))
        End While

        datareader.Close()
        myconn.Close()

        Select Case cbFileDate.Items.Count
            Case 0
                cbFileDate.SelectedIndex = -1
            Case 1
                cbFileDate.SelectedIndex = 0
            Case Else
                cbFileDate.SelectedIndex = cbFileDate.Items.Count - 1
        End Select

    End Sub

    Private Sub txtCDSNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                btnOK_Click(Me, e)
        End Select

    End Sub

End Class