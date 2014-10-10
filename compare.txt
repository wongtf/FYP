Imports System.Data.OleDb

Public Class frmCardSetup

    Private Sub frmCardSetup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCardSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Define Card Setup", "Audit Log")
        LoadDataFieldName()
        RefreshData()
    End Sub

    Private Sub RefreshGrid(ByVal tblName As String, ByVal dwCardSetupID As Integer, ByVal dbGrid As DataGridView)
        Try
            Dim myconn As OleDbConnection = New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String
            If tblName = "ReportDetails" Then
                'strSQL = "SELECT * FROM " & tblName & " Where CardSetupID=" & dwCardSetupID '& " ORDER By ReportFieldName"
                strSQL = "SELECT " & tblName & ".*, DataSetup.data_field_name From DataSetup INNER JOIN " & tblName & " ON (DataSetup.ds_id = " & tblName & ".ds_id AND DataSetup.data_fldid=" & tblName & ".data_fldid) Where " & tblName & ".cs_id=" & dwCardSetupID & ""
            Else
                'strSQL = "SELECT * FROM " & tblName & " Where CardSetupID=" & dwCardSetupID & " ORDER By RowNo"
                strSQL = "SELECT " & tblName & ".*, DataSetup.data_field_name From DataSetup INNER JOIN " & tblName & " ON (DataSetup.ds_id= " & tblName & ".ds_id AND DataSetup.data_fldid=" & tblName & ".data_fldid) Where " & tblName & ".cs_id=" & dwCardSetupID & " ORDER BY " & tblName & ".element_seq"
            End If
            Dim daDataSetup As OleDbDataAdapter = New OleDb.OleDbDataAdapter(strSQL, myconn)
            Dim dsDataSetup As DataSet = New DataSet()

            'Create a DataTable
            Dim dtTable As DataTable = New DataTable(tblName)
            'Fill DataTable
            daDataSetup.Fill(dtTable)
            dbGrid.DataSource = dtTable
            'dwDataFldCnt = dbGrid.Rows.Count - 1
            'lblTotal.Text = dwDataFldCnt & " records found"
            daDataSetup = Nothing
            dsDataSetup = Nothing
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("RefreshGrid: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub RefreshData()
        Try

            Dim dwCardSetupID As Integer = Val(Trim(lblCardSetupID.Text))

            'RefreshGrid("AuditDetails", dwCardSetupID, dbGridAudit)
            RefreshGrid("EmbossingDetails", dwCardSetupID, dbgridEmboss)
            RefreshGrid("EncodeDataDetails", dwCardSetupID, dbGridEncode)
            RefreshGrid("IndentationDetails", dwCardSetupID, dbGridOCR)
            RefreshGrid("SMCDetails", dwCardSetupID, dbGridSmartCard)
            RefreshGrid("ReportDetails", dwCardSetupID, dbGridReport)
            RefreshGrid("MailerDetails", dwCardSetupID, dbGridMailer)

        Catch ex As Exception
            MessageBox.Show("RefreshData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadDataFieldName()
        Try
            Dim dwDataSetupID As Integer = Val(lblDataSetupID.Text)
            Dim strSQL As String = "SELECT data_fldid, data_field_name FROM DataSetup Where ds_id=" & dwDataSetupID & " Order by data_field_name ASC"
            'clear the combo box at each tab page
            For i As Integer = 0 To Me.TabControl1.TabPages.Count - 1 'loop for every tab page
                For Each c As Control In Me.TabControl1.TabPages.Item(i).Controls
                    If TypeOf c Is ComboBox Then
                        Dim cbo As ComboBox = DirectCast(c, ComboBox)
                        If cbo.Name.ToLower Like "cmbdatafldname?" Then
                            LoadTableCombo(cbo, strSQL)
                            'cbo.Items.Clear()
                        End If
                    End If
                Next c
            Next i
        Catch ex As Exception
            MessageBox.Show("frmCardSetup_LoadDataFieldName: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub OnlyNumericInput(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmbColOffset.KeyPress, txtEmbRowOffset.KeyPress, txtOCRColOffset.KeyPress, txtOCRRowOffset.KeyPress
        'only accept integers from 0 to 9
        If Asc(e.KeyChar) = 8 Then 'backspace
            e.Handled = False
        ElseIf Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmbAdd.Click, cmdEncAdd.Click, cmdOCRAdd.Click, cmdSMCAdd.Click, cmdReportAdd.Click, cmdMailerAdd.Click
        AddModifyDataFld(True, 0)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmbEdit.Click, cmdEncEdit.Click, cmdOCREdit.Click, cmdSMCEdit.Click, cmdMailerEdit.Click
        AddModifyDataFld(False, 0)
    End Sub

    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmbInsert.Click, cmdEncInsert.Click, cmdOCRInsert.Click, cmdSMCInsert.Click, cmdMailerInsert.Click
        Dim dwRowNo As Integer
        dwRowNo = InputBox("Insert before which row?", "Card Setup")
        If IsNumeric(dwRowNo) = False Then
            MsgBox("Row Number should be in numeric value only!", MsgBoxStyle.Information, "Card Setup")
        Else
            AddModifyDataFld(True, dwRowNo)
        End If
    End Sub

    Private Sub AddModifyDataFld(ByVal boolAddFlag As Boolean, ByVal dwRowNo As Integer)
        Try
            Dim dbGrid As DataGridView = dbgridEmboss
            Dim szTblName As String = ""
            Dim dwCardSetupID As Integer
            Dim dwDataSetupID As Integer
            Dim dwDataFldID As Integer

            Dim dwEmbColOffset As Integer
            Dim dwEmbRowOffset As Integer
            Dim szEmbTag As String

            Dim dwPrevColOffSet As Integer
            Dim dwPrevRowOffset As Integer

            Dim dwTracknum As Integer
            Dim dwSeparator As Integer
            Dim dwPrevTrackNum As Integer

            Dim dwOCRColOffset As Integer
            Dim dwOCRRowOffset As Integer

            Dim szTagName As String
            Dim szTagLength As String
            Dim szAppName As String

            Dim szReportFldName As String

            Dim dwCount As Integer

            Dim szMailerFieldTag As String

            Dim szSQL As String = ""
            Dim dwReturnRow As Integer
            Dim dwLastRowNo As Integer
            Dim boolInsert As Boolean
            Dim dwi As Integer
            Dim szSQLUpdate As String
            Dim szAuditText As String = ""

            dwCardSetupID = Val(Trim(lblCardSetupID.Text))
            dwDataSetupID = Val(Trim(lblDataSetupID.Text))
            If dwRowNo > 0 Then
                boolInsert = True
            Else
                boolInsert = False
            End If

            Select Case Me.TabControl1.SelectedIndex
                Case 0  'emboss 
                    dbGrid = dbgridEmboss
                    szTblName = "EmbossingDetails"
                    dwDataFldID = Val(Trim(Mid(cmbDataFldName1.Text, 101, Len(cmbDataFldName1.Text) - 100)))
                    dwEmbColOffset = Val(Trim(txtEmbColOffset.Text))
                    dwEmbRowOffset = Val(Trim(txtEmbRowOffset.Text))
                    szEmbTag = Trim(txtEmbTag.Text)
                    dwLastRowNo = dbgridEmboss.RowCount '- 1
                    If boolInsert = True Then
                        If dwRowNo > dwLastRowNo Then
                            MsgBox("Invalid Row Number Given!", MsgBoxStyle.Critical, "Card Setup")
                            Exit Sub
                        End If
                    End If

                    If dwDataFldID = 0 Then
                        MsgBox("Please select one of the data field name.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If

                    If boolAddFlag = True And dwRowNo = 0 Then
                        dwRowNo = dbgridEmboss.RowCount + 1
                    ElseIf boolAddFlag = False And dwRowNo = 0 Then
                        dwRowNo = Val(lblEmbRowNo.Text)
                    End If

                    If dwEmbRowOffset < 2000 And dwEmbRowOffset > 0 Then
                        If dwRowNo > 1 Then
                            If boolInsert = False Then
                                dwPrevColOffSet = Val(dbgridEmboss(4, dwRowNo - 2).Value)
                                dwPrevRowOffset = Val(dbgridEmboss(5, dwRowNo - 2).Value)
                            Else    'insert row
                                dwPrevColOffSet = Val(dbgridEmboss(4, dwRowNo - 2).Value)
                                dwPrevRowOffset = Val(dbgridEmboss(5, dwRowNo - 2).Value)
                            End If

                            If dwEmbRowOffset > dwPrevRowOffset Then
                                MsgBox("Row offset should be smaller than " & dwPrevRowOffset)
                                Exit Sub
                            Else
                                If dwEmbRowOffset = dwPrevRowOffset Then
                                    If dwEmbColOffset <= dwPrevColOffSet Then
                                        MsgBox("Column Offset should be bigger than " & dwPrevColOffSet)
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    Else
                        MsgBox("The range of row offset should be from 1 to 2000", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If

                    If boolAddFlag = True Then
                        szSQL = "INSERT INTO EmbossingDetails (cs_id, element_seq, ds_id, data_fldid, element_col_offset, element_row_offset, element_tag) VALUES (" & _
                                    dwCardSetupID & ", " & dwRowNo & ", " & dwDataSetupID & ", " & dwDataFldID & ", " & _
                                    dwEmbColOffset & ", " & dwEmbRowOffset & ", '" & szEmbTag & "')"
                        szAuditText = "Add Emboss Field [" & Trim(cmbDataFldName1.Text) & "]"
                    Else 'update
                        szSQL = "UPDATE EmbossingDetails SET ds_id=" & dwDataSetupID & ", data_fldid=" & dwDataFldID & _
                                ", element_row_offset=" & dwEmbRowOffset & ", element_col_offset=" & dwEmbColOffset & _
                                ", element_tag='" & szEmbTag & "' WHERE cs_id=" & dwCardSetupID & " and ds_id=" & dwDataSetupID & " and element_seq=" & dwRowNo
                        szAuditText = "Edit Emboss Field [" & Trim(cmbDataFldName1.Text) & "]"
                    End If
                Case 1  'encode
                    dbGrid = dbGridEncode
                    szTblName = "EncodeDataDetails"
                    dwDataFldID = Val(Trim(Mid(cmbDataFldName2.Text, 101, Len(cmbDataFldName2.Text) - 100)))
                    dwLastRowNo = dbGridEncode.RowCount '- 1
                    If boolInsert = True Then
                        If dwRowNo > dwLastRowNo Then
                            MsgBox("Invalid Row Number Given!", MsgBoxStyle.Critical, "Card Setup")
                            Exit Sub
                        End If
                    End If

                    If dwDataFldID = 0 Then
                        MsgBox("Please select one of the data field name.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If
                    If Trim(cmbTrackNum.Text) = "" Then
                        MsgBox("Please select one of the track number.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If
                    If Trim(cmbSeparator.Text) = "" Then
                        MsgBox("Please select either YES or NO for Track separator.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If

                    dwTracknum = Val(Trim(cmbTrackNum.Text))
                    dwSeparator = cmbSeparator.SelectedIndex 'Val(Trim(cmbSeparator.Text))

                    If boolAddFlag = True And dwRowNo = 0 Then
                        dwRowNo = dbGridEncode.RowCount + 1
                    ElseIf boolAddFlag = False And dwRowNo = 0 Then
                        dwRowNo = Val(lblEncRowNo.Text)
                    End If

                    If dwRowNo > 1 Then
                        If boolInsert = False Then
                            dwPrevTrackNum = Val(dbGridEncode(4, dwRowNo - 2).Value)
                        Else
                            dwPrevTrackNum = Val(dbGridEncode(4, dwRowNo - 2).Value)
                        End If
                        If dwTracknum < dwPrevTrackNum Then
                            MsgBox("Track number should be bigger or equal to " & dwPrevTrackNum)
                            Exit Sub
                        End If
                    End If

                    If boolAddFlag = True Then
                        szSQL = "INSERT INTO EncodeDataDetails (cs_id, element_seq, ds_id, data_fldid, element_track_num, element_separator) VALUES (" & _
                                    dwCardSetupID & ", " & dwRowNo & ", " & dwDataSetupID & ", " & dwDataFldID & ", " & _
                                    dwTracknum & ", " & dwSeparator & ")"
                        szAuditText = "Add Encode Field [" & Trim(cmbDataFldName2.Text) & "]"
                    Else 'update
                        szSQL = "UPDATE EncodeDataDetails SET ds_id=" & dwDataSetupID & ", data_fldid=" & dwDataFldID & _
                                ", element_track_num=" & dwTracknum & ", element_separator=" & dwSeparator & _
                                " WHERE cs_id=" & dwCardSetupID & " and ds_id=" & dwDataSetupID & " and element_seq=" & dwRowNo
                        szAuditText = "Edit Encode Field [" & Trim(cmbDataFldName2.Text) & "]"
                    End If
                Case 2  'OCR
                    dbGrid = dbGridOCR
                    szTblName = "IndentationDetails"
                    dwDataFldID = Val(Trim(Mid(cmbDataFldName3.Text, 101, Len(cmbDataFldName3.Text) - 100)))
                    dwOCRColOffset = Val(Trim(txtOCRColOffset.Text))
                    dwOCRRowOffset = Val(Trim(txtOCRRowOffset.Text))
                    dwLastRowNo = dbGridOCR.RowCount '- 1
                    If boolInsert = True Then
                        If dwRowNo > dwLastRowNo Then
                            MsgBox("Invalid Row Number Given!", MsgBoxStyle.Critical, "Card Setup")
                            Exit Sub
                        End If
                    End If

                    If dwDataFldID = 0 Then
                        MsgBox("Please select one of the data field name.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If

                    If boolAddFlag = True And dwRowNo = 0 Then
                        dwRowNo = dbGridOCR.RowCount + 1
                    ElseIf boolAddFlag = False And dwRowNo = 0 Then
                        dwRowNo = Val(lblOCRRowNo.Text)
                    End If

                    If dwOCRRowOffset < 2000 And dwOCRRowOffset > 0 Then
                        If dwRowNo > 1 Then
                            If boolInsert = False Then
                                dwPrevColOffSet = Val(dbGridOCR(4, dwRowNo - 2).Value)
                                dwPrevRowOffset = Val(dbGridOCR(5, dwRowNo - 2).Value)
                            Else
                                dwPrevColOffSet = Val(dbGridOCR(4, dwRowNo - 2).Value)
                                dwPrevRowOffset = Val(dbGridOCR(5, dwRowNo - 2).Value)
                            End If

                            If dwOCRRowOffset > dwPrevRowOffset Then
                                MsgBox("Row offset should be smaller than " & dwPrevRowOffset)
                                Exit Sub
                            Else
                                If dwOCRRowOffset = dwPrevRowOffset Then
                                    If dwOCRColOffset <= dwPrevColOffSet Then
                                        MsgBox("Column Offset should be bigger than " & dwPrevColOffSet)
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    Else
                        MsgBox("The range of row offset should be from 1 to 2000", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If


                    If boolAddFlag = True Then
                        szSQL = "INSERT INTO IndentationDetails (cs_id, element_seq, ds_id, data_fldid, element_col_offset, element_row_offset) VALUES (" & _
                                    dwCardSetupID & ", " & dwRowNo & ", " & dwDataSetupID & ", " & dwDataFldID & ", " & _
                                    dwOCRColOffset & ", " & dwOCRRowOffset & ")"
                        szAuditText = "Add OCR Field [" & Trim(cmbDataFldName3.Text) & "]"
                    Else 'update
                        szSQL = "UPDATE IndentationDetails SET ds_id=" & dwDataSetupID & ", data_fldid=" & dwDataFldID & _
                                ", element_row_offset=" & dwOCRRowOffset & ", element_col_offSet=" & dwOCRColOffset & _
                                " WHERE cs_id=" & dwCardSetupID & " and ds_id=" & dwDataSetupID & " and element_seq=" & dwRowNo
                        szAuditText = "Edit OCR Field [" & Trim(cmbDataFldName3.Text) & "]"
                    End If
                Case 3  'SMC
                    dbGrid = dbGridSmartCard
                    szTblName = "SMCDetails"
                    dwDataFldID = Val(Trim(Mid(cmbDataFldName4.Text, 101, Len(cmbDataFldName4.Text) - 100)))
                    szTagName = Trim(txtTagName.Text)
                    szTagLength = Trim(txtTagLength.Text)
                    szAppName = Trim(txtAppName.Text)
                    dwLastRowNo = dbGridSmartCard.RowCount '- 1
                    If boolInsert = True Then
                        If dwRowNo > dwLastRowNo Then
                            MsgBox("Invalid Row Number Given!", MsgBoxStyle.Critical, "Card Setup")
                            Exit Sub
                        End If
                    End If

                    If dwDataFldID = 0 Then
                        MsgBox("Please select one of the data field name.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If
                    If szTagName = "" Then
                        MsgBox("Please enter the Tag Name first.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If
                    If szTagLength = "" Then
                        MsgBox("Please enter the Tag Length first.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If
                    If szAppName = "" Then
                        MsgBox("Please enter the Application Name first.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If

                    If boolAddFlag = True And dwRowNo = 0 Then
                        dwRowNo = dbGridSmartCard.RowCount + 1
                    ElseIf boolAddFlag = False And dwRowNo = 0 Then
                        dwRowNo = Val(lblSMCRowNo.Text)
                    End If

                    If boolAddFlag = True Then
                        szSQL = "INSERT INTO SMCDetails (cs_id, element_seq, ds_id, data_fldid, element_tagname, element_taglen, element_appname) VALUES (" & _
                                    dwCardSetupID & ", " & dwRowNo & ", " & dwDataSetupID & ", " & dwDataFldID & ", '" & _
                                    szTagName & "', '" & szTagLength & "', '" & szAppName & "')"
                        szAuditText = "Add SMC Field [" & Trim(cmbDataFldName4.Text) & "]"
                    Else 'update
                        szSQL = "UPDATE SMCDetails SET ds_id=" & dwDataSetupID & ", data_fldid=" & dwDataFldID & _
                                ", element_tagname='" & szTagName & "', element_taglen='" & szTagLength & _
                                "', element_appname='" & szAppName & "' WHERE cs_id=" & dwCardSetupID & " and ds_id=" & dwDataSetupID & " and element_seq=" & dwRowNo
                        szAuditText = "Edit SMC Field [" & Trim(cmbDataFldName4.Text) & "]"
                    End If

                Case 4  'Report  
                    dbGrid = dbGridReport
                    szTblName = "ReportDetails"
                    dwDataFldID = Val(Trim(Mid(cmbDataFldName5.Text, 101, Len(cmbDataFldName5.Text) - 100)))
                    szReportFldName = Trim(cmbReportFldName.Text)
                    If dwDataFldID = 0 Then
                        MsgBox("Please select one of the data field name.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If
                    If szReportFldName = "" Then
                        MsgBox("Please select the Report Field Name first.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If

                    If boolAddFlag = True Then
                        dwCount = GetCountSQL("SELECT * FROM ReportDetails where report_fldtag='" & szReportFldName & "' and cs_id=" & dwCardSetupID)
                        If dwCount <= 0 Then
                            szSQL = "INSERT INTO ReportDetails (cs_id, ds_id, data_fldid, report_fldtag) VALUES (" & _
                                        dwCardSetupID & ", " & dwDataSetupID & ", " & dwDataFldID & ", '" & _
                                        szReportFldName & "')"
                            szAuditText = "Add Report Field [" & Trim(cmbDataFldName5.Text) & "] for " & szReportFldName
                        Else 'update
                            MessageBox.Show(szReportFldName & " already assigned to others field.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                Case 5  'Mailer
                    dbGrid = dbGridMailer
                    szTblName = "MailerDetails"
                    dwDataFldID = Val(Trim(Mid(cmbDataFldName7.Text, 101, Len(cmbDataFldName7.Text) - 100)))
                    szMailerFieldTag = Trim(txtFieldTag.Text)
                    dwLastRowNo = dbGridMailer.RowCount '- 1
                    If dwDataFldID = 0 Then
                        MsgBox("Please select one of the data field name.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If
                    If szMailerFieldTag = "" Then
                        MsgBox("Please specify the Mailer Field Tag first.", MsgBoxStyle.Information, "CardSetup")
                        Exit Sub
                    End If

                    If boolAddFlag = True And dwRowNo = 0 Then
                        dwRowNo = dbGridMailer.RowCount + 1
                    ElseIf boolAddFlag = False And dwRowNo = 0 Then
                        dwRowNo = Val(lblMailerRowNo.Text)
                    End If

                    If boolAddFlag = True Then
                        szSQL = "INSERT INTO MailerDetails (cs_id, element_seq, ds_id, data_fldid, element_field_name) VALUES (" & _
                                        dwCardSetupID & ", " & dwRowNo & ", " & dwDataSetupID & ", " & dwDataFldID & ", '" & _
                                        szMailerFieldTag & "')"
                        szAuditText = "Add Mailer Field [" & Trim(cmbDataFldName7.Text) & "] for " & szMailerFieldTag
                    Else
                        szSQL = "UPDATE MailerDetails SET ds_id=" & dwDataSetupID & ", data_fldid=" & dwDataFldID & _
                                ", element_field_name='" & szMailerFieldTag & "' WHERE cs_id=" & _
                                dwCardSetupID & " and ds_id=" & dwDataSetupID & " and element_seq=" & dwRowNo
                        szAuditText = "Edit Mailer Field [" & Trim(cmbDataFldName7.Text) & "] for " & szMailerFieldTag
                    End If
            End Select
            'update the rowno first before insert the new rowno to db
            If boolInsert = True Then
                If dwLastRowNo >= dwRowNo Then
                    For dwi = dwLastRowNo To dwRowNo Step -1
                        'refresh the rowno
                        szSQLUpdate = "UPDATE " & szTblName & " SET element_seq=" & dwi + 1 & " Where element_seq=" & dwi & " and cs_id=" & dwCardSetupID
                        dwReturnRow = ExecuteSQL(szSQLUpdate)
                    Next dwi
                End If
            End If

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving job record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("Card Setup field not found. No record updated.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 1
                    MessageBox.Show("One Record saved.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAuditLog(szAuditText, "Setup")
                    RefreshGrid(szTblName, dwCardSetupID, dbGrid)
            End Select
            If Me.TabControl1.SelectedIndex <> 4 Then
                ClearControlBox(Me.TabControl1, System.EventArgs.Empty)
            End If
        Catch ex As Exception
            MessageBox.Show("AddModifyDataFld: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub DeleteCardFld(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmbDelete.Click, cmdEncDelete.Click, cmdOCRDelete.Click, cmdSMCDelete.Click, cmdReportDelete.Click, cmdMailerDelete.Click
        Try
            Dim dwRowNo As Integer
            Dim dwCardSetupID As Integer = Val(Trim(lblCardSetupID.Text))
            Dim szTblName As String = ""
            Dim szSQL As String
            Dim dwReturnRow As Integer
            Dim dbGrid As DataGridView = dbgridEmboss
            Dim dwLastRowNo As Integer
            Dim dwi As Integer
            Dim szReportFldName As String = ""

            Select Case Me.TabControl1.SelectedIndex
                Case 0  'emboss 
                    dwRowNo = Val(Trim(lblEmbRowNo.Text))
                    szTblName = "EmbossingDetails"
                    dbGrid = dbgridEmboss
                    dwLastRowNo = dbgridEmboss.RowCount '- 1
                Case 1  'encode
                    dwRowNo = Val(Trim(lblEncRowNo.Text))
                    szTblName = "EncodeDataDetails"
                    dbGrid = dbGridEncode
                    dwLastRowNo = dbGridEncode.RowCount '- 1
                Case 2  'OCR
                    dwRowNo = Val(Trim(lblOCRRowNo.Text))
                    szTblName = "IndentationDetails"
                    dbGrid = dbGridOCR
                    dwLastRowNo = dbGridOCR.RowCount '- 1
                Case 3  'SMC
                    dwRowNo = Val(Trim(lblSMCRowNo.Text))
                    szTblName = "SMCDetails"
                    dbGrid = dbGridSmartCard
                    dwLastRowNo = dbGridSmartCard.RowCount '- 1
                Case 4  'Report 
                    'dwRowNo = Val(Trim(lblAuditRowNo.Text))
                    dwRowNo = 1
                    szReportFldName = Trim(lblAuditRowNo.Text)
                    szTblName = "ReportDetails"
                    dbGrid = dbGridReport
                    dwLastRowNo = 1 'dbGridReport.RowCount - 1
                Case 5  'Load Module 
                    dwRowNo = Val(Trim(lblMailerRowNo.Text))
                    szTblName = "MailerDetails"
                    dbGrid = dbGridMailer
                    dwLastRowNo = dbGridMailer.RowCount
            End Select


            If dwRowNo = 0 Or szTblName = "" Then
                Exit Sub
            End If

            If (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

            If Me.TabControl1.SelectedIndex = 4 Then
                szSQL = "DELETE From " & szTblName & " WHERE cs_id=" & dwCardSetupID & " And report_fldtag='" & szReportFldName & "'"
            Else
                szSQL = "DELETE From " & szTblName & " WHERE cs_id=" & dwCardSetupID & " And element_seq=" & dwRowNo
            End If
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting card field record.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("Card Field record not found. No record deleted.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 1
                    MessageBox.Show("One Record deleted.", "CardSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAuditLog("Delete CardSetupID [" & dwCardSetupID & "] from " & szTblName, "Setup")
                    If dwLastRowNo > dwRowNo Then
                        For dwi = dwRowNo To dwLastRowNo
                            'refresh the rowno
                            szSQL = "UPDATE " & szTblName & " SET element_seq=" & dwi & " Where element_seq=" & dwi + 1 & " and cs_id=" & dwCardSetupID
                            dwReturnRow = ExecuteSQL(szSQL)
                        Next dwi
                    End If

                    ClearControlBox(Me.TabControl1, System.EventArgs.Empty)
                    RefreshGrid(szTblName, dwCardSetupID, dbGrid)
            End Select
        Catch ex As Exception
            MessageBox.Show("frmCardSetup_DeleteCardFld: Exception-" & ex.Message)
        End Try
    End Sub

    Private Sub ClearControlBox(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmbClear.Click, cmdEncClear.Click, cmdOCRClear.Click, cmdSMCClear.Click, cmdReportClear.Click, cmdMailerClear.Click
        'MsgBox(sender)
        Select Case Me.TabControl1.SelectedIndex
            Case 0 'Emboss Tab
                cmbDataFldName1.Text = ""
                txtEmbColOffset.Text = ""
                txtEmbRowOffset.Text = ""
                txtEmbTag.Text = ""
            Case 1  'Encode Tab
                cmbDataFldName2.Text = ""
                cmbTrackNum.Text = ""
                cmbSeparator.Text = ""
            Case 2  'OCR Tab
                cmbDataFldName3.Text = ""
                txtOCRColOffset.Text = ""
                txtOCRRowOffset.Text = ""
            Case 3  'Smart Card Tab
                cmbDataFldName4.Text = ""
                txtTagName.Text = ""
                txtTagLength.Text = ""
                txtAppName.Text = ""
            Case 4  'Report Tab
                cmbDataFldName5.Text = ""
                cmbReportFldName.Text = ""
            Case 5
                cmbDataFldName7.Text = ""
                txtFieldTag.Text = ""
        End Select
    End Sub

    Private Sub dbgrid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgridEmboss.CellMouseClick, dbGridEncode.CellMouseClick, dbGridOCR.CellMouseClick, dbGridSmartCard.CellMouseClick, dbGridReport.CellMouseClick, dbGridMailer.CellMouseClick
        Try

            Dim dbGrid As DataGridView = dbgridEmboss
            Dim lblRowNo As Label = lblEmbRowNo
            Dim dwGridIndex As Integer
            Dim dwData As Integer
            ClearControlBox(Me.TabControl1, System.EventArgs.Empty)
            'If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
            If e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
                dwGridIndex = Me.TabControl1.SelectedIndex
                Select Case dwGridIndex
                    Case 0  'emboss 
                        dbGrid = dbgridEmboss
                        lblRowNo = lblEmbRowNo
                    Case 1  'encode
                        dbGrid = dbGridEncode
                        lblRowNo = lblEncRowNo
                    Case 2  'OCR
                        dbGrid = dbGridOCR
                        lblRowNo = lblOCRRowNo
                    Case 3  'SMC
                        dbGrid = dbGridSmartCard
                        lblRowNo = lblSMCRowNo
                    Case 4  'Report  
                        dbGrid = dbGridReport
                        lblRowNo = lblAuditRowNo
                    Case 5  'Load Module  
                        dbGrid = dbGridMailer
                        lblRowNo = lblMailerRowNo
                End Select
                'If e.RowIndex = dbGrid.RowCount - 1 Then Exit Sub

                lblRowNo.Text = dbGrid(1, e.RowIndex).Value
                Select Case dwGridIndex
                    Case 0  'emboss tab
                        'populate the cmbdatafldname
                        dwData = Val(dbGrid(3, e.RowIndex).Value)
                        cmbDataFldName1.SelectedIndex = FindComboItem(cmbDataFldName1, dwData)
                        txtEmbColOffset.Text = dbGrid(4, e.RowIndex).Value
                        txtEmbRowOffset.Text = dbGrid(5, e.RowIndex).Value
                        txtEmbTag.Text = dbGrid(6, e.RowIndex).Value

                    Case 1 'Encode tab
                        'populate the cmbdatafldname
                        dwData = Val(dbGrid(3, e.RowIndex).Value)
                        cmbDataFldName2.SelectedIndex = FindComboItem(cmbDataFldName2, dwData)
                        cmbTrackNum.Text = cmbTrackNum.Items.Item(Val(dbGrid(4, e.RowIndex).Value) - 1)
                        cmbSeparator.Text = cmbSeparator.Items.Item(Val(dbGrid(5, e.RowIndex).Value))

                    Case 2 'OCR Tab
                        'populate the cmbdatafldname
                        dwData = Val(dbGrid(3, e.RowIndex).Value)
                        cmbDataFldName3.SelectedIndex = FindComboItem(cmbDataFldName3, dwData)
                        txtOCRColOffset.Text = dbGrid(4, e.RowIndex).Value
                        txtOCRRowOffset.Text = dbGrid(5, e.RowIndex).Value

                    Case 3 ' SMC Tab
                        dwData = Val(dbGrid(3, e.RowIndex).Value)
                        cmbDataFldName4.SelectedIndex = FindComboItem(cmbDataFldName4, dwData)
                        txtTagName.Text = dbGrid(4, e.RowIndex).Value
                        txtTagLength.Text = dbGrid(5, e.RowIndex).Value
                        txtAppName.Text = dbGrid(6, e.RowIndex).Value

                    Case 4 ' Report Tab
                        dwData = Val(dbGrid(3, e.RowIndex).Value)
                        cmbDataFldName5.SelectedIndex = FindComboItem(cmbDataFldName5, dwData)
                        'lblRowNo.Text = dbGrid(4, e.RowIndex).Value
                        cmbReportFldName.Text = dbGrid(1, e.RowIndex).Value
                    Case 5 ' Mailer Tab
                        dwData = Val(dbGrid(3, e.RowIndex).Value)
                        cmbDataFldName7.SelectedIndex = FindComboItem(cmbDataFldName7, dwData)
                        'lblRowNo.Text = dbGrid(4, e.RowIndex).Value
                        txtFieldTag.Text = dbGrid(4, e.RowIndex).Value
                End Select

            End If
        Catch ex As Exception
            MessageBox.Show("dgrid_CellMouseClick: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class