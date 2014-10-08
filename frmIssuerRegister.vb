Imports System.IO

Public Class frmIssuerRegister

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.InitialDirectory = BankInfo.Folder_Input
            OpenFileDialog1.Multiselect = False
            OpenFileDialog1.DefaultExt = "*"
            OpenFileDialog1.Filter = "All files (*.*)|*.*"
            OpenFileDialog1.ShowDialog()

            Dim szFile As String
            szFile = OpenFileDialog1.FileName
            If (szFile <> "") Then
                txtFile.Text = OpenFileDialog1.FileName
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub ExtractDetail(ByVal szFile As String)
        'Load file content into DataContents variables
        Dim dwFileNum As Integer
        Dim dwFileNum1 As Integer
        Dim dwIndex As Long
        Dim dwStart As Long = 1
        Dim dwRecordNo As Long = 0
        Dim szTempString As String
        Dim szTempString1 As String
        Dim DataContents As String
        Dim szStartString As String
        Dim szStartString1 As String
        Dim szStartString2 As String
        Dim szEndString As String
        Dim szEndString1 As String
        Dim boolPrint As Boolean = False

        szStartString = "ISSUE REGISTER ON CARDS TO BE EMBOSSED"
        szStartString1 = "HAND COLLECTION REPORT"
        szStartString2 = "COURIER REPORT"
        szEndString = "**** END OF REPORT ****"
        szEndString1 = "SUMMARY REPORT FOR ISSUE REGISTER"
        Dim szOutput As String = Path.GetFileName(szFile)

        ''open the input file for processing
        dwFileNum = FreeFile()

        FileOpen(dwFileNum, szFile, OpenMode.Binary, OpenAccess.Read)
        DataContents = Space$(LOF(dwFileNum))
        FileGet(dwFileNum, DataContents)
        FileClose(dwFileNum)

        ''open the output file for processing
        dwFileNum1 = FreeFile()
        FileOpen(dwFileNum1, BankInfo.Folder_Ready & "IRd_" & szOutput, OpenMode.Output)

        dwIndex = InStr(dwStart, DataContents, vbCrLf, CompareMethod.Text)
        Do While dwIndex > 0
            dwRecordNo += 1

            lbRecNo.Text = "Current Record: " & CStr(dwRecordNo)
            lbRecNo.Refresh()
            Application.DoEvents()

            ''set the next record position
            szTempString = Mid(DataContents, dwStart, dwIndex - dwStart)

            If (Trim(szTempString) = "") Then
                GoTo next_record
            Else
                If (InStr(1, szTempString, szStartString, CompareMethod.Text) > 0) Then
                    dwStart = dwIndex + 2
                    szTempString1 = szTempString

                    dwIndex = InStr(dwStart, DataContents, vbCrLf, CompareMethod.Text)
                    szTempString = Mid(DataContents, dwStart, dwIndex - dwStart)

                    If (InStr(1, szTempString, szStartString1, CompareMethod.Text) > 0) Or (InStr(1, szTempString, szStartString2, CompareMethod.Text) > 0) Then
                        Print(dwFileNum1, szTempString1 & vbCrLf)
                        boolPrint = True
                    End If
                End If

                If (InStr(1, szTempString, szEndString, CompareMethod.Text) > 0) Then
                    If (boolPrint = True) Then
                        Print(dwFileNum1, szEndString & vbCrLf)
                    End If
                    boolPrint = False
                End If

                If (InStr(1, szTempString, szEndString1, CompareMethod.Text) > 0) Then
                    If (boolPrint = True) Then
                        Print(dwFileNum1, szEndString1 & vbCrLf)
                    End If
                    boolPrint = False
                End If

                If (boolPrint = True) Then
                    Print(dwFileNum1, szTempString & vbCrLf)
                End If
                End If

next_record:
                dwStart = dwIndex + 2
                dwIndex = InStr(dwStart, DataContents, vbCrLf, CompareMethod.Text)
        Loop
        FileClose(dwFileNum1)

    End Sub

    Private Sub ExtractSummary(ByVal szFile As String)
        'Load file content into DataContents variables
        Dim dwFileNum As Integer
        Dim dwFileNum1 As Integer
        Dim dwIndex As Long
        Dim dwStart As Long = 1
        Dim dwRecordNo As Long = 0
        Dim szTempString As String
        Dim DataContents As String
        Dim szStartString As String
        Dim szEndString As String
        Dim boolPrint As Boolean = False

        szStartString = "SUMMARY REPORT FOR ISSUE REGISTER"
        szEndString = "**** END OF REPORT ****"

        Dim szOutput As String = Path.GetFileName(szFile)

        ''open the input file for processing
        dwFileNum = FreeFile()

        FileOpen(dwFileNum, szFile, OpenMode.Binary, OpenAccess.Read)
        DataContents = Space$(LOF(dwFileNum))
        FileGet(dwFileNum, DataContents)
        FileClose(dwFileNum)

        ''open the output file for processing
        dwFileNum1 = FreeFile()
        FileOpen(dwFileNum1, BankInfo.Folder_Ready & "IRs_" & szOutput, OpenMode.Append)

        dwIndex = InStr(dwStart, DataContents, vbCrLf, CompareMethod.Text)
        Do While dwIndex > 0
            dwRecordNo += 1

            lbRecNo.Text = "Current Record: " & CStr(dwRecordNo)
            lbRecNo.Refresh()
            Application.DoEvents()

            ''set the next record position
            szTempString = Mid(DataContents, dwStart, dwIndex - dwStart)

            If (Trim(szTempString) = "") Then
                GoTo next_record
            Else
                If (InStr(1, szTempString, szStartString, CompareMethod.Text) > 0) Then
                    boolPrint = True
                End If
            End If

            If (InStr(1, szTempString, szEndString, CompareMethod.Text) > 0) Then
                Print(dwFileNum1, vbCrLf)
                boolPrint = False
            End If

            If (boolPrint = True) Then
                Print(dwFileNum1, szTempString & vbCrLf)
            End If

next_record:
            dwStart = dwIndex + 2
            dwIndex = InStr(dwStart, DataContents, vbCrLf, CompareMethod.Text)
        Loop
        FileClose(dwFileNum1)

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            lbRecNo.Visible = True
            Dim szOutput As String = Path.GetFileName(txtFile.Text)

            If (optDetail.Checked = True) Then
                ExtractDetail(txtFile.Text)

                MessageBox.Show("Issuer Register - Detail Report has been generated at [" & BankInfo.Folder_Ready & "] folder.", "Issuer Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
                szOutput = BankInfo.Folder_Ready & "IRd_" & szOutput
            Else
                ExtractSummary(txtFile.Text)
                MessageBox.Show("Issuer Register - Summary Report has been generated at [" & BankInfo.Folder_Ready & "] folder.", "Issuer Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
                szOutput = BankInfo.Folder_Ready & "IRs_" & szOutput
            End If

            Dim MyProcess As New Process
            MyProcess.StartInfo.FileName = Environment.GetEnvironmentVariable("windir") & "\notepad.exe"
            MyProcess.StartInfo.Arguments = szOutput
            MyProcess.Start()
            'MyProcess.WaitForExit()

        Finally
            lbRecNo.Visible = False
        End Try
    End Sub

End Class