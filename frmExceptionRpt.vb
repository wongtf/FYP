Public Class frmExceptionRpt

    Private Sub btnGetReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetReport.Click
        Dim szFileName As String = ""
        szFileName = BankInfo.Folder_Report & "exceptions.rpt"

        If (IsFileExist(szFileName) = False) Then
            MessageBox.Show("Report file is missing from the following location: " & szFileName, "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim szSQL As String
            Dim dwReturnRow As Integer

            szSQL = "EXEC sp_extractexception '" & cbFileDate.SelectedItem.ToString & "','" & gszStationId & "'"
            dwReturnRow = ExecuteSQL(szSQL)

            UpdateAuditLog("Print Exception Report for filedate[" & cbFileDate.SelectedItem.ToString & "]", "Production")
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

            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            CrystalReportViewer1.Show()

        Catch ex As System.Exception
            MessageBox.Show("frmExceptionRpt_btnGetReport_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmExceptionRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Print Exception Report", "Audit Log")
        'Get all report file name in TempReport table
        cbFileDate.Items.Clear()

        Dim szSQL As String
        szSQL = "SELECT DISTINCT(data_filedate) FROM data Where data_DataException='True' ORDER BY data_filedate"


        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
        'myconn.ConnectionTimeout = 0
        myCmd.CommandTimeout = 0

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