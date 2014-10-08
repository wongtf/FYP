Imports System.IO

Module General

    Public gszWorkDrive As String

    Public Const APP_NAME As String = "DPSREPORTSYS"
    Public Const DSN_NAME As String = "NewCitiRep"
    Public DSN_USER As String
    Public DSN_PASSWORD As String

    Public Const DEFAULT_PASSWORD As String = "Password1"
    Public Const INFINITE_EXPIRY As String = "00000000"
    Public Const PASSWORD_MIN_LEN As Integer = 8
    Public Const LOGIN_DORMANT_PERIOD As Integer = 30
    Public Const LOGIN_DEFAULT_RETRY As Integer = 3
    Public Const FIXEDLENGTH_DEFAULT_LEN As Integer = 502
    Public Const FIXEDLENGTH_DEFAULT_CARD_TAG As String = "CARD_NUMBER"

    Public Const XML_DEFAULT_ROOT_TAG As String = "/MASS_PERSO_REQUEST"
    Public Const XML_DEFAULT_BATCH_TAG As String = "BATCH_ID"
    Public Const XML_DEFAULT_CARD_TAG As String = "CARD_ID"

    Public Const EXT_RPT As String = ".rpt"
    Public Const EXT_TMP As String = ".tmp"
    Public Const EXT_ASC As String = ".asc"
    Public Const EXT_ENC As String = ".enc"
    Public Const EXT_9K As String = ".9k"
    Public Const EXT_XLS As String = ".xls"
    Public Const DUMMY_FILE As String = "dummy.txt"
    Public Const DECRYPT_BAT_FILE As String = "decrypt.bat"
    Public Const ENCRYPT_BAT_FILE As String = "encrypt.bat"

    Public Const ENCRYPT_EMVES_BAT_FILE As String = "encryption.bat"

    Public Const DEFAULT_MACHINE_CODE As String = "9"

    Public gszConnString As String '= "FIL=MS Access;DSN=XMLC"

    Public gszPassword As String

    Public Const DATA_OP_LEFT As String = "LEFT"
    Public Const DATA_OP_LEFS As String = "LEFS"
    Public Const DATA_OP_RIGHT As String = "RIGHT"
    Public Const DATA_OP_MID As String = "MID"
    Public Const DATA_OP_CHR As String = "CHR"
    Public Const DATA_OP_HEX As String = "HEX"
    Public Const DATA_OP_SPACE As String = "SPACE"
    Public Const DATA_OP_REPLACE As String = "REPLACE"
    Public Const DATA_OP_STR As String = "STR"
    Public Const DATA_OP_STR_HEX As String = "SRHX"
    Public Const DATA_OP_RECORD_NUMBER As String = "RECORD_NUMBER"
    Public Const DATA_OP_SYSDATE As String = "SYSDATE"
    Public Const DATA_OP_BCD As String = "BCD"
    Public Const DATA_OP_BCDSYSDATE As String = "SYSBCDDATE"
    Public Const DATA_OP_IIF As String = "IIF"
    Public Const DATA_OP_TRIM As String = "TRIM"

    Public Const DATA_OP_BEGIN_EMBLEN As String = "BEGIN_EMBLEN"
    Public Const DATA_OP_END_EMBLEN As String = "END_EMBLEN"

    Public Const DATA_OP_OPEN_BRACKET As String = "("
    Public Const DATA_OP_CLOSE_BRACKET As String = ")"
    Public Const DATA_OP_SEPARATOR As String = ","
    Public Const MAX_EMBLEN As Integer = 10

    Public arOpList() As String = New String() {"", "LEFT(FIELD_NAME,LEN)", "LEFS(FIELD_NAME,LEN)", "RIGHT(FIELD_NAME,LEN)", "MID(FIELD_NAME,START_POSITION,LEN)", "CHR(HEXCODE)", _
                                                "HEX(INT)", "SPACE(COUNT)", "REPLACE(FIND_TEXT,REPLACE_TEXT)", "STR(CHARACTER,COUNT)", "SRHX(CHR_HEX,COUNT)", _
                                                "RECORD_NUMBER(CHARACTER,COUNT)", "SYSDATE(DATE_FORMAT)", "BCD(DATA_IN_ARRAY_OF_HEX)", "IIF(FIELD_NAME,CONDITION,OUTPUT_TRUE,OUTPUT_FALSE)", _
                                                "TRIM(FIELD_NAME)", "BEGIN_EMBLEN(INDEX,CHARACTER,COUNT)", "END_EMBLEN(INDEX)"}

    Public Const LOGIN_OK As Integer = 0
    Public Const LOGIN_FAIL As Integer = 1
    Public Const LOGIN_BARRED As Integer = 2
    Public Const LOGIN_REVOKED As Integer = 3
    Public Const LOGIN_DORMANT As Integer = 4
    Public Const LOGIN_FIRST_TIME As Integer = 5
    Public Const LOGIN_EXPIRED As Integer = 6

    Public Const FAIL_ID As Integer = -1

    Public Const NEW_ID As String = "-1"
    Public Const NEW_JOB As String = "NEW JOB"
    Public Const NEW_DATA As String = "NEW CARD"
    Public Const NEW_BANK As String = "NEW BANK"
    Public Const NEW_USER As String = "NEW USER"
    Public Const NEW_GROUP As String = "NEW GROUP"
    Public Const NEW_MENU As String = "NEW MENU"
    Public Const NEW_FORMAT As String = "NEW FORMAT"
    Public Const NEW_SEGMENT As String = "NEW SEGMENT"
    Public Const NEW_ELEMENT As String = "NEW ELEMENT"
    Public Const NEW_REPORT As String = "NEW REPORT"

    Public Const DATA_GROUP_GENERAL As String = "GENERAL"
    Public Const DATA_GROUP_EMBOSS As String = "EMBOSS DATA"
    Public Const DATA_GROUP_DCAUDIT As String = "DC9K AUDIT"
    Public Const DATA_GROUP_IREGISTER As String = "ISSUE REGISTER"
    Public Const DATA_GROUP_CN As String = "CN FILE"

    Public Const FILE_TYPE_UNDEFINED As String = "UNDEFINED"
    Public Const FILE_TYPE_DAILY As String = "DAILY + UPGRADE"
    Public Const FILE_TYPE_RENEWAL As String = "RENEWAL"
    Public Const FILE_TYPE_UPGRADE As String = "UPGRADE"
    Public Const FILE_TYPE_PE1 As String = "PRE-EMB 1"
    Public Const FILE_TYPE_PE2 As String = "PRE-EMB 2"
    Public Const FILE_TYPE_COMMCARD As String = "COMM CARD"

    Public Const COURIER_POSLAJU As String = "P"
    Public Const COURIER_ERABARU As String = "A"

    Public Const FILE_STATION_ID As String = "station.ini"
    Public Const FILE_SERVER_NAME As String = "server.ini"

    Public Const BARCODE_PREV As String = "0101010"
    Public Const BARCODE_NEXT As String = "0202020"

    Public Enum DATA_SEGMENT
        HEADER = 1
        EMBOSSING = 2
        INDENTATION = 3
        ENCODING = 4
        MAILER = 5
        SMC = 6
        ULTRAGRAFIX = 7
        COLOR = 8
        FOOTER = 9
    End Enum

    Public Enum BANK_ENCRYPT_ALGORITHM
        PLAINTEXT = 0
        DCQSS = 1
        EMVES = 2
    End Enum

    Public Enum FILE_FORMAT
        XML = 1
        FIXEDLENGTH = 2
        DELIMITED = 3
        CNFILE = 4
    End Enum

    Public Enum OUTPUT_FORMAT
        NOOUTPUT = 0
        PLAINTEXT = 1
        ENC = 2
    End Enum

    Public Enum DATA_FORMAT
        ASC = 0
        HEX = 1
    End Enum

    Public Enum DATA_GROUP
        GENERAL = 0
        EMBOSS = 1
        DCAUDIT = 2
        IREGISTER = 3
    End Enum

    Public Enum FILE_TYPE
        UNDEFINED = 0
        DAILY = 1
        RENEWAL = 2
    End Enum

    Public Structure Bank
        Dim Id As Long
        Dim BankName As String
        Dim Bin As String
        Dim Algorithm As BANK_ENCRYPT_ALGORITHM
        Dim Logo As String
        Dim Folder_Root As String
        Dim Folder_Input As String
        Dim Folder_EncService As String
        Dim Folder_EncBackup As String
        Dim Folder_Ready As String
        Dim Folder_DC9K As String
        Dim Folder_Error As String
        Dim Folder_Backup As String
        Dim Folder_Report As String
        Dim Default_CN As String
        Dim Output_Encrypted As Boolean
    End Structure

    Public Structure Job
        Dim Id As Long
        Dim FileIDF As String
        Dim Description As String
        Dim CardSetupID As Integer
        Dim FileStartPos As Integer
        Dim FileLength As Integer
        Dim FileFormat As FILE_FORMAT
        Dim OutputFormat As OUTPUT_FORMAT
        'Dim JobProc As Integer
    End Structure

    Public Structure Users
        Dim Id As Long
        Dim BankId As Long
        Dim LoginId As String
        Dim Name As String
        Dim Barred As Boolean
        Dim GroupId As Long
        Dim Revoked As Boolean
        Dim RetryLeft As Integer
        Dim LastLogin As String
        Dim FirstSignIn As Boolean
        Dim DormantPeriod As Integer
        Dim ExpiryPeriod As Integer
        Dim ExpiryDate As String
    End Structure

    Public Structure Element
        Dim Tag As String
        Dim MapField As String
    End Structure

    Public Structure ElementItem
        Dim Tag As String
        Dim Value As String
    End Structure

    Public Structure Format
        Dim Id As Integer
        Dim Sequence As Integer
        Dim Name As String
        Dim Description As String
        Dim TypeOfValue As DATA_FORMAT
        Dim IsBatchHeader As Boolean
        Dim XML_Node As String
        Dim TextStartPos As Integer
        Dim TextLength As Integer
        Dim RowDelimiter As String
        Dim ColDelimiter As String
        Dim VerificationFlag As Boolean
    End Structure

    Public Structure Record
        Dim BatchId As String
        Dim CardId As String
    End Structure

    'Added by SY
    Public Structure Report
        Dim Id As Integer
        Dim ReportFileName As String
        Dim ReportDescription As String
        Dim MenuDisplay As String
    End Structure

    'Added by SY
    Public Structure SortField
        Dim Name As String
        Dim Value As String
        Dim StartPos As Long
        Dim Length As Long
    End Structure

    Public UserInfo As Users
    Public BankInfo As Bank
    Public JobInfo As Job

    Public arRecord() As Record                 'Store card record only
    Public arJobInfo() As Job                   'Store jobsetup record
    Public arFormatInfo() As Format             'Store format record
    Public arElement() As Element               'Store element template only
    Public arElementItem() As ElementItem       'Store element that has data ready
    Public arReportInfo() As Report             'Store report setup record  'added by SY
    Public arSortField() As SortField           'Store report sort field    'added by SY

    Public szReportFileName As String           'added by SY
    Public szReportType As String               'added by SY

    Public gszFieldName As String               'added by HV
    Public gszStationId As String               'added by HV
    Public gszServerName As String              'added by HV

    'Subroutine : Main
    'Purpose    : This is the first executable module in the project.
    Sub Main()

        gszWorkDrive = Application.StartupPath & "\"

        'Read Station Id
        Dim dwFileNum As Integer
        dwFileNum = FreeFile()

        FileOpen(dwFileNum, gszWorkDrive & FILE_SERVER_NAME, OpenMode.Input)

        If Not EOF(dwFileNum) Then
            Dim szEncrypted As String = ""
            Dim szPassword As String = ""

            gszServerName = LineInput(dwFileNum)
            DSN_USER = LineInput(dwFileNum)
            szEncrypted = LineInput(dwFileNum)
            'If (EncryptString(szEncrypted, szPassword) = True) Then
            If (DecryptString(szEncrypted, szPassword) = True) Then
                DSN_PASSWORD = szPassword
            Else
                DSN_PASSWORD = "sa"
            End If
        Else
            gszServerName = "localhost"
            DSN_USER = "sa"
            DSN_PASSWORD = "sa"
        End If

        FileClose(dwFileNum)
        'End Read Station Id

        'DeleteDSN(DSN_NAME)
        'If (CreateDSN(DSN_NAME, gszServerName, DSN_NAME, DSN_USER, DSN_PASSWORD) = False) Then
        ' MessageBox.Show("Fail to create DSN connection [" & DSN_NAME & "].", "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' Exit Sub
        ' End If

        'gszConnString = "Driver={SQL Server};" & "Server=" & gszServerName & ";" & "Database=" & DSN_NAME & ";" & "Uid=" & DSN_USER & ";" & "Pwd=" & DSN_PASSWORD
        gszConnString = "Provider=SQLOLEDB; Data Source=" & gszServerName & "; Initial Catalog=" & DSN_NAME & "; User ID=" & DSN_USER & "; Password=" & DSN_PASSWORD & ";"

        'Read Station Id
        dwFileNum = FreeFile()

        FileOpen(dwFileNum, gszWorkDrive & FILE_STATION_ID, OpenMode.Input)

        If Not EOF(dwFileNum) Then
            gszStationId = LineInput(dwFileNum)
        Else
            gszStationId = "DEFAULT"
        End If

        FileClose(dwFileNum)
        'End Read Station Id

        ' Display the login dialog.
        Dim dlgLogin As New frmLogin

