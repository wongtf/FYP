Public Class frmFormula
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lvField As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAddConst As System.Windows.Forms.Button
    Friend WithEvents btnAddField As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents txtFormula As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvConstant As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormula))
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lvField = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.txtFormula = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAddConst = New System.Windows.Forms.Button
        Me.btnAddField = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbFormat = New System.Windows.Forms.ComboBox
        Me.lvConstant = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Format available:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(514, 358)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 61
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(428, 358)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 60
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lvField
        '
        Me.lvField.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvField.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lvField.FullRowSelect = True
        Me.lvField.GridLines = True
        Me.lvField.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvField.Location = New System.Drawing.Point(19, 64)
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(286, 191)
        Me.lvField.TabIndex = 59
        Me.lvField.UseCompatibleStateImageBehavior = False
        Me.lvField.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 26
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Field Name"
        Me.ColumnHeader2.Width = 235
        '
        'txtFormula
        '
        Me.txtFormula.Location = New System.Drawing.Point(115, 324)
        Me.txtFormula.MaxLength = 50
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.Size = New System.Drawing.Size(482, 21)
        Me.txtFormula.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 23)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Preview Formula"
        '
        'btnAddConst
        '
        Me.btnAddConst.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddConst.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddConst.ForeColor = System.Drawing.Color.White
        Me.btnAddConst.Location = New System.Drawing.Point(314, 268)
        Me.btnAddConst.Name = "btnAddConst"
        Me.btnAddConst.Size = New System.Drawing.Size(83, 23)
        Me.btnAddConst.TabIndex = 67
        Me.btnAddConst.Text = "Add &Constant"
        Me.btnAddConst.UseVisualStyleBackColor = False
        '
        'btnAddField
        '
        Me.btnAddField.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddField.ForeColor = System.Drawing.Color.White
        Me.btnAddField.Location = New System.Drawing.Point(19, 268)
        Me.btnAddField.Name = "btnAddField"
        Me.btnAddField.Size = New System.Drawing.Size(83, 23)
        Me.btnAddField.TabIndex = 66
        Me.btnAddField.Text = "Add &Field"
        Me.btnAddField.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(20, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 3)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'cbFormat
        '
        Me.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormat.Items.AddRange(New Object() {"PLAINTEXT", "DCQSS NATIVE"})
        Me.cbFormat.Location = New System.Drawing.Point(124, 12)
        Me.cbFormat.Name = "cbFormat"
        Me.cbFormat.Size = New System.Drawing.Size(254, 21)
        Me.cbFormat.TabIndex = 69
        '
        'lvConstant
        '
        Me.lvConstant.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvConstant.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lvConstant.FullRowSelect = True
        Me.lvConstant.GridLines = True
        Me.lvConstant.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvConstant.Location = New System.Drawing.Point(314, 64)
        Me.lvConstant.Name = "lvConstant"
        Me.lvConstant.Size = New System.Drawing.Size(286, 191)
        Me.lvConstant.TabIndex = 70
        Me.lvConstant.UseCompatibleStateImageBehavior = False
        Me.lvConstant.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "#"
        Me.ColumnHeader3.Width = 26
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Constant Name"
        Me.ColumnHeader4.Width = 235
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(312, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 23)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "These fields constant field available for use."
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 23)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "These format fields available for use."
        '
        'frmFormula
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(618, 395)
        Me.Controls.Add(Me.lvConstant)
        Me.Controls.Add(Me.cbFormat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddConst)
        Me.Controls.Add(Me.btnAddField)
        Me.Controls.Add(Me.txtFormula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lvField)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFormula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Formula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFormula_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        LoadAllConst()
        LoadAllFormat()

        If (cbFormat.Items.Count > 0) Then
            cbFormat.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadAllConst()

        Try
            Dim dwCount As Integer
            Dim dwIndex As Integer

            dwCount = UBound(arOpList)

            lvConstant.Items.Clear()

            For dwIndex = 1 To dwCount
                Dim lvItem As New ListViewItem(CStr(dwIndex))
                lvItem.SubItems.Add(arOpList(dwIndex))

                lvConstant.Items.Add(lvItem)
            Next dwIndex

        Catch ex As Exception
            MessageBox.Show("frmFormula_LoadAllConst: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllFormat()

        Try
            Dim szSQL As String
            szSQL = "SELECT fs_id, fs_name FROM FormatSetup WHERE fs_bank_id=" & UserInfo.BankId & " AND fs_deleted=0 ORDER BY fs_name ASC"

            LoadTableCombo(cbFormat, szSQL)

        Catch ex As Exception
            MessageBox.Show("frmFormula_LoadAllFormat: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadAllField()
        Try
            'Retrieve format field tie to the job_id
            Dim szName As String
            Dim szDesc As String
            Dim lngFormatSetup As Long

            lngFormatSetup = FindComboId(cbFormat, cbFormat.SelectedIndex)    'fs_id

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            myCmd.Connection = myconn

            myCmd.CommandText = "SELECT fmt_field_name, fmt_field_desc, fmt_field_seq FROM Format WHERE fs_id=" & CStr(lngFormatSetup) & " Order by fmt_field_seq ASC"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            Dim dwCount As Integer = 1

            While datareader.Read()
                szName = IIf(IsDBNull(datareader("fmt_field_name")), "", datareader("fmt_field_name"))
                szDesc = IIf(IsDBNull(datareader("fmt_field_desc")), "", datareader("fmt_field_desc"))

                Dim lvItem As New ListViewItem(CStr(dwCount))
                lvItem.SubItems.Add(szName)

                lvField.Items.Add(lvItem)
                dwCount += 1
            End While

            datareader.Close()
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmFormula_LoadAllField: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub cbFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormat.SelectedIndexChanged
        LoadAllField()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            gszFieldName = txtFormula.Text

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("frmSelectField_btnOK_Click: Exception-" & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub lvField_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvField.DoubleClick
        Try
            Dim dwIndex As Integer
            dwIndex = CInt(lvField.SelectedIndices.Item(0).ToString)

            If (dwIndex = -1) Then
                MessageBox.Show("No field selected. Please select a field before proceed.", "Select Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If (Trim(txtFormula.Text) = "") Then
                txtFormula.Text = lvField.Items(dwIndex).SubItems(1).Text
            Else
                txtFormula.Text += "+" & lvField.Items(dwIndex).SubItems(1).Text
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddField.Click
        Try
            Dim dwIndex As Integer
            dwIndex = CInt(lvField.SelectedIndices.Item(0).ToString)

            If (dwIndex = -1) Then
                MessageBox.Show("No field selected. Please select a field before proceed.", "Select Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If (Trim(txtFormula.Text) = "") Then
                txtFormula.Text = lvField.Items(dwIndex).SubItems(1).Text
            Else
                txtFormula.Text += "+" & lvField.Items(dwIndex).SubItems(1).Text
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddConst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddConst.Click
        Try
            Dim dwIndex As Integer
            dwIndex = CInt(lvConstant.SelectedIndices.Item(0).ToString)

            If (dwIndex = -1) Then
                MessageBox.Show("No constant field selected. Please select a constant field before proceed.", "Select Constant Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If (Trim(txtFormula.Text) = "") Then
                txtFormula.Text = lvConstant.Items(dwIndex).SubItems(1).Text
            Else
                txtFormula.Text += "+" & lvConstant.Items(dwIndex).SubItems(1).Text
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lvConstant_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvConstant.DoubleClick
        Try
            Dim dwIndex As Integer
            dwIndex = CInt(lvConstant.SelectedIndices.Item(0).ToString)

            If (dwIndex = -1) Then
                MessageBox.Show("No constant field selected. Please select a constant field before proceed.", "Select Constant Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If (Trim(txtFormula.Text) = "") Then
                txtFormula.Text = lvConstant.Items(dwIndex).SubItems(1).Text
            Else
                txtFormula.Text += "+" & lvConstant.Items(dwIndex).SubItems(1).Text
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class
