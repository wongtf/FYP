Public Class frmExceptions

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            ErrorProvider1.SetError(txtPAN, "")
            ErrorProvider1.SetError(txtCDSNo, "")
            picOK.Visible = False
            picFail.Visible = False
            lbOld.Text = ""

            If (Trim(txtCDSNo.Text) = "") And (Trim(txtPAN.Text) = "") Then
                ErrorProvider1.SetError(txtCDSNo, "AWB or Account Number cannot be blank.")
                picFail.Visible = True
                Exit Sub
            End If

            If (Trim(txtCDSNo.Text) <> "") And (Trim(txtPAN.Text) <> "") Then
                ErrorProvider1.SetError(txtCDSNo, "AWB and Account Number cannot be enter at the same time.")
                picFail.Visible = True
                Exit Sub
            End If

            Dim szSQL As String
            Dim dwReturnRow As Integer

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            If (Trim(txtCDSNo.Text) <> "") Then
                szSQL = "EXEC sp_movedata 0,'" & cbFileDate.Text & "','" & Trim(txtCDSNo.Text) & "'"
            Else
                szSQL = "EXEC sp_movedata 1,'" & cbFileDate.Text & "','" & Trim(txtPAN.Text) & "'"
            End If

            dwReturnRow = ExecuteSQL(szSQL)
            If (dwReturnRow > 0) Then
                picOK.Visible = True
                lbOld.Text = txtPAN.Text

                If (Trim(txtCDSNo.Text) <> "") Then
                    UpdateAuditLog("Destroy card for CDSNo " & Trim(txtCDSNo.Text), "Production")
                    txtCDSNo.Focus()
                Else
                    UpdateAuditLog("Destroy card for CardNo " & Trim(txtPAN.Text), "Production")
                    txtPAN.Focus()
                End If

                txtCDSNo.Clear()
                txtPAN.Clear()
            Else
                ErrorProvider1.SetError(txtCDSNo, "AWB or Account Number is incorrect or update is not possible.")
                picFail.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show("frmException_btnOK_Click: Exception-" & ex.Message)
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

    Private Sub frmExceptions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                DialogResult = Windows.Forms.DialogResult.Abort
        End Select
    End Sub

    Private Sub frmExceptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Destroy card list", "Audit Log")
        'Get all report file name in TempReport table
        Dim myconn As New oledb.oledbConnection(gszConnString)
        Dim szSQL As String

        szSQL = "SELECT DISTINCT(data_filedate) FROM data ORDER BY data_filedate"

        cbFileDate.Items.Clear()

        Dim myCmd As New oledb.oledbCommand(szSQL, myconn)
        Dim datareader As OleDb.OleDbDataReader = Nothing

        myconn.Open()
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

    Private Sub txtCDSNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCDSNo.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnOK_Click(Me, e)
        End Select

    End Sub

    Private Sub cbFileDate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFileDate.SelectedIndexChanged
        txtCDSNo.Focus()
    End Sub

End Class