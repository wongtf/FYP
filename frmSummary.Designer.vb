<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummary))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.cbFileDate = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optPreEmb2 = New System.Windows.Forms.RadioButton
        Me.optPreEmb1 = New System.Windows.Forms.RadioButton
        Me.optRenewal = New System.Windows.Forms.RadioButton
        Me.optDaily = New System.Windows.Forms.RadioButton
        Me.optAll = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnGetReport = New System.Windows.Forms.Button
        Me.optMEB1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 47)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(920, 444)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'cbFileDate
        '
        Me.cbFileDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFileDate.Items.AddRange(New Object() {"PLAINTEXT", "DCQSS NATIVE"})
        Me.cbFileDate.Location = New System.Drawing.Point(128, 13)
        Me.cbFileDate.MaxDropDownItems = 50
        Me.cbFileDate.Name = "cbFileDate"
        Me.cbFileDate.Size = New System.Drawing.Size(94, 21)
        Me.cbFileDate.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optMEB1)
        Me.GroupBox1.Controls.Add(Me.optPreEmb2)
        Me.GroupBox1.Controls.Add(Me.optPreEmb1)
        Me.GroupBox1.Controls.Add(Me.optRenewal)
        Me.GroupBox1.Controls.Add(Me.optDaily)
        Me.GroupBox1.Controls.Add(Me.optAll)
        Me.GroupBox1.Controls.Add(Me.cbFileDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 39)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'optPreEmb2
        '
        Me.optPreEmb2.AutoSize = True
        Me.optPreEmb2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPreEmb2.Location = New System.Drawing.Point(609, 15)
        Me.optPreEmb2.Name = "optPreEmb2"
        Me.optPreEmb2.Size = New System.Drawing.Size(44, 17)
        Me.optPreEmb2.TabIndex = 39
        Me.optPreEmb2.Text = "PEU"
        Me.optPreEmb2.UseVisualStyleBackColor = True
        '
        'optPreEmb1
        '
        Me.optPreEmb1.AutoSize = True
        Me.optPreEmb1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPreEmb1.Location = New System.Drawing.Point(556, 15)
        Me.optPreEmb1.Name = "optPreEmb1"
        Me.optPreEmb1.Size = New System.Drawing.Size(43, 17)
        Me.optPreEmb1.TabIndex = 38
        Me.optPreEmb1.Text = "PE2"
        Me.optPreEmb1.UseVisualStyleBackColor = True
        '
        'optRenewal
        '
        Me.optRenewal.AutoSize = True
        Me.optRenewal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRenewal.Location = New System.Drawing.Point(480, 15)
        Me.optRenewal.Name = "optRenewal"
        Me.optRenewal.Size = New System.Drawing.Size(66, 17)
        Me.optRenewal.TabIndex = 37
        Me.optRenewal.Text = "Renewal"
        Me.optRenewal.UseVisualStyleBackColor = True
        '
        'optDaily
        '
        Me.optDaily.AutoSize = True
        Me.optDaily.Checked = True
        Me.optDaily.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDaily.Location = New System.Drawing.Point(303, 15)
        Me.optDaily.Name = "optDaily"
        Me.optDaily.Size = New System.Drawing.Size(167, 17)
        Me.optDaily.TabIndex = 36
        Me.optDaily.TabStop = True
        Me.optDaily.Text = "Daily+Replacement+Upgrade"
        Me.optDaily.UseVisualStyleBackColor = True
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Checked = True
        Me.optAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAll.Location = New System.Drawing.Point(257, 15)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(36, 17)
        Me.optAll.TabIndex = 1
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(28, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Type of Report"
        '
        'btnGetReport
        '
        Me.btnGetReport.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGetReport.ForeColor = System.Drawing.Color.White
        Me.btnGetReport.Location = New System.Drawing.Point(782, 11)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(83, 23)
        Me.btnGetReport.TabIndex = 0
        Me.btnGetReport.Text = "&Get Report"
        Me.btnGetReport.UseVisualStyleBackColor = False
        '
        'optMEB1
        '
        Me.optMEB1.AutoSize = True
        Me.optMEB1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMEB1.Location = New System.Drawing.Point(663, 15)
        Me.optMEB1.Name = "optMEB1"
        Me.optMEB1.Size = New System.Drawing.Size(87, 17)
        Me.optMEB1.TabIndex = 41
        Me.optMEB1.Text = "ME-B1/B2/B3"
        Me.optMEB1.UseVisualStyleBackColor = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(899, 497)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGetReport)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Summary Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbFileDate As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGetReport As System.Windows.Forms.Button
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents optPreEmb2 As System.Windows.Forms.RadioButton
    Friend WithEvents optPreEmb1 As System.Windows.Forms.RadioButton
    Friend WithEvents optRenewal As System.Windows.Forms.RadioButton
    Friend WithEvents optDaily As System.Windows.Forms.RadioButton
    Friend WithEvents optMEB1 As System.Windows.Forms.RadioButton
End Class
