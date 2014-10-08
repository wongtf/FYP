Public Class frmChangeCNRpt

    Private Sub btnGetReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetReport.Click
        Dim szFileName As String = ""
        szFileName = BankInfo.Folder_Report & "courierchange.rpt"

        If (IsFileExist(szFileName) = False) Then
            MessageBox.Show("Report file is missing from the following location: " & szFileName, "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim szSQL As String
            Dim dwReturnRow As Integer

            szSQL = "EXEC sp_extractcourierchange '" & cbFileDate.SelectedItem.ToString & "','" & gszStationId & "'"
            dwReturnRow = ExecuteSQL(szSQL)

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn As New oledb.oledbConnection(gszConnString)
            'myconn.ConnectionTimeout = 0

            Dim strSQL As String = "Select * From TempReport Where StationId='" & gszStationId & "'"
            Dim DA As New OleDb.OleDbDataAdapter(strSQL, myconn)
            Dim DS As New DataSet

            DA.Fill(DS, "TempReport")
            objReport.SetDataSource(DS.Tables("TempReport"))
            'objReport.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, BankInfo.Folder_Ready & "")
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            CrystalReportViewer1.Show()

        Catch ex As System.Exception
            MessageBox.Show("frmExceptionRpt_btnGetReport_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmCNChangeRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Print Courier Change Report", "Audit Log")
        'Get all report file name in TempReport table
        cbFileDate.Items.Clear()

        Dim szSQL As String
        szSQL = "SELECT DISTINCT(data_file_date) FROM courierchange ORDER BY data_file_date"

        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
        'myconn.ConnectionTimeout = 0
        myCmd.CommandTimeout = 0

        Dim datareader As OleDb.OleDbDataReader = Nothing

        myconn.Open()
        datareader = myCmd.ExecuteReader()

        While datareader.Read()
            cbFileDate.Items.Add(datareader("data_file_date"))
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