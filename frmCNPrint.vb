Imports System.Data
Imports System.IO
Imports System.Xml

Public Class frmCNPrint

    Dim szHeaderDetails As String
    Dim szTrailerDetails As String
    Dim szDetails As String
    Dim szFieldCheck As String

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click

        Try
            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
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

            myCmd.CommandText = "exec sp_updateprint '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            myCmd.ExecuteNonQuery()

            myconn.Close()

            UpdateAuditLog("Print CN for file " & cbFile.SelectedItem.ToString, "Production")
            Dim szFileName As String = ""
            szFileName = BankInfo.Folder_Report & "CNPrint" & szCourierType & ".rpt"
            
            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn1 As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "Select * From TempCN Where StationId='" & gszStationId & "'"
            Dim DA As New oledb.oledbDataAdapter(strSQL, myconn1)
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
            Dim myconn As New oledb.oledbConnection(gszConnString)
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

            myCmd.CommandText = "exec sp_updateprint '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            myCmd.ExecuteNonQuery()

            myconn.Close()

            UpdateAuditLog("Print selected CN for file " & cbFile.SelectedItem.ToString, "Production")

            Dim szFileName As String = ""
            szFileName = BankInfo.Folder_Report & "CNPrint" & szCourierType & ".rpt"

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn1 As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "Select * From TempCN Where StationId='" & gszStationId & "'"
            Dim DA As New oledb.oledbDataAdapter(strSQL, myconn1)
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
            btnRefresh.Enabled = True
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

            If cbType.Items.Count > 0 Then
                cbType.SelectedIndex = 1
            End If

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

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.Refresh()

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            Dim datareader As oledb.oledbDataReader = Nothing

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

            'Retrieve the record information
            myCmd.CommandText = "exec sp_extractprint '" & cbFileDate.Text & "','" & szBatchId & "','" & szCourierId & "','" & gszStationId & "'"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            While datareader.Read()
                szCDSRef = IIf(IsDBNull(datareader("Field2")), "", datareader("Field2"))
                szName = IIf(IsDBNull(datareader("Field3")), "", datareader("Field3"))
                szPAN = IIf(IsDBNull(datareader("Field5")), "", datareader("Field5"))
                szMName = IIf(IsDBNull(datareader("Line04")), "", datareader("Line04"))

                If (Trim(szCDSRef) <> "") Then
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

    Private Sub cbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbType.SelectedValueChanged
        If (cbFileDate.Items.Count = 0) Then
            Exit Sub
        End If

        If cbDeliveryType.Text = "" Then Exit Sub

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

            If GetUploadFileFld(szCNtype) = False Then Exit Sub

            dwcount = cbFile.Items.Count - 1
            For i = 0 To dwcount
                szBatchID = cbFile.Items.Item(i)
                szExportCNFileName = BankInfo.Folder_Ready & szBatchID & ".txt"
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


End Class