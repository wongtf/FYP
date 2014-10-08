Imports System.IO

Public Class frmLoadData
    Dim szEmbFilePath As String = BankInfo.Folder_Input

    Private Sub RefreshDataFile()
        Dim szFiles As String() = Directory.GetFiles(szEmbFilePath)
        Dim szFilename As String
        Dim szFileNameOnly As String
        cmbEmbFile.Text = ""
        cmbEmbFile.Items.Clear()
        For Each szFilename In szFiles
            szFileNameOnly = Path.GetFileName(szFilename)
            cmbEmbFile.Items.Add(szFileNameOnly)
        Next
    End Sub

    Private Sub EnableControl(ByVal boolEnabled As Boolean)
        cmdLoadOne.Enabled = boolEnabled
        cmdLoadAll.Enabled = boolEnabled
    End Sub

    Private Sub cmdLoadOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadOne.Click
        Try
            Dim szEmbFile As String
            Dim szErrorDesc As String = ""
            Dim dwJobIndex As Integer
            Dim dwJobID As Long

            lstGoodFile.Items.Clear()
            lstErrorFile.Items.Clear()
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            'FunctionType for this module always is 1 - import data)
            If (LoadAllJobInfo(BankInfo.Id, 1, szErrorDesc) = False) Then
                MessageBox.Show("LoadAllJobInfo return " & szErrorDesc)
                Exit Try
            End If
            szEmbFile = Trim(cmbEmbFile.Text)
            
            If szEmbFile <> "" Then
                EnableControl(False)
                dwJobIndex = GetJobID(BankInfo.Id, szEmbFile, dwJobID)
                If (dwJobIndex <> -1) Then
                    If DataConversion(szEmbFile, dwJobID, szErrorDesc) = False Then
                        lstErrorFile.Items.Add(szEmbFile & " - " & szErrorDesc)
                    End If
                Else
                    lstErrorFile.Items.Add(szEmbFile & " not defined for Import data function group.")
                End If
            End If
            
        Catch ex As Exception
            MessageBox.Show("frmLoadData.cmdLoadOne.click: Exception-" & ex.Message)
        Finally
            EnableControl(True)
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cmdLoadAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadAll.Click
        Try
            Dim dwRawFile As Integer
            Dim dwi As Integer
            Dim szEmbFile As String
            Dim szErrordesc As String = ""
            Dim dwJobIndex As Integer
            Dim dwJobID As Long

            dwRawFile = cmbEmbFile.Items.Count
            lstErrorFile.Items.Clear()
            lstGoodFile.Items.Clear()
            If dwRawFile > 0 Then

                'FunctionType for this module always is 1 - import data)
                If (LoadAllJobInfo(BankInfo.Id, 1, szErrordesc) = False) Then
                    MessageBox.Show("LoadAllJobInfo return " & szErrordesc)
                    Exit Try
                End If

                EnableControl(False)
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                For dwi = dwRawFile - 1 To 0 Step -1
                    cmbEmbFile.Text = cmbEmbFile.Items.Item(dwi)
                    szEmbFile = Trim(cmbEmbFile.Text)
                    If szEmbFile <> "" Then
                        dwJobIndex = GetJobID(BankInfo.Id, szEmbFile, dwJobID)
                        If (dwJobIndex <> -1) Then
                            If DataConversion(szEmbFile, dwJobID, szErrordesc) = False Then
                                lstErrorFile.Items.Add(szEmbFile & " - " & szErrordesc)
                            End If
                        Else
                            lstErrorFile.Items.Add(szEmbFile & " not defined for Import data function group.")
                        End If
                    End If
                Next dwi
            End If
        Catch ex As Exception
            MessageBox.Show("frmLoadData.cmdLoadAll.click: Exception-" & ex.Message)
        Finally
            EnableControl(True)
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Function DataConversion(ByVal szEmbFile As String, ByVal dwJobID As Integer, ByRef szErrorDesc As String) As Boolean
        Dim szEmbFileName As String
        Dim szTempEmbFileName As String
        Dim szEmbFileNameonly As String
        Dim szTempOutputFile As String
        Dim szCardType As String = ""
        Dim szCardtypedesc As String = ""
        Dim szFileType As String = ""
        Dim szFileDate As String = ""
        Dim szEmbFileBakName As String
        Dim szErrorFileName As String
        Dim szEmbFileOutputName As String

        Dim dwCardSetupID As Integer
        Dim dwDataSetupID As Integer
        Dim dwRecordSize As Long
        Dim dwHeaderSize As Long
        Dim dwTrailerSize As Long
        Dim szRecordSeparator As String = ""
        Dim szEndRecordSeparator As String = ""
        Dim dwCardID As Integer
        Dim dwMailerInd As Integer
        Dim szCardID As String = ""
        Dim szMailerInd As String = ""
        Dim szSuppMailerInd As String = ""
        Dim dwfname_Startpos As Integer
        Dim dwfname_Length As Integer
        Dim dwfdate_Startpos As Integer
        Dim dwfdate_Length As Integer
        Dim dwftype_Startpos As Integer
        Dim dwftype_Length As Integer

        Dim dwFileNum As Integer = 0
        Dim dwErrFileNum As Integer = 0
        Dim dwOutputfileNum As Integer = 0
        Dim lngRecPosition As Long = 1
        Const lngMaxInputLen As Long = 10000
        Dim lngFileLen As Long
        Dim lngInputLen As Long
        Dim lngOutPutLen As Long
        Dim lngSuppOutPutLen As Long
        Dim lngLeftLen As Long
        Dim lngInputSuppLen As Long
        Dim lngSuppRecPosition As Long
        Dim szLastTextLine As String = ""
        Dim szTempString As String = ""
        Dim szTextLine As String = ""
        Dim szTempSuppString As String = ""
        Dim szSuppTextLine As String = ""
        Dim szLastSuppTextLine As String = ""

        Dim dwSeparatorPosition As Integer

        Dim dwTempInt As Integer = 0
        Dim dwEmbInt As Integer = 0
        Dim szEmbData As String = ""
        Dim dwOCRInt As Integer = 0
        Dim szOCRData As String = ""
        Dim dwEncInt As Integer = 0
        Dim szEncData As String = ""
        Dim dwMailerInt As Integer = 0
        Dim szMailerData As String = ""
        Dim szSMCData As String = ""
        Dim dwReportInt As Integer = 0
        Dim dwProcID As Integer = 0

        Dim lngRecCount As Long = 0
        Dim lErrcount As Long = 0

        Dim myconn As New OleDb.OleDbConnection()

        Dim dwSCFldCount As Integer

        Try
            DataConversion = False
            szErrorDesc = ""
            'setting db
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            'get the product type desc from embfile
            'filter out the file extension and "_" symbol

            szEmbFileName = szEmbFilePath & szEmbFile
            szEmbFileNameonly = Path.GetFileNameWithoutExtension(szEmbFile)
            szTempEmbFileName = gszWorkDrive & "Conversion.dat"
            szTempOutputFile = gszWorkDrive & "ConvOutput.dat"
            szEmbFileOutputName = BankInfo.Folder_DC9K & szEmbFileNameonly & ".9k.enc"
            WipeFile(szEmbFileOutputName)
            WipeFile(szTempOutputFile)
            szEmbFileBakName = BankInfo.Folder_Backup & szEmbFile
            szErrorFileName = BankInfo.Folder_Error & szEmbFile

            myCmd.CommandText = "SELECT JobSetup.cs_id, JobSetup.job_description, DatasetupSpec.ds_recordsize, DatasetupSpec.ds_headersize, " & _
                                "DatasetupSpec.ds_trailersize, DatasetupSpec.ds_recordseparator, CardSetupSpec.ds_id, " & _
                                "CardSetupSpec.cs_cardid, CardSetupSpec.cs_mailerInd, JobSetup.job_fname_start_pos, JobSetup.job_fname_length, " & _
                                "JobSetup.job_fdate_start_pos, JobSetup.job_fdate_length, JobSetup.job_ftype_start_pos, JobSetup.job_ftype_length FROM DatasetupSpec " & _
                                "INNER JOIN (CardSetupSpec INNER JOIN JobSetup ON CardSetupSpec.cs_id = JobSetup.cs_id) " & _
                                "ON DatasetupSpec.ds_id = CardSetupSpec.ds_id " & _
                                "WHERE JobSetup.job_id=" & dwJobID
            datareader = myCmd.ExecuteReader()

            If datareader.HasRows Then
                While datareader.Read()
                    dwCardSetupID = IIf(IsDBNull(datareader("cs_id")), 0, Val(datareader("cs_id")))
                    szCardtypedesc = IIf(IsDBNull(datareader("job_description")), "", datareader("job_description"))
                    dwDataSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
                    dwRecordSize = IIf(IsDBNull(datareader("ds_recordsize")), 0, Val(datareader("ds_recordsize")))
                    dwHeaderSize = IIf(IsDBNull(datareader("ds_headersize")), 0, Val(datareader("ds_headersize")))
                    dwTrailerSize = IIf(IsDBNull(datareader("ds_trailersize")), 0, Val(datareader("ds_trailersize")))
                    szRecordSeparator = IIf(IsDBNull(datareader("ds_recordseparator")), "", datareader("ds_recordseparator"))
                    szRecordSeparator = IIf(Trim(szRecordSeparator) = "", szRecordSeparator, HEXtoCHAR(szRecordSeparator))
                    dwCardID = IIf(IsDBNull(datareader("cs_cardid")), 0, Val(datareader("cs_cardid")))
                    dwMailerInd = IIf(IsDBNull(datareader("cs_mailerInd")), 0, Val(datareader("cs_mailerInd")))
                    dwfname_Startpos = IIf(IsDBNull(datareader("job_fname_start_pos")), 0, Val(datareader("job_fname_start_pos")))
                    dwfname_Length = IIf(IsDBNull(datareader("job_fname_length")), 0, Val(datareader("job_fname_length")))
                    dwfdate_Startpos = IIf(IsDBNull(datareader("job_fdate_start_pos")), 0, Val(datareader("job_fdate_start_pos")))
                    dwfdate_Length = IIf(IsDBNull(datareader("job_fdate_length")), 0, Val(datareader("job_fdate_length")))
                    dwftype_Startpos = IIf(IsDBNull(datareader("job_ftype_start_pos")), 0, Val(datareader("job_ftype_start_pos")))
                    dwftype_Length = IIf(IsDBNull(datareader("job_ftype_length")), 0, Val(datareader("job_ftype_length")))
                End While
            Else
                'MessageBox.Show(szCardType& " not defined in card type table!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                szErrorDesc = szCardType & " not defined in card type table for " & szEmbFile
                Return False
            End If
            datareader.Close()

            szCardType = Mid(szEmbFile, dwfname_Startpos, dwfname_Length)
            szFileType = Mid(szEmbFile, dwftype_Startpos, dwftype_Length)
            szFileDate = Mid(szEmbFile, dwfdate_Startpos, dwfdate_Length)

            Dim szSQL As String = "SELECT cs_EndRecord_Separator FROM CardSetupSpec where cs_id=" & dwCardSetupID
            szEndRecordSeparator = GetFieldDataSQL(szSQL, "cs_EndRecord_Separator")

            lblProdStatus.Text = "Decrypting file " & szEmbFileName
            lblProdStatus.Refresh()

            'Decrypt the file before proceed further
            If chkNoFileEnc.Checked = True Then
                If MyCopyFile(szEmbFileName, szTempEmbFileName) = False Then
                    szErrorDesc = "Error decrypting " & szEmbFileName
                    Return False
                End If
            Else
                If DecryptFile(szEmbFileName, szTempEmbFileName) = False Then
                    szErrorDesc = "Error decrypting " & szEmbFileName
                    Return False
                End If
            End If
            
            dwFileNum = FreeFile()
            'open the input file for processing
            FileOpen(dwFileNum, szTempEmbFileName, OpenMode.Binary)

            'open the input file for processing
            dwErrFileNum = FreeFile()
            FileOpen(dwErrFileNum, szErrorFileName, OpenMode.Binary, OpenAccess.Write)
            If dwHeaderSize > 0 Then
                szTempString = New String(" ", dwHeaderSize)
                Seek(dwFileNum, lngRecPosition)
                FileGet(dwFileNum, szTempString)
                FilePut(dwErrFileNum, szTempString)
            End If
            lngFileLen = FileLen(szTempEmbFileName) - dwHeaderSize
            lngRecPosition = dwHeaderSize + 1

            dwOutputfileNum = FreeFile()
            FileOpen(dwOutputfileNum, szTempOutputFile, OpenMode.Binary, OpenAccess.Write)

            '************
            'Fixed the number of bytes to be input
            '************
            If lngFileLen >= lngMaxInputLen Then
                lngInputLen = lngMaxInputLen
            Else
                lngInputLen = lngFileLen
            End If

            'if fixed length record
            If dwRecordSize > 0 Then
                szTempString = New String(" ", dwRecordSize)
            Else
                szTempString = New String(" ", lngInputLen)
            End If

            lngOutPutLen = lngRecPosition

            dwEmbInt = GetEmbossFld(dwCardSetupID)
            dwOCRInt = GetOCRFld(dwCardSetupID)
            dwEncInt = GetEncodeFld(dwCardSetupID)
            dwMailerInt = GetMailerFld(dwCardSetupID)
            dwReportInt = GetReportFld(dwCardSetupID)
            dwSCFldCount = GetCountSQL("SELECT * FROM SMCDetails where cs_id=" & dwCardSetupID)

            Do While lngOutPutLen < lngFileLen
                'set the next record position
                Seek(dwFileNum, lngRecPosition)
                FileGet(dwFileNum, szTempString)
                'vExtractLine = Input(lInputLen, #1)
                szTempString = szLastTextLine & szTempString

