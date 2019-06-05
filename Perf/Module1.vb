Imports System.Threading
Module Module1


    Sub Main()

        ' process name, pretty name, executable
        Dim programs(,) = {
            {"throttlestop", "ThrottleStop", "C:\ThrottleStop_8.70.6\ThrottleStop.exe"},
            {"borderlessgaming", "Borderless Gaming", "C:\Program Files (x86)\Borderless Gaming\BorderlessGaming.exe"},
            {"msiafterburner", "MSI Afterburner", "C:\Program Files (x86)\MSI Afterburner\MSIAfterburner.exe"}
        }

        Dim i As Integer
        i = 0

        While i <= programs.GetUpperBound(0)
            Dim running As Boolean
            Dim pretty As String
            Dim exe As String

            running = CheckIfRunning(programs(i, 0))
            pretty = programs(i, 1)
            exe = programs(i, 2)

            If running = False Then
                Dim proc As New System.Diagnostics.Process()
                proc = Process.Start(programs(i, 2))

                MsgBox(pretty + " went down. Restarting...")


            End If

            i += 1

        End While

        Thread.Sleep(1000)





        Main()

    End Sub



    Function CheckIfRunning(processname As String)
        Dim p() As Process
        p = Process.GetProcessesByName(processname)
        If p.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


End Module



