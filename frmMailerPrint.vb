Imports System.Data
Imports System.IO
Imports System.Xml

Public Class frmMailerPrint

    Dim szHeaderDetails As String
    Dim szTrailerDetails As String
    Dim szDetails As String
    Dim szFieldCheck As String

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click

        Try
            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnAll.Enabled = False
            btnSelected.Enabled = False
            cbFileDate.Enabled = False
            cbType.Enabled = False
            cbFile.Enabled = False
            btnRefresh.Enabled = False

            'Update the record information
            myconn.Open()
            myCmd.Connection = myconn

            myCmd.CommandText = "exec sp_selectcn '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "','',1"
            myCmd.ExecuteNonQuery()

            'myCmd.CommandText = "exec sp_updateprint '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            'myCmd.ExecuteNonQuery()

            myconn.Close()

            UpdateAuditLog("Print Mailer for file " & cbFile.SelectedItem.ToString, "Production")
            Dim szFileName As String = ""
            szFileName = BankInfo.Folder_Report & "Mailer.rpt"

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn1 As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "Select * From TempPrint WHERE Selected=1 AND fileName='" & cbFile.SelectedItem.ToString & "' AND StationId='" & gszStationId & "' AND Field4='True' ORDER BY Field1"
            Dim DA As New OleDb.OleDbDataAdapter(strSQL, myconn1)
            Dim DS As New DataSet

            DA.Fill(DS, "TempPrint")
            objReport.SetDataSource(DS.Tables("TempPrint"))

            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            CrystalReportViewer1.PrintReport()

        Catch ex As Exception
            MessageBox.Show("frmMailerPrint_btnAll.Click: Exception-" & ex.Message)
        Finally
            btnAll.Enabled = True
            btnSelected.Enabled = True
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

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnAll.Enabled = False
            btnSelected.Enabled = False
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

            'myCmd.CommandText = "exec sp_updateprint '" & cbFile.SelectedItem.ToString & "','" & gszStationId & "'"
            'myCmd.ExecuteNonQuery()

            myconn.Close()

            UpdateAuditLog("Print selected Mailer for file " & cbFile.SelectedItem.ToString, "Production")

            Dim szFileName As String = ""
            szFileName = BankInfo.Folder_Report & "Mailer.rpt"

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn1 As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "Select * From TempPrint WHERE Selected=1 AND fileName='" & cbFile.SelectedItem.ToString & "' AND StationId='" & gszStationId & "' AND Field4='True' ORDER BY Field1"
            '"Select * From TempCN Where StationId='" & gszStationId & "'"
            Dim DA As New OleDb.OleDbDataAdapter(strSQL, myconn1)
            Dim DS As New DataSet

            DA.Fill(DS, "TempPrint")
            objReport.SetDataSource(DS.Tables("TempPrint"))

            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            CrystalReportViewer1.PrintReport()

        Catch ex As Exception
            MessageBox.Show("frmMailerPrint_btnSelected.Click: Exception-" & ex.Message)
        Finally
            btnAll.Enabled = True
            btnSelected.Enabled = True
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

    Private Sub frmMailerPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UpdateAuditLog("Print Mailer ", "Audit Log")
            btnAll.Enabled = False
            btnSelected.Enabled = False

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
            MessageBox.Show("frmMailerPrint_Load: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddStatusItem(ByVal szStatus As String)

        Try
            Dim lvItem As New ListViewItem(szStatus)
            lvField.Items.Add(lvItem)
            lvField.Update()

        Catch ex As Exception
            MessageBox.Show("frmMailerPrint_AddStatusItem: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadData(ByVal szBatchId As String)

        Try
            If (szBatchId = "") Then
                Exit Sub
            End If

            picLoad.Visible = True
            btnAll.Enabled = False
            btnSelected.Enabled = False
            cbFileDate.Enabled = False
            cbType.Enabled = False
            cbFile.Enabled = False
            btnRefresh.Enabled = False

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


            'Retrieve the record information
            myCmd.CommandText = "exec sp_extractmprint '" & cbFileDate.Text & "','" & szBatchId & "','" & gszStationId & "'"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            While datareader.Read()
                szCDSRef = IIf(IsDBNull(datareader("Field2")), "", datareader("Field2"))
                szName = IIf(IsDBNull(datareader("Field3")), "", datareader("Field3"))
                szPAN = IIf(IsDBNull(datareader("Field5")), "", datareader("Field5"))
                szMName = IIf(IsDBNull(datareader("Line05")), "", datareader("Line05"))

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
            cbFileDate.Enabled = True
            cbType.Enabled = True
            cbFile.Enabled = True
            btnRefresh.Enabled = True
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadData(cbFile.SelectedItem.ToString)
    End Sub

    Private Sub cbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbType.SelectedValueChanged
        If (cbFileDate.Items.Count = 0) Then
            Exit Sub
        End If

        'Get all report file name in TempReport table
        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Dim szSQL As String

        'Dim dwJobIndex As Integer
        'Dim lngJobIdTemp As Long
        'Dim dwFileType As Integer
        Dim szFileName As String

        'szSQL = "SELECT DISTINCT(data_batch_id) FROM data WHERE data_filedate='" & cbFileDate.SelectedItem.ToString & "' ORDER BY data_batch_id"
        szSQL = "SELECT DISTINCT(data_filename) FROM data WHERE data_filedate='" & cbFileDate.SelectedItem.ToString & "' AND data_filetype='" & cbType.SelectedItem.ToString & "' ORDER BY data_filename"

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

End Class