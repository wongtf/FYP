Public Class frmUser
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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbrSeparator0 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrDel As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrSeparator1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents chkBarred As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGrant As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPass As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuBankAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBankDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefreshList As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.NumericUpDownPass = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGrant = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.cbGroup = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.chkBarred = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbid = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbrSeparator0 = New System.Windows.Forms.ToolBarButton
        Me.tbrAdd = New System.Windows.Forms.ToolBarButton
        Me.tbrDel = New System.Windows.Forms.ToolBarButton
        Me.tbrRefresh = New System.Windows.Forms.ToolBarButton
        Me.tbrSeparator1 = New System.Windows.Forms.ToolBarButton
        Me.tbrExit = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuBankAdd = New System.Windows.Forms.MenuItem
        Me.mnuBankDelete = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuRefreshList = New System.Windows.Forms.MenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDownPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.NumericUpDownPass)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.NumericUpDown)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnGrant)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.cbGroup)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.chkBarred)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbid)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtLogin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(182, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 435)
        Me.Panel1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(240, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "days"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(26, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 17)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Password Expiry Interval"
        '
        'NumericUpDownPass
        '
        Me.NumericUpDownPass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownPass.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownPass.Location = New System.Drawing.Point(170, 146)
        Me.NumericUpDownPass.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDownPass.Name = "NumericUpDownPass"
        Me.NumericUpDownPass.Size = New System.Drawing.Size(62, 21)
        Me.NumericUpDownPass.TabIndex = 3
        Me.NumericUpDownPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownPass.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(240, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "days"
        '
        'Label31
        '
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(26, 180)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(134, 17)
        Me.Label31.TabIndex = 64
        Me.Label31.Text = "Dormant Period"
        '
        'NumericUpDown
        '
        Me.NumericUpDown.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown.Location = New System.Drawing.Point(170, 176)
        Me.NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(62, 21)
        Me.NumericUpDown.TabIndex = 4
        Me.NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(316, 26)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "For user who have their account revoke, click on Grant button to reactivate the a" & _
            "ccount with default password."
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 246)
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
        Me.btnGrant.Location = New System.Drawing.Point(368, 278)
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
        Me.btnReset.Location = New System.Drawing.Point(368, 242)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cbGroup
        '
        Me.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroup.Items.AddRange(New Object() {"PLAINTEXT", "DCQSS NATIVE"})
        Me.cbGroup.Location = New System.Drawing.Point(170, 116)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(221, 21)
        Me.cbGroup.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(26, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 23)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Access Group *"
        '
        'chkBarred
        '
        Me.chkBarred.Location = New System.Drawing.Point(170, 204)
        Me.chkBarred.Name = "chkBarred"
        Me.chkBarred.Size = New System.Drawing.Size(15, 24)
        Me.chkBarred.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(26, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 23)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Is this user barred?"
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Brown
        Me.Label9.Location = New System.Drawing.Point(28, 348)
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
        Me.GroupBox1.Location = New System.Drawing.Point(30, 318)
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
        Me.btnCancel.Location = New System.Drawing.Point(370, 348)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(284, 348)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(170, 86)
        Me.txtLogin.MaxLength = 10
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(221, 21)
        Me.txtLogin.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Login id *"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(170, 55)
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
        Me.Label2.Size = New System.Drawing.Size(134, 23)
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
        Me.Label1.Text = "User Information:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.ToolBar.Size = New System.Drawing.Size(690, 44)
        Me.ToolBar.TabIndex = 0
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
        Me.TreeView1.TabIndex = 1
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBankAdd, Me.mnuBankDelete, Me.MenuItem3, Me.mnuRefreshList})
        '
        'mnuBankAdd
        '
        Me.mnuBankAdd.Index = 0
        Me.mnuBankAdd.Text = "Add User"
        '
        'mnuBankDelete
        '
        Me.mnuBankDelete.Index = 1
        Me.mnuBankDelete.Text = "Delete User"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(568, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmUser
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(690, 470)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.TreeView1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDownPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim boolLoaded As Boolean
    Dim boolChanged As Boolean

    Private Sub frmUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Define User Profile", "Audit Log")
        boolLoaded = False
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
                Case "Add"
                    If (szId = NEW_ID) Then
                        Exit Sub
                    End If

                    Dim szUserName As String
                    szUserName = NEW_USER

                    Dim nodp As New Windows.Forms.TreeNode(szUserName, 0, 1)
                    nodp.Tag = NEW_ID
                    TreeView1.Nodes.Add(nodp)
                    dwIndex = nodp.Index
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                    AddNewUser()

                Case "Del"
                    If (szId = "") Then
                        'If no record selected, do nothing.
                        Exit Sub
                    End If

                    If (szId = NEW_ID) Then
                        RemoveNewId()
                        Exit Sub
                    End If

                    If (szId = UserInfo.Id) Then
                        MessageBox.Show("You are not allowed to delete the currently active user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                        Exit Sub
                    End If

                    Dim szSQL As String
                    Dim dwReturnRow As Integer
                    szSQL = "UPDATE Users SET usr_deleted=-1 WHERE usr_id = " & szId

                    dwReturnRow = ExecuteSQL(szSQL)
                    Select Case dwReturnRow
                        Case -1
                            MessageBox.Show("Error occur when deleting user record.", "User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 0
                            MessageBox.Show("User record not found. No record deleted.", "User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case Else
                            MessageBox.Show("User record has been deleted.", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UpdateAuditLog("Delete User ID " & szId, "Security")
                            TreeView1.SelectedNode.Remove()
                    End Select

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

            Dim szUserName As String

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Users WHERE usr_bank_id=" & UserInfo.BankId & " AND usr_group_id <> 1 AND usr_deleted=0 Order by usr_name ASC"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("usr_id")) = False) Then
                    szUserName = IIf(IsDBNull(datareader("usr_name")), "", datareader("usr_name"))

                    Dim nodp As New Windows.Forms.TreeNode(szUserName, 0, 1)
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
            ErrorProvider1.SetError(txtName, "")
            ErrorProvider1.SetError(txtLogin, "")
            ErrorProvider1.SetError(cbGroup, "")
            ErrorProvider1.SetError(chkBarred, "")

            If (szId = "") Then
                Exit Sub
            End If

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Users WHERE usr_id=" & szId & " AND usr_deleted=0 Order by usr_name ASC"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                lbid.Text = IIf(IsDBNull(datareader("usr_id")), "", datareader("usr_id"))
                txtName.Text = IIf(IsDBNull(datareader("usr_name")), "", datareader("usr_name"))
                txtLogin.Text = IIf(IsDBNull(datareader("usr_login_id")), "", datareader("usr_login_id"))

                NumericUpDownPass.Value = IIf(IsDBNull(datareader("usr_expiry_period")), 0, datareader("usr_expiry_period"))
                NumericUpDown.Value = IIf(IsDBNull(datareader("usr_dormant_period")), 0, datareader("usr_dormant_period"))

                chkBarred.Checked = datareader("usr_barred")
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
            chkBarred.Checked = False
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
            MessageBox.Show("frmUser_btnCancel_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            Dim szId As String
            szId = lbid.Text

            ErrorProvider1.SetError(txtName, "")
            ErrorProvider1.SetError(txtLogin, "")
            ErrorProvider1.SetError(cbGroup, "")
            ErrorProvider1.SetError(chkBarred, "")

            If (szId = "") Then
                Exit Sub
            End If

            If (txtName.Text = "") Then
                ErrorProvider1.SetError(txtName, "User name cannot be blank.")
                Exit Sub
            End If

            If (txtLogin.Text = "") Then
                ErrorProvider1.SetError(txtLogin, "Login id cannot be blank.")
                Exit Sub
            End If

            If (cbGroup.SelectedIndex = -1) Then
                ErrorProvider1.SetError(cbGroup, "Access group cannot be blank.")
                Exit Sub
            End If

            If (chkBarred.Checked = True) And (szId = UserInfo.Id) Then
                ErrorProvider1.SetError(chkBarred, "User is not allowed to barred himself/herself from the system.")
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            myCmd.Connection = myconn
            Dim dwReturnRow As Integer

            Dim szUserName As String
            Dim szLogin As String
            Dim dwBarred As Integer
            Dim lngGroup As Long
            Dim dwExpiry As Integer
            Dim dwDormant As Integer

            szUserName = txtName.Text
            szLogin = txtLogin.Text
            dwBarred = IIf(chkBarred.Checked = True, -1, 0)
            dwExpiry = NumericUpDownPass.Value
            dwDormant = NumericUpDown.Value
            lngGroup = FindComboId(cbGroup, cbGroup.SelectedIndex)    'usr_group_id

            myconn.Open()

            If (szId = NEW_ID) Then
                Dim CryptographyFactory As New CryptoFactory
                Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")

                Dim szCipher As String = Cryptographer.Encrypt(DEFAULT_PASSWORD)

                myCmd.CommandText = "INSERT INTO Users (usr_bank_id, usr_login_id, usr_name, usr_password, usr_barred, usr_group_id, usr_expiry_period, usr_dormant_period, usr_last_login) VALUES (" & UserInfo.BankId & ",'" & szLogin & "','" & szUserName & "','" & szCipher & "'," & dwBarred & "," & CStr(lngGroup) & "," & CStr(dwExpiry) & "," & CStr(dwDormant) & ",'" & Date.Now.ToString("yyyyMMddhhmmss") & "')"
            Else
                myCmd.CommandText = "UPDATE Users SET usr_login_id='" & szLogin & "', usr_name='" & szUserName & "', usr_barred=" & dwBarred & ", usr_group_id=" & CStr(lngGroup) & ", usr_expiry_period=" & CStr(dwExpiry) & ", usr_dormant_period=" & CStr(dwDormant) & " WHERE usr_id =" & szId
            End If

            dwReturnRow = myCmd.ExecuteNonQuery()

            myconn.Close()

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            If (dwReturnRow > 0) Then
                boolChanged = False

                MessageBox.Show("User information has been saved.", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateAuditLog("Update User ID " & szLogin, "Security")
                If (szId = NEW_ID) Then
                    Dim lngUserId As Long
                    lngUserId = GetCurrentId("Users", "usr_id")

                    If (lngUserId = FAIL_ID) Then
                        MessageBox.Show("Error occur when retrieving last user id.", "User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    szId = CStr(lngUserId)
                    TreeView1.SelectedNode.Tag = szId
                    lbid.Text = szId
                End If

                TreeView1.SelectedNode.Text = szUserName
            Else
                MessageBox.Show("Fail to save bank information. Please try again later. If problem persist, please contact system administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmUser_btnSave_Click: Exception-" & ex.Message)
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
                    UpdateAuditLog("Grant User access for " & szId, "Security")
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
                    UpdateAuditLog("Reset User Password for " & szId, "Security")
            End Select

        Catch ex As Exception
            MessageBox.Show("frmUser_btnReset_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub mnuBankAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBankAdd.Click

        Try
            Dim dwIndex As Integer
            Dim szId As String
            szId = lbid.Text

            If (szId = NEW_ID) Then
                Exit Sub
            End If

            Dim szUserName As String
            szUserName = NEW_USER

            Dim nodp As New Windows.Forms.TreeNode(szUserName, 0, 1)
            nodp.Tag = NEW_ID
            TreeView1.Nodes.Add(nodp)
            dwIndex = nodp.Index
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

            AddNewUser()

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

            If (szId = UserInfo.Id) Then
                MessageBox.Show("You are not allowed to delete the currently active user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

            Dim szSQL As String
            Dim dwReturnRow As Integer
            szSQL = "UPDATE Users SET usr_deleted=-1 WHERE usr_id = " & szId

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting user record.", "User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0
                    MessageBox.Show("User record not found. No record deleted.", "User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("User record has been deleted.", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAuditLog("Delete User ID " & szId, "Security")
                    TreeView1.SelectedNode.Remove()
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

    Private Sub chkBarred_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBarred.Click
        boolChanged = True
    End Sub

End Class
