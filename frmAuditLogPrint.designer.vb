<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditLogPrint
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnGetReport = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbReportType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbUserName = New System.Windows.Forms.ComboBox
        Me.dtPickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtPickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-1, 132)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(769, 273)
        Me.CrystalReportViewer1.TabIndex = 30
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnGetReport
        '
        Me.btnGetReport.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGetReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetReport.ForeColor = System.Drawing.Color.White
        Me.btnGetReport.Location = New System.Drawing.Point(525, 93)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(83, 23)
        Me.btnGetReport.TabIndex = 31
        Me.btnGetReport.Text = "&Get Report"
        Me.btnGetReport.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Type Of Report :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbReportType
        '
        Me.cmbReportType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.Items.AddRange(New Object() {"All", "Audit Log", "Production", "Setup", "Security"})
        Me.cmbReportType.Location = New System.Drawing.Point(276, 12)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(284, 22)
        Me.cmbReportType.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "User Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbUserName
        '
        Me.cmbUserName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserName.FormattingEnabled = True
        Me.cmbUserName.Location = New System.Drawing.Point(276, 39)
        Me.cmbUserName.Name = "cmbUserName"
        Me.cmbUserName.Size = New System.Drawing.Size(284, 22)
        Me.cmbUserName.TabIndex = 34
        '
        'dtPickerStartDate
        '
        Me.dtPickerStartDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerStartDate.Location = New System.Drawing.Point(276, 66)
        Me.dtPickerStartDate.Name = "dtPickerStartDate"
        Me.dtPickerStartDate.Size = New System.Drawing.Size(200, 22)
        Me.dtPickerStartDate.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Report Start Date :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Report End Date :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtPickerEndDate
        '
        Me.dtPickerEndDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerEndDate.Location = New System.Drawing.Point(276, 94)
        Me.dtPickerEndDate.Name = "dtPickerEndDate"
        Me.dtPickerEndDate.Size = New System.Drawing.Size(200, 22)
        Me.dtPickerEndDate.TabIndex = 38
        '
        'frmAuditLogPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 405)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtPickerEndDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtPickerStartDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbReportType)
        Me.Controls.Add(Me.btnGetReport)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmAuditLogPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Audit Log Printing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnGetReport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbUserName As System.Windows.Forms.ComboBox
    Friend WithEvents dtPickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtPickerEndDate As System.Windows.Forms.DateTimePicker
End Class
