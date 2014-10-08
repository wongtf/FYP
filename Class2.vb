Public Interface ICrypto
    Function BlockSize() As Integer
    Function KeySize() As Integer
    Function Encrypt(ByVal data As String) As String
    Function Decrypt(ByVal data As String) As String
End Interface

Public Class CryptoFactory
    Public Function MakeCryptographer(ByVal type As String) As ICrypto
        Select Case type.ToLower
            Case "rijndael"
                Return New Rijndael
            Case Else
                Return New Rijndael
        End Select
    End Function
End Class