ReadNextRec:
                If dwRecordSize > 0 Then 'fixed length
                    'already end of file
                    If lngRecPosition >= lngFileLen Then Exit Do
                    If lngFileLen - lngRecPosition < dwRecordSize - 1 Then
                        Exit Do
                    End If
                    Seek(dwFileNum, lngRecPosition)
                    FileGet(dwFileNum, szTempString)
                    szTextLine = szTempString
                    lngRecPosition = lngRecPosition + dwRecordSize
                    If Len(szTextLine) <> dwRecordSize Then
                        Exit Do 'end of file liao
                    End If
                Else    'variable length
                    'extract the record based on record separator
                    dwSeparatorPosition = InStr(szTempString, szRecordSeparator)
                    If dwSeparatorPosition = 0 And lngOutPutLen <= lngFileLen Then
                        GoTo ReadNextChunk
                    Else
                        'lRecLen = lsepfound
                        szTextLine = Mid(szTempString, 1, dwSeparatorPosition + Len(szRecordSeparator))
                    End If
                End If

                lblProdStatus.Text = "Processing record " & lngRecCount & " from " & szEmbFileName
                lblProdStatus.Refresh()

                szCardID = GetFieldData(szTextLine, "", dwDataSetupID, dwCardID)

                If dwEmbInt > 0 Then
                    szEmbData = FormatEmbossData(szTextLine, dwEmbInt)
                    If szEmbData = "" Then
                        szErrorDesc = "Error formatting emboss data for Cardno " & szCardID & " in " & szEmbFile
                        lstErrorFile.Items.Add(szErrorDesc)
                        FilePut(dwErrFileNum, szTextLine)
                        lErrcount = lErrcount + 1
                        GoTo NextNewDataRec
                    End If
                Else
                    szEmbData = ""
                End If

                If dwOCRInt > 0 Then
                    szOCRData = FormatOCR(szTextLine, dwCardSetupID, dwOCRInt)
                    If szOCRData = "" Then
                        szErrorDesc = "Error formatting OCR data for Cardno " & szCardID & " in " & szEmbFile
                        lstErrorFile.Items.Add(szErrorDesc)
                        FilePut(dwErrFileNum, szTextLine)
                        lErrcount = lErrcount + 1
                        GoTo NextNewDataRec
                    End If
                Else
                    szOCRData = ""
                End If

                If dwEncInt > 0 Then
                    szEncData = FormatEncode(szTextLine, dwCardSetupID, dwEncInt)
                    If szEncData = "" Then
                        szErrorDesc = "Error formatting encode data for Cardno " & szCardID & " in " & szEmbFile
                        lstErrorFile.Items.Add(szErrorDesc)
                        FilePut(dwErrFileNum, szTextLine)
                        lErrcount = lErrcount + 1
                        GoTo NextNewDataRec
                    End If
                Else
                    szEncData = ""
                End If

                'check whether there is SMC setup in db
                'check the datafld name already in the db
                If dwSCFldCount > 0 Then
                    'If Dir(szSCDataFileName, FileAttribute.Archive + FileAttribute.Normal) <> "" Then
                    '    Kill(szSCDataFileName)
                    'End If

                    szSMCData = FormatSMC(szTextLine, dwCardSetupID)
                    If szSMCData = "" Then
                        szErrorDesc = "Error formatting smart card data for CardNo " & szCardID & " in " & szEmbFile
                        lstErrorFile.Items.Add(szErrorDesc)
                        'add to error count
                        FilePut(dwErrFileNum, szTextLine)
                        lErrcount = lErrcount + 1
                        GoTo NextNewDataRec
                    End If
                Else
                    szSMCData = ""
                End If

                If dwMailerInd <> 0 Then
                    szMailerInd = GetFieldData(szTextLine, "", dwDataSetupID, dwMailerInd)
                    szSuppTextLine = ""
                    'check the mailer indicator; if 2-pass in current and next data; if 1-oni pass in current data; if space-oni pass in current data
                    If szMailerInd = "2" Then
                        If dwRecordSize > 0 Then 'fixed length
                            'already end of file
                            If lngRecPosition >= lngFileLen Then
                                szErrorDesc = "Error formatting mailer info for supp card for " & szCardID & " in " & szEmbFile
                                lstErrorFile.Items.Add(szErrorDesc)
                                FilePut(dwErrFileNum, szTextLine)
                                lErrcount = lErrcount + 1
                                GoTo NextNewDataRec
                                'Return False
                            End If
                            Seek(dwFileNum, lngRecPosition)
                            FileGet(dwFileNum, szTempString)
                            szSuppTextLine = szTempString
                            If Len(szSuppTextLine) <> dwRecordSize Then
                                szErrorDesc = "Error formatting mailer info for supp card for " & szCardID & " in " & szEmbFile
                                lstErrorFile.Items.Add(szErrorDesc)
                                FilePut(dwErrFileNum, szTextLine)
                                lErrcount = lErrcount + 1
                                GoTo NextNewDataRec
                                'Return False
                            End If
                        Else    'variable length
                            'extract the record based on record separator
                            szTempSuppString = Mid(szTempString, dwSeparatorPosition + Len(szRecordSeparator))
                            lngSuppOutPutLen = lngOutPutLen
                            lngInputSuppLen = lngInputLen
