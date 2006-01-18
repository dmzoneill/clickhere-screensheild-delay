Imports System.IO
Imports System.Text
Imports System.Net.Sockets
Imports System.Threading

Module Module1

    Sub Main()

        Dim g As Integer

        For g = 1 To 15
            Threading.Thread.Sleep(1000)
            System.Console.Write(g)
        Next

        Dim myProcess As Process = New Process()
        Dim s As String

        myProcess.StartInfo.FileName = "C:\Program Files\ScreenShield\ScreenShield.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = ""
        myProcess.StartInfo.RedirectStandardInput = False
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.StartInfo.RedirectStandardError = False
        myProcess.Start()
        
      
    End Sub

End Module
