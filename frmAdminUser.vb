Public Class frmAdminUser
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
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuRefreshList As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGrant As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbid As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbrRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrSeparator1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbrSeparator0 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPass As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminUser))
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuRefreshList = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.NumericUpDownPass = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGrant = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.cbGroup = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lbid = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbrRefresh = New System.Windows.Forms.ToolBarButton
        Me.tbrSeparator1 = New System.Windows.Forms.ToolBarButton
        Me.tbrExit = New System.Windows.Forms.ToolBarButton
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tbrSeparator0 = New System.Windows.Forms.ToolBarButton
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDownPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRefreshList})
        '
        'mnuRefreshList
        '
        Me.mnuRefreshList.Index = 0
        Me.mnuRefreshList.Text = "Refresh List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.NumericUpDownPass)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.NumericUpDown)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnGrant)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.cbGroup)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lbid)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtLogin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtBank)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(182, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 435)
        Me.Panel1.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(240, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "days"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(26, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 17)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Password Expiry Interval"
        Me.Label8.Visible = False
        '
        'NumericUpDownPass
        '
        Me.NumericUpDownPass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownPass.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownPass.Location = New System.Drawing.Point(170, 339)
        Me.NumericUpDownPass.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDownPass.Name = "NumericUpDownPass"
        Me.NumericUpDownPass.Size = New System.Drawing.Size(62, 21)
        Me.NumericUpDownPass.TabIndex = 69
        Me.NumericUpDownPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownPass.Value = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDownPass.Visible = False
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(240, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "days"
        Me.Label9.Visible = False
        '
        'Label31
        '
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(26, 373)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(134, 17)
        Me.Label31.TabIndex = 71
        Me.Label31.Text = "Dormant Period"
        Me.Label31.Visible = False
        '
        'NumericUpDown
        '
        Me.NumericUpDown.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown.Location = New System.Drawing.Point(170, 369)
        Me.NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(62, 21)
        Me.NumericUpDown.TabIndex = 70
        Me.NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown.Value = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(170, 84)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(221, 21)
        Me.txtName.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(26, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 23)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "User Name"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(316, 26)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "For user who have their account revoke, click on Grant button to reactivate the a" & _
            "ccount with default password."
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(306, 26)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "For user who forget their password, click on Reset button to set to default passw" & _
            "ord."
        '
        'btnGrant
        '
        Me.btnGrant.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGrant.Enabled = False
        Me.btnGrant.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrant.ForeColor = System.Drawing.Color.White
        Me.btnGrant.Location = New System.Drawing.Point(368, 246)
        Me.btnGrant.Name = "btnGrant"
        Me.btnGrant.Size = New System.Drawing.Size(83, 23)
        Me.btnGrant.TabIndex = 7
        Me.btnGrant.Text = "&Grant"
        Me.btnGrant.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(368, 210)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cbGroup
        '
        Me.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroup.Enabled = False
        Me.cbGroup.Items.AddRange(New Object() {"PLAINTEXT", "DCQSS NATIVE"})
        Me.cbGroup.Location = New System.Drawing.Point(170, 144)
        Me.cbGroup.MaxDropDownItems = 50
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(221, 21)
        Me.cbGroup.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(26, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 23)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Access Group"
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
        Me.GroupBox1.Location = New System.Drawing.Point(28, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 8)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(170, 114)
        Me.txtLogin.MaxLength = 10
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.ReadOnly = True
        Me.txtLogin.Size = New System.Drawing.Size(221, 21)
        Me.txtLogin.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Login id"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(170, 55)
        Me.txtBank.MaxLength = 50
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(221, 21)
        Me.txtBank.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bank Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Information:"
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
        Me.TreeView1.Size = New System.Drawing.Size(183, 481)
        Me.TreeView1.TabIndex = 6
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(568, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'tbrSeparator0
        '
        Me.tbrSeparator0.Name = "tbrSeparator0"
        Me.tbrSeparator0.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbrSeparator0, Me.tbrRefresh, Me.tbrSeparator1, Me.tbrExit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(688, 44)
        Me.ToolBar.TabIndex = 5
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAdminUser
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(688, 460)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolBar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmAdminUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDownPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim boolLoaded As Boolean
    Dim boolChanged As Boolean

    Private Sub frmUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boolLoaded = False
        UpdateAuditLog("User Administration", "Audit Log")
    End Sub

    Private Sub frmUser_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Try
            If (boolLoaded = True) Then
                Exit Sub
            Else
                boolLoaded = True
            End If

            lbid.Text = NEW_ID

            Me.Refresh()
            LoadAllUser()
            LoadAllGroup()

            If (TreeView1.GetNodeCount(False) > 0) Then
                TreeView1.SelectedNode = TreeView1.Nodes(0)
            End If

            boolChanged = False

        Catch ex As Exception
            MessageBox.Show("frmUser_Activated: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                If (boolChanged = True) Then
                    If (MessageBox.Show("User information has not been saved. Do you wish to discard the changes and proceed with the operation?", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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
                If (MessageBox.Show("User information has not been saved. Do you wish to discard the changes and proceed with the operation?", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                    Exit Sub
                End If
            End If

            boolChanged = False

            Dim dwIndex As Integer
            Dim szId As String
            szId = lbid.Text

            Select Case CStr(e.Button.Tag())
                Case "Refresh"
                    dwIndex = TreeView1.SelectedNode.Index

                    LoadAllUser()
                    Call RefreshInformation(szId)
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                Case "Exit"
                    DialogResult = Windows.Forms.DialogResult.OK

            End Select


        Catch ex As Exception
            'MessageBox.Show("frmUser_ToolBar_ButtonClick: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllUser()

        Try
            TreeView1.Nodes.Clear()

            Dim szBankName As String
            Dim szUserName As String
            Dim szDisplay As String

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT a.*, b.bank_name FROM Users a, Bank b WHERE b.bank_id=a.usr_bank_id AND a.usr_bank_id <> 0 AND a.usr_group_id = 2 AND a.usr_deleted=0 Order by a.usr_name ASC"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("usr_id")) = False) Then
                    szBankName = IIf(IsDBNull(datareader("bank_name")), "", datareader("bank_name"))
                    szUserName = IIf(IsDBNull(datareader("usr_name")), "", datareader("usr_name"))
                    szDisplay = szUserName & " (" & szBankName & ")"

                    Dim nodp As New Windows.Forms.TreeNode(szDisplay, 0, 1)
                    nodp.Tag = datareader("usr_id")
                    TreeView1.Nodes.Add(nodp)
                End If

            End While

            myconn.Close()

        Catch ex As Exception
            'MessageBox.Show("frmUser_LoadAllUser: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllGroup()

        Try
            Dim szSQL As String
            szSQL = "SELECT group_id, group_name FROM Groups WHERE group_id <> 1 AND group_deleted=0 ORDER BY groups.group_name ASC"

            LoadTableCombo(cbGroup, szSQL)

        Catch ex As Exception
            MessageBox.Show("frmUser_LoadAllGroup: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub RefreshInformation(ByVal szId As String)

        Try
            If (szId = "") Then
                Exit Sub
            End If

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT a.*, b.bank_name FROM Users a, Bank b WHERE b.bank_id=a.usr_bank_id AND a.usr_id=" & szId & " AND a.usr_deleted=0 Order by a.usr_name ASC"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                lbid.Text = IIf(IsDBNull(datareader("usr_id")), "", datareader("usr_id"))
                txtBank.Text = IIf(IsDBNull(datareader("bank_name")), "", datareader("bank_name"))
                txtName.Text = IIf(IsDBNull(datareader("usr_name")), "", datareader("usr_name"))
                txtLogin.Text = IIf(IsDBNull(datareader("usr_login_id")), "", datareader("usr_login_id"))

                NumericUpDownPass.Value = IIf(IsDBNull(datareader("usr_expiry_period")), 0, datareader("usr_expiry_period"))
                NumericUpDown.Value = IIf(IsDBNull(datareader("usr_dormant_period")), 0, datareader("usr_dormant_period"))

                cbGroup.SelectedIndex = FindComboItem(cbGroup, IIf(IsDBNull(datareader("usr_group_id")), FAIL_ID, datareader("usr_group_id")))
                btnGrant.Enabled = datareader("usr_revoked")

                Exit While
            End While

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmUser_RefreshInformation: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddNewUser()

        Try
            lbid.Text = NEW_ID
            txtName.Text = ""
            txtLogin.Text = ""
            cbGroup.SelectedIndex = -1

            txtName.Focus()

        Catch ex As Exception
            MessageBox.Show("frmUser_AddNewUser: Exception-" & ex.Message)
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
            'MessageBox.Show("frmUser_RemoveNewId: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            MessageBox.Show("frmUser_btnCancel_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
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
            MessageBox.Show("frmUser_TreeView1_AfterSelect: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        If (boolChanged = True) Then
            If (MessageBox.Show("User information has not been saved. Do you wish to discard the changes and proceed with the operation?", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                e.Cancel = True
            Else
                boolChanged = False
            End If
        End If
    End Sub

    Private Sub btnGrant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrant.Click

        Try
            Dim dwResponse As Integer

            dwResponse = MessageBox.Show("Are you sure you want to Grant Access for this user? Press 'YES' to proceed and 'NO' to abort.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (dwResponse = vbNo) Then
                Exit Sub
            End If

            Dim CryptographyFactory As New CryptoFactory
            Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")
            Dim szCipher As String = Cryptographer.Encrypt(DEFAULT_PASSWORD)

            Dim szSQL As String
            Dim dwReturnRow As Integer

            Dim szId As String
            szId = lbid.Text

            Dim szLastLogin As String
            szLastLogin = Date.Now.ToString("yyyyMMddhhmmss")

            'Check for user password expiry date
            Dim szExpiry As String
            Dim dwExpiry As Integer

            dwExpiry = NumericUpDown.Value

            If (dwExpiry = 0) Then
                szExpiry = INFINITE_EXPIRY
            Else
                Dim d1 As Date = Date.Today
                Dim d2 As Date = d1.AddDays(dwExpiry)

                szExpiry = d2.ToString("yyyyMMdd")
            End If

            szSQL = "UPDATE Users SET usr_revoked=0, usr_expiry_date='" & szExpiry & "', usr_password='" & szCipher & "', usr_last_login='" & szLastLogin & "', usr_retry_left=" & CStr(LOGIN_DEFAULT_RETRY) & " WHERE usr_id=" & szId
            dwReturnRow = ExecuteSQL(szSQL)

            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when granting user access.", "Grant Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0
                    MessageBox.Show("User record not found. No access granted for this user.", "Grant Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("User has been granted access. Please use the default password on next login.", "Grant Access", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAuditLog("Grant user access for User ID " & szId, "Security")
            End Select


        Catch ex As Exception
            MessageBox.Show("frmUser_btnGrant_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        Try
            Dim dwResponse As Integer

            dwResponse = MessageBox.Show("Are you sure you want to Reset password for this user? Press 'YES' to proceed and 'NO' to abort.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (dwResponse = vbNo) Then
                Exit Sub
            End If

            Dim CryptographyFactory As New CryptoFactory
            Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")
            Dim szCipher As String = Cryptographer.Encrypt(DEFAULT_PASSWORD)

            Dim szSQL As String
            Dim dwReturnRow As Integer

            Dim szId As String
            szId = lbid.Text

            Dim szLastLogin As String
            szLastLogin = Date.Now.ToString("yyyyMMddhhmmss")


            'Check for user password expiry date
            Dim szExpiry As String
            Dim dwExpiry As Integer

            dwExpiry = NumericUpDown.Value

            If (dwExpiry = 0) Then
                szExpiry = INFINITE_EXPIRY
            Else
                Dim d1 As Date = Date.Today
                Dim d2 As Date = d1.AddDays(UserInfo.ExpiryPeriod)

                szExpiry = d2.ToString("yyyyMMdd")
            End If

            szSQL = "UPDATE Users SET usr_expiry_date='" & szExpiry & "', usr_password='" & szCipher & "', usr_retry_left=" & CStr(LOGIN_DEFAULT_RETRY) & " WHERE usr_id=" & szId
            dwReturnRow = ExecuteSQL(szSQL)

            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when reset user password.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0
                    MessageBox.Show("User record not found. Password not reset.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("User password has been reset. Please use the default password on next login.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAuditLog("Reset User password for User ID " & szId, "Security")
            End Select

        Catch ex As Exception
            MessageBox.Show("frmUser_btnReset_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub mnuRefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefreshList.Click

        Try
            Dim dwIndex As Integer
            Dim szId As String
            szId = lbid.Text

            dwIndex = TreeView1.SelectedNode.Index

            LoadAllUser()
            Call RefreshInformation(szId)
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

        Catch ex As Exception
            'MessageBox.Show("frmBank_mnuRefreshList_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub cbGroup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGroup.Click
        boolChanged = True
    End Sub

    Private Sub chkBarred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        boolChanged = True
    End Sub

End Class
