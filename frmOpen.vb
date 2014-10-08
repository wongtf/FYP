Imports System.Data
Imports System.IO
Imports System.Xml

Public Class frmOpen
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
    Friend WithEvents lbOutput As System.Windows.Forms.Label
    Friend WithEvents lbInput As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
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
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstErrorFile As System.Windows.Forms.ListBox
    Friend WithEvents lbRecNo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpen))
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbCount = New System.Windows.Forms.Label
        Me.lstFile = New System.Windows.Forms.ListBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbOutput = New System.Windows.Forms.Label
        Me.lbInput = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstErrorFile = New System.Windows.Forms.ListBox
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
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&Load Now"
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
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbCount
        '
        Me.lbCount.BackColor = System.Drawing.Color.Transparent
        Me.lbCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCount.ForeColor = System.Drawing.Color.Black
        Me.lbCount.Location = New System.Drawing.Point(32, 144)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(189, 16)
        Me.lbCount.TabIndex = 10
        Me.lbCount.Text = "File found:"
        '
        'lstFile
        '
        Me.lstFile.Location = New System.Drawing.Point(32, 164)
        Me.lstFile.Name = "lstFile"
        Me.lstFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFile.Size = New System.Drawing.Size(521, 186)
        Me.lstFile.Sorted = True
        Me.lstFile.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(32, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(312, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Bank information:"
        '
        'lbOutput
        '
        Me.lbOutput.BackColor = System.Drawing.Color.Transparent
        Me.lbOutput.ForeColor = System.Drawing.Color.White
        Me.lbOutput.Location = New System.Drawing.Point(176, 108)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(303, 23)
        Me.lbOutput.TabIndex = 60
        Me.lbOutput.Text = "lbOutput"
        '
        'lbInput
        '
        Me.lbInput.BackColor = System.Drawing.Color.Transparent
        Me.lbInput.ForeColor = System.Drawing.Color.White
        Me.lbInput.Location = New System.Drawing.Point(176, 88)
        Me.lbInput.Name = "lbInput"
        Me.lbInput.Size = New System.Drawing.Size(303, 23)
        Me.lbInput.TabIndex = 59
        Me.lbInput.Text = "lbInput"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(156, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 23)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = " :"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(156, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 23)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = " :"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(32, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 23)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Output folder"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(32, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 23)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Input folder"
        '
        'lbAlgorithm
        '
        Me.lbAlgorithm.BackColor = System.Drawing.Color.Transparent
        Me.lbAlgorithm.ForeColor = System.Drawing.Color.White
        Me.lbAlgorithm.Location = New System.Drawing.Point(448, 36)
        Me.lbAlgorithm.Name = "lbAlgorithm"
        Me.lbAlgorithm.Size = New System.Drawing.Size(127, 23)
        Me.lbAlgorithm.TabIndex = 53
        Me.lbAlgorithm.Text = "lbAlgorithm"
        '
        'lbBIN
        '
        Me.lbBIN.BackColor = System.Drawing.Color.Transparent
        Me.lbBIN.ForeColor = System.Drawing.Color.White
        Me.lbBIN.Location = New System.Drawing.Point(176, 56)
        Me.lbBIN.Name = "lbBIN"
        Me.lbBIN.Size = New System.Drawing.Size(127, 23)
        Me.lbBIN.TabIndex = 52
        Me.lbBIN.Text = "lbBIN"
        '
        'lbName
        '
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.ForeColor = System.Drawing.Color.White
        Me.lbName.Location = New System.Drawing.Point(176, 36)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(127, 23)
        Me.lbName.TabIndex = 51
        Me.lbName.Text = "lbName"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(428, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = " :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(156, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 23)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = " :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
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
        Me.Label4.ForeColor = System.Drawing.Color.White
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
        Me.Label2.ForeColor = System.Drawing.Color.White
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
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Bank name"
        '
        'lvStatus
        '
        Me.lvStatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvStatus.Location = New System.Drawing.Point(31, 163)
        Me.lvStatus.MultiSelect = False
        Me.lvStatus.Name = "lvStatus"
        Me.lvStatus.Size = New System.Drawing.Size(522, 229)
        Me.lvStatus.TabIndex = 3
        Me.lvStatus.UseCompatibleStateImageBehavior = False
        Me.lvStatus.View = System.Windows.Forms.View.Details
        Me.lvStatus.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Status"
        Me.ColumnHeader1.Width = 498
        '
        'lbRecNo
        '
        Me.lbRecNo.ForeColor = System.Drawing.Color.White
        Me.lbRecNo.Location = New System.Drawing.Point(32, 400)
        Me.lbRecNo.Name = "lbRecNo"
        Me.lbRecNo.Size = New System.Drawing.Size(189, 17)
        Me.lbRecNo.TabIndex = 63
        Me.lbRecNo.Text = "Current Record: 0"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(227, 398)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(326, 18)
        Me.ProgressBar.TabIndex = 64
        Me.ProgressBar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Error Reported : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstErrorFile
        '
        Me.lstErrorFile.FormattingEnabled = True
        Me.lstErrorFile.HorizontalScrollbar = True
        Me.lstErrorFile.Location = New System.Drawing.Point(31, 436)
        Me.lstErrorFile.Name = "lstErrorFile"
        Me.lstErrorFile.ScrollAlwaysVisible = True
        Me.lstErrorFile.Size = New System.Drawing.Size(517, 134)
        Me.lstErrorFile.TabIndex = 65
        '
        'frmOpen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(587, 579)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstErrorFile)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.lbRecNo)
        Me.Controls.Add(Me.lvStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.lbInput)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
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
        Me.Name = "frmOpen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Load File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnOK.Enabled = False
            btnClose.Enabled = False
            lvStatus.Visible = True

            ' Dim dwIndex As Integer
            Dim dwCount As Integer

            dwCount = lvStatus.Items.Count
            While (dwCount > 0)
                lvStatus.Items(0).Remove()
                dwCount = lvStatus.Items.Count
            End While

            AddStatusItem("Total file found: " & lstFile.Items.Count)

            ProgressBar.Minimum = 0
            ProgressBar.Maximum = lstFile.Items.Count
            ProgressBar.Visible = True

            Dim szFileCollection() As String

            'Retrieve file name in the input folder into an array
            szFileCollection = Directory.GetFiles(BankInfo.Folder_Input)

            Dim enElement As System.Collections.IEnumerator
            enElement = szFileCollection.GetEnumerator

            Dim szOutputFileName As String
            Dim szInputFileName As String
            Dim szFileName As String
            Dim szBackupFileName As String
            Dim szFinalFileNameWOExt As String

            'Dim szFileNameWOExt As String
            Dim szErrorFileName As String

            Dim dwTotalFile As Integer = 0
            Dim dwTotalPass As Integer = 0
            Dim dwTotalFail As Integer = 0


            While enElement.MoveNext
                dwTotalFile += 1

                'Prepare all file path for the current file
                szInputFileName = CStr(enElement.Current)
                szFileName = Path.GetFileName(szInputFileName)
                szFinalFileNameWOExt = Path.GetFileNameWithoutExtension(szFileName)
                ''Strip off EXT_ENC from file name
                'If (Strings.Right(szFileName, 4) = EXT_ENC) Then
                '    szFileNameWOExt = Mid(szFileName, 1, Len(szFileName) - 4)
                'Else
                '    szFileNameWOExt = szFileName
                'End If

                ''Extract file name without the extension
                'dwIndex = InStr(szFileNameWOExt, ".")
                'If (dwIndex > 0) Then
                '    szFinalFileNameWOExt = Microsoft.VisualBasic.Left(szFileNameWOExt, dwIndex - 1)
                'Else
                '    szFinalFileNameWOExt = szFileNameWOExt
                'End If

                'Find if file name already exist and auto-generate new file name
                'New file format: <12 CHR FROM ORIGINAL FILE NAME><hhmmss>_<2 DIGIT RECORD_COUNT>.9k
                If (IsFileExist(BankInfo.Folder_Ready & szFinalFileNameWOExt & EXT_9K) = True) Then
                    Dim szNewFile As String
                    Dim szHour As String = Date.Now.ToString("hhmmss")

                    szNewFile = Mid(szFinalFileNameWOExt, 1, 11) & "_" & szHour & "_" & CStr(dwTotalFile)
                    szFinalFileNameWOExt = szNewFile
                End If

                AddStatusItem("Start processing: " & szFileName & "...")

                Dim szNow As String = Date.Now.ToString("yyyyMMddhhmmss")
                Dim szToday As String = Date.Now.ToString("yyyyMMdd")

                'If (IsFolderExist(BankInfo.Folder_Backup & szToday) = False) Then
                '    MkDir(BankInfo.Folder_Backup & szToday)
                'End If

                szOutputFileName = gszWorkDrive & szFinalFileNameWOExt                                           'Output file always do not have EXT_ENC file extension
                'szBackupFileName = BankInfo.Folder_Backup & szToday & "\" & szFinalFileNameWOExt & "_" & szNow & ".txt"     'Backup file always do not have EXT_ENC file extension
                szBackupFileName = BankInfo.Folder_Backup & szFinalFileNameWOExt & "_" & szNow & ".txt"     'Backup file always do not have EXT_ENC file extension
                szErrorFileName = BankInfo.Folder_Error & szFileName                                        'Error file always do not have EXT_ENC file extension

                MyCopyFile(szInputFileName, szOutputFileName)

                'Perform file content verification and parsing the content
                AddStatusItem("(" & szFileName & ")  Parsing file...")

                If (VerifyAndParseData(szOutputFileName, lbRecNo, lstErrorFile) = False) Then
                    GoTo FailRecord
                End If
                UpdateAuditLog("Input file " & szFileName & " loaded into system", "Production")
                
                dwTotalPass += 1
                GoTo NextRecord

FailRecord:
                'Move the input file to Error folder
                MyMoveFile(szInputFileName, szErrorFileName)

                dwTotalFail += 1
                GoTo Finish

NextRecord:
                'Encrypt the input file and move to Backup folder
                AddStatusItem("(" & szFileName & ")  Successful.")

                'If all wents well, shred the temporary files and move the original file to backup folder
                MyMoveFile(szInputFileName, szBackupFileName)

Finish:
                If IsFileExist(szInputFileName) Then
                    WipeFile(szInputFileName)
                End If

                If IsFileExist(szOutputFileName) Then
                    WipeFile(szOutputFileName)
                End If

Done:
                lstFile.Items.Remove(szFileName)
                ProgressBar.Value = dwTotalFile
                ProgressBar.Refresh()
            End While

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            btnOK.Enabled = True
            btnClose.Enabled = True

            If (dwTotalFile = dwTotalPass) Then
                MessageBox.Show("All " & CStr(dwTotalFile) & " file(s) found has been successfully processed.", "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'DialogResult = Windows.Forms.DialogResult.OK
            Else
                If (dwTotalFile = dwTotalFail) Then
                    MessageBox.Show("All " & dwTotalFile & " file(s) found fail to be processed. Please check with the relevent bank or system administrator for further action.", "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(CStr(dwTotalFail) & " out of " & dwTotalFile & " file(s) found fail to be processed. Please check with the relevent bank or system administrator for further action.", "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception

        Finally
            lvStatus.Visible = False
            ProgressBar.Visible = False
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub frmOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UpdateAuditLog("Load File", "Audit Log")
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
                Case Else
                    lbAlgorithm.Text = "Unknown"
            End Select

            lbInput.Text = BankInfo.Folder_Input
            lbOutput.Text = BankInfo.Folder_Ready

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
                    btnOK.Enabled = True
                End If

                lbCount.Text = "Total file found: " & CStr(dwCount)

            End If

        Catch ex As Exception
            btnOK.Enabled = False
            MessageBox.Show("frmOpen_Load: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddStatusItem(ByVal szStatus As String)

        Try
            Dim lvItem As New ListViewItem(szStatus)
            lvStatus.Items.Add(lvItem)
            lvStatus.Update()

        Catch ex As Exception
            MessageBox.Show("frmOpen_AddStatusItem: Exception-" & ex.Message)
        End Try

    End Sub

End Class
