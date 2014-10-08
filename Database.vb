Imports System.IO
Imports System.Xml
Imports System.Data

Module Database

    'Common use routine ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Public Function ExecuteSQL(ByVal szSQL As String) As Integer
        Try
            If (szSQL = "") Then
                Return -1
                Exit Function
            End If

            Dim dwReturnRow As Integer

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            'myconn.ConnectionTimeout = 0
            myCmd.Connection = myconn
            myCmd.CommandTimeout = 0

            myconn.Open()

            myCmd.CommandText = szSQL
            dwReturnRow = myCmd.ExecuteNonQuery()

            myconn.Close()

            Return dwReturnRow

        Catch ex As Exception
            MessageBox.Show("ExecuteSQL: Exception-" & ex.Message())
            Return -1
        End Try

    End Function

    Public Function GetCountSQL(ByVal szSQL As String) As Integer
        Try
            If (szSQL = "") Then
                Return -1
                Exit Function
            End If

            Dim strSQL As String = szSQL
            Dim dwReturnRow As Integer = 0

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As oledb.oledbDataReader = Nothing
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                dwReturnRow += 1
            End While

            myconn.Close()

            Return dwReturnRow

        Catch ex As Exception
            MessageBox.Show("GetCountSQL: Exception-" & ex.Message())
            Return -1
        End Try

    End Function

    Public Function GetFieldDataSQL(ByVal szSQL As String, ByVal szFieldName As String) As String
        Dim myconn As New OleDb.OleDbConnection()
        GetFieldDataSQL = ""
        Try
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim szFieldData As String = ""

            'get the data field definition
            myCmd.CommandText = szSQL
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    szFieldData = IIf(IsDBNull(datareader(szFieldName)), "", datareader(szFieldName))
                End While
            End If
            datareader.Close()
            Return szFieldData
        Catch ex As Exception
            MessageBox.Show("GetFieldDataSQL: Exception-" & ex.Message)
        Finally
            myconn.Close()
        End Try
    End Function

    Public Function LoadTableCombo(ByRef myComboBox As ComboBox, ByVal szSQL As String) As Boolean
        Try
            If (szSQL = "") Then
                Return False
                Exit Function
            End If

            Dim strSQL As String = szSQL
            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)

            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            myComboBox.Items.Clear()

            Dim szId As String
            Dim szName As String

            While datareader.Read()
                szId = IIf(IsDBNull(datareader(0)), "-1", datareader(0))
                szName = IIf(IsDBNull(datareader(1)), "", datareader(1))

                If (szId <> "-1") Then
                    myComboBox.Items.Add(Left(szName & Space(100), 100) & szId)
                End If
            End While

            myconn.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("LoadTableCombo: Exception-" & ex.Message())
            Return False
        End Try

    End Function

    Public Function GetCurrentId(ByVal szTableName As String, ByVal szFldId As String) As Long
        Try
            If (szTableName = "") Then
                Return False
                Exit Function
            End If

            Dim szSQL As String
            szSQL = "SELECT " & szFldId & " FROM " & szTableName & " ORDER BY " & szFldId & " DESC"

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand(szSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            Dim dwId As Long
            dwId = FAIL_ID

            While datareader.Read()
                dwId = IIf(IsDBNull(datareader(0)), FAIL_ID, datareader(0))
                Exit While
            End While

            myconn.Close()
            Return dwId

        Catch ex As Exception
            MessageBox.Show("GetCurrentId: Exception-" & ex.Message())
            Return FAIL_ID
        End Try

    End Function

    Public Function GetMachineCode(ByVal szMachineName As String) As String
        Try
            If (szMachineName = "") Then
                Return DEFAULT_MACHINE_CODE
                Exit Function
            End If

            Dim szSQL As String
            szSQL = "SELECT machine_code FROM Machine WHERE machine_name='" & szMachineName & "' AND machine_deleted=0"

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand(szSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            Dim szId As String
            szId = DEFAULT_MACHINE_CODE

            While datareader.Read()
                szId = IIf(IsDBNull(datareader(0)), DEFAULT_MACHINE_CODE, datareader(0))
                Exit While
            End While

            myconn.Close()
            Return szId

        Catch ex As Exception
            MessageBox.Show("GetMachineCode: Exception-" & ex.Message())
            Return DEFAULT_MACHINE_CODE
        End Try

    End Function

    Public Sub UpdateJobRunningNumber(ByVal lngJobID As Long, ByVal dwRunningNumber As Integer)
        Dim szSQL As String
        Dim dwReturnRow As Integer

        If (dwRunningNumber = 99) Then
            szSQL = "UPDATE JobSetup SET job_running_number=1 WHERE job_id=" & CStr(lngJobID)
        Else
            szSQL = "UPDATE JobSetup SET job_running_number=" & CStr(dwRunningNumber + 1) & " WHERE job_id=" & CStr(lngJobID)
        End If

        dwReturnRow = ExecuteSQL(szSQL)
    End Sub

    'Used by external routine ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'Retrieve the Report Setup information into the myRepInfo structure
    Public Function GetReportInfo(ByVal lngBankID As Long) As Boolean
        Try
            If (lngBankID <= 0) Or (IsNothing(lngBankID)) Then
                Return False
                Exit Function
            End If

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM ReportSetup WHERE rep_bank_id=" & lngBankID & " AND rep_deleted=0"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            Dim dwIndex As Integer = 1
            Erase arReportInfo

            datareader = myCmd.ExecuteReader()
            While datareader.Read()
                ReDim Preserve arReportInfo(dwIndex)

                arReportInfo(dwIndex).Id = datareader("rep_id")
                arReportInfo(dwIndex).MenuDisplay = IIf(IsDBNull(datareader("rep_menu_disp")), "", datareader("rep_menu_disp"))
                arReportInfo(dwIndex).ReportDescription = IIf(IsDBNull(datareader("rep_desc")), "", datareader("rep_desc"))
                arReportInfo(dwIndex).ReportFileName = IIf(IsDBNull(datareader("rep_filename")), "", datareader("rep_filename"))
                dwIndex += 1
            End While

            If datareader.HasRows() Then
                Return True
            Else
                Return False
            End If

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("GetReportInfo: Exception-" & ex.Message())
            Return False
        End Try

    End Function

    'Retrieve the User information into the myUserInfo structure
    Public Function GetUserInfo(ByVal lngBankId As Long, ByVal szLoginId As String, ByVal szPassword As String, ByRef myUserInfo As Users) As Integer
        Try
            If (szLoginId = "") Or (IsNothing(szLoginId)) Then
                Return LOGIN_FAIL
                Exit Function
            End If

            If (lngBankId = FAIL_ID) Or (IsNothing(lngBankId)) Then
                lngBankId = "0"
            End If

            Dim dwReturn As Integer
            Dim szTempPass As String = ""

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Users WHERE usr_bank_id=" & lngBankId & " AND usr_login_id='" & szLoginId & "' AND usr_deleted=0"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()
                szTempPass = IIf(IsDBNull(datareader("usr_password")), FAIL_ID, datareader("usr_password"))

                myUserInfo.Id = IIf(IsDBNull(datareader("usr_id")), FAIL_ID, datareader("usr_id"))
                myUserInfo.Name = IIf(IsDBNull(datareader("usr_name")), "", datareader("usr_name"))
                myUserInfo.BankId = IIf(IsDBNull(datareader("usr_bank_id")), "", datareader("usr_bank_id"))
                myUserInfo.LoginId = IIf(IsDBNull(datareader("usr_login_id")), FAIL_ID, datareader("usr_login_id"))
                myUserInfo.Barred = IIf(IsDBNull(datareader("usr_barred")), False, datareader("usr_barred"))
                myUserInfo.GroupId = IIf(IsDBNull(datareader("usr_group_id")), FAIL_ID, datareader("usr_group_id"))
                myUserInfo.Revoked = IIf(IsDBNull(datareader("usr_revoked")), False, datareader("usr_revoked"))
                myUserInfo.RetryLeft = IIf(IsDBNull(datareader("usr_retry_left")), 0, datareader("usr_retry_left"))
                myUserInfo.FirstSignIn = IIf(IsDBNull(datareader("usr_first_sign_in")), True, datareader("usr_first_sign_in"))
                myUserInfo.DormantPeriod = IIf(IsDBNull(datareader("usr_dormant_period")), 0, datareader("usr_dormant_period"))
                myUserInfo.ExpiryPeriod = IIf(IsDBNull(datareader("usr_expiry_period")), 0, datareader("usr_expiry_period"))
                myUserInfo.ExpiryDate = IIf(IsDBNull(datareader("usr_expiry_date")), INFINITE_EXPIRY, datareader("usr_expiry_date"))

                myUserInfo.LastLogin = IIf(IsDBNull(datareader("usr_last_login")), Date.Now.ToString("yyyyMMddhhmmss"), datareader("usr_last_login"))

                If (myUserInfo.LastLogin = "") Then
                    myUserInfo.LastLogin = Date.Now.ToString("yyyyMMddhhmmss")
                End If

                Exit While
            End While

            If datareader.HasRows() Then
                Dim szSQL As String
                Dim dwReturnRow As Integer
                Dim dwRetryLeft As Integer

                If (myUserInfo.Revoked = True) And (lngBankId <> "0") Then
                    dwReturn = LOGIN_REVOKED
                    GoTo Done
                End If

                If (myUserInfo.Barred = True) And (lngBankId <> "0") Then
                    dwReturn = LOGIN_BARRED
                Else
                    'Check for user dormant for more than LOGIN_DORMANT_PERIOD days
                    Dim d1 As Date = Date.Today
                    Dim d2 As Date = New Date(CInt(Mid(myUserInfo.LastLogin, 1, 4)), CInt(Mid(myUserInfo.LastLogin, 5, 2)), CInt(Mid(myUserInfo.LastLogin, 7, 2)))

                    Dim t1 As TimeSpan = d1.Subtract(d2)

                    If (t1.Days >= myUserInfo.DormantPeriod) And (myUserInfo.DormantPeriod > 0) And (myUserInfo.GroupId <> 1) And (lngBankId <> "0") Then
                        szSQL = "UPDATE Users SET usr_retry_left=0, usr_revoked=-1 WHERE usr_id=" & myUserInfo.Id
                        dwReturn = LOGIN_DORMANT
                    Else

                        Dim CryptographyFactory As New CryptoFactory
                        Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")
                        Dim szPlain As String = Cryptographer.Decrypt(szTempPass)

                        If (szPlain = szPassword) Then
                            Dim szLastLogin As String
                            szLastLogin = Date.Now.ToString("yyyyMMddhhmmss")

                            'Check for first time login user
                            If (myUserInfo.FirstSignIn = True) Or (szPassword = DEFAULT_PASSWORD) Then
                                szSQL = "UPDATE Users SET usr_last_login='" & szLastLogin & "' WHERE usr_id=" & myUserInfo.Id
                                dwReturn = LOGIN_FIRST_TIME
                            Else
                                'Check for password expiry period
                                If (myUserInfo.ExpiryPeriod = INFINITE_EXPIRY) Then
                                    szSQL = "UPDATE Users SET usr_last_login='" & szLastLogin & "', usr_retry_left=" & CStr(LOGIN_DEFAULT_RETRY) & " WHERE usr_id=" & myUserInfo.Id
                                    dwReturn = LOGIN_OK
                                Else
                                    Dim szExpiry As String
                                    Dim d3 As Date = Date.Today

                                    szExpiry = d3.ToString("yyyyMMdd")
                                    If (szExpiry >= myUserInfo.ExpiryDate) And (myUserInfo.GroupId <> 1) Then
                                        szSQL = "UPDATE Users SET usr_retry_left=0, usr_revoked=-1 WHERE usr_id=" & myUserInfo.Id
                                        dwReturn = LOGIN_EXPIRED
                                    Else
                                        szSQL = "UPDATE Users SET usr_last_login='" & szLastLogin & "', usr_retry_left=" & CStr(LOGIN_DEFAULT_RETRY) & " WHERE usr_id=" & myUserInfo.Id
                                        dwReturn = LOGIN_OK
                                    End If
                                End If
                            End If
                        Else
                            If (myUserInfo.GroupId = 1) Then
                                szSQL = "UPDATE Users SET usr_retry_left=3 WHERE usr_id=" & myUserInfo.Id
                                dwReturn = LOGIN_FAIL
                            Else
                                'Wrong password, check for user revocation policy
                                dwRetryLeft = myUserInfo.RetryLeft - 1

                                If (dwRetryLeft = 0) Then
                                    szSQL = "UPDATE Users SET usr_retry_left=0, usr_revoked=-1 WHERE usr_id=" & myUserInfo.Id
                                    dwReturn = LOGIN_REVOKED
                                Else
                                    szSQL = "UPDATE Users SET usr_retry_left=" & CStr(dwRetryLeft) & " WHERE usr_id=" & myUserInfo.Id
                                    dwReturn = LOGIN_FAIL
                                End If
                            End If
                        End If
                    End If

                    dwReturnRow = ExecuteSQL(szSQL)
                End If
            Else
                dwReturn = LOGIN_FAIL
            End If

Done:
            myconn.Close()
            Return dwReturn

        Catch ex As Exception
            MessageBox.Show("GetUserInfo: Exception-" & ex.Message)
            Return LOGIN_FAIL
        End Try

    End Function

    'validate the user password
    Public Function IsPasswordValid(ByVal dwUserId As Long, ByVal szPassword As String) As Boolean
        Try
            If (dwUserId = FAIL_ID) Or (IsNothing(dwUserId)) Then
                Return False
                Exit Function
            End If

            Dim szTempPass As String = ""
            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Users WHERE usr_id=" & dwUserId & " AND usr_barred = 0 AND usr_deleted=0"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()
                szTempPass = IIf(IsDBNull(datareader("usr_password")), FAIL_ID, datareader("usr_password"))

                Exit While
            End While

            If datareader.HasRows() Then
                Dim CryptographyFactory As New CryptoFactory
                Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")

                Dim szPlain As String = Cryptographer.Decrypt(szTempPass)
                If (szPlain = szPassword) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("IsPasswordValid: Exception-" & ex.Message())
            Return False
        End Try

    End Function

    'save the user password
    Public Function SavePassword(ByVal lngUserId As Long, ByVal szCurrentPass As String, ByVal szNewPass As String) As Boolean
        Try
            If (lngUserId = FAIL_ID) Or (IsNothing(lngUserId)) Then
                Return False
                Exit Function
            End If

            Dim CryptographyFactory As New CryptoFactory
            Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")

            Dim szCipher As String = Cryptographer.Encrypt(szNewPass)
            Dim szOldCipher As String = Cryptographer.Encrypt(szCurrentPass)

            Dim szSQL As String
            Dim dwReturnRow As Integer

            szSQL = "SELECT * FROM PassHistory WHERE usr_id=" & lngUserId & " AND usr_password='" & szCipher & "'"

            dwReturnRow = GetCountSQL(szSQL)
            If (dwReturnRow >= 1) Then
                MessageBox.Show("The new password has been used before. Please enter a password that has not been used.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            'Check for user password expiry date
            Dim szExpiry As String

            If (UserInfo.ExpiryPeriod = 0) Then
                szExpiry = INFINITE_EXPIRY
            Else
                Dim d1 As Date = Date.Today
                Dim d2 As Date = d1.AddDays(UserInfo.ExpiryPeriod)

                szExpiry = d2.ToString("yyyyMMdd")
            End If

            szSQL = "UPDATE Users SET usr_expiry_date='" & szExpiry & "', usr_password='" & szCipher & "' WHERE usr_id=" & lngUserId & " AND usr_barred = 0 AND usr_deleted=0"

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when changing password.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Case 0
                    MessageBox.Show("User record not found. No record deleted.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Case Else
                    Call SavePasswordHistory(lngUserId, szOldCipher)

                    MessageBox.Show("Password has been changed. Please use the new password on next login.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
            End Select


        Catch ex As Exception
            MessageBox.Show("SavePassword: Exception-" & ex.Message())
            Return False
        End Try

    End Function

    Public Function SavePasswordHistory(ByVal lngUserId As Long, ByVal szPassword As String) As Boolean

        Try
            Dim szSQL As String
            Dim dwReturnRow As Integer

            Dim szLastLogin As String
            szLastLogin = Date.Now.ToString("yyyyMMddhhmmss")

            szSQL = "INSERT INTO PassHistory (usr_id, usr_password, usr_date) VALUES (" & lngUserId & ",'" & szPassword & "','" & szLastLogin & "')"

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving password history.", "Password History", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Case 0
                    MessageBox.Show("User record not found. No password history saved.", "assword History", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Case Else
                    Return True
            End Select


        Catch ex As Exception
            MessageBox.Show("SavePasswordHistory: Exception-" & ex.Message())
            Return False
        End Try

    End Function


    'Retrieve the Bank Setup information into the myBankInfo structure
    Public Function GetBankInfo(ByVal lngBankId As Long, ByRef myBankInfo As Bank, ByRef szError As String) As Boolean
        Try
            If (lngBankId < 0) Or (IsNothing(lngBankId)) Then
                Return False
                Exit Function
            End If

            If (lngBankId = 0) Then
                myBankInfo.Id = lngBankId
                myBankInfo.BankName = "Super Administrator"
                myBankInfo.Bin = "Not defined"
                myBankInfo.Algorithm = 0
                myBankInfo.Logo = ""
                myBankInfo.Folder_Root = "Not defined"
                myBankInfo.Folder_Backup = "Not defined"
                myBankInfo.Folder_EncService = "Not defined"
                myBankInfo.Folder_Error = "Not defined"
                myBankInfo.Folder_Input = "Not defined"
                myBankInfo.Folder_DC9K = "Not defined"
                myBankInfo.Folder_Ready = "Not defined"
                myBankInfo.Folder_Report = "Not defined"
                myBankInfo.Output_Encrypted = False

                Return True
                Exit Function
            End If

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Bank WHERE bank_id=" & lngBankId & " AND bank_deleted=0"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows() Then
                While datareader.Read()
                    myBankInfo.Id = lngBankId
                    myBankInfo.BankName = IIf(IsDBNull(datareader("bank_name")), "", datareader("bank_name"))
                    myBankInfo.Bin = IIf(IsDBNull(datareader("bank_bin")), "", datareader("bank_bin"))
                    myBankInfo.Algorithm = IIf(IsDBNull(datareader("bank_algorithm")), 0, datareader("bank_algorithm"))
                    myBankInfo.Logo = IIf(IsDBNull(datareader("bank_logo")), "", datareader("bank_logo"))
                    myBankInfo.Folder_Input = IIf(IsDBNull(datareader("bank_folder_input")), "", datareader("bank_folder_input"))
                    myBankInfo.Folder_Ready = IIf(IsDBNull(datareader("bank_folder_output")), "", datareader("bank_folder_output"))
                    myBankInfo.Folder_Backup = IIf(IsDBNull(datareader("bank_folder_backup")), "", datareader("bank_folder_backup"))
                    myBankInfo.Folder_DC9K = IIf(IsDBNull(datareader("bank_folder_dc9k")), "", datareader("bank_folder_dc9k"))
            
                    myBankInfo.Folder_Root = IIf(IsDBNull(datareader("bank_folder")), "", datareader("bank_folder"))
                    myBankInfo.Folder_EncService = myBankInfo.Folder_Root & "EncryptService\"
                    myBankInfo.Folder_EncBackup = myBankInfo.Folder_Root & "Backup\"
                    myBankInfo.Folder_Error = myBankInfo.Folder_Root & "Error\"

                    myBankInfo.Folder_Report = myBankInfo.Folder_Root & "Report\"   'Added by SY

                    myBankInfo.Output_Encrypted = datareader("bank_encrypted")
                    Exit While

                End While

            
                Return True
            Else
                Return False
            End If
            myconn.Close()

        Catch ex As Exception
            szError = "GetBankInfo: Exception-" & ex.Message
            Return False
        End Try

    End Function

    'Load all the Jobsetup tied to the lnbBankId into arJobInfo table 
    Public Function LoadAllJobInfo(ByVal lngBankId As Long, ByVal job_functype As Integer, ByRef szError As String) As Boolean

        Try
            If (lngBankId <= 0) Or (IsNothing(lngBankId)) Then
                Return False
                Exit Function
            End If

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM JobSetup WHERE job_bank_id=" & lngBankId & " AND job_functype=" & job_functype & " AND job_deleted=0"

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()

            Dim dwIndex As Integer = 1
            Erase arJobInfo

            datareader = myCmd.ExecuteReader()
            While datareader.Read()
                ReDim Preserve arJobInfo(dwIndex)

                arJobInfo(dwIndex).Id = datareader("job_id")
                arJobInfo(dwIndex).FileIDF = IIf(IsDBNull(datareader("job_fileind")), "", datareader("job_fileind"))
                arJobInfo(dwIndex).Description = IIf(IsDBNull(datareader("job_description")), "", datareader("job_description"))
                arJobInfo(dwIndex).FileStartPos = IIf(IsDBNull(datareader("job_fname_start_pos")), 0, datareader("job_fname_start_pos"))
                arJobInfo(dwIndex).FileLength = IIf(IsDBNull(datareader("job_fname_length")), 0, datareader("job_fname_length"))

                arJobInfo(dwIndex).CardSetupID = IIf(IsDBNull(datareader("cs_id")), 0, datareader("cs_id"))
                arJobInfo(dwIndex).FileFormat = IIf(IsDBNull(datareader("job_file_format")), 2, datareader("job_file_format"))
                arJobInfo(dwIndex).OutputFormat = IIf(IsDBNull(datareader("job_output_file_fmt")), 1, datareader("job_output_file_fmt"))
                'arJobInfo(dwIndex).JobProc = IIf(IsDBNull(datareader("job_procid")), 1, datareader("job_procid"))
                dwIndex += 1
            End While

            If datareader.HasRows() Then
                Return True
            Else
                Return False
            End If

            myconn.Close()

        Catch ex As Exception
            szError = "LoadAllJobInfo: Exception-" & ex.Message
            Return False
        End Try

    End Function

    Public Function VerifyAndParseData(ByVal szFile As String, ByRef lbRecNo As Label, ByRef lstErrorFile As ListBox) As Boolean

        Dim dwJobId As Long
        Dim lngFormatSetupId As Long
        Dim dwJobIndex As Integer
        Dim lngJobIdTemp As Long
        Dim szFileName As String
        Dim boolResult As Boolean
        Dim szError As String = ""

        'FunctionType for this module always is 2 - update data)
        If (LoadAllJobInfo(BankInfo.Id, 2, szError) = False) Then
            WriteToErrorLog(szFile, "", "", "VerifyAndParseData", szError)
            Return False
        End If

        szFileName = Path.GetFileName(szFile)

        dwJobIndex = GetJobID(BankInfo.Id, szFileName, lngJobIdTemp)
        If (dwJobIndex <> -1) Then
            dwJobId = lngJobIdTemp 'arJobInfo(dwJobIndex).Id

            'Check input file format
            Select Case arJobInfo(dwJobIndex).FileFormat
                Case FILE_FORMAT.XML
                    'Parse XML file before verify the content of file
                    If (ParseXMLFile(szFile, dwJobIndex, lbRecNo, lstErrorFile) = False) Then
                        Return False
                    End If

                    boolResult = VerifyXMLFile(lngFormatSetupId, dwJobIndex, szFileName, lbRecNo, lstErrorFile)

                Case FILE_FORMAT.FIXEDLENGTH
                    boolResult = VerifyAndParseFixedLenFile(szFile, dwJobId, lbRecNo, lstErrorFile)

                Case FILE_FORMAT.DELIMITED

            End Select

            If (boolResult = False) Then
                Return boolResult
            End If

            Return True
        Else
            lstErrorFile.Items.Add(szFileName & " not defined for Update data function group")
            Return False
        End If

    End Function

    Public Function VerifyAndParseData_Find(ByVal szFile As String, ByRef lngJobId As Long, ByRef lbRecNo As Label, ByRef lstErrorFile As ListBox) As Boolean

        Dim lngFormatSetupId As Long
        Dim dwJobId As Long
        Dim dwJobIndex As Integer
        Dim lngJobIdTemp As Long
        Dim szFileName As String

        szFileName = Path.GetFileName(szFile)

        dwJobIndex = GetJobID(BankInfo.Id, szFileName, lngJobIdTemp)
        If (dwJobIndex <> -1) Then
            dwJobId = arJobInfo(dwJobIndex).Id
            'lngFormatSetupId = arJobInfo(dwJobIndex).FormatSetupId
            lngJobId = lngJobIdTemp

            'Check input file format
            Select Case arJobInfo(dwJobIndex).FileFormat
                Case FILE_FORMAT.XML
                    'Parse XML file before verify the content of file
                    If (ParseXMLFile(szFile, dwJobIndex, lbRecNo, lsterrorfile) = False) Then
                        Return False
                    End If

                    Return VerifyXMLFile(lngFormatSetupId, dwJobIndex, szFileName, lbRecNo, lsterrorfile)

                Case FILE_FORMAT.FIXEDLENGTH
                    Return VerifyAndParseFixedLenFile_Find(szFile, lngFormatSetupId, dwJobIndex, lbRecNo)

                Case FILE_FORMAT.DELIMITED

            End Select

        End If

    End Function

    Public Function GetJobID(ByVal dwBankID As Integer, ByVal szFile As String, ByRef lngJobId As Long) As Integer
        Dim dwIndex As Integer
        Dim dwJobIndex As Integer = -1
        
        For dwIndex = 1 To UBound(arJobInfo)
            If UCase(Mid(szFile, arJobInfo(dwIndex).FileStartPos, arJobInfo(dwIndex).FileLength)) = UCase(arJobInfo(dwIndex).FileIDF) Then
                dwJobIndex = dwIndex
                lngJobId = arJobInfo(dwIndex).Id
            End If
        Next

        Return dwJobIndex

    End Function

    'Used by internal routine ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    'This function will parse the fixed length field value based on startpos & length to db
    Public Function VerifyAndParseFixedLenFile(ByVal szFile As String, ByVal dwJobID As Integer, ByRef lbRecNo As Label, ByRef lstErrorFile As ListBox) As Boolean

        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Dim myCmd As New OleDb.OleDbCommand
        Dim datareader As OleDb.OleDbDataReader = Nothing
        'myconn.ConnectionTimeout = 0
        myCmd.Connection = myconn
        myCmd.CommandTimeout = 0

        Dim dwRecordNo As Long = 1
        Dim szBatchId As String = ""
        Dim szCardId As String
        Dim szSortFldId As String = ""

        Dim dwFileNum As Integer
        Dim szTempString As String = ""

        Dim szFieldName As String = ""
        Dim szFieldValue As String = ""

        Dim szFileDate As String = ""
        Dim szCommand As String = ""

        Dim dwCardSetupID As Integer
        Dim dwDataSetupID As Integer
        Dim dwfdate_startpos As Integer
        Dim dwfdate_length As Integer
        Dim dwRecordSize As Long
        Dim dwHeaderSize As Long
        Dim dwTrailerSize As Long
        Dim szRecordSeparator As String = ""
        Dim dwCardID As Integer
        Dim szFIRRef As String = ""
        Dim szChkFld As String = ""
        Dim szChkFldValue As String = ""
        Dim dwReportInt As Integer

        Dim lngFileLen As Long
        Dim lngRecPosition As Long = 1
        Const lngMaxInputLen As Long = 10000
        Dim lngInputLen As Long
        Dim lngOutPutLen As Long
        Dim lngLeftLen As Long
        Dim szLastTextLine As String = ""
        Dim szTextLine As String = ""
        Dim dwSeparatorPosition As Integer

        Try
            myconn.Open()

            'use the filename as reference for batch id
            szBatchId = Path.GetFileName(szFile)

            myCmd.CommandText = "SELECT JobSetup.cs_id, DatasetupSpec.ds_recordsize, DatasetupSpec.ds_headersize, " & _
                                 "DatasetupSpec.ds_trailersize, DatasetupSpec.ds_recordseparator, CardSetupSpec.ds_id, " & _
                                 "CardSetupSpec.cs_cardid, DatasetupSpec.ds_FIRRef, DataSetupSpec.ds_chkFld, " & _
                                 "DatasetupSpec.ds_chkvalue, JobSetup.job_fdate_Start_pos, JobSetup.job_fdate_length FROM DatasetupSpec " & _
                                 "INNER JOIN (CardSetupSpec INNER JOIN JobSetup ON CardSetupSpec.cs_id = Jobsetup.cs_id) " & _
                                 "ON DatasetupSpec.ds_id = CardSetupSpec.ds_id " & _
                                 "WHERE JobSetup.job_id=" & dwJobID
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    dwCardSetupID = IIf(IsDBNull(datareader("cs_id")), 0, Val(datareader("cs_id")))
                    dwDataSetupID = IIf(IsDBNull(datareader("ds_id")), 0, Val(datareader("ds_id")))
                    dwRecordSize = IIf(IsDBNull(datareader("ds_recordsize")), 0, Val(datareader("ds_recordsize")))
                    dwHeaderSize = IIf(IsDBNull(datareader("ds_headersize")), 0, Val(datareader("ds_headersize")))
                    dwTrailerSize = IIf(IsDBNull(datareader("ds_trailersize")), 0, Val(datareader("ds_trailersize")))
                    szRecordSeparator = IIf(IsDBNull(datareader("ds_recordseparator")), "", datareader("ds_recordseparator"))
                    szRecordSeparator = IIf(Trim(szRecordSeparator) = "", szRecordSeparator, HEXtoCHAR(szRecordSeparator))
                    dwCardID = IIf(IsDBNull(datareader("cs_cardid")), 0, Val(datareader("cs_cardid")))
                    dwfdate_startpos = IIf(IsDBNull(datareader("job_fdate_start_pos")), 0, Val(datareader("job_fdate_start_pos")))
                    dwfdate_length = IIf(IsDBNull(datareader("job_fdate_length")), 0, Val(datareader("job_fdate_length")))
                    szFIRRef = IIf(IsDBNull(datareader("ds_FIRRef")), "", datareader("ds_FIRRef"))
                    szChkFld = IIf(IsDBNull(datareader("ds_chkFld")), "", datareader("ds_chkFld"))
                    szChkFldValue = IIf(IsDBNull(datareader("ds_chkValue")), "", datareader("ds_chkValue"))
                End While
            Else
                'MessageBox.Show(szCardType& " not defined in card type table!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lstErrorFile.Items.Add(szBatchId & " not defined in JobSetup table")
                Return False
            End If
            datareader.Close()

            If dwfdate_startpos > 0 And dwfdate_length > 0 Then
                szFileDate = Mid(szBatchId, dwfdate_startpos, dwfdate_length)
            Else
                lstErrorFile.Items.Add(szBatchId & " filedate definition not defined in JobSetup table")
                Return False
            End If

            dwFileNum = FreeFile()
            'open the input file for processing
            FileOpen(dwFileNum, szBatchId, OpenMode.Binary)

            lngFileLen = FileLen(szBatchId) '- dwHeaderSize
            lngRecPosition = dwHeaderSize + 1

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

            dwReportInt = GetReportFld(dwCardSetupID)

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

                If szFIRRef <> "" Then
                    If Mid(szTextLine, 1, szFIRRef.Length) = szFIRRef Then
                        GoTo NextNewDataRec
                    End If
                End If

                szCardId = GetFieldData(szTextLine, "", dwDataSetupID, dwCardID)
                szCardId = szCardId.Replace(" ", "")

                If szChkFld <> "" Then
                    If CheckConditionFld(szChkFld, szChkFldValue, szTextLine, dwDataSetupID) = False Then
                        GoTo NextNewDataRec
                    End If
                End If

                If UpdateReportFld(szTextLine, dwReportInt, szCardId, szFileDate) = False Then
                    lstErrorFile.Items.Add(szCardId & " not found in " & szBatchId)
                End If

                lbRecNo.Text = "Current Process Record: " & CStr(dwRecordNo) '& " of " & CStr(dwTotalRec)
                lbRecNo.Refresh()
                Application.DoEvents()

NextNewDataRec:
                dwRecordNo += 1
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
            FileClose(dwFileNum)

            Return True


        Catch ex As Exception
            WriteToErrorLog(szBatchId, "", szSortFldId, "ParseFile", "VerifyAndParseFixedLenFile: Exception-" & ex.Message)
            'MessageBox.Show(szCommand)
            MessageBox.Show("VerifyAndParseFixedLenFile: Exception-" & ex.Message)
            Return False
        Finally
            myconn.Close()
        End Try

    End Function

 
    'This function will parse the fixed length field value based on startpos & length to db
    Private Function VerifyAndParseFixedLenFile_Find(ByVal szFile As String, ByVal lngFormatSetupId As Long, ByVal dwJobIndex As Integer, ByRef lbRecNo As Label) As Boolean

        Dim myconn As New oledb.oledbConnection(gszConnString)
        Dim myCmd As New oledb.oledbCommand
        myCmd.Connection = myconn
        'myconn.ConnectionTimeout = 0
        myCmd.CommandTimeout = 0

        Dim dwReturnRow As Long
        Dim dwRecordNo As Long

        Dim szName As String
        Dim szValue As String

        Dim szBatchId As String = ""
        Dim szCardId As String
        Dim szSortFldId As String

        'Dim dwCardIDStartPos As Integer
        'Dim dwCardIDLen As Integer

        Dim szQuery As String
        Dim dwi As Integer

        'Dim lngRecLen As Long
        Dim lngFileLen As Long
        Dim szError As String = ""
        Dim dwFileNum As Integer
        Dim szTempString As String
        Dim lngPosition As Long
        Dim boolFldEmpty As Boolean

        Dim szFieldName As String = ""
        Dim szFieldValue As String = ""

        Dim szDStatus As String = ""
        Dim szAcceptCode As String = ""
        Dim szDLLerror As String = ""
        Dim szSearchCode As String = ""

        Try
            myconn.Open()
            myCmd.CommandText = "TRUNCATE TABLE Data"    '"DELETE FROM Data"
            myCmd.ExecuteNonQuery()

            'use the filename as reference for batch id
            szBatchId = Path.GetFileName(szFile)

            'Get all format field for the particular jobid
            szQuery = "SELECT * FROM Format WHERE fs_id=" & lngFormatSetupId

            If (GetFormatInfo(szQuery, szBatchId) = True) Then

                'lngRecLen = arJobInfo(dwJobIndex).Record_Length
                lngFileLen = FileLen(szFile)

                'Check file length, it should be able multiple of Record Length
                dwFileNum = FreeFile()

                'Get the cardid startpos and length first
                For dwi = 1 To UBound(arFormatInfo)
                    'If (arFormatInfo(dwi).Name = arJobInfo(dwJobIndex).XML_Node_Card) Then
                    '    dwCardIDStartPos = arFormatInfo(dwi).TextStartPos
                    '    dwCardIDLen = arFormatInfo(dwi).TextLength
                    '    Exit For
                    'End If
                Next dwi

                ''open the input file for processing
                FileOpen(dwFileNum, szFile, OpenMode.Input)

                lngPosition = 1
                dwRecordNo = 1

                'set the next record position
                'If (arJobInfo(dwJobIndex).HasBatchHeader = True) Then
                '    szTempString = LineInput(dwFileNum)
                '    Seek(dwFileNum)
                'End If

                Do While Not EOF(dwFileNum)
                    lbRecNo.Text = "Current Record: " & CStr(dwRecordNo)
                    lbRecNo.Refresh()
                    Application.DoEvents()

                    ''set the next record position
                    szTempString = LineInput(dwFileNum)

                    If (Trim(szTempString) = "") Then
                        GoTo next_record
                    End If

                    'check for valid data for processing
                    For dwi = 1 To UBound(arFormatInfo)
                        szName = arFormatInfo(dwi).Name
                        szValue = Trim(Mid(szTempString, arFormatInfo(dwi).TextStartPos, arFormatInfo(dwi).TextLength))

                        If (UCase(szName) = "D_STATUS") Then
                            szDStatus = UCase(Trim(szValue))
                        End If

                        If (UCase(szName) = "ACCEPTCODE") Then
                            szAcceptCode = Trim(szValue)
                        End If

                        If (UCase(szName) = "DLLERROR") Then
                            szDLLerror = Trim(szValue)
                        End If

                        If (UCase(szName) = "SEARCHCODE") Then
                            szSearchCode = UCase(Trim(szValue))
                        End If
                    Next dwi

                    szCardId = Right("00000" & CStr(dwRecordNo), 5)     'Mid(szTempString, dwCardIDStartPos, dwCardIDLen)
                    szSortFldId = Right("00000" & CStr(dwRecordNo), 5)

                    If (Trim(szCardId) = "") Then
                        szError = "Card Id is empty."
                        WriteToErrorLog(szBatchId, "", "", "VerifyFile", szError)
                    Else
                        'extract each record from file based on format field startpos & length
                        'chk the record if verification needed, and update to data table
                        For dwi = 1 To UBound(arFormatInfo)
                            boolFldEmpty = False
                            szName = arFormatInfo(dwi).Name
                            szValue = Mid(szTempString, arFormatInfo(dwi).TextStartPos, arFormatInfo(dwi).TextLength)

                            If (arFormatInfo(dwi).VerificationFlag = True) Then
                                If Trim(szValue) = "" Then
                                    boolFldEmpty = True
                                    szError = "[" & szName & "] has empty value."
                                End If
                            End If

                            If (boolFldEmpty = True) Then
                                WriteToErrorLog(szBatchId, "", szCardId, "VerifyFile", szError)
                            Else
                                'Replace machine_id with the machine_code from Machine Table
                                If (UCase(szName) = "MACHINEID") Then
                                    szValue = GetMachineCode(Trim(szValue))
                                End If

                                'Save the found entry into DATA table if name and value is not empty
                                If InStr(szValue, "'") > 0 Then
                                    szValue = Replace(szValue, "'", "''")
                                End If

                                myCmd.CommandText = "INSERT INTO Data (data_batch_id, data_card_id, data_element_name, data_element_value, data_sort_field) VALUES ('" & szBatchId & "','" & szCardId & "','" & szName & "','" & szValue & "','" & szSortFldId & "')"
                                dwReturnRow = myCmd.ExecuteNonQuery()

                            End If
                        Next dwi

                        dwRecordNo += 1

                    End If

next_record:
                    Seek(dwFileNum)
                    'lngPosition += lngRecLen
                Loop

                FileClose(dwFileNum)
            End If

            Return True


        Catch ex As Exception
            WriteToErrorLog(szBatchId, "", "", "ParseFile", "VerifyAndParseFixedLenFile_Find: Exception-" & ex.Message)

            Return False
        Finally
            myconn.Close()
        End Try

    End Function

    'This function will parse the xml value based on tag to db
    Private Function ParseXMLFile(ByVal szFile As String, ByVal dwJobIndex As Integer, ByRef lbRecNo As Label, ByRef lstErrorFile As ListBox) As Boolean

        'Dim dwReturnRow As Integer
        'Dim myconn As New oledb.oledbConnection(gszConnString)
        'Dim myCmd As New oledb.oledbCommand
        'myCmd.Connection = myconn
        ''myconn.ConnectionTimeout = 0
        'myCmd.CommandTimeout = 0

        'Dim m_xmld As XmlDocument
        'Dim m_node As XmlNode
        'Dim m_XmlNodeReader As XmlNodeReader

        'Dim szName As String
        'Dim szValue As String
        'Dim dwTotal As Long = 0

        'Dim szBatchId As String = ""
        'Dim szCardId As String = ""
        'Dim szCardIdOld As String = ""
        'Dim szFileName As String = ""

        'Try
        '    szFileName = Path.GetFileName(szFile)

        '    myconn.Open()

        '    myCmd.CommandText = "TRUNCATE TABLE Data"
        '    myCmd.ExecuteNonQuery()

        '    'Create the XML Document
        '    m_xmld = New XmlDocument

        '    'Load the Xml file
        '    m_xmld.Load(szFile)

        '    'Find BATCH_ID first
        '    ' m_node = m_xmld.SelectSingleNode(arJobInfo(dwJobIndex).XML_Node_Root)
        '    m_XmlNodeReader = New XmlNodeReader(m_node)

        '    'check for batch header the flag is on
        '    'If (arJobInfo(dwJobIndex).HasBatchHeader = True) Then
        '    '    Do While (m_XmlNodeReader.Read())
        '    '        m_XmlNodeReader.MoveToAttribute(arJobInfo(dwJobIndex).XML_Node_Batch)
        '    '        szValue = m_XmlNodeReader.Value
        '    '        szName = m_XmlNodeReader.LocalName

        '    '        If (szName = arJobInfo(dwJobIndex).XML_Node_Batch) Then
        '    '            szBatchId = szValue

        '    '            If (szBatchId <> "") Then
        '    '                'myCmd.CommandText = "INSERT INTO Data (data_batch_id, data_card_id, data_element_name, data_element_value, data_element_value_1) VALUES ('" & szBatchId & "','" & szCardId & "','" & szName & "','" & Left(szValue, 8000) & "','" & Mid(szValue, 8001) & "')"

        '    '                myCmd.CommandText = "INSERT INTO Data (data_batch_id, data_card_id, data_element_name, data_element_value) VALUES ('" & szBatchId & "','" & szCardId & "','" & szName & "','" & szValue & "')"
        '    '                dwReturnRow = myCmd.ExecuteNonQuery()
        '    '            End If

        '    '            Exit Do
        '    '        End If
        '    '    Loop
        '    'End If

        '    m_XmlNodeReader = Nothing


        '    'Get the sort field if there is any
        '    'Dim szSortField As String
        '    Dim dwIndex As Integer

        '    Dim szFieldName As String = ""
        '    Dim szFieldValue As String = ""

        '    'Find record nodes
        '    ' m_node = m_xmld.SelectSingleNode(arJobInfo(dwJobIndex).XML_Node_Root)
        '    m_XmlNodeReader = New XmlNodeReader(m_node)

        '    dwIndex = 1

        '    Do While (m_XmlNodeReader.Read())
        '        'empty the string
        '        szName = ""
        '        szValue = ""

        '        'Read attributes if exists
        '        If (m_XmlNodeReader.HasAttributes) Then

        '            m_XmlNodeReader.MoveToFirstAttribute()
        '            szValue = m_XmlNodeReader.Value
        '            szName = m_XmlNodeReader.LocalName

        '            'If found CARD_ID, record the information into szCardId variable
        '            If (szName = arJobInfo(dwJobIndex).XML_Node_Card) Then
        '                szCardId = szValue

        '                If (szCardIdOld <> "") Then
        '                    dwTotal += 1
        '                    lbRecNo.Text = "Current Record: " & CStr(dwTotal)
        '                    lbRecNo.Refresh()
        '                    Application.DoEvents()

        '                    'use for tempreport insertion
        '                    If (szCardIdOld <> szCardId) Then
        '                        dwIndex = 1

        '                        If (szCardIdOld <> "") Then
        '                            szFieldName = szFieldName & ")"
        '                            szFieldValue = szFieldValue & ")"
        '                            myCmd.CommandText = szFieldName & szFieldValue
        '                            dwReturnRow = myCmd.ExecuteNonQuery()
        '                        End If
        '                    End If
        '                End If

        '                szCardIdOld = szCardId
        '            End If

        '            While m_XmlNodeReader.MoveToNextAttribute()
        '                szValue = m_XmlNodeReader.Value
        '                szName = m_XmlNodeReader.LocalName

        '                'If found CARD_ID, record the information into szCardId variable
        '                If (szName = arJobInfo(dwJobIndex).XML_Node_Card) Then
        '                    szCardId = szValue

        '                    If (szCardIdOld <> "") Then
        '                        'use for tempreport insertion
        '                        If (szCardIdOld <> szCardId) Then
        '                            dwIndex = 1

        '                            If (szCardIdOld <> "") Then
        '                                szFieldName = szFieldName & ")"
        '                                szFieldValue = szFieldValue & ")"
        '                                myCmd.CommandText = szFieldName & szFieldValue
        '                                dwReturnRow = myCmd.ExecuteNonQuery()
        '                            End If
        '                        End If
        '                    End If

        '                    szCardIdOld = szCardId
        '                End If

        '            End While

        '        Else
        '            'Read nodes if exists
        '            Select Case m_XmlNodeReader.NodeType
        '                Case XmlNodeType.Element
        '                    szName = m_XmlNodeReader.LocalName
        '                    szValue = m_XmlNodeReader.ReadString
        '                    szName = m_XmlNodeReader.LocalName

        '                Case XmlNodeType.Text
        '                    szName = m_XmlNodeReader.LocalName
        '                    szValue = m_XmlNodeReader.ReadString
        '                    szName = m_XmlNodeReader.LocalName

        '            End Select

        '        End If

        '        'Save the found entry into DATA table if name and value is not empty
        '        If (szName <> "") And (szValue <> "") Then
        '            myCmd.CommandText = "INSERT INTO Data (data_batch_id, data_card_id, data_element_name, data_element_value) VALUES ('" & szBatchId & "','" & szCardId & "','" & szName & "','" & szValue & "')"
        '            dwReturnRow = myCmd.ExecuteNonQuery()

        '            If (szCardId <> "") Then
        '                If (dwIndex = 1) Then
        '                    szFieldName = "INSERT INTO TempReport (FileName, Field1"
        '                    szFieldValue = " VALUES ('" & szFileName & "', '" & Left(szValue, 5000) & "'"
        '                Else
        '                    szFieldName = szFieldName & ", Field" & dwIndex
        '                    szFieldValue = szFieldValue & ", '" & Left(szValue, 5000) & "'"
        '                End If

        '                dwIndex += 1
        '            End If
        '        End If
        '    Loop

        '    'Update last record informations
        '    If (szCardId <> "") Then
        '        dwTotal += 1
        '        lbRecNo.Text = "Current Record: " & CStr(dwTotal)
        '        lbRecNo.Refresh()
        '        Application.DoEvents()

        '        'update tempreport table
        '        szFieldName = szFieldName & ")"
        '        szFieldValue = szFieldValue & ")"
        '        myCmd.CommandText = szFieldName & szFieldValue
        '        dwReturnRow = myCmd.ExecuteNonQuery()
        '    End If

        '    'Update data_sort_field
        '    Dim myconn_1 As New OleDb.OleDbConnection("Provider=sqloledb;Data Source=localhost;Initial Catalog=XMLc;User Id=" & DSN_USER & ";Password=" & DSN_PASSWORD & ";")
        '    Dim myCmd_1 As New OleDb.OleDbCommand
        '    myCmd_1.Connection = myconn_1
        '    myconn_1.Open()

        '    myCmd_1.CommandText = "EXEC sp_updatesortfield '" & szBatchId & "'," & CStr(arJobInfo(dwJobIndex).Id)
        '    dwReturnRow = myCmd_1.ExecuteNonQuery
        '    myconn_1.Close()

        '    Return True

        'Catch ex As Exception
        '    WriteToErrorLog(szFileName, "", "", "ParseXML", "ParseXMLFile: Exception-" & ex.Message)
        '    Return False
        'Finally
        '    myconn.Close()
        'End Try

    End Function

    'Verify the XML data to have appropriate valid data defined in Format table
    Private Function VerifyXMLFile(ByVal lngFormatSetupId As Long, ByVal dwJobIndex As Integer, ByVal szFile As String, ByRef lbRecNo As Label, ByRef lstErrorFile As ListBox) As Boolean

        Dim szFileName As String
        szFileName = Path.GetFileName(szFile)

        Try
            If (lngFormatSetupId <= 0) Or (IsNothing(lngFormatSetupId)) Then
                Return False
                Exit Function
            End If

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmdQuery As New OleDb.OleDbCommand
            Dim myCmd As New OleDb.OleDbCommand
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0
            myCmdQuery.CommandTimeout = 0

            Dim datareader As OleDb.OleDbDataReader = Nothing

            Dim szQuery As String
            Dim dwi As Integer
            Dim dwReturnRow As Integer

            Dim dwj As Integer
            Dim dwIndex As Integer = 1
            Dim boolFldEmpty As Boolean
            Dim szError As String = ""

            myconn.Open()
            myCmdQuery.Connection = myconn
            myCmd.Connection = myconn

            'chk the batch details if there is any
            'If (arJobInfo(dwJobIndex).HasBatchHeader = True) Then

            '    'Get the format field that with batchheader and need verification
            '    szQuery = "SELECT * FROM Format WHERE fs_id=" & lngFormatSetupId & " AND fmt_batch_header=1 AND fmt_verification_flag=1"

            '    If (GetFormatInfo(szQuery, szFileName) = True) Then

            '        For dwi = 1 To UBound(arFormatInfo)
            '            'Retrieve Batch details from data table
            '            boolFldEmpty = True

            '            myCmdQuery.CommandText = "SELECT * FROM Data WHERE data_element_name='" & arFormatInfo(dwi).XML_Node & "'"
            '            datareader = myCmdQuery.ExecuteReader()

            '            If datareader.HasRows() Then
            '                'Node found, need to check for empty data
            '                If (IsDBNull(datareader("data_element_value")) = True) Then
            '                    szError = "[" & arFormatInfo(dwi).XML_Node & "] has empty value."
            '                Else
            '                    boolFldEmpty = False
            '                End If

            '            Else
            '                'Fail to find node
            '                szError = "Missing this element- [" & arFormatInfo(dwi).XML_Node & "]"
            '            End If

            '            datareader.Close()

            '            If (boolFldEmpty = True) Then
            '                'Log error to ErrorLog Table
            '                WriteToErrorLog(szFileName, "", "", "VerifyXML", szError)
            '                Return False

            '                Exit Try
            '            End If

            '        Next dwi

            '    End If
            'End If

            'Proceed to check the child node details
            szQuery = "SELECT * FROM Format WHERE fs_id=" & lngFormatSetupId & " AND fmt_batch_header=0 AND fmt_verification_flag=1"

            If (GetFormatInfo(szQuery, szFileName) = True) Then

                'get distinct batchid and cardid from db
                myCmdQuery.CommandText = "SELECT DISTINCT data_batch_id, data_card_id from Data Where data_card_id <> ''"
                datareader = myCmdQuery.ExecuteReader()

                Erase arRecord
                ReDim Preserve arRecord(0)
                dwIndex = 1

                While datareader.Read()
                    ReDim Preserve arRecord(dwIndex)

                    arRecord(dwIndex).BatchId = datareader("data_batch_id")
                    arRecord(dwIndex).CardId = datareader("data_card_id")

                    dwIndex += 1
                End While

                datareader.Close()

                For dwi = 1 To UBound(arFormatInfo)

                    For dwj = 1 To UBound(arRecord)
                        lbRecNo.Text = "Current Format:" & CStr(dwi) & "  Current Record: " & CStr(dwj)
                        lbRecNo.Refresh()
                        Application.DoEvents()

                        'get the batch details from data table
                        myCmdQuery.CommandText = "SELECT * FROM Data WHERE data_batch_id='" & arRecord(dwj).BatchId & "' AND data_card_id='" & arRecord(dwj).CardId & "' AND data_element_name='" & arFormatInfo(dwi).XML_Node & "'"
                        datareader = myCmdQuery.ExecuteReader()

                        boolFldEmpty = True

                        If datareader.HasRows() Then
                            'Node found, need to check for empty data
                            If (Not IsDBNull(datareader("data_element_value"))) Then
                                boolFldEmpty = False
                            Else
                                szError = "[" & arFormatInfo(dwi).XML_Node & "] has empty value."
                            End If

                        Else
                            'Fail to find node
                            szError = "Missing this element- [" & arFormatInfo(dwi).XML_Node & "]"
                        End If

                        datareader.Close()

                        If (boolFldEmpty = True) Then
                            myCmd.CommandText = "DELETE * FROM Data WHERE data_batch_id='" & arRecord(dwj).BatchId & "' And data_card_id='" & arRecord(dwj).CardId & "'"
                            dwReturnRow = myCmd.ExecuteNonQuery()

                            'output to error table
                            WriteToErrorLog(szFileName, arRecord(dwj).BatchId, arRecord(dwj).CardId, "VerifyXML", szError)
                        End If

                    Next dwj

                Next dwi

            End If

            myconn.Close()

            Return True

        Catch ex As Exception
            WriteToErrorLog(szFileName, "", "", "VerifyXML", "VerifyXMLFile:Exception-" & ex.Message)
            Return False
        End Try

    End Function

    'Load all the Format into arFormatInfo table 
    Private Function GetFormatInfo(ByVal szSQL As String, ByVal szFile As String) As Boolean

        Try
            If (szSQL = "") Then
                Return False
                Exit Function
            End If

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmdQuery As New oledb.oledbCommand
            Dim myCmd As New oledb.oledbCommand(szSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0
            myCmdQuery.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            Dim dwIndex As Integer = 1
            Erase arFormatInfo

            While datareader.Read()
                ReDim Preserve arFormatInfo(dwIndex)

                arFormatInfo(dwIndex).Sequence = IIf(IsDBNull(datareader("fmt_field_seq")), -1, datareader("fmt_field_seq"))
                arFormatInfo(dwIndex).Name = IIf(IsDBNull(datareader("fmt_field_name")), "", datareader("fmt_field_name"))
                arFormatInfo(dwIndex).Description = IIf(IsDBNull(datareader("fmt_field_desc")), "", datareader("fmt_field_desc"))
                arFormatInfo(dwIndex).TypeOfValue = IIf(IsDBNull(datareader("fmt_field_valtype")), -1, datareader("fmt_field_valtype"))
                arFormatInfo(dwIndex).IsBatchHeader = IIf(IsDBNull(datareader("fmt_batch_header")), True, datareader("fmt_batch_header"))
                arFormatInfo(dwIndex).XML_Node = IIf(IsDBNull(datareader("fmt_xml_node")), "", datareader("fmt_xml_node"))
                arFormatInfo(dwIndex).TextStartPos = IIf(IsDBNull(datareader("fmt_start_pos")), -1, datareader("fmt_start_pos"))
                arFormatInfo(dwIndex).TextLength = IIf(IsDBNull(datareader("fmt_length")), 0, datareader("fmt_length"))
                arFormatInfo(dwIndex).RowDelimiter = IIf(IsDBNull(datareader("fmt_row_delimiter")), "", datareader("fmt_row_delimiter"))
                arFormatInfo(dwIndex).ColDelimiter = IIf(IsDBNull(datareader("fmt_col_delimiter")), "", datareader("fmt_col_delimiter"))
                arFormatInfo(dwIndex).VerificationFlag = IIf(IsDBNull(datareader("fmt_verification_flag")), False, datareader("fmt_verification_flag"))

                dwIndex += 1
            End While

            If datareader.HasRows() Then
                Return True
            Else
                Return False
            End If

            myconn.Close()

        Catch ex As Exception
            WriteToErrorLog(szFile, "", "", "VerifyFile", "GetFormatInfo:Exception-" & ex.Message)
            Return False
        End Try

    End Function

    'Create a template of element list based on Job Setup Id. This template is still in raw format (with all <TAG>).
    Public Function FormatData(ByVal szFinalFileName As String, ByVal szBatchId As String, ByVal lngJobIndex As Long, ByVal lngJobId As Long, ByRef lbRecNo As Label) As Boolean
        Dim szError As String = ""
        Dim szFileName As String = Path.GetFileName(szFinalFileName)

        Try
            'Retrieve job element list from several tables and consolidate into arElement array
            If (GetJobElementList(lngJobId, arElement, szError) = False) Then
                WriteToErrorLog(szFileName, "", "", "FormatData", "GetJobElementList=" & szError)
                Return False
            End If
            'End retrieve

            Dim szCardId As String
            Dim dwRecordNo As Long
            Dim dwTotalItem As Long
            Dim dwCount As Long
            Dim szLine As String
            Dim lngDataGroup As Long
            Dim lngDataSetup As Long
            Dim lngFileType As Long

            'lngDataGroup = arJobInfo(lngJobIndex).GroupSetupId
            'lngDataSetup = arJobInfo(lngJobIndex).DataSetupId
            'lngFileType = arJobInfo(lngJobIndex).FileType

            'Read Head and Tail string
            Dim szHeader As String = ""
            Dim szFooter As String = ""

            Dim myconn0 As New oledb.oledbConnection(gszConnString)
            Dim strSQL0 As String = "SELECT ds_head, ds_tail FROM DataSetup WHERE ds_id=" & lngDataSetup & " AND ds_deleted=0"

            Dim myCmd0 As New oledb.oledbCommand(strSQL0, myconn0)
            Dim datareader0 As oledb.oledbDataReader = Nothing

            'myconn0.ConnectionTimeout = 0
            myCmd0.CommandTimeout = 0

            myconn0.Open()
            datareader0 = myCmd0.ExecuteReader()

            If datareader0.Read() Then
                szHeader = IIf(IsDBNull(datareader0("ds_head")), "", datareader0("ds_head"))
                szFooter = IIf(IsDBNull(datareader0("ds_tail")), "", datareader0("ds_tail"))

                szHeader = Replace(szHeader, "<CRLF>", vbCrLf, 1, -1, CompareMethod.Text)
                szFooter = Replace(szFooter, "<CRLF>", vbCrLf, 1, -1, CompareMethod.Text)
            End If
            myconn0.Close()
            'End Read Head and Tail string


            Dim dwFileNum As Integer = FreeFile()
            If (szHeader <> "") Then
                FileOpen(dwFileNum, szFinalFileName, OpenMode.Output)
                Print(dwFileNum, szHeader)
            Else
                FileOpen(dwFileNum, szFinalFileName, OpenMode.Append)
            End If

            'Process all the records in DATA table
            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT DISTINCT(data_sort_field), data_group, data_card_id, data_batch_id FROM Data WHERE data_batch_id='" & szBatchId & "' AND data_group=" & lngDataGroup & " ORDER BY data_sort_field ASC"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            dwRecordNo = 1

            While datareader.Read()
                szCardId = IIf(IsDBNull(datareader("data_card_id")), "", datareader("data_card_id"))
                'szBatchId = IIf(IsDBNull(datareader("data_batch_id")), "", datareader("data_batch_id"))

                If (szCardId <> "") And (szBatchId <> "") Then
                    If (GetJobElementValue(szBatchId, szCardId, dwRecordNo, arElement, arElementItem, szError) = False) Then
                        WriteToErrorLog(szFileName, "", "", "FormatData", szError)
                        'handle error here
                    Else
                        lbRecNo.Text = "Current Record: " & CStr(dwRecordNo)
                        lbRecNo.Refresh()
                        Application.DoEvents()

                        'replace embedded length tag with data
                        szLine = ""
                        dwTotalItem = UBound(arElementItem)
                        For dwCount = 1 To dwTotalItem
                            szLine += arElementItem(dwCount).Tag + arElementItem(dwCount).Value
                        Next

                        Dim dwIndex1 As Integer
                        Dim dwIndex2 As Integer
                        Dim dwIndex3 As Integer
                        Dim dwIndex4 As Integer
                        Dim dwIndex5 As Integer
                        Dim dwIndex6 As Integer

                        Dim szData1 As String
                        Dim szData2 As String
                        Dim szData3 As String

                        Dim dwEmbLen As Integer
                        Dim dwLoop As Integer


                        For dwLoop = MAX_EMBLEN To 1 Step -1
                            'Handle DATA_OP_BEGIN_EMBLEN    (INPUT_1: INDEX, INPUT_2: APPENDING_CHR, INPUT_3: COUNT)
                            dwIndex1 = InStr(1, szLine, DATA_OP_BEGIN_EMBLEN + DATA_OP_OPEN_BRACKET + CStr(dwLoop), CompareMethod.Text)
                            If (dwIndex1 > 0) Then
                                dwIndex2 = InStr(dwIndex1, szLine, DATA_OP_OPEN_BRACKET, CompareMethod.Text)

                                If (dwIndex2 > 0) Then
                                    dwIndex3 = InStr(dwIndex2, szLine, DATA_OP_CLOSE_BRACKET, CompareMethod.Text)
                                    If (dwIndex3 = 0) Then
                                        WriteToErrorLog(szFileName, "", "", "FormatData", "FormatData: Exception-DATA_OP_BEGIN_EMBLEN(" & CStr(dwLoop) & ") does not have corresponding DATA_OP_CLOSE_BRACKET.")
                                        GoTo error_routine
                                    End If
                                Else
                                    WriteToErrorLog(szFileName, "", "", "FormatData", "FormatData: Exception-DATA_OP_BEGIN_EMBLEN(" & CStr(dwLoop) & ") does not have corresponding DATA_OP_OPEN_BRACKET.")
                                    GoTo error_routine
                                End If

                                If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) Then
                                    dwIndex4 = InStr(dwIndex2, szLine, DATA_OP_SEPARATOR, CompareMethod.Text)
                                    dwIndex5 = InStr(dwIndex4 + 1, szLine, DATA_OP_SEPARATOR, CompareMethod.Text)

                                    If (dwIndex4 > 0) And (dwIndex5 > 0) Then
                                        szData1 = Mid(szLine, dwIndex2 + 1, dwIndex4 - dwIndex2 - 1)
                                        szData2 = Mid(szLine, dwIndex4 + 1, dwIndex5 - dwIndex4 - 1)
                                        szData3 = Mid(szLine, dwIndex5 + 1, dwIndex3 - dwIndex5 - 1)

                                        dwIndex6 = InStr(1, szLine, DATA_OP_END_EMBLEN + DATA_OP_OPEN_BRACKET + CStr(dwLoop) + DATA_OP_CLOSE_BRACKET, CompareMethod.Text)
                                        If (dwIndex6 > 0) Then
                                            dwEmbLen = dwIndex6 - dwIndex3 - 1

                                            Dim myRepeatedCharacter As String
                                            myRepeatedCharacter = New String(szData2, CInt(szData3))

                                            myRepeatedCharacter = Right(myRepeatedCharacter & CStr(dwEmbLen), CInt(szData3))

                                            szLine = Replace(szLine, Mid(szLine, dwIndex1, dwIndex3 - dwIndex1 + 1), myRepeatedCharacter, 1, -1, CompareMethod.Text)
                                            szLine = Replace(szLine, DATA_OP_END_EMBLEN + DATA_OP_OPEN_BRACKET + CStr(dwLoop) + DATA_OP_CLOSE_BRACKET, "", 1, -1, CompareMethod.Text)
                                        Else
                                            WriteToErrorLog(szFileName, "", "", "FormatData", "FormatData: Exception-DATA_OP_BEGIN_EMBLEN(" & CStr(dwLoop) & ") does not have corresponding DATA_OP_END_EMBLEN.")
                                            GoTo error_routine
                                        End If
                                    Else
                                        WriteToErrorLog(szFileName, "", "", "FormatData", "FormatData: Exception-DATA_OP_BEGIN_EMBLEN(" & CStr(dwLoop) & ") does not have corresponding DATA_OP_SEPARATOR.")
                                        GoTo error_routine
                                    End If
                                End If
                            End If

                            dwIndex2 = 0
                            dwIndex3 = 0
                            dwIndex4 = 0
                            dwIndex5 = 0
                            dwEmbLen = 0

                            szData1 = ""
                            szData2 = ""
                            szData3 = ""
                        Next dwLoop

                        If (lngFileType <> 6) Then
                            If (Trim(Mid(szLine, 17, 13)) <> "") Then
                                Print(dwFileNum, szLine)
                            End If
                        Else
                            Print(dwFileNum, szLine)
                        End If
                        dwRecordNo += 1
                    End If
                End If

            End While

            If (szFooter <> "") Then
                Print(dwFileNum, szFooter)
            End If

            FileClose(dwFileNum)
            myconn.Close()

            Return True
            'End process

        Catch ex As Exception
            WriteToErrorLog(szFileName, "", "", "FormatData", "FormatData: Exception-" & ex.Message)
            Return False
        End Try

error_routine:
        Exit Function

    End Function

    Public Function GetJobElementList(ByVal lngJobId As Long, ByRef myElement() As Element, ByRef szError As String) As Boolean

        Try
            If (lngJobId <= 0) Or (IsNothing(lngJobId)) Then
                Return False
                Exit Function
            End If

            Dim strSQL As String = "SELECT a.ds_id, a.seg_id FROM SegmentList a, DataSetup b, JobSetup c WHERE (a.ds_id = b.ds_id) and (b.ds_id = c.job_ds_id) and (job_id = " & lngJobId & ") ORDER BY a.seg_seq ASC"

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            If (datareader.HasRows = False) Then
                szError = "SegmentList not defined for Job=" & lngJobId
                Return False
            End If

            Dim lngDataSetupId As Long
            Dim lngSegmentId As Long

            ReDim Preserve myElement(0)

            While datareader.Read()
                lngDataSetupId = IIf(IsDBNull(datareader("ds_id")), -1, datareader("ds_id"))
                lngSegmentId = IIf(IsDBNull(datareader("seg_id")), -1, datareader("seg_id"))

                FillSegmentElement(lngDataSetupId, lngSegmentId, myElement)
            End While

            myconn.Close()

            Return True


        Catch ex As Exception
            szError = "GetJobElementList: Exception-" & ex.Message
            Return False
        Finally
        End Try

    End Function

    'Once the template of element list is established, this routine will retrieve data for each element list.
    'The element with correct data will be store in the myElementList variable.
    Public Function GetJobElementValue(ByVal szBatchId As String, ByVal szCardId As String, ByVal dwRecordNo As Integer, ByRef myElement() As Element, ByRef myElementItem() As ElementItem, ByRef szError As String) As Boolean
        'Loop all elements in myElement array and replace the mapfield tag/constant
        'before output to myElementItem array
        Try
            If (UBound(myElement) <= 0) Then
                Return False
                Exit Function
            End If

            'Prepare myElementItem to accept data
            Dim dwTotalItem As Integer
            dwTotalItem = UBound(myElement)

            ReDim Preserve myElementItem(dwTotalItem)
            'End prepare

            'Load all record from DATA table that is related to the szCardId record
            'This is to avoid multiple data access to DATA table when parsing element item
            Dim myData() As ElementItem = Nothing
            LoadElementData(szBatchId, szCardId, myData)
            'End load 

            Dim dwCount As Integer
            Dim szValue As String

            For dwCount = 1 To dwTotalItem
                szValue = myElement(dwCount).MapField
                myElementItem(dwCount).Tag = myElement(dwCount).Tag
                myElementItem(dwCount).Value = ParseElementItem(szCardId, dwRecordNo, szValue, myData)
            Next

            Return True

        Catch ex As Exception
            szError = "GetJobElementValue: Exception-" & ex.Message
            Return False
        End Try

    End Function

    'ONE Data Setup maybe tie to one or more data segment, and in specific sequence of order.
    'This routine will consolidate all the related data segment and its subelement into a common list
    'and store in the myElement variable.
    Private Sub FillSegmentElement(ByVal lngDataSetupId As Long, ByVal lngSegmentId As Long, ByRef myElement() As Element)
        Try
            Dim szTableName As String

            If (lngDataSetupId <= 0) Or (IsNothing(lngDataSetupId)) Or _
               (lngSegmentId <= 0) Or (IsNothing(lngSegmentId)) Then
                Exit Sub
            End If

            Select Case lngSegmentId
                Case DATA_SEGMENT.HEADER
                    szTableName = "HeaderDetails"
                Case DATA_SEGMENT.EMBOSSING
                    szTableName = "EmbossingDetails"
                Case DATA_SEGMENT.INDENTATION
                    szTableName = "IndentationDetails"
                Case DATA_SEGMENT.ENCODING
                    szTableName = "EncodeDataDetails"
                Case DATA_SEGMENT.MAILER
                    szTableName = "MailerDetails"
                Case DATA_SEGMENT.SMC
                    szTableName = "SMCDetails"
                Case DATA_SEGMENT.ULTRAGRAFIX
                    szTableName = "UltragrafixDetails"
                Case DATA_SEGMENT.COLOR
                    szTableName = "ColorDetails"
                Case DATA_SEGMENT.FOOTER
                    szTableName = "FooterDetails"
                Case Else
                    szTableName = ""
            End Select

            'Connect to SegmentList table to retrieve the segment sequence
            Dim strSQL As String = "SELECT element_tag, element_map_field FROM " & szTableName & " WHERE ds_id = " & lngDataSetupId & " ORDER BY element_seq ASC"
            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            Dim dwCount As Integer
            dwCount = UBound(myElement) + 1

            While datareader.Read()
                ReDim Preserve myElement(dwCount)

                myElement(dwCount).Tag = IIf(IsDBNull(datareader("element_tag")), "", datareader("element_tag"))
                myElement(dwCount).MapField = IIf(IsDBNull(datareader("element_map_field")), "", datareader("element_map_field"))

                dwCount += 1
            End While

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("FillSegmentElement: Exception-" & ex.Message)
        End Try

    End Sub

    'Load all the DATA table for the selected record based on BATCH_ID and CARD_ID
    'and store in the myData variable.
    'This is required for FindElementItem routine to match the tag and obtain actual value for the tag.
    'The reason to use this intermediate myData variable is to reduce multiple table access during the
    'FindElementItem routine.
    Private Function LoadElementData(ByVal szBatchId As String, ByVal szCardId As String, ByRef myData() As ElementItem) As Boolean
        Try
            Dim cn As New ADODB.Connection
            Dim rs As New ADODB.Recordset

            Dim szTag As String
            Dim szValue As String

            'Connect to XMLC database and empty the DATA table
            cn.ConnectionString = gszConnString
            cn.CommandTimeout = 0
            cn.Open()

            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
            rs.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic


            'Load all record data here EXCEPT CARD_SCRIPT element because its huge data
            'rs.Open("SELECT DISTINCT(data_element_name), data_element_value FROM Data WHERE data_batch_id ='" & szBatchId & "' AND data_card_id = '" & szCardId & "' AND data_element_name <> 'CARD_SCRIPT' ORDER BY data_element_name ASC", cn)
            rs.Open("SELECT data_element_name, data_element_value FROM Data WHERE data_batch_id ='" & szBatchId & "' AND data_card_id = '" & szCardId & "' AND data_element_name <> 'CARD_SCRIPT' ORDER BY data_element_name ASC", cn)

            ReDim Preserve myData(0)

            Dim dwCount As Integer
            dwCount = UBound(myData) + 1

            While (Not rs.EOF)
                szTag = IIf(IsDBNull(rs.Fields(0).Value), "", rs.Fields(0).Value)
                szValue = IIf(IsDBNull(rs.Fields(1).Value), "", rs.Fields(1).Value)

                If (UCase(szTag) = "AWBNO") And (szValue = "") Then
                    szValue = Space(13)
                End If

                If (szTag <> "") And (szValue <> "") Then
                    ReDim Preserve myData(dwCount)

                    myData(dwCount).Tag = szTag
                    myData(dwCount).Value = szValue

                    dwCount += 1
                End If

                rs.MoveNext()
            End While

            rs.Close()
            cn.Close()

        Catch ex As Exception
            MessageBox.Show("LoadElementData: Exception-" & ex.Message)
        End Try

    End Function

    'ONE subelement in each of the element may contain one or more text(s) which are needed to be replace
    'with actual value from DATA table.
    'This routine will break down the element into subelement and process them one by one.
    Private Function ParseElementItem(ByVal szCardId As String, ByVal dwRecordNo As Integer, ByVal szValue As String, ByRef myData() As ElementItem) As String

        Try
            Dim myArray() As String

            'Split value to individual item in myArray
            myArray = Split(szValue, "+", -1, CompareMethod.Text)

            Dim dwIndex1 As Integer
            Dim dwIndex2 As Integer
            Dim dwIndex3 As Integer
            Dim dwIndex4 As Integer
            Dim dwIndex5 As Integer

            Dim szData1 As String
            Dim szData2 As String
            Dim szData3 As String
            Dim szData4 As String
            Dim szData5 As String
            Dim szData6 As String
            Dim szData7 As String

            Dim szRetVal As String

            Dim dwCount As Integer
            Dim dwTotalItem As Integer

            'Loop through the myArray to find and replace the data 
            dwTotalItem = UBound(myArray)

            For dwCount = 0 To dwTotalItem
                dwIndex1 = InStr(1, myArray(dwCount), DATA_OP_OPEN_BRACKET, CompareMethod.Text)
                dwIndex2 = InStrRev(myArray(dwCount), DATA_OP_CLOSE_BRACKET, -1, CompareMethod.Text)

                'Handle DATA_OP_LEFT    (INPUT_1: FIELD_NAME, INPUT_2: LENGTH_TO_EXTRACT)
                If (InStr(myArray(dwCount), DATA_OP_LEFT, CompareMethod.Text) > 0) Then
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex2 - dwIndex3 - 1)

                        szData3 = FindElementItem(szData1, myData)
                        myArray(dwCount) = Left(szData3, CInt(szData2))
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_LEFS    (INPUT_1: FIELD_NAME, INPUT_2: LENGTH_TO_EXTRACT)
                If (InStr(myArray(dwCount), DATA_OP_LEFS, CompareMethod.Text) > 0) Then
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex2 - dwIndex3 - 1)

                        szData3 = FindElementItem(szData1, myData)
                        myArray(dwCount) = Left(szData3 & Space(CInt(szData2)), CInt(szData2))
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_RIGHT   (INPUT_1: FIELD_NAME, INPUT_2: LENGTH_TO_EXTRACT)
                If (InStr(myArray(dwCount), DATA_OP_RIGHT, CompareMethod.Text) > 0) Then
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex2 - dwIndex3 - 1)

                        szData3 = FindElementItem(szData1, myData)
                        myArray(dwCount) = Right(szData3, CInt(szData2))
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_MID     (INPUT_1: FIELD_NAME, INPUT_2: START_POSITION, INPUT_3: LENGTH_TO_EXTRACT)
                If (InStr(myArray(dwCount), DATA_OP_MID, CompareMethod.Text) > 0) Then
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)
                    dwIndex4 = InStr(dwIndex3 + 1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) And (dwIndex4 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex4 - dwIndex3 - 1)
                        szData3 = Mid(myArray(dwCount), dwIndex4 + 1, dwIndex2 - dwIndex4 - 1)

                        szData4 = FindElementItem(szData1, myData)
                        myArray(dwCount) = Mid(szData4, CInt(szData2), CInt(szData3))
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_CHR     (INPUT_1: CHR_IN_HEX)
                If (InStr(myArray(dwCount), DATA_OP_CHR, CompareMethod.Text) > 0) Then
                    If (dwIndex1 > 0) And (dwIndex2 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex2 - dwIndex1 - 1)

                        myArray(dwCount) = Chr(Val("&H" & szData1))
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_HEX     (INPUT_1: CHR_IN_ASC)
                If (InStr(myArray(dwCount), DATA_OP_HEX, CompareMethod.Text) > 0) Then
                    If (dwIndex1 > 0) And (dwIndex2 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex2 - dwIndex1 - 1)

                        myArray(dwCount) = Hex(szData1)
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_SPACE   (INPUT_1: COUNT)
                If (InStr(myArray(dwCount), DATA_OP_SPACE, CompareMethod.Text) > 0) Then
                    If (dwIndex1 > 0) And (dwIndex2 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex2 - dwIndex1 - 1)

                        myArray(dwCount) = Space(CInt(szData1))
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_REPLACE (INPUT_1: FIND_TEXT, INPUT_2: REPLACE_TEXT)
                If (InStr(myArray(dwCount), DATA_OP_REPLACE, CompareMethod.Text) > 0) Then
                    dwIndex1 = InStr(1, myArray(dwCount), DATA_OP_OPEN_BRACKET, CompareMethod.Text)
                    dwIndex2 = InStrRev(myArray(dwCount), DATA_OP_CLOSE_BRACKET, -1, CompareMethod.Text)
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex2 - dwIndex3 - 1)

                        myArray(dwCount) = Replace(myArray(dwCount), szData1, szData2, 1, -1, CompareMethod.Text)
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_STR     (INPUT_1: CHR_ASC, INPUT_2: COUNT)
                If (InStr(myArray(dwCount), DATA_OP_STR, CompareMethod.Text) > 0) Then
                    dwIndex1 = InStr(1, myArray(dwCount), DATA_OP_OPEN_BRACKET, CompareMethod.Text)
                    dwIndex2 = InStrRev(myArray(dwCount), DATA_OP_CLOSE_BRACKET, -1, CompareMethod.Text)
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex2 - dwIndex3 - 1)

                        Dim myRepeatedCharacter As String
                        myRepeatedCharacter = New String(szData1, CInt(szData2))

                        myArray(dwCount) = myRepeatedCharacter
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_STR_HEX     (INPUT_1: CHR_HEX, INPUT_2: COUNT)
                If (InStr(myArray(dwCount), DATA_OP_STR_HEX, CompareMethod.Text) > 0) Then
                    dwIndex1 = InStr(1, myArray(dwCount), DATA_OP_OPEN_BRACKET, CompareMethod.Text)
                    dwIndex2 = InStrRev(myArray(dwCount), DATA_OP_CLOSE_BRACKET, -1, CompareMethod.Text)
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex2 - dwIndex3 - 1)

                        Dim myRepeatedCharacter As String
                        myRepeatedCharacter = New String(Chr(Val("&H" & szData1)), CInt(szData2))

                        myArray(dwCount) = myRepeatedCharacter
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_RECORD_NUMBER    (INPUT_1: APPENDING_CHR, INPUT_2: COUNT)
                If (InStr(myArray(dwCount), DATA_OP_RECORD_NUMBER, CompareMethod.Text) > 0) Then
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex2 - dwIndex3 - 1)

                        Dim myRepeatedCharacter As String
                        myRepeatedCharacter = New String(szData1, CInt(szData2))

                        myRepeatedCharacter = Right(myRepeatedCharacter & CStr(dwRecordNo), CInt(szData2))
                        myArray(dwCount) = myRepeatedCharacter
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_SYSDATE     (INPUT_1: DATE FORMAT)
                If (InStr(myArray(dwCount), DATA_OP_SYSDATE, CompareMethod.Text) > 0) Then
                    If (dwIndex1 > 0) And (dwIndex2 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex2 - dwIndex1 - 1)

                        myArray(dwCount) = Date.Now.ToString(szData1)   'szData1 = yyMMdd
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_BCD     (INPUT_1: DATA_IN_ARRAYOFHEX)
                If (InStr(myArray(dwCount), DATA_OP_BCD, CompareMethod.Text) > 0) Then
                    If (dwIndex1 > 0) And (dwIndex2 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex2 - dwIndex1 - 1)

                        myArray(dwCount) = BCD(szData1, myData)
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_IIF     (INPUT_1: FIELD_NAME, INPUT_2: CONDITION, INPUT_3: OUTPUT_TRUE, INPUT_4: OUTPUT_FALSE)
                If (InStr(myArray(dwCount), DATA_OP_IIF, CompareMethod.Text) > 0) Then
                    dwIndex1 = InStr(1, myArray(dwCount), DATA_OP_OPEN_BRACKET, CompareMethod.Text)
                    dwIndex2 = InStrRev(myArray(dwCount), DATA_OP_CLOSE_BRACKET, -1, CompareMethod.Text)
                    dwIndex3 = InStr(dwIndex1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)
                    dwIndex4 = InStr(dwIndex3 + 1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)
                    dwIndex5 = InStr(dwIndex4 + 1, myArray(dwCount), DATA_OP_SEPARATOR, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) And (dwIndex3 > 0) And (dwIndex4 > 0) And (dwIndex5 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex3 - dwIndex1 - 1)  'FIELD_NAME
                        szData2 = Mid(myArray(dwCount), dwIndex3 + 1, dwIndex4 - dwIndex3 - 1)  'CONDITION
                        szData3 = Mid(myArray(dwCount), dwIndex4 + 1, dwIndex5 - dwIndex4 - 1)  'OUTPUT_TRUE
                        szData4 = Mid(myArray(dwCount), dwIndex5 + 1, dwIndex2 - dwIndex5 - 1)  'OUTPUT_FALSE

                        szData5 = FindElementItem(szData1, myData)  'Value for FIELD_NAME
                        szData6 = FindElementItem(szData3, myData)  'Value for OUTPUT_TRUE
                        szData7 = FindElementItem(szData4, myData)  'Value for OUTPUT_FALSE

                        If Trim(UCase(szData5)) = Trim(UCase(szData2)) Then
                            myArray(dwCount) = szData6
                        Else
                            myArray(dwCount) = szData7
                        End If
                    End If

                    GoTo next_item
                End If

                'Handle DATA_OP_TRIM     (INPUT_1: FIELD_NAME)
                If (InStr(myArray(dwCount), DATA_OP_TRIM, CompareMethod.Text) > 0) Then
                    If (dwIndex1 > 0) And (dwIndex2 > 0) Then
                        szData1 = Mid(myArray(dwCount), dwIndex1 + 1, dwIndex2 - dwIndex1 - 1)

                        myArray(dwCount) = Trim(szData1)
                    End If

                    GoTo next_item
                End If

                szRetVal = FindElementItem(myArray(dwCount), myData)
                If (szRetVal = "") Then
                    myArray(dwCount) = myArray(dwCount)
                Else
                    myArray(dwCount) = szRetVal
                End If

