<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardSetupMainMenu
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
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdDetails = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtEndRecSeparator = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMailerMIC = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSMCMIC = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtOCRMIC = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbMailerIndFldId = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbCardNoFldId = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbFormType = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbDSetupName = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblCardSetupID = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtEncodeMIC = New System.Windows.Forms.TextBox
        Me.txtDefinition = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCardSetupName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdSaveAs = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 31)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(255, 396)
        Me.TreeView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmdDetails)
        Me.Panel1.Controls.Add(Me.cmdClear)
        Me.Panel1.Controls.Add(Me.cmdEdit)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(257, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 472)
        Me.Panel1.TabIndex = 1
        '
        'cmdDetails
        '
        Me.cmdDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDetails.Image = Global.DPSReporting.My.Resources.Resources.binoculars
        Me.cmdDetails.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDetails.Location = New System.Drawing.Point(500, 414)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(115, 51)
        Me.cmdDetails.TabIndex = 26
        Me.cmdDetails.Text = "Details Definition >>>"
        Me.cmdDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDetails.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClear.Image = Global.DPSReporting.My.Resources.Resources.Paintbrush_1
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClear.Location = New System.Drawing.Point(416, 414)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(78, 51)
        Me.cmdClear.TabIndex = 25
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Image = Global.DPSReporting.My.Resources.Resources.file_edit
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(331, 414)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(78, 51)
        Me.cmdEdit.TabIndex = 23
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Image = Global.DPSReporting.My.Resources.Resources.db_add
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdd.Location = New System.Drawing.Point(247, 414)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(78, 51)
        Me.cmdAdd.TabIndex = 22
        Me.cmdAdd.Text = "Add New"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(39, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Card Setup Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtEndRecSeparator)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtMailerMIC)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtSMCMIC)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtOCRMIC)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cbMailerIndFldId)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cbCardNoFldId)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.cbFormType)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.cbDSetupName)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblCardSetupID)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtEncodeMIC)
        Me.Panel2.Controls.Add(Me.txtDefinition)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCardSetupName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(42, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 371)
        Me.Panel2.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "End Record Separator"
        '
        'txtEndRecSeparator
        '
        Me.txtEndRecSeparator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndRecSeparator.Location = New System.Drawing.Point(154, 312)
        Me.txtEndRecSeparator.MaxLength = 50
        Me.txtEndRecSeparator.Name = "txtEndRecSeparator"
        Me.txtEndRecSeparator.Size = New System.Drawing.Size(275, 21)
        Me.txtEndRecSeparator.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Mailer MIC"
        '
        'txtMailerMIC
        '
        Me.txtMailerMIC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailerMIC.Location = New System.Drawing.Point(154, 285)
        Me.txtMailerMIC.MaxLength = 50
        Me.txtMailerMIC.Name = "txtMailerMIC"
        Me.txtMailerMIC.Size = New System.Drawing.Size(275, 21)
        Me.txtMailerMIC.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "SMC MIC"
        '
        'txtSMCMIC
        '
        Me.txtSMCMIC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMCMIC.Location = New System.Drawing.Point(154, 258)
        Me.txtSMCMIC.MaxLength = 50
        Me.txtSMCMIC.Name = "txtSMCMIC"
        Me.txtSMCMIC.Size = New System.Drawing.Size(275, 21)
        Me.txtSMCMIC.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "OCR MIC"
        '
        'txtOCRMIC
        '
        Me.txtOCRMIC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOCRMIC.Location = New System.Drawing.Point(154, 231)
        Me.txtOCRMIC.MaxLength = 50
        Me.txtOCRMIC.Name = "txtOCRMIC"
        Me.txtOCRMIC.Size = New System.Drawing.Size(275, 21)
        Me.txtOCRMIC.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Encode MIC"
        '
        'cbMailerIndFldId
        '
        Me.cbMailerIndFldId.FormattingEnabled = True
        Me.cbMailerIndFldId.Location = New System.Drawing.Point(154, 177)
        Me.cbMailerIndFldId.Name = "cbMailerIndFldId"
        Me.cbMailerIndFldId.Size = New System.Drawing.Size(275, 21)
        Me.cbMailerIndFldId.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "MailerIndicatorFldID"
        '
        'cbCardNoFldId
        '
        Me.cbCardNoFldId.FormattingEnabled = True
        Me.cbCardNoFldId.Location = New System.Drawing.Point(154, 150)
        Me.cbCardNoFldId.Name = "cbCardNoFldId"
        Me.cbCardNoFldId.Size = New System.Drawing.Size(275, 21)
        Me.cbCardNoFldId.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Form Type *"
        '
        'cbFormType
        '
        Me.cbFormType.FormattingEnabled = True
        Me.cbFormType.Items.AddRange(New Object() {"UltraForm", "BasicForm"})
        Me.cbFormType.Location = New System.Drawing.Point(154, 123)
        Me.cbFormType.Name = "cbFormType"
        Me.cbFormType.Size = New System.Drawing.Size(275, 21)
        Me.cbFormType.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Data Setup Name *"
        '
        'cbDSetupName
        '
        Me.cbDSetupName.FormattingEnabled = True
        Me.cbDSetupName.Location = New System.Drawing.Point(154, 96)
        Me.cbDSetupName.Name = "cbDSetupName"
        Me.cbDSetupName.Size = New System.Drawing.Size(275, 21)
        Me.cbDSetupName.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "CardNoFldID"
        '
        'lblCardSetupID
        '
        Me.lblCardSetupID.AutoSize = True
        Me.lblCardSetupID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardSetupID.Location = New System.Drawing.Point(4, 0)
        Me.lblCardSetupID.Name = "lblCardSetupID"
        Me.lblCardSetupID.Size = New System.Drawing.Size(0, 13)
        Me.lblCardSetupID.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(151, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Maximum not more than 50 char"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEncodeMIC
        '
        Me.txtEncodeMIC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncodeMIC.Location = New System.Drawing.Point(154, 204)
        Me.txtEncodeMIC.MaxLength = 50
        Me.txtEncodeMIC.Name = "txtEncodeMIC"
        Me.txtEncodeMIC.Size = New System.Drawing.Size(275, 21)
        Me.txtEncodeMIC.TabIndex = 17
        '
        'txtDefinition
        '
        Me.txtDefinition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefinition.Location = New System.Drawing.Point(154, 64)
        Me.txtDefinition.MaxLength = 50
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.Size = New System.Drawing.Size(275, 21)
        Me.txtDefinition.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Definition"
        '
        'txtCardSetupName
        '
        Me.txtCardSetupName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardSetupName.Location = New System.Drawing.Point(154, 22)
        Me.txtCardSetupName.MaxLength = 50
        Me.txtCardSetupName.Name = "txtCardSetupName"
        Me.txtCardSetupName.Size = New System.Drawing.Size(275, 21)
        Me.txtCardSetupName.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Card Setup Name *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(472, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Card Setup Main Menu - Defined the Card Layout for each product type"
        '
        'cmdSaveAs
        '
        Me.cmdSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSaveAs.Image = Global.DPSReporting.My.Resources.Resources.import
        Me.cmdSaveAs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSaveAs.Location = New System.Drawing.Point(5, 448)
        Me.cmdSaveAs.Name = "cmdSaveAs"
        Me.cmdSaveAs.Size = New System.Drawing.Size(78, 51)
        Me.cmdSaveAs.TabIndex = 27
        Me.cmdSaveAs.Text = "Save As"
        Me.cmdSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSaveAs.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.DPSReporting.My.Resources.Resources.printer
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(89, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 51)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Print"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Image = Global.DPSReporting.My.Resources.Resources.db_remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(173, 448)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(78, 51)
        Me.cmdDelete.TabIndex = 25
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Image = Global.DPSReporting.My.Resources.Resources.Log_Off
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(763, 510)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(78, 51)
        Me.cmdClose.TabIndex = 23
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmCardSetupMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(886, 569)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdSaveAs)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.MaximizeBox = False
        Me.Name = "frmCardSetupMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Card Setup Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDefinition As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCardSetupName As System.Windows.Forms.TextBox
    Friend WithEvents txtEncodeMIC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdSaveAs As System.Windows.Forms.Button
    Friend WithEvents lblCardSetupID As System.Windows.Forms.Label
    Friend WithEvents cmdDetails As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbDSetupName As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbFormType As System.Windows.Forms.ComboBox
    Friend WithEvents cbMailerIndFldId As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCardNoFldId As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOCRMIC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEndRecSeparator As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMailerMIC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSMCMIC As System.Windows.Forms.TextBox
End Class
