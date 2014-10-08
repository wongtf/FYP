'20100908, Danny Lim,   Added the functionality to block entry of duplicated AWB based on the CDS# & Delivery Type
'                       Added a button to reset the AWBs based on the delivery type, card type, file type and file date

'20120413, Danny Lim, Added scan function to verify if the CN nnumber is in the correct format.

Imports System.Data
Imports System.IO
Imports System.Xml

Public Class frmScan
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
    Friend WithEvents lbCount As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lbRecNo As System.Windows.Forms.Label
    Friend WithEvents pnlScan As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnPrevRec As System.Windows.Forms.Button
    Friend WithEvents picFail As System.Windows.Forms.PictureBox
    Friend WithEvents picOK As System.Windows.Forms.PictureBox
    Friend WithEvents btnNextRec As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents txtCDS As System.Windows.Forms.TextBox
    Friend WithEvents txtAWBNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlFile As System.Windows.Forms.GroupBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents cbFileDate As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents cbFile As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbNotScan As System.Windows.Forms.Label
    Friend WithEvents picLoad As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveOne As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbDeliveryType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnResetAWBs As System.Windows.Forms.Button
    Friend WithEvents lvField As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScan))
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbCount = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lvField = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.btnSave = New System.Windows.Forms.Button
        Me.lbRecNo = New System.Windows.Forms.Label
        Me.pnlScan = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnGo = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnPrevRec = New System.Windows.Forms.Button
        Me.picFail = New System.Windows.Forms.PictureBox
        Me.picOK = New System.Windows.Forms.PictureBox
        Me.btnNextRec = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnDone = New System.Windows.Forms.Button
        Me.txtCDS = New System.Windows.Forms.TextBox
        Me.txtAWBNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlFile = New System.Windows.Forms.GroupBox
        Me.cbDeliveryType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbType = New System.Windows.Forms.ComboBox
        Me.cbFileDate = New System.Windows.Forms.ComboBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.cbFile = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbNotScan = New System.Windows.Forms.Label
        Me.picLoad = New System.Windows.Forms.PictureBox
        Me.btnSaveOne = New System.Windows.Forms.Button
        Me.btnResetAWBs = New System.Windows.Forms.Button
        Me.pnlScan.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picFail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFile.SuspendLayout()
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(231, 455)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&Scan Now"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(498, 455)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbCount
        '
        Me.lbCount.BackColor = System.Drawing.Color.Transparent
        Me.lbCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCount.ForeColor = System.Drawing.Color.Black
        Me.lbCount.Location = New System.Drawing.Point(33, 119)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(179, 16)
        Me.lbCount.TabIndex = 10
        Me.lbCount.Text = "Record found:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(32, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(312, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "File information:"
        '
        'lvField
        '
        Me.lvField.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvField.HideSelection = False
        Me.lvField.Location = New System.Drawing.Point(35, 137)
        Me.lvField.MultiSelect = False
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(661, 295)
        Me.lvField.TabIndex = 0
        Me.lvField.UseCompatibleStateImageBehavior = False
        Me.lvField.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 31
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PAN"
        Me.ColumnHeader2.Width = 186
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Airway Bill Number"
        Me.ColumnHeader3.Width = 225
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CDS Ref [P]"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 97
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CDS Ref [S]"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(409, 455)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Upload &All"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lbRecNo
        '
        Me.lbRecNo.ForeColor = System.Drawing.Color.White
        Me.lbRecNo.Location = New System.Drawing.Point(32, 435)
        Me.lbRecNo.Name = "lbRecNo"
        Me.lbRecNo.Size = New System.Drawing.Size(516, 17)
        Me.lbRecNo.TabIndex = 64
        Me.lbRecNo.Text = "Current Record: 0"
        Me.lbRecNo.Visible = False
        '
        'pnlScan
        '
        Me.pnlScan.Controls.Add(Me.GroupBox2)
        Me.pnlScan.Controls.Add(Me.btnPrevRec)
        Me.pnlScan.Controls.Add(Me.picFail)
        Me.pnlScan.Controls.Add(Me.picOK)
        Me.pnlScan.Controls.Add(Me.btnNextRec)
        Me.pnlScan.Controls.Add(Me.btnCancel)
        Me.pnlScan.Controls.Add(Me.btnDone)
        Me.pnlScan.Controls.Add(Me.txtCDS)
        Me.pnlScan.Controls.Add(Me.txtAWBNo)
        Me.pnlScan.Controls.Add(Me.Label3)
        Me.pnlScan.Controls.Add(Me.Label4)
        Me.pnlScan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.pnlScan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlScan.Location = New System.Drawing.Point(36, 121)
        Me.pnlScan.Name = "pnlScan"
        Me.pnlScan.Size = New System.Drawing.Size(661, 357)
        Me.pnlScan.TabIndex = 66
        Me.pnlScan.TabStop = False
        Me.pnlScan.Text = "Scan Airway Bill"
        Me.pnlScan.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox2.Location = New System.Drawing.Point(175, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 59)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Record"
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(266, 22)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(41, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "CDS Number"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(86, 23)
        Me.txtSearch.MaxLength = 19
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(174, 23)
        Me.txtSearch.TabIndex = 0
        '
        'btnPrevRec
        '
        Me.btnPrevRec.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPrevRec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevRec.ForeColor = System.Drawing.Color.White
        Me.btnPrevRec.Location = New System.Drawing.Point(334, 160)
        Me.btnPrevRec.Name = "btnPrevRec"
        Me.btnPrevRec.Size = New System.Drawing.Size(41, 23)
        Me.btnPrevRec.TabIndex = 3
        Me.btnPrevRec.Text = "<"
        Me.btnPrevRec.UseVisualStyleBackColor = False
        '
        'picFail
        '
        Me.picFail.Image = CType(resources.GetObject("picFail.Image"), System.Drawing.Image)
        Me.picFail.Location = New System.Drawing.Point(175, 160)
        Me.picFail.Name = "picFail"
        Me.picFail.Size = New System.Drawing.Size(31, 29)
        Me.picFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFail.TabIndex = 28
        Me.picFail.TabStop = False
        Me.picFail.Visible = False
        '
        'picOK
        '
        Me.picOK.Image = CType(resources.GetObject("picOK.Image"), System.Drawing.Image)
        Me.picOK.Location = New System.Drawing.Point(175, 160)
        Me.picOK.Name = "picOK"
        Me.picOK.Size = New System.Drawing.Size(31, 29)
        Me.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOK.TabIndex = 27
        Me.picOK.TabStop = False
        Me.picOK.Visible = False
        '
        'btnNextRec
        '
        Me.btnNextRec.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNextRec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextRec.ForeColor = System.Drawing.Color.White
        Me.btnNextRec.Location = New System.Drawing.Point(375, 160)
        Me.btnNextRec.Name = "btnNextRec"
        Me.btnNextRec.Size = New System.Drawing.Size(41, 23)
        Me.btnNextRec.TabIndex = 4
        Me.btnNextRec.Text = ">"
        Me.btnNextRec.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(421, 160)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDone.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(261, 160)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(67, 23)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "&Ok"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'txtCDS
        '
        Me.txtCDS.BackColor = System.Drawing.Color.White
        Me.txtCDS.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCDS.ForeColor = System.Drawing.Color.Black
        Me.txtCDS.Location = New System.Drawing.Point(261, 128)
        Me.txtCDS.MaxLength = 19
        Me.txtCDS.Name = "txtCDS"
        Me.txtCDS.Size = New System.Drawing.Size(227, 23)
        Me.txtCDS.TabIndex = 1
        '
        'txtAWBNo
        '
        Me.txtAWBNo.BackColor = System.Drawing.Color.White
        Me.txtAWBNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAWBNo.ForeColor = System.Drawing.Color.Black
        Me.txtAWBNo.Location = New System.Drawing.Point(261, 96)
        Me.txtAWBNo.MaxLength = 13
        Me.txtAWBNo.Name = "txtAWBNo"
        Me.txtAWBNo.Size = New System.Drawing.Size(227, 23)
        Me.txtAWBNo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(172, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "CDS Number"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(172, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "AWB Number"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnlFile
        '
        Me.pnlFile.Controls.Add(Me.cbDeliveryType)
        Me.pnlFile.Controls.Add(Me.Label6)
        Me.pnlFile.Controls.Add(Me.Label5)
        Me.pnlFile.Controls.Add(Me.cbType)
        Me.pnlFile.Controls.Add(Me.cbFileDate)
        Me.pnlFile.Controls.Add(Me.btnRefresh)
        Me.pnlFile.Controls.Add(Me.cbFile)
        Me.pnlFile.Controls.Add(Me.Label8)
        Me.pnlFile.Controls.Add(Me.Label1)
        Me.pnlFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.pnlFile.Location = New System.Drawing.Point(35, 30)
        Me.pnlFile.Name = "pnlFile"
        Me.pnlFile.Size = New System.Drawing.Size(661, 76)
        Me.pnlFile.TabIndex = 67
        Me.pnlFile.TabStop = False
        '
        'cbDeliveryType
        '
        Me.cbDeliveryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeliveryType.Location = New System.Drawing.Point(136, 16)
        Me.cbDeliveryType.MaxDropDownItems = 50
        Me.cbDeliveryType.Name = "cbDeliveryType"
        Me.cbDeliveryType.Size = New System.Drawing.Size(143, 21)
        Me.cbDeliveryType.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(114, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = " :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 23)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Delivery Type"
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Location = New System.Drawing.Point(236, 47)
        Me.cbType.MaxDropDownItems = 50
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(138, 21)
        Me.cbType.TabIndex = 1
        '
        'cbFileDate
        '
        Me.cbFileDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileDate.Location = New System.Drawing.Point(136, 47)
        Me.cbFileDate.MaxDropDownItems = 50
        Me.cbFileDate.Name = "cbFileDate"
        Me.cbFileDate.Size = New System.Drawing.Size(94, 21)
        Me.cbFileDate.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(564, 47)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(83, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'cbFile
        '
        Me.cbFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFile.Location = New System.Drawing.Point(380, 47)
        Me.cbFile.MaxDropDownItems = 50
        Me.cbFile.Name = "cbFile"
        Me.cbFile.Size = New System.Drawing.Size(178, 21)
        Me.cbFile.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(114, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = " :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "File name"
        '
        'lbNotScan
        '
        Me.lbNotScan.BackColor = System.Drawing.Color.Transparent
        Me.lbNotScan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNotScan.ForeColor = System.Drawing.Color.Black
        Me.lbNotScan.Location = New System.Drawing.Point(517, 119)
        Me.lbNotScan.Name = "lbNotScan"
        Me.lbNotScan.Size = New System.Drawing.Size(179, 16)
        Me.lbNotScan.TabIndex = 87
        Me.lbNotScan.Text = "Record not scan: "
        Me.lbNotScan.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'picLoad
        '
        Me.picLoad.BackColor = System.Drawing.Color.White
        Me.picLoad.Image = CType(resources.GetObject("picLoad.Image"), System.Drawing.Image)
        Me.picLoad.Location = New System.Drawing.Point(162, 234)
        Me.picLoad.Name = "picLoad"
        Me.picLoad.Size = New System.Drawing.Size(406, 133)
        Me.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoad.TabIndex = 88
        Me.picLoad.TabStop = False
        Me.picLoad.Visible = False
        '
        'btnSaveOne
        '
        Me.btnSaveOne.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSaveOne.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOne.ForeColor = System.Drawing.Color.White
        Me.btnSaveOne.Location = New System.Drawing.Point(320, 455)
        Me.btnSaveOne.Name = "btnSaveOne"
        Me.btnSaveOne.Size = New System.Drawing.Size(83, 23)
        Me.btnSaveOne.TabIndex = 89
        Me.btnSaveOne.Text = "Upload &One"
        Me.btnSaveOne.UseVisualStyleBackColor = False
        '
        'btnResetAWBs
        '
        Me.btnResetAWBs.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnResetAWBs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetAWBs.ForeColor = System.Drawing.Color.White
        Me.btnResetAWBs.Location = New System.Drawing.Point(142, 455)
        Me.btnResetAWBs.Name = "btnResetAWBs"
        Me.btnResetAWBs.Size = New System.Drawing.Size(83, 23)
        Me.btnResetAWBs.TabIndex = 90
        Me.btnResetAWBs.Text = "&Reset AWB"
        Me.btnResetAWBs.UseVisualStyleBackColor = False
        '
        'frmScan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(812, 504)
        Me.Controls.Add(Me.pnlScan)
        Me.Controls.Add(Me.btnResetAWBs)
        Me.Controls.Add(Me.pnlFile)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbCount)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lbRecNo)
        Me.Controls.Add(Me.lbNotScan)
        Me.Controls.Add(Me.btnSaveOne)
        Me.Controls.Add(Me.picLoad)
        Me.Controls.Add(Me.lvField)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Scan CN - (POSLAJU only)"
        Me.pnlScan.ResumeLayout(False)
        Me.pnlScan.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picFail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFile.ResumeLayout(False)
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dwIndexOf As Integer
    Dim szHeaderDetails As String
    Dim szTrailerDetails As String
    Dim szDetails As String
    Dim szFieldCheck As String

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try
            pnlScan.Visible = True
            pnlFile.Enabled = False
            txtCDS.Text = lvField.Items(0).SubItems(3).Text
            dwIndexOf = 0

            txtAWBNo.Focus()

        Catch ex As Exception
            pnlFile.Enabled = True
        Finally

        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub frmOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UpdateAuditLog("Scan Airwaybill number", "Audit Log")
            btnResetAWBs.Enabled = False
            btnOK.Enabled = False
            btnSave.Enabled = False
            dwIndexOf = -1

            'Get all report file name in TempReport table
            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim szSQL As String = ""
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing

            'Get List of DeliveryType from db
            myCmd.CommandText = "exec sp_extractdeliverytype"
            datareader = myCmd.ExecuteReader()

            cbDeliveryType.Items.Clear()
            While datareader.Read()
                cbDeliveryType.Items.Add(datareader("deliverytype"))
            End While
            cbDeliveryType.Text = "P"
            datareader.Close()

            'Get List of FileDate in db
            szSQL = "SELECT DISTINCT(data_Filedate) FROM data ORDER BY data_filedate"
            myCmd.CommandText = szSQL

            cbFileDate.Items.Clear()

            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                cbFileDate.Items.Add(datareader("data_filedate"))
            End While

            datareader.Close()

            Select Case cbFileDate.Items.Count
                Case 0
                    cbFileDate.SelectedIndex = -1
                Case 1
                    cbFileDate.SelectedIndex = 0
                Case Else
                    cbFileDate.SelectedIndex = cbFileDate.Items.Count - 1
            End Select

            'Get List of File Type in db
            szSQL = "SELECT DISTINCT(data_FileType) FROM data"
            myCmd.CommandText = szSQL

            cbType.Items.Clear()

            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                cbType.Items.Add(datareader("data_FileType"))
            End While

            datareader.Close()

            'edit by azuwa kasnan 27102013
            If cbType.Items.Count > 0 Then
                cbType.SelectedIndex = -1
            End If

            'If cbType.Items.Count = 0 Then
            'cbType.SelectedIndex = -1
            'ElseIf cbType.Items.Count = 1 Then
            'cbType.SelectedIndex = 0
            'Else
            'cbType.SelectedIndex = cbType.Items.Count - 1
            'End If

            myconn.Close()

        Catch ex As Exception
            btnResetAWBs.Enabled = False
            btnOK.Enabled = False
            btnSave.Enabled = False
            MessageBox.Show("frmScan_Load: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AddStatusItem(ByVal szStatus As String)

        Try
            Dim lvItem As New ListViewItem(szStatus)
            lvField.Items.Add(lvItem)
            lvField.Update()

        Catch ex As Exception
            MessageBox.Show("frmOpen_AddStatusItem: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadData(ByVal szBatchId As String)

        Try
            If (szBatchId = "") Then
                Exit Sub
            End If

            picLoad.Visible = True
            cbFileDate.Enabled = False
            cbType.Enabled = False
            cbFile.Enabled = False
            btnResetAWBs.Enabled = False
            btnOK.Enabled = False
            btnSave.Enabled = False
            btnRefresh.Enabled = False

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.Refresh()

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing

            'Retrieve format field tie to the job_id
            Dim dwCount As Integer = 1
            Dim dwEmpty As Integer = 0

            Dim szPAN As String = ""
            Dim szAWBNo As String = ""
            Dim szCDSRef1 As String = ""
            Dim szCDSRef2 As String = ""

            myconn.Open()
            myCmd.Connection = myconn

            'Retrieve the record information
            myCmd.CommandText = "exec sp_extractposlaju '" & cbFileDate.Text & "','" & szBatchId & "','" & cbDeliveryType.Text & "'"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            While datareader.Read()
                szPAN = IIf(IsDBNull(datareader("PAN")), "", datareader("PAN"))

                szAWBNo = IIf(IsDBNull(datareader("AWBNO")), "", datareader("AWBNO"))
                szCDSRef1 = IIf(IsDBNull(datareader("PREFNO")), "", datareader("PREFNO"))
                szCDSRef2 = IIf(IsDBNull(datareader("SREFNO")), "", datareader("SREFNO"))

                If (Trim(szAWBNo) = "") Then
                    dwEmpty += 1
                End If

                If (Trim(szCDSRef1) <> "" Or Trim(szCDSRef1) = "") Then
                    Dim lvItem As New ListViewItem(dwCount)

                    lvItem.SubItems.Add(szPAN)
                    lvItem.SubItems.Add(szAWBNo)
                    lvItem.SubItems.Add(szCDSRef1)
                    lvItem.SubItems.Add(szCDSRef2)
                    lvItem.Tag = szBatchId

                    lvField.Items.Add(lvItem)
                    dwCount += 1
                End If

            End While

            datareader.Close()
            myconn.Close()

            lbCount.Text = "Record found: " & CStr(dwCount - 1)
            lbNotScan.Text = "Record not scan: " & CStr(dwEmpty)

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmScan_LoadData: Exception-" & ex.Message)
        Finally
            picLoad.Visible = False
            cbFileDate.Enabled = True
            cbType.Enabled = True
            cbFile.Enabled = True
            btnResetAWBs.Enabled = True
            btnOK.Enabled = True
            btnSave.Enabled = True
            btnRefresh.Enabled = True
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub cbFile_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFile.SelectedIndexChanged
        LoadData(cbFile.SelectedItem.ToString)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnOK.Enabled = False
            btnResetAWBs.Enabled = False
            btnSave.Enabled = False
            btnSaveOne.Enabled = False
            btnClose.Enabled = False

            Dim szBatchId As String
            Dim i As Integer
            Dim j As Integer
            Dim dwcount As Integer

            Dim szAirWayBillFileName As String = ""
            Dim szFileDateNow As String
            Dim dwFileNum As Integer = FreeFile()

            Dim dwRecCNT As Long = 0
            Dim dwTotalCNT As Long = 0
            Dim szFileType As String = Trim(cbType.Text)
            Dim dwDeliveryCnt As Integer = cbDeliveryType.Items.Count - 1
            Dim dwIcnt As Integer = 0

            szFileDateNow = cbFileDate.SelectedItem.ToString
            If szFileType <> "NEW" And szFileType <> "RPL" And szFileType <> "UPG" And szFileType <> "B1" And szFileType <> "B2" And szFileType <> "B3" Then
                'szAirWayBillFileName = BankInfo.Folder_Ready & "AirWayBill" & szFileDateNow & szFileType & ".txt"
                szAirWayBillFileName = BankInfo.Folder_Ready & "AirWayBill" & szFileDateNow & "Debit" & ".txt"
            Else
                szAirWayBillFileName = BankInfo.Folder_Ready & "AirWayBill" & szFileDateNow & "Daily" & ".txt"
            End If

            If GetUploadFileFld("AirWayBill") = True Then
                FileOpen(dwFileNum, szAirWayBillFileName, OpenMode.Output)
                FormatFileHeaderTrailer(szHeaderDetails, dwFileNum, 0)
            Else
                Exit Sub
            End If

            For dwIcnt = 0 To dwDeliveryCnt
                cbDeliveryType.Text = cbDeliveryType.Items.Item(dwIcnt)
                If szFileType <> "NEW" And szFileType <> "RPL" And szFileType <> "UPG" And szFileType <> "B1" And szFileType <> "B2" And szFileType <> "B3" Then
                    dwcount = cbFile.Items.Count - 1
                    For i = 0 To dwcount
                        szBatchId = cbFile.Items.Item(i)
                        dwRecCNT = FormatFileDetails(szDetails, szBatchId, dwFileNum, szFieldCheck, False)
                        UpdateAuditLog("Upload Airwaybill records for file[" & szBatchId & "] with records[" & dwRecCNT & "]", "Production")
                        dwTotalCNT += dwRecCNT
                    Next i
                Else
                    For j = 1 To 6
                        Select Case j
                            Case 1
                                RefreshFileName("NEW")
                            Case 2
                                RefreshFileName("RPL")
                            Case 3
                                RefreshFileName("UPG")
                            Case 4
                                RefreshFileName("B1")
                            Case 5
                                RefreshFileName("B2")
                            Case 6
                                RefreshFileName("B3")
                        End Select
                        dwcount = cbFile.Items.Count - 1
                        For i = 0 To dwcount
                            szBatchId = cbFile.Items.Item(i)
                            dwRecCNT = FormatFileDetails(szDetails, szBatchId, dwFileNum, szFieldCheck, False)
                            UpdateAuditLog("Upload Airwaybill records for file[" & szBatchId & "] with records[" & dwRecCNT & "]", "Production")
                            dwTotalCNT += dwRecCNT
                        Next i
                    Next j
                End If
            Next dwIcnt

            FormatFileHeaderTrailer(szTrailerDetails, dwFileNum, dwTotalCNT)
            FileClose(dwFileNum)
            UpdateAuditLog(szAirWayBillFileName & " file created with total records[" & dwTotalCNT & "]", "Production")

Done:
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            btnOK.Enabled = True
            btnClose.Enabled = True

            MessageBox.Show("Records have been saved into file at [" & szAirWayBillFileName & "].", "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        Finally
            btnResetAWBs.Enabled = True
            btnOK.Enabled = True
            btnSave.Enabled = True
            btnSaveOne.Enabled = True
            btnClose.Enabled = True
        End Try

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If Not cbFile.SelectedItem Is Nothing Then
            LoadData(cbFile.SelectedItem.ToString)
        End If
    End Sub

    'Private Sub cbFileDate_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFileDate.SelectedValueChanged
    '    ''Get all report file name in TempReport table
    '    'Dim myconn As New OleDb.OleDbConnection(gszConnString)
    '    'Dim szSQL As String

    '    ''Dim dwJobIndex As Integer
    '    ''Dim lngJobIdTemp As Long
    '    ''Dim dwFileType As Integer
    '    'Dim szFileName As String

    '    'szSQL = "SELECT DISTINCT(data_filename) FROM data WHERE data_filedate='" & cbFileDate.SelectedItem.ToString & "' ORDER BY data_filename"

    '    'Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
    '    'Dim datareader As OleDb.OleDbDataReader = Nothing

    '    'cbFile.Items.Clear()

    '    'myconn.Open()
    '    'datareader = myCmd.ExecuteReader()

    '    'While datareader.Read()
    '    '    szFileName = datareader("data_filename")

    '    '    'dwJobIndex = GetJobID(BankInfo.Id, szFileName, lngJobIdTemp)
    '    '    'If (dwJobIndex <> -1) Then
    '    '    '    dwFileType = arJobInfo(dwJobIndex).FileType

    '    '    '    If (dwFileType = cbType.SelectedIndex) Or (cbType.SelectedIndex = 0) Then
    '    '    cbFile.Items.Add(szFileName)
    '    '    'End If
    '    '    'End If

    '    'End While
    '    'datareader.Close()
    '    'myconn.Close()
    '    If (cbFileDate.Items.Count = 0) Then
    '        Exit Sub
    '    End If
    '    RefreshFileName(cbType.SelectedItem.ToString)
    'End Sub

    Private Sub cbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbType.SelectedValueChanged, cbDeliveryType.SelectedValueChanged, cbFileDate.SelectedValueChanged
        If (cbFileDate.Text = "") Then
            Exit Sub
        End If
        If (cbDeliveryType.Text = "") Then
            Exit Sub
        End If
        If (cbType.Text = "") Then
            Exit Sub
        End If
        RefreshFileName(cbType.SelectedItem.ToString)
    End Sub

    'Private Sub cbDeliveryType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeliveryType.SelectedValueChanged
    '    If (cbDeliveryType.Items.Count = 0) Then
    '        Exit Sub
    '    End If
    '    RefreshFileName(cbType.SelectedItem.ToString)
    'End Sub

    Private Sub RefreshFileName(ByVal szFiletype As String)
        'Get all report file name in TempReport table
        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Dim szSQL As String

        'Dim dwJobIndex As Integer
        'Dim lngJobIdTemp As Long
        'Dim dwFileType As Integer
        Dim szFileName As String

        szSQL = "SELECT DISTINCT(data_filename) FROM data WHERE data_filedate='" & cbFileDate.SelectedItem.ToString & "' AND data_filetype='" & szFiletype & "' AND Field7='" & cbDeliveryType.Text & "' ORDER BY data_filename"
        'szSQL = "SELECT DISTINCT(data_filename) FROM data WHERE data_filedate='" & cbFileDate.SelectedItem.ToString & "' AND data_filetype='" & szFiletype & "' ORDER BY data_filename"

        Dim myCmd As New OleDb.OleDbCommand(szSQL, myconn)
        Dim datareader As OleDb.OleDbDataReader = Nothing

        cbFile.Items.Clear()

        myconn.Open()
        datareader = myCmd.ExecuteReader()

        While datareader.Read()
            szFileName = datareader("data_filename")

            'dwJobIndex = GetJobID(BankInfo.Id, szFileName, lngJobIdTemp)
            'If (dwJobIndex <> -1) Then
            '    dwFileType = arJobInfo(dwJobIndex).FileType

            '    If (dwFileType = cbType.SelectedIndex) Or (cbType.SelectedIndex = 0) Then
            cbFile.Items.Add(szFileName)
            '    End If
            'End If

        End While
        datareader.Close()
        myconn.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtAWBNo.Clear()
        txtCDS.Clear()
        txtSearch.Clear()

        ErrorProvider1.SetError(txtAWBNo, "")
        ErrorProvider1.SetError(txtCDS, "")
        ErrorProvider1.SetError(txtSearch, "")

        pnlScan.Visible = False
        pnlFile.Enabled = True

        If Not cbFile.SelectedItem Is Nothing Then
            LoadData(cbFile.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Try
            ErrorProvider1.SetError(txtAWBNo, "")
            ErrorProvider1.SetError(txtCDS, "")

            If (Trim(txtAWBNo.Text) = BARCODE_PREV) Then
                txtAWBNo.Clear()
                btnPrevRec_Click(Me, e)
                Exit Sub
            End If

            If (Trim(txtAWBNo.Text) = BARCODE_NEXT) Then
                txtAWBNo.Clear()
                btnNextRec_Click(Me, e)
                Exit Sub
            End If

            picOK.Visible = False
            picFail.Visible = False

            Beep()

            If (Trim(txtAWBNo.Text) = "") Then
                ErrorProvider1.SetError(txtAWBNo, "AWB Number cannot be blank.")
                picFail.Visible = True
                Exit Sub
            End If

            If (Trim(txtCDS.Text) = "") Then
                ErrorProvider1.SetError(txtCDS, "CDS Number cannot be blank.")
                picFail.Visible = True
                Exit Sub
            End If


            '20120413, Danny Lim, added to verify if the AWB# is in the correct poslaju format, if is poslaju

            If cbDeliveryType.Text.Trim.ToUpper = "P" Then
                If txtAWBNo.Text.Trim.Length <> 13 Then
                    ErrorProvider1.SetError(txtAWBNo, "Invalid AWB Number format - length incorrect.")
                    picFail.Visible = True
                    Exit Sub
                End If

                If IsNumeric(txtAWBNo.Text.Trim.Substring(0, 2)) = True Or IsNumeric(txtAWBNo.Text.Trim.Substring(11, 2)) = True Then
                    ErrorProvider1.SetError(txtAWBNo, "Invalid AWB Number format - format incorrect.")
                    picFail.Visible = True
                    Exit Sub
                End If

                If IsNumeric(txtAWBNo.Text.Trim.Substring(2, 9)) = False Then
                    ErrorProvider1.SetError(txtAWBNo, "Invalid AWB Number format - format incorrect.")
                    picFail.Visible = True
                    Exit Sub
                End If
            End If

            '20100907, danny lim, added a procedure to check if the awb had been entered. 
            'if found then exit function
            Dim szFileID As String
            szFileID = GetSQLSingleData("select 'CDS # ' + field5 + ', ' + char(13) + 'File Date : ' + data_filedate + ', Card Type : ' + data_cardtype + ', File Type : ' + data_filetype AS Expr2 from data where AWBNO = '" _
                                        & txtAWBNo.Text.ToString.Trim.Replace("""", "") & "' and field7 = '" _
                                        & cbDeliveryType.SelectedItem.ToString.Trim & "'")

            If szFileID.Trim.Length <> 0 Then
                MsgBox("Duplicated AWB file found recorded in " & szFileID & "." & vbCrLf & "Please reenter the correct AWB number.", MsgBoxStyle.Critical, "Duplicated AWB File Found")
                txtAWBNo.Focus()
                txtAWBNo.SelectAll()
            Else
                'v701, added these 5 lines of control to check EOF
                If (dwIndexOf = lvField.Items.Count) Then
                    Beep()
                    ErrorProvider1.SetError(txtCDS, "You have reached the end of record.")
                    Exit Sub
                End If

                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

                Dim szSQL As String = ""
                Dim dwReturnRow As Integer
                Dim szScanTime As String = DateTime.Now.ToString("hhmmss")
                Dim szScanDate As String = DateTime.Now.ToString("MMddyyyy")

                szSQL = "EXEC sp_updateawbnumber '" & cbFile.Text & "','" & Trim(txtCDS.Text) & "','" & Trim(txtAWBNo.Text) & "','" & szScanDate & "','" & szScanTime & "'"
                dwReturnRow = ExecuteSQL(szSQL)

                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

                If (dwReturnRow = 0) Then
                    ErrorProvider1.SetError(txtAWBNo, "")
                    ErrorProvider1.SetError(txtCDS, "")
                    picFail.Visible = True
                    MessageBox.Show("Fail to update this record. Please try again or contact System Administrator.", "Barcode Scanning", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    txtAWBNo.SelectAll()
                    txtAWBNo.Focus()
                    Exit Sub
                End If

                UpdateAuditLog("Update awbnumber[" & Trim(txtAWBNo.Text) & "] for CDSNo " & Trim(txtCDS.Text), "Production")

                picOK.Visible = True
                lvField.Items(dwIndexOf).SubItems(2).Text = txtAWBNo.Text

                dwIndexOf += 1
                txtAWBNo.Clear()

                If (dwIndexOf = lvField.Items.Count) Then
                    Beep()
                    ErrorProvider1.SetError(txtCDS, "You have reached the end of record.")
                    Exit Sub
                End If

                txtCDS.Text = lvField.Items(dwIndexOf).SubItems(3).Text

                txtAWBNo.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("frmscan_btnDone_Click: Exception-" & ex.Message)
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnNextRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextRec.Click
        ErrorProvider1.SetError(txtCDS, "")

        If (dwIndexOf = lvField.Items.Count) Then
            Beep()
            ErrorProvider1.SetError(txtCDS, "You have reached the end of record.")
            Exit Sub
        End If

        dwIndexOf += 1
        txtCDS.Text = lvField.Items(dwIndexOf).SubItems(3).Text
    End Sub

    Private Sub btnPrevRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevRec.Click
        ErrorProvider1.SetError(txtCDS, "")

        If (dwIndexOf = 0) Then
            Beep()
            ErrorProvider1.SetError(txtCDS, "You have reached the beginning of record.")
            Exit Sub
        End If

        dwIndexOf -= 1
        txtCDS.Text = lvField.Items(dwIndexOf).SubItems(3).Text
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Dim dwIndex As Integer
        Dim boolFound As Boolean = False

        ErrorProvider1.SetError(txtSearch, "")

        For dwIndex = 0 To lvField.Items.Count - 1
            If (lvField.Items(dwIndex).SubItems(3).Text = txtSearch.Text) Then
                txtCDS.Text = lvField.Items(dwIndex).SubItems(3).Text
                dwIndexOf = dwIndex
                boolFound = True
                txtAWBNo.Focus()
                Exit For
            End If
        Next

        If (boolFound = False) Then
            Beep()
            ErrorProvider1.SetError(txtSearch, "Cannot find the CDS Number.")
        End If

    End Sub

    Private Sub txtAWBNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAWBNo.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnDone_Click(Me, e)
        End Select
    End Sub

    Private Sub txtCDS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCDS.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnDone_Click(Me, e)
        End Select
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnGo_Click(Me, e)
        End Select
    End Sub

    Private Sub btnSaveOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOne.Click

        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            btnOK.Enabled = False
            btnSave.Enabled = False
            btnSaveOne.Enabled = False
            btnClose.Enabled = False
            btnResetAWBs.Enabled = False

            Dim szFileName As String
            Dim szBatchId As String
            Dim szAirWayBillFileName As String
            Dim szFileDateNow As String
            Dim dwFileNum As Integer = FreeFile()
            Dim dwRecCNT As Long

            szFileDateNow = cbFileDate.SelectedItem.ToString
            szFileName = cbFile.SelectedItem.ToString
            szAirWayBillFileName = BankInfo.Folder_Ready & "AWB_" & szFileName & ".txt"

            szBatchId = cbFile.SelectedItem.ToString

            If GetUploadFileFld("AirWayBill") = True Then
                FileOpen(dwFileNum, szAirWayBillFileName, OpenMode.Output)
                FormatFileHeaderTrailer(szHeaderDetails, dwFileNum, 0)
                dwRecCNT = FormatFileDetails(szDetails, szBatchId, dwFileNum, szFieldCheck, False)
                FormatFileHeaderTrailer(szTrailerDetails, dwFileNum, dwRecCNT)
                FileClose(dwFileNum)
                UpdateAuditLog(szAirWayBillFileName & " file created with total records[" & dwRecCNT & "]", "Production")
            End If

Done:
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            btnOK.Enabled = True
            btnClose.Enabled = True

            MessageBox.Show("Records have been saved into file at [" & szAirWayBillFileName & "].", "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Information)

FailRecord:

        Catch ex As Exception

        Finally
            btnResetAWBs.Enabled = True
            btnOK.Enabled = True
            btnSave.Enabled = True
            btnSaveOne.Enabled = True
            btnClose.Enabled = True
        End Try

    End Sub

    Private Function GetUploadFileFld(ByVal szUF_Name As String) As Boolean
        Try
            Dim myconn As New OleDb.OleDbConnection()
            myconn.ConnectionString = gszConnString
            myconn.Open()

            Dim myCmd As New OleDb.OleDbCommand()
            myCmd.Connection = myconn
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myCmd.CommandText = "SELECT * FROM UploadFileDetails2 where uf_name='" & szUF_Name & "' and uf_deleted=0"
            datareader = myCmd.ExecuteReader()
            If datareader.HasRows Then
                While datareader.Read()
                    szHeaderDetails = IIf(IsDBNull(datareader("uf_header")), "", datareader("uf_header"))
                    szDetails = IIf(IsDBNull(datareader("uf_details")), "", datareader("uf_details"))
                    szTrailerDetails = IIf(IsDBNull(datareader("uf_footer")), "", datareader("uf_footer"))
                    szFieldCheck = IIf(IsDBNull(datareader("uf_check_field")), "", datareader("uf_check_field"))
                    '**********************************
                End While
            Else
                MsgBox("There is no field defined for upload file!")
                Return False
            End If
            Return True

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmScan.GetUploadField[" & szUF_Name & "]: Exception-" & ex.Message)
        End Try
    End Function

    '20100908, danny lim, added to reset awb for particular AWBs in a selected batch
    Private Sub btnResetAWB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetAWBs.Click

        If lvField.Items.Count = 0 Then
            MsgBox("There are no CDS in the list to reset.", MsgBoxStyle.Exclamation, "No CDS")
        Else
            If MsgBox("This will reset the AWB Numbers listed in this batch. Are you sure you want to continue?", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Reset AWB?") = MsgBoxResult.Yes Then
                If frmPasswordPrompt.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If MsgBox("Correct Password entered. Do you want to continue to reset the AWBs?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        Dim myconn As New OleDb.OleDbConnection(gszConnString)
                        Dim myCmd As New OleDb.OleDbCommand
                        Dim szScanTime As String = DateTime.Now.ToString("hhmmss")
                        Dim szScanDate As String = DateTime.Now.ToString("MMddyyyy")

                        Dim szSQL As String = ""
                        Dim dwReturnRow As Integer
                        Dim szBatchId As String
                        Dim shtCount As Short = 0

                        szBatchId = cbFile.SelectedItem.ToString

                        myconn.Open()
                        myCmd.Connection = myconn

                        For Each lvItem As ListViewItem In lvField.Items
                            szSQL = "EXEC sp_updateawbnumber '" & lvItem.Tag & "','" & lvItem.SubItems(3).Text & "','','" & szScanDate & "','" & szScanTime & "'"
                            dwReturnRow = ExecuteSQL(szSQL)

                            If (dwReturnRow = 0) Then
                                MessageBox.Show("Fail to update this record. Please try again or contact System Administrator.", "Reset AWB", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            Else
                                shtCount += 1

                                lbNotScan.Text = "Record not scan: " & CStr(shtCount)
                                lvItem.SubItems(2).Text = ""
                            End If

                            UpdateAuditLog("Reset awbnumber for CDSNo " & lvItem.SubItems(3).Text & ", File Type : " & lvItem.Tag & ".", "Production")
                        Next

                        myconn.Close()

                        MsgBox("Total up to " & shtCount & " AWBs had been resetted.", MsgBoxStyle.Information, "Reset AWB")
                        btnOK.Focus()
                    Else
                        MsgBox("No AWBs are resetted.", MsgBoxStyle.Exclamation, "AWBs not resetted")
                    End If
                Else
                    MsgBox("Incorrect password entered. AWBs not resetted.", MsgBoxStyle.Exclamation, "Incorrect Password")
                End If
            End If
        End If
    End Sub




End Class
