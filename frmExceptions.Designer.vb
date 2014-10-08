<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExceptions
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExceptions))
        Me.picFail = New System.Windows.Forms.PictureBox
        Me.picOK = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtPAN = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbOld = New System.Windows.Forms.Label
        Me.txtCDSNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbFileDate = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.picFail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFail
        '
        Me.picFail.Image = CType(resources.GetObject("picFail.Image"), System.Drawing.Image)
        Me.picFail.Location = New System.Drawing.Point(31, 172)
        Me.picFail.Name = "picFail"
        Me.picFail.Size = New System.Drawing.Size(31, 29)
        Me.picFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFail.TabIndex = 24
        Me.picFail.TabStop = False
        Me.picFail.Visible = False
        '
        'picOK
        '
        Me.picOK.Image = CType(resources.GetObject("picOK.Image"), System.Drawing.Image)
        Me.picOK.Location = New System.Drawing.Point(31, 172)
        Me.picOK.Name = "picOK"
        Me.picOK.Size = New System.Drawing.Size(31, 29)
        Me.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOK.TabIndex = 23
        Me.picOK.TabStop = False
        Me.picOK.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(303, 172)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(233, 172)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(67, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&Ok"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txtPAN
        '
        Me.txtPAN.BackColor = System.Drawing.Color.White
        Me.txtPAN.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAN.ForeColor = System.Drawing.Color.Black
        Me.txtPAN.Location = New System.Drawing.Point(96, 133)
        Me.txtPAN.MaxLength = 16
        Me.txtPAN.Name = "txtPAN"
        Me.txtPAN.Size = New System.Drawing.Size(274, 23)
        Me.txtPAN.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Account No"
        '
        'lbOld
        '
        Me.lbOld.BackColor = System.Drawing.Color.Transparent
        Me.lbOld.ForeColor = System.Drawing.Color.White
        Me.lbOld.Location = New System.Drawing.Point(21, 206)
        Me.lbOld.Name = "lbOld"
        Me.lbOld.Size = New System.Drawing.Size(187, 13)
        Me.lbOld.TabIndex = 25
        '
        'txtCDSNo
        '
        Me.txtCDSNo.BackColor = System.Drawing.Color.White
        Me.txtCDSNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCDSNo.ForeColor = System.Drawing.Color.Black
        Me.txtCDSNo.Location = New System.Drawing.Point(96, 96)
        Me.txtCDSNo.MaxLength = 16
        Me.txtCDSNo.Name = "txtCDSNo"
        Me.txtCDSNo.Size = New System.Drawing.Size(274, 23)
        Me.txtCDSNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "CDS No"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Or"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(14, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(333, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Please enter CDS Number or Account Number (PAN)"
        '
        'cbFileDate
        '
        Me.cbFileDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileDate.Location = New System.Drawing.Point(96, 52)
        Me.cbFileDate.MaxDropDownItems = 50
        Me.cbFileDate.Name = "cbFileDate"
        Me.cbFileDate.Size = New System.Drawing.Size(94, 21)
        Me.cbFileDate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 23)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "File date"
        '
        'frmExceptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(411, 233)
        Me.Controls.Add(Me.cbFileDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCDSNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbOld)
        Me.Controls.Add(Me.picFail)
        Me.Controls.Add(Me.picOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPAN)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExceptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  SI/Destroy Card List - (Entry)"
        CType(Me.picFail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picFail As System.Windows.Forms.PictureBox
    Friend WithEvents picOK As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtPAN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbOld As System.Windows.Forms.Label
    Friend WithEvents txtCDSNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbFileDate As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
