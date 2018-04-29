Imports System

Module Program
    Sub Main(args As String())
        For index = 1 To 100
            Dim output As String = String.Empty

            If index Mod 15 = 0 Then
                output = "FizzBuzz"
            ElseIf index Mod 3 = 0 Then
                output = "Fizz"
            ElseIf index Mod 5 = 0 Then
                output = "Buzz"
            Else
                output = CType(index, String)
            End If

            Console.WriteLine(output)
        Next
    End Sub
End Module
