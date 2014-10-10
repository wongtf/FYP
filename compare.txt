Imports System.IO

Public Class frmShred
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cmbFileGroup As System.Windows.Forms.ComboBox
    Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUnselectAll As System.Windows.Forms.MenuItem
    Friend WithEvents lstFile As System.Windows.Forms.ListBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShred))
        Me.cmbFileGroup = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstFile = New System.Windows.Forms.ListBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuSelectAll = New System.Windows.Forms.MenuItem
        Me.mnuUnselectAll = New System.Windows.Forms.MenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.StatusBar = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbFileGroup
        '
        Me.cmbFileGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFileGroup.Items.AddRange(New Object() {"BACKUP", "ERROR", "READY"})
        Me.cmbFileGroup.Location = New System.Drawing.Point(110, 21)
        Me.cmbFileGroup.Name = "cmbFileGroup"
        Me.cmbFileGroup.Size = New System.Drawing.Size(385, 21)
        Me.cmbFileGroup.Sorted = True
        Me.cmbFileGroup.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File group"
        '
        'lstFile
        '
        Me.lstFile.ContextMenu = Me.ContextMenu1
        Me.lstFile.Location = New System.Drawing.Point(32, 75)
        Me.lstFile.Name = "lstFile"
        Me.lstFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFile.Size = New System.Drawing.Size(463, 186)
        Me.lstFile.Sorted = True
        Me.lstFile.TabIndex = 3
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSelectAll, Me.mnuUnselectAll})
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Index = 0
        Me.mnuSelectAll.Text = "Select &All"
        '
        'mnuUnselectAll
        '
        Me.mnuUnselectAll.Index = 1
        Me.mnuUnselectAll.Text = "&Unselect All"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "File found:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(281, 270)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(193, 270)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "&Shred Now"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'StatusBar
        '
        Me.StatusBar.Location = New System.Drawing.Point(0, 308)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar.ShowPanels = True
        Me.StatusBar.Size = New System.Drawing.Size(528, 23)
        Me.StatusBar.TabIndex = 7
        Me.StatusBar.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 511
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(0, 310)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(508, 21)
        Me.ProgressBar.TabIndex = 8
        Me.ProgressBar.Visible = False
        '
        'frmShred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(528, 331)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFileGroup)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShred"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Shred file"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmbIssuerPath_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFileGroup.SelectedIndexChanged

        Try
            Dim szFileGroup As String
            Dim szIssuerPath As String

            lstFile.Items.Clear()
            szFileGroup = cmbFileGroup.SelectedItem

            Select Case szFileGroup
                Case "BACKUP"
                    StatusBar.Panels(0).Text = BankInfo.Folder_Backup
                Case "ERROR"
                    StatusBar.Panels(0).Text = BankInfo.Folder_Error
                Case "READY"
                    StatusBar.Panels(0).Text = BankInfo.Folder_Ready
            End Select

            'get all files from the selected folder
            szIssuerPath = StatusBar.Panels(0).Text
            If (szIssuerPath <> "") Then
                Dim szFileCollection() As String
                Dim dwIndex As Integer

                szFileCollection = Directory.GetFiles(szIssuerPath)

                For dwIndex = 0 To UBound(szFileCollection)
                    lstFile.Items.Add(Path.GetFileName(szFileCollection(dwIndex)))
                    lstFile.SetSelected(lstFile.Items.Count - 1, True)
                Next

            End If

        Catch ex As Exception
            MessageBox.Show("frmShred_cmbFileGroup_SelectIndexChanged: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub mnuSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectAll.Click
        Dim dwIndex As Integer

        For dwIndex = 0 To lstFile.Items.Count - 1
            lstFile.SetSelected(dwIndex, True)
        Next
    End Sub

    Private Sub mnuUnselectAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuUnselectAll.Click
        lstFile.ClearSelected()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try
            Dim dwIndex As Integer
            Dim szFileName As String
            Dim dwCount As Integer = 0
            Dim dwTotalFile As Integer = 0
            Dim dwTotalDel As Integer = 0

            Dim dwResponse As Integer
            Dim szIssuerPath As String

            dwResponse = MessageBox.Show("Are you sure you want to shred the selected files? This process is irreversible. Press 'YES' to proceed and 'NO' to abort.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (dwResponse = vbNo) Then
                Exit Sub
            End If

            btnOK.Enabled = False
            btnClose.Enabled = False
            ProgressBar.Visible = True

            'get all files from the selected folder
            szIssuerPath = StatusBar.Panels(0).Text

            dwTotalFile = 0
            For dwIndex = 0 To lstFile.Items.Count - 1
                If (lstFile.GetSelected(dwIndex) = True) Then
                    dwTotalFile += 1
                End If
            Next

            ProgressBar.Minimum = 0
            ProgressBar.Maximum = dwTotalFile

            dwCount = 0
            For dwIndex = lstFile.Items.Count - 1 To 0 Step -1
                szFileName = szIssuerPath & lstFile.Items(dwIndex)
                If (szFileName <> "") Then
                    If WipeFile(szFileName) Then
                        UpdateAuditLog("Delete file - " & szFileName, "Production")
                        lstFile.Items.RemoveAt(dwIndex)

                        ProgressBar.Value = dwCount
                        dwTotalDel += 1
                    End If
                End If

                dwCount += 1
            Next

            If (dwTotalFile = dwTotalDel) Then
                MessageBox.Show("All " & dwTotalFile & " file(s) has been shred successfully.", "Shred", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Fail to shred " & CStr(dwTotalFile - dwTotalDel) & " out of " & dwTotalFile & " file(s) found. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("frmShred_btnOK_Click: Exception-" & ex.Message)
        Finally
            btnOK.Enabled = True
            btnClose.Enabled = True
            ProgressBar.Visible = False
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub frmShred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("File Deletion", "Audit Log")
    End Sub
End Class