
Public Class frmAuditLogPrint

    Private Function GetReportSQL(ByRef szReportName As String) As String
        GetReportSQL = ""
        Try
            Dim szReportStartDate As String
            Dim szReportEndDate As String
            Dim szReportType As String = ""
            Dim szUserName As String = ""
            Dim szReportSelection As String
            Dim dtStartDateTime As DateTime
            Dim dtEndDateTime As DateTime

            Dim szSQL As String = ""
            dtStartDateTime = Trim(dtPickerStartDate.Text)
            szReportStartDate = dtStartDateTime.ToString("MM/dd/yyyy")
            dtEndDateTime = Trim(dtPickerEndDate.Text)
            szReportEndDate = dtEndDateTime.ToString("MM/dd/yyyy")

            szReportType = Trim(cmbReportType.Text)
            szUserName = Trim(cmbUserName.Text)

            If szReportType <> "" And szUserName <> "" And dtStartDateTime <= dtEndDateTime Then
                If StrComp(szReportType, "All", 1) = 0 Then
                    If StrComp(szUserName, "All", 1) = 0 Then
                        szReportSelection = "Select * from AuditLog where "
                        szReportName = "All Activity Report for all userid from "
                    Else
                        szReportSelection = "Select * from AuditLog where USERID='" & szUserName & "' and "
                        szReportName = "All Activity Report for " & szUserName & " from "
                    End If
                Else
                    If StrComp(szUserName, "All", 1) = 0 Then
                        szReportSelection = "Select * from AuditLog where RepType='" & szReportType & "' and "
                        szReportName = szReportType & " Activity Report for all userid from "
                    Else
                        szReportSelection = "Select * from AuditLog where RepType='" & szReportType & "' and USERID='" & szUserName & "' and "
                        szReportName = szReportType & " Activity Report for " & szUserName & " from "
                    End If
                End If

                szReportName = szReportName & szReportStartDate & " to " & szReportEndDate
                szReportStartDate = szReportStartDate & " " & "0:0:0" 'StartTime
                szReportEndDate = szReportEndDate & " " & "23:59:59" 'EndTime
                szSQL = szReportSelection & "DateLog >= '" & szReportStartDate & "' And DateLog <= '" & szReportEndDate & "' Order By DateLog, USERID"
                Return szSQL
            Else
                MsgBox("Please specify all the report definition first!", MsgBoxStyle.Information, "CIS")
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub btnGetReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetReport.Click
        Dim myconn As New OleDb.OleDbConnection()
        Try
            Dim szReportName As String = ""
            Dim szSQL As String = GetReportSQL(szReportName)
            If szSQL = "" Then Exit Sub

            Dim szFileName As String = ""
            szFileName = BankInfo.Folder_Report & "\AuditLog.rpt"

            If (IsFileExist(szFileName) = False) Then
                MessageBox.Show("Report file is missing from the following location: " & szFileName, "CIS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(szFileName)

            myconn.ConnectionString = gszConnString

            UpdateAuditLog("Print Audit Log Report - " & szReportName, "Production")

            'Dim strSQL As String = "Select * From AuditLog Where DateLog<=#13/11/2008 0:0:0#"
            Dim DA As New OleDb.OleDbDataAdapter(szSQL, myconn)
            Dim DS As New DataSet

            DA.Fill(DS, "AuditLog")
            objReport.SetDataSource(DS.Tables("AuditLog"))
            objReport.SummaryInfo.ReportTitle = szReportName

            'Collated' in this context has nothing to do with database collation.  
            'Some advanced printers (like copier/printers) will sort each document into its own shelf.  
            'Not every printer supports this functionality, so check the printer dialog before setting to true.  
            'To print the entire report, set startpage and endpage each to 0. 
            'change the printer name at run time
            'objReport.PrintOptions.PrinterName = "CutePDF Writer"
            'objReport.PrintToPrinter(1, False, 0, 0)
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            CrystalReportViewer1.Show()

            DA = Nothing
            DS = Nothing

        Catch ex As System.Exception
            MessageBox.Show("frmExceptionRpt_btnGetReport_Click: Exception-" & ex.Message)
        Finally
            myconn.Close()
        End Try
    End Sub

    Private Sub frmAuditLogPrint_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmAuditLogPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Print Audit Log Report", "Audit Log")

        Dim myconn As New OleDb.OleDbConnection()
        Try
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim szUserName As String

            'list all access group from db to access group combo box
            cmbUserName.Items.Clear()
            cmbUserName.Items.Add("All")
            myCmd.CommandText = "SELECT * FROM Users WHERE usr_bank_id=" & BankInfo.Id & " AND usr_deleted=0"

            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    szUserName = IIf(IsDBNull(datareader("usr_login_id")), "", datareader("usr_login_id"))
                    cmbUserName.Items.Add(szUserName)
                End While
            End If
            datareader.Close()
        Catch ex As Exception
            MessageBox.Show("frmAuditLogPrint.Form_Load Exception-" & ex.Message())
        Finally
            myconn.Close()
        End Try
    End Sub
End Class