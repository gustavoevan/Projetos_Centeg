Imports System

Module Program
    Sub Main(args As String())
        
        'programa para converter de MB para GB

        dim MB as double
        dim GB as double

        console.writeline("qual o valor em mb?")
        MB = console.readline()

        GB = MB / 1024

        console.writeline("O valor em GB é: " & GB)

    End Sub
End Module
