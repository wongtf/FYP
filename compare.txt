Imports System.IO

Module Security

    Declare Function SDelFile Lib "sDelete.dll" Alias "SDelete" (ByVal sFileName As String) As Boolean

    Public Function WipeFile(ByVal szFile As String) As Boolean
        Try
            If IsFileExist(szFile) = True Then
                File.Delete(szFile)
            End If
            Return True
        Catch ex As Exception
        End Try

    End Function

    Public Function DecryptFile(ByVal szInputFile As String, ByVal szOutputFile As String) As Boolean
        Dim szDecryptBatchFile As String = ""
        Dim szDumpFile As String
        Dim szFileName As String
        Dim szErrorFileName As String

        Try
            szFileName = Path.GetFileName(szInputFile)
            szErrorFileName = BankInfo.Folder_Error & szFileName

            If Strings.Right(szFileName, 4) = EXT_ENC Then
                szDecryptBatchFile = gszWorkDrive & DECRYPT_BAT_FILE
                szDumpFile = gszWorkDrive & DUMMY_FILE

                Dim objDumpFile As New StreamWriter(szDumpFile, True)
                objDumpFile.WriteLine("Hello")
                objDumpFile.Close()

                If (IsFileExist(szDecryptBatchFile) = True) Then
                    WipeFile(szDecryptBatchFile)
                End If

                Dim objDecryptFile As New StreamWriter(szDecryptBatchFile, True)

                objDecryptFile.WriteLine("java -classpath .;" & BankInfo.Folder_EncService & " Encrypt -c -p 2468 -x -i " & szInputFile & " -o " & szOutputFile)
                objDecryptFile.WriteLine("if exist " & szDumpFile & " del " & szDumpFile)
                objDecryptFile.WriteLine("exit")

                objDecryptFile.Close()
                Shell(szDecryptBatchFile, AppWinStyle.Hide, False)

                'Do While IsFileExist(szDumpFile)
                'Loop
                Do While Dir(szDumpFile) <> ""
                Loop

                If (IsFileExist(szDecryptBatchFile) = True) Then
                    WipeFile(szDecryptBatchFile)
                End If

                If (IsFileExist(szOutputFile) = True) Then
                    Return True
                Else
                    MyMoveFile(szInputFile, szErrorFileName)
                    Return False
                End If

            Else
                MyMoveFile(szInputFile, szErrorFileName)
                Return False
            End If

        Catch ex As Exception
            If (IsFileExist(szDecryptBatchFile) = True) Then
                WipeFile(szDecryptBatchFile)
            End If

            MessageBox.Show("DecryptFile: exception-" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function EncryptFile(ByVal szInputFile As String, ByVal szOutputfile As String) As Boolean
        Dim szEncryptBatchFile As String = ""
        Dim szDumpFile As String

        Try
            szEncryptBatchFile = gszWorkDrive & ENCRYPT_BAT_FILE
            szDumpFile = gszWorkDrive & DUMMY_FILE

            Dim objDumpFile As New StreamWriter(szDumpFile, True)
            objDumpFile.WriteLine("Hello")
            objDumpFile.Close()

            If (IsFileExist(szEncryptBatchFile) = True) Then
                WipeFile(szEncryptBatchFile)
            End If

            Dim objEncryptFile As New StreamWriter(szEncryptBatchFile, True)

            objEncryptFile.WriteLine("java -classpath .;" & BankInfo.Folder_EncService & " Encrypt -c -p 2468 -i " & szInputFile & " -o " & szOutputfile)
            objEncryptFile.WriteLine("if exist " & szDumpFile & " del " & szDumpFile)
            objEncryptFile.WriteLine("exit")

            objEncryptFile.Close()
            Shell(szEncryptBatchFile, AppWinStyle.Hide, False)

            'Do While IsFileExist(szDumpFile)
            'Loop
            Do While Dir(szDumpFile) <> ""
            Loop

            If (IsFileExist(szEncryptBatchFile) = True) Then
                WipeFile(szEncryptBatchFile)
            End If

            System.Threading.Thread.Sleep(1000)

            Return IsFileExist(szOutputfile)

        Catch ex As Exception
            If (IsFileExist(szEncryptBatchFile) = True) Then
                WipeFile(szEncryptBatchFile)
            End If

            MessageBox.Show("EncryptFile: exception-" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function EncryptEMVESFile() As Boolean
        Dim szEncryptBatchFile As String = ""
        Dim szDumpFile As String

        Try
            szEncryptBatchFile = gszWorkDrive & ENCRYPT_EMVES_BAT_FILE
            szDumpFile = gszWorkDrive & DUMMY_FILE

            Dim objDumpFile As New StreamWriter(szDumpFile, True)
            objDumpFile.WriteLine("Hello")
            objDumpFile.Close()

            If (IsFileExist(szEncryptBatchFile) = True) Then
                WipeFile(szEncryptBatchFile)
            End If

            Dim objEncryptFile As New StreamWriter(szEncryptBatchFile, True)

            objEncryptFile.WriteLine("emvesclient -e")
            objEncryptFile.WriteLine("if exist " & szDumpFile & " del " & szDumpFile)
            objEncryptFile.WriteLine("exit")

            objEncryptFile.Close()
            Shell(szEncryptBatchFile, AppWinStyle.Hide, False)

            'Do While IsFileExist(szDumpFile)
            'Loop
            Do While Dir(szDumpFile) <> ""
            Loop

            If (IsFileExist(szEncryptBatchFile) = True) Then
                WipeFile(szEncryptBatchFile)
            End If

            System.Threading.Thread.Sleep(1000)

        Catch ex As Exception
            If (IsFileExist(szEncryptBatchFile) = True) Then
                WipeFile(szEncryptBatchFile)
            End If

            MessageBox.Show("EncryptFile: exception-" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function EncryptString(ByVal szPlainText As String, ByRef szCipherText As String) As Boolean
        Try
            Dim CryptographyFactory As New CryptoFactory
            Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")

            szCipherText = Cryptographer.Encrypt(szPlainText)
            Return True

        Catch ex As Exception
            szCipherText = ""
            Return False
        End Try

    End Function

    Public Function DecryptString(ByVal szCipherText As String, ByRef szPlainText As String) As Boolean
        Try
            Dim CryptographyFactory As New CryptoFactory
            Dim Cryptographer As ICrypto = CryptographyFactory.MakeCryptographer("rijndael")

            szPlainText = Cryptographer.Decrypt(szCipherText)
            Return True

        Catch ex As Exception
            szPlainText = ""
            Return False
        End Try

    End Function

End Module
