Imports System.Data
Imports System.IO
Imports System.Xml

Public Class frmSearch
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbCount As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlFile As System.Windows.Forms.GroupBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtvalue As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvField As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbCount = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lvField = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlFile = New System.Windows.Forms.GroupBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtvalue = New System.Windows.Forms.TextBox
        Me.cbType = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(377, 473)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbCount
        '
        Me.lbCount.BackColor = System.Drawing.Color.Transparent
        Me.lbCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCount.ForeColor = System.Drawing.Color.Black
        Me.lbCount.Location = New System.Drawing.Point(33, 83)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(179, 16)
        Me.lbCount.TabIndex = 10
        Me.lbCount.Text = "Record found:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(32, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(312, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Search record information:"
        '
        'lvField
        '
        Me.lvField.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvField.HideSelection = False
        Me.lvField.Location = New System.Drawing.Point(36, 102)
        Me.lvField.MultiSelect = False
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(749, 366)
        Me.lvField.TabIndex = 0
        Me.lvField.UseCompatibleStateImageBehavior = False
        Me.lvField.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 31
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Batch_id"
        Me.ColumnHeader2.Width = 179
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "File_date"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Card_id"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Element_value"
        Me.ColumnHeader5.Width = 270
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "CDSNo for Suppl"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "MailerPrint"
        Me.ColumnHeader7.Width = 100
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnlFile
        '
        Me.pnlFile.Controls.Add(Me.btnClear)
        Me.pnlFile.Controls.Add(Me.txtvalue)
        Me.pnlFile.Controls.Add(Me.cbType)
        Me.pnlFile.Controls.Add(Me.btnSearch)
        Me.pnlFile.Controls.Add(Me.Label8)
        Me.pnlFile.Controls.Add(Me.Label1)
        Me.pnlFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.pnlFile.Location = New System.Drawing.Point(35, 30)
        Me.pnlFile.Name = "pnlFile"
        Me.pnlFile.Size = New System.Drawing.Size(749, 46)
        Me.pnlFile.TabIndex = 67
        Me.pnlFile.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(654, 14)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear List"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtvalue
        '
        Me.txtvalue.Location = New System.Drawing.Point(284, 16)
        Me.txtvalue.Name = "txtvalue"
        Me.txtvalue.Size = New System.Drawing.Size(275, 21)
        Me.txtvalue.TabIndex = 1
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Location = New System.Drawing.Point(140, 16)
        Me.cbType.MaxDropDownItems = 50
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(138, 21)
        Me.cbType.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(565, 14)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(83, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(115, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = " :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Search criteria"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "AWBNO"
        Me.ColumnHeader8.Width = 100
        '
        'frmSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(821, 508)
        Me.Controls.Add(Me.pnlFile)
        Me.Controls.Add(Me.lvField)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbCount)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Search record"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFile.ResumeLayout(False)
        Me.pnlFile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dwIndexOf As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UpdateAuditLog("Search record", "Audit Log")

            cbType.Items.Clear()
            cbType.Items.Add("CARDHOLDER_NAME")
            cbType.Items.Add("CARD_NUMBER")
            cbType.Items.Add("CDS_NUMBER")
            cbType.Items.Add("AWB_NUMBER")
            cbType.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("frmSearch_Load: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub LoadData(ByVal szBatchId As String)

        Try
            If (szBatchId = "") Then
                Exit Sub
            End If

            btnSearch.Enabled = False

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.Refresh()

            Dim szSQL As String = ""
            Dim szPAN As String = ""
            Dim dwCount As Long = 0
            Dim szField1 As String
            Dim szField2 As String
            Dim szField3 As String
            Dim szField4 As String
            Dim szField5 As String
            Dim szField6 As String
            Dim szField7 As String

            szSQL = "EXEC sp_searchdata " & CStr(cbType.SelectedIndex) & ",'" & txtvalue.Text & "'"
            'dwReturnRow = ExecuteSQL(szSQL)

            'Select Case cbType.SelectedIndex
            '    Case 0      '"CARDHOLDER_NAME"
            '        szSQL = "select * from data where data_element_name = 'CARDHOLDERNAME' and (data_group=1 or data_group=2 or data_group=3) and data_element_value like '" & txtvalue.Text & "%'"
            '    Case 1      '"CARD_NUMBER"
            '        szSQL = "select * from data where data_card_id like '" & txtvalue.Text & "%'"
            '    Case 2      '"CDS_NUMBER"
            '        szSQL = "select * from data where data_element_name = 'CDSNO' and data_element_value like '" & txtvalue.Text & "%'"
            '    Case 3      '"AWB_NUMBER"
            '        szSQL = "select * from data where (data_element_name = 'AWBNO' or data_element_name = 'REFNO') and data_element_value like '" & txtvalue.Text & "%'"
            '    Case Else
            '        MessageBox.Show("Please select a search criteria before proceed.", "Delivery Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            'End Select

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand
            'myconn.ConnectionTimeout = 0

            Dim datareader As OleDb.OleDbDataReader = Nothing

            myconn.Open()
            myCmd.Connection = myconn
            myCmd.CommandTimeout = 0

            'Retrieve the record information
            myCmd.CommandText = szSQL
            datareader = myCmd.ExecuteReader()

            lvField.Items.Clear()

            While datareader.Read()
                szField1 = IIf(IsDBNull(datareader("data_filename")), "", datareader("data_filename"))
                szField2 = IIf(IsDBNull(datareader("data_filedate")), "", datareader("data_filedate"))
                'szField3 = IIf(IsDBNull(datareader("data_group")), "", datareader("data_group"))

                'Select Case szField3
                '    Case "0"
                '        szField3 = DATA_GROUP_GENERAL
                '    Case "1"
                '        szField3 = DATA_GROUP_EMBOSS
                '    Case "2"
                '        szField3 = DATA_GROUP_DCAUDIT
                '    Case "3"
                '        szField3 = DATA_GROUP_IREGISTER
                '    Case "4"
                '        szField3 = DATA_GROUP_CN
                'End Select

                szField3 = IIf(IsDBNull(datareader("data_card_id")), "", datareader("data_card_id"))
                szField4 = IIf(IsDBNull(datareader("SearchField")), "", datareader("SearchField"))
                szField5 = IIf(IsDBNull(datareader("SupplCDSNo")), "", datareader("SupplCDSNo"))
                szField6 = IIf(IsDBNull(datareader("MailerInd")), "", datareader("MailerInd"))
                szField7 = IIf(IsDBNull(datareader("AWBNumber")), "", datareader("AWBNumber"))

                Dim lvItem As New ListViewItem(dwCount)

                lvItem.SubItems.Add(szField1)
                lvItem.SubItems.Add(szField2)
                'lvItem.SubItems.Add(szField3)
                lvItem.SubItems.Add(szField3)
                lvItem.SubItems.Add(szField4)
                lvItem.SubItems.Add(szField5)
                lvItem.SubItems.Add(szField6)
                lvItem.SubItems.Add(szField7)

                'lvItem.SubItems.Add(szField6)

                lvField.Items.Add(lvItem)
                dwCount += 1
            End While

            datareader.Close()
            myconn.Close()

            lbCount.Text = "Record found: " & CStr(dwCount - 1)

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("frmScan_LoadData: Exception-" & ex.Message)
        Finally
            cbType.Enabled = True
            btnSearch.Enabled = True
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadData(cbType.SelectedIndex)
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                btnSearch_Click(Me, e)
        End Select
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lvField.Items.Clear()
    End Sub
End Class
