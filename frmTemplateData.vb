Public Class frmTemplateData
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lvField As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemplateData))
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lvField = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 32
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 23)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Please select ONE Card Setup template from the list below."
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(224, 164)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(138, 164)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 63
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
        Me.lvField.Location = New System.Drawing.Point(24, 38)
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(384, 107)
        Me.lvField.TabIndex = 62
        Me.lvField.UseCompatibleStateImageBehavior = False
        Me.lvField.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 331
        '
        'frmTemplateData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(427, 196)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lvField)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTemplateData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Template- Card Setup"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTemplateData_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        LoadAllField()
    End Sub

    Private Sub LoadAllField()
        Try
            'Retrieve format field tie to the job_id
            Dim szName As String

            Dim myconn As New oledb.oledbConnection(gszConnString)
            Dim myCmd As New oledb.oledbCommand
            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            myCmd.Connection = myconn

            myCmd.CommandText = "SELECT distinct(element_group) FROM TemplateSegmentList Order by element_group ASC"
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            Dim dwCount As Integer = 1

            While datareader.Read()
                szName = IIf(IsDBNull(datareader("element_group")), "", datareader("element_group"))

                Dim lvItem As New ListViewItem(CStr(dwCount))
                lvItem.SubItems.Add(szName)

                lvField.Items.Add(lvItem)
                dwCount += 1
            End While

            datareader.Close()
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmTemplateData_LoadAllField: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim dwIndex As Integer
            dwIndex = CInt(lvField.SelectedIndices.Item(0).ToString)

            If (dwIndex = -1) Then
                MessageBox.Show("No field selected. Please select a field before proceed.", "Select Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            gszFieldName = lvField.Items(dwIndex).SubItems(1).Text

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("frmTemplateData_btnOK_Click: Exception-" & ex.Message)
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

            gszFieldName = lvField.Items(dwIndex).SubItems(1).Text

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("frmTemplateData_btnOK_Click: Exception-" & ex.Message)
        End Try
    End Sub

End Class
