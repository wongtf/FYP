<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtFldHexValue = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFldLength = New System.Windows.Forms.TextBox
        Me.txtFldStartPos = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFileContents = New System.Windows.Forms.TextBox
        Me.btnOpenSampleFile = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chkCheckNmSeparator = New System.Windows.Forms.CheckBox
        Me.rbDataType5 = New System.Windows.Forms.RadioButton
        Me.chkCurrency = New System.Windows.Forms.CheckBox
        Me.txtOldDateFmt = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.rbDataType2 = New System.Windows.Forms.RadioButton
        Me.rbDataType0 = New System.Windows.Forms.RadioButton
        Me.rbDataType1 = New System.Windows.Forms.RadioButton
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtReplCharCode = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.rbDataType3 = New System.Windows.Forms.RadioButton
        Me.txtNewDateFormat = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkLastDayOfMth = New System.Windows.Forms.CheckBox
        Me.chkCheckPoscode = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.chkConditionFld = New System.Windows.Forms.CheckBox
        Me.txtReplValue = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtConditionFld = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblDataFldID = New System.Windows.Forms.Label
        Me.cmbOutputFormat = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cmbDataFldName = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCompositeFld = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtEndCode = New System.Windows.Forms.TextBox
        Me.txtDataLength = New System.Windows.Forms.TextBox
        Me.rbEndFld1 = New System.Windows.Forms.RadioButton
        Me.rbEndFld0 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtStartCode = New System.Windows.Forms.TextBox
        Me.txtStartPosition = New System.Windows.Forms.TextBox
        Me.rbStartFld1 = New System.Windows.Forms.RadioButton
        Me.rbStartFld0 = New System.Windows.Forms.RadioButton
        Me.txtDataFldName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtStaticData = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.dgridDataSetup = New System.Windows.Forms.DataGridView
        Me.lblTotal = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.lblDataSetupID = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgridDataSetup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtFldHexValue)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtFldLength)
        Me.Panel1.Controls.Add(Me.txtFldStartPos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFileContents)
        Me.Panel1.Controls.Add(Me.btnOpenSampleFile)
        Me.Panel1.Location = New System.Drawing.Point(9, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 206)
        Me.Panel1.TabIndex = 1
        '
        'txtFldHexValue
        '
        Me.txtFldHexValue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFldHexValue.Location = New System.Drawing.Point(73, 176)
        Me.txtFldHexValue.Name = "txtFldHexValue"
        Me.txtFldHexValue.Size = New System.Drawing.Size(431, 21)
        Me.txtFldHexValue.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hex Value"
        '
        'txtFldLength
        '
        Me.txtFldLength.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFldLength.Location = New System.Drawing.Point(459, 10)
        Me.txtFldLength.Name = "txtFldLength"
        Me.txtFldLength.Size = New System.Drawing.Size(77, 21)
        Me.txtFldLength.TabIndex = 5
        '
        'txtFldStartPos
        '
        Me.txtFldStartPos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFldStartPos.Location = New System.Drawing.Point(260, 10)
        Me.txtFldStartPos.Name = "txtFldStartPos"
        Me.txtFldStartPos.Size = New System.Drawing.Size(77, 21)
        Me.txtFldStartPos.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Field Length"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Field Start Position"
        '
        'txtFileContents
        '
        Me.txtFileContents.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileContents.Location = New System.Drawing.Point(3, 40)
        Me.txtFileContents.Multiline = True
        Me.txtFileContents.Name = "txtFileContents"
        Me.txtFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileContents.Size = New System.Drawing.Size(570, 129)
        Me.txtFileContents.TabIndex = 1
        '
        'btnOpenSampleFile
        '
        Me.btnOpenSampleFile.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenSampleFile.Location = New System.Drawing.Point(3, 3)
        Me.btnOpenSampleFile.Name = "btnOpenSampleFile"
        Me.btnOpenSampleFile.Size = New System.Drawing.Size(123, 31)
        Me.btnOpenSampleFile.TabIndex = 0
        Me.btnOpenSampleFile.Text = "Open Sample File"
        Me.btnOpenSampleFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.chkCheckNmSeparator)
        Me.Panel2.Controls.Add(Me.rbDataType5)
        Me.Panel2.Controls.Add(Me.chkCurrency)
        Me.Panel2.Controls.Add(Me.txtOldDateFmt)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.rbDataType2)
        Me.Panel2.Controls.Add(Me.rbDataType0)
        Me.Panel2.Controls.Add(Me.rbDataType1)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtReplCharCode)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.rbDataType3)
        Me.Panel2.Controls.Add(Me.txtNewDateFormat)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.chkLastDayOfMth)
        Me.Panel2.Controls.Add(Me.chkCheckPoscode)
        Me.Panel2.Controls.Add(Me.GroupBox7)
        Me.Panel2.Controls.Add(Me.lblDataFldID)
        Me.Panel2.Controls.Add(Me.cmbOutputFormat)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtDataFldName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(595, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 615)
        Me.Panel2.TabIndex = 5
        '
        'chkCheckNmSeparator
        '
        Me.chkCheckNmSeparator.AutoSize = True
        Me.chkCheckNmSeparator.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheckNmSeparator.Location = New System.Drawing.Point(12, 590)
        Me.chkCheckNmSeparator.Name = "chkCheckNmSeparator"
        Me.chkCheckNmSeparator.Size = New System.Drawing.Size(124, 18)
        Me.chkCheckNmSeparator.TabIndex = 33
        Me.chkCheckNmSeparator.Text = "Name Separator"
        Me.chkCheckNmSeparator.UseVisualStyleBackColor = True
        '
        'rbDataType5
        '
        Me.rbDataType5.BackColor = System.Drawing.SystemColors.Control
        Me.rbDataType5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbDataType5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDataType5.ForeColor = System.Drawing.Color.Blue
        Me.rbDataType5.Location = New System.Drawing.Point(215, 201)
        Me.rbDataType5.Name = "rbDataType5"
        Me.rbDataType5.Size = New System.Drawing.Size(179, 17)
        Me.rbDataType5.TabIndex = 30
        Me.rbDataType5.Text = "Arithmetic Data Field"
        Me.rbDataType5.UseVisualStyleBackColor = False
        '
        'chkCurrency
        '
        Me.chkCurrency.AutoSize = True
        Me.chkCurrency.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCurrency.Location = New System.Drawing.Point(303, 439)
        Me.chkCurrency.Name = "chkCurrency"
        Me.chkCurrency.Size = New System.Drawing.Size(107, 18)
        Me.chkCurrency.TabIndex = 32
        Me.chkCurrency.Text = "CurrencyField"
        Me.chkCurrency.UseVisualStyleBackColor = True
        '
        'txtOldDateFmt
        '
        Me.txtOldDateFmt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldDateFmt.Location = New System.Drawing.Point(116, 509)
        Me.txtOldDateFmt.Name = "txtOldDateFmt"
        Me.txtOldDateFmt.Size = New System.Drawing.Size(275, 21)
        Me.txtOldDateFmt.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(3, 511)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 14)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Old Date Format"
        '
        'rbDataType2
        '
        Me.rbDataType2.BackColor = System.Drawing.SystemColors.Control
        Me.rbDataType2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbDataType2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDataType2.ForeColor = System.Drawing.Color.Blue
        Me.rbDataType2.Location = New System.Drawing.Point(12, 200)
        Me.rbDataType2.Name = "rbDataType2"
        Me.rbDataType2.Size = New System.Drawing.Size(179, 17)
        Me.rbDataType2.TabIndex = 29
        Me.rbDataType2.Text = "Composite Data Field"
        Me.rbDataType2.UseVisualStyleBackColor = False
        '
        'rbDataType0
        '
        Me.rbDataType0.BackColor = System.Drawing.SystemColors.Control
        Me.rbDataType0.Checked = True
        Me.rbDataType0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbDataType0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDataType0.ForeColor = System.Drawing.Color.Blue
        Me.rbDataType0.Location = New System.Drawing.Point(12, 28)
        Me.rbDataType0.Name = "rbDataType0"
        Me.rbDataType0.Size = New System.Drawing.Size(138, 21)
        Me.rbDataType0.TabIndex = 28
        Me.rbDataType0.TabStop = True
        Me.rbDataType0.Text = "Variable Data Field"
        Me.rbDataType0.UseVisualStyleBackColor = False
        '
        'rbDataType1
        '
        Me.rbDataType1.BackColor = System.Drawing.SystemColors.Control
        Me.rbDataType1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbDataType1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDataType1.ForeColor = System.Drawing.Color.Blue
        Me.rbDataType1.Location = New System.Drawing.Point(12, 144)
        Me.rbDataType1.Name = "rbDataType1"
        Me.rbDataType1.Size = New System.Drawing.Size(157, 24)
        Me.rbDataType1.TabIndex = 12
        Me.rbDataType1.Text = "Constant Data Field"
        Me.rbDataType1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(116, 486)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(269, 23)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Separated the new Chr Code and old Char Code by coma (,) For E.g 0D,20"
        '
        'txtReplCharCode
        '
        Me.txtReplCharCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReplCharCode.Location = New System.Drawing.Point(117, 465)
        Me.txtReplCharCode.Name = "txtReplCharCode"
        Me.txtReplCharCode.Size = New System.Drawing.Size(275, 21)
        Me.txtReplCharCode.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 467)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 14)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Repl Char Code"
        '
        'rbDataType3
        '
        Me.rbDataType3.BackColor = System.Drawing.SystemColors.Control
        Me.rbDataType3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbDataType3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDataType3.ForeColor = System.Drawing.Color.Blue
        Me.rbDataType3.Location = New System.Drawing.Point(12, 340)
        Me.rbDataType3.Name = "rbDataType3"
        Me.rbDataType3.Size = New System.Drawing.Size(198, 21)
        Me.rbDataType3.TabIndex = 14
        Me.rbDataType3.Text = "Date Data Field (SysDate)"
        Me.rbDataType3.UseVisualStyleBackColor = False
        '
        'txtNewDateFormat
        '
        Me.txtNewDateFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewDateFormat.Location = New System.Drawing.Point(117, 536)
        Me.txtNewDateFormat.Name = "txtNewDateFormat"
        Me.txtNewDateFormat.Size = New System.Drawing.Size(275, 21)
        Me.txtNewDateFormat.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(-1, 538)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "New Date Format"
        '
        'chkLastDayOfMth
        '
        Me.chkLastDayOfMth.AutoSize = True
        Me.chkLastDayOfMth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLastDayOfMth.Location = New System.Drawing.Point(127, 439)
        Me.chkLastDayOfMth.Name = "chkLastDayOfMth"
        Me.chkLastDayOfMth.Size = New System.Drawing.Size(177, 18)
        Me.chkLastDayOfMth.TabIndex = 24
        Me.chkLastDayOfMth.Text = "Get Last Day of a Month"
        Me.chkLastDayOfMth.UseVisualStyleBackColor = True
        '
        'chkCheckPoscode
        '
        Me.chkCheckPoscode.AutoSize = True
        Me.chkCheckPoscode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheckPoscode.Location = New System.Drawing.Point(11, 439)
        Me.chkCheckPoscode.Name = "chkCheckPoscode"
        Me.chkCheckPoscode.Size = New System.Drawing.Size(117, 18)
        Me.chkCheckPoscode.TabIndex = 23
        Me.chkCheckPoscode.Text = "Check Poscode"
        Me.chkCheckPoscode.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.chkConditionFld)
        Me.GroupBox7.Controls.Add(Me.txtReplValue)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.txtConditionFld)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(11, 360)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(395, 76)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(128, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 11)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "List out all conditions that separated by coma (,)"
        '
        'chkConditionFld
        '
        Me.chkConditionFld.AutoSize = True
        Me.chkConditionFld.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConditionFld.Location = New System.Drawing.Point(5, 0)
        Me.chkConditionFld.Name = "chkConditionFld"
        Me.chkConditionFld.Size = New System.Drawing.Size(117, 18)
        Me.chkConditionFld.TabIndex = 16
        Me.chkConditionFld.Text = "Condition Field"
        Me.chkConditionFld.UseVisualStyleBackColor = True
        '
        'txtReplValue
        '
        Me.txtReplValue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReplValue.Location = New System.Drawing.Point(98, 48)
        Me.txtReplValue.Name = "txtReplValue"
        Me.txtReplValue.Size = New System.Drawing.Size(279, 21)
        Me.txtReplValue.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(9, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 14)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Value"
        '
        'txtConditionFld
        '
        Me.txtConditionFld.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConditionFld.Location = New System.Drawing.Point(98, 21)
        Me.txtConditionFld.Name = "txtConditionFld"
        Me.txtConditionFld.Size = New System.Drawing.Size(279, 21)
        Me.txtConditionFld.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Condition"
        '
        'lblDataFldID
        '
        Me.lblDataFldID.AutoSize = True
        Me.lblDataFldID.Location = New System.Drawing.Point(5, 6)
        Me.lblDataFldID.Name = "lblDataFldID"
        Me.lblDataFldID.Size = New System.Drawing.Size(0, 13)
        Me.lblDataFldID.TabIndex = 21
        '
        'cmbOutputFormat
        '
        Me.cmbOutputFormat.FormattingEnabled = True
        Me.cmbOutputFormat.Items.AddRange(New Object() {"HEX", "ASCII"})
        Me.cmbOutputFormat.Location = New System.Drawing.Point(118, 563)
        Me.cmbOutputFormat.Name = "cmbOutputFormat"
        Me.cmbOutputFormat.Size = New System.Drawing.Size(274, 21)
        Me.cmbOutputFormat.TabIndex = 16
        Me.cmbOutputFormat.Text = "ASCII"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 565)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 14)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Output Format"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbDataFldName)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtCompositeFld)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(6, 207)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(395, 129)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        '
        'cmbDataFldName
        '
        Me.cmbDataFldName.FormattingEnabled = True
        Me.cmbDataFldName.Location = New System.Drawing.Point(112, 20)
        Me.cmbDataFldName.Name = "cmbDataFldName"
        Me.cmbDataFldName.Size = New System.Drawing.Size(274, 21)
        Me.cmbDataFldName.Sorted = True
        Me.cmbDataFldName.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Data Field Name"
        '
        'txtCompositeFld
        '
        Me.txtCompositeFld.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompositeFld.Location = New System.Drawing.Point(112, 49)
        Me.txtCompositeFld.Multiline = True
        Me.txtCompositeFld.Name = "txtCompositeFld"
        Me.txtCompositeFld.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCompositeFld.Size = New System.Drawing.Size(274, 78)
        Me.txtCompositeFld.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Composite Field"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 98)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtEndCode)
        Me.GroupBox3.Controls.Add(Me.txtDataLength)
        Me.GroupBox3.Controls.Add(Me.rbEndFld1)
        Me.GroupBox3.Controls.Add(Me.rbEndFld0)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(197, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 68)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "End of Field"
        '
        'txtEndCode
        '
        Me.txtEndCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndCode.Location = New System.Drawing.Point(94, 40)
        Me.txtEndCode.Name = "txtEndCode"
        Me.txtEndCode.Size = New System.Drawing.Size(73, 21)
        Me.txtEndCode.TabIndex = 13
        '
        'txtDataLength
        '
        Me.txtDataLength.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataLength.Location = New System.Drawing.Point(94, 17)
        Me.txtDataLength.Name = "txtDataLength"
        Me.txtDataLength.Size = New System.Drawing.Size(73, 21)
        Me.txtDataLength.TabIndex = 12
        '
        'rbEndFld1
        '
        Me.rbEndFld1.BackColor = System.Drawing.SystemColors.Control
        Me.rbEndFld1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbEndFld1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEndFld1.ForeColor = System.Drawing.Color.Black
        Me.rbEndFld1.Location = New System.Drawing.Point(6, 41)
        Me.rbEndFld1.Name = "rbEndFld1"
        Me.rbEndFld1.Size = New System.Drawing.Size(118, 21)
        Me.rbEndFld1.TabIndex = 10
        Me.rbEndFld1.Text = "End Code"
        Me.rbEndFld1.UseVisualStyleBackColor = False
        '
        'rbEndFld0
        '
        Me.rbEndFld0.BackColor = System.Drawing.SystemColors.Control
        Me.rbEndFld0.Checked = True
        Me.rbEndFld0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbEndFld0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEndFld0.ForeColor = System.Drawing.Color.Black
        Me.rbEndFld0.Location = New System.Drawing.Point(6, 15)
        Me.rbEndFld0.Name = "rbEndFld0"
        Me.rbEndFld0.Size = New System.Drawing.Size(118, 21)
        Me.rbEndFld0.TabIndex = 9
        Me.rbEndFld0.TabStop = True
        Me.rbEndFld0.Text = "Length"
        Me.rbEndFld0.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtStartCode)
        Me.GroupBox2.Controls.Add(Me.txtStartPosition)
        Me.GroupBox2.Controls.Add(Me.rbStartFld1)
        Me.GroupBox2.Controls.Add(Me.rbStartFld0)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 68)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Start of Field"
        '
        'txtStartCode
        '
        Me.txtStartCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartCode.Location = New System.Drawing.Point(103, 41)
        Me.txtStartCode.Name = "txtStartCode"
        Me.txtStartCode.Size = New System.Drawing.Size(73, 21)
        Me.txtStartCode.TabIndex = 12
        '
        'txtStartPosition
        '
        Me.txtStartPosition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartPosition.Location = New System.Drawing.Point(103, 16)
        Me.txtStartPosition.Name = "txtStartPosition"
        Me.txtStartPosition.Size = New System.Drawing.Size(73, 21)
        Me.txtStartPosition.TabIndex = 11
        '
        'rbStartFld1
        '
        Me.rbStartFld1.BackColor = System.Drawing.SystemColors.Control
        Me.rbStartFld1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbStartFld1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStartFld1.ForeColor = System.Drawing.Color.Black
        Me.rbStartFld1.Location = New System.Drawing.Point(6, 41)
        Me.rbStartFld1.Name = "rbStartFld1"
        Me.rbStartFld1.Size = New System.Drawing.Size(92, 21)
        Me.rbStartFld1.TabIndex = 10
        Me.rbStartFld1.Text = "Start Code"
        Me.rbStartFld1.UseVisualStyleBackColor = False
        '
        'rbStartFld0
        '
        Me.rbStartFld0.BackColor = System.Drawing.SystemColors.Control
        Me.rbStartFld0.Checked = True
        Me.rbStartFld0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbStartFld0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStartFld0.ForeColor = System.Drawing.Color.Black
        Me.rbStartFld0.Location = New System.Drawing.Point(6, 15)
        Me.rbStartFld0.Name = "rbStartFld0"
        Me.rbStartFld0.Size = New System.Drawing.Size(118, 21)
        Me.rbStartFld0.TabIndex = 9
        Me.rbStartFld0.TabStop = True
        Me.rbStartFld0.Text = "Start Position"
        Me.rbStartFld0.UseVisualStyleBackColor = False
        '
        'txtDataFldName
        '
        Me.txtDataFldName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataFldName.Location = New System.Drawing.Point(147, 9)
        Me.txtDataFldName.Name = "txtDataFldName"
        Me.txtDataFldName.Size = New System.Drawing.Size(238, 21)
        Me.txtDataFldName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Data Field Name"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtStaticData)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(5, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(395, 44)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'txtStaticData
        '
        Me.txtStaticData.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaticData.Location = New System.Drawing.Point(129, 17)
        Me.txtStaticData.Name = "txtStaticData"
        Me.txtStaticData.Size = New System.Drawing.Size(245, 21)
        Me.txtStaticData.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(50, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Static Data"
        '
        'cmdClear
        '
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClear.Image = Global.DPSReporting.My.Resources.Resources.Paintbrush_1
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClear.Location = New System.Drawing.Point(846, 638)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(78, 51)
        Me.cmdClear.TabIndex = 20
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Image = Global.DPSReporting.My.Resources.Resources.db_remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(763, 638)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(78, 51)
        Me.cmdDelete.TabIndex = 19
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Image = Global.DPSReporting.My.Resources.Resources.file_edit
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(679, 638)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(78, 51)
        Me.cmdEdit.TabIndex = 18
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Image = Global.DPSReporting.My.Resources.Resources.db_add
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdd.Location = New System.Drawing.Point(595, 638)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(78, 51)
        Me.cmdAdd.TabIndex = 17
        Me.cmdAdd.Text = "Add New"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'dgridDataSetup
        '
        Me.dgridDataSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridDataSetup.Location = New System.Drawing.Point(9, 233)
        Me.dgridDataSetup.Name = "dgridDataSetup"
        Me.dgridDataSetup.Size = New System.Drawing.Size(580, 366)
        Me.dgridDataSetup.TabIndex = 8
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(11, 614)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 14)
        Me.lblTotal.TabIndex = 9
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Image = Global.DPSReporting.My.Resources.Resources.Log_Off
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(930, 638)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(78, 51)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblDataSetupID
        '
        Me.lblDataSetupID.AutoSize = True
        Me.lblDataSetupID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataSetupID.Location = New System.Drawing.Point(15, 641)
        Me.lblDataSetupID.Name = "lblDataSetupID"
        Me.lblDataSetupID.Size = New System.Drawing.Size(0, 14)
        Me.lblDataSetupID.TabIndex = 10
        Me.lblDataSetupID.Visible = False
        '
        'frmDataSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 778)
        Me.Controls.Add(Me.lblDataSetupID)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.dgridDataSetup)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDataSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Setup Definition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgridDataSetup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOpenSampleFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFileContents As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFldHexValue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFldLength As System.Windows.Forms.TextBox
    Friend WithEvents txtFldStartPos As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEndFld1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbEndFld0 As System.Windows.Forms.RadioButton
    Friend WithEvents rbStartFld1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbStartFld0 As System.Windows.Forms.RadioButton
    Friend WithEvents txtEndCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDataLength As System.Windows.Forms.TextBox
    Friend WithEvents txtStartCode As System.Windows.Forms.TextBox
    Friend WithEvents txtStartPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtDataFldName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCompositeFld As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStaticData As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDataFldName As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNewDateFormat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbDataType3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDataType1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbOutputFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents dgridDataSetup As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDataFldID As System.Windows.Forms.Label
    Friend WithEvents lblDataSetupID As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReplValue As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtConditionFld As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkConditionFld As System.Windows.Forms.CheckBox
    Friend WithEvents chkLastDayOfMth As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheckPoscode As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtReplCharCode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rbDataType0 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDataType2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtOldDateFmt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkCurrency As System.Windows.Forms.CheckBox
    Friend WithEvents rbDataType5 As System.Windows.Forms.RadioButton
    Friend WithEvents chkCheckNmSeparator As System.Windows.Forms.CheckBox
End Class
