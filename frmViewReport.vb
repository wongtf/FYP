Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmViewReport
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cboFileName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGetReport As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewReport))
        Me.cboFileName = New System.Windows.Forms.ComboBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnGetReport = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cboFileName
        '
        Me.cboFileName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFileName.DropDownWidth = 240
        Me.cboFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFileName.ForeColor = System.Drawing.Color.DarkRed
        Me.cboFileName.Location = New System.Drawing.Point(120, 8)
        Me.cboFileName.Name = "cboFileName"
        Me.cboFileName.Size = New System.Drawing.Size(280, 21)
        Me.cboFileName.TabIndex = 11
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BackColor = System.Drawing.Color.Beige
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 38)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(632, 422)
        Me.CrystalReportViewer1.TabIndex = 13
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Embossing File Name"
        '
        'btnGetReport
        '
        Me.btnGetReport.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGetReport.ForeColor = System.Drawing.Color.White
        Me.btnGetReport.Location = New System.Drawing.Point(408, 8)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(83, 23)
        Me.btnGetReport.TabIndex = 23
        Me.btnGetReport.Text = "&Get Report"
        Me.btnGetReport.UseVisualStyleBackColor = False
        '
        'FrmViewReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(632, 460)
        Me.Controls.Add(Me.btnGetReport)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.cboFileName)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmViewReport"
        Me.Text = "FrmViewReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Structure NgrCode
        Dim NgrCode As String
        Dim TotalCount As Long
    End Structure

    Dim arNgrCode() As NgrCode

    Private Sub FrmViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'show the form caption 
        FrmViewReport.ActiveForm.Text = "Print " & szReportType & " Report"

        'Get all report file name in TempReport table
        Dim strSQL As String
        Dim szFieldName As String

        If szReportType = "Error Report" Then
            strSQL = "SELECT DISTINCT err_Filename from ErrorLog"
            szFieldName = "err_FileName"
        Else
            strSQL = "SELECT DISTINCT FileName FROM TempReport"
            szFieldName = "FileName"
        End If

        cboFileName.Items.Clear()

        Dim myconn As New oledb.oledbConnection(gszConnString)
        Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
        'myconn.ConnectionTimeout = 0
        myCmd.CommandTimeout = 0

        Dim datareader As oledb.oledbDataReader = Nothing

        myconn.Open()
        datareader = myCmd.ExecuteReader()

        While datareader.Read()
            cboFileName.Items.Add(datareader(szFieldName))
        End While
        datareader.Close()
        myconn.Close()

    End Sub

    Private Function GetRingkasan(ByVal szFileName As String) As Boolean

        Try
            Dim strSQL As String = "SELECT * FROM NgrCode"

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0
            myCmd.Connection = myconn
            myCmd.CommandText = strSQL

            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()

            Dim dwi As Integer = 1
            datareader = myCmd.ExecuteReader()

            If (datareader.HasRows = False) Then
                myconn.Close()
                Return False
                Exit Function
            End If

            'Get all negeri code from table
            Erase arNgrCode
            While datareader.Read
                ReDim Preserve arNgrCode(dwi)

                arNgrCode(dwi).NgrCode = datareader("NegeriCode")
                arNgrCode(dwi).TotalCount = 0
                dwi += 1
            End While
            datareader.Close()

            'count the number of cards in each ngrcode
            For dwi = 1 To UBound(arNgrCode)
                strSQL = "SELECT Count(Field1) From TempReport Where Field12 Like '" & arNgrCode(dwi).NgrCode & "%' And FileName='" & szFileName & "'"
                myCmd.CommandText = strSQL
                arNgrCode(dwi).TotalCount = myCmd.ExecuteScalar()
            Next

            'update back the totalcount to db
            For dwi = 1 To UBound(arNgrCode)
                strSQL = "UPDATE NgrCode SET TotalCount=" & arNgrCode(dwi).TotalCount & " WHERE NegeriCode='" & arNgrCode(dwi).NgrCode & "'"
                myCmd.CommandText = strSQL
                myCmd.ExecuteNonQuery()
            Next

            myconn.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("frmViewReport_GetRingkasan: Exception-" & ex.Message)
            Return False
        Finally
        End Try

    End Function

    Private Sub btnGetReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetReport.Click
        Dim szFileName As String

        szFileName = Trim(cboFileName.Text)
        If (szFileName = "") Then Exit Sub

        If (IsFileExist(BankInfo.Folder_Report & szReportFileName & ".rpt") = False) Then
            MessageBox.Show("Report file is missing from the following location: " & BankInfo.Folder_Report & szReportFileName & ".rpt", "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim szTableName As String
        Dim SelectFormula As String = ""

        szTableName = "TempReport"

        'Hardcode this for BSN Ringkasan report
        If (szReportType = "Ringkasan Report") Then
            szTableName = "NgrCode"

            If (GetRingkasan(szFileName) = False) Then
                Exit Sub
            End If
        ElseIf (szReportType = "Error Report") Then
            szTableName = "ErrorLog"
            SelectFormula = "{ErrorLog.err_filename} ='" & szFileName & "'"
        Else
            SelectFormula = "{TempReport.FileName} ='" & szFileName & "'"
        End If

        Try
            'Crystal Report's report document object
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            'Load the report
            objReport.Load(BankInfo.Folder_Report & szReportFileName & ".rpt")

            'Pass in the parameter to report only for BSN Ringkasan Report
            If (szReportType = "Ringkasan Report") Then
                objReport.SetParameterValue("EmbFileName", szFileName)
            Else
                objReport.DataDefinition.RecordSelectionFormula() = SelectFormula
            End If

            Dim myconn As New oledb.oledbConnection(gszConnString)
            'myconn.ConnectionTimeout = 0

            Dim strSQL As String = "Select * From " & szTableName
            Dim DA As New OleDb.OleDbDataAdapter(strSQL, myconn)
            Dim DS As New DataSet

            DA.Fill(DS, szTableName)
            objReport.SetDataSource(DS.Tables(szTableName))

            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = objReport
            CrystalReportViewer1.RefreshReport()

            'Show the report
            CrystalReportViewer1.Show()

        Catch ex As System.Exception
            MessageBox.Show("frmViewReport_btnGetReport_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub FrmViewReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                DialogResult = Windows.Forms.DialogResult.OK
            Case Else
        End Select
    End Sub

End Class
