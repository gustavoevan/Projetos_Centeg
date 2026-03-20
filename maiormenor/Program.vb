Imports System

Module Program
    Sub Main(args As String())
        
        dim valor1 as integer
        dim valor2 as integer

        console.writeline("qual o primeiro valor?")
        valor1 = console.readline

         console.writeline("qual o segundo valor?")
        valor2 = console.readline

        if valor1 > valor2 then
         console.writeline("o maior valor é : " & valor1)
         else
        console.writeline("o maior valor é : " & valor2)
         end if



    End Sub
End Module
