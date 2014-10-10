Public Class frmAccessMenu
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbid As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tbrExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbrSeparator0 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrDel As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrSeparator1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtControl As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuBankAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBankDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefreshList As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccessMenu))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbid = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtControl = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbrExit = New System.Windows.Forms.ToolBarButton
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuBankAdd = New System.Windows.Forms.MenuItem
        Me.mnuBankDelete = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuRefreshList = New System.Windows.Forms.MenuItem
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbrSeparator0 = New System.Windows.Forms.ToolBarButton
        Me.tbrAdd = New System.Windows.Forms.ToolBarButton
        Me.tbrDel = New System.Windows.Forms.ToolBarButton
        Me.tbrRefresh = New System.Windows.Forms.ToolBarButton
        Me.tbrSeparator1 = New System.Windows.Forms.ToolBarButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbid)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtControl)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(182, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 416)
        Me.Panel1.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Brown
        Me.Label9.Location = New System.Drawing.Point(28, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "*  Mandatory field"
        '
        'lbid
        '
        Me.lbid.ForeColor = System.Drawing.Color.White
        Me.lbid.Location = New System.Drawing.Point(437, 8)
        Me.lbid.Name = "lbid"
        Me.lbid.Size = New System.Drawing.Size(65, 23)
        Me.lbid.TabIndex = 17
        Me.lbid.Text = "Id"
        Me.lbid.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(30, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 8)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(370, 216)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(284, 216)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtControl
        '
        Me.txtControl.Location = New System.Drawing.Point(140, 86)
        Me.txtControl.MaxLength = 50
        Me.txtControl.Name = "txtControl"
        Me.txtControl.Size = New System.Drawing.Size(221, 21)
        Me.txtControl.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Control name *"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(140, 55)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(221, 21)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name *"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Access Menu Information:"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        '
        'tbrExit
        '
        Me.tbrExit.ImageIndex = 3
        Me.tbrExit.Name = "tbrExit"
        Me.tbrExit.Tag = "Exit"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.ContextMenu = Me.ContextMenu1
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(-2, 44)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(183, 416)
        Me.TreeView1.TabIndex = 6
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBankAdd, Me.mnuBankDelete, Me.MenuItem3, Me.mnuRefreshList})
        '
        'mnuBankAdd
        '
        Me.mnuBankAdd.Index = 0
        Me.mnuBankAdd.Text = "Add Menu"
        '
        'mnuBankDelete
        '
        Me.mnuBankDelete.Index = 1
        Me.mnuBankDelete.Text = "Delete Menu"
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
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbrSeparator0, Me.tbrAdd, Me.tbrDel, Me.tbrRefresh, Me.tbrSeparator1, Me.tbrExit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(688, 44)
        Me.ToolBar.TabIndex = 8
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(578, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmAccessMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(688, 460)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.ToolBar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmAccessMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Access Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim boolLoaded As Boolean
    Dim boolChanged As Boolean

    Private Sub frmAccessMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boolLoaded = False
        UpdateAuditLog("Define Access Menu", "Audit Log")
    End Sub

    Private Sub frmAccessMenu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Try
            If (boolLoaded = True) Then
                Exit Sub
            Else
                boolLoaded = True
            End If

            lbid.Text = NEW_ID

            Me.Refresh()
            LoadAllMenu()

            If (TreeView1.GetNodeCount(False) > 0) Then
                TreeView1.SelectedNode = TreeView1.Nodes(0)
            End If

            boolChanged = False

        Catch ex As Exception
            MessageBox.Show("frmAccessMenu_Activated: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmAccessMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                If (boolChanged = True) Then
                    If (MessageBox.Show("Access menu information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Access Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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
                If (MessageBox.Show("Access menu information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Access Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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

                    Dim szMenuName As String
                    szMenuName = NEW_MENU

                    Dim nodp As New Windows.Forms.TreeNode(szMenuName, 0, 1)
                    nodp.Tag = NEW_ID
                    TreeView1.Nodes.Add(nodp)
                    dwIndex = nodp.Index
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                    AddNewMenu()

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
                    szSQL = "DELETE FROM Menus WHERE menu_id = " & szId

                    dwReturnRow = ExecuteSQL(szSQL)
                    Select Case dwReturnRow
                        Case -1
                            MessageBox.Show("Error occur when deleting access menu record.", "Access Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 0
                            MessageBox.Show("Access menu record not found. No record deleted.", "Access Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case Else
                            MessageBox.Show("Access menu record has been deleted.", "Access Menu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TreeView1.SelectedNode.Remove()
                            UpdateAuditLog("Delete Access menu " & szId, "Security")
                    End Select

                Case "Refresh"
                    dwIndex = TreeView1.SelectedNode.Index

                    LoadAllMenu()
                    Call RefreshInformation(szId)
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                Case "Exit"
                    DialogResult = Windows.Forms.DialogResult.OK

            End Select


        Catch ex As Exception
            'MessageBox.Show("frmAccessMenu_ToolBar_ButtonClick: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllMenu()

        Try
            TreeView1.Nodes.Clear()

            Dim szMenuName As String

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Menus ORDER BY menu_name ASC"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("menu_id")) = False) Then

                    szMenuName = IIf(IsDBNull(datareader("menu_name")), "", datareader("menu_name"))

                    Dim nodp As New Windows.Forms.TreeNode(szMenuName, 0, 1)
                    nodp.Tag = datareader("menu_id")
                    TreeView1.Nodes.Add(nodp)

                End If

            End While

            myconn.Close()

        Catch ex As Exception
            'MessageBox.Show("frmAccessMenu_LoadAllMenu: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub RefreshInformation(ByVal szId As String)

        Try
            If (szId = "") Then
                Exit Sub
            End If

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Menus WHERE menu_id=" & szId

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                lbid.Text = IIf(IsDBNull(datareader("menu_id")), "", datareader("menu_id"))
                txtName.Text = IIf(IsDBNull(datareader("menu_name")), "", datareader("menu_name"))
                txtControl.Text = IIf(IsDBNull(datareader("menu_control_name")), "", datareader("menu_control_name"))

                Exit While
            End While

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmAccessMenu_RefreshInformation: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddNewMenu()

        Try
            lbid.Text = NEW_ID
            txtName.Text = ""
            txtControl.Text = ""

            txtName.Focus()
        Catch ex As Exception
            MessageBox.Show("frmAccessMenu_AddNewMenu: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub RemoveNewId()

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
            'MessageBox.Show("frmAccessMenu_RemoveNewId: Exception-" & ex.Message)
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

        Catch ex As Exception
            MessageBox.Show("frmAccessMenu_btnCancel_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            Dim szId As String
            szId = lbid.Text

            ErrorProvider1.SetError(txtName, "")
            ErrorProvider1.SetError(txtControl, "")

            If (szId = "") Then
                Exit Sub
            End If

            If (txtName.Text = "") Then
                ErrorProvider1.SetError(txtName, "Menu name cannot be blank.")
                Exit Sub
            End If

            If (txtControl.Text = "") Then
                ErrorProvider1.SetError(txtControl, "Control name cannot be blank.")
                Exit Sub
            End If


            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            myCmd.Connection = myconn
            Dim dwReturnRow As Integer

            Dim szMenuName As String
            Dim szControl As String

            szMenuName = txtName.Text
            szControl = txtControl.Text

            myconn.Open()

            If (szId = NEW_ID) Then
                myCmd.CommandText = "INSERT INTO Menus (menu_name, menu_control_name) VALUES ('" & szMenuName & "','" & szControl & "')"
            Else
                myCmd.CommandText = "UPDATE Menus SET menu_name='" & szMenuName & "', menu_control_name='" & szControl & "' WHERE menu_id =" & szId
            End If

            dwReturnRow = myCmd.ExecuteNonQuery()

            myconn.Close()

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            If (dwReturnRow > 0) Then
                boolChanged = False

                MessageBox.Show("Access menu information has been saved.", "Access Menu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateAuditLog("Update Access menu " & szMenuName, "Security")

                If (szId = NEW_ID) Then
                    Dim lngMenuId As Long
                    lngMenuId = GetCurrentId("Menus", "menu_id")

                    If (lngMenuId = FAIL_ID) Then
                        MessageBox.Show("Error occur when retrieving last menu id.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    szId = CStr(lngMenuId)
                    lbid.Text = szId
                    TreeView1.SelectedNode.Tag = szId
                End If

                TreeView1.SelectedNode.Text = szMenuName

            Else
                MessageBox.Show("Fail to save access menu information. Please try again later. If problem persist, please contact system administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmAccessMenu_btnSave_Click: Exception-" & ex.Message)
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
            MessageBox.Show("frmAccessMenu_TreeView1_AfterSelect: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        If (boolChanged = True) Then
            If (MessageBox.Show("Access menu information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Access Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                e.Cancel = True
            Else
                boolChanged = False
            End If
        End If
    End Sub

    Private Sub mnuBankAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBankAdd.Click

        Try
            Dim dwIndex As Integer
            Dim szId As String
            szId = lbid.Text

            If (szId = NEW_ID) Then
                Exit Sub
            End If

            Dim szMenuName As String
            szMenuName = NEW_MENU

            Dim nodp As New Windows.Forms.TreeNode(szMenuName, 0, 1)
            nodp.Tag = NEW_ID
            TreeView1.Nodes.Add(nodp)
            dwIndex = nodp.Index
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

            AddNewMenu()

        Catch ex As Exception
            'MessageBox.Show("frmBank_mnuBankAdd_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub mnuBankDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBankDelete.Click

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
            szSQL = "DELETE FROM Menus WHERE menu_id = " & szId

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting access menu record.", "Access Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0
                    MessageBox.Show("Access menu record not found. No record deleted.", "Access Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("Access menu record has been deleted.", "Access Menu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TreeView1.SelectedNode.Remove()
                    UpdateAuditLog("Delete Access menu " & szId, "Security")
            End Select

        Catch ex As Exception
            'MessageBox.Show("frmBank_mnuBankDelete_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub mnuRefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefreshList.Click

        Try
            Dim dwIndex As Integer
            Dim szId As String
            szId = lbid.Text

            dwIndex = TreeView1.SelectedNode.Index

            LoadAllMenu()
            Call RefreshInformation(szId)
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

        Catch ex As Exception
            'MessageBox.Show("frmBank_mnuRefreshList_Click: Exception-" & ex.Message)
        End Try

    End Sub

End Class
