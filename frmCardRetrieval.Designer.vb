<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardRetrieval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCardRetrieval))
        Me.btnGetReport = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbFileDate = New System.Windows.Forms.ComboBox
        Me.optRenewal = New System.Windows.Forms.RadioButton
        Me.optDaily = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.optME = New System.Windows.Forms.RadioButton
        Me.cbMEBatch = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetReport
        '
        Me.btnGetReport.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGetReport.ForeColor = System.Drawing.Color.White
        Me.btnGetReport.Location = New System.Drawing.Point(805, 10)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(83, 23)
        Me.btnGetReport.TabIndex = 27
        Me.btnGetReport.Text = "&Get Report"
        Me.btnGetReport.UseVisualStyleBackColor = False
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 47)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(898, 451)
        Me.CrystalReportViewer1.TabIndex = 25
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbMEBatch)
        Me.GroupBox1.Controls.Add(Me.optME)
        Me.GroupBox1.Controls.Add(Me.cbFileDate)
        Me.GroupBox1.Controls.Add(Me.optRenewal)
        Me.GroupBox1.Controls.Add(Me.optDaily)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 39)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'cbFileDate
        '
        Me.cbFileDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileDate.Items.AddRange(New Object() {"PLAINTEXT", "DCQSS NATIVE"})
        Me.cbFileDate.Location = New System.Drawing.Point(127, 13)
        Me.cbFileDate.MaxDropDownItems = 50
        Me.cbFileDate.Name = "cbFileDate"
        Me.cbFileDate.Size = New System.Drawing.Size(94, 21)
        Me.cbFileDate.TabIndex = 36
        '
        'optRenewal
        '
        Me.optRenewal.AutoSize = True
        Me.optRenewal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRenewal.Location = New System.Drawing.Point(414, 13)
        Me.optRenewal.Name = "optRenewal"
        Me.optRenewal.Size = New System.Drawing.Size(119, 17)
        Me.optRenewal.TabIndex = 32
        Me.optRenewal.Text = "Renewal+PE2+PEU"
        Me.optRenewal.UseVisualStyleBackColor = True
        '
        'optDaily
        '
        Me.optDaily.AutoSize = True
        Me.optDaily.Checked = True
        Me.optDaily.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDaily.Location = New System.Drawing.Point(237, 13)
        Me.optDaily.Name = "optDaily"
        Me.optDaily.Size = New System.Drawing.Size(167, 17)
        Me.optDaily.TabIndex = 31
        Me.optDaily.TabStop = True
        Me.optDaily.Text = "Daily+Replacement+Upgrade"
        Me.optDaily.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Type of Report"
        '
        'optME
        '
        Me.optME.AutoSize = True
        Me.optME.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optME.Location = New System.Drawing.Point(543, 13)
        Me.optME.Name = "optME"
        Me.optME.Size = New System.Drawing.Size(39, 17)
        Me.optME.TabIndex = 37
        Me.optME.Text = "ME"
        Me.optME.UseVisualStyleBackColor = True
        '
        'cbMEBatch
        '
        Me.cbMEBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMEBatch.Items.AddRange(New Object() {"B1", "B2", "B3"})
        Me.cbMEBatch.Location = New System.Drawing.Point(589, 12)
        Me.cbMEBatch.MaxDropDownItems = 50
        Me.cbMEBatch.Name = "cbMEBatch"
        Me.cbMEBatch.Size = New System.Drawing.Size(94, 21)
        Me.cbMEBatch.TabIndex = 38
        '
        'frmCardRetrieval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(900, 498)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGetReport)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCardRetrieval"
        Me.Text = "Print Card Retrieval List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetReport As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optRenewal As System.Windows.Forms.RadioButton
    Friend WithEvents optDaily As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbFileDate As System.Windows.Forms.ComboBox
    Friend WithEvents cbMEBatch As System.Windows.Forms.ComboBox
    Friend WithEvents optME As System.Windows.Forms.RadioButton
End Class
