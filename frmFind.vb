Imports System.Data
Imports System.IO
Imports System.Xml

Public Class frmFind
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
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstFile As System.Windows.Forms.ListBox
    Friend WithEvents lbCount As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbAlgorithm As System.Windows.Forms.Label
    Friend WithEvents lbBIN As System.Windows.Forms.Label
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvStatus As System.Windows.Forms.ListView
    Friend WithEvents cbField As System.Windows.Forms.ComboBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lvField As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstErrorFile As System.Windows.Forms.ListBox
    Friend WithEvents lbRecNo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFind))
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbCount = New System.Windows.Forms.Label
        Me.lstFile = New System.Windows.Forms.ListBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lbAlgorithm = New System.Windows.Forms.Label
        Me.lbBIN = New System.Windows.Forms.Label
        Me.lbName = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvStatus = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.lbRecNo = New System.Windows.Forms.Label
        Me.cbField = New System.Windows.Forms.ComboBox
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lvField = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.lstErrorFile = New System.Windows.Forms.ListBox
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(216, 360)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&Find Now"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(304, 360)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbCount
        '
        Me.lbCount.BackColor = System.Drawing.Color.Transparent
        Me.lbCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCount.ForeColor = System.Drawing.Color.Black
        Me.lbCount.Location = New System.Drawing.Point(32, 91)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(137, 16)
        Me.lbCount.TabIndex = 10
        Me.lbCount.Text = "File found:"
        '
        'lstFile
        '
        Me.lstFile.Location = New System.Drawing.Point(32, 111)
        Me.lstFile.Name = "lstFile"
        Me.lstFile.Size = New System.Drawing.Size(521, 186)
        Me.lstFile.Sorted = True
        Me.lstFile.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(32, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(312, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Bank information:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(156, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 23)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = " :"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 324)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 23)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Find criteria"
        '
        'lbAlgorithm
        '
        Me.lbAlgorithm.BackColor = System.Drawing.Color.Transparent
        Me.lbAlgorithm.Location = New System.Drawing.Point(448, 36)
        Me.lbAlgorithm.Name = "lbAlgorithm"
        Me.lbAlgorithm.Size = New System.Drawing.Size(127, 23)
        Me.lbAlgorithm.TabIndex = 53
        Me.lbAlgorithm.Text = "lbAlgorithm"
        '
        'lbBIN
        '
        Me.lbBIN.BackColor = System.Drawing.Color.Transparent
        Me.lbBIN.Location = New System.Drawing.Point(176, 56)
        Me.lbBIN.Name = "lbBIN"
        Me.lbBIN.Size = New System.Drawing.Size(127, 23)
        Me.lbBIN.TabIndex = 52
        Me.lbBIN.Text = "lbBIN"
        '
        'lbName
        '
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Location = New System.Drawing.Point(176, 36)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(127, 23)
        Me.lbName.TabIndex = 51
        Me.lbName.Text = "lbName"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(428, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = " :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(156, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 23)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = " :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(156, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = " :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "File algorithm"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Bank BIN"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Bank name"
        '
        'lvStatus
        '
        Me.lvStatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvStatus.Location = New System.Drawing.Point(32, 110)
        Me.lvStatus.MultiSelect = False
        Me.lvStatus.Name = "lvStatus"
        Me.lvStatus.Size = New System.Drawing.Size(522, 237)
        Me.lvStatus.TabIndex = 62
        Me.lvStatus.UseCompatibleStateImageBehavior = False
        Me.lvStatus.View = System.Windows.Forms.View.Details
        Me.lvStatus.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Status"
        Me.ColumnHeader1.Width = 502
        '
        'lbRecNo
        '
        Me.lbRecNo.Location = New System.Drawing.Point(32, 400)
        Me.lbRecNo.Name = "lbRecNo"
        Me.lbRecNo.Size = New System.Drawing.Size(516, 17)
        Me.lbRecNo.TabIndex = 63
        Me.lbRecNo.Text = "Current Record: 0"
        '
        'cbField
        '
        Me.cbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbField.Location = New System.Drawing.Point(179, 321)
        Me.cbField.Name = "cbField"
        Me.cbField.Size = New System.Drawing.Size(148, 21)
        Me.cbField.TabIndex = 70
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(333, 321)
        Me.txtValue.MaxLength = 50
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(221, 21)
        Me.txtValue.TabIndex = 71
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lvField
        '
        Me.lvField.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvField.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lvField.FullRowSelect = True
        Me.lvField.GridLines = True
        Me.lvField.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvField.Location = New System.Drawing.Point(32, 110)
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(522, 237)
        Me.lvField.TabIndex = 72
        Me.lvField.UseCompatibleStateImageBehavior = False
        Me.lvField.View = System.Windows.Forms.View.Details
        Me.lvField.Visible = False
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "#"
        Me.ColumnHeader2.Width = 32
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Field"
        Me.ColumnHeader3.Width = 198
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Value"
        Me.ColumnHeader4.Width = 268
        '
        'lstErrorFile
        '
        Me.lstErrorFile.FormattingEnabled = True
        Me.lstErrorFile.Location = New System.Drawing.Point(517, 388)
        Me.lstErrorFile.Name = "lstErrorFile"
        Me.lstErrorFile.Size = New System.Drawing.Size(35, 17)
        Me.lstErrorFile.TabIndex = 73
        Me.lstErrorFile.Visible = False
        '
        'frmFind
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(587, 448)
        Me.Controls.Add(Me.lstErrorFile)
        Me.Controls.Add(Me.lvField)
        Me.Controls.Add(Me.lvStatus)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.cbField)
        Me.Controls.Add(Me.lbRecNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbAlgorithm)
        Me.Controls.Add(Me.lbBIN)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbCount)
        Me.Controls.Add(Me.lstFile)
        Me.Controls.Add(Me.btnOK)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find file"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try
            ErrorProvider1.SetError(lstFile, "")

            If (lstFile.SelectedIndex = -1) Then
                ErrorProvider1.SetError(lstFile, "File not selected.")
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnOK.Enabled = False
            btnClose.Enabled = False
            lstFile.Visible = False
            lvStatus.Visible = True

            Dim szInputFileName As String
            Dim szFileName As String

            'Prepare all file path for the current file
            szInputFileName = BankInfo.Folder_Input & lstFile.SelectedItem.ToString
            szFileName = lstFile.SelectedItem.ToString

            AddStatusItem("Start processing: " & szFileName & "...")

            'STEP 1: ParseXML and verify data in database
            'STEP 2: Output result    -> Database

            'Perform file content verification and parsing the content
            Dim dwIndex As Long
            Dim szError As String = ""
            Dim lngJobId As Long = -1

            If (LoadAllJobInfo(BankInfo.Id, 2, szError) = False) Then
                Exit Sub
            End If

            For dwIndex = 1 To UBound(arJobInfo)
                If UCase(Mid(lstFile.Text, arJobInfo(dwIndex).FileStartPos, arJobInfo(dwIndex).FileLength)) = UCase(arJobInfo(dwIndex).FileIDF) Then
                    lngJobId = arJobInfo(dwIndex).Id
                    Exit For
                End If
            Next

            If (lngJobId = -1) Then
                Exit Sub
            End If

            If (VerifyAndParseData_Find(szInputFileName, lngJobId, lbRecNo, lsterrorfile) = False) Then
                GoTo Done
            End If

            'Perform data formatting and output to EXT_9K output file
            AddStatusItem("(" & szFileName & ")  Searching match...")

            '5486 3720 0061 9135 
            Dim szId As String
            Dim szName As String
            Dim szValue As String
            Dim dwCount As Integer = 1
            Dim boolFound As Boolean = False

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myconn_1 As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            Dim datareader As oledb.oledbDataReader = Nothing
            Dim myCmd_1 As New oledb.oledbCommand
            Dim datareader_1 As oledb.oledbDataReader = Nothing

            myconn.Open()
            myconn_1.Open()
            myCmd.Connection = myconn
            myCmd_1.Connection = myconn_1

            myCmd.CommandText = "SELECT data_card_id FROM Data WHERE data_element_name='" & cbField.Text & "' AND data_element_value LIKE '%" & txtValue.Text & "%' Order by data_card_id ASC"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            While datareader.Read()
                szId = IIf(IsDBNull(datareader("data_card_id")), "", datareader("data_card_id"))

                myCmd_1.CommandText = "SELECT data_element_name, data_element_value FROM Data WHERE data_card_id='" & szId & "' Order by data_card_id ASC"
                datareader_1 = myCmd_1.ExecuteReader()

                While datareader_1.Read()
                    szName = IIf(IsDBNull(datareader_1("data_element_name")), "", datareader_1("data_element_name"))
                    szValue = IIf(IsDBNull(datareader_1("data_element_value")), "", datareader_1("data_element_value"))

                    Dim lvItem As New ListViewItem(CStr(dwCount))
                    lvItem.SubItems.Add(szName)
                    lvItem.SubItems.Add(szValue)

                    lvField.Items.Add(lvItem)
                End While

                datareader_1.Close()
                dwCount += 1
                boolFound = True
            End While

            datareader.Close()
            myconn.Close()

            If (boolFound = True) Then
                lvField.Visible = True
            End If

            'Encrypt the input file and move to Backup folder
            AddStatusItem("(" & szFileName & ")  loaded and searched.")

