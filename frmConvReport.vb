Public Class frmConvReport
    Private Sub btnGetReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetReport.Click
        Dim dwOption As Integer = 0
        Dim szFileName As String = BankInfo.Folder_Report & "LoadReportDebit.rpt"

        If (IsFileExist(szFileName) = False) Then
            MessageBox.Show("Report file is missing from the following location: " & szFileName, "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim szSQL As String
            Dim szFileType As String = Trim(cbFileType.Text)
            Dim szFileDate As String = Trim(cbFileDate.Text)

            If szFileType = "" Or szFileDate = "" Then Exit Sub
            szSQL = "SELECT * From Data where data_filetype='" & szFileType & " ' AND data_filedate='" & szFileDate & "' ORDER By data_rec_no"

            UpdateAuditLog("Print Conversion report for file type " & szFileType & " and filedate " & szFileDate, "Production")
            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            'myconn.ConnectionTimeout = 0

            Dim DA As New OleDb.OleDbDataAdapter(szSQL, myconn)
            Dim DS As New DataSet

            DA.Fill(DS, "Data")
            objReport.SetDataSource(DS.Tables("Data"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            CrystalReportViewer1.Show()

        Catch ex As System.Exception
            MessageBox.Show("frmConvReport_btnGetReport_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmConvReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Print Conversion Report", "Audit Log")
        'Get all report file name in TempReport table
        cbFileDate.Items.Clear()
        cbFileType.Items.Clear()

        Dim szSQL As String
        'Select Distinct file date from Data table
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
        Select Case cbFileDate.Items.Count
            Case 0
                cbFileDate.SelectedIndex = -1
            Case 1
                cbFileDate.SelectedIndex = 0
            Case Else
                cbFileDate.SelectedIndex = cbFileDate.Items.Count - 1
        End Select
        '*******************************

        'Select Distinct filetype from Data table
        szSQL = "SELECT DISTINCT(data_filetype) FROM data ORDER BY data_filetype"
        myCmd.CommandText = szSQL
        datareader = myCmd.ExecuteReader()

        While datareader.Read()
            cbFileType.Items.Add(datareader("data_filetype"))
        End While

        datareader.Close()
        Select Case cbFileType.Items.Count
            Case 0
                cbFileType.SelectedIndex = -1
            Case 1
                cbFileType.SelectedIndex = 0
            Case Else
                cbFileType.SelectedIndex = cbFileType.Items.Count - 1
        End Select

        myconn.Close()
    End Sub
End Class