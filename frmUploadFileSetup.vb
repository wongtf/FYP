Public Class frmUploadFileSetup
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbrAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrDel As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbrSeparator1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrSeparator0 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents lbid As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtHeader As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuUploadFileSetupAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUploadFileSetupDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefreshList As System.Windows.Forms.MenuItem
    Friend WithEvents txtFldIdentifier As System.Windows.Forms.TextBox
    Friend WithEvents txtFooter As System.Windows.Forms.TextBox
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtSetupName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUploadFileSetup))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuUploadFileSetupAdd = New System.Windows.Forms.MenuItem
        Me.mnuUploadFileSetupDelete = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuRefreshList = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbrSeparator0 = New System.Windows.Forms.ToolBarButton
        Me.tbrAdd = New System.Windows.Forms.ToolBarButton
        Me.tbrDel = New System.Windows.Forms.ToolBarButton
        Me.tbrRefresh = New System.Windows.Forms.ToolBarButton
        Me.tbrSeparator1 = New System.Windows.Forms.ToolBarButton
        Me.tbrExit = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSetupName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFooter = New System.Windows.Forms.TextBox
        Me.txtDetails = New System.Windows.Forms.TextBox
        Me.txtFldIdentifier = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbid = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtHeader = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.ContextMenu = Me.ContextMenu1
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(-2, 44)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(183, 417)
        Me.TreeView1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuUploadFileSetupAdd, Me.mnuUploadFileSetupDelete, Me.MenuItem3, Me.mnuRefreshList})
        '
        'mnuUploadFileSetupAdd
        '
        Me.mnuUploadFileSetupAdd.Index = 0
        Me.mnuUploadFileSetupAdd.Text = "Add UploadFile Setup"
        '
        'mnuUploadFileSetupDelete
        '
        Me.mnuUploadFileSetupDelete.Index = 1
        Me.mnuUploadFileSetupDelete.Text = "Delete UploadFile Setup"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'mnuRefreshList
        '
        Me.mnuRefreshList.Index = 3
        Me.mnuRefreshList.Text = "Refresh List"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbrSeparator0, Me.tbrAdd, Me.tbrDel, Me.tbrRefresh, Me.tbrSeparator1, Me.tbrExit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(725, 44)
        Me.ToolBar.TabIndex = 2
        '
        'tbrSeparator0
        '
        Me.tbrSeparator0.Name = "tbrSeparator0"
        Me.tbrSeparator0.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbrAdd
        '
        Me.tbrAdd.ImageIndex = 0
        Me.tbrAdd.Name = "tbrAdd"
        Me.tbrAdd.Tag = "Add"
        '
        'tbrDel
        '
        Me.tbrDel.ImageIndex = 1
        Me.tbrDel.Name = "tbrDel"
        Me.tbrDel.Tag = "Del"
        '
        'tbrRefresh
        '
        Me.tbrRefresh.ImageIndex = 2
        Me.tbrRefresh.Name = "tbrRefresh"
        Me.tbrRefresh.Tag = "Refresh"
        '
        'tbrSeparator1
        '
        Me.tbrSeparator1.Name = "tbrSeparator1"
        Me.tbrSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbrExit
        '
        Me.tbrExit.ImageIndex = 3
        Me.tbrExit.Name = "tbrExit"
        Me.tbrExit.Tag = "Exit"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtSetupName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtFooter)
        Me.Panel1.Controls.Add(Me.txtDetails)
        Me.Panel1.Controls.Add(Me.txtFldIdentifier)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lbid)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtHeader)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(182, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 380)
        Me.Panel1.TabIndex = 0
        '
        'txtSetupName
        '
        Me.txtSetupName.Location = New System.Drawing.Point(217, 34)
        Me.txtSetupName.MaxLength = 200
        Me.txtSetupName.Name = "txtSetupName"
        Me.txtSetupName.Size = New System.Drawing.Size(294, 21)
        Me.txtSetupName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Setup Name "
        '
        'txtFooter
        '
        Me.txtFooter.Location = New System.Drawing.Point(217, 205)
        Me.txtFooter.MaxLength = 0
        Me.txtFooter.Multiline = True
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFooter.Size = New System.Drawing.Size(294, 56)
        Me.txtFooter.TabIndex = 3
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(217, 138)
        Me.txtDetails.MaxLength = 0
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(294, 54)
        Me.txtDetails.TabIndex = 2
        '
        'txtFldIdentifier
        '
        Me.txtFldIdentifier.Location = New System.Drawing.Point(217, 275)
        Me.txtFldIdentifier.MaxLength = 200
        Me.txtFldIdentifier.Name = "txtFldIdentifier"
        Me.txtFldIdentifier.Size = New System.Drawing.Size(294, 21)
        Me.txtFldIdentifier.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(24, 275)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Field Identifier"
        '
        'lbid
        '
        Me.lbid.ForeColor = System.Drawing.Color.White
        Me.lbid.Location = New System.Drawing.Point(442, 1)
        Me.lbid.Name = "lbid"
        Me.lbid.Size = New System.Drawing.Size(65, 23)
        Me.lbid.TabIndex = 17
        Me.lbid.Text = "Id"
        Me.lbid.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(28, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 10)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(424, 329)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(338, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Footer"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Details"
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(217, 74)
        Me.txtHeader.MaxLength = 0
        Me.txtHeader.Multiline = True
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHeader.Size = New System.Drawing.Size(294, 52)
        Me.txtHeader.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Header"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Upload File Details Setup:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Bitmap files|*.bmp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(497, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Upload File Details"
        '
        'frmUploadFileSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(725, 421)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.TreeView1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmUploadFileSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Upload File Setup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim boolLoaded As Boolean
    Dim boolChanged As Boolean

    Private Sub frmUploadFileSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Define upload file format", "Audit Log")
        boolLoaded = False
    End Sub

    Private Sub frmUploadFileSetup_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Try
            If (boolLoaded = True) Then
                Exit Sub
            Else
                boolLoaded = True
            End If

            lbid.Text = NEW_ID

            Me.Refresh()
            LoadAllUFSetup()

            If (TreeView1.GetNodeCount(False) > 0) Then
                TreeView1.SelectedNode = TreeView1.Nodes(0)
            End If

            boolChanged = False

        Catch ex As Exception
            MessageBox.Show("frmUploadFileSetup_Activated: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmUploadFileSetup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                If (boolChanged = True) Then
                    If (MessageBox.Show("UploadFileSetup information has not been saved. Do you wish to discard the changes and proceed with the operation?", "UploadFileSetup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                        Exit Sub
                    End If
                End If

                DialogResult = Windows.Forms.DialogResult.OK

            Case Keys.Up, Keys.Down, Keys.Left, Keys.Right
                'Do nothing

            Case Else
                boolChanged = True
        End Select

    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick

        Try
            If (boolChanged = True) Then
                If (MessageBox.Show("UploadFile setup information has not been saved. Do you wish to discard the changes and proceed with the operation?", "UploadFileSetup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                    Exit Sub
                End If
            End If

            boolChanged = False

            Dim dwIndex As Integer
            Dim szId As String
            szId = lbid.Text

            Select Case CStr(e.Button.Tag())
                Case "Add"
                    If (szId = NEW_ID) Then
                        Exit Sub
                    End If

                    Dim szSetupName As String
                    szSetupName = "New Setup"

                    Dim nodp As New Windows.Forms.TreeNode(szSetupName, 0, 1)
                    nodp.Tag = NEW_ID
                    TreeView1.Nodes.Add(nodp)
                    dwIndex = nodp.Index
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)
                    nodp = Nothing

                    AddNewUploadFileSetup()

                Case "Del"
                    If (szId = "") Then
                        'If no record selected, do nothing.
                        Exit Sub
                    End If

                    If (szId = NEW_ID) Then
                        RemoveNewId()
                        Exit Sub
                    End If

                    If (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                        Exit Sub
                    End If

                    Dim szSQL As String
                    Dim dwReturnRow As Integer
                    szSQL = "UPDATE UploadFileDetails SET uf_deleted=-1 WHERE uf_id = " & szId

                    dwReturnRow = ExecuteSQL(szSQL)
                    Select Case dwReturnRow
                        Case -1
                            MessageBox.Show("Error occur when deleting UploadFile setup record.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 0
                            MessageBox.Show("UploadFileSetup record not found. No record deleted.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case Else
                            MessageBox.Show("UploadFileSetup record has been deleted.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UpdateAuditLog("Delete UploadFileSetup ID " & szId, "Setup")
                            TreeView1.SelectedNode.Remove()
                    End Select

                Case "Refresh"
                    dwIndex = TreeView1.SelectedNode.Index

                    LoadAllUFSetup()
                    Call RefreshInformation(szId)
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                Case "Exit"
                    DialogResult = Windows.Forms.DialogResult.OK

            End Select


        Catch ex As Exception
            'MessageBox.Show("frmUploadFileSetup_ToolBar_ButtonClick: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllUFSetup()

        Try
            TreeView1.Nodes.Clear()

            Dim szUploadFileSetupName As String

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM UploadFileDetails WHERE uf_deleted=0 ORDER BY uf_name ASC"

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("uf_id")) = False) Then
                    szUploadFileSetupName = IIf(IsDBNull(datareader("uf_name")), "", datareader("uf_name"))

                    Dim nodp As TreeNode = New TreeNode(szUploadFileSetupName, 0, 1)
                    nodp.Tag = datareader("uf_id")
                    TreeView1.Nodes.Add(nodp)
                End If

            End While

            myconn.Close()

        Catch ex As Exception
            'MessageBox.Show("frmUploadFileSetup_LoadAllUploadFileSetup: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub RefreshInformation(ByVal szId As String)

        Try
            If (szId = "") Then
                Exit Sub
            End If

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM UploadFileDetails WHERE uf_id=" & szId & " AND uf_deleted=0 ORDER BY uf_name ASC"

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                lbid.Text = IIf(IsDBNull(datareader("uf_id")), "", datareader("uf_id"))
                txtSetupName.Text = IIf(IsDBNull(datareader("uf_name")), "", datareader("uf_name"))
                txtHeader.Text = IIf(IsDBNull(datareader("uf_header")), "", datareader("uf_header"))
                txtDetails.Text = IIf(IsDBNull(datareader("uf_details")), "", datareader("uf_details"))
                txtFooter.Text = IIf(IsDBNull(datareader("uf_footer")), "", datareader("uf_footer"))
                txtFldIdentifier.Text = IIf(IsDBNull(datareader("uf_check_field")), "", datareader("uf_check_field"))
                Exit While
            End While

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmUploadFileSetup_RefreshInformation: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddNewUploadFileSetup()

        Try
            lbid.Text = NEW_ID
            txtSetupName.Text = ""
            txtHeader.Text = ""
            txtDetails.Text = ""
            txtFooter.Text = ""
            txtFldIdentifier.Text = ""

            txtSetupName.Focus()

        Catch ex As Exception
            MessageBox.Show("frmUploadFileSetup_AddNewUploadFileSetup: Exception-" & ex.Message)
        End Try

    End Sub

    Public Sub RemoveNewId()

        Try
            Dim dwIndex As Integer
            Dim dwCount As Integer
            dwCount = TreeView1.GetNodeCount(False) - 1

            For dwIndex = dwCount To 0 Step -1
                If (TreeView1.Nodes(dwIndex).Tag = NEW_ID) Then
                    TreeView1.Nodes.RemoveAt(dwIndex)
                End If
            Next

        Catch ex As Exception
            'MessageBox.Show("frmUploadFileSetup_RemoveNewId: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Try
            boolChanged = False

            Dim szId As String
            szId = lbid.Text
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            If (szId = NEW_ID) Then
                RemoveNewId()
            Else
                RefreshInformation(szId)
            End If

            Close()

        Catch ex As Exception
            MessageBox.Show("frmUploadFileSetup_btnCancel_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim myconn As New OleDb.OleDbConnection(gszConnString)

        Try
            Dim boolNew As Boolean = False

            Dim szId As String
            szId = lbid.Text

            ErrorProvider1.SetError(txtSetupName, "")
            ErrorProvider1.SetError(txtFldIdentifier, "")

            If (szId = "") Then
                Exit Sub
            End If

            If (txtSetupName.Text = "") Then
                ErrorProvider1.SetError(txtFldIdentifier, "Upload File Setup Name cannot be blank.")
                Exit Sub
            End If

            If (txtFldIdentifier.Text = "") Then
                ErrorProvider1.SetError(txtFldIdentifier, "Field Identifier cannot be blank.")
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim myCmd As New OleDb.OleDbCommand
            myCmd.Connection = myconn
            Dim dwReturnRow As Integer

            Dim szSetupName As String
            Dim szHeader As String
            Dim szDetails As String
            Dim szFooter As String
            Dim szFldIdentifier As String
            Dim dwCount As Integer

            szSetupName = txtSetupName.Text
            szHeader = txtHeader.Text
            szDetails = txtDetails.Text
            szFooter = txtFooter.Text
            szFldIdentifier = txtFldIdentifier.Text

            myconn.Open()

            If (szId = NEW_ID) Then
                boolNew = True
                dwCount = GetCountSQL("SELECT * FROM UploadFileDetails where uf_name='" & szSetupName & "'")
                If dwCount <= 0 Then

                    myCmd.CommandText = "INSERT INTO UploadFileDetails (job_bank_id, uf_name, uf_header, uf_details, uf_footer, uf_check_field, uf_deleted) VALUES (" & _
                                        BankInfo.Id & ", '" & szSetupName & "', '" & szHeader & "', '" & szDetails & "', '" & szFooter & "', '" & szFldIdentifier & "',0)"
                Else
                    MessageBox.Show("UploadFile Setup name already exists.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                myCmd.CommandText = "UPDATE UploadFileDetails SET uf_name='" & szSetupName & "', uf_header='" & szHeader & "', uf_details='" & szDetails & "', " & _
                                    "uf_footer='" & szFooter & "', uf_check_field='" & szFldIdentifier & "' WHERE uf_id =" & szId
            End If

            dwReturnRow = myCmd.ExecuteNonQuery()
            myconn.Close()


            'Refresh database immediately
            myconn.Open()
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            If (dwReturnRow > 0) Then

                If (szId = NEW_ID) Then
                    Dim lngUFId As Long
                    lngUFId = GetCurrentId("UploadFileDetails", "uf_id")

                    If (lngUFId = FAIL_ID) Then
                        MessageBox.Show("Error occur when retrieving last UploadFileSetup id.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    szId = CStr(lngUFId)
                    lbid.Text = szId
                    TreeView1.SelectedNode.Tag = szId
                End If

                TreeView1.SelectedNode.Text = szSetupName

                boolChanged = False

                MessageBox.Show("UploadFile setup information has been saved.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateAuditLog("Update UploadFileSetup ID " & szId, "Setup")
            Else
                MessageBox.Show("Fail to save UploadFileSetup information. Please try again later. If problem persist, please contact system administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmUploadFileSetup_btnSave_Click: Exception-" & ex.Message)
        Finally
            myconn.Close()
        End Try

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Try
            Dim szId As String
            szId = TreeView1.SelectedNode.Tag

            If (szId <> NEW_ID) Then
                RemoveNewId()
                RefreshInformation(szId)
            End If

        Catch ex As Exception
            MessageBox.Show("frmUploadFileSetup_TreeView1_AfterSelect: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        If (boolChanged = True) Then
            If (MessageBox.Show("UploadFileSetup information has not been saved. Do you wish to discard the changes and proceed with the operation?", "UploadFileSetup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                e.Cancel = True
            Else
                boolChanged = False
            End If
        End If
    End Sub

    Private Sub mnuUploadFileSetupAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUploadFileSetupAdd.Click

        Try
            Dim dwIndex As Integer
            Dim szId As String
            szId = lbid.Text

            If (szId = NEW_ID) Then
                Exit Sub
            End If

            Dim szSetupName As String
            szSetupName = "New Setup"

            Dim nodp As New Windows.Forms.TreeNode(szSetupName, 0, 1)
            nodp.Tag = NEW_ID
            TreeView1.Nodes.Add(nodp)
            dwIndex = nodp.Index
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

            AddNewUploadFileSetup()

        Catch ex As Exception
            'MessageBox.Show("frmUploadFileSetup_mnuUploadFileSetupAdd_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub mnuUploadFileSetupDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUploadFileSetupDelete.Click

        Try
            Dim szId As String
            szId = lbid.Text

            If (szId = "") Then
                'If no record selected, do nothing.
                Exit Sub
            End If

            If (szId = NEW_ID) Then
                RemoveNewId()
                Exit Sub
            End If

            If (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

            Dim szSQL As String
            Dim dwReturnRow As Integer
            szSQL = "UPDATE UploadFileDetails SET uf_deleted=-1 WHERE uf_id = " & szId

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting UploadFileSetup record.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0
                    MessageBox.Show("UploadFileSetup record not found. No record deleted.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("UploadFileSetup record has been deleted.", "UploadFileSetup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAuditLog("Delete UploadFileSetup ID " & szId, "Setup")
                    TreeView1.SelectedNode.Remove()
            End Select

        Catch ex As Exception
            'MessageBox.Show("frmUploadFileSetup_mnuUploadFileSetupDelete_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub mnuRefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefreshList.Click

        Try
            Dim dwIndex As Integer
            Dim szId As String
            szId = lbid.Text

            dwIndex = TreeView1.SelectedNode.Index

            LoadAllUFSetup()
            Call RefreshInformation(szId)
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

        Catch ex As Exception
            'MessageBox.Show("frmUploadFileSetup_mnuRefreshList_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub cbAlgorithm_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        boolChanged = True
    End Sub
End Class
