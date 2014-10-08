Imports System.IO

Public Class frmSelectReport
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
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lvField As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lvField = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "File name"
        Me.ColumnHeader2.Width = 199
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 32
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 23)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Please select report file."
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(276, 68)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 67
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(276, 38)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 23)
        Me.btnOK.TabIndex = 66
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
        Me.lvField.Location = New System.Drawing.Point(16, 38)
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(235, 247)
        Me.lvField.TabIndex = 65
        Me.lvField.UseCompatibleStateImageBehavior = False
        Me.lvField.View = System.Windows.Forms.View.Details
        '
        'frmSelectReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(381, 315)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lvField)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSelectReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Report File"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmLogo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        LoadAllReport()
    End Sub

    Private Sub LoadAllReport()
        Try
            Dim szFileCollection() As String
            Dim dwIndex As Integer
            Dim dwCount As Integer = 1
            Dim szName As String

            lvField.Items.Clear()

            szFileCollection = Directory.GetFiles(BankInfo.Folder_Report)

            For dwIndex = 0 To UBound(szFileCollection)
                szName = Path.GetFileName(szFileCollection(dwIndex))

                If (LCase(Microsoft.VisualBasic.Right(szName, Len(EXT_RPT))) = EXT_RPT) Then
                    Dim lvItem As New ListViewItem(CStr(dwCount))
                    szName = Mid(szName, 1, Len(szName) - Len(EXT_RPT))
                    lvItem.SubItems.Add(szName)

                    lvField.Items.Add(lvItem)
                    dwCount += 1
                End If
            Next

            If (dwCount > 0) Then
                btnOK.Enabled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim dwIndex As Integer
            dwIndex = CInt(lvField.SelectedIndices.Item(0).ToString)

            If (dwIndex = -1) Then
                MessageBox.Show("No report file selected. Please select a report file before proceed.", "Select Report File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            gszFieldName = lvField.Items(dwIndex).SubItems(1).Text

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("frmSelectReport_btnOK_Click: Exception-" & ex.Message)
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
                MessageBox.Show("No report file selected. Please select a report file before proceed.", "Select Report File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            gszFieldName = lvField.Items(dwIndex).SubItems(1).Text

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("frmSelectReport_btnOK_Click: Exception-" & ex.Message)
        End Try
    End Sub

End Class
