Imports System.IO
Module ModConvFunction
    'for data design spec
    Public dwDataRecLength As Long
    Public szDataRecSep As String
    Public dwDataHeaderSize As Long
    Public dwDataTrailerSize As Long
    'added by lim
    Public sTempFileName As String

    'Structure MailerFormFld
    '    MFName As String * 5
    '    dfname As String * 30
    '    SuppCard As Boolean
    'End Structure

    Private Structure EmbossFld
        Dim dwDSetupID As Integer
        Dim dwDataFldID As Integer
        Dim dwColOffset As Long
        Dim dwRowOffset As Long
        Dim szModuleID As String
    End Structure
    Dim EmbossFldArr() As EmbossFld

    Private Structure EncodeFld
        Dim dwDSetupID As Integer
        Dim dwDataFldID As Integer
        Dim dwTrackNum As Integer
        Dim szSeparator As String
    End Structure
    Dim EncodeFldArr() As EncodeFld

    Private Structure OCRFld
        Dim dwDSetupID As Integer
        Dim dwDataFldID As Integer
        Dim dwColOffset As Long
        Dim dwRowOffset As Long
    End Structure
    Dim OCRFldArr() As OCRFld

    Private Structure ReportFld
        Dim dwDSetupID As Integer
        Dim dwDataFldID As Integer
        Dim szReportFldName As String
        Dim szReportFldValue As String
    End Structure
    Dim ReportFldArr() As ReportFld

    Private Structure MailerFld
        Dim dwDSetupID As Integer
        Dim dwDataFldID As Integer
        Dim szMailerFldName As String
    End Structure
    Dim MailerFldArr() As MailerFld

    Private Structure SMCFld
        Dim dwDSetupID As Integer
        Dim dwDataFldID As Integer
        Dim szTagName As String
        Dim szTagLength As String
        Dim szAppName As String
    End Structure
    Dim SMCFldArr() As SMCFld

    ''Data Field definition
    'Public Structure DataFld
    '    Dim szdfName As String
    '    Dim dwFldStartPos As Integer
    '    Dim dwFldLen As Integer
    '    Dim szFldStartCode As String
    '    Dim szFldEndCode As String
    '    Dim dwDatatype As Integer     '0 for variable; 1 for constant, 2 for combine field
    '    Dim szConstantData As String
    '    Dim szCompositeData As String
    '    Dim szOutputFormat As String
    'End Structure

    'Public MailerFormArr() As MailerFormFld

    Public Function GetFieldData(ByVal szRawText As String, ByVal szRawSuppText As String, ByVal dwDSetupID As Integer, ByVal dwDataFldID As Integer) As String
        Dim dwStartPosition As Integer
        Dim dwFldleng As Integer
        Dim szStartCode As String
        Dim szEndCode As String

        Dim szCompositeData As String
        Dim dwDataType As Integer
        Dim szConditionfld As String
        Dim szReplValue As String

        Dim szConstantData As String = ""
        Dim szOutputData As String = ""
        Dim szOutputFormat As String
        Dim szReplaceChar As String
        Dim boolCheckPoscode As Boolean
        Dim boolGetLastDayOfMth As Boolean
        Dim boolCurrencyFld As Boolean
        Dim szCNType As String
        Dim myconn As New OleDb.OleDbConnection()
        Dim szSQL As String

        Dim szOldDateFormat As String = ""
        Dim szDateFormat As String = ""

        GetFieldData = ""
        'Try
        On Error GoTo chkerr
        myconn.ConnectionString = gszConnString
        myconn.Open()

        Dim myCmd As New OleDb.OleDbCommand()
        myCmd.Connection = myconn
        Dim datareader As OleDb.OleDbDataReader = Nothing

        'get the data field definition
        myCmd.CommandText = "SELECT * FROM DataSetup where ds_id=" & dwDSetupID & " and data_fldid=" & dwDataFldID
        datareader = myCmd.ExecuteReader()
        If datareader.HasRows Then
            datareader.Read()
            dwDataType = IIf(IsDBNull(datareader("data_field_type")), 0, Val(datareader("data_field_type")))
            szDateFormat = IIf(IsDBNull(datareader("data_date_fldformat")), "", datareader("data_date_fldformat"))
            szOldDateFormat = IIf(IsDBNull(datareader("data_old_date_fldformat")), "", datareader("data_old_date_fldformat"))
            dwStartPosition = IIf(IsDBNull(datareader("data_start_pos")), 0, Val(datareader("data_start_pos")))
            dwFldleng = IIf(IsDBNull(datareader("data_length")), 0, Val(datareader("data_length")))

            'get the start code in hex and convert to character
            szStartCode = IIf(IsDBNull(datareader("data_start_code")), "", datareader("data_start_code"))
            szEndCode = IIf(IsDBNull(datareader("data_end_code")), "", datareader("data_end_code"))

            szConditionfld = IIf(IsDBNull(datareader("data_condition_fldValue")), "", datareader("data_condition_fldValue"))
            szReplValue = IIf(IsDBNull(datareader("data_condition_replValue")), "", datareader("data_condition_replValue"))

            szConstantData = IIf(IsDBNull(datareader("data_constant")), "", datareader("data_constant"))
            szCompositeData = IIf(IsDBNull(datareader("data_composite_data")), "", datareader("data_composite_data"))

            szReplaceChar = IIf(IsDBNull(datareader("data_repl_charCode")), "", datareader("data_repl_charCode"))
            boolCheckPoscode = IIf(IsDBNull(datareader("data_checkPoscode")), False, CBool(datareader("data_checkPoscode")))
            boolGetLastDayOfMth = IIf(IsDBNull(datareader("data_get_lastDayofMth")), False, CBool(datareader("data_get_lastDayofMth")))
            boolCurrencyFld = IIf(IsDBNull(datareader("data_currencyfld")), False, CBool(datareader("data_currencyfld")))
            szOutputFormat = IIf(IsDBNull(datareader("data_output_format")), "", datareader("data_output_format"))
        Else
            Return ""
        End If
        datareader.Close()
        myconn.Close()
        Select Case dwDataType
            Case 0, 4 'variable field

                'pass the FIRData to format if it is refer to FIR
                szOutputData = FormatVariableFld(dwStartPosition, dwFldleng, szStartCode, szEndCode, szRawText, dwDSetupID, dwDataFldID)

                'If it is condition fld
                If dwDataType = 4 Then
                    szOutputData = FormatConditionFld(szConditionfld, szReplValue, szOutputData)
                End If
            Case 1 'constant field
                szOutputData = szConstantData
            Case 2 'composite field
                '*****************************
                'format the combine field text data
                szOutputData = FormatCompositeFld(szCompositeData, szRawText, szRawSuppText, dwDSetupID, dwDataFldID)
            Case 3 'set system date field
                Dim dtSystemDate As DateTime = DateTime.Now.ToString("d")
                If szDateFormat <> "" Then
                    szOutputData = Microsoft.VisualBasic.Format(dtSystemDate, szDateFormat)
                Else
                    szOutputData = Convert.ToString(szDateFormat)
                End If
        End Select

        'replace character in string
        If szReplaceChar <> "" Then
            Dim CharCode() As String = szReplaceChar.Split(",")
            If UBound(CharCode) = 1 Then
                szOutputData = Replace(szOutputData, Chr("&H" & CharCode(0)), Chr("&H" & CharCode(1)), 1, , vbTextCompare)
            Else
                Return ""
            End If
        End If

        'If boolCheckPoscode = True Then
        '    szCNType = CheckPoscode(szOutputData)
        '    If szCNType = "" Then
        '        szOutputData = BankInfo.Default_CN
        '    Else
        '        szOutputData = szCNType
        '    End If
        'End If

        If szOldDateFormat <> "" Then
            Dim enGB As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("en-US", True)
            enGB.DateTimeFormat.ShortDatePattern = szOldDateFormat
            Dim szTempDate As DateTime = Convert.ToDateTime(szOutputData, enGB)
            szOutputData = Microsoft.VisualBasic.Format(szTempDate, szDateFormat)
        End If

        If boolGetLastDayOfMth = True Then
            Dim dtLastDateofMth As DateTime = GetLastDayOfMonth(szOutputData)
            If szDateFormat <> "" Then
                szOutputData = Microsoft.VisualBasic.Format(dtLastDateofMth, szDateFormat)
            Else
                szOutputData = Convert.ToString(dtLastDateofMth)
            End If
        End If

        If boolCurrencyFld = True Then
            szOutputData = Microsoft.VisualBasic.Format(Val(szOutputData), "###,###,###,###")
        End If

        'check the output format
        If szOutputFormat <> "" Then
            'if it is HEX format
            If szOutputFormat = "HEX" Then
                GetFieldData = FormatChartoHex(szOutputData)
            Else
                GetFieldData = szOutputData
            End If
        Else
            GetFieldData = szOutputData
        End If

        Exit Function