ReCheckSupp:
                            dwSeparatorPosition = InStr(szTempSuppString, szRecordSeparator)
                            If dwSeparatorPosition = 0 And lngSuppOutPutLen <= lngFileLen Then
                                lngSuppRecPosition = lngRecPosition + lngInputSuppLen
                                lngSuppOutPutLen = lngSuppOutPutLen + lngInputSuppLen '- 1
                                szLastSuppTextLine = szTempSuppString
                                If lngSuppOutPutLen < lngFileLen Then
                                    lngLeftLen = lngFileLen - lngSuppOutPutLen + 1
                                    If lngLeftLen >= lngMaxInputLen Then
                                        lngInputSuppLen = lngMaxInputLen
                                    Else
                                        lngInputSuppLen = lngLeftLen
                                    End If
                                    Seek(dwFileNum, lngSuppRecPosition)
                                    FileGet(dwFileNum, szTempString)
                                    'vExtractLine = Input(lInputLen, #1)
                                    szTempSuppString = szLastSuppTextLine & szTempString
                                    GoTo ReCheckSupp
                                Else
                                    szErrorDesc = "Error formatting mailer info for supp card for " & szCardID & " in " & szEmbFile
                                    lstErrorFile.Items.Add(szErrorDesc)
                                    FilePut(dwErrFileNum, szTextLine)
                                    lErrcount = lErrcount + 1
                                    GoTo NextNewDataRec
                                    'Return False
                                End If
                            Else
                                'lRecLen = lsepfound
                                szSuppTextLine = Mid(szTempSuppString, 1, dwSeparatorPosition + Len(szRecordSeparator))
                            End If
                        End If
                        szSuppMailerInd = GetFieldData(szSuppTextLine, "", dwDataSetupID, dwMailerInd)
                        If szSuppMailerInd <> " " Then
                            szErrorDesc = "Error formatting mailer info for supp card for " & szCardID & " in " & szEmbFile
                            lstErrorFile.Items.Add(szErrorDesc)
                            FilePut(dwErrFileNum, szTextLine)
                            lErrcount = lErrcount + 1
                            GoTo NextNewDataRec
                        End If
                    End If
                    If szMailerInd <> " " Then
                        If dwMailerInt > 0 Then
                            szMailerData = FormatMailer(szTextLine, szSuppTextLine, dwCardSetupID, dwMailerInt)
                            If szMailerData = "" Then
                                szErrorDesc = "Error formatting mailer data for Cardno " & szCardID & " in " & szEmbFile
                                lstErrorFile.Items.Add(szErrorDesc)
                                FilePut(dwErrFileNum, szTextLine)
                                lErrcount = lErrcount + 1
                                GoTo NextNewDataRec
                            End If
                        Else
                            szMailerData = ""
                        End If
                    Else
                        szMailerData = ""
                    End If
                Else
                    szMailerData = ""
                End If

                If dwReportInt > 0 Then
                    If FormatReportFld(szTextLine, szSuppTextLine, dwReportInt, szEmbFileNameonly, szCardType, szCardtypedesc, szFileType, szFileDate, lngRecCount + 1, szCardID) = False Then
                        szErrorDesc = "Error formatting Report Field for Cardno " & szCardID & " in " & szEmbFile
                        lstErrorFile.Items.Add(szErrorDesc)
                        FilePut(dwErrFileNum, szTextLine)
                        lErrcount = lErrcount + 1
                        GoTo NextNewDataRec
                    End If
                End If

                FilePut(dwOutputfileNum, Strings.Format(lngRecCount + 1, "000000") & szEmbData & szOCRData & szEncData & szMailerData & szSMCData & szEndRecordSeparator)


                'szSQL = "INSERT INTO " & szEmbFileTblName & " (RecNo, EmbData, OCRData, EncData, CardNo, CardExpDate, " & _
                '    "RecSplitType, PrintFlag) VALUES (" & lngRecCount - 1 & ", '" & szEmbData & "', '" & szOCRData & _
                '    "', '" & szEncData & "', '" & szDbCardNo & "', '" & szCardExpDate & "', '" & szRecSplitType & "', 0)"

                'dwReturnRow = ExecuteSQL(szSQL, gszProdDbConnectString)
                'End If
                'Select Case dwReturnRow
                '    Case -1
                '        MessageBox.Show("Error occur when saving record.", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '        'add to error count
                'End Select

