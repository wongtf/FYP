Public Class frmDataSetupMainMenu

    Private Sub frmDataSetupMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshTreeView()
    End Sub

    Private Sub RefreshTreeView()

        Try
            TreeView1.Nodes.Clear()

            Dim szDataSetup As String

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM DataSetupSpec Where job_bank_id=" & BankInfo.Id & " And ds_deleted=0 Order by ds_name ASC"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("ds_id")) = False) Then
                    szDataSetup = IIf(IsDBNull(datareader("ds_name")), "", datareader("ds_name"))

                    Dim nodp As New Windows.Forms.TreeNode(szDataSetup, 0, 1)
                    nodp.Tag = datareader("ds_id")
                    TreeView1.Nodes.Add(nodp)
                End If

            End While
            datareader.Close()
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("RefreshData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub RefreshData(ByVal szId As String)

        Try
            If (szId = "") Then
                Exit Sub
            End If

            'ClearControlBox()

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            myCmd.Connection = myconn

            'Retrieve the job information
            myCmd.CommandText = "SELECT * FROM DataSetupSpec WHERE ds_id=" & szId & ""
            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                lblDataSetupID.Text = IIf(IsDBNull(datareader("ds_id")), "", datareader("ds_id"))
                txtDataSetupName.Text = IIf(IsDBNull(datareader("ds_name")), "", datareader("ds_name"))
                txtDefinition.Text = IIf(IsDBNull(datareader("ds_description")), "", datareader("ds_description"))
                txtRecordLength.Text = IIf(IsDBNull(datareader("ds_recordsize")), "", datareader("ds_recordsize"))
                txtRecordSeparator.Text = IIf(IsDBNull(datareader("ds_recordseparator")), "", datareader("ds_recordseparator"))
                txtFileHeaderSize.Text = IIf(IsDBNull(datareader("ds_headersize")), "", datareader("ds_headersize"))
                txtFileTrailerSize.Text = IIf(IsDBNull(datareader("ds_trailersize")), "", datareader("ds_trailersize"))
                txtFIRRef.Text = IIf(IsDBNull(datareader("ds_FIRRef")), "", datareader("ds_FIRRef"))
                txtFldChkID.Text = IIf(IsDBNull(datareader("ds_ChkFld")), "", datareader("ds_ChkFld"))
                txtFldChkValue.Text = IIf(IsDBNull(datareader("ds_chkvalue")), "", datareader("ds_chkvalue"))
                Exit While
            End While

            If Trim(txtRecordSeparator.Text) = "" Then
                rbRecordSep0.Checked = True
            Else
                rbRecordSep1.Checked = True
            End If

            datareader.Close()
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("RefreshData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub ClearControlBox()
        lblDataSetupID.Text = ""
        txtDataSetupName.Text = ""
        txtDefinition.Text = ""
        txtRecordLength.Text = "0"
        txtRecordSeparator.Text = ""
        txtFileHeaderSize.Text = "0"
        txtFileTrailerSize.Text = "0"
        txtFIRRef.Text = ""
        txtFldChkID.Text = ""
        txtFldChkValue.Text = ""
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            Dim szId As String
            szId = TreeView1.SelectedNode.Tag

            RefreshData(szId)

        Catch ex As Exception
            MessageBox.Show("frmDataSetupMainMenu_TreeView1_AfterSelect: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        ClearControlBox()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        AddModifyDataSetup(True)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If lblDataSetupID.Text <> "" Then
            AddModifyDataSetup(False)
        End If
    End Sub

    Private Sub AddModifyDataSetup(ByVal boolAddFlag As Boolean)
        Try
            Dim szDataSetupName As String = ""
            Dim szDefinition As String = ""
            Dim dwRecordLength As Integer = 0
            Dim szRecordSeparator As String = ""
            Dim dwFileHeaderSize As Integer = 0
            Dim dwFileTrailerSize As Integer = 0
            Dim szFIRRef As String = ""
            Dim szFldChkID As String = ""
            Dim szFldChkValue As String = ""

            Dim dwCount As Integer
            Dim szSQL As String = ""
            Dim dwDataSetupID As Integer
            Dim dwReturnRow As Integer
            Dim szAuditText As String = ""

            szDataSetupName = Trim(txtDataSetupName.Text)
            If szDataSetupName = "" Then Exit Sub
            szDefinition = Trim(txtDefinition.Text)

            If rbRecordSep0.Checked = True Then
                If Trim(txtRecordLength.Text) <> "" Then
                    dwRecordLength = CLng(Trim(txtRecordLength.Text))
                End If
            Else
                szRecordSeparator = Trim(txtRecordSeparator.Text)
            End If
            If Trim(txtFileHeaderSize.Text) <> "" Then
                dwFileHeaderSize = CLng(Trim(txtFileHeaderSize.Text))
            End If
            If Trim(txtFileTrailerSize.Text) <> "" Then
                dwFileTrailerSize = CLng(Trim(txtFileTrailerSize.Text))
            End If

            szFIRRef = Trim(txtFIRRef.Text)
            szFldChkID = Trim(txtFldChkID.Text)
            szFldChkValue = Trim(txtFldChkValue.Text)

            If boolAddFlag = True Then  'add new record
                'check the datasetup name already in the db
                dwCount = GetCountSQL("SELECT * FROM DataSetupSpec where ds_name='" & szDataSetupName & "'")
                If dwCount <= 0 Then
                    'Add new record
                    szSQL = "INSERT INTO DataSetupSpec (job_bank_id, ds_name, ds_description, ds_recordsize, ds_recordseparator, " & _
                            "ds_headersize, ds_trailersize, ds_FIRRef, ds_chkfld, ds_chkvalue) VALUES (" & UserInfo.BankId & ", '" & _
                            szDataSetupName & "', '" & szDefinition & "', " & dwRecordLength & ", '" & szRecordSeparator & "', " & _
                            dwFileHeaderSize & ", " & dwFileTrailerSize & ", '" & szFIRRef & "', '" & szFldChkID & "', '" & _
                            szFldChkValue & "')"
                    szAuditText = "Add new Data Design format [" & szDataSetupName & "]"
                Else
                    MessageBox.Show("Record already exists.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                dwDataSetupID = CLng(Trim(lblDataSetupID.Text))
                szSQL = "UPDATE DataSetupSpec SET ds_description='" & szDefinition & "', ds_recordsize=" & dwRecordLength & _
                ", ds_recordseparator='" & szRecordSeparator & "', ds_headersize=" & dwFileHeaderSize & _
                ", ds_trailersize=" & dwFileTrailerSize & ", ds_FIRRef='" & szFIRRef & "', ds_chkfld='" & _
                szFldChkID & "', ds_chkvalue='" & szFldChkValue & "' WHERE ds_id = " & dwDataSetupID
                szAuditText = "Edit Data Design format [" & szDataSetupName & "]"
            End If

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving datasetup record.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("DataSetup record not found. No record deleted.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 1
                    MessageBox.Show("One Record saved.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshTreeView()
                    UpdateAuditLog(szAuditText, "Setup")
            End Select
            ClearControlBox()
        Catch ex As Exception
            MessageBox.Show("frmDataSetupMainMenu_AddModifyDataSetup: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim szSQL As String
        Dim dwReturnRow As Integer
        Dim dwDataSetupId As Integer
        Dim szDataSetupName As String
        If Trim(lblDataSetupID.Text) <> "" Then
            dwDataSetupId = CLng(Trim(lblDataSetupID.Text))
            szDataSetupName = Trim(txtDataSetupName.Text)
            If (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

            szSQL = "DELETE From DataSetupSpec WHERE ds_id = " & dwDataSetupId
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting data field record.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("Data Field record not found. No record deleted.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 1
                    MessageBox.Show("One Record deleted.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearControlBox()
                    UpdateAuditLog("Delete Data Design format [" & szDataSetupName & "]", "Setup")
                    RefreshTreeView()
            End Select
        End If
    End Sub

    Private Sub cmdDetailsDef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetailsDef.Click
        Dim dwDataSetupId As Integer
        If Trim(lblDataSetupID.Text) <> "" Then
            dwDataSetupId = CLng(Trim(lblDataSetupID.Text))
        Else
            Exit Sub
        End If
        frmDataSetup.lblDataSetupID.Text = dwDataSetupId
        frmDataSetup.ShowDialog()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Dispose()
    End Sub

End Class