next_item:
                dwIndex1 = 0
                dwIndex2 = 0
                dwIndex3 = 0
                dwIndex4 = 0
                dwIndex5 = 0

                szData1 = ""
                szData2 = ""
                szData3 = ""
                szData4 = ""
                szData5 = ""
                szData6 = ""
                szData7 = ""

                szRetVal = ""
            Next

            'After all member in the myArray has been replaced or fill-up properly,
            'merge them into a single string and return to the calling routine
            Dim szFinalValue As String = ""

            For dwCount = 0 To dwTotalItem
                szFinalValue = szFinalValue & CStr(myArray(dwCount))
            Next

            Return szFinalValue

        Catch ex As Exception
            MessageBox.Show("ParseElementItem: Exception-" & ex.Message)
            Return ""
        End Try

    End Function

    Private Function BCD(ByVal szData As String, ByRef myData() As ElementItem) As String
        Dim myBCDArray() As String
        Dim dwTotalBCDItem As Integer
        Dim dwBCDCount As Integer
        Dim szRetVal As String
        Dim szDataBCD As String = ""

        Dim dwIndex1 As Integer
        Dim dwIndex2 As Integer
        Dim szData1 As String

        Try
            myBCDArray = Split(szData, "~", -1, CompareMethod.Text)
            dwTotalBCDItem = UBound(myBCDArray)
            For dwBCDCount = 0 To dwTotalBCDItem
                'The BCD function will cater for SYSDATE Function too.
                If (InStr(myBCDArray(dwBCDCount), DATA_OP_BCDSYSDATE, CompareMethod.Text) > 0) Then

                    dwIndex1 = InStr(1, myBCDArray(dwBCDCount), DATA_OP_OPEN_BRACKET, CompareMethod.Text)
                    dwIndex2 = InStrRev(myBCDArray(dwBCDCount), DATA_OP_CLOSE_BRACKET, -1, CompareMethod.Text)

                    If (dwIndex1 > 0) And (dwIndex2 > 0) Then
                        szData1 = Mid(myBCDArray(dwBCDCount), dwIndex1 + 1, dwIndex2 - dwIndex1 - 1)

                        szDataBCD += Microsoft.VisualBasic.Format(DateTime.Now, szData1)
                    End If
                Else
                    szRetVal = FindElementItem(myBCDArray(dwBCDCount), myData)
                    If (szRetVal = "") Then
                        szDataBCD += myBCDArray(dwBCDCount)
                    Else
                        szDataBCD += szRetVal
                    End If
                End If
            Next

            Dim dwDataLen As Integer
            Dim dwIndex As Integer
            BCD = ""
            dwDataLen = Len(szDataBCD)
            For dwIndex = 1 To dwDataLen Step 2
                BCD = BCD + Chr("&H" & Mid(szDataBCD, dwIndex, 2))
            Next dwIndex
        Catch ex As Exception
            MessageBox.Show("BCD: Exception-" & ex.Message)
            BCD = ""
        End Try

    End Function


    'After the LoadElementData has been called, all the actual data from DATA table will be store in myData variable.
    'When ParseElementItem processes, it will call this routine to match the required Tag with the actual data
    'in myData variable. It will return the actual value to calling routine if the matched tag is found.
    Private Function FindElementItem(ByVal szTag As String, ByRef myData() As ElementItem) As String

        Dim szValue As String
        szValue = szTag

        Dim dwCount As Integer
        Dim dwTotalItem As Integer

        dwTotalItem = UBound(myData)
        For dwCount = 1 To dwTotalItem
            If (UCase(myData(dwCount).Tag) = UCase(szTag)) Then
                szValue = myData(dwCount).Value
                Exit For
            End If
        Next

        Return szValue

    End Function

End Module
