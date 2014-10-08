Public Class frmSummary

    Private Sub btnGetReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetReport.Click
        Dim dwOption As Integer = 0
        Dim szFileName As String = ""

        szFileName = BankInfo.Folder_Report & "SummaryReport.rpt"
        If (optAll.Checked = True) Then
            dwOption = 0
        End If

        If (optDaily.Checked = True) Then
            dwOption = 1
        End If

        If (optRenewal.Checked = True) Then
            dwOption = 2
        End If

        'If (optUpgrade.Checked = True) Then
        '    dwOption = 3
        '    szFileName = BankInfo.Folder_Report & "SummaryUpgrade.rpt"
        'End If

        If (optPreEmb1.Checked = True) Then
            dwOption = 4
        End If

        If (optPreEmb2.Checked = True) Then
            dwOption = 5
        End If

        If (optMEB1.Checked = True) Then
            dwOption = 6
        End If

        If (IsFileExist(szFileName) = False) Then
            MessageBox.Show("Report file is missing from the following location: " & szFileName, "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim szSQL As String
            Dim dwReturnRow As Integer

            szSQL = "EXEC sp_extractcourier " & CStr(dwOption) & ",'" & cbFileDate.SelectedItem.ToString & "','" & gszStationId & "'"
            dwReturnRow = ExecuteSQL(szSQL)
            UpdateAuditLog("Print Summary Report for filetype[" & CStr(dwOption) & " and filedate[" & cbFileDate.SelectedItem.ToString & "]", "Production")

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "Select * From TempReport Where StationId='" & gszStationId & "'"
            Dim DA As New OleDb.OleDbDataAdapter(strSQL, myconn)
            Dim DS As New DataSet

            DA.Fill(DS, "TempReport")
            objReport.SetDataSource(DS.Tables("TempReport"))

            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            'Show the report
            CrystalReportViewer1.Show()

        Catch ex As System.Exception
            MessageBox.Show("frmSummary_btnGetReport_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmSummary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UpdateAuditLog("Print Summary Report", "Audit Log")
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