Done:
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            btnOK.Enabled = True
            btnClose.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            lstFile.Visible = True
            lvStatus.Visible = False
            btnOK.Enabled = True
            btnClose.Enabled = True
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub frmOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnOK.Enabled = False

            Dim szIssuerPath As String

            'get all files from the selected folder
            lbName.Text = BankInfo.BankName
            lbBIN.Text = BankInfo.Bin

            Select Case BankInfo.Algorithm
                Case BANK_ENCRYPT_ALGORITHM.PLAINTEXT
                    lbAlgorithm.Text = "Plain Text"
                Case BANK_ENCRYPT_ALGORITHM.DCQSS
                    lbAlgorithm.Text = "DCQSS"
                Case BANK_ENCRYPT_ALGORITHM.EMVES
                    lbAlgorithm.Text = "EMVES"
                Case Else
                    lbAlgorithm.Text = "Unknown"
            End Select

            szIssuerPath = BankInfo.Folder_Input

            If (szIssuerPath <> "") Then
                Dim szFileCollection() As String
                Dim dwIndex As Integer
                Dim dwCount As Integer = 0

                szFileCollection = Directory.GetFiles(szIssuerPath)

                For dwIndex = 0 To UBound(szFileCollection)
                    lstFile.Items.Add(Path.GetFileName(szFileCollection(dwIndex)))
                    dwCount += 1
                Next

                If (dwCount > 0) Then
                    lstFile.SelectedIndex = 0
                    LoadAllField()

                    btnOK.Enabled = True
                End If

                lbCount.Text = "Total file found: " & CStr(dwCount)

            End If

        Catch ex As Exception
            btnOK.Enabled = False
            MessageBox.Show("frmOpen_Load: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllField()
        Try
            'Retrieve format field tie to the job_id
            Dim dwId As Long = -1
            Dim dwIndex As Long
            Dim szName As String = ""
            Dim szError As String = ""

            If (LoadAllJobInfo(BankInfo.Id, 2, szError) = False) Then
                Exit Sub
            End If

            For dwIndex = 1 To UBound(arJobInfo)
                If UCase(Mid(lstFile.Text, arJobInfo(dwIndex).FileStartPos, arJobInfo(dwIndex).FileLength)) = UCase(arJobInfo(dwIndex).FileIDF) Then
                    ' dwId = arJobInfo(dwIndex).FormatSetupId
                    Exit For
                End If
            Next

            If (dwId = -1) Then
                Exit Sub
            End If

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            myCmd.Connection = myconn

            myCmd.CommandText = "SELECT fmt_field_name, fmt_field_desc, fmt_field_seq FROM Format WHERE fs_id=" & CStr(dwId) & " Order by fmt_field_seq ASC"
            datareader = myCmd.ExecuteReader()

            cbField.Items.Clear()

            While datareader.Read()
                szName = IIf(IsDBNull(datareader("fmt_field_name")), "", datareader("fmt_field_name"))
                cbField.Items.Add(szName)
            End While

            datareader.Close()
            myconn.Close()

            If (cbField.Items.Count > 0) Then
                cbField.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("frmFind_LoadAllField: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddStatusItem(ByVal szStatus As String)

        Try
            Dim lvItem As New ListViewItem(szStatus)
            lvStatus.Items.Add(lvItem)
            lvStatus.Update()

        Catch ex As Exception
            MessageBox.Show("frmFind_AddStatusItem: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub lstFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstFile.Click
        LoadAllField()
    End Sub

End Class
