Public Class frmFormatSetup
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
    Friend WithEvents tbrSeparator0 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbrAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrDel As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrSeparator1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuBankAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBankDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefreshList As System.Windows.Forms.MenuItem
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlField As System.Windows.Forms.Panel
    Friend WithEvents lbPrevious As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCol As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents chkVerification As System.Windows.Forms.CheckBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownLen1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownOffset1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtXmlnode As System.Windows.Forms.TextBox
    Friend WithEvents chkBatch As System.Windows.Forms.CheckBox
    Friend WithEvents rbHex As System.Windows.Forms.RadioButton
    Friend WithEvents rbAsc As System.Windows.Forms.RadioButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents lbIndex As System.Windows.Forms.Label
    Friend WithEvents lvField As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoveField As System.Windows.Forms.Button
    Friend WithEvents btnAddField As System.Windows.Forms.Button
    Friend WithEvents btnEditField As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbInformation As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tbrCopy As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnTemplate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormatSetup))
        Me.tbrSeparator0 = New System.Windows.Forms.ToolBarButton
        Me.tbrRefresh = New System.Windows.Forms.ToolBarButton
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbrAdd = New System.Windows.Forms.ToolBarButton
        Me.tbrCopy = New System.Windows.Forms.ToolBarButton
        Me.tbrDel = New System.Windows.Forms.ToolBarButton
        Me.tbrSeparator1 = New System.Windows.Forms.ToolBarButton
        Me.tbrExit = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuBankAdd = New System.Windows.Forms.MenuItem
        Me.mnuBankDelete = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuRefreshList = New System.Windows.Forms.MenuItem
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlField = New System.Windows.Forms.Panel
        Me.lbPrevious = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbTitle = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtCol = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtRow = New System.Windows.Forms.TextBox
        Me.chkVerification = New System.Windows.Forms.CheckBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.NumericUpDownLen1 = New System.Windows.Forms.NumericUpDown
        Me.Label25 = New System.Windows.Forms.Label
        Me.NumericUpDownOffset1 = New System.Windows.Forms.NumericUpDown
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtXmlnode = New System.Windows.Forms.TextBox
        Me.chkBatch = New System.Windows.Forms.CheckBox
        Me.rbHex = New System.Windows.Forms.RadioButton
        Me.rbAsc = New System.Windows.Forms.RadioButton
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.lbIndex = New System.Windows.Forms.Label
        Me.lvField = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.btnRemoveField = New System.Windows.Forms.Button
        Me.btnAddField = New System.Windows.Forms.Button
        Me.btnEditField = New System.Windows.Forms.Button
        Me.btnTemplate = New System.Windows.Forms.Button
        Me.lbid = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbInformation = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlField.SuspendLayout()
        CType(Me.NumericUpDownLen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownOffset1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbrSeparator0
        '
        Me.tbrSeparator0.Name = "tbrSeparator0"
        Me.tbrSeparator0.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbrRefresh
        '
        Me.tbrRefresh.ImageIndex = 3
        Me.tbrRefresh.Name = "tbrRefresh"
        Me.tbrRefresh.Tag = "Refresh"
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbrSeparator0, Me.tbrAdd, Me.tbrCopy, Me.tbrDel, Me.tbrRefresh, Me.tbrSeparator1, Me.tbrExit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(793, 44)
        Me.ToolBar.TabIndex = 5
        '
        'tbrAdd
        '
        Me.tbrAdd.ImageIndex = 0
        Me.tbrAdd.Name = "tbrAdd"
        Me.tbrAdd.Tag = "Add"
        '
        'tbrCopy
        '
        Me.tbrCopy.ImageIndex = 1
        Me.tbrCopy.Name = "tbrCopy"
        Me.tbrCopy.Tag = "Copy"
        '
        'tbrDel
        '
        Me.tbrDel.ImageIndex = 2
        Me.tbrDel.Name = "tbrDel"
        Me.tbrDel.Tag = "Del"
        '
        'tbrSeparator1
        '
        Me.tbrSeparator1.Name = "tbrSeparator1"
        Me.tbrSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbrExit
        '
        Me.tbrExit.ImageIndex = 4
        Me.tbrExit.Name = "tbrExit"
        Me.tbrExit.Tag = "Exit"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "Copy.ico")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(672, -15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
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
        Me.TreeView1.Size = New System.Drawing.Size(183, 513)
        Me.TreeView1.TabIndex = 6
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pnlField)
        Me.Panel1.Controls.Add(Me.lvField)
        Me.Panel1.Controls.Add(Me.btnRemoveField)
        Me.Panel1.Controls.Add(Me.btnAddField)
        Me.Panel1.Controls.Add(Me.btnEditField)
        Me.Panel1.Controls.Add(Me.btnTemplate)
        Me.Panel1.Controls.Add(Me.lbid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbInformation)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Location = New System.Drawing.Point(182, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 465)
        Me.Panel1.TabIndex = 52
        '
        'pnlField
        '
        Me.pnlField.BackColor = System.Drawing.Color.SlateGray
        Me.pnlField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlField.Controls.Add(Me.lbPrevious)
        Me.pnlField.Controls.Add(Me.btnClose)
        Me.pnlField.Controls.Add(Me.lbTitle)
        Me.pnlField.Controls.Add(Me.Label30)
        Me.pnlField.Controls.Add(Me.btnClear)
        Me.pnlField.Controls.Add(Me.btnOK)
        Me.pnlField.Controls.Add(Me.Label29)
        Me.pnlField.Controls.Add(Me.txtCol)
        Me.pnlField.Controls.Add(Me.Label27)
        Me.pnlField.Controls.Add(Me.Label28)
        Me.pnlField.Controls.Add(Me.txtRow)
        Me.pnlField.Controls.Add(Me.chkVerification)
        Me.pnlField.Controls.Add(Me.Label26)
        Me.pnlField.Controls.Add(Me.Label22)
        Me.pnlField.Controls.Add(Me.Label24)
        Me.pnlField.Controls.Add(Me.NumericUpDownLen1)
        Me.pnlField.Controls.Add(Me.Label25)
        Me.pnlField.Controls.Add(Me.NumericUpDownOffset1)
        Me.pnlField.Controls.Add(Me.Label23)
        Me.pnlField.Controls.Add(Me.txtXmlnode)
        Me.pnlField.Controls.Add(Me.chkBatch)
        Me.pnlField.Controls.Add(Me.rbHex)
        Me.pnlField.Controls.Add(Me.rbAsc)
        Me.pnlField.Controls.Add(Me.Label21)
        Me.pnlField.Controls.Add(Me.Label20)
        Me.pnlField.Controls.Add(Me.txtDesc)
        Me.pnlField.Controls.Add(Me.Label19)
        Me.pnlField.Controls.Add(Me.txtValue)
        Me.pnlField.Controls.Add(Me.lbIndex)
        Me.pnlField.Location = New System.Drawing.Point(26, 57)
        Me.pnlField.Name = "pnlField"
        Me.pnlField.Size = New System.Drawing.Size(555, 384)
        Me.pnlField.TabIndex = 54
        Me.pnlField.Visible = False
        '
        'lbPrevious
        '
        Me.lbPrevious.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrevious.ForeColor = System.Drawing.Color.White
        Me.lbPrevious.Location = New System.Drawing.Point(42, 26)
        Me.lbPrevious.Name = "lbPrevious"
        Me.lbPrevious.Size = New System.Drawing.Size(266, 16)
        Me.lbPrevious.TabIndex = 75
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(446, 340)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 23)
        Me.btnClose.TabIndex = 73
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbTitle
        '
        Me.lbTitle.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.Black
        Me.lbTitle.Location = New System.Drawing.Point(10, 10)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(177, 16)
        Me.lbTitle.TabIndex = 72
        Me.lbTitle.Text = "Add Field"
        '
        'Label30
        '
        Me.Label30.ForeColor = System.Drawing.Color.Brown
        Me.Label30.Location = New System.Drawing.Point(44, 346)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(171, 15)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "*  Mandatory field"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(360, 340)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 23)
        Me.btnClear.TabIndex = 69
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(274, 340)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 68
        Me.btnOK.Text = "&Save"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(242, 294)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(94, 16)
        Me.Label29.TabIndex = 67
        Me.Label29.Text = "Column delimiter"
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(344, 290)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(82, 21)
        Me.txtCol.TabIndex = 66
        '
        'Label27
        '
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label27.Location = New System.Drawing.Point(42, 270)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(267, 19)
        Me.Label27.TabIndex = 65
        Me.Label27.Text = "(Applicable to DELIMITED file only)"
        '
        'Label28
        '
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(42, 294)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(94, 16)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "Row delimiter"
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(138, 290)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(82, 21)
        Me.txtRow.TabIndex = 63
        '
        'chkVerification
        '
        Me.chkVerification.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVerification.ForeColor = System.Drawing.Color.White
        Me.chkVerification.Location = New System.Drawing.Point(42, 124)
        Me.chkVerification.Name = "chkVerification"
        Me.chkVerification.Size = New System.Drawing.Size(165, 24)
        Me.chkVerification.TabIndex = 62
        Me.chkVerification.Text = "Data verification?"
        '
        'Label26
        '
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label26.Location = New System.Drawing.Point(42, 216)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(267, 19)
        Me.Label26.TabIndex = 61
        Me.Label26.Text = "(Applicable to FIXEDLENGTH file only)"
        '
        'Label22
        '
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label22.Location = New System.Drawing.Point(42, 162)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(267, 19)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "(Applicable to XML file only)"
        '
        'Label24
        '
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(249, 238)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(9, 17)
        Me.Label24.TabIndex = 55
        Me.Label24.Text = "/"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDownLen1
        '
        Me.NumericUpDownLen1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownLen1.Location = New System.Drawing.Point(261, 236)
        Me.NumericUpDownLen1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumericUpDownLen1.Name = "NumericUpDownLen1"
        Me.NumericUpDownLen1.Size = New System.Drawing.Size(53, 21)
        Me.NumericUpDownLen1.TabIndex = 54
        Me.NumericUpDownLen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(42, 240)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(149, 17)
        Me.Label25.TabIndex = 53
        Me.Label25.Text = "Start from offset and length"
        '
        'NumericUpDownOffset1
        '
        Me.NumericUpDownOffset1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownOffset1.Location = New System.Drawing.Point(192, 236)
        Me.NumericUpDownOffset1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumericUpDownOffset1.Name = "NumericUpDownOffset1"
        Me.NumericUpDownOffset1.Size = New System.Drawing.Size(53, 21)
        Me.NumericUpDownOffset1.TabIndex = 52
        Me.NumericUpDownOffset1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(42, 186)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 16)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "XML node"
        '
        'txtXmlnode
        '
        Me.txtXmlnode.Location = New System.Drawing.Point(192, 182)
        Me.txtXmlnode.Name = "txtXmlnode"
        Me.txtXmlnode.Size = New System.Drawing.Size(283, 21)
        Me.txtXmlnode.TabIndex = 48
        '
        'chkBatch
        '
        Me.chkBatch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBatch.ForeColor = System.Drawing.Color.White
        Me.chkBatch.Location = New System.Drawing.Point(288, 124)
        Me.chkBatch.Name = "chkBatch"
        Me.chkBatch.Size = New System.Drawing.Size(186, 24)
        Me.chkBatch.TabIndex = 47
        Me.chkBatch.Text = "This field is a batch header?"
        '
        'rbHex
        '
        Me.rbHex.ForeColor = System.Drawing.Color.White
        Me.rbHex.Location = New System.Drawing.Point(236, 98)
        Me.rbHex.Name = "rbHex"
        Me.rbHex.Size = New System.Drawing.Size(51, 24)
        Me.rbHex.TabIndex = 45
        Me.rbHex.Text = "Hex"
        '
        'rbAsc
        '
        Me.rbAsc.Checked = True
        Me.rbAsc.ForeColor = System.Drawing.Color.White
        Me.rbAsc.Location = New System.Drawing.Point(192, 98)
        Me.rbAsc.Name = "rbAsc"
        Me.rbAsc.Size = New System.Drawing.Size(51, 24)
        Me.rbAsc.TabIndex = 44
        Me.rbAsc.TabStop = True
        Me.rbAsc.Text = "Asc"
        '
        'Label21
        '
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(42, 102)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 16)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Type of value"
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(42, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 16)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Description"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(192, 72)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(283, 21)
        Me.txtDesc.TabIndex = 41
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(42, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 16)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Name *"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(192, 48)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(283, 21)
        Me.txtValue.TabIndex = 0
        '
        'lbIndex
        '
        Me.lbIndex.ForeColor = System.Drawing.Color.Black
        Me.lbIndex.Location = New System.Drawing.Point(444, 8)
        Me.lbIndex.Name = "lbIndex"
        Me.lbIndex.Size = New System.Drawing.Size(94, 16)
        Me.lbIndex.TabIndex = 74
        Me.lbIndex.Visible = False
        '
        'lvField
        '
        Me.lvField.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvField.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lvField.FullRowSelect = True
        Me.lvField.GridLines = True
        Me.lvField.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvField.Location = New System.Drawing.Point(26, 122)
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(555, 222)
        Me.lvField.TabIndex = 53
        Me.lvField.UseCompatibleStateImageBehavior = False
        Me.lvField.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data Format"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 48
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Header?"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 55
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "XML node"
        Me.ColumnHeader5.Width = 132
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Start position"
        Me.ColumnHeader6.Width = 50
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Length"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 50
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Row delimiter"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Col delimiter"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Verification flag"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 90
        '
        'btnRemoveField
        '
        Me.btnRemoveField.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRemoveField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveField.ForeColor = System.Drawing.Color.White
        Me.btnRemoveField.Location = New System.Drawing.Point(198, 350)
        Me.btnRemoveField.Name = "btnRemoveField"
        Me.btnRemoveField.Size = New System.Drawing.Size(83, 23)
        Me.btnRemoveField.TabIndex = 57
        Me.btnRemoveField.Text = "&Remove Field"
        Me.btnRemoveField.UseVisualStyleBackColor = False
        '
        'btnAddField
        '
        Me.btnAddField.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddField.ForeColor = System.Drawing.Color.White
        Me.btnAddField.Location = New System.Drawing.Point(26, 350)
        Me.btnAddField.Name = "btnAddField"
        Me.btnAddField.Size = New System.Drawing.Size(83, 23)
        Me.btnAddField.TabIndex = 55
        Me.btnAddField.Text = "&Add Field"
        Me.btnAddField.UseVisualStyleBackColor = False
        '
        'btnEditField
        '
        Me.btnEditField.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEditField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditField.ForeColor = System.Drawing.Color.White
        Me.btnEditField.Location = New System.Drawing.Point(112, 350)
        Me.btnEditField.Name = "btnEditField"
        Me.btnEditField.Size = New System.Drawing.Size(83, 23)
        Me.btnEditField.TabIndex = 56
        Me.btnEditField.Text = "&Edit Field"
        Me.btnEditField.UseVisualStyleBackColor = False
        '
        'btnTemplate
        '
        Me.btnTemplate.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTemplate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTemplate.ForeColor = System.Drawing.Color.White
        Me.btnTemplate.Location = New System.Drawing.Point(481, 350)
        Me.btnTemplate.Name = "btnTemplate"
        Me.btnTemplate.Size = New System.Drawing.Size(98, 23)
        Me.btnTemplate.TabIndex = 58
        Me.btnTemplate.Text = "&Use Template"
        Me.btnTemplate.UseVisualStyleBackColor = False
        '
        'lbid
        '
        Me.lbid.ForeColor = System.Drawing.Color.White
        Me.lbid.Location = New System.Drawing.Point(502, 22)
        Me.lbid.Name = "lbid"
        Me.lbid.Size = New System.Drawing.Size(65, 23)
        Me.lbid.TabIndex = 17
        Me.lbid.Text = "Id"
        Me.lbid.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(26, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Field Information:"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 23)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Format Name *"
        '
        'lbInformation
        '
        Me.lbInformation.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInformation.ForeColor = System.Drawing.Color.SandyBrown
        Me.lbInformation.Location = New System.Drawing.Point(26, 36)
        Me.lbInformation.Name = "lbInformation"
        Me.lbInformation.Size = New System.Drawing.Size(188, 23)
        Me.lbInformation.TabIndex = 60
        Me.lbInformation.Text = "Format Setup Information:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(214, 58)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 21)
        Me.txtName.TabIndex = 59
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(26, 394)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 8)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(494, 418)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 63
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(408, 418)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 23)
        Me.btnSave.TabIndex = 62
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.Brown
        Me.Label16.Location = New System.Drawing.Point(49, 420)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(171, 15)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "*  Mandatory field"
        '
        'frmFormatSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(793, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFormatSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Format Setup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlField.ResumeLayout(False)
        Me.pnlField.PerformLayout()
        CType(Me.NumericUpDownLen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownOffset1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim boolLoaded As Boolean
    Dim boolChanged As Boolean

    Private Sub frmJobSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            LoadAllFormat()

            If (TreeView1.GetNodeCount(False) > 0) Then
                TreeView1.SelectedNode = TreeView1.Nodes(0)
            End If

            boolChanged = False

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_Activated: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub frmJobSetup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                If (boolChanged = True) Then
                    If (MessageBox.Show("Format information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Format Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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
                If (MessageBox.Show("Format information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Format Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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
                    szJobName = NEW_FORMAT

                    Dim nodp As New Windows.Forms.TreeNode(szJobName, 0, 1)
                    nodp.Tag = NEW_ID
                    TreeView1.Nodes.Add(nodp)
                    dwIndex = nodp.Index
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                    AddNewFormat()

                Case "Copy"
                    If (szId = NEW_ID) Then
                        Exit Sub
                    End If

                    Dim szFormatName As String
                    szFormatName = InputBox("Please enter new format setup name.", "Copy")

                    If (Trim(szFormatName) = "") Then
                        Exit Sub
                    End If

                    Dim szNewId As String = FAIL_ID
                    If (CopyFormatSetup(szFormatName, szNewId) = True) Then
                        Call RefreshInformation(szNewId)
                    Else
                        MessageBox.Show("Error occur when copying data record.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

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
                    szSQL = "UPDATE FormatSetup SET fs_deleted=-1 WHERE fs_id = " & szId

                    dwReturnRow = ExecuteSQL(szSQL)
                    Select Case dwReturnRow
                        Case -1
                            MessageBox.Show("Error occur when deleting job record.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 0
                            MessageBox.Show("Job record not found. No record deleted.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case Else
                            MessageBox.Show("Job record has been deleted.", "Job Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TreeView1.SelectedNode.Remove()
                    End Select

                Case "Refresh"
                    dwIndex = TreeView1.SelectedNode.Index

                    LoadAllFormat()
                    Call RefreshInformation(szId)
                    TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

                Case "Exit"
                    DialogResult = Windows.Forms.DialogResult.OK

            End Select


        Catch ex As Exception
            'MessageBox.Show("frmFormatSetup_ToolBar_ButtonClick: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllFormat()

        Try
            TreeView1.Nodes.Clear()

            Dim szJobName As String

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim strSQL As String = "SELECT * FROM FormatSetup WHERE fs_bank_id=" & UserInfo.BankId & " AND fs_deleted=0 Order by fs_name ASC"

            Dim myCmd As New oledb.oledbCommand(strSQL, myconn)
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            datareader = myCmd.ExecuteReader()
            While datareader.Read()

                If (IsDBNull(datareader("fs_id")) = False) Then
                    szJobName = IIf(IsDBNull(datareader("fs_name")), "", datareader("fs_name"))

                    Dim nodp As New Windows.Forms.TreeNode(szJobName, 0, 1)
                    nodp.Tag = datareader("fs_id")
                    TreeView1.Nodes.Add(nodp)
                End If

            End While

            myconn.Close()

        Catch ex As Exception
            'MessageBox.Show("frmFormatSetup_LoadAllJob: Exception-" & ex.Message)
        End Try

    End Sub

    Private Function CopyFormatSetup(ByVal szFormatName As String, ByRef szNewId As String) As Boolean

        Try
            Dim szId As String

            If (szFormatName = "") Then
                Return False
                Exit Function
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim szName As String

            szName = szFormatName

            Dim szSQL As String
            Dim dwReturnRow As Integer

            szSQL = "INSERT INTO FormatSetup (fs_name, fs_bank_id) VALUES ('" & szName & "'," & UserInfo.BankId & ")"

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving format setup record.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                Case 0
                    MessageBox.Show("Format setup record not found. No record deleted.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
            End Select

            'Retrieve the newly generated job_id for new record
            Dim lngFormatId As Long
            lngFormatId = GetCurrentId("FormatSetup", "fs_id")

            If (lngFormatId = FAIL_ID) Then
                MessageBox.Show("Error occur when retrieving last format id.", "Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If

            szId = CStr(lngFormatId)
            szNewId = szId

            'Field value
            Dim dwFldSeq As Integer
            Dim szFldName As String
            Dim szFldDesc As String
            Dim dwFldValType As Integer
            Dim dwFldHeader As Integer
            Dim szFldXMLnode As String
            Dim dwFldStartPos As Integer
            Dim dwFldLen As Integer
            Dim szFldRow As String
            Dim szFldCol As String
            Dim dwFldVerification As Integer

            Dim dwIndex As Integer
            Dim dwTotal As Integer

            dwTotal = lvField.Items.Count - 1

            For dwIndex = 0 To dwTotal
                dwFldSeq = dwIndex + 1
                szFldName = lvField.Items(dwIndex).Text
                szFldDesc = lvField.Items(dwIndex).SubItems(1).Text
                dwFldValType = IIf(lvField.Items(dwIndex).SubItems(2).Text = "Asc", DATA_FORMAT.ASC, DATA_FORMAT.HEX)
                dwFldHeader = IIf(lvField.Items(dwIndex).SubItems(3).Text = "Yes", -1, 0)
                szFldXMLnode = lvField.Items(dwIndex).SubItems(4).Text
                dwFldStartPos = CInt(lvField.Items(dwIndex).SubItems(5).Text)
                dwFldLen = CInt(lvField.Items(dwIndex).SubItems(6).Text)
                szFldRow = lvField.Items(dwIndex).SubItems(7).Text
                szFldCol = lvField.Items(dwIndex).SubItems(8).Text
                dwFldVerification = IIf(lvField.Items(dwIndex).SubItems(9).Text = "Yes", -1, 0)

                szSQL = "INSERT INTO Format (fs_id, fmt_field_seq, fmt_field_name, fmt_field_desc, " & _
                        "fmt_field_valtype, fmt_batch_header, fmt_xml_node, fmt_start_pos, fmt_length, " & _
                        "fmt_row_delimiter, fmt_col_delimiter, fmt_verification_flag ) VALUES (" & szId & "," & dwFldSeq & ",'" & szFldName & "','" & szFldDesc & _
                        "'," & dwFldValType & "," & dwFldHeader & ",'" & szFldXMLnode & "'," & dwFldStartPos & "," & dwFldLen & _
                        ",'" & szFldRow & "','" & szFldCol & "'," & dwFldVerification & ")"

                dwReturnRow = ExecuteSQL(szSQL)
                If (dwReturnRow <> 1) Then
                    MessageBox.Show("Error occur when saving format's field.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If

            Next dwIndex

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            MessageBox.Show("Format setup information has been copied.", "Fromat Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAllFormat()

            Return True

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmDataSetup_CopyFormatSetup: Exception-" & ex.Message)
            Return False
        End Try

    End Function

    Private Sub RefreshInformation(ByVal szId As String)

        Try
            If (szId = "") Then
                Exit Sub
            End If

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            Dim datareader As oledb.oledbDataReader = Nothing

            myconn.Open()
            myCmd.Connection = myconn

            'Retrieve the job information
            myCmd.CommandText = "SELECT * FROM FormatSetup WHERE fs_id=" & szId & " AND fs_deleted=0 Order by fs_name ASC"
            datareader = myCmd.ExecuteReader()

            While datareader.Read()

                lbid.Text = IIf(IsDBNull(datareader("fs_id")), "", datareader("fs_id"))
                txtName.Text = IIf(IsDBNull(datareader("fs_name")), "", datareader("fs_name"))

                Exit While
            End While

            datareader.Close()


            'Retrieve format field tie to the job_id
            Dim dwSeq As Integer
            Dim szName As String
            Dim szDesc As String
            Dim dwValType As Integer
            Dim boolHeader As Boolean
            Dim szXMLnode As String
            Dim dwStartPos As Integer
            Dim dwLen As Integer
            Dim szRow As String
            Dim szCol As String
            Dim boolVerification As Boolean

            myCmd.CommandText = "SELECT * FROM Format WHERE fs_id=" & szId & " Order by fmt_field_seq ASC"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            While datareader.Read()

                dwSeq = IIf(IsDBNull(datareader("fmt_field_seq")), -1, datareader("fmt_field_seq"))
                szName = IIf(IsDBNull(datareader("fmt_field_name")), "", datareader("fmt_field_name"))
                szDesc = IIf(IsDBNull(datareader("fmt_field_desc")), "", datareader("fmt_field_desc"))
                dwValType = IIf(IsDBNull(datareader("fmt_field_valtype")), -1, datareader("fmt_field_valtype"))
                boolHeader = datareader("fmt_batch_header")
                szXMLnode = IIf(IsDBNull(datareader("fmt_xml_node")), "", datareader("fmt_xml_node"))
                dwStartPos = IIf(IsDBNull(datareader("fmt_start_pos")), 0, datareader("fmt_start_pos"))
                dwLen = IIf(IsDBNull(datareader("fmt_length")), 0, datareader("fmt_length"))
                szRow = IIf(IsDBNull(datareader("fmt_row_delimiter")), "", datareader("fmt_row_delimiter"))
                szCol = IIf(IsDBNull(datareader("fmt_col_delimiter")), "", datareader("fmt_col_delimiter"))
                boolVerification = datareader("fmt_verification_flag")

                Dim lvItem As New ListViewItem(szName)
                lvItem.SubItems.Add(szDesc)

                Select Case dwValType
                    Case DATA_FORMAT.ASC
                        lvItem.SubItems.Add("Asc")
                    Case DATA_FORMAT.HEX
                        lvItem.SubItems.Add("Hex")
                End Select

                If (boolHeader = True) Then
                    lvItem.SubItems.Add("Yes")
                Else
                    lvItem.SubItems.Add("No")
                End If

                lvItem.SubItems.Add(szXMLnode)
                lvItem.SubItems.Add(dwStartPos)
                lvItem.SubItems.Add(dwLen)
                lvItem.SubItems.Add(szRow)
                lvItem.SubItems.Add(szCol)

                If (boolVerification = True) Then
                    lvItem.SubItems.Add("Yes")
                Else
                    lvItem.SubItems.Add("No")
                End If

                lvField.Items.Add(lvItem)

            End While

            datareader.Close()
            myconn.Close()

            pnlField.Visible = False

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_RefreshInformation: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddNewFormat()

        Try
            lbid.Text = NEW_ID
            txtName.Text = ""

            Dim dwCount As Integer

            dwCount = lvField.Items.Count
            While (dwCount > 0)
                lvField.Items(0).Remove()
                dwCount = lvField.Items.Count
            End While

            txtName.Focus()

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_AddNewJob: Exception-" & ex.Message)
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
            'MessageBox.Show("frmFormatSetup_RemoveNewId: Exception-" & ex.Message)
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
            MessageBox.Show("frmFormatSetup_btnCancel_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            Dim szId As String
            szId = lbid.Text

            ErrorProvider1.SetError(txtName, "")
            ErrorProvider1.SetError(txtValue, "")

            If (szId = "") Then
                Exit Sub
            End If

            If (txtName.Text = "") Then
                ErrorProvider1.SetError(txtName, "Format name cannot be blank.")
                Exit Sub
            End If


            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim szName As String
            szName = txtName.Text                       'fs_name

            Dim szSQL As String
            Dim dwReturnRow As Integer

            If (szId = NEW_ID) Then
                szSQL = "INSERT INTO FormatSetup (fs_name, fs_bank_id) VALUES ('" & szName & "'," & UserInfo.BankId & ")"
            Else
                szSQL = "UPDATE FormatSetup SET fs_name='" & szName & "' WHERE fs_id =" & szId
            End If

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when saving format record.", "Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 0
                    MessageBox.Show("Format record not found. No record deleted.", "Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            'Retrieve the newly generated job_id for new record
            If (szId = NEW_ID) Then
                Dim lngFormatId As Long
                lngFormatId = GetCurrentId("FormatSetup", "fs_id")

                If (lngFormatId = FAIL_ID) Then
                    MessageBox.Show("Error occur when retrieving last format id.", "Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                szId = CStr(lngFormatId)
                lbid.Text = szId
            End If

            'Remove all format field tied to this job id
            szSQL = "DELETE FROM Format WHERE fs_id=" & szId
            dwReturnRow = ExecuteSQL(szSQL)

            If (dwReturnRow = -1) Then
                MessageBox.Show("Error occur when deleting job's format field.", "Job", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Field value
            Dim dwFldSeq As Integer
            Dim szFldName As String
            Dim szFldDesc As String
            Dim dwFldValType As Integer
            Dim dwFldHeader As Integer
            Dim szFldXMLnode As String
            Dim dwFldStartPos As Integer
            Dim dwFldLen As Integer
            Dim szFldRow As String
            Dim szFldCol As String
            Dim dwFldVerification As Integer

            Dim dwIndex As Integer
            Dim dwTotal As Integer

            dwTotal = lvField.Items.Count - 1

            For dwIndex = 0 To dwTotal
                dwFldSeq = dwIndex + 1
                szFldName = lvField.Items(dwIndex).Text
                szFldDesc = lvField.Items(dwIndex).SubItems(1).Text
                dwFldValType = IIf(lvField.Items(dwIndex).SubItems(2).Text = "Asc", DATA_FORMAT.ASC, DATA_FORMAT.HEX)
                dwFldHeader = IIf(lvField.Items(dwIndex).SubItems(3).Text = "Yes", -1, 0)
                szFldXMLnode = lvField.Items(dwIndex).SubItems(4).Text
                dwFldStartPos = CInt(lvField.Items(dwIndex).SubItems(5).Text)
                dwFldLen = CInt(lvField.Items(dwIndex).SubItems(6).Text)
                szFldRow = lvField.Items(dwIndex).SubItems(7).Text
                szFldCol = lvField.Items(dwIndex).SubItems(8).Text
                dwFldVerification = IIf(lvField.Items(dwIndex).SubItems(9).Text = "Yes", -1, 0)

                szSQL = "INSERT INTO Format (fs_id, fmt_field_seq, fmt_field_name, fmt_field_desc, " & _
                        "fmt_field_valtype, fmt_batch_header, fmt_xml_node, fmt_start_pos, fmt_length, " & _
                        "fmt_row_delimiter, fmt_col_delimiter, fmt_verification_flag ) VALUES (" & szId & "," & dwFldSeq & ",'" & szFldName & "','" & szFldDesc & _
                        "'," & dwFldValType & "," & dwFldHeader & ",'" & szFldXMLnode & "'," & dwFldStartPos & "," & dwFldLen & _
                        ",'" & szFldRow & "','" & szFldCol & "'," & dwFldVerification & ")"

                dwReturnRow = ExecuteSQL(szSQL)
                If (dwReturnRow <> 1) Then
                    MessageBox.Show("Error occur when saving format's field.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            Next dwIndex

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            boolChanged = False

            MessageBox.Show("Format information has been saved.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (szId = NEW_ID) Then
                TreeView1.SelectedNode.Tag = szId
            End If

            TreeView1.SelectedNode.Text = szName

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmFormatSetup_btnSave_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearPanelData()
        txtValue.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ClearPanelData()
        pnlField.Visible = False
    End Sub

    Private Sub ClearPanelData()

        Try
            txtValue.Text = ""
            txtDesc.Text = ""
            rbAsc.Checked = True
            chkVerification.Checked = False
            chkBatch.Checked = False
            txtXmlnode.Text = ""
            NumericUpDownOffset1.Value = 0
            NumericUpDownLen1.Value = 0
            txtRow.Text = ""
            txtCol.Text = ""

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_ClearPanelData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub FillPanelField(ByVal dwIndex As Integer)

        Try
            lbIndex.Text = CStr(dwIndex)

            txtValue.Text = lvField.Items(dwIndex).Text
            txtDesc.Text = lvField.Items(dwIndex).SubItems(1).Text

            If (lvField.Items(dwIndex).SubItems(2).Text = "Asc") Then
                rbAsc.Checked = True
            Else
                rbHex.Checked = True
            End If

            If (lvField.Items(dwIndex).SubItems(3).Text = "Yes") Then
                chkBatch.Checked = True
            Else
                chkBatch.Checked = False
            End If

            txtXmlnode.Text = lvField.Items(dwIndex).SubItems(4).Text

            NumericUpDownOffset1.Value = CInt(lvField.Items(dwIndex).SubItems(5).Text)
            NumericUpDownLen1.Value = CInt(lvField.Items(dwIndex).SubItems(6).Text)

            txtRow.Text = lvField.Items(dwIndex).SubItems(7).Text
            txtCol.Text = lvField.Items(dwIndex).SubItems(8).Text

            If (lvField.Items(dwIndex).SubItems(9).Text = "Yes") Then
                chkVerification.Checked = True
            Else
                chkVerification.Checked = False
            End If

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_FillPanelData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub UpdateFieldData(ByVal dwIndex As Integer)

        Try
            lbIndex.Text = CStr(dwIndex)

            lvField.Items(dwIndex).Text = txtValue.Text
            lvField.Items(dwIndex).SubItems(1).Text = txtDesc.Text

            If (rbAsc.Checked = True) Then
                lvField.Items(dwIndex).SubItems(2).Text = "Asc"
            Else
                lvField.Items(dwIndex).SubItems(2).Text = "Hex"
            End If


            If (chkBatch.Checked = True) Then
                lvField.Items(dwIndex).SubItems(3).Text = "Yes"
            Else
                lvField.Items(dwIndex).SubItems(3).Text = "No"
            End If

            lvField.Items(dwIndex).SubItems(4).Text = txtXmlnode.Text

            lvField.Items(dwIndex).SubItems(5).Text = CStr(NumericUpDownOffset1.Value)
            lvField.Items(dwIndex).SubItems(6).Text = CStr(NumericUpDownLen1.Value)

            lvField.Items(dwIndex).SubItems(7).Text = txtRow.Text
            lvField.Items(dwIndex).SubItems(8).Text = txtCol.Text

            If (chkVerification.Checked = True) Then
                lvField.Items(dwIndex).SubItems(9).Text = "Yes"
            Else
                lvField.Items(dwIndex).SubItems(9).Text = "No"
            End If

            lvField.Refresh()

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_UpdateFieldData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddFieldData()

        Try
            Dim boolVerification As Boolean

            Dim lvItem As New ListViewItem(txtValue.Text)
            lvItem.SubItems.Add(txtDesc.Text)

            If (rbAsc.Checked = True) Then
                lvItem.SubItems.Add("Asc")
            Else
                lvItem.SubItems.Add("Hex")
            End If

            If (chkVerification.Checked = True) Then
                lvItem.SubItems.Add("Yes")
            Else
                lvItem.SubItems.Add("No")
            End If

            lvItem.SubItems.Add(txtXmlnode.Text)

            lvItem.SubItems.Add(CStr(NumericUpDownOffset1.Value))
            lvItem.SubItems.Add(CStr(NumericUpDownLen1.Value))
            lvItem.SubItems.Add(txtRow.Text)
            lvItem.SubItems.Add(txtCol.Text)

            If (boolVerification = True) Then
                lvItem.SubItems.Add("Yes")
            Else
                lvItem.SubItems.Add("No")
            End If

            lvField.Items.Add(lvItem)

            lvField.Refresh()

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_AddFieldData: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try
            ErrorProvider1.SetError(txtName, "")
            ErrorProvider1.SetError(txtValue, "")

            If (txtValue.Text = "") Then
                ErrorProvider1.SetError(txtValue, "Field name cannot be blank.")
                Exit Sub
            End If

            Select Case btnOK.Text
                Case "&Add"
                    AddFieldData()
                    lbPrevious.Text = "(Previous saved field: " & txtValue.Text & ")"
                    ClearPanelData()
                    txtValue.Focus()

                Case "&Update"
                    'Save data
                    Dim dwIndex As Integer
                    dwIndex = CInt(lbIndex.Text)

                    UpdateFieldData(dwIndex)
                    ClearPanelData()
                    pnlField.Visible = False

            End Select

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_btnOK_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub lvField_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvField.DoubleClick

        Try
            Dim dwIndex As Integer
            dwIndex = CInt(lvField.SelectedIndices.Item(0).ToString)

            FillPanelField(dwIndex)

            lbTitle.Text = "Edit Field"
            lbPrevious.Text = ""
            btnOK.Text = "&Update"
            pnlField.Visible = True
            txtValue.Focus()

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_lvField_DoubleClick: Exception-" & ex.Message)
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
            MessageBox.Show("frmFormatSetup_TreeView1_AfterSelect: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        If (boolChanged = True) Then
            If (MessageBox.Show("Format information has not been saved. Do you wish to discard the changes and proceed with the operation?", "Format Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
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
            szJobName = NEW_FORMAT

            Dim nodp As New Windows.Forms.TreeNode(szJobName, 0, 1)
            nodp.Tag = NEW_ID
            TreeView1.Nodes.Add(nodp)
            dwIndex = nodp.Index
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

            AddNewFormat()

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
            szSQL = "UPDATE FormatSetup SET fs_deleted=-1 WHERE fs_id = " & szId

            dwReturnRow = ExecuteSQL(szSQL)
            Select Case dwReturnRow
                Case -1
                    MessageBox.Show("Error occur when deleting format record.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0
                    MessageBox.Show("Format record not found. No record deleted.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("Format record has been deleted.", "Format Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            LoadAllFormat()
            Call RefreshInformation(szId)
            TreeView1.SelectedNode = TreeView1.Nodes(dwIndex)

        Catch ex As Exception
            'MessageBox.Show("frmBank_mnuRefreshList_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnAddField_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddField.Click

        Try
            lbTitle.Text = "Add Field"
            lbPrevious.Text = ""
            btnOK.Text = "&Add"
            pnlField.Visible = True
            txtValue.Focus()

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_btnAddField_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnRemoveField_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveField.Click

        Try
            If (MessageBox.Show("Are you sure you want to delete this field?", "Delete Field", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

            Dim dwIndex As Integer
            dwIndex = CInt(lvField.SelectedIndices.Item(0).ToString)

            lvField.Items(dwIndex).Remove()

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_btnRemoveField_Click: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnEditField_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditField.Click
        Try
            Dim dwIndex As Integer
            dwIndex = CInt(lvField.SelectedIndices.Item(0).ToString)

            FillPanelField(dwIndex)

            lbTitle.Text = "Edit Field"
            lbPrevious.Text = ""
            btnOK.Text = "&Update"
            pnlField.Visible = True
            txtValue.Focus()

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_btnEditField_Click: Exception-" & ex.Message)
        End Try
    End Sub

    Private Sub btnTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemplate.Click
        Dim dlgTemplate As New frmTemplate
        gszFieldName = ""

        dlgTemplate.ShowDialog()

        If (dlgTemplate.DialogResult = Windows.Forms.DialogResult.OK) Then
            If (lvField.Items.Count > 0) Then
                If (MessageBox.Show("There are fields associated with this format setup. Do you want to replace the existing fields with the new selected template?", "Replace Field", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
                    Exit Sub
                End If
            End If

            FillTemplate(gszFieldName)

            boolChanged = True
        End If
        dlgTemplate.Dispose()
    End Sub

    Private Sub FillTemplate(ByVal szTemplateName As String)

        Try
            lvField.Items.Clear()

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            myCmd.Connection = myconn

            'Retrieve format field tie to the job_id
            Dim dwSeq As Integer
            Dim szName As String
            Dim szDesc As String
            Dim dwValType As Integer
            Dim boolHeader As Boolean
            Dim szXMLnode As String
            Dim dwStartPos As Integer
            Dim dwLen As Integer
            Dim szRow As String
            Dim szCol As String
            Dim boolVerification As Boolean

            myCmd.CommandText = "SELECT * FROM TemplateFormat WHERE fmt_name='" & szTemplateName & "' Order by fmt_field_seq ASC"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            While datareader.Read()

                dwSeq = IIf(IsDBNull(datareader("fmt_field_seq")), -1, datareader("fmt_field_seq"))
                szName = IIf(IsDBNull(datareader("fmt_field_name")), "", datareader("fmt_field_name"))
                szDesc = IIf(IsDBNull(datareader("fmt_field_desc")), "", datareader("fmt_field_desc"))
                dwValType = IIf(IsDBNull(datareader("fmt_field_valtype")), -1, datareader("fmt_field_valtype"))
                boolHeader = datareader("fmt_batch_header")
                szXMLnode = IIf(IsDBNull(datareader("fmt_xml_node")), "", datareader("fmt_xml_node"))
                dwStartPos = IIf(IsDBNull(datareader("fmt_start_pos")), 0, datareader("fmt_start_pos"))
                dwLen = IIf(IsDBNull(datareader("fmt_length")), 0, datareader("fmt_length"))
                szRow = IIf(IsDBNull(datareader("fmt_row_delimiter")), "", datareader("fmt_row_delimiter"))
                szCol = IIf(IsDBNull(datareader("fmt_col_delimiter")), "", datareader("fmt_col_delimiter"))
                boolVerification = datareader("fmt_verification_flag")

                Dim lvItem As New ListViewItem(szName)
                lvItem.SubItems.Add(szDesc)

                Select Case dwValType
                    Case DATA_FORMAT.ASC
                        lvItem.SubItems.Add("Asc")
                    Case DATA_FORMAT.HEX
                        lvItem.SubItems.Add("Hex")
                End Select

                If (boolHeader = True) Then
                    lvItem.SubItems.Add("Yes")
                Else
                    lvItem.SubItems.Add("No")
                End If

                lvItem.SubItems.Add(szXMLnode)
                lvItem.SubItems.Add(dwStartPos)
                lvItem.SubItems.Add(dwLen)
                lvItem.SubItems.Add(szRow)
                lvItem.SubItems.Add(szCol)

                If (boolVerification = True) Then
                    lvItem.SubItems.Add("Yes")
                Else
                    lvItem.SubItems.Add("No")
                End If

                lvField.Items.Add(lvItem)

            End While

            datareader.Close()
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmFormatSetup_FillTemplate: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub NumericUpDownOffset1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownOffset1.ValueChanged
        NumericUpDownOffset1.Select(0, 10)
    End Sub

    Private Sub NumericUpDownLen1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDownLen1.GotFocus
        NumericUpDownLen1.Select(0, 10)
    End Sub

End Class
