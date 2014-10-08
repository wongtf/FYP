Public Class frmCardRetrieval

    Private Sub btnGetReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetReport.Click
        Dim dwOption As Integer = 0
        Dim szFileName As String = ""
        Dim szBatchID As String = ""

        If (optDaily.Checked = True) Then
            dwOption = 0
            szFileName = BankInfo.Folder_Report & "DailyCardRetrieval.rpt"
        End If

        If (optRenewal.Checked = True) Then
            dwOption = 1
            szFileName = BankInfo.Folder_Report & "RenewalCardRetrieval.rpt"
        End If

        If (optME.Checked = True) Then
            dwOption = 2
            szBatchID = Trim(cbMEBatch.Text)
            If szBatchID = "" Then Exit Sub
            szFileName = BankInfo.Folder_Report & "MECardRetrieval.rpt"
        End If

        If (IsFileExist(szFileName) = False) Then
            MessageBox.Show("Report file is missing from the following location: " & szFileName, "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim szSQL As String
            Dim dwReturnRow As Integer

            szSQL = "EXEC sp_extractcardretrieval " & CStr(dwOption) & ",'" & cbFileDate.SelectedItem.ToString & "','" & szBatchID & "'"
            dwReturnRow = ExecuteSQL(szSQL)
            UpdateAuditLog("Print Card Retrieval List for file type[" & CStr(dwOption) & "] and filedate[" & cbFileDate.SelectedItem.ToString & "]", "Audit Log")

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn As New oledb.oledbConnection(gszConnString)
            'myconn.ConnectionTimeout = 0

            Dim strSQL As String = "Select * From Temp_cardretrieval ORDER BY cardtype_desc"
            Dim DA As New OleDb.OleDbDataAdapter(strSQL, myconn)
            Dim DS As New DataSet

            DA.Fill(DS, "Temp_cardretrieval")
            objReport.SetDataSource(DS.Tables("Temp_cardretrieval"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            CrystalReportViewer1.Show()

        Catch ex As System.Exception
            MessageBox.Show("frmCardRetrieval_btnGetReport_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmCardRetrieval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Print Card Retrieval List", "Audit Log")
        'Get all report file name in TempReport table
        cbFileDate.Items.Clear()

        Dim szSQL As String
        szSQL = "SELECT DISTINCT(data_filedate) FROM data ORDER BY data_filedate"

        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
        'myconn.ConnectionTimeout = 0
        myCmd.CommandTimeout = 0

        Dim datareader As OleDb.OleDbDataReader = Nothing
        'myconn.ConnectionTimeout = 0
        myconn.Open()
        datareader = myCmd.ExecuteReader()

        While datareader.Read()
            cbFileDate.Items.Add(datareader("data_filedate"))
        End While

        datareader.Close()
        myconn.Close()

        Select Case cbFileDate.Items.Count
            Case 0
                cbFileDate.SelectedIndex = -1
            Case 1
                cbFileDate.SelectedIndex = 0
            Case Else
                cbFileDate.SelectedIndex = cbFileDate.Items.Count - 1
        End Select

    End Sub

End Class