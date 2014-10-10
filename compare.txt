Public Class frmReportHousekeep
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFileGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cboFileDate As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFileName As System.Windows.Forms.ComboBox
    Friend WithEvents optDate As System.Windows.Forms.RadioButton
    Friend WithEvents optName As System.Windows.Forms.RadioButton
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBackupCleanUp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportHousekeep))
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbFileGroup = New System.Windows.Forms.ComboBox
        Me.cboFileDate = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboFileName = New System.Windows.Forms.ComboBox
        Me.optDate = New System.Windows.Forms.RadioButton
        Me.optName = New System.Windows.Forms.RadioButton
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBackupCleanUp = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(310, 168)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(208, 168)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "Clean &up"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, -38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "File group"
        '
        'cmbFileGroup
        '
        Me.cmbFileGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFileGroup.Items.AddRange(New Object() {"BACKUP", "ERROR", "READY"})
        Me.cmbFileGroup.Location = New System.Drawing.Point(80, -41)
        Me.cmbFileGroup.Name = "cmbFileGroup"
        Me.cmbFileGroup.Size = New System.Drawing.Size(152, 21)
        Me.cmbFileGroup.Sorted = True
        Me.cmbFileGroup.TabIndex = 6
        '
        'cboFileDate
        '
        Me.cboFileDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFileDate.Location = New System.Drawing.Point(132, 91)
        Me.cboFileDate.Name = "cboFileDate"
        Me.cboFileDate.Size = New System.Drawing.Size(159, 21)
        Me.cboFileDate.Sorted = True
        Me.cboFileDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(373, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Please select data to be removed."
        '
        'cboFileName
        '
        Me.cboFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFileName.Location = New System.Drawing.Point(132, 121)
        Me.cboFileName.Name = "cboFileName"
        Me.cboFileName.Size = New System.Drawing.Size(261, 21)
        Me.cboFileName.Sorted = True
        Me.cboFileName.TabIndex = 2
        '
        'optDate
        '
        Me.optDate.AutoSize = True
        Me.optDate.Checked = True
        Me.optDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDate.ForeColor = System.Drawing.Color.White
        Me.optDate.Location = New System.Drawing.Point(23, 92)
        Me.optDate.Name = "optDate"
        Me.optDate.Size = New System.Drawing.Size(67, 17)
        Me.optDate.TabIndex = 0
        Me.optDate.TabStop = True
        Me.optDate.Text = "File Date"
        Me.optDate.UseVisualStyleBackColor = True
        '
        'optName
        '
        Me.optName.AutoSize = True
        Me.optName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optName.ForeColor = System.Drawing.Color.White
        Me.optName.Location = New System.Drawing.Point(23, 122)
        Me.optName.Name = "optName"
        Me.optName.Size = New System.Drawing.Size(71, 17)
        Me.optName.TabIndex = 2
        Me.optName.TabStop = True
        Me.optName.Text = "File Name"
        Me.optName.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Items.AddRange(New Object() {"Daily Record", "Error Report"})
        Me.cboType.Location = New System.Drawing.Point(132, 52)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(159, 21)
        Me.cboType.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Report Type"
        '
        'btnBackupCleanUp
        '
        Me.btnBackupCleanUp.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBackupCleanUp.ForeColor = System.Drawing.Color.White
        Me.btnBackupCleanUp.Location = New System.Drawing.Point(119, 156)
        Me.btnBackupCleanUp.Name = "btnBackupCleanUp"
        Me.btnBackupCleanUp.Size = New System.Drawing.Size(83, 35)
        Me.btnBackupCleanUp.TabIndex = 18
        Me.btnBackupCleanUp.Text = "Backup && Clean &up"
        Me.btnBackupCleanUp.UseVisualStyleBackColor = False
        '
        'frmReportHousekeep
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(423, 205)
        Me.Controls.Add(Me.btnBackupCleanUp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.optName)
        Me.Controls.Add(Me.optDate)
        Me.Controls.Add(Me.cboFileName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboFileDate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFileGroup)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportHousekeep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Housekeeping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmReportHousekeep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Data Housekeeping", "Audit Log")
        'cboType.SelectedIndex = 0
    End Sub

    'Private Sub frmReportHousekeep_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    optDate.Checked = True
    'End Sub

    Private Sub LoadReportFile()
        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.Refresh()

            'Get all report file name in TempReport table
            Dim szSQL As String
            Dim szTableName As String
            Dim szFieldName As String

            szTableName = "Data"

            If (optDate.Checked = True) Then
                cboFileDate.Items.Clear()
                szSQL = "SELECT DISTINCT(data_filedate) FROM " & szTableName & " ORDER BY data_filedate"
                szFieldName = "data_filedate"
            Else
                cboFileName.Items.Clear()
                szSQL = "SELECT DISTINCT(data_filename) FROM " & szTableName & " ORDER BY data_filename"
                szFieldName = "data_filename"
            End If

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()

            datareader = myCmd.ExecuteReader()
            cboFileDate.Items.Clear()

            While datareader.Read()
                If (optDate.Checked = True) Then
                    cboFileDate.Items.Add(datareader(szFieldName))
                Else
                    cboFileName.Items.Add(datareader(szFieldName))
                End If
            End While
            datareader.Close()

            myconn.Close()

        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try
            Dim szFileName As String = ""

            Select Case cboType.SelectedIndex
                Case 0
                    If optDate.Checked Then
                        szFileName = Trim(cboFileDate.Text)
                    Else
                        szFileName = Trim(cboFileName.Text)
                    End If
                Case 1
                    szFileName = "Error Report"
            End Select

            If szFileName = "" Then Exit Sub

            Dim dwResponse As Integer

            dwResponse = MessageBox.Show("Are you sure you want to clean up the selected files? This process is irreversible. Click 'YES' to proceed and 'NO' to abort.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (dwResponse = vbNo) Then
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.Refresh()

            Dim strSQL As String = ""
            Dim szAuditStr As String = ""
            Dim szTableName As String = ""

            Select Case cboType.SelectedIndex
                Case 0
                    szTableName = "Data"
                Case 1
                    szTableName = "ErrorLog"
            End Select

            Select Case cboType.SelectedIndex
                Case 0
                    If optDate.Checked Then
                        strSQL = "DELETE FROM " & szTableName & " WHERE data_filedate='" & szFileName & "'"
                        szAuditStr = "DELETE all data from " & szTableName & " with file date[" & szFileName & "]"
                    Else
                        strSQL = "DELETE FROM " & szTableName & " WHERE data_filename='" & szFileName & "'"
                        szAuditStr = "DELETE all data from " & szTableName & " with file name[" & szFileName & "]"
                    End If
                Case 1
                    strSQL = "DELETE FROM " & szTableName
                    szAuditStr = "DELETE all records from " & szTableName
            End Select

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()

            myconn.Close()

            Select Case cboType.SelectedIndex
                Case 0
                    LoadReportFile()
            End Select

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            UpdateAuditLog(szAuditStr, "Production")
            MessageBox.Show("All data in " & szFileName & " has been deleted.", "HouseKeeping", MessageBoxButtons.OK)

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnCleanUpAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dwCount As Long
        Dim szFileName As String
        Dim i As Integer

        Dim dwResponse As Integer

        dwResponse = MessageBox.Show("Are you sure you want to clean up all data? This process is irreversible. Click 'YES' to proceed and 'NO' to abort.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If (dwResponse = vbNo) Then
            Exit Sub
        End If

        dwCount = cboFileDate.Items.Count - 1
        For i = 0 To dwCount

            szFileName = cboFileDate.Items.Item(i) 'Trim(cboFileName.Text)
            If szFileName = "" Then Exit Sub

            Dim strSQL As String
            Dim szTableName As String

            szTableName = "Data"

            strSQL = "TRUNCATE TABLE " & szTableName

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()

            myconn.Close()
            UpdateAuditLog("Delete All records from Data table", "Production")
        Next i
        LoadReportFile()

        MessageBox.Show("All records has been deleted.", "HouseKeeping", MessageBoxButtons.OK)

    End Sub

    Private Sub optDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDate.Click
        LoadReportFile()
        cboFileDate.Focus()
    End Sub

    Private Sub optName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optName.Click
        LoadReportFile()
        cboFileName.Focus()
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        LoadReportFile()
        If (optDate.Checked = True) Then
            cboFileDate.Focus()
        Else
            cboFileName.Focus()
        End If
    End Sub

    Private Sub btnBackupCleanUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackupCleanUp.Click

        Try
            Dim szFileName As String = ""

            szFileName = Trim(cboFileDate.Text)
            If szFileName = "" Then Exit Sub

            Dim dwResponse As Integer

            dwResponse = MessageBox.Show("Are you sure you want to clean up the selected files? This process is irreversible. Click 'YES' to proceed and 'NO' to abort.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (dwResponse = vbNo) Then
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.Refresh()

            Dim strSQL As String = ""
            Dim szAuditStr As String = ""
            Dim szTableName As String = ""
            Dim dwReturnRow As Integer

            strSQL = "sp_BackupData '" & szFileName & "'"
            dwReturnRow = ExecuteSQL(strSQL)

            If dwReturnRow <= 0 Then
                MessageBox.Show("Can't backup data from the selected date " & szFileName & " deletion aborted!")
                Exit Sub
            End If

            szTableName = "Data"

            strSQL = "DELETE FROM " & szTableName & " WHERE data_filedate='" & szFileName & "'"
            szAuditStr = "DELETE all data from " & szTableName & " with file date[" & szFileName & "]"

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            'myconn.ConnectionTimeout = 0
            myCmd.CommandTimeout = 0

            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()

            myconn.Close()

            Select Case cboType.SelectedIndex
                Case 0
                    LoadReportFile()
            End Select

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            UpdateAuditLog(szAuditStr, "Production")
            MessageBox.Show("All data in " & szFileName & " has been deleted.", "HouseKeeping", MessageBoxButtons.OK)

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub
End Class
