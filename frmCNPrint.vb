Imports System.Data
Imports System.IO
Imports System.Xml
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices

Public Class frmCNPrint

    Dim szHeaderDetails As String
    Dim szTrailerDetails As String
    Dim szDetails As String
    Dim szFieldCheck As String


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click

        Try
            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim szCourierType As String = Trim(cbDeliveryType.Text)

            If szCourierType = "" Then Exit Sub

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnAll.Enabled = False
            btnSelected.Enabled = False
            btnChange.Enabled = False
            cbFileDate.Enabled = False
            cbType.Enabled = False
            cbFile.Enabled = False
            btnRefresh.Enabled = False

            'Update the record information
            myconn.Open()
            myCmd.Connection = myconn

            myCmd.CommandText = "exec sp_selectcn '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "','',1"
            myCmd.ExecuteNonQuery()

            If szCourierType = "P" Or szCourierType = "p" Then
                myCmd.CommandText = "exec sp_updateprint2 '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            Else
                myCmd.CommandText = "exec sp_updateprint '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            End If
            myCmd.ExecuteNonQuery()

            myconn.Close()

            UpdateAuditLog("Print CN for file " & cbFile.SelectedItem.ToString, "Production")
            Dim szFileName As String = ""
            szFileName = BankInfo.Folder_Report & "CNPrintDebitR" & szCourierType & ".rpt"

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn1 As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "Select * From TempCN Where StationId='" & gszStationId & "'"
            Dim DA As New OleDb.OleDbDataAdapter(strSQL, myconn1)
            Dim DS As New DataSet

            DA.Fill(DS, "TempCN")
            objReport.SetDataSource(DS.Tables("TempCN"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.PrintReport()

        Catch ex As Exception
            MessageBox.Show("frmCNPrint_btnAll.Click: Exception-" & ex.Message)
        Finally
            btnAll.Enabled = True
            btnSelected.Enabled = True
            btnChange.Enabled = True
            cbFileDate.Enabled = True
            cbType.Enabled = True
            cbFile.Enabled = True
            btnRefresh.Enabled = True

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelected.Click
        Try
            Dim dwIndex As Integer
            Dim boolSelected As Boolean = False
            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            Dim szCourierType As String = Trim(cbDeliveryType.Text)

            If szCourierType = "" Then Exit Sub
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnAll.Enabled = False
            btnSelected.Enabled = False
            btnChange.Enabled = False
            cbFileDate.Enabled = False
            cbType.Enabled = False
            cbFile.Enabled = False
            btnRefresh.Enabled = False

            myconn.Open()
            myCmd.Connection = myconn

            myCmd.CommandText = "exec sp_selectcn '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "','',2"
            myCmd.ExecuteNonQuery()

            For dwIndex = 0 To lvField.Items.Count - 1
                If (lvField.Items(dwIndex).Selected = True) Then
                    'Update the record information
                    boolSelected = True
                    myCmd.CommandText = "exec sp_selectcn '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "','" & lvField.Items(dwIndex).SubItems(1).Text & "',0"
                    myCmd.ExecuteNonQuery()
                End If
            Next

            If (boolSelected = False) Then
                myconn.Close()
                MessageBox.Show("No record selected for printing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If szCourierType = "P" Or szCourierType = "p" Then
                myCmd.CommandText = "exec sp_updateprint2 '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            Else
                myCmd.CommandText = "exec sp_updateprint '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            End If

            myCmd.ExecuteNonQuery()

            myconn.Close()

            UpdateAuditLog("Print selected CN for file " & cbFile.SelectedItem.ToString, "Production")

            Dim szFileName As String = ""
            szFileName = BankInfo.Folder_Report & "CNPrintDebitR" & szCourierType & ".rpt"

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            'objReport.Load(szFileName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            objReport.Load(szFileName)

            Dim myconn1 As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "Select * From TempCN Where StationId='" & gszStationId & "'"
            Dim DA As New OleDb.OleDbDataAdapter(strSQL, myconn1)
            Dim DS As New DataSet

            DA.Fill(DS, "TempCN")
            objReport.SetDataSource(DS.Tables("TempCN"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.PrintReport()

        Catch ex As Exception
            MessageBox.Show("frmCNPrint_btnSelected.Click: Exception-" & ex.Message)
        Finally
            btnAll.Enabled = True
            btnSelected.Enabled = True
            btnChange.Enabled = True
            cbFileDate.Enabled = True
            cbType.Enabled = True
            cbFile.Enabled = True

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub frmOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UpdateAuditLog("Print CN ", "Audit Log")
            btnAll.Enabled = False
            btnSelected.Enabled = False
            btnChange.Enabled = False
            '02/09/2013'
            btnExportPL.Enabled = False
            'ExportBatch.Enabled = False

            'Get all report file name in TempReport table
            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim szSQL As String

            szSQL = "SELECT DISTINCT(data_filedate) FROM data ORDER BY data_filedate"

            cbFileDate.Items.Clear()

            Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                cbFileDate.Items.Add(datareader("data_filedate"))
            End While

            datareader.Close()

            Select Case cbFileDate.Items.Count
                Case 0
                    cbFileDate.SelectedIndex = -1
                Case 1
                    cbFileDate.SelectedIndex = 0
                Case Else
                    cbFileDate.SelectedIndex = cbFileDate.Items.Count - 1
            End Select

            'Get List of DeliveryType from db
            myCmd.CommandText = "exec sp_extractdeliverytype"
            datareader = myCmd.ExecuteReader()

            cbDeliveryType.Items.Clear()
            While datareader.Read()
                cbDeliveryType.Items.Add(datareader("deliverytype"))
            End While
            cbDeliveryType.Text = "P"
            datareader.Close()

            'Get List of File Type in db
            szSQL = "SELECT DISTINCT(data_FileType) FROM data"
            myCmd.CommandText = szSQL

            cbType.Items.Clear()

            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                cbType.Items.Add(datareader("data_FileType"))
            End While

            'Edit By azuwa kasnan 27102013
            If cbType.Items.Count > 0 Then
                cbType.SelectedIndex = -1
            End If
            'If cbType.Items.Count = 0 Then
            'cbType.SelectedIndex = -1
            'ElseIf cbType.Items.Count = 1 Then
            'cbType.SelectedIndex = 0
            'Else
            'cbType.SelectedIndex = cbType.Items.Count - 1
            'End If

            datareader.Close()
            myconn.Close()

        Catch ex As Exception
            btnSelected.Enabled = True
            btnChange.Enabled = True
            MessageBox.Show("frmScan_Load: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddStatusItem(ByVal szStatus As String)

        Try
            Dim lvItem As New ListViewItem(szStatus)
            lvField.Items.Add(lvItem)
            lvField.Update()

        Catch ex As Exception
            MessageBox.Show("frmOpen_AddStatusItem: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadData(ByVal szBatchId As String, ByVal szCourierId As String)

        Try
            If (szBatchId = "") Then
                Exit Sub
            End If

            picLoad.Visible = True
            btnAll.Enabled = False
            btnSelected.Enabled = False
            btnChange.Enabled = False
            cbFileDate.Enabled = False
            cbType.Enabled = False
            cbFile.Enabled = False
            btnRefresh.Enabled = False
            '02/09/2013'
            btnExportPL.Enabled = False

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.Refresh()

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing

            'Retrieve format field tie to the job_id
            Dim dwCount As Integer

            Dim szPAN As String = ""
            Dim szCDSRef As String = ""
            Dim szName As String = ""
            Dim szMName As String = ""

            dwCount = 1

            myconn.Open()
            myCmd.Connection = myconn
            myCmd.CommandTimeout = 1000
            'edit by azuwa kasnan 29/10/2013
            'Retrieve the record information
            myCmd.CommandText = "exec sp_extractprint2 '" & cbFileDate.Text & "','" & szBatchId & "','" & szCourierId & "','" & gszStationId & "'"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            While datareader.Read()
                szCDSRef = IIf(IsDBNull(datareader("Field2")), "", datareader("Field2"))
                szName = IIf(IsDBNull(datareader("Field3")), "", datareader("Field3"))
                szPAN = IIf(IsDBNull(datareader("Field5")), "", datareader("Field5"))
                szMName = IIf(IsDBNull(datareader("Line04")), "", datareader("Line04"))

                'edit by azuwa kasnan 24102013
                If (Trim(szCDSRef) <> "" Or Trim(szCDSRef) = "") Then
                    Dim lvItem As New ListViewItem(dwCount)

                    lvItem.SubItems.Add(szCDSRef)
                    lvItem.SubItems.Add(szPAN)
                    lvItem.SubItems.Add(szName)
                    lvItem.SubItems.Add(szMName)

                    lvField.Items.Add(lvItem)
                    dwCount += 1
                End If

            End While

            datareader.Close()
            myconn.Close()

            lbCount.Text = "Record found: " & CStr(dwCount - 1)
            btnAll.Enabled = True

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmScan_LoadData: Exception-" & ex.Message)
        Finally
            picLoad.Visible = False
            btnAll.Enabled = True
            btnSelected.Enabled = True
            btnChange.Enabled = True
            cbFileDate.Enabled = True
            cbType.Enabled = True
            cbFile.Enabled = True
            btnRefresh.Enabled = True
            '02/09/2013'
            If (szCourierId = "A") Then
                btnExportPL.Enabled = False
            Else
                btnExportPL.Enabled = True
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub cbFile_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFile.SelectedIndexChanged
        If cbDeliveryType.Text = "" Then Exit Sub
        LoadData(cbFile.SelectedItem.ToString, Trim(cbDeliveryType.Text))
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadData(cbFile.SelectedItem.ToString, Trim(cbDeliveryType.Text))
    End Sub

    '   Private Sub cbFileDate_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFileDate.SelectedValueChanged
    ''Get all report file name in TempReport table
    'Dim myconn As New oledb.oledbConnection(gszConnString)
    'Dim szSQL As String

    ''Dim dwJobIndex As Integer
    ''Dim lngJobIdTemp As Long
    ''Dim dwFileType As Integer
    'Dim szFileName As String

    'szSQL = "SELECT DISTINCT(data_filename) FROM data WHERE data_filedate='" & cbFileDate.SelectedItem.ToString & "' ORDER BY data_filename"

    'Dim myCmd As New oledb.oledbCommand(szSQL, myconn)
    'Dim datareader As oledb.oledbDataReader = Nothing

    'cbFile.Items.Clear()

    'myconn.Open()
    'datareader = myCmd.ExecuteReader()

    'While datareader.Read()
    '    szFileName = datareader("data_filename")

    '    'dwJobIndex = GetJobID(BankInfo.Id, szFileName, lngJobIdTemp)
    '    'If (dwJobIndex <> -1) Then
    '    '    dwFileType = arJobInfo(dwJobIndex).FileType

    '    '    If (dwFileType = cbType.SelectedIndex) Or (cbType.SelectedIndex = 0) Then
    '    cbFile.Items.Add(szFileName)
    '    '    End If
    '    'End If

    'End While
    'datareader.Close()
    'myconn.Close()

    'End Sub
    'Edit By azuwa kasnan 27102013
    Private Sub cbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbType.SelectedValueChanged, cbDeliveryType.SelectedValueChanged, cbFileDate.SelectedValueChanged
        If (cbFileDate.Text = "") Then
            Exit Sub
        End If
        If (cbDeliveryType.Text = "") Then
            Exit Sub
        End If
        If (cbType.Text = "") Then
            Exit Sub
        End If
        RefreshFileName(cbType.SelectedItem.ToString)
    End Sub

    'Private Sub cbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbType.SelectedValueChanged
    'If (cbFileDate.Items.Count = 0) Then
    'Exit Sub
    ' End If

    'If cbDeliveryType.Text = "" Then Exit Sub

    Private Sub RefreshFileName(ByVal szFiletype As String)
        'Get all report file name in TempReport table
        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Dim szSQL As String

        'Dim dwJobIndex As Integer
        'Dim lngJobIdTemp As Long
        'Dim dwFileType As Integer
        Dim szFileName As String

        'szSQL = "SELECT DISTINCT(data_batch_id) FROM data WHERE data_filedate='" & cbFileDate.SelectedItem.ToString & "' ORDER BY data_batch_id"
        szSQL = "SELECT DISTINCT(data_filename) FROM data WHERE data_filedate='" & cbFileDate.SelectedItem.ToString & "' AND data_filetype='" & cbType.SelectedItem.ToString & "' AND Field7='" & cbDeliveryType.Text & "' ORDER BY data_filename"

        Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
        Dim datareader As OleDb.OleDbDataReader = Nothing

        cbFile.Items.Clear()

        myconn.Open()
        datareader = myCmd.ExecuteReader()

        While datareader.Read()
            szFileName = datareader("data_filename")

            'dwJobIndex = GetJobID(BankInfo.Id, szFileName, lngJobIdTemp)
            'If (dwJobIndex <> -1) Then
            '    dwFileType = arJobInfo(dwJobIndex).FileType

            '    If (dwFileType = cbType.SelectedIndex) Or (cbType.SelectedIndex = 0) Then
            cbFile.Items.Add(szFileName)
            '    End If
            'End If

        End While
        datareader.Close()
        myconn.Close()

    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Try
            Dim dwIndex As Integer
            Dim boolSelected As Boolean = False
            Dim szCourierType As String = Trim(cbDeliveryType.Text)
            Dim szNewCourierType As String

            For dwIndex = 0 To lvField.Items.Count - 1
                If (lvField.Items(dwIndex).Selected = True) Then
                    boolSelected = True
                    Exit For
                End If
            Next

            If (boolSelected = False) Then
                MessageBox.Show("No record selected for courier type changes.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim szMessage As String
            Dim dwResponse As Integer
            szNewCourierType = InputBox("Please provide the new Courier Code?", "Change Courier")
            If szNewCourierType = "" Then Exit Sub

            szMessage = "Are you sure to change the courier type from " & szCourierType & " to " & szNewCourierType & " for the selected records? Press 'YES' to proceed and 'NO' to abort."

            dwResponse = MessageBox.Show(szMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (dwResponse = vbNo) Then
                Exit Sub
            End If

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            myconn.Open()
            myCmd.Connection = myconn

            For dwIndex = 0 To lvField.Items.Count - 1
                If (lvField.Items(dwIndex).Selected = True) Then
                    'Update the record information
                    boolSelected = True
                    myCmd.CommandText = "exec sp_updatecourier '" & cbFileDate.SelectedItem.ToString & "','" & lvField.Items(dwIndex).SubItems(2).Text & "','" & szNewCourierType & "'"
                    myCmd.ExecuteNonQuery()
                    UpdateAuditLog("Change courier code for " & lvField.Items(dwIndex).SubItems(2).Text & " to " & szNewCourierType & " in file " & cbFile.SelectedItem.ToString, "Production")
                End If
            Next

            If (boolSelected = False) Then
                myconn.Close()
                MessageBox.Show("No record selected for courier type changes.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            myconn.Close()

            MessageBox.Show("Courier type has been changed for the selected records.", "Change Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadData(cbFile.SelectedItem.ToString, szCourierType)


        Catch ex As Exception

        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub cbDeliveryType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeliveryType.SelectedValueChanged, cbFileDate.SelectedValueChanged
        cbFile.Items.Clear()
        If cbType.Items.Count > 0 Then
            cbType.SelectedIndex = 1
        End If
    End Sub

    Private Sub btnExportCN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportCN.Click
        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnAll.Enabled = False
            btnSelected.Enabled = False
            btnChange.Enabled = False
            btnClose.Enabled = False

            Dim szCNtype As String = cbDeliveryType.Text
            If szCNtype = "" Then Exit Sub
            Dim i As Integer
            Dim dwcount As Integer

            Dim szExportCNFileName As String = ""
            Dim szBatchID As String
            Dim dwFileNum As Integer = FreeFile()

            Dim dwRecCNT As Long = 0
            Dim dwTotalCNT As Long = 0

            Dim szFileType As String

            If GetUploadFileFld(szCNtype) = False Then Exit Sub

            dwcount = cbFile.Items.Count - 1
            For i = 0 To dwcount
                szBatchID = cbFile.Items.Item(i)

                'kelv-get filetype from field 27
                'if filetype = first 2 or first 3 char of batchID do not create initial
                szFileType = GetFieldDataSQL("SELECT * FROM Data where data_filename='" & szBatchID & "' and Field7='" & szCNtype & "'", "Field27")
                If Trim(szFileType) = "" Then
                    szFileType = "GAC"
                End If
                If szFileType = Mid(szBatchID, 1, 2) Or szFileType = Mid(szBatchID, 1, 3) Then
                    szFileType = ""
                End If

                szExportCNFileName = BankInfo.Folder_Ready & Trim(szFileType) & szBatchID & ".txt"
                FileOpen(dwFileNum, szExportCNFileName, OpenMode.Output)
                FormatFileHeaderTrailer(szHeaderDetails, dwFileNum, 0)
                dwRecCNT = FormatFileDetails(szDetails, szBatchID, dwFileNum, szFieldCheck, True)
                UpdateAuditLog("Export CN with records " & dwRecCNT & " from file " & szBatchID, "Production")
                dwTotalCNT += dwRecCNT
                FormatFileHeaderTrailer(szTrailerDetails, dwFileNum, dwTotalCNT)
                FileClose(dwFileNum)
            Next i

            MessageBox.Show(szExportCNFileName & " has export completed!")
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            btnAll.Enabled = True
            btnSelected.Enabled = True
            btnChange.Enabled = True
            btnClose.Enabled = True
        End Try

    End Sub

    Private Function GetUploadFileFld(ByVal szCNType As String) As Boolean
        Try
            Dim myconn As New OleDb.OleDbConnection()
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myCmd.CommandText = "exec sp_extractuploaddetails '" & szCNType & "'"
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    szHeaderDetails = IIf(IsDBNull(datareader("uf_header")), "", datareader("uf_header"))
                    szDetails = IIf(IsDBNull(datareader("uf_details")), "", datareader("uf_details"))
                    szTrailerDetails = IIf(IsDBNull(datareader("uf_footer")), "", datareader("uf_footer"))
                    szFieldCheck = IIf(IsDBNull(datareader("uf_check_field")), "", datareader("uf_check_field"))
                    '**********************************
                End While
            Else
                MsgBox("There is no field defined for upload file!")
                Return False
            End If
            Return True

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmScan.GetUploadField[" & szCNType & "]: Exception-" & ex.Message)
        End Try
    End Function

    '20130905 Added by Azuwa
    '20130910 Edited by Felix
    Private Sub btnExportPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportPL.Click
        Dim myconn As New OleDb.OleDbConnection()
        Dim szINIPath As String = Application.StartupPath & "\Config.ini"
        Dim objIniFile As New IniFile(szINIPath)
        Dim szPath As String
        Dim szStateList As String
        Dim szCmd As String
        Try
            'szCmd = objIniFile.GetString("Command", "Cmd", "")
            szPath = objIniFile.GetString("Path", "Path", "")
            szStateList = objIniFile.GetString("State", "States", "")

            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            'myCmd.CommandText = "exec sp_selectcn '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "','',1"
            'myCmd.ExecuteNonQuery()

            'myCmd.CommandText = "exec sp_updateprint '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            'myCmd.ExecuteNonQuery()

            'myCmd.CommandText = "Select * From TempCN Where StationId='" & gszStationId & "'"
            szCmd = "SELECT * FROM dbo.TempPrint Where field4='True' and StationId='" & gszStationId & "'"
            myCmd.CommandText = szCmd
            datareader = myCmd.ExecuteReader()

            'Dim xlAppToUpload As Excel.Application = CType(CreateObject("Excel.Application"), Excel.Application)
            'xlAppToUpload.Visible = True
            'xlAppToUpload.Workbooks.Add()

            'Dim xlWorkSheetToUpload As Excel.Worksheet
            'xlWorkSheetToUpload = CType(xlAppToUpload.ActiveSheet, Excel.Worksheet)

            '20130917 Edited by Felix
            Dim xlAppToUpload As Excel.Application
            Dim xlWorkBookToUpload As Excel.Workbook
            Dim xlWorkSheetToUpload As Excel.Worksheet

            xlAppToUpload = New Excel.Application
            xlAppToUpload.Visible = False
            xlWorkBookToUpload = xlAppToUpload.Workbooks.Add()
            xlWorkSheetToUpload = xlWorkBookToUpload.ActiveSheet

            '20130910 Added by Felix Tan
            xlWorkSheetToUpload.Name = "Address"
            'Testing
            Dim Address1 As String = ""
            Dim AddressL6 As String = ""
            Dim AddressL7 As String = ""
            Dim AddressL8 As String = ""
            Dim AddressL9 As String = ""
            Dim Address2 As String = ""
            Dim State As String = ""
            Dim CDSNumber1 As String = ""
            Dim CDSNumber2 As String = ""
            Dim PostcodeState As String = ""
            Dim Country As String = ""
            Dim Postcode As String = ""
            Dim regexPostcodeState As New Regex("([0-9]{5,6} [a-zA-Z,.'0-9 ]{0,}$)")
            Dim regexPostcode As New Regex("(^[0-9 ]{5,6})")
            Dim regexCDSNumber As New Regex("([0-9]{11}$)")
            Dim regexState As New Regex("( [a-zA-Z,.' ]{0,})")
            Dim regexCountry As New Regex("(MYS|MY|MALAYSIA)")
            Dim regexStateList As New Regex("(" + szStateList + ")$")
            Dim m As Match = regexCDSNumber.Match(AddressL6)
            Dim m2 As Match = regexCountry.Match(State)
            Dim m3 As Match = regexStateList.Match(State)

            Dim iRowCnt As Integer = 0

            Try
                If datareader.HasRows Then
                    iRowCnt = 2

                    With xlWorkSheetToUpload                   ' SHOW COLUMNS ON THE TOP.
                        .Cells(iRowCnt - 1, 1).value = "Name"
                        .Cells(iRowCnt - 1, 2).value = "Address1"
                        .Cells(iRowCnt - 1, 3).value = "Address2"
                        .Cells(iRowCnt - 1, 4).value = "Postcode"
                        .Cells(iRowCnt - 1, 5).value = "City"
                        .Cells(iRowCnt - 1, 6).value = "State"
                        .Cells(iRowCnt - 1, 7).value = "Country"
                        .Cells(iRowCnt - 1, 8).value = "ContactPerson"
                        .Cells(iRowCnt - 1, 9).value = "PhoneNo"
                        .Cells(iRowCnt - 1, 10).value = "FaxNo"
                        .Cells(iRowCnt - 1, 11).value = "Email"
                        .Cells(iRowCnt - 1, 12).value = "ReferenceNo"
                        .Cells(iRowCnt - 1, 13).value = "Group"

                        While datareader.Read()
                            '20130910 Added by Felix
                            Address1 = datareader.Item("Line05")
                            'Read and remove CDS Number 1
                            CDSNumber1 = datareader.Item("Field2")
                            Address1 = Replace(Address1, CDSNumber1, "").Trim
                            AddressL6 = datareader.Item("Line06")
                            'Check CDS Number 2
                            m = regexCDSNumber.Match(AddressL6)
                            CDSNumber2 = IIf(m.Success, m.ToString, "")
                            'Address1 = IIf(m.Success, Address1 + "     " + CDSNumber2, Address1)
                            'AddressL6 = IIf(m.Success, Replace(AddressL6, CDSNumber2, "").Trim, AddressL6.Trim)
                            If m.Success Then
                                AddressL6 = Replace(AddressL6, CDSNumber2, "").Trim
                            Else
                                AddressL6 = AddressL6.Trim
                            End If
                            AddressL7 = IIf(String.IsNullOrEmpty(datareader.Item("Line07").Trim), "", "," + Trim(datareader.Item("Line07")))
                            AddressL8 = IIf(String.IsNullOrEmpty(datareader.Item("Line08").Trim), "", "," + Trim(datareader.Item("Line08")))
                            AddressL9 = IIf(String.IsNullOrEmpty(datareader.Item("Line09").Trim), "", "," + Trim(datareader.Item("Line09")))
                            Address2 = AddressL6 + AddressL7 + AddressL8 + AddressL9
                            m = regexPostcodeState.Match(Address2)
                            PostcodeState = IIf(m.Success, m.ToString, "")
                            'Address2 = IIf(m.Success, Replace(Address2, "," + PostcodeState, ""), Address2)
                            If m.Success Then
                                Address2 = Replace(Address2, "," + PostcodeState, "")
                                Address2 = Replace(Address2, PostcodeState, "")
                            End If
                            m = regexPostcode.Match(PostcodeState)
                            Postcode = IIf(m.Success, m.ToString.Trim, "")
                            m = regexState.Match(PostcodeState)
                            State = IIf(m.Success, m.ToString.Trim, "")
                            m2 = regexCountry.Match(State)
                            'State = IIf(m2.Success, Replace(State, m2.ToString, "").Trim, State) 
                            '(Could return Object reference not set to an instance of an object! All arguments are evaluated before passing to the function)
                            If m2.Success Then
                                State = Replace(State, m2.ToString, "").Trim
                            End If
                            m3 = regexStateList.Match(State)
                            Country = IIf((m2.Success Or m3.Success) And Postcode.Length = 5, "MY", "")
                            If State.Equals("") Then
                                m3 = regexStateList.Match(Address2)
                                If m3.Success Then
                                    State = m3.ToString.Trim
                                    Address2 = Replace(Address2, "," + m3.ToString, "")
                                    Address2 = Replace(Address2, m3.ToString, "")
                                End If
                            End If

                            'Insert data into Excel
                            .Cells(iRowCnt, 1).NumberFormat = "@"
                            .Cells(iRowCnt, 1).value = datareader.Item("Line04")
                            .Cells(iRowCnt, 2).NumberFormat = "@"
                            .Cells(iRowCnt, 2).value = Address1
                            .Cells(iRowCnt, 3).NumberFormat = "@"
                            .Cells(iRowCnt, 3).value = Address2
                            .Cells(iRowCnt, 4).NumberFormat = "@"
                            .Cells(iRowCnt, 4).value = Postcode
                            '.Cells(iRowCnt, 5).value = regexCity.Match(PostcodeState).ToString
                            .Cells(iRowCnt, 6).NumberFormat = "@"
                            .Cells(iRowCnt, 6).value = State
                            .Cells(iRowCnt, 7).NumberFormat = "@"
                            .Cells(iRowCnt, 7).value = Country
                            '.Cells(iRowCnt, 8).value = datareader.Item("Field3")
                            '.Cells(iRowCnt, 9).value = Regex.Split(datareader.Item("Line01"), "\s{3,}")(1)
                            .Cells(iRowCnt, 10).NumberFormat = "@"
                            .Cells(iRowCnt, 10).value = "N/A      " & CDSNumber2
                            '.Cells(iRowCnt, 11).value = datareader.Item("Line09")
                            .Cells(iRowCnt, 12).NumberFormat = "@"
                            .Cells(iRowCnt, 12).value = CDSNumber1
                            '.Cells(iRowCnt, 13).value = datareader.Item("Line09")
                            iRowCnt = iRowCnt + 1
                        End While

                    End With
                End If
                datareader.Close()
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            Try
                'xlWorkSheetToUpload.SaveAs(szPath + cbFile.SelectedItem.ToString + ".xls")
                xlWorkBookToUpload.SaveAs(szPath + cbFile.SelectedItem.ToString + ".xls")
                xlWorkBookToUpload.Close()
                xlAppToUpload.Quit()
                '20130910 Added by Felix
                Marshal.ReleaseComObject(xlWorkSheetToUpload)
                Marshal.ReleaseComObject(xlAppToUpload.Workbooks)
                Marshal.ReleaseComObject(xlAppToUpload)
                xlWorkSheetToUpload = Nothing
                xlWorkBookToUpload = Nothing
                xlAppToUpload = Nothing

                MessageBox.Show(cbFile.SelectedItem.ToString & " has export completed!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                '20130910 Added by Felix
                GC.Collect()
                Dim proc As System.Diagnostics.Process
                For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                    proc.Kill()
                Next
            End Try


        Catch ex As Exception
            MessageBox.Show("Connection Time Out: Exception-" & ex.Message)
        End Try

    End Sub



End Class