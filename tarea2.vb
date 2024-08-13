Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())
        Dim R As Single
        Dim L As Single
        Dim C As Single
        Dim XL As Single
        Dim XC As Single
        Dim F As Single
        Dim XT As Single
        Dim FR As Single
        Dim PI As Single
        Dim Z As Single
        PI = 3.1415
        Console.Write("de su valor de R: ")
        R = Console.ReadLine()
        Console.Write("de su valor de L: ")
        L = Console.ReadLine()
        Console.Write("de su valor de C: ")
        C = Console.ReadLine()
        Console.Write("de su valor de F: ")
        F = Console.ReadLine()
        XC = 1 / (2 * PI * C * F)
        XL = 2 * PI * L * F
        Console.WriteLine("Su valor de XL= " & XL)
        Console.WriteLine("Su valor de XC= " & XC)
        XT = Math.Sqrt((R ^ 2 + (XL - XC) ^ 2))
        Z = Math.Atan(R / (XL - XC)) * ((1 * 180) / PI)
        Console.WriteLine("su valor de XT es de: " & XT)
        Console.WriteLine("Con un angulo de:" & Z)
        FR = 1 / (2 * PI * Math.Sqrt(L * C))
        Console.WriteLine("su valor de FR es de: " & FR)
    End Sub
End Module
