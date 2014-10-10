Public Class frmBank
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents btnBrowse0 As System.Windows.Forms.Button
    Friend WithEvents lbid As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbAlgorithm As System.Windows.Forms.ComboBox
    Friend WithEvents txtRoot As System.Windows.Forms.TextBox
    Friend WithEvents txtBIN As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse4 As System.Windows.Forms.Button
    Friend WithEvents txtLogo As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuBankAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBankDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefreshList As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse3 As System.Windows.Forms.Button
    Friend WithEvents txtBackup As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse2 As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse1 As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse5 As System.Windows.Forms.Button
    Friend WithEvents txtDC9K As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkOutputFormat As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBank))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuBankAdd = New System.Windows.Forms.MenuItem
        Me.mnuBankDelete = New System.Windows.Forms.MenuItem
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
        Me.btnBrowse5 = New System.Windows.Forms.Button
        Me.txtDC9K = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnBrowse2 = New System.Windows.Forms.Button
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnBrowse1 = New System.Windows.Forms.Button
        Me.txtInput = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkOutputFormat = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnBrowse3 = New System.Windows.Forms.Button
        Me.txtBackup = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnBrowse4 = New System.Windows.Forms.Button
        Me.txtLogo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbid = New System.Windows.Forms.Label
        Me.btnBrowse0 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbAlgorithm = New System.Windows.Forms.ComboBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtRoot = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBIN = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TreeView1.Size = New System.Drawing.Size(183, 447)
        Me.TreeView1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBankAdd, Me.mnuBankDelete, Me.MenuItem3, Me.mnuRefreshList})
        '
        'mnuBankAdd
        '
        Me.mnuBankAdd.Index = 0
        Me.mnuBankAdd.Text = "Add Bank"
        '
        'mnuBankDelete
        '
        Me.mnuBankDelete.Index = 1
        Me.mnuBankDelete.Text = "Delete Bank"
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
        Me.Panel1.Controls.Add(Me.btnBrowse5)
        Me.Panel1.Controls.Add(Me.txtDC9K)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnBrowse2)
        Me.Panel1.Controls.Add(Me.txtOutput)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnBrowse1)
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.chkOutputFormat)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btnBrowse3)
        Me.Panel1.Controls.Add(Me.txtBackup)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnBrowse4)
        Me.Panel1.Controls.Add(Me.txtLogo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbid)
        Me.Panel1.Controls.Add(Me.btnBrowse0)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cbAlgorithm)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtRoot)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtBIN)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(182, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 431)
        Me.Panel1.TabIndex = 1
        '
        'btnBrowse5
        '
        Me.btnBrowse5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBrowse5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse5.ForeColor = System.Drawing.Color.White
        Me.btnBrowse5.Location = New System.Drawing.Point(486, 231)
        Me.btnBrowse5.Name = "btnBrowse5"
        Me.btnBrowse5.Size = New System.Drawing.Size(27, 21)
        Me.btnBrowse5.TabIndex = 33
        Me.btnBrowse5.Text = "..."
        Me.btnBrowse5.UseVisualStyleBackColor = False
        '
        'txtDC9K
        '
        Me.txtDC9K.Location = New System.Drawing.Point(191, 228)
        Me.txtDC9K.MaxLength = 200
        Me.txtDC9K.Name = "txtDC9K"
        Me.txtDC9K.Size = New System.Drawing.Size(294, 21)
        Me.txtDC9K.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 23)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "DC9K/P3PRocess folder *"
        '
        'btnBrowse2
        '
        Me.btnBrowse2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBrowse2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse2.ForeColor = System.Drawing.Color.White
        Me.btnBrowse2.Location = New System.Drawing.Point(486, 172)
        Me.btnBrowse2.Name = "btnBrowse2"
        Me.btnBrowse2.Size = New System.Drawing.Size(27, 21)
        Me.btnBrowse2.TabIndex = 29
        Me.btnBrowse2.Text = "..."
        Me.btnBrowse2.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(191, 171)
        Me.txtOutput.MaxLength = 200
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(294, 21)
        Me.txtOutput.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Output folder *"
        '
        'btnBrowse1
        '
        Me.btnBrowse1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBrowse1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse1.ForeColor = System.Drawing.Color.White
        Me.btnBrowse1.Location = New System.Drawing.Point(486, 142)
        Me.btnBrowse1.Name = "btnBrowse1"
        Me.btnBrowse1.Size = New System.Drawing.Size(27, 21)
        Me.btnBrowse1.TabIndex = 27
        Me.btnBrowse1.Text = "..."
        Me.btnBrowse1.UseVisualStyleBackColor = False
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(191, 142)
        Me.txtInput.MaxLength = 200
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(294, 21)
        Me.txtInput.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(24, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Input folder *"
        '
        'chkOutputFormat
        '
        Me.chkOutputFormat.Location = New System.Drawing.Point(191, 284)
        Me.chkOutputFormat.Name = "chkOutputFormat"
        Me.chkOutputFormat.Size = New System.Drawing.Size(20, 24)
        Me.chkOutputFormat.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(26, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Encrypt ready file?"
        '
        'btnBrowse3
        '
        Me.btnBrowse3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBrowse3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse3.ForeColor = System.Drawing.Color.White
        Me.btnBrowse3.Location = New System.Drawing.Point(486, 201)
        Me.btnBrowse3.Name = "btnBrowse3"
        Me.btnBrowse3.Size = New System.Drawing.Size(27, 21)
        Me.btnBrowse3.TabIndex = 5
        Me.btnBrowse3.Text = "..."
        Me.btnBrowse3.UseVisualStyleBackColor = False
        '
        'txtBackup
        '
        Me.txtBackup.Location = New System.Drawing.Point(191, 200)
        Me.txtBackup.MaxLength = 200
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.Size = New System.Drawing.Size(294, 21)
        Me.txtBackup.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(24, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Backup folder *"
        '
        'btnBrowse4
        '
        Me.btnBrowse4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBrowse4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse4.ForeColor = System.Drawing.Color.White
        Me.btnBrowse4.Location = New System.Drawing.Point(486, 261)
        Me.btnBrowse4.Name = "btnBrowse4"
        Me.btnBrowse4.Size = New System.Drawing.Size(27, 21)
        Me.btnBrowse4.TabIndex = 7
        Me.btnBrowse4.Text = "..."
        Me.btnBrowse4.UseVisualStyleBackColor = False
        '
        'txtLogo
        '
        Me.txtLogo.Location = New System.Drawing.Point(191, 256)
        Me.txtLogo.MaxLength = 200
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.Size = New System.Drawing.Size(294, 21)
        Me.txtLogo.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(26, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Logo name"
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Brown
        Me.Label9.Location = New System.Drawing.Point(26, 379)
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
        'btnBrowse0
        '
        Me.btnBrowse0.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBrowse0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse0.ForeColor = System.Drawing.Color.White
        Me.btnBrowse0.Location = New System.Drawing.Point(486, 113)
        Me.btnBrowse0.Name = "btnBrowse0"
        Me.btnBrowse0.Size = New System.Drawing.Size(27, 21)
        Me.btnBrowse0.TabIndex = 3
        Me.btnBrowse0.Text = "..."
        Me.btnBrowse0.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(28, 347)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 8)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'cbAlgorithm
        '
        Me.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAlgorithm.Items.AddRange(New Object() {"PLAINTEXT", "DCQSS NATIVE", "EMVES"})
        Me.cbAlgorithm.Location = New System.Drawing.Point(191, 316)
        Me.cbAlgorithm.Name = "cbAlgorithm"
        Me.cbAlgorithm.Size = New System.Drawing.Size(221, 21)
        Me.cbAlgorithm.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(385, 383)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(299, 383)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtRoot
        '
        Me.txtRoot.Location = New System.Drawing.Point(191, 113)
        Me.txtRoot.MaxLength = 200
        Me.txtRoot.Name = "txtRoot"
        Me.txtRoot.Size = New System.Drawing.Size(294, 21)
        Me.txtRoot.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Root folder *"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Output file algorithm *"
        '
        'txtBIN
        '
        Me.txtBIN.Location = New System.Drawing.Point(191, 84)
        Me.txtBIN.MaxLength = 10
        Me.txtBIN.Name = "txtBIN"
        Me.txtBIN.Size = New System.Drawing.Size(221, 21)
        Me.txtBIN.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "BIN *"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(191, 55)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(221, 21)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name *"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank Information:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Bitmap files|*.bmp"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(578, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmBank
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(725, 475)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.TreeView1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Bank"
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

    Private Sub frmBank_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boolLoaded = False
        UpdateAuditLog("Bank Administration", "Audit Log")
    End Sub

    Private Sub frmBank_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Try
            If (boolLoaded = True) Then
                Exit Sub
            Else
                boolLoaded = True
            End If

            lbid.Text = NEW_ID

            Me.Refresh()
            LoadAllBank()

            If (TreeView1.GetNodeCount(False) > 0) Then
                TreeView1.SelectedNode = TreeView1.Nodes(0)
            End If

            boolChanged = False

        Catch ex As Exception
            MessageBox.Show("frmBank_Activated: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmBank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                If (boolChanged = True) Then
                    If (MessageBox.Show("Bank information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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
                If (MessageBox.Show("Bank information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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

                    Dim szBankName As String
                    szBankName = NEW_BANK

                    Dim nodp As New Windows.Forms.TreeNode(szBankName, 0, 1)
                    nodp.Tag = NEW_ID
                    TreeView1.Nodes.Add(nodp)
                    dwIndex = nodp.Index
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)
                    nodp = Nothing

                    AddNewBank()

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
                    szSQL = "UPDATE Bank SET bank_deleted=-1 WHERE bank_id = " & szId

                    dwReturnRow = ExecuteSQL(szSQL)
                    Select Case dwReturnRow
                        Case -1
                            MessageBox.Show("Error occur when deleting bank record.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 0
                            MessageBox.Show("Bank record not found. No record deleted.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case Else
                            szSQL = "UPDATE Users SET usr_deleted=-1 WHERE usr_bank_id=" & szId
                            dwReturnRow = ExecuteSQL(szSQL)

                            MessageBox.Show("Bank record has been deleted.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UpdateAuditLog("Delete Bank ID " & szId, "Security")
                            TreeView1.SelectedNode.Remove()
                    End Select

                Case "Refresh"
                    dwIndex = TreeView1.SelectedNode.Index

                    LoadAllBank()
                    Call RefreshInformation(szId)
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                Case "Exit"
                    DialogResult = Windows.Forms.DialogResult.OK

            End Select


        Catch ex As Exception
            'MessageBox.Show("frmBank_ToolBar_ButtonClick: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllBank()

        Try
            TreeView1.Nodes.Clear()

            Dim szBankName As String

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Bank WHERE bank_deleted=0 ORDER BY bank_name ASC"

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("bank_id")) = False) Then
                    szBankName = IIf(IsDBNull(datareader("bank_name")), "", datareader("bank_name"))

                    Dim nodp As TreeNode = New TreeNode(szBankName, 0, 1)
                    nodp.Tag = datareader("bank_id")
                    TreeView1.Nodes.Add(nodp)
                End If

            End While

            myconn.Close()

        Catch ex As Exception
            'MessageBox.Show("frmBank_LoadAllBank: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub RefreshInformation(ByVal szId As String)

        Try
            If (szId = "") Then
                Exit Sub
            End If

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM Bank WHERE bank_id=" & szId & " AND bank_deleted=0 ORDER BY bank_name ASC"

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                lbid.Text = IIf(IsDBNull(datareader("bank_id")), "", datareader("bank_id"))
                txtName.Text = IIf(IsDBNull(datareader("bank_name")), "", datareader("bank_name"))
                txtBIN.Text = IIf(IsDBNull(datareader("bank_bin")), "", datareader("bank_bin"))
                cbAlgorithm.SelectedIndex = IIf(IsDBNull(datareader("bank_algorithm")), -1, datareader("bank_algorithm"))
                txtRoot.Text = IIf(IsDBNull(datareader("bank_folder")), "", datareader("bank_folder"))
                txtInput.Text = IIf(IsDBNull(datareader("bank_folder_input")), "", datareader("bank_folder_input"))
                txtOutput.Text = IIf(IsDBNull(datareader("bank_folder_output")), "", datareader("bank_folder_output"))
                txtBackup.Text = IIf(IsDBNull(datareader("bank_folder_backup")), "", datareader("bank_folder_backup"))
                txtDC9K.Text = IIf(IsDBNull(datareader("bank_folder_dc9k")), "", datareader("bank_folder_dc9k"))
                txtLogo.Text = IIf(IsDBNull(datareader("bank_logo")), "", datareader("bank_logo"))
                chkOutputFormat.Checked = IIf(datareader("bank_encrypted") = 0, False, True)

                Exit While
            End While

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmBank_RefreshInformation: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddNewBank()

        Try
            lbid.Text = NEW_ID
            txtName.Text = ""
            txtBIN.Text = ""
            cbAlgorithm.SelectedIndex = -1
            txtRoot.Text = ""
            txtLogo.Text = ""
            txtDC9K.Text = ""
            txtName.Focus()

        Catch ex As Exception
            MessageBox.Show("frmBank_AddNewBank: Exception-" & ex.Message)
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
            'MessageBox.Show("frmBank_RemoveNewId: Exception-" & ex.Message)
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
            MessageBox.Show("frmBank_btnCancel_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            Close()
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim myconn As New OleDb.OleDbConnection(gszConnString)

        Try
            Dim boolNew As Boolean = False

            Dim szId As String
            szId = lbid.Text

            ErrorProvider1.SetError(txtName, "")
            ErrorProvider1.SetError(txtBIN, "")
            ErrorProvider1.SetError(cbAlgorithm, "")
            ErrorProvider1.SetError(txtRoot, "")
            ErrorProvider1.SetError(txtInput, "")
            ErrorProvider1.SetError(txtOutput, "")
            ErrorProvider1.SetError(txtBackup, "")
            ErrorProvider1.SetError(txtDC9K, "")

            If (szId = "") Then
                Exit Sub
            End If

            If (txtName.Text = "") Then
                ErrorProvider1.SetError(txtName, "Bank name cannot be blank.")
                Exit Sub
            End If

            If (txtBIN.Text = "") Then
                ErrorProvider1.SetError(txtBIN, "Bank BIN cannot be blank.")
                Exit Sub
            End If

            If (cbAlgorithm.SelectedIndex = -1) Then
                ErrorProvider1.SetError(cbAlgorithm, "File algorithm cannot be blank.")
                Exit Sub
            End If

            If (txtRoot.Text = "") Then
                ErrorProvider1.SetError(txtRoot, "Root folder cannot be blank.")
                Exit Sub
            End If

            If (IsFolderExist(txtRoot.Text) = False) Then
                ErrorProvider1.SetError(txtRoot, "Root folder does not exists.")
                Exit Sub
            End If

            If (txtInput.Text = "") Then
                ErrorProvider1.SetError(txtInput, "Input folder cannot be blank.")
                Exit Sub
            End If

            If (txtOutput.Text = "") Then
                ErrorProvider1.SetError(txtOutput, "Output folder cannot be blank.")
                Exit Sub
            End If

            If (txtBackup.Text = "") Then
                ErrorProvider1.SetError(txtBackup, "Backup folder cannot be blank.")
                Exit Sub
            End If

            If (txtDC9K.Text = "") Then
                ErrorProvider1.SetError(txtDC9K, "DC9K folder cannot be blank.")
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim myCmd As New OleDb.OleDbCommand
            myCmd.Connection = myconn
            Dim dwReturnRow As Integer

            Dim szBankName As String
            Dim szBIN As String
            Dim dwAlgorithm As Integer
            Dim szRoot As String
            Dim szInput As String
            Dim szBackup As String
            Dim szOutput As String
            Dim szDC9K As String

            Dim szLogo As String
            Dim dwOutputEncrypted As Integer

            szBankName = txtName.Text
            szBIN = txtBIN.Text
            dwAlgorithm = cbAlgorithm.SelectedIndex

            szRoot = IIf(Microsoft.VisualBasic.Right(txtRoot.Text, 1) = "\", txtRoot.Text, txtRoot.Text & "\")
            txtRoot.Text = szRoot

            szInput = IIf(Microsoft.VisualBasic.Right(txtInput.Text, 1) = "\", txtInput.Text, txtInput.Text & "\")
            txtInput.Text = szInput

            szOutput = IIf(Microsoft.VisualBasic.Right(txtOutput.Text, 1) = "\", txtOutput.Text, txtOutput.Text & "\")
            txtOutput.Text = szOutput

            szBackup = IIf(Microsoft.VisualBasic.Right(txtBackup.Text, 1) = "\", txtBackup.Text, txtBackup.Text & "\")
            txtBackup.Text = szBackup

            szDC9K = IIf(Microsoft.VisualBasic.Right(txtDC9K.Text, 1) = "\", txtDC9K.Text, txtDC9K.Text & "\")
            txtDC9K.Text = szDC9K

            szLogo = txtLogo.Text

            If chkOutputFormat.Checked = True Then
                dwOutputEncrypted = 1
            Else
                dwOutputEncrypted = 0
            End If

            myconn.Open()

            If (szId = NEW_ID) Then
                boolNew = True

                'create all folder for the bank
                Dim szTempFolder As String
                szTempFolder = gszWorkDrive & "ISSUER\"
                If (IsFolderExist(szTempFolder) = False) Then
                    MessageBox.Show("ISSUER folder not found. Operation aborted and record not saved.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                myCmd.CommandText = "INSERT INTO Bank (bank_name, bank_bin, bank_algorithm, bank_folder, bank_folder_input, bank_folder_output, bank_folder_backup, bank_folder_dc9K, bank_logo, bank_encrypted) VALUES ('" & _
                                    szBankName & "','" & szBIN & "'," & dwAlgorithm & ",'" & szRoot & "','" & szInput & "','" & szOutput & "','" & szBackup & "','" & szDC9K & "', '" & szLogo & "'," & dwOutputEncrypted & ")"
            Else
                myCmd.CommandText = "UPDATE Bank SET bank_name='" & szBankName & "', bank_bin='" & szBIN & "', bank_algorithm=" & dwAlgorithm & ", bank_folder='" & szRoot & "', bank_folder_input='" & szInput & "', bank_folder_output='" & szOutput & _
                                    "', bank_folder_backup='" & szBackup & "', bank_folder_dc9k='" & szDC9K & "', bank_logo='" & szLogo & "', bank_encrypted=" & dwOutputEncrypted & " WHERE bank_id =" & szId
            End If

            dwReturnRow = myCmd.ExecuteNonQuery()
            myconn.Close()


            'Refresh database immediately
            myconn.Open()
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            If (dwReturnRow > 0) Then

                If (szId = NEW_ID) Then
                    Dim lngBankId As Long
                    lngBankId = GetCurrentId("Bank", "bank_id")

                    If (lngBankId = FAIL_ID) Then
                        MessageBox.Show("Error occur when retrieving last bank id.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    szId = CStr(lngBankId)
                    lbid.Text = szId
                    TreeView1.SelectedNode.Tag = szId
                End If

                TreeView1.SelectedNode.Text = szBankName

                If (boolNew = True) Then
                    'create all folder for the bank
                    Dim szTempFolder As String
                    szTempFolder = gszWorkDrive & "ISSUER\"

                    'Copy issuer directory to a newly created issuer folder
                    CopyDirectory(szTempFolder, szRoot)

                    'Create a default administrator for Issuer
                    Dim CryptographyFactory As New CryptoFactory
                    Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")

                    Dim szCipher As String = Cryptographer.Encrypt(DEFAULT_PASSWORD)

                    myCmd.CommandText = "INSERT INTO Users (usr_bank_id, usr_login_id, usr_name, usr_password, usr_barred, usr_group_id, usr_expiry_period, usr_dormant_period, usr_expiry_date, usr_last_login) VALUES (" & szId & ",'admin','Administrator','" & szCipher & "',0,2,0," & CStr(LOGIN_DORMANT_PERIOD) & ",'" & INFINITE_EXPIRY & "','" & Date.Now.ToString("yyyyMMddhhmmss") & "')"
                    dwReturnRow = myCmd.ExecuteNonQuery()
                End If

                boolChanged = False

                MessageBox.Show("Bank information has been saved.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateAuditLog("Update Bank ID " & szId, "Audit Log")
            Else
                MessageBox.Show("Fail to save bank information. Please try again later. If problem persist, please contact system administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmBank_btnSave_Click: Exception-" & ex.Message)
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
            MessageBox.Show("frmBank_TreeView1_AfterSelect: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        If (boolChanged = True) Then
            If (MessageBox.Show("Bank information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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

            Dim szBankName As String
            szBankName = NEW_BANK

            Dim nodp As New Windows.Forms.TreeNode(szBankName, 0, 1)
            nodp.Tag = NEW_ID
            TreeView1.Nodes.Add(nodp)
            dwIndex = nodp.Index
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

            AddNewBank()

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
            szSQL = "UPDATE Bank SET bank_deleted=-1 WHERE bank_id = " & szId

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting bank record.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0
                    MessageBox.Show("Bank record not found. No record deleted.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    szSQL = "UPDATE Users SET usr_deleted=-1 WHERE usr_bank_id=" & szId
                    dwReturnRow = ExecuteSQL(szSQL)

                    MessageBox.Show("Bank record has been deleted.", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAuditLog("Delete Bank ID " & szId, "Audit Log")
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

            LoadAllBank()
            Call RefreshInformation(szId)
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

        Catch ex As Exception
            'MessageBox.Show("frmBank_mnuRefreshList_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub cbAlgorithm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAlgorithm.Click
        boolChanged = True
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse0.Click, btnBrowse1.Click, btnBrowse2.Click, btnBrowse3.Click, btnBrowse4.Click, btnBrowse5.Click

        Try
            Dim clickedCtrl As Control
            Dim szbtnName As String
            Dim dwBtnIndex As Integer
            Dim TxtCtrl As TextBox = Nothing
            Dim szFBDescription As String = ""
            If TypeOf sender Is Control Then
                clickedCtrl = DirectCast(sender, Control)
                szbtnName = clickedCtrl.Name
                dwBtnIndex = Strings.Right(szbtnName, 1)
                Select Case dwBtnIndex
                    Case 0
                        szFBDescription = "Please select the root folder for the bank."
                        TxtCtrl = txtRoot
                    Case 1
                        szFBDescription = "Please select the input folder for the bank."
                        TxtCtrl = txtInput
                    Case 2
                        szFBDescription = "Please select the output folder for the bank."
                        TxtCtrl = txtOutput
                    Case 3
                        szFBDescription = "Please select the backup folder for the bank."
                        TxtCtrl = txtBackup
                    Case 4
                        Dim dlgLogo As New frmLogo
                        gszFieldName = txtLogo.Text

                        dlgLogo.ShowDialog()

                        If (dlgLogo.DialogResult = Windows.Forms.DialogResult.OK) Then
                            txtLogo.Text = gszFieldName
                            boolChanged = True
                        End If
                        dlgLogo.Dispose()
                        Exit Try
                    Case 5
                        szFBDescription = "Please select the DC9K folder for the bank."
                        TxtCtrl = txtDC9K

                End Select
            End If

            FolderBrowserDialog.Description = szFBDescription
            If (TxtCtrl.Text = "") Then
                FolderBrowserDialog.SelectedPath = gszWorkDrive
            Else
                If (IsFolderExist(txtRoot.Text) = True) Then
                    FolderBrowserDialog.SelectedPath = TxtCtrl.Text
                End If
            End If

            If (FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                'txtRoot.Text = FolderBrowserDialog.SelectedPath
                TxtCtrl.Text = IIf(Microsoft.VisualBasic.Right(FolderBrowserDialog.SelectedPath, 1) = "\", FolderBrowserDialog.SelectedPath, FolderBrowserDialog.SelectedPath & "\")
                boolChanged = True
            End If

        Catch ex As Exception
            MessageBox.Show("frmBank_btnBrowse_Click: Exception-" & ex.Message)
        End Try

    End Sub

    'Private Sub btnBrowse4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse4.Click

    '    Try


    '    Catch ex As Exception
    '        MessageBox.Show("frmBank_btnBrowse4_Click: Exception-" & ex.Message)
    '    End Try

    'End Sub
End Class
