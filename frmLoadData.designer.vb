<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadData
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
        Me.cmbEmbFile = New System.Windows.Forms.ComboBox
        Me.cmdLoadOne = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdLoadAll = New System.Windows.Forms.Button
        Me.lstGoodFile = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstErrorFile = New System.Windows.Forms.ListBox
        Me.lblProdStatus = New System.Windows.Forms.Label
        Me.chkNoFileEnc = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'cmbEmbFile
        '
        Me.cmbEmbFile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmbFile.FormattingEnabled = True
        Me.cmbEmbFile.Location = New System.Drawing.Point(152, 12)
        Me.cmbEmbFile.Name = "cmbEmbFile"
        Me.cmbEmbFile.Size = New System.Drawing.Size(335, 24)
        Me.cmbEmbFile.TabIndex = 0
        '
        'cmdLoadOne
        '
        Me.cmdLoadOne.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadOne.Location = New System.Drawing.Point(350, 42)
        Me.cmdLoadOne.Name = "cmdLoadOne"
        Me.cmdLoadOne.Size = New System.Drawing.Size(84, 34)
        Me.cmdLoadOne.TabIndex = 1
        Me.cmdLoadOne.Text = "Load One"
        Me.cmdLoadOne.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Incoming Data File :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdLoadAll
        '
        Me.cmdLoadAll.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadAll.Location = New System.Drawing.Point(252, 42)
        Me.cmdLoadAll.Name = "cmdLoadAll"
        Me.cmdLoadAll.Size = New System.Drawing.Size(81, 34)
        Me.cmdLoadAll.TabIndex = 6
        Me.cmdLoadAll.Text = "Load All"
        Me.cmdLoadAll.UseVisualStyleBackColor = True
        '
        'lstGoodFile
        '
        Me.lstGoodFile.FormattingEnabled = True
        Me.lstGoodFile.HorizontalScrollbar = True
        Me.lstGoodFile.Location = New System.Drawing.Point(68, 117)
        Me.lstGoodFile.Name = "lstGoodFile"
        Me.lstGoodFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstGoodFile.ScrollAlwaysVisible = True
        Me.lstGoodFile.Size = New System.Drawing.Size(517, 186)
        Me.lstGoodFile.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Good File : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Error Reported : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstErrorFile
        '
        Me.lstErrorFile.FormattingEnabled = True
        Me.lstErrorFile.HorizontalScrollbar = True
        Me.lstErrorFile.Location = New System.Drawing.Point(68, 322)
        Me.lstErrorFile.Name = "lstErrorFile"
        Me.lstErrorFile.ScrollAlwaysVisible = True
        Me.lstErrorFile.Size = New System.Drawing.Size(517, 134)
        Me.lstErrorFile.TabIndex = 9
        '
        'lblProdStatus
        '
        Me.lblProdStatus.AutoSize = True
        Me.lblProdStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdStatus.Location = New System.Drawing.Point(149, 78)
        Me.lblProdStatus.Name = "lblProdStatus"
        Me.lblProdStatus.Size = New System.Drawing.Size(93, 14)
        Me.lblProdStatus.TabIndex = 22
        Me.lblProdStatus.Text = "Load File Status"
        '
        'chkNoFileEnc
        '
        Me.chkNoFileEnc.AutoSize = True
        Me.chkNoFileEnc.Location = New System.Drawing.Point(493, 16)
        Me.chkNoFileEnc.Name = "chkNoFileEnc"
        Me.chkNoFileEnc.Size = New System.Drawing.Size(78, 17)
        Me.chkNoFileEnc.TabIndex = 23
        Me.chkNoFileEnc.Text = "W/O ENC "
        Me.chkNoFileEnc.UseVisualStyleBackColor = True
        '
        'frmLoadData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 474)
        Me.Controls.Add(Me.chkNoFileEnc)
        Me.Controls.Add(Me.lblProdStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstErrorFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstGoodFile)
        Me.Controls.Add(Me.cmdLoadAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdLoadOne)
        Me.Controls.Add(Me.cmbEmbFile)
        Me.MaximizeBox = False
        Me.Name = "frmLoadData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Embossing File Loading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbEmbFile As System.Windows.Forms.ComboBox
    Friend WithEvents cmdLoadOne As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdLoadAll As System.Windows.Forms.Button
    Friend WithEvents lstGoodFile As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstErrorFile As System.Windows.Forms.ListBox
    Friend WithEvents lblProdStatus As System.Windows.Forms.Label
    Friend WithEvents chkNoFileEnc As System.Windows.Forms.CheckBox
End Class
