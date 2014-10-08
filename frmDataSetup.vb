Imports System.IO

Public Class frmDataSetup
    Dim dwDSetupID As Integer
    Dim dwDataFldCnt As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenSampleFile.Click
        Dim dwFileNum As Integer = FreeFile()
        Try
            Dim openFileDialog1 As New OpenFileDialog()
            Dim szFileName As String
            Dim szTempString As String
            Dim lngPosition As Long
            Dim lngRecLen As Long = Val(frmDataSetupMainMenu.txtRecordLength.Text)
            Dim lMaxInputLen As Long = 10000
            Dim lFileLen As Long
            Dim dwHeaderSize As Long = Val(frmDataSetupMainMenu.txtFileHeaderSize.Text)
            Dim lngReadLen As Long

            openFileDialog1.InitialDirectory = "c:\"
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                szFileName = openFileDialog1.FileName()
                'open the input file for processing
                FileOpen(dwFileNum, szFileName, OpenMode.Binary)

                lngPosition = 1

                lngReadLen = lngRecLen

                If Not EOF(dwFileNum) Then
                    'set the next record position
                    Seek(dwFileNum, lngPosition + dwHeaderSize)
                    If lngReadLen > 0 Then
                        'get each record based on fixed length
                        szTempString = New String(" ", lngRecLen)
                        FileGet(dwFileNum, szTempString)
                    Else
                        lFileLen = FileLen(szFileName)
                        If lFileLen < lMaxInputLen Then
                            szTempString = New String(" ", lFileLen)
                        Else
                            szTempString = New String(" ", lMaxInputLen)
                        End If
                        FileGet(dwFileNum, szTempString)
                    End If
                    txtFileContents.Text = szTempString
                End If

                FileClose(dwFileNum)
            End If
        Catch ex As Exception
            MessageBox.Show("btnOpenSampleFile: Exception-" & ex.Message())
            FileClose(dwFileNum)
        End Try
    End Sub

    Private Sub txtFileContents_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFileContents.MouseUp
        Try
            Dim sSelectText As String
            Dim lLenSelect As Long
            Dim sOutputText As String
            Dim sTempTxt As String
            Dim i As Integer

            txtFldLength.Text = txtFileContents.SelectionLength
            txtFldStartPos.Text = txtFileContents.SelectionStart + 1
            'If txtFileContents.SelectionStart = 0 Then txtFileContents.SelectionStart = 1
            sSelectText = Mid(txtFileContents.Text, txtFileContents.SelectionStart + 1, txtFileContents.SelectionLength)
            lLenSelect = Len(sSelectText)
            sOutputText = ""
            For i = 1 To lLenSelect
                sTempTxt = Hex(Asc(Mid(sSelectText, i, 1)))
                sOutputText = sOutputText & Microsoft.VisualBasic.Right(StrDup(2, "0") & sTempTxt, 2)
            Next i
            txtFldHexValue.Text = sOutputText
        Catch ex As Exception
            MessageBox.Show("txtFileContents_MouseUp: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub frmDataSetup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmDataSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dwDSetupID = Val(Trim(lblDataSetupID.Text))
        RefreshGrid()
        RefreshDataFldNameCombo()
    End Sub
    

    Private Sub RefreshGrid()
        Try
            Dim myconn As OleDb.OleDbConnection = New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM DataSetup Where ds_id=" & dwDSetupID & " ORDER By data_fldid"
            Dim daDataSetup As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(strSQL, myconn)
            Dim dsDataSetup As DataSet = New DataSet()

            'Create a DataTable
            Dim dtTable As DataTable = New DataTable("DataSetup")
            'Fill DataTable
            daDataSetup.Fill(dtTable)
            dgridDataSetup.DataSource = dtTable
            dwDataFldCnt = dgridDataSetup.Rows.Count - 1
            lblTotal.Text = dwDataFldCnt & " records found"
            dsDataSetup = Nothing
            daDataSetup = Nothing
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("RefreshGrid: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub RefreshDataFldNameCombo()
        Dim myconn As New OleDb.OleDbConnection()
        Try
            Dim dwi As Integer = 0
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim szDataFldName As String

            cmbDataFldName.Items.Clear()
            myCmd.CommandText = "SELECT * FROM DataSetup Where ds_id=" & dwDSetupID & " and data_field_type <> 1 and data_field_type <> 2 ORDER By data_field_name"
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    szDataFldName = IIf(IsDBNull(datareader("data_field_name")), "", datareader("data_field_name"))
                    cmbDataFldName.Items.Add(szDataFldName)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("RefreshDataFldNameCombo: Exception-" & ex.Message())
        Finally
            myconn.Close()
        End Try
    End Sub

    Private Sub ClearControlBox()
        rbDataType0.Checked = True
        lblDataFldID.Text = ""
        txtDataFldName.Text = ""
        txtStartPosition.Text = ""
        txtDataLength.Text = ""
        txtStartCode.Text = ""
        txtEndCode.Text = ""
        txtStaticData.Text = ""
        txtCompositeFld.Text = ""
        txtNewDateFormat.Text = ""
        cmbOutputFormat.Text = "ASCII"
        chkConditionFld.Checked = False
        chkCheckPoscode.Checked = False
        chkLastDayOfMth.Checked = False
        chkCurrency.Checked = False
        txtConditionFld.Text = ""
        txtReplValue.Text = ""
        'add new for Name Separator 08/02/2013 azuwa kasnan
        'chkCheckNmSeparator.Checked = False
    End Sub

    Private Sub dgridDataSetup_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgridDataSetup.CellMouseClick
        Try
            Dim iDataType As Integer
            ClearControlBox()
            If e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then 'AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell
                If e.RowIndex = dgridDataSetup.RowCount - 1 Then Exit Sub

                lblDataFldID.Text = dgridDataSetup(1, e.RowIndex).Value
                txtDataFldName.Text = dgridDataSetup(2, e.RowIndex).Value
                iDataType = dgridDataSetup(3, e.RowIndex).Value
                Select Case iDataType
                    Case 0, 4  'variable field
                        rbDataType0.Checked = True
                        'start field definition
                        If Trim(dgridDataSetup(4, e.RowIndex).Value) <> "0" Then
                            rbStartFld0.Checked = True
                            txtStartPosition.Text = dgridDataSetup(4, e.RowIndex).Value
                        Else
                            rbStartFld1.Checked = True
                            txtStartCode.Text = dgridDataSetup(6, e.RowIndex).Value
                        End If
                        'end field definition
                        If Trim(dgridDataSetup(5, e.RowIndex).Value) <> "0" Then
                            rbEndFld0.Checked = True
                            txtDataLength.Text = dgridDataSetup(5, e.RowIndex).Value
                        Else
                            rbEndFld1.Checked = True
                            txtEndCode.Text = dgridDataSetup(7, e.RowIndex).Value
                        End If
                        If iDataType = 4 Then
                            chkConditionFld.Checked = True
                            txtConditionFld.Text = dgridDataSetup(11, e.RowIndex).Value
                            txtReplValue.Text = dgridDataSetup(12, e.RowIndex).Value
                        End If
                    Case 1 'constant field
                        rbDataType1.Checked = True
                        txtStaticData.Text = dgridDataSetup(8, e.RowIndex).Value
                    Case 2 'composite field
                        rbDataType2.Checked = True
                        txtCompositeFld.Text = dgridDataSetup(9, e.RowIndex).Value
                    Case 3
                        rbDataType3.Checked = True
                    Case 5
                        rbDataType5.Checked = True
                        txtCompositeFld.Text = dgridDataSetup(9, e.RowIndex).Value
                End Select
                cmbOutputFormat.Text = dgridDataSetup(10, e.RowIndex).Value
                txtReplCharCode.Text = IIf(IsDBNull(dgridDataSetup(13, e.RowIndex).Value), "", dgridDataSetup(13, e.RowIndex).Value)
                chkCheckPoscode.Checked = CBool(dgridDataSetup(14, e.RowIndex).Value)
                chkLastDayOfMth.Checked = CBool(dgridDataSetup(15, e.RowIndex).Value)
                txtOldDateFmt.Text = IIf(IsDBNull(dgridDataSetup(16, e.RowIndex).Value), "", dgridDataSetup(16, e.RowIndex).Value)
                txtNewDateFormat.Text = IIf(IsDBNull(dgridDataSetup(17, e.RowIndex).Value), "", dgridDataSetup(17, e.RowIndex).Value)
                chkCurrency.Checked = CBool(dgridDataSetup(18, e.RowIndex).Value)

                'add new for Name Separator 08/02/2013 azuwa kasnan
                'chkCheckNmSeparator.Checked = CBool(dgridDataSetup(19, e.RowIndex).Value)
            End If
        Catch ex As Exception
            MessageBox.Show("dgridDataSetup_CellMouseClick: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        ClearControlBox()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        AddModifyDataFld(True)
        RefreshDataFldNameCombo()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        AddModifyDataFld(False)
    End Sub

    Private Sub AddModifyDataFld(ByVal boolAddFlag As Boolean)
        Try
            Dim szDataFldName As String = ""
            Dim dwDataType As Integer = 0
            Dim lngStartPos As Long = 0
            Dim lngFldLength As Long = 0
            Dim szStartCode As String = ""
            Dim szEndCode As String = ""
            Dim szConstantData As String = ""
            Dim szCompositeData As String = ""
            Dim szOutputFormat As String = ""
            Dim szConditionFld As String = ""
            Dim szReplvalue As String = ""
            Dim szReplCharCode As String = ""
            Dim boolCheckPoscode As Integer 'Boolean = False
            Dim boolLastDayofMth As Integer 'Boolean = False
            Dim boolCurrencyFld As Integer
            Dim szDateFormat As String = ""
            Dim szOldDateFormat As String = ""

            Dim dwDataFldId As Integer = 0
            Dim dwCount As Integer
            Dim szSQL As String = ""
            Dim dwReturnRow As Integer
            Dim dwGridRow As Integer = 0
            Dim szAuditText As String = ""
            Dim szArithmeticFld As String = ""

            'add new for Name Separator 08/02/2013 azuwa kasnan
            'Dim boolCheckNameSeparator As Integer

            szDataFldName = Trim(txtDataFldName.Text)
            If rbDataType0.Checked = True Then
                dwDataType = 0
                If rbStartFld0.Checked = True Then
                    lngStartPos = IIf(Trim(txtStartPosition.Text = ""), 0, CLng(Trim(txtStartPosition.Text)))
                Else
                    szStartCode = Trim(txtStartCode.Text)
                End If
                If rbEndFld0.Checked = True Then
                    lngFldLength = IIf(Trim(txtDataLength.Text = ""), 0, CLng(Trim(txtDataLength.Text)))
                Else
                    szEndCode = Trim(txtEndCode.Text)
                End If
            ElseIf rbDataType1.Checked = True Then
                dwDataType = 1
                szConstantData = txtStaticData.Text
            ElseIf rbDataType2.Checked = True Then
                dwDataType = 2
                szCompositeData = txtCompositeFld.Text
            ElseIf rbDataType3.Checked = True Then
                dwDataType = 3
            ElseIf rbDataType5.Checked = True Then
                dwDataType = 5
                szCompositeData = txtCompositeFld.Text
                'szArithmeticFld = Trim(txtCompositeFld.Text)
                'szArithmeticFld = Trim(txtArithmeticFld.Text)
            End If
            szOutputFormat = Trim(cmbOutputFormat.Text)
            If chkConditionFld.Checked = True Then
                dwDataType = 4
                szConditionFld = txtConditionFld.Text
                szReplvalue = txtReplValue.Text
            End If
            szReplCharCode = Trim(txtReplCharCode.Text)
            boolCheckPoscode = chkCheckPoscode.Checked
            boolLastDayofMth = chkLastDayOfMth.Checked
            boolCurrencyFld = chkCurrency.Checked
            szDateFormat = Trim(txtNewDateFormat.Text)
            szOldDateFormat = Trim(txtOldDateFmt.Text)

            'add new for Name Separator 08/02/2013 azuwa kasnan
            'boolCheckNameSeparator = chkCheckNmSeparator.Checked

            If boolAddFlag = True Then  'add new record
                'check the last row datafld id
                dwGridRow = dgridDataSetup.RowCount - 1
                If dwGridRow = 0 Then
                    dwDataFldCnt = 0
                Else
                    dwDataFldCnt = Val(dgridDataSetup(1, dwGridRow - 1).Value)
                End If
                'check the datafld name already in the db
                dwCount = GetCountSQL("SELECT * FROM DataSetup where data_field_name='" & szDataFldName & "' and ds_id=" & dwDSetupID)
                If dwCount <= 0 Then
                    'Add new record
                    szSQL = "INSERT INTO DataSetup (ds_id, data_fldid, data_field_name, data_field_type, data_start_pos, data_length, " & _
                            "data_start_code, data_end_code, data_constant, data_composite_data, data_output_format, data_condition_fldvalue, data_condition_replvalue, data_repl_charcode, " & _
                            "data_checkposcode, data_get_lastdayofmth, data_date_fldformat, data_old_date_fldformat, data_currencyfld) VALUES (" & dwDSetupID & ", " & dwDataFldCnt + 1 & ",'" & szDataFldName & _
                            "', " & dwDataType & "," & lngStartPos & "," & lngFldLength & ", '" & szStartCode & "', '" & _
                                szEndCode & "', '" & szConstantData & "', '" & szCompositeData & "', '" & szOutputFormat & "', '" & _
                                szConditionFld & "', '" & szReplvalue & "', '" & szReplCharCode & "', " & boolCheckPoscode & ", " & _
                                boolLastDayofMth & ", '" & szDateFormat & "', '" & szOldDateFormat & "', " & boolCurrencyFld & ")"
                    szAuditText = "Add new Data Field [" & szDataFldName & "]"
                Else
                    MessageBox.Show("Record already exists.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                dwDataFldId = CLng(Trim(lblDataFldID.Text))
                szSQL = "UPDATE DataSetup SET data_field_type=" & dwDataType & ", data_start_pos=" & lngStartPos & _
                ", data_length=" & lngFldLength & ", data_start_code='" & szStartCode & "', data_end_code='" & szEndCode & _
                "', data_constant='" & szConstantData & "', data_composite_data='" & szCompositeData & _
                "', data_output_format='" & szOutputFormat & "', data_condition_fldvalue='" & szConditionFld & _
                "', data_condition_replvalue='" & szReplvalue & "', data_repl_charcode='" & szReplCharCode & _
                "', data_checkposcode=" & boolCheckPoscode & ", data_get_lastdayofmth=" & boolLastDayofMth & _
                ", data_date_fldformat='" & szDateFormat & "', data_old_date_fldformat='" & szOldDateFormat & _
                "', data_currencyfld=" & boolCurrencyFld & " WHERE ds_id=" & dwDSetupID & " and data_fldid = " & dwDataFldId
                szAuditText = "Edit Data Field [" & szDataFldName & "]"
            End If
            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving record.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("Record not found. No record deleted.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 1
                    MessageBox.Show("One Record saved.", "DataSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshGrid()
                    RefreshDataFldNameCombo()
                    UpdateAuditLog(szAuditText, "Setup")
            End Select
            ClearControlBox()
        Catch ex As Exception
            MessageBox.Show("AddModifyDataFld: Exception-" & ex.Message())
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim szSQL As String
        Dim dwReturnRow As Integer
        Dim dwDataFldId As Integer
        Dim szDataFldName As String
        If Trim(lblDataFldID.Text) <> "" Then
            dwDataFldId = CLng(Trim(lblDataFldID.Text))
            szDataFldName = Trim(txtDataFldName.Text)
            If (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

            szSQL = "DELETE From DataSetup WHERE ds_id=" & dwDSetupID & " And data_fldid = " & dwDataFldId
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
                    RefreshGrid()
                    RefreshDataFldNameCombo()
                    UpdateAuditLog("Delete data field [" & szDataFldName & "]", "Setup")
            End Select
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmbDataFldName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDataFldName.SelectedValueChanged
        If Trim(cmbDataFldName.Text) = "" Then Exit Sub
        If Trim(txtCompositeFld.Text) <> "" Then
            txtCompositeFld.Text = txtCompositeFld.Text & "+<" & Trim(cmbDataFldName.Text) & ">"
        Else
            txtCompositeFld.Text = "<" & Trim(cmbDataFldName.Text) & ">"
        End If

    End Sub


 
End Class