Again:
        If dlgLogin.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim frmStart As New frmMenu

            If (frmStart.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
                GoTo Again
            End If
        End If

    End Sub

    'Subroutine : CheckFolderExist
    'Purpose    : To check if a given folder exists or not
    Public Function IsFolderExist(ByVal szFolder As String) As Boolean
        Return Directory.Exists(szFolder)
    End Function

    'Subroutine : CheckFileExist
    'Purpose    : To check if a given file exists or not
    Public Function IsFileExist(ByVal szFile As String) As Boolean
        Return File.Exists(szFile)
    End Function

    'Subroutine : MyCopyFile
    'Purpose    : To copy a file from source to destination
    Public Function MyCopyFile(ByVal szSource As String, ByVal szDestination As String) As Boolean
        Try
            If (IsFileExist(szDestination) = True) Then
                WipeFile(szDestination)
            End If

            File.Copy(szSource, szDestination)
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    'Subroutine : MyMoveFile
    'Purpose    : To move a file from source to destination
    Public Function MyMoveFile(ByVal szSource As String, ByVal szDestination As String) As Boolean
        Try
            If (IsFileExist(szDestination) = True) Then
                WipeFile(szDestination)
            End If

            File.Move(szSource, szDestination)
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    'Subroutine : CopyDirectory
    'This function takes two absolute paths (source directory and destination)
    Public Function CopyDirectory(ByVal Src As String, ByVal Dest As String, Optional ByVal bQuiet As Boolean = False) As Boolean

        If Not Directory.Exists(Src) Then
            Throw New DirectoryNotFoundException("Selected folder named " & Src & " does not exists.")
        End If

        If Directory.Exists(Dest) AndAlso Not bQuiet Then
            If MessageBox.Show("Selected folder named " & Dest & " already exists." & vbCrLf & _
            "Do you wish to overwrite existing files in the folder?", _
            "Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Function
        End If

        'add Directory Seperator Character (\) for the string concatenation shown later
        If Dest.Substring(Dest.Length - 1, 1) <> Path.DirectorySeparatorChar Then
            Dest += Path.DirectorySeparatorChar
        End If

        If Not Directory.Exists(Dest) Then Directory.CreateDirectory(Dest)

        Dim Files As String()
        Files = Directory.GetFileSystemEntries(Src)

        Dim element As String

        For Each element In Files
            If Directory.Exists(element) Then
                'if the current FileSystemEntry is a directory, call this function recursively
                CopyDirectory(element, Dest & Path.GetFileName(element), True)
            Else
                'the current FileSystemEntry is a file so just copy it
                File.Copy(element, Dest & Path.GetFileName(element), True)
            End If
        Next

        Return True

    End Function

    'Subroutine : WriteToErrorLog
    'Purpose    : To record error into ErrorLog table
    Public Sub WriteToErrorLog(ByVal szFile As String, ByVal szBatchId As String, ByVal szCardId As String, ByVal szActivity As String, ByVal szError As String)

        Dim myconn As New oledb.oledbConnection(gszConnString)
        Dim myCmdQuery As New oledb.oledbCommand
        Dim myCmd As New oledb.oledbCommand
        Dim datareader As oledb.oledbDataReader = Nothing

        Dim DateTimeInfo As DateTime
        Dim dwReturnRow As Integer
        Dim szSQLAdd$

        Try
            DateTimeInfo = DateTime.Now

            myconn.Open()
            myCmd.Connection = myconn
            If InStr(szError, "'") > 0 Then
                szError = Replace(szError, "'", "''")
            End If
            szSQLAdd$ = "INSERT INTO ErrorLog (err_filename, err_datetime, err_batch_id, err_card_id, err_operation, err_desc) VALUES ('" & szFile & "','" & DateTimeInfo.ToString("yyyyMMdd") & DateTimeInfo.ToString("hhmmss") & "','" & szBatchId & "','" & szCardId & "','" & szActivity & "','" & szError & "')"
            'Save the found entry into DATA table if name and value is not empty
            myCmd.CommandText = szSQLAdd$
            dwReturnRow = myCmd.ExecuteNonQuery()

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("WriteToErrorLog: exception-" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Subroutine : FindComboItem
    'Purpose    : To find the index of the szId in myComboBox
    Public Function FindComboItem(ByVal myComboBox As ComboBox, ByVal dwId As Long) As Integer
        Try
            Dim dwIndex As Integer = FAIL_ID

            Dim szValue As String
            Dim dwCount As Integer
            Dim dwTotalItem As Integer

            dwTotalItem = myComboBox.Items.Count - 1
            If dwTotalItem > 0 Then myComboBox.SelectedIndex = 0
            For dwCount = 0 To dwTotalItem
                szValue = myComboBox.Items.Item(dwCount)
                szValue = Mid(szValue, 101, Len(szValue) - 100)
                If (CLng(szValue) = dwId) Then
                    dwIndex = dwCount
                    Exit For
                End If
            Next

            Return dwIndex

        Catch ex As Exception
            Return FAIL_ID
        End Try

    End Function

    Public Function FindComboId(ByVal myComboBox As ComboBox, ByVal dwIndex As Integer) As Long

        Try
            Dim szValue As String

            szValue = myComboBox.Items.Item(dwIndex)
            szValue = Mid(szValue, 101, Len(szValue) - 100)

            Return CLng(szValue)

        Catch ex As Exception
            Return FAIL_ID
        End Try


    End Function

    'Subroutine : FindListboxItem
    'Purpose    : To find the index of the szId in myComboBox
    Public Function FindListboxItem(ByVal myListBox As ListBox, ByVal dwId As Long) As Integer
        Try
            Dim dwIndex As Integer = FAIL_ID

            Dim szValue As String
            Dim dwCount As Integer
            Dim dwTotalItem As Integer

            dwTotalItem = myListBox.Items.Count - 1
            For dwCount = 0 To dwTotalItem
                szValue = myListBox.Items.Item(dwCount)
                szValue = Mid(szValue, 101, Len(szValue) - 100)
                If (CLng(szValue) = dwId) Then
                    dwIndex = dwCount
                    Exit For
                End If
            Next

            Return dwIndex

        Catch ex As Exception
            Return FAIL_ID
        End Try

    End Function

    Public Function AcceptablePassword(ByVal szPassword As String) As Boolean
        Dim szChar As String
        Dim dwIndex As Integer
        Dim dwCount As Integer
        Dim boolUpper As Boolean = False
        Dim boolLower As Boolean = False
        Dim boolNumber As Boolean = False

        dwCount = Len(szPassword)

        For dwIndex = 1 To dwCount
            szChar = Mid(szPassword, dwIndex, 1)

            If (IsUpper(szChar) = True) Then
                boolUpper = True
            End If
            If (IsLower(szChar) = True) Then
                boolLower = True
            End If
            If (IsNumeric(szChar) = True) Then
                boolNumber = True
            End If

        Next dwIndex

        If (boolUpper = True) And (boolLower = True) And (boolNumber = True) Then
            Return True
        Else
            Return False
        End If

    End Function

End Module