NextNewDataRec:
                lngRecCount = lngRecCount + 1
                If dwRecordSize = 0 Then
                    szTempString = Mid(szTempString, dwSeparatorPosition + Len(szRecordSeparator))
                End If
                GoTo ReadNextRec

ReadNextChunk:
                lngRecPosition = lngRecPosition + lngInputLen
                lngOutPutLen = lngOutPutLen + lngInputLen '- 1
                szLastTextLine = szTempString
                If lngOutPutLen < lngFileLen Then
                    lngLeftLen = lngFileLen - lngOutPutLen + 1
                    If lngLeftLen >= lngMaxInputLen Then
                        lngInputLen = lngMaxInputLen
                    Else
                        lngInputLen = lngLeftLen
                    End If
                    szTempString = New String(" ", lngInputLen)
                Else
                    Exit Do
                End If
            Loop
            'print trailer to errfile if there is trailer
            If dwTrailerSize > 0 Then
                szTempString = New String(" ", dwTrailerSize)
                Seek(dwFileNum, FileLen(szTempEmbFileName) - dwTrailerSize + 1)
                FileGet(dwFileNum, szTempString)
                FilePut(dwErrFileNum, szTempString)
            End If
            'lngFileLen = FileLen(szEmbFileName) - dwHeaderSize
            'lngRecPosition = dwHeaderSize + 1

            FileClose(dwFileNum)
            FileClose(dwErrFileNum)
            FileClose(dwOutputfileNum)

            If lErrcount = 0 Then
                WipeFile(szErrorFileName)
            End If

            lblProdStatus.Text = "Encrypting file " & szEmbFileName
            lblProdStatus.Refresh()

            If FileLen(szTempOutputFile) > 0 Then
                'encrypt back the file here
                If EncryptFile(szTempOutputFile, szEmbFileOutputName) = False Then
                    szErrorDesc = "Error Encrypting file " & szEmbFile
                    Return False
                End If
            Else
                WipeFile(szTempOutputFile)
            End If

            If lngRecCount > 0 Then
                MyMoveFile(szEmbFileName, szEmbFileBakName)
                WipeFile(szEmbFileName)
            Else
                szErrorDesc = "No record found in file" 'dwErrorNum = 10
                Return False
            End If

            RefreshDataFile()

            'add on 14/4/10 to update deliverytype using stored procedure
            'Temporary remarks until further notice
            'szSQL = "EXEC sp_updatedeliverytype '" & szEmbFileNameonly & "'"
            'ExecuteSQL(szSQL)

            UpdateAuditLog("Data conversion completed for file[" & szEmbFile & "] with good card[" & lngRecCount - lErrcount & "] and error card[" & lErrcount & "]", "Production")
            'UpdateAuditLog(lngRecCount - lErrcount & " of " & lngRecCount & " records successfully loaded from " & szEmbFile, "Production")
            'MsgBox(lngRecCount & " records successfully loaded from " & szEmbFile & "!")
            lstGoodFile.Items.Add(szEmbFile & " - GoodRec: " & lngRecCount - lErrcount & " ErrRec: " & lErrcount)
            DataConversion = True
        Catch ex As Exception
            MessageBox.Show("frmLoadData.DataConversion[" & dwCardSetupID & "]: Exception-" & ex.Message)
            szErrorDesc = ex.Message
            If InStr(ex.Message, "The process cannot access the file") > 0 Then
                FileClose(dwFileNum)
                FileClose(dwErrFileNum)
                FileClose(dwOutputfileNum)
            ElseIf InStr(ex.Message, "") > 0 Then
                'drop the table
            End If
        Finally
            FileClose(dwFileNum)
            FileClose(dwErrFileNum)
            FileClose(dwOutputfileNum)
            myconn.Close()
        End Try
    End Function

    Private Sub frmLoadData_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim myconn As New OleDb.OleDbConnection()
        Try
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            'print the audit report to printer
            Dim szReportFile As String = "LoadReport.rpt"
            Dim szSQL As String
            Dim dwReturnRow As Integer
            Dim szFileType As String

            myCmd.CommandText = "Select DISTINCT(data_filetype) From Data Where data_firstload='True'"
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    szFileType = IIf(IsDBNull(datareader("data_filetype")), "", datareader("data_filetype"))
                    szSQL = "SELECT * From Data where data_filetype='" & szFileType & " ' AND data_firstload='True' ORDER By data_rec_no"
                    PrintProductionReport(szSQL, "", "", szReportFile, "")
                End While

                szSQL = "UPDATE Data SET data_firstload='False' WHERE data_firstload='True'"

                dwReturnRow = ExecuteSQL(szSQL)

                Select Case dwReturnRow
                    Case -1
                        MessageBox.Show("Error occur when update record into Data.", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'add to error count
                End Select
            End If
            datareader.Close()
        Catch ex As Exception
            MessageBox.Show("frmLoadData_FormClosing : Exception-" & ex.Message)
        Finally
            myconn.Close()
            Me.Dispose()
        End Try
    End Sub

    Private Sub frmLoadData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Data Conversion", "Audit Log")
        If Directory.Exists(szEmbFilePath) = False Then
            MsgBox("The " & szEmbFilePath & " not found!")
            EnableControl(False)
            Exit Sub
        End If

        RefreshDataFile()
    End Sub
End Class