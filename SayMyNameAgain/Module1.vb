'Jamison Burton
'RCET0265
'Spring 2022
'Say My Name...Again
'https://github.com/Reimonoe17/SayMyNameAgain

Option Compare Text
Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Dim name As String

        Console.WriteLine("Please enter your name: ")
        name = Console.ReadLine()

        If name = "Emily" Then
            Console.WriteLine("Hello Emily, how are you today?")
        ElseIf name = "Joe" Then
            Console.WriteLine("Let's go Brandon!")
        ElseIf name = "Jamison" Then
            Console.WriteLine("Hello, you handsome devil you!")
        Else
            Console.WriteLine("Hello " & name & ", do you like this program so far?")
        End If

        Console.ReadLine()
    End Sub

End Module
