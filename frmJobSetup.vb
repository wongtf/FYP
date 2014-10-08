Public Class frmJobSetup
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents tbrDel As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrSeparator1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbrSeparator0 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cbFileFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbid As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbInformation As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfilenameStartOffset As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuBankAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBankDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefreshList As System.Windows.Forms.MenuItem
    Friend WithEvents cbCardSetup As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtProdName As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cbFunctionType As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel1 As System.Windows.Forms.Button
    Friend WithEvents btnSave1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtfilenameLength As System.Windows.Forms.TextBox
    Friend WithEvents txtfiledateLength As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtfiledateStartOffset As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtfiletypeLength As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtfiletypeStartOffset As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbOutputFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbBatchType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboProcType As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobSetup))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuBankAdd = New System.Windows.Forms.MenuItem
        Me.mnuBankDelete = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuRefreshList = New System.Windows.Forms.MenuItem
        Me.tbrDel = New System.Windows.Forms.ToolBarButton
        Me.tbrSeparator1 = New System.Windows.Forms.ToolBarButton
        Me.tbrAdd = New System.Windows.Forms.ToolBarButton
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbrSeparator0 = New System.Windows.Forms.ToolBarButton
        Me.tbrRefresh = New System.Windows.Forms.ToolBarButton
        Me.tbrExit = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cboProcType = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cbBatchType = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbOutputFormat = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbFunctionType = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtProdName = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.cbCardSetup = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbFileFormat = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbid = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbInformation = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtfiletypeLength = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtfiletypeStartOffset = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtfiledateLength = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtfiledateStartOffset = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtfilenameLength = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCancel1 = New System.Windows.Forms.Button
        Me.btnSave1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtfilenameStartOffset = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.TreeView1.Size = New System.Drawing.Size(183, 475)
        Me.TreeView1.TabIndex = 1
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBankAdd, Me.mnuBankDelete, Me.MenuItem3, Me.mnuRefreshList})
        '
        'mnuBankAdd
        '
        Me.mnuBankAdd.Index = 0
        Me.mnuBankAdd.Text = "Add Job"
        '
        'mnuBankDelete
        '
        Me.mnuBankDelete.Index = 1
        Me.mnuBankDelete.Text = "Delete Job"
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
        'tbrDel
        '
        Me.tbrDel.ImageIndex = 1
        Me.tbrDel.Name = "tbrDel"
        Me.tbrDel.Tag = "Del"
        '
        'tbrSeparator1
        '
        Me.tbrSeparator1.Name = "tbrSeparator1"
        Me.tbrSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbrAdd
        '
        Me.tbrAdd.ImageIndex = 0
        Me.tbrAdd.Name = "tbrAdd"
        Me.tbrAdd.Tag = "Add"
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbrSeparator0, Me.tbrAdd, Me.tbrDel, Me.tbrRefresh, Me.tbrSeparator1, Me.tbrExit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(780, 44)
        Me.ToolBar.TabIndex = 0
        '
        'tbrSeparator0
        '
        Me.tbrSeparator0.Name = "tbrSeparator0"
        Me.tbrSeparator0.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbrRefresh
        '
        Me.tbrRefresh.ImageIndex = 2
        Me.tbrRefresh.Name = "tbrRefresh"
        Me.tbrRefresh.Tag = "Refresh"
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(182, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(598, 477)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSlateGray
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.cboProcType)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.cbBatchType)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.cbOutputFormat)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.cbFunctionType)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.txtProdName)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.cbCardSetup)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbFileFormat)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lbid)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lbInformation)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(590, 451)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'cboProcType
        '
        Me.cboProcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProcType.Items.AddRange(New Object() {"1 - Standard (unspecified)", "2 - New", "3 - Replacement", "4 - Renewal"})
        Me.cboProcType.Location = New System.Drawing.Point(206, 232)
        Me.cboProcType.Name = "cboProcType"
        Me.cboProcType.Size = New System.Drawing.Size(254, 21)
        Me.cboProcType.TabIndex = 61
        Me.cboProcType.Visible = False
        '
        'Label18
        '
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(19, 231)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 22)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Process Type * "
        Me.Label18.Visible = False
        '
        'cbBatchType
        '
        Me.cbBatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBatchType.Items.AddRange(New Object() {"1 - BAU", "2 - ME"})
        Me.cbBatchType.Location = New System.Drawing.Point(206, 199)
        Me.cbBatchType.Name = "cbBatchType"
        Me.cbBatchType.Size = New System.Drawing.Size(254, 21)
        Me.cbBatchType.TabIndex = 58
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(19, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 23)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Job Batch Type *"
        '
        'cbOutputFormat
        '
        Me.cbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputFormat.Items.AddRange(New Object() {"0 - No Output", "1 - Plain Text", "2 - Encrypted"})
        Me.cbOutputFormat.Location = New System.Drawing.Point(206, 170)
        Me.cbOutputFormat.Name = "cbOutputFormat"
        Me.cbOutputFormat.Size = New System.Drawing.Size(254, 21)
        Me.cbOutputFormat.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(19, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 23)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Output Format *"
        '
        'cbFunctionType
        '
        Me.cbFunctionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFunctionType.Items.AddRange(New Object() {"1 - Import Data", "2 - Update Data", "3 - Export Data"})
        Me.cbFunctionType.Location = New System.Drawing.Point(206, 141)
        Me.cbFunctionType.Name = "cbFunctionType"
        Me.cbFunctionType.Size = New System.Drawing.Size(254, 21)
        Me.cbFunctionType.TabIndex = 4
        '
        'Label34
        '
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(19, 141)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(153, 23)
        Me.Label34.TabIndex = 55
        Me.Label34.Text = "Function Type *"
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(206, 83)
        Me.txtProdName.MaxLength = 50
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(254, 21)
        Me.txtProdName.TabIndex = 2
        '
        'Label30
        '
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(19, 112)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(153, 23)
        Me.Label30.TabIndex = 51
        Me.Label30.Text = "File Format *"
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.Brown
        Me.Label16.Location = New System.Drawing.Point(19, 414)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(171, 15)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "*  Mandatory field"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(21, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 8)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(379, 409)
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
        Me.btnSave.Location = New System.Drawing.Point(293, 409)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbCardSetup
        '
        Me.cbCardSetup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCardSetup.Location = New System.Drawing.Point(206, 284)
        Me.cbCardSetup.Name = "cbCardSetup"
        Me.cbCardSetup.Size = New System.Drawing.Size(254, 21)
        Me.cbCardSetup.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(18, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 23)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Card Setup *"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label9.Location = New System.Drawing.Point(18, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 23)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Card Setup Information:"
        '
        'cbFileFormat
        '
        Me.cbFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileFormat.Items.AddRange(New Object() {"1 - XML", "2 - Fixed Length", "3 - Delimited"})
        Me.cbFileFormat.Location = New System.Drawing.Point(206, 112)
        Me.cbFileFormat.Name = "cbFileFormat"
        Me.cbFileFormat.Size = New System.Drawing.Size(254, 21)
        Me.cbFileFormat.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 23)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Job Description *"
        '
        'lbid
        '
        Me.lbid.ForeColor = System.Drawing.Color.White
        Me.lbid.Location = New System.Drawing.Point(430, 20)
        Me.lbid.Name = "lbid"
        Me.lbid.Size = New System.Drawing.Size(65, 23)
        Me.lbid.TabIndex = 32
        Me.lbid.Text = "Id"
        Me.lbid.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(206, 54)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 21)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Job Name *"
        '
        'lbInformation
        '
        Me.lbInformation.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInformation.ForeColor = System.Drawing.Color.SandyBrown
        Me.lbInformation.Location = New System.Drawing.Point(19, 30)
        Me.lbInformation.Name = "lbInformation"
        Me.lbInformation.Size = New System.Drawing.Size(188, 23)
        Me.lbInformation.TabIndex = 30
        Me.lbInformation.Text = "Job Setup Information:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSlateGray
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.txtfiletypeLength)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtfiletypeStartOffset)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtfiledateLength)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtfiledateStartOffset)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtfilenameLength)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.btnCancel1)
        Me.TabPage2.Controls.Add(Me.btnSave1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtfilenameStartOffset)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(590, 451)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Input File"
        '
        'txtfiletypeLength
        '
        Me.txtfiletypeLength.Location = New System.Drawing.Point(207, 214)
        Me.txtfiletypeLength.MaxLength = 20
        Me.txtfiletypeLength.Name = "txtfiletypeLength"
        Me.txtfiletypeLength.Size = New System.Drawing.Size(70, 21)
        Me.txtfiletypeLength.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(19, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 17)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "File type length "
        '
        'txtfiletypeStartOffset
        '
        Me.txtfiletypeStartOffset.Location = New System.Drawing.Point(207, 187)
        Me.txtfiletypeStartOffset.MaxLength = 20
        Me.txtfiletypeStartOffset.Name = "txtfiletypeStartOffset"
        Me.txtfiletypeStartOffset.Size = New System.Drawing.Size(70, 21)
        Me.txtfiletypeStartOffset.TabIndex = 72
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(19, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 23)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "File type Start Offset "
        '
        'txtfiledateLength
        '
        Me.txtfiledateLength.Location = New System.Drawing.Point(206, 144)
        Me.txtfiledateLength.MaxLength = 20
        Me.txtfiledateLength.Name = "txtfiledateLength"
        Me.txtfiledateLength.Size = New System.Drawing.Size(70, 21)
        Me.txtfiledateLength.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 17)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "File date length *"
        '
        'txtfiledateStartOffset
        '
        Me.txtfiledateStartOffset.Location = New System.Drawing.Point(206, 117)
        Me.txtfiledateStartOffset.MaxLength = 20
        Me.txtfiledateStartOffset.Name = "txtfiledateStartOffset"
        Me.txtfiledateStartOffset.Size = New System.Drawing.Size(70, 21)
        Me.txtfiledateStartOffset.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(18, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 23)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "File date Start Offset *"
        '
        'txtfilenameLength
        '
        Me.txtfilenameLength.Location = New System.Drawing.Point(206, 77)
        Me.txtfilenameLength.MaxLength = 20
        Me.txtfilenameLength.Name = "txtfilenameLength"
        Me.txtfilenameLength.Size = New System.Drawing.Size(70, 21)
        Me.txtfilenameLength.TabIndex = 67
        '
        'Label17
        '
        Me.Label17.ForeColor = System.Drawing.Color.Brown
        Me.Label17.Location = New System.Drawing.Point(19, 414)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(171, 15)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "*  Mandatory field"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(21, 388)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 8)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        '
        'btnCancel1
        '
        Me.btnCancel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel1.ForeColor = System.Drawing.Color.White
        Me.btnCancel1.Location = New System.Drawing.Point(379, 409)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel1.TabIndex = 64
        Me.btnCancel1.Text = "&Cancel"
        Me.btnCancel1.UseVisualStyleBackColor = False
        '
        'btnSave1
        '
        Me.btnSave1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave1.ForeColor = System.Drawing.Color.White
        Me.btnSave1.Location = New System.Drawing.Point(293, 409)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(83, 23)
        Me.btnSave1.TabIndex = 63
        Me.btnSave1.Text = "&Save"
        Me.btnSave1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "File name length *"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "File name Definition"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(18, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(440, 15)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "E.g. File name VEP2041027.script.xml has identifier=VEP at offset=1."
        '
        'txtfilenameStartOffset
        '
        Me.txtfilenameStartOffset.Location = New System.Drawing.Point(206, 50)
        Me.txtfilenameStartOffset.MaxLength = 20
        Me.txtfilenameStartOffset.Name = "txtfilenameStartOffset"
        Me.txtfilenameStartOffset.Size = New System.Drawing.Size(70, 21)
        Me.txtfilenameStartOffset.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "File name Start Offset *"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(672, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(19, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 15)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "*  Mandatory field"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(21, 388)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 8)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(379, 409)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "&Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(293, 409)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 23)
        Me.Button4.TabIndex = 63
        Me.Button4.Text = "&Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(206, 228)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 24)
        Me.CheckBox1.TabIndex = 4
        '
        'Label35
        '
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(18, 234)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(171, 15)
        Me.Label35.TabIndex = 62
        Me.Label35.Text = "Does the file has footer record?"
        '
        'Label36
        '
        Me.Label36.ForeColor = System.Drawing.Color.LightGray
        Me.Label36.Location = New System.Drawing.Point(18, 286)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(442, 17)
        Me.Label36.TabIndex = 52
        Me.Label36.Text = "This also indicate if the BATCH node exists in XML file."
        '
        'Label37
        '
        Me.Label37.ForeColor = System.Drawing.Color.LightGray
        Me.Label37.Location = New System.Drawing.Point(18, 270)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(442, 14)
        Me.Label37.TabIndex = 51
        Me.Label37.Text = "This indicate if the first row of FIXEDLENGTH or DELIMITED file is a header recor" & _
            "d."
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(206, 200)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 24)
        Me.CheckBox2.TabIndex = 3
        '
        'Label38
        '
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(18, 206)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(171, 15)
        Me.Label38.TabIndex = 49
        Me.Label38.Text = "Does the file has header record?"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"XML", "FIXEDLENGTH", "DELIMITED", "CNFILE"})
        Me.ComboBox1.Location = New System.Drawing.Point(206, 176)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(111, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label39
        '
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label39.Location = New System.Drawing.Point(18, 156)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(188, 19)
        Me.Label39.TabIndex = 47
        Me.Label39.Text = "File format"
        '
        'Label40
        '
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(18, 180)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(153, 23)
        Me.Label40.TabIndex = 46
        Me.Label40.Text = "Format *"
        '
        'Label41
        '
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(18, 80)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(153, 17)
        Me.Label41.TabIndex = 43
        Me.Label41.Text = "Start from offset and length *"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(206, 76)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(47, 21)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label42
        '
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label42.Location = New System.Drawing.Point(18, 30)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(188, 19)
        Me.Label42.TabIndex = 41
        Me.Label42.Text = "File name"
        '
        'Label43
        '
        Me.Label43.ForeColor = System.Drawing.Color.LightGray
        Me.Label43.Location = New System.Drawing.Point(18, 112)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(440, 15)
        Me.Label43.TabIndex = 40
        Me.Label43.Text = "E.g. File name VEP2041027.script.xml has identifier=VEP at offset=1."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(206, 50)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label44
        '
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(18, 54)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(153, 23)
        Me.Label44.TabIndex = 39
        Me.Label44.Text = "File name identifier *"
        '
        'Label45
        '
        Me.Label45.ForeColor = System.Drawing.Color.Brown
        Me.Label45.Location = New System.Drawing.Point(19, 414)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(171, 15)
        Me.Label45.TabIndex = 66
        Me.Label45.Text = "*  Mandatory field"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(21, 388)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(440, 8)
        Me.GroupBox4.TabIndex = 65
        Me.GroupBox4.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(379, 409)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 23)
        Me.Button5.TabIndex = 64
        Me.Button5.Text = "&Cancel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(293, 409)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 23)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "&Save"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(206, 228)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 24)
        Me.CheckBox3.TabIndex = 4
        '
        'Label46
        '
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(18, 234)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(171, 15)
        Me.Label46.TabIndex = 62
        Me.Label46.Text = "Does the file has footer record?"
        '
        'Label47
        '
        Me.Label47.ForeColor = System.Drawing.Color.LightGray
        Me.Label47.Location = New System.Drawing.Point(18, 286)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(442, 17)
        Me.Label47.TabIndex = 52
        Me.Label47.Text = "This also indicate if the BATCH node exists in XML file."
        '
        'Label48
        '
        Me.Label48.ForeColor = System.Drawing.Color.LightGray
        Me.Label48.Location = New System.Drawing.Point(18, 270)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(442, 14)
        Me.Label48.TabIndex = 51
        Me.Label48.Text = "This indicate if the first row of FIXEDLENGTH or DELIMITED file is a header recor" & _
            "d."
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(206, 200)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 24)
        Me.CheckBox4.TabIndex = 3
        '
        'Label49
        '
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(18, 206)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(171, 15)
        Me.Label49.TabIndex = 49
        Me.Label49.Text = "Does the file has header record?"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Items.AddRange(New Object() {"XML", "FIXEDLENGTH", "DELIMITED", "CNFILE"})
        Me.ComboBox2.Location = New System.Drawing.Point(206, 176)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(111, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label50
        '
        Me.Label50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label50.Location = New System.Drawing.Point(18, 156)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(188, 19)
        Me.Label50.TabIndex = 47
        Me.Label50.Text = "File format"
        '
        'Label51
        '
        Me.Label51.ForeColor = System.Drawing.Color.White
        Me.Label51.Location = New System.Drawing.Point(18, 180)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(153, 23)
        Me.Label51.TabIndex = 46
        Me.Label51.Text = "Format *"
        '
        'Label52
        '
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.Location = New System.Drawing.Point(18, 80)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(153, 17)
        Me.Label52.TabIndex = 43
        Me.Label52.Text = "Start from offset and length *"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(206, 76)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(47, 21)
        Me.NumericUpDown2.TabIndex = 1
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label53
        '
        Me.Label53.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label53.Location = New System.Drawing.Point(18, 30)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(188, 19)
        Me.Label53.TabIndex = 41
        Me.Label53.Text = "File name"
        '
        'Label54
        '
        Me.Label54.ForeColor = System.Drawing.Color.LightGray
        Me.Label54.Location = New System.Drawing.Point(18, 112)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(440, 15)
        Me.Label54.TabIndex = 40
        Me.Label54.Text = "E.g. File name VEP2041027.script.xml has identifier=VEP at offset=1."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(206, 50)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(255, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Label55
        '
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.Location = New System.Drawing.Point(18, 54)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(153, 23)
        Me.Label55.TabIndex = 39
        Me.Label55.Text = "File name identifier *"
        '
        'frmJobSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(780, 521)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.ToolBar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmJobSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Job Setup"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim boolLoaded As Boolean
    Dim boolChanged As Boolean

    Private Sub frmJobSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAuditLog("Define Job Setup", "Audit Log")
        boolLoaded = False
    End Sub

    Private Sub frmJobSetup_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Try
            If (boolLoaded = True) Then
                Exit Sub
            Else
                boolLoaded = True
            End If

            lbid.Text = NEW_ID

            Me.Refresh()

            LoadAllFormatSetup()
            LoadAllJob()

            If (TreeView1.GetNodeCount(False) > 0) Then
                TreeView1.SelectedNode = TreeView1.Nodes(0)
            End If

            boolChanged = False

        Catch ex As Exception
            MessageBox.Show("frmJobSetup_Activated: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmJobSetup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                If (boolChanged = True) Then
                    If (MessageBox.Show("Job information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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
                If (MessageBox.Show("Job information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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

                    Dim szJobName As String
                    szJobName = NEW_JOB

                    Dim nodp As New Windows.Forms.TreeNode(szJobName, 0, 1)
                    nodp.Tag = NEW_ID
                    TreeView1.Nodes.Add(nodp)
                    dwIndex = nodp.Index
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                    AddNewJob()

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
                    szSQL = "UPDATE JobSetup SET job_deleted=-1 WHERE job_id = " & szId

                    dwReturnRow = ExecuteSQL(szSQL)
                    Select Case dwReturnRow
                        Case -1
                            MessageBox.Show("Error occur when deleting job record.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 0
                            MessageBox.Show("Job record not found. No record deleted.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case Else
                            MessageBox.Show("Job record has been deleted.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UpdateAuditLog("Delete Job Setup ID[" & szId & "]", "Setup")
                            TreeView1.SelectedNode.Remove()
                    End Select

                Case "Refresh"
                    dwIndex = TreeView1.SelectedNode.Index

                    LoadAllJob()
                    Call RefreshInformation(szId)
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                Case "Exit"
                    DialogResult = Windows.Forms.DialogResult.OK

            End Select


        Catch ex As Exception
            'MessageBox.Show("frmJobSetup_ToolBar_ButtonClick: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllJob()

        Try
            TreeView1.Nodes.Clear()

            Dim szJobName As String

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM JobSetup WHERE job_bank_id=" & BankInfo.Id & " AND job_deleted=0 Order by job_fileind ASC"

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("job_id")) = False) Then
                    szJobName = IIf(IsDBNull(datareader("job_fileind")), "", datareader("job_fileind"))

                    Dim nodp As New Windows.Forms.TreeNode(szJobName, 0, 1)
                    nodp.Tag = datareader("job_id")
                    TreeView1.Nodes.Add(nodp)
                End If

            End While

            myconn.Close()

        Catch ex As Exception
            'MessageBox.Show("frmJobSetup_LoadAllJob: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllFormatSetup()

        Try
            Dim szSQL As String
            szSQL = "SELECT cs_id, cs_name FROM CardSetupSpec WHERE job_bank_id=" & UserInfo.BankId & " AND cs_deleted=0 ORDER BY cs_name ASC"

            LoadTableCombo(cbCardSetup, szSQL)

        Catch ex As Exception
            MessageBox.Show("frmJobSetup_LoadAllFormatSetup: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub RefreshInformation(ByVal szId As String)

        Try
            If (szId = "") Then
                Exit Sub
            End If

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            myCmd.Connection = myconn

            'Retrieve the job information
            myCmd.CommandText = "SELECT * FROM JobSetup WHERE job_id=" & szId & " AND job_deleted=0 Order by job_fileind ASC"
            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                'lbid.Text = IIf(IsDBNull(datareader("job_id")), "", datareader("job_id"))
                'txtName.Text = IIf(IsDBNull(datareader("job_fileind")), "", datareader("job_fileind"))
                'txtProdName.Text = IIf(IsDBNull(datareader("job_description")), "", datareader("job_description"))
                'cbFileFormat.SelectedIndex = IIf(IsDBNull(datareader("job_file_format")), -1, datareader("job_file_format") - 1)
                'cbFunctionType.SelectedIndex = IIf(IsDBNull(datareader("job_functype")), -1, datareader("job_functype") - 1)
                'cbOutputFormat.SelectedIndex = IIf(IsDBNull(datareader("job_output_file_fmt")), -1, datareader("job_output_file_fmt"))
                'cbBatchType.SelectedIndex = IIf(IsDBNull(datareader("job_batch_type")), -1, CInt(datareader("job_batch_type")) - 1)

                'cbCardSetup.SelectedIndex = FindComboItem(cbCardSetup, IIf(IsDBNull(datareader("cs_id")), -1, datareader("cs_id")))

                'txtfilenameStartOffset.Text = IIf(IsDBNull(datareader("job_fname_start_pos")), 0, datareader("job_fname_start_pos"))
                'txtfilenameLength.Text = IIf(IsDBNull(datareader("job_fname_length")), 0, datareader("job_fname_length"))
                'txtfiledateStartOffset.Text = IIf(IsDBNull(datareader("job_fdate_start_pos")), 0, datareader("job_fdate_start_pos"))
                'txtfiledateLength.Text = IIf(IsDBNull(datareader("job_fdate_length")), 0, datareader("job_fdate_length"))
                'txtfiletypeStartOffset.Text = IIf(IsDBNull(datareader("job_ftype_start_pos")), 0, datareader("job_ftype_start_pos"))
                'txtfiletypeLength.Text = IIf(IsDBNull(datareader("job_ftype_length")), 0, datareader("job_ftype_length"))

                'danny lim, 110325, convert iif to standard if and added a new evaluation for a new field - job process
                If (IsDBNull(datareader("job_id"))) Then lbid.Text = "" Else lbid.Text = datareader("job_id")
                If (IsDBNull(datareader("job_fileind"))) Then txtName.Text = "" Else txtName.Text = datareader("job_fileind")
                If (IsDBNull(datareader("job_description"))) Then txtProdName.Text = "" Else txtProdName.Text = datareader("job_description")

                If (IsDBNull(datareader("job_file_format"))) Then cbFileFormat.SelectedIndex = -1 Else cbFileFormat.SelectedIndex = datareader("job_file_format") - 1
                If (IsDBNull(datareader("job_functype"))) Then cbFunctionType.SelectedIndex = -1 Else cbFunctionType.SelectedIndex = datareader("job_functype") - 1
                'If (IsDBNull(datareader("job_output_file_fmt"))) Then cbOutputFormat.SelectedIndex = -1 Else cbOutputFormat.SelectedIndex = datareader("job_output_file_fmt") - 1
                If (IsDBNull(datareader("job_output_file_fmt"))) Then cbOutputFormat.SelectedIndex = -1 Else cbOutputFormat.SelectedIndex = datareader("job_output_file_fmt")
                If (IsDBNull(datareader("job_batch_type"))) Then cbBatchType.SelectedIndex = -1 Else cbBatchType.SelectedIndex = datareader("job_batch_type") - 1

                If (IsDBNull(datareader("cs_id"))) Then cbCardSetup.SelectedIndex = -1 Else cbCardSetup.SelectedIndex = FindComboItem(cbCardSetup, datareader("cs_id"))

                If (IsDBNull(datareader("job_fname_start_pos"))) Then txtfilenameStartOffset.Text = 0 Else txtfilenameStartOffset.Text = datareader("job_fname_start_pos")
                If (IsDBNull(datareader("job_fname_length"))) Then txtfilenameLength.Text = 0 Else txtfilenameLength.Text = datareader("job_fname_length")
                If (IsDBNull(datareader("job_fdate_start_pos"))) Then txtfiledateStartOffset.Text = 0 Else txtfiledateStartOffset.Text = datareader("job_fdate_start_pos")
                If (IsDBNull(datareader("job_fdate_length"))) Then txtfiledateLength.Text = 0 Else txtfiledateLength.Text = datareader("job_fdate_length")
                If (IsDBNull(datareader("job_ftype_start_pos"))) Then txtfiletypeStartOffset.Text = 0 Else txtfiletypeStartOffset.Text = datareader("job_ftype_start_pos")
                If (IsDBNull(datareader("job_ftype_length"))) Then txtfiletypeLength.Text = 0 Else txtfiletypeLength.Text = datareader("job_ftype_length")

                'If (IsDBNull(datareader("job_procid"))) Then cboProcType.SelectedIndex = -1 Else cboProcType.SelectedIndex = datareader("job_procid") - 1

                Exit While
            End While

            datareader.Close()
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmJobSetup_RefreshInformation: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddNewJob()

        Try
            lbid.Text = NEW_ID
            txtName.Text = ""
            txtProdName.Text = ""
            cbFileFormat.SelectedIndex = -1
            cbFunctionType.SelectedIndex = -1

            cbFileFormat.SelectedIndex = -1
            cbBatchType.SelectedIndex = -1
            cbCardSetup.SelectedIndex = -1
            txtfilenameStartOffset.Text = ""
            txtfilenameLength.Text = ""
            txtfiledateStartOffset.Text = ""
            txtfiledateLength.Text = ""
            txtfiletypeStartOffset.Text = ""
            txtfiletypeLength.Text = ""

            txtName.Focus()

        Catch ex As Exception
            MessageBox.Show("frmJobSetup_AddNewJob: Exception-" & ex.Message)
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
            'MessageBox.Show("frmJobSetup_RemoveNewId: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click, btnCancel1.Click

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
            MessageBox.Show("frmJobSetup_btnCancel_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click, btnSave1.Click

        Try
            Dim szId As String
            szId = lbid.Text

            ErrorProvider1.SetError(txtName, "")
            ErrorProvider1.SetError(txtProdName, "")
            ErrorProvider1.SetError(cbFileFormat, "")
            ErrorProvider1.SetError(cbCardSetup, "")
            ErrorProvider1.SetError(cbFunctionType, "")
            ErrorProvider1.SetError(cbOutputFormat, "")
            ErrorProvider1.SetError(cbBatchType, "")
            ErrorProvider1.SetError(txtfilenameStartOffset, "")
            ErrorProvider1.SetError(txtfilenameLength, "")
            ErrorProvider1.SetError(txtfiledateStartOffset, "")
            ErrorProvider1.SetError(txtfiledateLength, "")
            ErrorProvider1.SetError(txtfiletypeStartOffset, "")
            ErrorProvider1.SetError(txtfiletypeLength, "")


            If (szId = "") Then
                Exit Sub
            End If

            If (txtName.Text = "") Then
                ErrorProvider1.SetError(txtName, "Job name cannot be blank.")
                Exit Sub
            End If

            If (cbFileFormat.SelectedIndex = -1) Then
                ErrorProvider1.SetError(cbFileFormat, "File Format cannot be blank.")
                Exit Sub
            End If

            If (cbCardSetup.SelectedIndex = -1) Then
                ErrorProvider1.SetError(cbCardSetup, "Format Setup cannot be blank.")
                Exit Sub
            End If

            If (cbOutputFormat.SelectedIndex = -1) Then
                ErrorProvider1.SetError(cbOutputFormat, "Output Format cannot be blank.")
                Exit Sub
            End If

            If (cbFunctionType.SelectedIndex = -1) Then
                ErrorProvider1.SetError(cbFunctionType, "Function Type cannot be blank.")
                Exit Sub
            End If

            If (cbBatchType.SelectedIndex = -1) Then
                ErrorProvider1.SetError(cbBatchType, "Batch Type cannot be blank.")
                Exit Sub
            End If

            'If (Me.cboProcType.SelectedIndex = -1) Then
            '    ErrorProvider1.SetError(cboProcType, "Process Type cannot be blank.")
            '    Exit Sub
            'End If

            If (txtfilenameStartOffset.Text = "") Then
                ErrorProvider1.SetError(txtfilenameStartOffset, "File name start offset cannot be blank.")
                Exit Sub
            End If

            If (txtfilenameLength.Text = "") Then
                ErrorProvider1.SetError(txtfilenameLength, "File name length cannot be blank.")
                Exit Sub
            End If

            If (txtfiledateStartOffset.Text = "") Then
                ErrorProvider1.SetError(txtfiledateStartOffset, "File date start offset cannot be blank.")
                Exit Sub
            End If

            If (txtfiledateLength.Text = "") Then
                ErrorProvider1.SetError(txtfiledateLength, "File date length cannot be blank.")
                Exit Sub
            End If

            If (txtfiletypeStartOffset.Text = "") Then
                ErrorProvider1.SetError(txtfiletypeStartOffset, "File type start offset cannot be blank.")
                Exit Sub
            End If

            If (txtfiletypeLength.Text = "") Then
                ErrorProvider1.SetError(txtfiletypeLength, "File type length cannot be blank.")
                Exit Sub
            End If
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim szName As String
            Dim szProdName As String
            Dim dwFuncType As Integer
            Dim dwFileFormat As Integer
            Dim dwOutputFormat As Integer
            Dim dwBatchtype As Integer

            Dim lngCardSetup As Long
            Dim dwfilenameStartOff As Integer
            Dim dwfilenameLen As Integer
            Dim dwfiledateStartOff As Integer
            Dim dwfiledateLen As Integer
            Dim dwfiletypeStartOff As Integer
            Dim dwfiletypeLen As Integer
            'Dim dwProcType As Integer

            szName = txtName.Text                       'job_fileind
            szProdName = txtProdName.Text               'job_description
            dwFuncType = cbFunctionType.SelectedIndex + 1       'job_functype
            dwFileFormat = cbFileFormat.SelectedIndex + 1           'job_file_format
            dwOutputFormat = cbOutputFormat.SelectedIndex          'job_output_file_fmt
            dwBatchtype = cbBatchType.SelectedIndex + 1             'job_batch_type
            'dwProcType = cboProcType.SelectedIndex + 1

            lngCardSetup = FindComboId(cbCardSetup, cbCardSetup.SelectedIndex)    'cs_id

            dwfilenameStartOff = Val(txtfilenameStartOffset.Text)                         'job_fname_start_pos
            dwfilenameLen = Val(txtfilenameLength.Text)             'job_fname_length
            dwfiledateStartOff = Val(txtfiledateStartOffset.Text)   'job_fdate_start_pos
            dwfiledateLen = Val(txtfiledateLength.Text)             'job_fdate_length
            dwfiletypeStartOff = Val(txtfiletypeStartOffset.Text)   'job_ftype_start_pos
            dwfiletypeLen = Val(txtfiletypeLength.Text)             'job_ftype_length

            Dim szSQL As String = ""
            Dim dwReturnRow As Integer

            If (szId = NEW_ID) Then
                szSQL = "INSERT INTO JobSetup (job_fileind, job_description, job_file_format, job_functype, job_output_file_fmt, cs_id, job_bank_id, " & _
                        "job_fname_start_pos, job_fname_length, job_fdate_start_pos, job_fdate_length, job_ftype_start_pos, job_ftype_length, job_batch_type, job_deleted) VALUES (" & _
                        "'" & szName & "','" & szProdName & "'," & dwFileFormat & "," & dwFuncType & "," & dwOutputFormat & "," & lngCardSetup & "," & BankInfo.Id & _
                        "," & dwfilenameStartOff & "," & dwfilenameLen & "," & dwfiledateStartOff & "," & dwfiledateLen & "," & dwfiletypeStartOff & "," & dwfiletypeLen & "," & dwBatchtype & ",0)"
            Else
                szSQL = "UPDATE JobSetup SET job_fileind='" & szName & "', job_description='" & szProdName & "', job_file_format=" & dwFileFormat & ", job_functype=" & dwFuncType & ", job_output_file_fmt=" & dwOutputFormat & _
                        ", cs_id=" & lngCardSetup & ", job_fname_start_pos=" & dwfilenameStartOff & ", job_fname_length=" & dwfilenameLen & ", job_fdate_start_pos=" & dwfiledateStartOff & _
                        ", job_fdate_length=" & dwfiledateLen & ", job_ftype_start_pos=" & dwfiletypeStartOff & ", job_ftype_length=" & dwfiletypeLen & ", job_batch_type=" & dwBatchtype & " WHERE job_id =" & szId
            End If

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving job record.", "Job", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("Job record not found. No record deleted.", "Job", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            boolChanged = False

            UpdateAuditLog("Update Job Setup " & szName, "Setup")
            MessageBox.Show("Job information has been saved.", "Saving Job", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (szId = NEW_ID) Then
                TreeView1.SelectedNode.Tag = szId
            End If

            TreeView1.SelectedNode.Text = szName

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmJobSetup_btnSave_Click: Exception-" & ex.Message)
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
            MessageBox.Show("frmJobSetup_TreeView1_AfterSelect: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        If (boolChanged = True) Then
            If (MessageBox.Show("Job information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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

            Dim szJobName As String
            szJobName = NEW_JOB

            Dim nodp As New Windows.Forms.TreeNode(szJobName, 0, 1)
            nodp.Tag = NEW_ID
            TreeView1.Nodes.Add(nodp)
            dwIndex = nodp.Index
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

            AddNewJob()

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
            szSQL = "UPDATE JobSetup SET job_deleted=-1 WHERE job_id = " & szId

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting job record.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0
                    MessageBox.Show("Job record not found. No record deleted.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("Job record has been deleted.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAuditLog("Delete Job Setup ID[" & szId & "]", "Setup")
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

            LoadAllJob()
            Call RefreshInformation(szId)
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

        Catch ex As Exception
            'MessageBox.Show("frmBank_mnuRefreshList_Click: Exception-" & ex.Message)
        End Try

    End Sub
End Class