chkerr:  '   Catch ex As Exception
        MessageBox.Show("modConvFunction.GetFieldData for DataSetupID[" & dwDSetupID & "]" & vbCrLf & " DataFldID[" & dwDataFldID & "]: Exception-" & Err.Description) ' ex.Message)
        'Resume
        'Finally
        myconn.Close()
        'End Try
    End Function

    Private Function FormatVariableFld(ByVal dwStartPosition As Integer, ByVal dwFldLength As Integer, ByVal szStartCode As String, ByVal szEndCode As String, ByVal szRawText As String, ByVal dwDSetupID As Integer, ByVal dwDataFldID As Integer) As String
        Dim dwDataFound As Integer
        Dim dwEndDataFound As Integer

        FormatVariableFld = ""
        Try
            If szStartCode <> "" Then
                szStartCode = HEXtoCHAR(szStartCode)  'convert hex to char
            Else
                szStartCode = ""
            End If

            'get the end code in hex and convert to character

            If szEndCode <> "" Then
                szEndCode = HEXtoCHAR(szEndCode)  'convert hex to char
            Else
                szEndCode = ""
            End If

            If dwStartPosition <> 0 And dwFldLength <> 0 Then
                FormatVariableFld = Mid(szRawText, dwStartPosition, dwFldLength)
            ElseIf dwStartPosition <> 0 And szEndCode <> "" Then
                dwDataFound = InStr(dwStartPosition, szRawText, szEndCode, CompareMethod.Text)
                FormatVariableFld = Mid(szRawText, dwStartPosition, dwDataFound - dwStartPosition)
            ElseIf szStartCode <> "" And dwFldLength <> 0 Then
                dwDataFound = InStr(szRawText, szStartCode)
                FormatVariableFld = Mid(szRawText, dwDataFound + Len(szStartCode), dwFldLength)
            ElseIf szStartCode <> "" And szEndCode <> "" Then
                dwDataFound = InStr(szRawText, szStartCode)
                dwEndDataFound = InStr(dwDataFound, szRawText, szEndCode, CompareMethod.Text)
                FormatVariableFld = Mid(szRawText, dwDataFound + Len(szStartCode), dwEndDataFound - dwDataFound - Len(szStartCode))
            End If
        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatVariableFld for DataSetupID[" & dwDSetupID & "]" & vbCrLf & " DataFldID[" & dwDataFldID & "]: Exception-" & ex.Message)
        End Try
    End Function

    Public Function FormatConditionFld(ByVal szConditionFld As String, ByVal szReplValue As String, ByVal szData As String) As String
        FormatConditionFld = "Undefined"
        Dim szConditionFldArr() As String
        Dim szReplValueArr() As String
        Dim dwi As Integer
        szConditionFldArr = SplitChar(szConditionFld, ",")
        szReplValueArr = SplitChar(szReplValue, ",")
        For dwi = 0 To UBound(szConditionFldArr)
            If szConditionFldArr(dwi) = szData Then
                FormatConditionFld = szReplValueArr(dwi)
                Exit For
            End If
        Next dwi
    End Function

    Public Function CheckConditionFld(ByVal szChkFld As String, ByVal szChkFldValue As String, ByVal szRawData As String, ByVal dwDSetupID As Integer) As Boolean
        CheckConditionFld = False
        Dim szChkFldArr() As String
        Dim szChkFldValueArr() As String
        Dim szRawValue As String
        Dim dwi As Integer
        szChkFldArr = SplitChar(szChkFld, ",")
        szChkFldValueArr = SplitChar(szChkFldValue, ",")
        For dwi = 0 To UBound(szChkFldArr)
            szRawValue = GetFieldData(szRawData, "", dwDSetupID, Val(szChkFldArr(dwi)))
            If szRawValue <> szChkFldValueArr(dwi) Then
                Exit For
            End If
        Next dwi
        CheckConditionFld = True
    End Function

    Private Function SplitChar(ByVal szInputData As String, ByVal szDelimeter As String) As Object
        Dim outarray() As String
        Dim arrsize As Integer

        arrsize = 0
        Do While InStr(szInputData, szDelimeter) > 0
            ReDim Preserve outarray(0 To arrsize)
            outarray(arrsize) = Left(szInputData, InStr(szInputData, szDelimeter) - 1)
            szInputData = Mid(szInputData, InStr(szInputData, szDelimeter) + 1)
            arrsize = arrsize + 1
        Loop

        ' We still have one element left
        ReDim Preserve outarray(0 To arrsize)
        outarray(arrsize) = szInputData
        SplitChar = outarray
    End Function

    Private Function FormatCompositeFld(ByVal szCompositeData As String, ByVal szRawText As String, ByVal szSupplText As String, ByVal dwDSetupID As Integer, ByVal dwDataFldID As Integer) As String
        Dim dwDataLength As Integer
        Dim dwi As Integer
        Dim dwFoundPlusSign As Integer = 0
        Dim szExtChar As String
        Dim szData As String = ""
        Dim szCharCode As String
        Dim szDataFldName As String

        Dim Dbconn As New OleDb.OleDbConnection()

        Dim dwStartPosition As Integer
        Dim dwFldleng As Integer
        Dim szStartCode As String
        Dim szEndCode As String
        Dim boolCurrencyFld As Boolean
        Dim szInputData As String

        FormatCompositeFld = ""
        Try
            Dbconn.ConnectionString = gszConnString
            Dbconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = Dbconn
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim dwDataType As Integer
            Dim szDateFormat As String = ""

            dwDataLength = Len(szCompositeData)
            'search for the "+" sign
            For dwi = 1 To dwDataLength
                dwi = dwFoundPlusSign + 1
                dwFoundPlusSign = InStr(dwi, szCompositeData, "+", vbTextCompare)
                If dwFoundPlusSign = 0 Then
                    szExtChar = Mid(szCompositeData, dwi)
                Else
                    szExtChar = Mid(szCompositeData, dwi, dwFoundPlusSign - dwi)
                End If

                If Mid(szExtChar, 1, 1) = "P" Then
                    szInputData = szRawText
                    szExtChar = Mid(szExtChar, 2)
                ElseIf Mid(szExtChar, 1, 1) = "S" Then
                    szInputData = szSupplText
                    szExtChar = Mid(szExtChar, 2)
                Else
                    szInputData = szRawText
                End If

                If Len(szExtChar) > 5 And Left(szExtChar, 4) = "Chr(" Then
                    szCharCode = Mid(szExtChar, 5, 2)
                    szData = Chr("&H" & szCharCode)
                Else
                    If Left(szExtChar, 1) = "<" Then   'get from the data field from data setup
                        szDataFldName = Mid(szExtChar, 2, Len(szExtChar) - 2)
                        'get the datafield def from db 
                        myCmd.CommandText = "SELECT * FROM DataSetup where ds_id=" & dwDSetupID & " and data_field_name='" & szDataFldName & "'"
                        datareader = myCmd.ExecuteReader()
                        If datareader.HasRows Then
                            datareader.Read()
                            dwDataType = IIf(IsDBNull(datareader("data_field_type")), 0, Val(datareader("data_field_type")))
                            szDateFormat = IIf(IsDBNull(datareader("data_date_fldformat")), "", datareader("data_date_fldformat"))
                            dwStartPosition = IIf(IsDBNull(datareader("data_start_pos")), 0, Val(datareader("data_start_pos")))
                            dwFldleng = IIf(IsDBNull(datareader("data_length")), 0, Val(datareader("data_length")))

                            'get the start code in hex and convert to character
                            szStartCode = IIf(IsDBNull(datareader("data_start_code")), "", datareader("data_start_code"))
                            szEndCode = IIf(IsDBNull(datareader("data_end_code")), "", datareader("data_end_code"))
                            boolCurrencyFld = IIf(IsDBNull(datareader("data_currencyfld")), False, CBool(datareader("data_currencyfld")))
                        Else
                            MessageBox.Show("Can't find DataFldName[" & szDataFldName & "] for DataSetupID[" & dwDSetupID & "]" & vbCrLf & " DataFldID[" & dwDataFldID & "]")
                            FormatCompositeFld = ""
                            Exit For
                        End If
                        datareader.Close()
                        'Dbconn.Close()

                        If dwDataType = 0 Then
                            szData = FormatVariableFld(dwStartPosition, dwFldleng, szStartCode, szEndCode, szInputData, dwDSetupID, dwDataFldID)
                            If boolCurrencyFld = True Then
                                szData = Microsoft.VisualBasic.Format(Val(szData), "###,###,###,###")
                            End If
                        ElseIf dwDataType = 3 Then
                            Dim dtSystemDate As DateTime = DateTime.Now.ToString("d")
                            If szDateFormat <> "" Then
                                szData = Microsoft.VisualBasic.Format(dtSystemDate, szDateFormat)
                            Else
                                szData = Convert.ToString(szDateFormat)
                            End If
                        End If

                    Else 'get from the merge field data
                        szData = szExtChar
                    End If
                End If
                FormatCompositeFld = FormatCompositeFld & szData
                If dwFoundPlusSign = 0 Then
                    Exit For
                End If

            Next dwi

        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatCompositeFld for DataSetupID[" & dwDSetupID & "]" & vbCrLf & " DataFldID[" & dwDataFldID & "]: Exception-" & ex.Message)
            Return ""
        Finally
            Dbconn.Close()
        End Try
    End Function

    Public Function GetEmbossFld(ByVal dwCardSetupID As Integer) As Long
        Try
            Dim myconn As New OleDb.OleDbConnection()
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myCmd.CommandText = "SELECT count(*) FROM EmbossingDetails where cs_id=" & dwCardSetupID
            Dim dwReccnt As Integer = myCmd.ExecuteScalar()
            If dwReccnt > 0 Then
                ReDim EmbossFldArr(dwReccnt - 1)
                Dim dwi As Integer = 0
                'get all the data setup definition from datasetup.mdb
                myCmd.CommandText = "SELECT * FROM EmbossingDetails where cs_Id=" & dwCardSetupID & " Order by element_seq"
                datareader = myCmd.ExecuteReader()
                If datareader.HasRows Then
                    While datareader.Read()
                        EmbossFldArr(dwi).dwDSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
                        EmbossFldArr(dwi).dwDataFldID = IIf(IsDBNull(datareader("data_fldid")), 0, Val(datareader("data_fldid")))
                        EmbossFldArr(dwi).dwRowOffset = IIf(IsDBNull(datareader("element_row_offset")), 0, Val(datareader("element_row_offset")))
                        EmbossFldArr(dwi).dwColOffset = IIf(IsDBNull(datareader("element_col_offset")), 0, Val(datareader("element_col_offset")))
                        EmbossFldArr(dwi).szModuleID = IIf(IsDBNull(datareader("element_tag")), "", datareader("element_tag"))
                        'EmbossFldArr(dwi).dwFontSize = IIf(IsDBNull(datareader("FontSize")), 0, Val(datareader("FontSize")))
                        '***********************************
                        dwi = dwi + 1
                    End While
                    Return dwReccnt
                Else
                    'MsgBox ("There is no field defined under " & DatafldName & " design!")
                    Return 0
                End If
                datareader.Close()
            Else
                Return 0
            End If

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("modConvFunction.GetEmbossFld[" & dwCardSetupID & "]: Exception-" & ex.Message)
        End Try
    End Function

    Function FormatEmbossData(ByVal szRawText As String, ByVal dwEmbFldCount As Integer) As String
        Dim dwj As Integer
        Dim szData As String = ""
        Dim szEmbData As String = ""
        Dim szTempEmbData As String = ""
        Dim dwRowOffset As Integer = 0
        Dim dwPrevRowOffset As Integer = 0
        Dim dwDataStartPos As Integer
        Dim dwSpaceLength As Integer
        Dim szEmbTag As String = ""

        FormatEmbossData = ""

        Try
            '************************************************
            'Format the Emboss data
            For dwj = 0 To dwEmbFldCount - 1
                szEmbTag = EmbossFldArr(dwj).szModuleID
                szData = GetFieldData(szRawText, "", EmbossFldArr(dwj).dwDSetupID, EmbossFldArr(dwj).dwDataFldID)
                dwRowOffset = EmbossFldArr(dwj).dwRowOffset
                If dwRowOffset = dwPrevRowOffset Then
                    GoTo FmtEmbData
                Else
                    If dwj = 0 Then
                        szEmbData = szEmbTag
                        GoTo FmtEmbData
                    Else
                        szEmbData = szEmbData & szTempEmbData & szEmbTag 'Chr(34)
                        szTempEmbData = ""
                        GoTo FmtEmbData
                    End If
                End If

