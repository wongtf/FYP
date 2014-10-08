Public Class frmCardSetupMainMenu

    Private Sub frmCardSetupMainMenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCardSetupMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Define Card Setup", "Audit Log")
        RefreshTreeView()
        LoadDataSetupName()
    End Sub

    Private Sub RefreshTreeView()

        Try
            TreeView1.Nodes.Clear()

            Dim szCardSetup As String

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM CardSetupSpec WHERE job_bank_id=" & BankInfo.Id & " AND cs_deleted=0 Order by cs_name ASC"

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("cs_id")) = False) Then
                    szCardSetup = IIf(IsDBNull(datareader("cs_name")), "", datareader("cs_name"))

                    Dim nodp As New Windows.Forms.TreeNode(szCardSetup, 0, 1)
                    nodp.Tag = datareader("cs_id")
                    TreeView1.Nodes.Add(nodp)
                End If

            End While
            datareader.Close()
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("RefreshData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadDataSetupName()
        Try
            Dim strSQL As String = "SELECT ds_id, ds_name FROM DataSetupSpec WHERE job_bank_id=" & UserInfo.BankId & " AND ds_deleted=0 ORDER BY ds_name ASC"

            LoadTableCombo(cbDSetupName, strSQL)

        Catch ex As Exception
            MessageBox.Show("frmCardSetupMainMenu_LoadDataSetupName: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadDataSetupFldName()
        Try
            Dim szDataSetup As String
            Dim dwds_id As Integer
            szDataSetup = Trim(cbDSetupName.Text)
            If szDataSetup = "" Then Exit Sub
            dwds_id = Val(Trim(Mid(szDataSetup, 101, Len(szDataSetup) - 100)))
            Dim strSQL As String = "SELECT data_fldid, data_field_name FROM DataSetup WHERE ds_id=" & dwds_id & " ORDER BY data_field_name ASC"

            LoadTableCombo(cbCardNoFldId, strSQL)
            LoadTableCombo(cbMailerIndFldId, strSQL)

        Catch ex As Exception
            MessageBox.Show("frmCardSetupMainMenu_LoadDataSetupFldName: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub RefreshData(ByVal szId As String)

        Try
            If (szId = "") Then
                Exit Sub
            End If

            'ClearControlBox()

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing


            myconn.Open()
            myCmd.Connection = myconn

            'Retrieve the card setup information
            myCmd.CommandText = "SELECT * FROM CardSetupSpec WHERE cs_id=" & szId & ""
            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                lblCardSetupID.Text = IIf(IsDBNull(datareader("cs_id")), "", datareader("cs_id"))
                txtCardSetupName.Text = IIf(IsDBNull(datareader("cs_name")), "", datareader("cs_name"))
                txtDefinition.Text = IIf(IsDBNull(datareader("cs_definition")), "", datareader("cs_definition"))
                cbDSetupName.SelectedIndex = FindComboItem(cbDSetupName, IIf(IsDBNull(datareader("ds_id")), -1, datareader("ds_id")))
                LoadDataSetupFldName()
                cbFormType.SelectedIndex = IIf(IsDBNull(datareader("cs_mailer_type")), -1, Val(datareader("cs_mailer_type")) - 1)
                cbCardNoFldId.SelectedIndex = FindComboItem(cbCardNoFldId, IIf(IsDBNull(datareader("cs_cardid")), -1, datareader("cs_cardid")))
                cbMailerIndFldId.SelectedIndex = FindComboItem(cbMailerIndFldId, IIf(IsDBNull(datareader("cs_mailerind")), -1, datareader("cs_mailerind")))
                txtEncodeMIC.Text = IIf(IsDBNull(datareader("cs_enc_id")), "", datareader("cs_enc_id"))
                txtOCRMIC.Text = IIf(IsDBNull(datareader("cs_ocr_id")), "", datareader("cs_ocr_id"))
                txtSMCMIC.Text = IIf(IsDBNull(datareader("cs_smc_id")), "", datareader("cs_smc_id"))
                txtMailerMIC.Text = IIf(IsDBNull(datareader("cs_mailer_id")), "", datareader("cs_mailer_id"))
                txtEndRecSeparator.Text = IIf(IsDBNull(datareader("cs_endrecord_separator")), "", datareader("cs_endrecord_separator"))
                Exit While
            End While

            datareader.Close()
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmCardSetupMainMenu_RefreshData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub ClearControlBox()
        lblCardSetupID.Text = ""
        txtCardSetupName.Text = ""
        txtDefinition.Text = ""
        cbDSetupName.Text = ""
        cbFormType.Text = ""
        cbCardNoFldId.Text = ""
        cbMailerIndFldId.Text = ""
        txtEncodeMIC.Text = ""
        txtOCRMIC.Text = ""
        txtSMCMIC.Text = ""
        txtMailerMIC.Text = ""
        txtEndRecSeparator.Text = ""
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            Dim szId As String
            szId = TreeView1.SelectedNode.Tag

            RefreshData(szId)

        Catch ex As Exception
            MessageBox.Show("frmCardSetupMainMenu_TreeView1_AfterSelect: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        ClearControlBox()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        AddModifyCardSetup(True)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If lblCardSetupID.Text <> "" Then
            AddModifyCardSetup(False)
        End If
    End Sub

    Private Sub AddModifyCardSetup(ByVal boolAddFlag As Boolean)
        Try
            Dim szCardSetupName As String = ""
            Dim dwDataSetupID As Integer = 0
            Dim szDefinition As String = ""
            Dim dwFormType As Integer = 0
            Dim dwCardNoFldID As Integer = 0
            Dim dwMailerIndFldId As Integer = 0

            Dim szENCMIC As String
            Dim szOCRMIC As String
            Dim szSMCMIC As String
            Dim szMailerMIC As String
            Dim szEndRecSeparator As String

            Dim dwCount As Integer
            Dim szSQL As String = ""
            Dim dwReturnRow As Integer
            Dim dwCardSetupID As Integer = 0
            Dim szAuditText As String = ""

            szCardSetupName = Trim(txtCardSetupName.Text)
            If Trim(cbDSetupName.Text) = "" Then Exit Sub
            dwDataSetupID = Val(Trim(Mid(cbDSetupName.Text, 101, Len(cbDSetupName.Text) - 100)))
            If Trim(cbCardNoFldId.Text) = "" Then Exit Sub
            dwCardNoFldID = Val(Trim(Mid(cbCardNoFldId.Text, 101, Len(cbCardNoFldId.Text) - 100)))
            If Trim(cbMailerIndFldId.Text) = "" Then Exit Sub
            dwMailerIndFldId = Val(Trim(Mid(cbMailerIndFldId.Text, 101, Len(cbMailerIndFldId.Text) - 100)))
            If Trim(cbFormType.Text) = "" Then Exit Sub
            dwFormType = cbFormType.SelectedIndex + 1

            If szCardSetupName = "" Or dwDataSetupID = 0 Or dwDataSetupID = 0 Or dwCardNoFldID = 0 Or dwMailerIndFldId = 0 Or dwFormType = 0 Then Exit Sub
            szDefinition = Trim(txtDefinition.Text)

            szENCMIC = Trim(txtEncodeMIC.Text)
            szOCRMIC = Trim(txtOCRMIC.Text)
            szSMCMIC = Trim(txtSMCMIC.Text)
            szMailerMIC = Trim(txtMailerMIC.Text)
            szEndRecSeparator = Trim(txtEndRecSeparator.Text)

            If boolAddFlag = True Then  'add new record
                'check the datasetup name already in the db
                dwCount = GetCountSQL("SELECT * FROM CardSetupSpec where cs_name='" & szCardSetupName & "'")
                If dwCount <= 0 Then
                    'Add new record
                    szSQL = "INSERT INTO CardSetupSpec (job_bank_id, ds_id, cs_name, cs_definition, cs_mailer_type, cs_cardid, " & _
                            "cs_mailerInd, cs_Enc_ID, cs_OCR_Id, cs_SMC_Id, cs_Mailer_Id, cs_EndRecord_Separator) VALUES (" & UserInfo.BankId & ", " & _
                            dwDataSetupID & ", '" & szCardSetupName & "', '" & szDefinition & "', " & dwFormType & ", " & dwCardNoFldID & ", " & _
                            dwMailerIndFldId & ", '" & szENCMIC & "', '" & szOCRMIC & "', '" & szSMCMIC & "', '" & szMailerMIC & "', '" & szEndRecSeparator & "')"
                    szAuditText = "Add a New Card Design format [" & szCardSetupName & "]"
                Else
                    MessageBox.Show("Card Setup already exists.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                dwCardSetupID = CLng(Trim(lblCardSetupID.Text))
                szSQL = "UPDATE CardSetupSpec SET cs_definition='" & szDefinition & "', cs_mailer_type=" & dwFormType & _
                ", cs_cardid=" & dwCardNoFldID & ", cs_mailerInd=" & dwMailerIndFldId & ", cs_Enc_Id='" & szENCMIC & _
                "', cs_OCR_Id='" & szOCRMIC & "', cs_SMC_Id='" & szSMCMIC & "', cs_Mailer_Id='" & szMailerMIC & _
                "', cs_EndRecord_Separator='" & szEndRecSeparator & "' WHERE cs_id=" & dwCardSetupID
                szAuditText = "Edit Card Design format [" & szCardSetupName & "]"
            End If

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving cardsetup record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("CardSetup record not found. No record deleted.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 1
                    MessageBox.Show("One Record saved.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshTreeView()
                    UpdateAuditLog(szAuditText, "Setup")
            End Select
            If boolAddFlag = True Then
                ClearControlBox()
            End If
        Catch ex As Exception
            MessageBox.Show("frmCardSetupMainMenu_AddModifyDataSetup: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim szSQL As String
        Dim dwReturnRow As Integer
        Dim dwCardSetupId As Integer
        Dim szCardSetupName As String
        If Trim(lblCardSetupID.Text) <> "" Then
            dwCardSetupId = CLng(Trim(lblCardSetupID.Text))
            szCardSetupName = Trim(txtCardSetupName.Text)
            If (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

            szSQL = "DELETE From CardSetupSpec WHERE cs_id=" & dwCardSetupId
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting cardsetup field record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("Card Field record not found. No record deleted.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 1
                    MessageBox.Show("One Record deleted.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearControlBox()
                    RefreshTreeView()
                    UpdateAuditLog("Delete Card Design Format [" & szCardSetupName & "]", "Setup")
            End Select
        End If
    End Sub

    Private Sub cmdDetailsDef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetails.Click
        Dim dwCardSetupId As Integer
        Dim dwDataSetupId As Integer
        Dim szDataSetupName As String
        Dim szTemp As String

        If Trim(lblCardSetupID.Text) <> "" Then
            dwCardSetupId = CLng(Trim(lblCardSetupID.Text))
            szTemp = Trim(cbDSetupName.Text)
            If szTemp <> "" Then
                dwDataSetupId = Val(Trim(Mid(szTemp, 101, Len(szTemp) - 100)))
                szDataSetupName = Trim(Mid(szTemp, 1, 100))
            Else
                MsgBox("Please select one of the data setup name first!", MsgBoxStyle.Critical, "Card Setup")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        frmCardSetup.lblCardSetupID.Text = dwCardSetupId
        frmCardSetup.lblDataSetupID.Text = dwDataSetupId
        frmCardSetup.lblCardSetupName.Text = Trim(txtCardSetupName.Text)
        frmCardSetup.lblDataSetupName.Text = szDataSetupName
        frmCardSetup.ShowDialog()
    End Sub

    'Private Sub txtLeftMargin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    'only accept integers from 0 to 9
    '    If Asc(e.KeyChar) = 8 Then 'backspace
    '        e.Handled = False
    '    ElseIf Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Dispose()
    End Sub

    Private Sub cmdSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveAs.Click
        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Try
            Dim dwCardSetupID As Integer = CLng(Trim(lblCardSetupID.Text))
            If dwCardSetupID = 0 Then Exit Try
            Dim szSQL As String
            Dim dwReturnRow As Integer
            Dim szCardSetupName As String
            szCardSetupName = InputBox("New Card Setup Name?", "Card Setup")
            If szCardSetupName = "" Then Exit Sub

            'check for duplicate name given
            For i As Integer = 0 To TreeView1.Nodes.Count - 1
                If szCardSetupName = TreeView1.Nodes.Item(i).Text Then
                    MessageBox.Show("Duplicate CardSetup Name given.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next

            'Duplicate the cardsetupspec 
            szSQL = "INSERT INTO CardSetupSpec (job_bank_id, ds_id, cs_name, cs_definition, cs_mailer_type, cs_cardid, " & _
                    "cs_mailerInd, cs_Enc_ID, cs_OCR_Id, cs_SMC_Id, cs_Mailer_Id, cs_EndRecord_Separator, cs_deleted) " & _
                    "SELECT job_bank_id, ds_id, '" & szCardSetupName & "', cs_definition, cs_mailer_type, cs_cardid, " & _
                    "cs_mailerInd, cs_Enc_ID, cs_OCR_Id, cs_SMC_Id, cs_Mailer_Id, cs_EndRecord_Separator, cs_deleted from CardSetupSpec Where cs_id=" & dwCardSetupID

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when duplicate cardSetup record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            'Get the CardSetupID
            Dim strSQL As String = "SELECT cs_id FROM CardSetupSpec Where cs_name='" & szCardSetupName & "'"

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim dwNewCardSetupID As Integer
            myconn.Open()
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                datareader.Read()
                dwNewCardSetupID = IIf(IsDBNull(datareader("cs_id")), 0, datareader("cs_id"))
            End If
            datareader.Close()

            If dwNewCardSetupID = 0 Then Exit Try
            'duplicate each cardsetup details
            'EmbossDetails
            szSQL = "INSERT INTO EmbossingDetails (cs_id, element_seq, ds_id, data_fldid, element_col_offset, element_row_offset, element_tag) " & _
                    "SELECT " & dwNewCardSetupID & ", element_seq, ds_id, data_fldid, element_col_offset, element_row_offSet, element_tag from EmbossingDetails " & _
                    "WHERE cs_id=" & dwCardSetupID
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when duplicate embossDetails record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            'EncodeDetails
            szSQL = "INSERT INTO EncodeDataDetails (cs_id, element_seq, ds_id, data_fldid, element_track_num, element_separator) " & _
                    "SELECT " & dwNewCardSetupID & ", element_seq, ds_id, data_fldid, element_track_num, element_separator from EncodeDataDetails " & _
                    "Where cs_id=" & dwCardSetupID
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when duplicate encodeDetails record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            'OCRDetails
            szSQL = "INSERT INTO IndentationDetails (cs_id, element_seq, ds_id, data_fldid, element_col_offset, element_row_offset) " & _
                    "SELECT " & dwNewCardSetupID & ", element_seq, ds_id, data_fldid, element_col_offset, element_row_offset From IndentationDetails " & _
                    "Where cs_id=" & dwCardSetupID
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when duplicate IndentDetails record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            'SMCDetails
            szSQL = "INSERT INTO SMCDetails (cs_id, element_seq, ds_id, data_fldid, element_tagname, element_taglen, element_appname) " & _
                    "SELECT " & dwNewCardSetupID & ", element_seq, ds_id, data_fldid, element_tagname, element_taglen, element_appname From SMCDetails " & _
                    "Where cs_id=" & dwCardSetupID
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when duplicate SMCDetails record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            'ReportDetails
            szSQL = "INSERT INTO ReportDetails (cs_id, ds_id, data_fldid, report_fldtag) " & _
                    "SELECT " & dwNewCardSetupID & ", ds_id, data_fldid, report_fldtag From ReportDetails " & _
                    "Where cs_id=" & dwCardSetupID
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when duplicate reportDetails record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            'MailerDetails
            szSQL = "INSERT INTO MailerDetails (cs_id, element_seq, ds_id, data_fldid, element_field_name) " & _
                    "SELECT " & dwNewCardSetupID & ", element_seq, ds_id, data_fldid, element_field_name From MailerDetails " & _
                    "Where cs_id=" & dwCardSetupID
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when duplicate MailerDetails record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            MessageBox.Show("New Card Setup Name successfully duplicated.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshTreeView()
            UpdateAuditLog("Duplicate a New Card Design format [" & szCardSetupName & "]", "Setup")

        Catch ex As Exception
            MessageBox.Show("frmCardSetupMainMenu_cmdSaveASClick: Exception-" & ex.Message)
        Finally
            myconn.Close()
        End Try

    End Sub

    
End Class