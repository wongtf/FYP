Module oledbMod

    'Constant Declaration
    Private Const oledb_ADD_DSN As Integer = 1        ' Add data source
    Private Const oledb_CONFIG_DSN As Integer = 2     ' Configure (edit) data source
    Private Const oledb_REMOVE_DSN As Integer = 3     ' Remove data source

    Private Declare Function SQLConfigDataSource Lib "oledbCP32.DLL" (ByVal hwndParent As Integer, ByVal fRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer

    Public Function CreateDSN(ByVal szDSNname As String, ByVal szServer As String, ByVal szDatabase As String, ByVal szUID As String, ByVal szPWD As String) As Boolean
        Try
            CreateDSN = False

            Dim intRet As Integer
            Dim szDriver As String
            Dim szAttributes As String

            ''Set the driver to SQL Server because it is most common.
            'szDriver = "Microsoft Access Driver (*.mdb)"
            'szAttributes = "Description=XMLc database connection" & Chr(0) & _
            '                "DSN=" & szDSNname & Chr(0) & _
            '                "dbq=" & szDatabase & Chr(0) & _
            '                "UID=" & szUID & Chr(0) & _
            '                "PWD=" & szPWD & Chr(0) & _
            '                "Server=Microsoft Access Driver (*.mdb)"

            szDriver = "SQL Server"
            szAttributes = "Description=Delivery Report database connection" & Chr(0) & _
                           "DSN=" & szDSNname & Chr(0) & _
                           "SERVER=" & szServer & Chr(0) & _
                           "DATABASE=" & szDatabase & Chr(0)

            intRet = SQLConfigDataSource(0, oledb_ADD_DSN, szDriver, szAttributes)
            If intRet Then
                CreateDSN = True
            End If

        Catch ex As Exception
            MessageBox.Show("obdc_CreateDSN: Exception-" & ex.Message)
        End Try
    End Function

    Public Function DeleteDSN(ByVal szDSNname As String) As Boolean
        Try
            DeleteDSN = False

            Dim intRet As Integer
            Dim szDriver As String
            Dim szAttributes As String

            'Set the driver to SQL Server because most common.
            szDriver = "Microsoft Access Driver (*.mdb)"

            'Set the attributes delimited by null.
            szAttributes = "DSN=" & szDSNname & Chr(0)

            intRet = SQLConfigDataSource(0, oledb_REMOVE_DSN, szDriver, szAttributes)
            If intRet Then
                DeleteDSN = True
            End If

        Catch ex As Exception
            MessageBox.Show("obdc_DeleteDSN: Exception-" & ex.Message)
        End Try
    End Function

End Module