FmtEmbData:
                dwDataStartPos = EmbossFldArr(dwj).dwColOffset - 1
                If Len(szTempEmbData) < dwDataStartPos Then
                    dwSpaceLength = dwDataStartPos - Len(szTempEmbData)
                    szTempEmbData = szTempEmbData & Space(dwSpaceLength) & szData
                Else
                    szTempEmbData = szTempEmbData & szData
                End If
                dwPrevRowOffset = dwRowOffset
            Next dwj

            FormatEmbossData = szEmbData & szTempEmbData '& Chr(34)
            Exit Function
        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatEmbossData: Exception-" & ex.Message)
            FormatEmbossData = ""
        End Try
    End Function

    Public Function GetEncodeFld(ByVal dwCardSetupID As Integer) As Long
        Try
            Dim myconn As New OleDb.OleDbConnection()
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myCmd.CommandText = "SELECT count(*) FROM EncodeDataDetails where cs_id=" & dwCardSetupID
            Dim dwReccnt As Integer = myCmd.ExecuteScalar()
            If dwReccnt > 0 Then
                ReDim EncodeFldArr(dwReccnt - 1)
                Dim dwi As Integer = 0
                'get all the data setup definition from datasetup.mdb
                myCmd.CommandText = "SELECT * FROM EncodeDataDetails where cs_id=" & dwCardSetupID & " Order by element_seq"
                datareader = myCmd.ExecuteReader()
                If datareader.HasRows Then
                    While datareader.Read()
                        EncodeFldArr(dwi).dwDSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
                        EncodeFldArr(dwi).dwDataFldID = IIf(IsDBNull(datareader("data_fldid")), 0, Val(datareader("data_fldid")))
                        EncodeFldArr(dwi).dwTrackNum = IIf(IsDBNull(datareader("element_track_num")), 0, Val(datareader("element_track_num")))
                        EncodeFldArr(dwi).szSeparator = IIf(IsDBNull(datareader("element_separator")), "", datareader("element_separator"))
                        '***********************************
                        dwi = dwi + 1
                    End While
                    Return dwReccnt
                Else
                    'MsgBox ("There is no field defined under " & DatafldName & " design!")
                    Return 0
                End If
            Else
                Return 0
            End If

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("modConvFunction.GetEncodeFld[" & dwCardSetupID & "]: Exception-" & ex.Message)
        End Try
    End Function

    Public Function FormatEncode(ByVal szRawText As String, ByVal dwCardSetupID As Integer, ByVal dwEncFldCount As Integer) As String
        Dim szEncData As String = "" '= "#ENC#"
        Dim dwj As Integer
        Dim szData As String
        Dim dwTrackNum As Integer
        Dim dwPrevTrackNum As Integer = 0
        Dim szSeparator As String

        FormatEncode = ""

        Dim szSQL As String = "SELECT cs_ENC_id FROM CardSetupSpec where cs_id=" & dwCardSetupID
        szEncData = GetFieldDataSQL(szSQL, "cs_ENC_Id")

        Try
            For dwj = 0 To dwEncFldCount - 1
                szData = GetFieldData(szRawText, "", EncodeFldArr(dwj).dwDSetupID, EncodeFldArr(dwj).dwDataFldID)
                dwTrackNum = EncodeFldArr(dwj).dwTrackNum
                szSeparator = UCase(Trim(EncodeFldArr(dwj).szSeparator))
                'this is where start sentinel is added
                If dwj = 0 Then
                    If dwTrackNum = 1 Then
                        If szSeparator = "1" Then
                            szEncData = szEncData & "%" & szData & "^"
                        Else
                            szEncData = szEncData & "%" & szData
                        End If
                    ElseIf dwTrackNum = 2 Then
                        If szSeparator = "1" Then
                            szEncData = szEncData & ";" & szData & "="
                        Else
                            szEncData = szEncData & ";" & szData
                        End If
                    ElseIf dwTrackNum = 3 Then
                        If szSeparator = "1" Then
                            szEncData = szEncData & "_;" & szData & "="
                        Else
                            szEncData = szEncData & "_;" & szData
                        End If
                    End If
                    dwPrevTrackNum = dwTrackNum
                Else
                    If dwTrackNum = dwPrevTrackNum Then
                        If szSeparator = "1" Then
                            If dwTrackNum = 1 Then
                                szEncData = szEncData & szData & "^"
                            ElseIf dwTrackNum = 2 Then
                                szEncData = szEncData & szData & "="
                            ElseIf dwTrackNum = 3 Then
                                szEncData = szEncData & szData & "="
                            End If
                        Else
                            szEncData = szEncData & szData
                        End If
                    Else
                        If dwTrackNum = 2 Then
                            If szSeparator = "1" Then
                                szEncData = szEncData & "?;" & szData & "="
                            Else
                                szEncData = szEncData & "?;" & szData
                            End If
                        ElseIf dwTrackNum = 3 Then
                            If szSeparator = "1" Then
                                szEncData = szEncData & "?_;" & szData & "="
                            Else
                                szEncData = szEncData & "?_;" & szData
                            End If
                        End If
                    End If
                    dwPrevTrackNum = dwTrackNum
                End If
                'Exit For
            Next dwj
            szEncData = szEncData & "?"
            FormatEncode = szEncData
            Exit Function
        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatEncode: Exception-" & ex.Message)
            Return ""
        End Try
    End Function

    Public Function GetOCRFld(ByVal dwCardSetupID As Integer) As Long
        Try
            Dim myconn As New OleDb.OleDbConnection()
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myCmd.CommandText = "SELECT count(*) FROM IndentationDetails where cs_id=" & dwCardSetupID
            Dim dwReccnt As Integer = myCmd.ExecuteScalar()
            If dwReccnt > 0 Then
                ReDim OCRFldArr(dwReccnt - 1)
                Dim dwi As Integer = 0
                'get all the data setup definition from datasetup.mdb
                myCmd.CommandText = "SELECT * FROM IndentationDetails where cs_id=" & dwCardSetupID & " Order by element_seq"
                datareader = myCmd.ExecuteReader()
                If datareader.HasRows Then
                    While datareader.Read()
                        OCRFldArr(dwi).dwDSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
                        OCRFldArr(dwi).dwDataFldID = IIf(IsDBNull(datareader("data_fldid")), 0, Val(datareader("data_fldid")))
                        OCRFldArr(dwi).dwRowOffset = IIf(IsDBNull(datareader("element_row_offset")), 0, Val(datareader("element_row_offset")))
                        OCRFldArr(dwi).dwColOffset = IIf(IsDBNull(datareader("element_col_offset")), 0, Val(datareader("element_col_offset")))
                        'OCRFldArr(dwi).dwfontsize = IIf(IsDBNull(datareader("FontSize")), 0, Val(datareader("FontSize")))
                        '***********************************
                        dwi = dwi + 1
                    End While
                    Return dwReccnt
                Else
                    'MsgBox ("There is no field defined under " & DatafldName & " design!")
                    Return 0
                End If
            Else
                Return 0
            End If

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("modConvFunction.GetOCRFld[" & dwCardSetupID & "]: Exception-" & ex.Message)
        End Try
    End Function

    Public Function FormatOCR(ByVal szRawText As String, ByVal dwCardSetupID As Integer, ByVal dwOCRFldCount As Integer) As String
        Dim dwj As Integer
        Dim szData As String = ""
        Dim szOCRData As String = "" '"#OCR#"
        Dim szTempOCRData As String = ""
        Dim dwRowOffset As Integer = 0
        Dim dwPrevRowOffset As Integer = 0
        Dim dwDataStartPos As Integer
        Dim dwSpaceLength As Integer

        FormatOCR = ""
        Dim szSQL As String = "SELECT cs_OCR_id FROM CardSetupSpec where cs_id=" & dwCardSetupID
        szOCRData = GetFieldDataSQL(szSQL, "cs_OCR_Id")

        Try
            '************************************************
            'Format the OCR data
            For dwj = 0 To dwOCRFldCount - 1
                szData = GetFieldData(szRawText, "", OCRFldArr(dwj).dwDSetupID, OCRFldArr(dwj).dwDataFldID)
                dwRowOffset = OCRFldArr(dwj).dwRowOffset
                If dwRowOffset = dwPrevRowOffset Then
                    GoTo FmtOCRData
                Else
                    If dwj = 0 Then
                        GoTo FmtOCRData
                    Else
                        szOCRData = szOCRData & szTempOCRData '& Chr(34)
                        szTempOCRData = ""
                        GoTo FmtOCRData
                    End If
                End If

