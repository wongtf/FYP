<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCNPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCNPrint))
        Me.cbType = New System.Windows.Forms.ComboBox
        Me.cbFileDate = New System.Windows.Forms.ComboBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.cbFile = New System.Windows.Forms.ComboBox
        Me.lvField = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbCount = New System.Windows.Forms.Label
        Me.btnAll = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSelected = New System.Windows.Forms.Button
        Me.picLoad = New System.Windows.Forms.PictureBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnChange = New System.Windows.Forms.Button
        Me.cbDeliveryType = New System.Windows.Forms.ComboBox
        Me.btnExportCN = New System.Windows.Forms.Button
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Location = New System.Drawing.Point(257, 66)
        Me.cbType.MaxDropDownItems = 50
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(126, 21)
        Me.cbType.TabIndex = 3
        '
        'cbFileDate
        '
        Me.cbFileDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileDate.Location = New System.Drawing.Point(157, 66)
        Me.cbFileDate.MaxDropDownItems = 50
        Me.cbFileDate.Name = "cbFileDate"
        Me.cbFileDate.Size = New System.Drawing.Size(94, 21)
        Me.cbFileDate.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(585, 64)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(83, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'cbFile
        '
        Me.cbFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFile.Location = New System.Drawing.Point(389, 66)
        Me.cbFile.MaxDropDownItems = 50
        Me.cbFile.Name = "cbFile"
        Me.cbFile.Size = New System.Drawing.Size(190, 21)
        Me.cbFile.TabIndex = 4
        '
        'lvField
        '
        Me.lvField.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvField.FullRowSelect = True
        Me.lvField.HideSelection = False
        Me.lvField.Location = New System.Drawing.Point(35, 127)
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(661, 276)
        Me.lvField.TabIndex = 6
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
        Me.ColumnHeader2.Text = "CDS Number"
        Me.ColumnHeader2.Width = 96
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Account Number"
        Me.ColumnHeader3.Width = 156
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cardholder Name"
        Me.ColumnHeader4.Width = 176
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mailer Name"
        Me.ColumnHeader5.Width = 179
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(32, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(312, 16)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "File information:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(135, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = " :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "File name"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(615, 413)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbCount
        '
        Me.lbCount.BackColor = System.Drawing.Color.Transparent
        Me.lbCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCount.ForeColor = System.Drawing.Color.Black
        Me.lbCount.Location = New System.Drawing.Point(32, 108)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(219, 16)
        Me.lbCount.TabIndex = 73
        Me.lbCount.Text = "Record found:"
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = System.Drawing.Color.White
        Me.btnAll.Location = New System.Drawing.Point(407, 413)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(98, 23)
        Me.btnAll.TabIndex = 7
        Me.btnAll.Text = "&Print All"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Courier Type"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(135, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = " :"
        '
        'btnSelected
        '
        Me.btnSelected.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSelected.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelected.ForeColor = System.Drawing.Color.White
        Me.btnSelected.Location = New System.Drawing.Point(511, 413)
        Me.btnSelected.Name = "btnSelected"
        Me.btnSelected.Size = New System.Drawing.Size(98, 23)
        Me.btnSelected.TabIndex = 8
        Me.btnSelected.Text = "&Print Selected"
        Me.btnSelected.UseVisualStyleBackColor = False
        '
        'picLoad
        '
        Me.picLoad.BackColor = System.Drawing.Color.White
        Me.picLoad.Image = CType(resources.GetObject("picLoad.Image"), System.Drawing.Image)
        Me.picLoad.Location = New System.Drawing.Point(157, 199)
        Me.picLoad.Name = "picLoad"
        Me.picLoad.Size = New System.Drawing.Size(406, 133)
        Me.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoad.TabIndex = 84
        Me.picLoad.TabStop = False
        Me.picLoad.Visible = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BackColor = System.Drawing.Color.Beige
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 470)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(733, 94)
        Me.CrystalReportViewer1.TabIndex = 85
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        Me.CrystalReportViewer1.Visible = False
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnChange.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.White
        Me.btnChange.Location = New System.Drawing.Point(35, 413)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(98, 23)
        Me.btnChange.TabIndex = 86
        Me.btnChange.Text = "C&hange Courier"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'cbDeliveryType
        '
        Me.cbDeliveryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeliveryType.Location = New System.Drawing.Point(157, 34)
        Me.cbDeliveryType.MaxDropDownItems = 50
        Me.cbDeliveryType.Name = "cbDeliveryType"
        Me.cbDeliveryType.Size = New System.Drawing.Size(143, 21)
        Me.cbDeliveryType.TabIndex = 87
        '
        'btnExportCN
        '
        Me.btnExportCN.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnExportCN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportCN.ForeColor = System.Drawing.Color.White
        Me.btnExportCN.Location = New System.Drawing.Point(303, 413)
        Me.btnExportCN.Name = "btnExportCN"
        Me.btnExportCN.Size = New System.Drawing.Size(98, 23)
        Me.btnExportCN.TabIndex = 88
        Me.btnExportCN.Text = "&Export"
        Me.btnExportCN.UseVisualStyleBackColor = False
        '
        'frmCNPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(731, 454)
        Me.Controls.Add(Me.btnExportCN)
        Me.Controls.Add(Me.cbDeliveryType)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.picLoad)
        Me.Controls.Add(Me.btnSelected)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.cbFileDate)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cbFile)
        Me.Controls.Add(Me.lvField)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbCount)
        Me.Controls.Add(Me.btnAll)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCNPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents cbFileDate As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents cbFile As System.Windows.Forms.ComboBox
    Friend WithEvents lvField As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbCount As System.Windows.Forms.Label
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSelected As System.Windows.Forms.Button
    Friend WithEvents picLoad As System.Windows.Forms.PictureBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents cbDeliveryType As System.Windows.Forms.ComboBox
    Friend WithEvents btnExportCN As System.Windows.Forms.Button
End Class
