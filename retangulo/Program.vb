Imports System

Module Program
    Sub Main(args As String())
        
        dim base As Double
        dim altura As Double
        dim area As Double

        console.writeline("qual a base do retangulo?")
        base= console.readline()

        console.writeline("qual a altura do retangulo?")
        altura= console.readline()

        area= base * altura

        console.writeline("a area do retangulo é " & area)
    End Sub
End Module
