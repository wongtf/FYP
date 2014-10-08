Imports System.Text

Module StringFunctions
    'Retrieves the path part of a full filename
    'C:\Folder\file.exe -> C:\Folder\
    Public Function GetPath(ByVal Full As String) As String
        For i As Integer = Full.Length - 1 To 0 Step -1
            If Full.Substring(i, 1) = "\" OrElse Full.Substring(i, 1) = "/" Then 'Find the rightmost \ or /, which should be cut off the file part
                Return Full.Substring(0, i) & "\"
            End If
        Next
        Return ""
    End Function

    'Retrieves the name of the file from a filename
    'C:\Folder\file.exe - > file 
    'OR
    'file.exe -> file
    Public Function GetName(ByVal Full As String) As String
        Dim Start As Integer = GetPath(Full).Length 'If it's has path it gets how long it only the path is
        Return RemoveExtension(Full.Substring(Start)) 'take of the path and the extension
    End Function

    'Retrieves the extension of the file from a filename
    'C:\Folder\file.exe - > exe 
    'OR
    'file.exe -> exe
    Public Function GetExtension(ByVal Full As String) As String
        Dim Index As Integer
        For i As Integer = Full.Length - 1 To 0 Step -1
            Index = Full.IndexOf(".", i) 'Find the right most . (a different technique than GetPath)
            If Index > -1 Then
                Return Full.Substring(Index)
            End If
        Next
        Return ""
    End Function

    'Removes extension from a filename
    'C:\Folder\file.exe - > C:\Folder\file 
    'OR
    'file.exe -> file
    Public Function RemoveExtension(ByVal Full As String) As String
        Dim Last As Integer = Full.Length - GetExtension(Full).Length
        Return Full.Substring(0, Last)
    End Function

    'Removes path from a filename
    'C:\Folder\file.exe - > file.exe
    Public Function GetFullName(ByVal Full As String) As String
        Return Full.Substring(GetPath(Full).Length) 'Cut off everything up to the path
    End Function

    'Capitalizes a word or sentence
    'word -> Word
    'OR
    'this is a sentence -> This is a sentence
    Public Function Capitalize(ByVal [String] As String) As String
        If [String].Length = 1 Then Return [String].ToUpper 'one letter just return it capitalized
        Return [String].Substring(0, 1).ToUpper & [String].Substring(1) 'cut the first letter and capitalize it and then add the rest
    End Function

    'checks whether a word or sentence is capitalized
    'Word -> True
    'OR
    'This is a sentence -> True
    Public Function IsCapitalized(ByVal [String] As String) As Boolean
        Return AscW([String].Substring(0, 1)) = AscW([String].Substring(0, 1).ToUpper) 'compare the ascii value of the first letter and a capitalized first letter
    End Function

    'checks whether a word or char is in lower case
    'word -> True
    'Word -> False
    Public Function IsLower(ByVal [String] As String) As Boolean
        For i As Integer = 0 To [String].Length - 1
            If Not AscW([String].Substring(i, 1)) = AscW([String].Substring(i, 1).ToLower) Then Return False 'compare the asc values
        Next
        Return True
    End Function

    'checks whether a word or char is in upper case
    'word -> False
    'Word -> False
    'WORD -> True
    Public Function IsUpper(ByVal [String] As String) As Boolean
        For i As Integer = 0 To [String].Length - 1
            If Not AscW([String].Substring(i, 1)) = AscW([String].Substring(i, 1).ToUpper) Then Return False 'compare asc values
        Next
        Return True
    End Function

    'swaps the cases in a word
    'word -> WORD
    'Word -> wORD
    'WoRd -> wOrD
    Public Function SwapCases(ByVal [String] As String) As String
        Dim ret As New StringBuilder 'StringBuilder used to be faster on bigger strings
        For i As Integer = 0 To [String].Length - 1
            If IsUpper([String].Substring(i, 1)) Then 'check whether it's a capital letter or not and make it the opposite
                ret.Append([String].Substring(i, 1).ToLower)
            Else
                ret.Append([String].Substring(i, 1).ToUpper)
            End If
        Next
        Return ret.ToString 'Take of ".ToString" if you prefer it in StringBuilder form (and change the function to StringBuilder also)
    End Function

    'Alternates cases between letters of a string, first letter's case stays the same
    'Hi -> Hi
    'longstring -> lOnGsTrInG
    Public Function AlternateCases(ByVal [String] As String) As String
        If [String].Length = 1 Then Return [String] 'Can't alternate if only one letter
        Dim Upper As Boolean = Not IsUpper([String].Substring(0, 1)) 'start alternation depending on the first letter's case
        Dim ret As New StringBuilder([String].Substring(0, 1))
        For i As Integer = 1 To [String].Length - 1
            If Upper Then
                ret.Append([String].Substring(i, 1).ToUpper)
            Else
                ret.Append([String].Substring(i, 1).ToLower)
            End If
            Upper = Not Upper 'switch to capitalize or not
        Next
        Return ret.ToString
    End Function

    'Checks to see if a string has alternate cases
    'lOnGsTrInG -> True
    Public Function IsAlternateCases(ByVal [String] As String) As Boolean
        If [String].Length = 1 Then Return False 'One letter strings can't be alternate cases
        Dim Upper As Boolean = Not IsUpper([String].Substring(0, 1)) 'Same structure as AlternateCases function, depends on the first letter
        For i As Integer = 1 To [String].Length - 1
            If Upper Then
                If Not IsUpper([String].Substring(i, 1)) Then Return False
            Else
                If IsUpper([String].Substring(i, 1)) Then Return False
            End If
            Upper = Not Upper
        Next
        Return True
    End Function

    'Checks for mixed upper and lower cases
    'string -> False
    'String -> True
    Public Function IsMixedCases(ByVal [String] As String) As Boolean
        Dim upper As Boolean
        For i As Integer = 0 To [String].Length - 1 'look for the first letter and see if it's capitalized or not
            If IsLetters([String].Substring(i, 1)) Then
                upper = IsUpper([String].Substring(i, 1))
            End If
        Next
        If [String].Length = 1 Then Return False
        For i As Integer = 1 To [String].Length - 1
            If IsUpper([String].Substring(i, 1)) <> upper AndAlso _
               IsLetters([String].Substring(i, 1)) Then Return True 'something has a different case, then it's now mixed, ignores numbers and others
        Next
        Return False
    End Function

    'Counts total number of a char or chars in a string
    'hello, l -> 2
    'hello, he -> 1
    Public Function CountTotal(ByVal [String] As String, ByVal [Chars] As String) As Integer
        Dim Count As Integer
        For i As Integer = 0 To [String].Length - 1 Step [Chars].Length
            'The way String.Compare works, "Not CBool" converts it to a traditional True/False
            'Compare is used to compare ignoring capitalization
            If Not i + [Chars].Length > [String].Length AndAlso Not CBool(String.Compare([String].Substring(i, [Chars].Length), [Chars], True)) Then
                Count += 1
            End If
        Next
        Return Count
    End Function

    'Removes vowels from a word
    'remove -> rmv
    Public Function RemoveVowels(ByVal [String] As String) As String
        Dim ret As New StringBuilder
        For i As Integer = 0 To [String].Length - 1
            If Not (Not CBool(String.Compare([String].Substring(i, 1), "a", True)) OrElse Not CBool(String.Compare([String].Substring(i, 1), "e", True)) OrElse _
                    Not CBool(String.Compare([String].Substring(i, 1), "i", True)) OrElse Not CBool(String.Compare([String].Substring(i, 1), "o", True)) OrElse _
                    Not CBool((String.Compare([String].Substring(i, 1), "u", True)))) Then
                'only add to the final string if it doesn't match the vowels
                ret.Append([String].Substring(i, 1))
            End If
        Next
        Return ret.ToString
    End Function

    'Checks to see if a word contains vowels
    'hello -> True
    'rmv -> False
    Public Function HasVowels(ByVal [String] As String) As Boolean
        For i As Integer = 0 To [String].Length - 1
            If (Not CBool(String.Compare([String].Substring(i, 1), "a", True)) OrElse Not CBool(String.Compare([String].Substring(i, 1), "e", True)) OrElse _
                    Not CBool(String.Compare([String].Substring(i, 1), "i", True)) OrElse Not CBool(String.Compare([String].Substring(i, 1), "o", True)) OrElse _
                    Not CBool(String.Compare([String].Substring(i, 1), "u", True))) Then
                'if something equals one of the vowels then it has vowels
                Return True
            End If
        Next
        Return False
    End Function

    'Checks if string is nothing but spaces
    '"        " -> True
    Public Function IsSpaces(ByVal [String] As String) As Boolean
        For i As Integer = 0 To [String].Length - 1
            If Not AscW([String].Substring(i, 1)) = 32 Then '32 is the asc value of a space
                Return False
            End If
        Next
        Return True
    End Function

    'Checks if string has only numbers
    '(Since parameter is String instead of Object, it should be faster)
    '12453 -> True
    '234d3 -> False
    Public Function IsNumeric(ByVal [String] As String) As Boolean
        For i As Integer = 0 To [String].Length - 1
            If Not (AscW([String].Substring(i, 1)) >= 48 AndAlso AscW([String].Substring(i, 1)) <= 57) Then 'asc value range of numbers
                Return False
            End If
        Next
        Return True
    End Function

    'Checks if the string contains numbers
    'hello -> False
    'h3llo -> True
    Public Function HasNumbers(ByVal [String] As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch([String], "\d+")
    End Function

    'Checks if string is numbers and letters
    'Test1254 -> True
    '$chool -> False
    Public Function IsAlphaNumberic(ByVal [String] As String) As Boolean
        For i As Integer = 0 To [String].Length - 1
            If Not (IsNumeric([String].Substring(i, 1)) OrElse _
              (AscW([String].Substring(i, 1)) >= 65 AndAlso AscW([String].Substring(i, 1)) <= 90) OrElse _
              (AscW([String].Substring(i, 1)) >= 97 AndAlso AscW([String].Substring(i, 1)) <= 122)) Then
                'checks asc value range of lower case and upper case letters and check if it's a number, if either fail, then it's not
                'only numbers and letters
                Return False
            End If
        Next
        Return True
    End Function

    'Checks if a string contains only letters
    'Hi -> True
    'Hi123 -> False
    Public Function IsLetters(ByVal [String] As String) As Boolean
        If IsAlphaNumberic([String]) Then 'Only numbers and letters, good
            If Not IsNumeric([String]) Then 'no numbers, good
                Return True
            End If
        End If
        Return False
    End Function

    'Returns the initials of a name or sentence
    'Capitalize - whether to make intials capitals
    'ReturnSeparator - to return intials separated (True - J. S. or False - J.S.)
    'John Smith -> J. S. or J.S.
    Public Function Initials(ByVal [String] As String, ByVal Capitalize As Boolean, ByVal ReturnSeparator As Boolean, Optional ByVal Separator As String = " ") As String
        Dim strs As String() = [String].Split(Separator) 'split all the words
        For i As Integer = 0 To strs.Length - 1
            'Leave only the first letter of everyword and add a . after each
            If Capitalize Then
                strs(i) = strs(i).Substring(0, 1).ToUpper & "."
            Else
                strs(i) = strs(i).Substring(0, 1) & "."
            End If
        Next
        If ReturnSeparator Then
            Return String.Join(Separator, strs)
        Else
            Return String.Join("", strs) 'No separator
        End If
    End Function

    'Capitalizes the first letter of every word
    'the big story -> The Big Story
    Public Function Title(ByVal [String] As String, Optional ByVal Separator As String = " ") As String
        Dim ret As String = ""
        If [String].IndexOf(Separator) > -1 Then
            Dim strs As String() = [String].Split(Separator) 'split all the words so to capitalize the first letter of each
            For i As Integer = 0 To strs.Length - 1
                If strs(i).Length = 1 Then
                    strs(i) = strs(i).ToUpper
                Else
                    strs(i) = strs(i).Substring(0, 1).ToUpper & strs(i).Substring(1)
                End If
            Next
            ret = String.Join(Separator, strs) 'join them back together
        End If
        Return ret
    End Function

    'Checks whether the first letter of each word is capitalized
    'The Big Story -> True
    'The big story -> False
    Public Function IsTitle(ByVal [String] As String, Optional ByVal Separator As String = " ") As Boolean
        If [String].IndexOf(Separator) > -1 Then
            Dim strs As String() = [String].Split(Separator) 'split the words to check the first letter of each word is capitalized
            For i As Integer = 0 To strs.Length - 1
                If Not AscW(strs(i).Substring(0, 1)) = AscW(strs(i).Substring(0, 1).ToUpper) Then Return False
            Next
        End If
        Return True
    End Function

    'Checks if string is a valid emailaddress-format
    'name@place.com -> True
    'hahaimfaking -> False
    '(Function works assuming the last part is no bigger than 3 letters (com, net, org))
    Public Function IsEmailAddress(ByVal [String] As String) As Boolean
        If [String].IndexOf("@") > -1 Then
            For i As Integer = [String].Length - 1 To 0 Step -1
                If [String].Substring(i, 1) = "." Then
                    If [String].Length - i <= 4 Then
                        Return True
                    End If
                End If
            Next
        End If
        Return False
    End Function

    'Returns all the locations of a char in a string
    'Hello, l -> 2, 3
    'Hello, o -> 4
    Public Function IndexesOf(ByVal [String] As String, ByVal [Char] As String) As Integer()
        Dim inx As New ArrayList
        For i As Integer = 0 To [String].Length - 1
            If [String].Substring(i, 1) = [Char] Then inx.Add(i) 'for every location found add it
        Next
        Dim final(inx.Count - 1) As Integer
        inx.CopyTo(final) 'convert the ArrayList to an Integer array
        inx.Clear()
        Return final
    End Function

    'Return a rating for how strong the string is as a password
    'Max rating is 100
    'Credits for original function to D. Rijmenants, this is just a vb.net version
    'If there are problems with copyright or whatever, contact me and i'll delete this
    Public Function PasswordStrength(ByVal [String] As String) As Integer
        Dim Total As Integer
        Dim Uc As Boolean
        Dim Lc As Boolean

        Total = [String].Length * 3
        For i As Integer = 1 To [String].Length - 1
            If AscW([String].Substring(i, 1)) >= 65 AndAlso AscW([String].Substring(i, 1)) <= 92 Then Uc = True 'contains uppercases
        Next
        For i As Integer = 1 To [String].Length - 1
            If AscW([String].Substring(i, 1)) >= 97 And AscW([String].Substring(i, 1)) <= 122 Then Lc = True 'contains lowercases
        Next
        If Uc = True And Lc = True Then Total *= 1.2
        For i As Integer = 1 To [String].Length - 1
            If AscW([String].Substring(i, 1)) >= 48 And AscW([String].Substring(i, 1)) <= 57 Then 'contains numbers
                If Uc = True Or Lc = True Then Total *= 1.4
                Exit For
            End If
        Next
        For i As Integer = 1 To [String].Length - 1
            If AscW([String].Substring(i, 1)) <= 47 Or AscW([String].Substring(i, 1)) >= 123 Or (AscW([String].Substring(i, 1)) >= 58 And AscW([String].Substring(i, 1)) <= 64) Then
                'contains some extra symbols
                Total *= 1.5
                Exit For
            End If
        Next
        If Total > 100 Then Total = 100 'make sure not over 100
        Return Total
    End Function

    'Gets the char in a string at a given position, but from right to left
    'string, 0 -> g
    Public Function CharRight(ByVal [String] As String, ByVal Position As Integer) As Char
        Return [String].Substring([String].Length - Position - 1, 1)
    End Function

    'Gets the char in a string at a given position from the given starting point, reads left to right
    'string, 0, 2 -> r
    Public Function CharMid(ByVal [String] As String, ByVal Position As Integer, ByVal Start As Integer) As Char
        If Not Start + Position > [String].Length Then
            Return [String].Substring(Start + Position, 1)
        Else
            Return ""
        End If
    End Function

    'Inserts a separator after every letter
    'hello, - -> h-e-l-l-o
    Public Function InsertSeparator(ByVal [String] As String, ByVal Separator As String) As String
        Dim final As New StringBuilder
        For i As Integer = 0 To [String].Length - 1
            final.Append([String].Substring(i, 1) & Separator) 'after every letter add the separator
        Next
        Return final.ToString.Substring(0, final.Length - 1) 'Cut out last separator (h-e-l-l-o- -> h-e-l-l-o)
    End Function

    'Inserts a separator after every Count letters
    'hello, -, 2 -> he-ll-o
    Public Function InsertSeparatorEvery(ByVal [String] As String, ByVal Separator As String, ByVal Count As Integer) As String
        Dim final As New StringBuilder
        For i As Integer = 0 To [String].Length - 1 Step Count 'every so steps add the separator
            If Not i + Count > [String].Length Then
                final.Append([String].Substring(i, Count) & Separator)
            Else
                final.Append([String].Substring(i) & Separator)
            End If
        Next
        Return final.ToString.Substring(0, final.Length - 1) 'Cut out last separator
    End Function

    'Inserts a separator at given position
    'hello, -, 3 -> hel-lo
    Public Function InsertSeparatorAt(ByVal [String] As String, ByVal Separator As String, ByVal Position As Integer) As String
        Return [String].Substring(0, Position) & Separator & [String].Substring(Position) 'split the string at that position and add the separator
    End Function

    'Function that works the same way as the default Substring, but
    'it takes Start and End parameters instead of Start and Length
    Public Function Substring(ByVal [String] As String, ByVal Start As Integer, ByVal [End] As Integer) As String
        If Start > [End] Then 'If start is after the end then just flip the values
            Start = Start Xor [End]
            [End] = Start Xor [End]
            Start = Start Xor [End]
        End If
        If [End] > [String].Length Then [End] = [String].Length 'if the end is outside of the string, just make it the end of the string
        Return [String].Substring(Start, [End] - Start)
    End Function

    'Reverses a string
    'Hello -> olleH
    Public Function Reverse(ByVal [String] As String) As String
        Dim final As New StringBuilder
        For i As Integer = [String].Length - 1 To 0 Step -1 'read the string backwards
            final.Append([String].Substring(i, 1))
        Next
        Return final.ToString
    End Function

    'Splits strings, but leaves anything within quotes
    'This is a "very long" string ->
    'This
    'is
    'a
    'very long
    'string
    Public Function MySplit(ByVal [String] As String, Optional ByVal DontAccountQuotes As Boolean = False, Optional ByVal Separator As String = " ") As String()
        If DontAccountQuotes Then
            Return [String].Split(Separator)
        Else
            Dim words As String() = [String].Split(Separator)
            Dim newwords As New ArrayList
            For i As Integer = 0 To words.Length - 1
                If words(i).StartsWith("""") Then
                    Dim linked As New ArrayList
                    For y As Integer = i To words.Length - 1
                        If words(y).EndsWith("""") Then
                            linked.Add(words(y).Substring(0, words(y).Length - 1))
                            i = y
                            Exit For
                        Else
                            If words(y).StartsWith("""") Then words(y) = words(y).Substring(1)
                            linked.Add(words(y))
                        End If
                    Next
                    Dim tmp(linked.Count - 1) As String
                    linked.CopyTo(tmp)
                    If Not linked.Count = 0 Then newwords.Add(String.Join(Separator, tmp))
                    linked.Clear()
                    Erase tmp
                Else
                    newwords.Add(words(i))
                End If
            Next
            Dim tmp2(newwords.Count - 1) As String
            newwords.CopyTo(tmp2)
            newwords.Clear()
            Return tmp2
        End If
    End Function

    Function EBCDIC_To_ASCII_Table() As String
        ' Returns the following table as a string for use by the Translate
        ' function to translate an EBCDIC string to an ASCII-ISO/ANSI string.
        '
        ' 00 01 02 03 9C 09 86 7F 97 8D 8E 0B 0C 0D 0E 0F    ....?.??ç?.....
        ' 10 11 12 13 9D 85 08 87 18 19 92 8F 1C 1D 1E 1F    ....ù?.?..?è....
        ' 80 81 82 83 84 0A 17 1B 88 89 8A 8B 8C 05 06 07    ?Å???...?????...
        ' 90 91 16 93 94 95 96 04 98 99 9A 9B 14 15 9E 1A    ê?.????.????..?.
        ' 20 A0 A1 A2 A3 A4 A5 A6 A7 A8 D5 2E 3C 28 2B 7C    . °¢£§¶ ...<(+|
        ' 26 A9 AA AB AC AD AE AF B0 B1 21 24 2A 29 3B 5E    & ´¨≠ÆØ∞±!$*);^
        ' 2D 2F B2 B3 B4 B5 B6 B7 B8 B9 E5 2C 25 5F 3E 3F    -/≤≥¥µ∂∑∏π.,%_>?
        ' BA BB BC BD BE BF C0 C1 C2 60 3A 23 40 27 3D 22    ∫ªºΩ ø...`:#@'="
        ' C3 61 62 63 64 65 66 67 68 69 C4 C5 C6 C7 C8 C9    .abcdefghi......
        ' CA 6A 6B 6C 6D 6E 6F 70 71 72 CB CC CD CE CF D0    .jklmnopqr......
        ' D1 7E 73 74 75 76 77 78 79 7A D2 D3 D4 5B D6 D7    .~stuvwxyz...[..
        ' D8 D9 DA DB DC DD DE DF E0 E1 E2 E3 E4 5D E6 E7    .............]..
        ' 7B 41 42 43 44 45 46 47 48 49 E8 E9 EA EB EC ED    {ABCDEFGHI......
        ' 7D 4A 4B 4C 4D 4E 4F 50 51 52 EE EF F0 F1 F2 F3    }JKLMNOPQR......
        ' 5C 9F 53 54 55 56 57 58 59 5A F4 F5 F6 F7 F8 F9    \.STUVWXYZ......
        ' 30 31 32 33 34 35 36 37 38 39 FA FB FC FD FE FF    0123456789......
        '
        EBCDIC_To_ASCII_Table = _
           HexToStr("000102039C09867F978D8E0B0C0D0E0F101112139D8508871819928F1C1D1E1F") & _
           HexToStr("80818283840A171B88898A8B8C050607909116939495960498999A9B14159E1A") & _
           HexToStr("20A0A1A2A3A4A5A6A7A8D52E3C282B7C26A9AAABACADAEAFB0B121242A293B5E") & _
           HexToStr("2D2FB2B3B4B5B6B7B8B9E52C255F3E3FBABBBCBDBEBFC0C1C2603A2340273D22") & _
           HexToStr("C3616263646566676869C4C5C6C7C8C9CA6A6B6C6D6E6F707172CBCCCDCECFD0") & _
           HexToStr("D17E737475767778797AD2D3D45BD6D7D8D9DADBDCDDDEDFE0E1E2E3E45DE6E7") & _
           HexToStr("7B414243444546474849E8E9EAEBECED7D4A4B4C4D4E4F505152EEEFF0F1F2F3") & _
           HexToStr("5C9F535455565758595AF4F5F6F7F8F930313233343536373839FAFBFCFDFEFF")
    End Function

    Function ASCII_To_EBCDIC_Table() As String
        '
        ' Returns the following table as a string for use by the Translate
        ' function to translate an EBCDIC string to an ASCII-ISO/ANSI string.
        '
        ' 00 01 02 03 37 2D 2E 2F 16 05 25 0B 0C 0D 0E 0F
        ' 10 11 12 13 3C 3D 32 26 18 19 3F 27 1C 1D 1E 1F
        ' 40 5A 7F 7B 5B 6C 50 7D 4D 5D 5C 4E 6B 60 4B 61
        ' F0 F1 F2 F3 F4 F5 F6 F7 F8 F9 7A 5E 4C 7E 6E 6F
        ' 7C C1 C2 C3 C4 C5 C6 C7 C8 C9 D1 D2 D3 D4 D5 D6
        ' D7 D8 D9 E2 E3 E4 E5 E6 E7 E8 E9 AD E0 BD 5F 6D
        ' 79 81 82 83 84 85 86 87 88 89 91 92 93 94 95 96
        ' 97 98 99 A2 A3 A4 A5 A6 A7 A8 A9 C0 4F D0 A1 07
        ' 20 21 22 23 24 15 06 17 28 29 2A 2B 2C 09 0A 1B
        ' 30 31 1A 33 34 35 36 08 38 39 3A 3B 04 14 3E E1
        ' 41 42 43 44 45 46 47 48 49 51 52 53 54 55 56 57
        ' 58 59 62 63 64 65 66 67 68 69 70 71 72 73 74 75
        ' 76 77 78 80 8A 8B 8C 8D 8E 8F 90 9A 9B 9C 9D 9E
        ' 9F A0 AA AB AC 4A AE AF B0 B1 B2 B3 B4 B5 B6 B7
        ' B8 B9 BA BB BC 6A BE BF CA CB CC CD CE CF DA dB
        ' DC DD DE DF EA EB EC ED EE EF FA FB FC FD FE FF
        '
        ASCII_To_EBCDIC_Table = _
           HexToStr("00010203372D2E2F1605250B0C0D0E0F101112133C3D322618193F271C1D1E1F") & _
           HexToStr("405A7F7B5B6C507D4D5D5C4E6B604B61F0F1F2F3F4F5F6F7F8F97A5E4C7E6E6F") & _
           HexToStr("7CC1C2C3C4C5C6C7C8C9D1D2D3D4D5D6D7D8D9E2E3E4E5E6E7E8E9ADE0BD5F6D") & _
           HexToStr("79818283848586878889919293949596979899A2A3A4A5A6A7A8A9C04FD0A107") & _
           HexToStr("202122232415061728292A2B2C090A1B30311A333435360838393A3B04143EE1") & _
           HexToStr("4142434445464748495152535455565758596263646566676869707172737475") & _
           HexToStr("767778808A8B8C8D8E8F909A9B9C9D9E9FA0AAABAC4AAEAFB0B1B2B3B4B5B6B7") & _
           HexToStr("B8B9BABBBC6ABEBFCACBCCCDCECFDADBDCDDDEDFEAEBECEDEEEFFAFBFCFDFEFF")
    End Function

    Function HexToStr(ByVal HexStr As String) As String
        Dim Temp As String, i As Long
        Temp = Space$(Len(HexStr) \ 2)
        For i = 1 To Len(HexStr) \ 2
            Mid(Temp, i, 1) = Chr(Val("&H" & Microsoft.VisualBasic.Mid(HexStr, i * 2 - 1, 2)))
        Next i
        HexToStr = Temp
    End Function

    Public Function TranslateToEBCDIC(ByVal InText As String) As String
        ' Uses a translation table to map InText from one character set to another.
        Dim xlatTable As String
        xlatTable = ASCII_To_EBCDIC_Table()

        Dim Temp As String, i As Long
        Temp = Space$(Len(InText))
        For i = 1 To Len(InText)
            Mid(Temp, i, 1) = Mid(xlatTable, Asc(Mid(InText, i, 1)) + 1, 1)
        Next i
        TranslateToEBCDIC = Temp
    End Function

    Public Function TranslateToASCII(ByVal InText As String) As String
        ' Uses a translation table to map InText from one character set to another.
        Dim xlatTable As String
        xlatTable = EBCDIC_To_ASCII_Table()

        Dim Temp As String, i As Long
        Temp = Space$(Len(InText))
        For i = 1 To Len(InText)
            Mid(Temp, i, 1) = Mid(xlatTable, Asc(Mid(InText, i, 1)) + 1, 1)
        Next i
        TranslateToASCII = Temp
    End Function

End Module