FmtOCRData:
                dwDataStartPos = OCRFldArr(dwj).dwColOffset - 1
                If Len(szTempOCRData) < dwDataStartPos Then
                    dwSpaceLength = dwDataStartPos - Len(szTempOCRData)
                    szTempOCRData = szTempOCRData & Space(dwSpaceLength) & szData
                Else
                    szTempOCRData = szTempOCRData & szData
                End If
                dwPrevRowOffset = dwRowOffset
                'Exit For

            Next dwj
            FormatOCR = szOCRData & szTempOCRData '& Chr(34)
            Exit Function

        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatOCR: Exception-" & ex.Message)
            FormatOCR = ""
        End Try
    End Function

    Public Function GetMailerFld(ByVal dwCardSetupID As Integer) As Long
        Try
            Dim myconn As New OleDb.OleDbConnection()
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myCmd.CommandText = "SELECT count(*) FROM MailerDetails where cs_id=" & dwCardSetupID
            Dim dwReccnt As Integer = myCmd.ExecuteScalar()
            If dwReccnt > 0 Then
                ReDim MailerFldArr(dwReccnt - 1)
                Dim dwi As Integer = 0
                'get all the data setup definition from datasetup.mdb
                myCmd.CommandText = "SELECT * FROM MailerDetails where cs_id=" & dwCardSetupID & " Order by element_seq"
                datareader = myCmd.ExecuteReader()
                If datareader.HasRows Then
                    While datareader.Read()
                        MailerFldArr(dwi).dwDSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
                        MailerFldArr(dwi).dwDataFldID = IIf(IsDBNull(datareader("data_fldid")), 0, Val(datareader("data_fldid")))
                        MailerFldArr(dwi).szMailerFldName = IIf(IsDBNull(datareader("element_field_name")), "", datareader("element_field_name"))
                        '***********************************
                        dwi = dwi + 1
                    End While
                    Return dwReccnt
                Else
                    'MsgBox ("There is no field defined under " & DatafldName & " design!")
                    Return 0
                End If
            Else
                Return 0
            End If

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("modConvFunction.GetMailerFld[" & dwCardSetupID & "]: Exception-" & ex.Message)
        End Try
    End Function

    Public Function FormatMailer(ByVal szRawText As String, ByVal szSuppRawText As String, ByVal dwCardSetupId As Integer, ByVal dwMailerFldCount As Integer) As String
        Dim dwj As Integer
        Dim szData As String = ""
        Dim szMailerData As String = ""
        Dim dwMailerType As Integer

        FormatMailer = ""
        Dim szSQL As String = "SELECT cs_Mailer_id, cs_mailer_type FROM CardSetupSpec where cs_id=" & dwCardSetupId
        szMailerData = GetFieldDataSQL(szSQL, "cs_Mailer_Id")
        dwMailerType = Val(GetFieldDataSQL(szSQL, "cs_mailer_type"))

        Try
            '************************************************
            'Format the Mailer data
            For dwj = 0 To dwMailerFldCount - 1
                szData = GetFieldData(szRawText, szSuppRawText, MailerFldArr(dwj).dwDSetupID, MailerFldArr(dwj).dwDataFldID)
                If dwMailerType = 1 Then
                    szMailerData = szMailerData & MailerFldArr(dwj).szMailerFldName & szData
                Else
                    szMailerData = szMailerData & Chr("&H0A") & szData
                End If
            Next dwj
            FormatMailer = szMailerData
            Exit Function

        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatMailer: Exception-" & ex.Message)
            FormatMailer = ""
        End Try
    End Function

    Public Function GetReportFld(ByVal dwCardSetupID As Integer) As Long
        Try
            Dim myconn As New OleDb.OleDbConnection()
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myCmd.CommandText = "SELECT count(*) FROM ReportDetails where cs_id=" & dwCardSetupID
            Dim dwReccnt As Integer = myCmd.ExecuteScalar()
            If dwReccnt > 0 Then
                ReDim ReportFldArr(dwReccnt - 1)
                Dim dwi As Integer = 0
                'get all the data setup definition from datasetup.mdb
                myCmd.CommandText = "SELECT * FROM ReportDetails where cs_id=" & dwCardSetupID & " Order by report_fldtag"
                datareader = myCmd.ExecuteReader()
                If datareader.HasRows Then
                    While datareader.Read()
                        ReportFldArr(dwi).dwDSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
                        ReportFldArr(dwi).dwDataFldID = IIf(IsDBNull(datareader("data_fldid")), 0, Val(datareader("data_fldid")))
                        ReportFldArr(dwi).szReportFldName = IIf(IsDBNull(datareader("report_fldtag")), "", datareader("report_fldtag"))
                        '***********************************
                        dwi = dwi + 1
                    End While
                    Return dwReccnt
                Else
                    'MsgBox ("There is no field defined under " & DatafldName & " design!")
                    Return 0
                End If
            Else
                Return 0
            End If

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("modConvFunction.GetReportFld[" & dwCardSetupID & "]: Exception-" & ex.Message)
        End Try
    End Function

    Public Function FormatReportFld(ByVal szRawText As String, ByVal szSuppText As String, ByVal dwReportFldCount As Integer, ByVal szEmbfileName As String, ByVal szEmbProdType As String, ByVal szEmbProdTypeDesc As String, ByVal szEmbFileType As String, ByVal szEmbFileDate As String, ByVal dwRecNo As Integer, ByVal szCardNo As String) As Boolean
        Dim dwj As Integer
        Dim szData As String = ""

        FormatReportFld = False
        Dim connProd As New OleDb.OleDbConnection()
        Try
            connProd.ConnectionString = gszConnString
            connProd.Open()

            'add the record into production table
            Dim daReport As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * From Data", connProd)
            Dim dsReport As DataSet = New DataSet()
            Dim cb As New OleDb.OleDbCommandBuilder(daReport)

            daReport.FillSchema(dsReport, SchemaType.Source)
            Dim pTable As New DataTable
            pTable = dsReport.Tables("Table")
            pTable.TableName = "Data"
            'daReport.MissingSchemaAction = MissingSchemaAction.AddWithKey
            'daReport.Fill(dsReport, "Data")

            Dim RowReport As DataRow
            RowReport = dsReport.Tables("Data").NewRow()
            RowReport("data_FileName") = szEmbfileName
            RowReport("data_CardType") = szEmbProdType
            RowReport("data_cardtype_desc") = szEmbProdTypeDesc
            RowReport("data_FileType") = szEmbFileType
            RowReport("data_FileDate") = szEmbFileDate
            RowReport("data_card_id") = szCardNo
            RowReport("data_Rec_No") = dwRecNo
            RowReport("data_DataException") = "False"
            RowReport("data_firstload") = "True"
            '************************************************
            'Format the Report Data
            'szSQL = "INSERT INTO TempReport (EmbFileName, EmbTypeDesc"
            'szSQLValue = " VALUES (" & Chr(34) & szEmbfileName & Chr(34) & ", " & Chr(34) & szEmbProdTypeDesc & Chr(34)
            For dwj = 0 To dwReportFldCount - 1
                szData = GetFieldData(szRawText, szSuppText, ReportFldArr(dwj).dwDSetupID, ReportFldArr(dwj).dwDataFldID)
                RowReport(ReportFldArr(dwj).szReportFldName) = szData
            Next dwj

            dsReport.Tables("Data").Rows.Add(RowReport)
            daReport.Update(dsReport, "Data")

            dsReport = Nothing
            daReport = Nothing

            Return True

            Exit Function

        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatReport: Exception-" & ex.Message)
        Finally
            connProd.Close()
        End Try
    End Function

    Public Function UpdateReportFld(ByVal szRawText As String, ByVal dwReportFldCount As Integer, ByVal szCardNo As String, ByVal szFileDate As String) As Boolean
        Dim dwj As Integer
        Dim szData As String = ""
        Dim szSQLUpdate$
        Dim dwReturnRow As Integer

        UpdateReportFld = False
        Dim connProd As New OleDb.OleDbConnection()
        Try
            connProd.ConnectionString = gszConnString
            connProd.Open()

            For dwj = 0 To dwReportFldCount - 1
                szData = GetFieldData(szRawText, "", ReportFldArr(dwj).dwDSetupID, ReportFldArr(dwj).dwDataFldID)
                szData = Replace(szData, "'", "''")
                szSQLUpdate$ = "UPDATE Data SET " & ReportFldArr(dwj).szReportFldName & "='" & szData & "' Where data_card_id='" & szCardNo & "' and data_filedate='" & szFileDate & "'"
                dwReturnRow = ExecuteSQL(szSQLUpdate)
                Select Case dwReturnRow
                    Case -1
                        'MessageBox.Show("Error occur when saving " & ReportFldArr(dwj).szReportFldName, "UpdateReportFld", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    Case 0
                        'MessageBox.Show("Record not found. No record updated for " & szCardNo, "UpdateReportFld", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    Case 1
                        'successfully save
                        'UpdateAuditLog(szAuditText, "Setup")
                End Select
            Next dwj
            Return True

            Exit Function

        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatReport: Exception-" & ex.Message)
        Finally
            connProd.Close()
        End Try
    End Function

    'Public Function GetSMCFld(ByVal dwCardSetupID As Integer) As Long
    '    Dim myconn As New OleDb.OleDbConnection()
    '    Try
    '        myconn.ConnectionString = gszConnString
    '        myconn.Open()

    '        Dim myCmd As New OleDb.OleDbCommand()
    '        myCmd.Connection = myconn
    '        Dim datareader As OleDb.OleDbDataReader = Nothing

    '        myCmd.CommandText = "SELECT count(*) FROM SMCDetails where cs_id=" & dwCardSetupID
    '        Dim dwReccnt As Integer = myCmd.ExecuteScalar()
    '        If dwReccnt > 0 Then
    '            Dim SMCFldArr(dwReccnt - 1) As SMCFld
    '            Dim dwi As Integer = 0
    '            'get all the data setup definition from datasetup.mdb
    '            myCmd.CommandText = "SELECT * FROM SMCDetails where cs_id=" & dwCardSetupID & " Order by element_seq"
    '            datareader = myCmd.ExecuteReader()
    '            If datareader.HasRows Then
    '                While datareader.Read()
    '                    SMCFldArr(dwi).dwDSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
    '                    SMCFldArr(dwi).dwDataFldID = IIf(IsDBNull(datareader("data_fldid")), 0, Val(datareader("data_fldid")))
    '                    SMCFldArr(dwi).szModuleID = IIf(IsDBNull(datareader("TagName")), "", datareader("TagName"))
    '                    SMCFldArr(dwi).szTagLength = IIf(IsDBNull(datareader("TagLength")), "", datareader("TagLength"))
    '                    SMCFldArr(dwi).szAppName = IIf(IsDBNull(datareader("AppName")), "", datareader("AppName"))
    '                    '***********************************
    '                    dwi = dwi + 1
    '                End While
    '                Return dwReccnt
    '            Else
    '                'MsgBox ("There is no field defined under " & DatafldName & " design!")
    '                Return 0
    '            End If
    '        Else
    '            Return 0
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("modConvFunction.GetSMCFld[" & dwCardSetupID & "]: Exception-" & ex.Message)
    '    Finally
    '        myconn.Close()
    '    End Try
    'End Function

    Public Function FormatSMC(ByVal szRawText As String, ByVal dwCardSetupID As Integer) As String
        Dim myconn As New OleDb.OleDbConnection()
        Dim dwi As Integer
        Dim szTempSMCAppData As String
        Dim szTempSMCData As String = ""
        Dim szSMCData As String = ""

        Dim szAppName(0) As String
        Dim dwDSetupID As Integer
        Dim dwDataFldID As Integer
        Dim szTagName As String
        Dim szTagLength As String
        Dim szData As String
        Dim szModuleID As String
        'Dim dwEmbedSMCLen As Long

        FormatSMC = ""
        Try
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            szTempSMCAppData = ""
            myCmd.CommandText = "SELECT DISTINCT element_appname FROM SMCDetails where cs_id=" & dwCardSetupID
            datareader = myCmd.ExecuteReader()
            dwi = 0
            If datareader.HasRows Then
                While datareader.Read()
                    ReDim Preserve szAppName(dwi)
                    szAppName(dwi) = IIf(IsDBNull(datareader("element_appname")), "", datareader("element_appname"))
                    dwi += 1
                End While
            Else
                Exit Function
            End If
            datareader.Close()

            Dim byteSC(0) As Byte
            Dim szsClen As String
            Dim szHexSClen As String

            For dwi = 1 To szAppName.Length
                'get all the data setup definition from datasetup.mdb
                myCmd.CommandText = "SELECT * FROM SMCDetails where cs_id=" & dwCardSetupID & " and element_appname='" & szAppName(dwi - 1) & "' Order by element_seq"
                datareader = myCmd.ExecuteReader()
                If datareader.HasRows Then
                    szTempSMCData = ""
                    While datareader.Read()
                        dwDSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
                        dwDataFldID = IIf(IsDBNull(datareader("data_fldid")), 0, Val(datareader("data_fldid")))
                        szTagName = IIf(IsDBNull(datareader("element_tagname")), "", datareader("element_tagname"))
                        szTagLength = IIf(IsDBNull(datareader("element_taglen")), "", datareader("element_taglen"))

                        szData = GetFieldData(szRawText, "", dwDSetupID, dwDataFldID)

                        'szTempSMCData = szTempSMCData & HEXtoCHAR(szTagName & szTagLength & szData)
                        szTempSMCData = szTempSMCData & szTagName & szTagLength & szData

                    End While
                End If

                'checking on whole smartcard data length

                szsClen = Hex(szTempSMCData.Length / 2)
                szHexSClen = szsClen.PadLeft(4, "0")
                szTempSMCData = szHexSClen & szTempSMCData

                'Pad the KEK ID to the SC Dat
                szTempSMCData = "000000000000000000000000" & szTempSMCData
                'check length after put in the kek id
                szsClen = Hex(szTempSMCData.Length / 2)
                szHexSClen = szsClen.PadLeft(4, "0")
                szTempSMCData = szHexSClen & szTempSMCData

                'Pad the AppName to SC Data
                szTempSMCData = szAppName(dwi - 1) & szTempSMCData

                szTempSMCAppData = szTempSMCAppData & szTempSMCData
            Next dwi
            'MsgBox(szTempSMCAppData)

            Dim dwEmbedSMCLen As Integer = szTempSMCAppData.Length / 2   'calculate embeded field length for smart card data
            szTempSMCAppData = FormatChartoHex(Strings.Format(dwEmbedSMCLen, "0000000")) & szTempSMCAppData
            'szTempSMCAppData = FormatChartoHex(szSCJobID) & szTempSMCAppData

            Dim szSQL As String = "SELECT cs_SMC_Id FROM CardSetupSpec where cs_id=" & dwCardSetupID
            szModuleID = GetFieldDataSQL(szSQL, "cs_SMC_id")

            szTempSMCAppData = szModuleID & HEXtoCHAR(szTempSMCAppData)

            'Dim writeByte() As Byte = AppendByte(szTempSMCAppData)

            '' Create a file and write the byte data to a file.
            'Dim oFileStream As System.IO.FileStream
            'oFileStream = New System.IO.FileStream("TempSC.dat", System.IO.FileMode.Create)
            'oFileStream.Write(writeByte, 0, writeByte.Length)
            'oFileStream.Close()

            FormatSMC = szTempSMCAppData
        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatSMC[" & dwCardSetupID & "]: Exception-" & ex.Message)
            FormatSMC = ""
        Finally
            myconn.Close()
        End Try

    End Function

    Public Function FormatFileDetails(ByVal szCompositeData As String, ByVal szFileName As String, ByVal dwOutputFileNum As Integer, ByVal szFldChk As String, ByVal boolUpdate As Boolean) As Long
        Dim dwDataLength As Integer
        Dim dwi As Integer
        Dim dwFoundPlusSign As Integer = 0
        Dim szExtChar As String
        Dim szFldChkData As String = ""
        Dim szData As String = ""
        Dim szFldName As String
        Dim szPrintData As String = ""

        Dim Dbconn As New OleDb.OleDbConnection()

        Dim szSQL As String = ""
        Dim dwReturnRow As Integer
        Dim szScanTime As String = DateTime.Now.ToString("hhmmss")
        Dim szScanDate As String = DateTime.Now.ToString("MMddyyyy")

        FormatFileDetails = 0
        Try
            Dbconn.ConnectionString = gszConnString
            Dbconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = Dbconn
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim FldStr() As String = Nothing
            Dim FldCond() As String = Nothing

            If boolUpdate = False Then
                myCmd.CommandText = "SELECT * FROM Data where data_filename='" & szFileName & "' AND data_DataException='False' ORDER By data_rec_no"
            Else
                'Change on 30/6/10 to extract only principle card to ABX file
                myCmd.CommandText = "SELECT * FROM Data where data_filename='" & szFileName & "' AND data_DataException='False' AND Field8='True' ORDER By data_rec_no"
            End If
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    'check if the AWBNO is empty then no output the record
                    szFldChkData = IIf(IsDBNull(datareader(szFldChk)), "", datareader(szFldChk))
                    If szFldChkData = "" Then 'And szDeliveryType = "P" Then
                        GoTo readnextrec
                    End If
                    dwDataLength = Len(szCompositeData)
                    szPrintData = ""
                    'search for the "+" sign
                    For dwi = 1 To dwDataLength
                        dwi = dwFoundPlusSign + 1
                        dwFoundPlusSign = InStr(dwi, szCompositeData, "+", vbTextCompare)
                        If dwFoundPlusSign = 0 Then
                            szExtChar = Mid(szCompositeData, dwi)
                        Else
                            szExtChar = Mid(szCompositeData, dwi, dwFoundPlusSign - dwi)
                        End If

                        If Left(szExtChar, 1) = "[" Then   'get from the data table
                            szExtChar = Mid(szExtChar, 2, szExtChar.Length - 1)
                            FldStr = szExtChar.Split(",")
                            If UBound(FldStr) = 1 Then
                                szFldName = Mid(FldStr(0), 1, FldStr(0).Length - 1) 'Mid(FldStr(0), 2, Len(FldStr(0)) - 2)
                                'If szFldName.ToUpper = "AWBNO" And szDeliveryType = "A" Then
                                ' szData = "ABX"
                                'Else
                                szData = IIf(IsDBNull(datareader(szFldName)), "", datareader(szFldName))
                                'End If
                                If FldStr(1) <> "" Then
                                    szData = szData.PadRight(CInt(FldStr(1)), " ")
                                End If
                            Else
                                MessageBox.Show("Invalid separator (,) specify in details")
                                Return 0
                            End If
                        ElseIf Left(szExtChar, 1) = "<" Then
                            szExtChar = Mid(szExtChar, 2, szExtChar.Length - 2)
                            FldStr = szExtChar.Split(",")
                            If UBound(FldStr) = 1 Then
                                If InStr(FldStr(0), "SPACE", CompareMethod.Text) > 0 Then
                                    szData = Strings.Space(Val(FldStr(1)))
                                ElseIf InStr(FldStr(0), "SYSDATE", CompareMethod.Text) > 0 Then
                                    szData = DateTime.Now.ToString(FldStr(1))
                                    'szData = Microsoft.VisualBasic.Format(dtSystemDate, FldStr(1))
                                ElseIf InStr(FldStr(0), "SYSTIME", CompareMethod.Text) > 0 Then
                                    szData = DateTime.Now.ToString(FldStr(1))
                                    'szData = Microsoft.VisualBasic.Format(dtSystemDate, FldStr(1))
                                ElseIf InStr(FldStr(0), "CRLF", CompareMethod.Text) > 0 Then
                                    szData = vbCrLf
                                End If
                            Else
                                MessageBox.Show("Invalid separator (,) specify in details")
                                Return 0
                            End If
                        Else
                            szData = szExtChar '(constant data)
                        End If
                        szPrintData = szPrintData & szData
                        If dwFoundPlusSign = 0 Then
                            Exit For
                        End If
                    Next dwi
                    Print(dwOutputFileNum, szPrintData)
                    If boolUpdate = True Then
                        szSQL = "EXEC sp_updateawbnumber '" & szFileName & "','" & szFldChkData & "','" & "ABX" & "','" & szScanDate & "','" & szScanTime & "'"
                        dwReturnRow = ExecuteSQL(szSQL)
                    End If
                    FormatFileDetails += 1
