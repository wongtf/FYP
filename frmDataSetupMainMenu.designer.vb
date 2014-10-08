<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataSetupMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataSetupMainMenu))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtFldChkValue = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtFldChkID = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtFIRRef = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblDataSetupID = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFileTrailerSize = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFileHeaderSize = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDefinition = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDataSetupName = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRecordSeparator = New System.Windows.Forms.TextBox
        Me.txtRecordLength = New System.Windows.Forms.TextBox
        Me.rbRecordSep1 = New System.Windows.Forms.RadioButton
        Me.rbRecordSep0 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdDetailsDef = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmdDetailsDef)
        Me.Panel1.Controls.Add(Me.cmdClear)
        Me.Panel1.Controls.Add(Me.cmdEdit)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Location = New System.Drawing.Point(257, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 472)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtFldChkValue)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtFldChkID)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtFIRRef)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblDataSetupID)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtFileTrailerSize)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtFileHeaderSize)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtDefinition)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtDataSetupName)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(44, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 376)
        Me.Panel2.TabIndex = 28
        '
        'txtFldChkValue
        '
        Me.txtFldChkValue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFldChkValue.Location = New System.Drawing.Point(156, 326)
        Me.txtFldChkValue.MaxLength = 50
        Me.txtFldChkValue.Name = "txtFldChkValue"
        Me.txtFldChkValue.Size = New System.Drawing.Size(275, 21)
        Me.txtFldChkValue.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Data FldChk Value"
        '
        'txtFldChkID
        '
        Me.txtFldChkID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFldChkID.Location = New System.Drawing.Point(156, 297)
        Me.txtFldChkID.MaxLength = 50
        Me.txtFldChkID.Name = "txtFldChkID"
        Me.txtFldChkID.Size = New System.Drawing.Size(275, 21)
        Me.txtFldChkID.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Data FldChk ID"
        '
        'txtFIRRef
        '
        Me.txtFIRRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFIRRef.Location = New System.Drawing.Point(156, 268)
        Me.txtFIRRef.MaxLength = 50
        Me.txtFIRRef.Name = "txtFIRRef"
        Me.txtFIRRef.Size = New System.Drawing.Size(275, 21)
        Me.txtFIRRef.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "FIR Reference"
        '
        'lblDataSetupID
        '
        Me.lblDataSetupID.AutoSize = True
        Me.lblDataSetupID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataSetupID.Location = New System.Drawing.Point(4, 0)
        Me.lblDataSetupID.Name = "lblDataSetupID"
        Me.lblDataSetupID.Size = New System.Drawing.Size(0, 13)
        Me.lblDataSetupID.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(157, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Maximum not more than 50 char"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFileTrailerSize
        '
        Me.txtFileTrailerSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileTrailerSize.Location = New System.Drawing.Point(156, 239)
        Me.txtFileTrailerSize.MaxLength = 50
        Me.txtFileTrailerSize.Name = "txtFileTrailerSize"
        Me.txtFileTrailerSize.Size = New System.Drawing.Size(275, 21)
        Me.txtFileTrailerSize.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "File Trailer Size"
        '
        'txtFileHeaderSize
        '
        Me.txtFileHeaderSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileHeaderSize.Location = New System.Drawing.Point(156, 210)
        Me.txtFileHeaderSize.MaxLength = 50
        Me.txtFileHeaderSize.Name = "txtFileHeaderSize"
        Me.txtFileHeaderSize.Size = New System.Drawing.Size(275, 21)
        Me.txtFileHeaderSize.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "File Header Size"
        '
        'txtDefinition
        '
        Me.txtDefinition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefinition.Location = New System.Drawing.Point(156, 56)
        Me.txtDefinition.MaxLength = 50
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.Size = New System.Drawing.Size(275, 21)
        Me.txtDefinition.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Definition"
        '
        'txtDataSetupName
        '
        Me.txtDataSetupName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataSetupName.Location = New System.Drawing.Point(156, 13)
        Me.txtDataSetupName.MaxLength = 50
        Me.txtDataSetupName.Name = "txtDataSetupName"
        Me.txtDataSetupName.Size = New System.Drawing.Size(275, 21)
        Me.txtDataSetupName.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtRecordSeparator)
        Me.GroupBox2.Controls.Add(Me.txtRecordLength)
        Me.GroupBox2.Controls.Add(Me.rbRecordSep1)
        Me.GroupBox2.Controls.Add(Me.rbRecordSep0)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 116)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record Separator Definition"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(136, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(294, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Specify the separator in Hex Value such as 0D0A0D"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(136, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(298, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Record Length in the raw data file, including CR + LF"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtRecordSeparator
        '
        Me.txtRecordSeparator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecordSeparator.Location = New System.Drawing.Point(136, 65)
        Me.txtRecordSeparator.Name = "txtRecordSeparator"
        Me.txtRecordSeparator.Size = New System.Drawing.Size(275, 21)
        Me.txtRecordSeparator.TabIndex = 12
        '
        'txtRecordLength
        '
        Me.txtRecordLength.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecordLength.Location = New System.Drawing.Point(136, 20)
        Me.txtRecordLength.Name = "txtRecordLength"
        Me.txtRecordLength.Size = New System.Drawing.Size(275, 21)
        Me.txtRecordLength.TabIndex = 11
        '
        'rbRecordSep1
        '
        Me.rbRecordSep1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.rbRecordSep1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbRecordSep1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecordSep1.ForeColor = System.Drawing.Color.Black
        Me.rbRecordSep1.Location = New System.Drawing.Point(6, 64)
        Me.rbRecordSep1.Name = "rbRecordSep1"
        Me.rbRecordSep1.Size = New System.Drawing.Size(124, 21)
        Me.rbRecordSep1.TabIndex = 10
        Me.rbRecordSep1.Text = "Record Separator"
        Me.rbRecordSep1.UseVisualStyleBackColor = False
        '
        'rbRecordSep0
        '
        Me.rbRecordSep0.BackColor = System.Drawing.Color.LightSteelBlue
        Me.rbRecordSep0.Checked = True
        Me.rbRecordSep0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbRecordSep0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecordSep0.ForeColor = System.Drawing.Color.Black
        Me.rbRecordSep0.Location = New System.Drawing.Point(6, 20)
        Me.rbRecordSep0.Name = "rbRecordSep0"
        Me.rbRecordSep0.Size = New System.Drawing.Size(118, 21)
        Me.rbRecordSep0.TabIndex = 9
        Me.rbRecordSep0.TabStop = True
        Me.rbRecordSep0.Text = "Record Length"
        Me.rbRecordSep0.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Setup Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(41, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 14)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Data Setup Information"
        '
        'cmdDetailsDef
        '
        Me.cmdDetailsDef.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDetailsDef.Image = CType(resources.GetObject("cmdDetailsDef.Image"), System.Drawing.Image)
        Me.cmdDetailsDef.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDetailsDef.Location = New System.Drawing.Point(500, 414)
        Me.cmdDetailsDef.Name = "cmdDetailsDef"
        Me.cmdDetailsDef.Size = New System.Drawing.Size(115, 51)
        Me.cmdDetailsDef.TabIndex = 26
        Me.cmdDetailsDef.Text = "Details Definition >>>"
        Me.cmdDetailsDef.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDetailsDef.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = Global.DPSReporting.My.Resources.Resources.import
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(5, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 51)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Save As"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(351, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Data Setup Main Menu - Defined the Data File Layout"
        '
        'frmDataSetupMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 569)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.MaximizeBox = False
        Me.Name = "frmDataSetupMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Setup Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdDetailsDef As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblDataSetupID As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFileTrailerSize As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFileHeaderSize As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDefinition As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataSetupName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRecordSeparator As System.Windows.Forms.TextBox
    Friend WithEvents txtRecordLength As System.Windows.Forms.TextBox
    Friend WithEvents rbRecordSep1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbRecordSep0 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFldChkValue As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFldChkID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFIRRef As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