ReadNextRec:
                End While
            End If
            datareader.Close()

        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatFileDetails : Exception-" & ex.Message)
            Return 0
        Finally
            Dbconn.Close()
        End Try
    End Function

    Public Function FormatFileHeaderTrailer(ByVal szCompositeData As String, ByVal dwOutputFileNum As Integer, ByVal dwReccNt As Long) As Long
        Dim dwDataLength As Integer
        Dim dwi As Integer
        Dim dwFoundPlusSign As Integer = 0
        Dim szExtChar As String
        Dim szData As String = ""
        Dim szPrintData As String = ""
        Dim FldStr() As String

        FormatFileHeaderTrailer = 0
        Try
            dwDataLength = Len(szCompositeData)
            szPrintData = ""
            'search for the "+" sign
            For dwi = 1 To dwDataLength
                dwi = dwFoundPlusSign + 1
                dwFoundPlusSign = InStr(dwi, szCompositeData, "+", vbTextCompare)
                If dwFoundPlusSign = 0 Then
                    szExtChar = Mid(szCompositeData, dwi)
                Else
                    szExtChar = Mid(szCompositeData, dwi, dwFoundPlusSign - dwi)
                End If

                If Left(szExtChar, 1) = "<" Then
                    szExtChar = Mid(szExtChar, 2, szExtChar.Length - 2)
                    FldStr = szExtChar.Split(",")
                    If UBound(FldStr) = 1 Then
                        If InStr(FldStr(0), "SPACE", CompareMethod.Text) > 0 Then
                            szData = Strings.Space(Val(FldStr(1)))
                        ElseIf InStr(FldStr(0), "SYSDATE", CompareMethod.Text) > 0 Then
                            szData = DateTime.Now.ToString(FldStr(1))
                            'szData = Microsoft.VisualBasic.Format(dtSystemDate, FldStr(1))
                        ElseIf InStr(FldStr(0), "SYSTIME", CompareMethod.Text) > 0 Then
                            szData = DateTime.Now.ToString(FldStr(1))
                        ElseIf InStr(FldStr(0), "RECCNT", CompareMethod.Text) > 0 Then
                            szData = CStr(dwReccNt)
                            szData = szData.PadLeft(FldStr(1), "0")
                            'szData = Microsoft.VisualBasic.Format(dtSystemDate, FldStr(1))
                        ElseIf InStr(FldStr(0), "CRLF", CompareMethod.Text) > 0 Then
                            szData = vbCrLf
                        End If
                    Else
                        MessageBox.Show("Invalid separator (,) specify in details")
                        Return 0
                    End If
                Else
                    szData = szExtChar '(constant data)
                End If
                szPrintData = szPrintData & szData
                If dwFoundPlusSign = 0 Then
                    Exit For
                End If
            Next dwi
            Print(dwOutputFileNum, szPrintData)
            FormatFileHeaderTrailer += 1

        Catch ex As Exception
            MessageBox.Show("modConvFunction.FormatFileHeaderTrailer : Exception-" & ex.Message)
            Return 0
        End Try
    End Function

    Public Function GetBytefromBlob(ByVal filePath As String) As Byte()
        Dim stream As FileStream = New FileStream( _
           filePath, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(stream)

        Dim photo() As Byte = reader.ReadBytes(stream.Length)

        reader.Close()
        stream.Close()

        Return photo
    End Function

    Private Function AppendByte(ByVal szinput As String) As Byte()
        Dim dwByteSize As Integer = szinput.Length / 2 - 1
        Dim byteSC(dwByteSize) As Byte
        For dwi As Integer = 0 To dwByteSize
            byteSC(dwi) = "&H" & szinput.Substring(0, 2)
            szinput = szinput.Substring(2, szinput.Length - 2)
        Next
        Return byteSC
    End Function

    Private Sub AppendByte1(ByRef byteSC() As Byte, ByVal szInput As String)
        Dim dwbyteSize As Integer = byteSC.Length
        'If dwbyteSize = 1 Then dwbyteSize = 0
        Dim dwstringSize As Integer = szInput.Length / 2
        Dim dwNewbyteSize As Integer = dwbyteSize + dwstringSize - 1
        ReDim Preserve byteSC(dwNewbyteSize)
        For dwi As Integer = dwbyteSize To dwNewbyteSize
            byteSC(dwi) = "&H" & szInput.Substring(0, 2)
            szInput = szInput.Substring(2, szInput.Length - 2)
        Next
    End Sub

    Public Function HEXtoCHAR(ByVal sInput As String) As String
        HEXtoCHAR = ""
        Try
            Dim ra(sInput.Length / 2 - 1) As Byte

            For i As Int32 = 0 To sInput.Length - 1 Step 2
                ra(i / 2) = Byte.Parse(sInput.Substring(i, 2), Globalization.NumberStyles.HexNumber)
            Next i

            Dim chars() As Char = System.Text.ASCIIEncoding.Default.GetChars(ra)

            Dim sData As String = New String(chars)
            Return sData
        Catch ex As Exception
            MessageBox.Show("modConvFunction.HEXtoChar: Exception-" & ex.Message)
        End Try
    End Function

    Private Function FormatChartoHex(ByVal sInput As String) As String
        Dim sValue As String
        Dim sHex As String = ""
        Do While sInput.Length > 0

            sValue = Conversion.Hex(Strings.Asc(sInput.Substring(0, 1).ToString()))
            sInput = sInput.Substring(1, sInput.Length - 1)
            sValue = sValue.PadLeft(2, "0")
            sHex = sHex + sValue
        Loop
        Return sHex

    End Function

    Public Function ConvertStrtoChar(ByVal sInput As String) As String
        Dim dwi As Integer
        ConvertStrtoChar = vbNullString
        For dwi = 1 To Len(sInput) Step 2
            ConvertStrtoChar = ConvertStrtoChar & System.Convert.ToChar(("&H" & Mid(sInput, dwi, 2)))
        Next dwi
    End Function

    Public Function ArrayToString(ByVal bytes() As Byte, Optional ByVal format As String = Nothing) As String
        If bytes.Length = 0 Then Return String.Empty
        Dim icnt As Integer = bytes.Length - 1
        Dim sb As New System.Text.StringBuilder(bytes.Length * 4)
        For j As Integer = 0 To icnt
            If bytes(j) = "&H0" Then
                sb.Append(" ")
            Else
                sb.Append(Strings.Chr(bytes(j)))
            End If
            'sb.Append(","c)
        Next
        'sb.Length -= 1
        Return sb.ToString()
    End Function

    Public Sub PrintProductionReport(ByVal szSQL As String, ByVal szPrinterName As String, ByVal szPaperSource As String, ByVal szReportFile As String, ByVal szReportSaveAsFile As String)
        Dim ProdConn As New OleDb.OleDbConnection()
        Try
            'print the crystal report out
            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim szFileName As String = BankInfo.Folder_Report & szReportFile
            'Load the report
            If IsFileExist(szFileName) = False Then
                MessageBox.Show("Report file is missing from the following location: " & szFileName, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            objReport.Load(szFileName)

            ProdConn.ConnectionString = gszConnString

            Dim DA As New OleDb.OleDbDataAdapter(szSQL, ProdConn)
            Dim DS As New DataSet

            DA.Fill(DS, "Data")
            objReport.SetDataSource(DS.Tables("Data"))

            'Collated' in this context has nothing to do with database collation.  
            'Some advanced printers (like copier/printers) will sort each document into its own shelf.  
            'Not every printer supports this functionality, so check the printer dialog before setting to true.  
            'To print the entire report, set startpage and endpage each to 0. 
            'change the printer name at run time
            'objReport.PrintOptions.PrinterName = szPrinterName
            'Dim m_PrinterSettings As New Printing.PrinterSettings
            'm_PrinterSettings.PrinterName = szPrinterName
            'Dim m_PaperSource As System.Drawing.Printing.PaperSource = Nothing
            'Dim m_PrinterSource As Printing.PaperSource
            'For Each m_PrinterSource In m_PrinterSettings.PaperSources
            '    If m_PrinterSource.SourceName.ToString = szPaperSource Then
            '        m_PaperSource = m_PrinterSource
            '        Exit For
            '    End If
            'Next
            'objReport.PrintOptions.CustomPaperSource = m_PaperSource

            objReport.PrintToPrinter(1, False, 0, 0)
            If szReportSaveAsFile <> "" Then
                objReport.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, szReportSaveAsFile)
            End If
            objReport.Close()
            objReport.Dispose()
            DA = Nothing
            DS = Nothing
        Catch ex As Exception
            MessageBox.Show("modConvFunction.PrintProductionReport: Exception-" & ex.Message)
        Finally
            ProdConn.Close()
        End Try
    End Sub

    Public Function CheckPoscode(ByVal szText As String) As String
        Dim myconn As New OleDb.OleDbConnection()
        CheckPoscode = ""
        Try
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim dwStartPoscodeRange As Long
            Dim dwEndPoscodeRange As Long
            Dim szCNCompany As String
            Dim dwi As Long
            myCmd.CommandText = "SELECT * FROM PostcodeList"
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    dwStartPoscodeRange = IIf(IsDBNull(datareader("PostcodeStart")), 0, CLng(datareader("Postcodestart")))
                    dwEndPoscodeRange = IIf(IsDBNull(datareader("PostcodeEnd")), 0, CLng(datareader("PostcodeEnd")))
                    szCNCompany = IIf(IsDBNull(datareader("CourierCoName")), "", datareader("CourierCoName"))
                    '***********************************
                    For dwi = dwStartPoscodeRange To dwEndPoscodeRange
                        If InStr(szText, dwi.ToString, CompareMethod.Text) > 0 Then
                            Return CheckPoscode
                        End If
                    Next dwi
                End While
            Else
                'MsgBox ("There is no field defined under " & DatafldName & " design!")
                Return 0
            End If
            datareader.Close()


        Catch ex As Exception
            MessageBox.Show("modConvFunction.CheckPoscode: Exception-" & ex.Message)
        Finally
            myconn.Close()
        End Try
    End Function

    'Get the last day of the month for any full date
    'Sample calling : GetLastDayOfMonth("January 12 2007").ToShortDateString()
    'Public Function GetLastDayOfMonth(ByVal dtDate As DateTime) As DateTime
    Public Function GetLastDayOfMonth(ByVal szDate As String) As DateTime
        'set return value to the last day of the month for any date passed in to the method create a datetime variable set to the passed in date

        Dim dtTo As DateTime = Convert.ToDateTime("15/" & szDate)

        'overshoot the date by a month

        dtTo = dtTo.AddMonths(1)

        'remove all of the days in the next month to get bumped down to the last day of the previous month

        dtTo = dtTo.AddDays(-(dtTo.Day))

        'return the last day of the month
        Return dtTo

    End Function

    Public Sub UpdateAuditLog(ByVal szActivity As String, ByVal szReportType As String)
        Try
            Dim szUserId As String = UserInfo.LoginId   'Environment.UserName
            Dim dtDateLog As String = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")
            'Dim szDateLog As String = dtDateLog.ToString("G")
            Dim szSQL As String
            Dim dwReturnRow As Integer

            szSQL = "INSERT INTO AuditLog (UserID, RepType, Activity, DateLog) VALUES ('" & _
                    szUserId & "', '" & szReportType & "', '" & szActivity & "', '" & dtDateLog & "')"

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving record.", "UpdateAuditLog", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 1
                    'MessageBox.Show("One Record saved.", "UserMatrix", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            MessageBox.Show("UpdateAuditLog: Exception-" & ex.Message())
        End Try
    End Sub

    Public Function GetSQLSingleData(ByVal SQLStatement As String) As String
        Dim myconn As New OleDb.OleDbConnection()
        Dim szToReturn As String = ""

        myconn.ConnectionString = gszConnString
        myconn.Open()

        Dim myCmd As New OleDb.OleDbCommand()
        myCmd.Connection = myconn
        Dim datareader As OleDb.OleDbDataReader = Nothing

        myCmd.CommandText = SQLStatement
        datareader = myCmd.ExecuteReader()

        If datareader.HasRows Then
            While datareader.Read()
                szToReturn = IIf(IsDBNull(datareader(0)), 0, CStr(datareader(0)))
            End While
        End If

        datareader.Close()

        GetSQLSingleData = szToReturn

    End Function

    Public Function DateToJulian(ByVal vDate As Date) As Integer

        Return CInt(VB6.Format(Year(vDate), "0000") & VB6.Format(DateDiff(Microsoft.VisualBasic.DateInterval.Day, CDate("01/01/" & VB6.Format(Year(vDate), "0000")), vDate) + 1, "000"))

    End Function

End Module
