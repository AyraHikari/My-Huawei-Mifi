Imports System.Xml
Imports System.Web
Public Class Form1
    Dim webClient As New System.Net.WebClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' IP Address
        Dim IP
        If My.Settings.FirstTime = False Then
InputIP:
            IP = InputBox("Input Your Mifi IP Address")
            If IP = "" Then
                End
            End If
            My.Settings.IpAddress = IP
        End If
        ' Trying to connect
        Try
            webClient.DownloadString("http://" + My.Settings.IpAddress + "/")
        Catch
            MsgBox("Could not connect to " + My.Settings.IpAddress + ", please input your IP Address again")
            GoTo InputIP
        End Try
        ' Success connected
        My.Settings.FirstTime = True
        Timer1.Enabled = True
        GetMsg.Enabled = True
        My.Settings.Cookie = webClient.ResponseHeaders.Get("Set-Cookie")
        TextBox1.Text = My.Settings.IpAddress
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Creating dim
        Dim result, prov As String

        ' Set Cookie
        webClient.Headers.Set("Cookie", My.Settings.Cookie)

        ' Trying to get status, if failed return and try again later
        Try
            result = webClient.DownloadString("http://" + My.Settings.IpAddress + "/api/monitoring/status")
        Catch ex As Exception
            Console.WriteLine("Request Time Out at monitoring")
            Return
        End Try
        Try
            prov = webClient.DownloadString("http://" + My.Settings.IpAddress + "/api/net/current-plmn")
        Catch ex As Exception
            Console.WriteLine("Request Time Out at get current provider")
            Return
        End Try

        ' Load Provider Name
        If Me.ShowInTaskbar Then
            Dim xmlprov As New XmlDocument()
            xmlprov.LoadXml(prov)
            If xmlprov.GetElementsByTagName("FullName").Count = 0 Then
                Provider.Text = "No Service"
            ElseIf xmlprov.GetElementsByTagName("FullName")(0).InnerText = 51009 Then
                Provider.Text = "Smartfren"
            Else
                Provider.Text = Str(xmlprov.GetElementsByTagName("FullName")(0).InnerText)
            End If
        End If


        ' Load Signal xml
        Dim xmlsignal As New XmlDocument()
        xmlsignal.LoadXml(result)

        ' Get if data is turned on
        Dim xmldata As New XmlDocument()
        Dim mdata = webClient.DownloadString("http://" + My.Settings.IpAddress + "/api/dialup/mobile-dataswitch")
        xmldata.LoadXml(mdata)
        Dim mifidata = xmldata.GetElementsByTagName("dataswitch")(0).InnerText

        ' Set Network Mode
        Dim netwk, netname
        Dim nettype = xmlsignal.GetElementsByTagName("CurrentNetworkType")(0).InnerText
        If nettype = 0 Then
            netwk = "No Service"
            netname = "No Service"
        ElseIf nettype = 1 Then
            netwk = "GSM"
            netname = "2G"
        ElseIf nettype = 2 Then
            netwk = "GPRS"
            netname = "G"
        ElseIf nettype = 3 Then
            netwk = "EDGE"
            netname = "E"
        ElseIf nettype = 4 Then
            netwk = "WCDMA"
            netname = "W"
        ElseIf nettype = 5 Then
            netwk = "HSDPA"
            netname = "H"
        ElseIf nettype = 6 Then
            netwk = "HSUPA"
            netname = "H"
        ElseIf nettype = 7 Then
            netwk = "HSPA"
            netname = "H"
        ElseIf nettype = 8 Then
            netwk = "TDSCDMA"
            netname = "H+"
        ElseIf nettype = 9 Then
            netwk = "HSPA+"
            netname = "H+"
        ElseIf nettype = 10 Then
            netwk = "EVDO"
            netname = "EVDO"
        ElseIf nettype = 11 Then
            netwk = "EVDO A"
            netname = "EVDO"
        ElseIf nettype = 12 Then
            netwk = "EVDO B"
            netname = "EVDO"
        ElseIf nettype = 13 Then
            netwk = "RTT"
            netname = "2G"
        ElseIf nettype = 14 Then
            netwk = "UMB"
            netname = "??"
        ElseIf nettype = 15 Then
            netwk = "EVDV"
            netname = "2G"
        ElseIf nettype = 16 Then
            netwk = "RTT"
            netname = "2G"
        ElseIf nettype = 17 Then
            netwk = "HSPA+ 64QAM"
            netname = "H+"
        ElseIf nettype = 18 Then
            netwk = "HSPA+ MIMO"
            netname = "H+"
        ElseIf nettype = 19 Then
            netwk = "LTE"
            netname = "4G"
        Else
            netwk = "??"
            netname = "??"
        End If
        If netname = "No Service" Then
            NetwkTypeLabel.Text = "X"
        Else
            NetwkTypeLabel.Text = netname
        End If

        ' Get trafic info
        Dim xmltraf As New XmlDocument()
        Dim trafik = webClient.DownloadString("http://" + My.Settings.IpAddress + "/api/monitoring/traffic-statistics")
        xmltraf.LoadXml(trafik)
        Dim curdl = xmltraf.GetElementsByTagName("CurrentDownload")(0).InnerText
        Dim curup = xmltraf.GetElementsByTagName("CurrentUpload")(0).InnerText

        ' Set Signal Icon
        Dim asw = xmlsignal.GetElementsByTagName("SignalIcon")
        If asw(0) Is Nothing Or Provider.Text = "No Service" Then
            NotifyIcon1.Icon = My.Resources.no_service
            NotifyIcon1.Text = "No service"
            SignalBox.Image = My.Resources.icon_signal_00_result
        Else
            If asw(0).InnerText = 0 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_0
                    NotifyIcon1.Text = netname + ": 0 bar" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_0
                    NotifyIcon1.Text = netname + ": 0 bar" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_00_result
            ElseIf asw(0).InnerText = 1 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_1
                    NotifyIcon1.Text = netname + ": 1 bar" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_1
                    NotifyIcon1.Text = netname + ": 1 bar" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_01_result
            ElseIf asw(0).InnerText = 2 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_2
                    NotifyIcon1.Text = netname + ": 2 bars" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_2
                    NotifyIcon1.Text = netname + ": 2 bars" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_02_result
            ElseIf asw(0).InnerText = 3 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_3
                    NotifyIcon1.Text = netname + ": 3 bars" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_3
                    NotifyIcon1.Text = netname + ": 3 bars" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_03_result
            ElseIf asw(0).InnerText = 4 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_4
                    NotifyIcon1.Text = netname + ": 4 bars" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_4
                    NotifyIcon1.Text = netname + ": 4 bars" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_04_result
            ElseIf asw(0).InnerText = 5 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_5
                    NotifyIcon1.Text = netname + ": 5 bars" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_5
                    NotifyIcon1.Text = netname + ": 5 bars" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_05_result
            End If
            NotifyIcon1.Text += xmlsignal.GetElementsByTagName("CurrentWifiUser")(0).InnerText + " users connected" + vbCrLf
            NotifyIcon1.Text += xmlsignal.GetElementsByTagName("BatteryPercent")(0).InnerText + "% battery" + vbCrLf
            curdl = FormatNumber(CDbl(Int(curdl) / 1024000), 2)
            curup = FormatNumber(CDbl(Int(curup) / 1024000), 2)
            Try
                NotifyIcon1.Text += curdl + " MB / " + curup + " MB"
            Catch ex As Exception
                NotifyIcon1.Text += Int(curdl) + " MB / " + Int(curup) + " MB"
            End Try
            NetUsageLabel.Text = "Network Usage: " + curdl + " MB / " + curup + " MB"
            BatteryBar.Value = xmlsignal.GetElementsByTagName("BatteryPercent")(0).InnerText
            BatteryLabel.Text = xmlsignal.GetElementsByTagName("BatteryPercent")(0).InnerText + "%"
            UserConnected.Text = xmlsignal.GetElementsByTagName("CurrentWifiUser")(0).InnerText + " users connected"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles HideBtn.Click
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles WebUibtn.Click
        Dim homepage As New Uri("http://" + My.Settings.IpAddress + "/")
        BrowserMifi.WebBrowser1.Url = homepage
        BrowserMifi.Show()
    End Sub

    Private Sub GetMsg_Tick(sender As Object, e As EventArgs) Handles GetMsg.Tick
        ' Get message
        Dim getmsg
        Dim xmlmsg As New XmlDocument()
        Try
            getmsg = webClient.DownloadString("http://" + My.Settings.IpAddress + "/api/monitoring/check-notifications")
        Catch ex As Exception
            Console.WriteLine("Request Time Out at monitoring")
            Return
        End Try

        xmlmsg.LoadXml(getmsg)
        If xmlmsg.GetElementsByTagName("UnreadMessage")(0).InnerText <> 0 Then
            If MessageInfo.Visible = False Then
                msgpic.Visible = True
                MessageInfo.Visible = True
                MessageInfo.ShowBalloonTip(2000)
            End If
        Else
            MessageInfo.Visible = False
        End If
    End Sub

    Private Sub MessageInfo_Click(sender As Object, e As MouseEventArgs) Handles MessageInfo.MouseClick
        Dim homepage As New Uri("http://" + My.Settings.IpAddress + "/html/smsinbox.html")
        BrowserMifi.WebBrowser1.Url = homepage
        BrowserMifi.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ConnectBtn.Click

    End Sub

    Private Sub msgpic_DoubleClick(sender As Object, e As EventArgs) Handles msgpic.DoubleClick
        Dim homepage As New Uri("http://" + My.Settings.IpAddress + "/html/smsinbox.html")
        BrowserMifi.WebBrowser1.Url = homepage
        BrowserMifi.Show()
    End Sub

    Private Sub MessageInfo_BalloonTipClicked(sender As Object, e As EventArgs) Handles MessageInfo.BalloonTipClicked
        Dim homepage As New Uri("http://" + My.Settings.IpAddress + "/html/smsinbox.html")
        BrowserMifi.WebBrowser1.Url = homepage
        BrowserMifi.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        On Error Resume Next
        Me.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        On Error Resume Next
        Me.Show()
    End Sub

    Private Sub Advanced_Click(sender As Object, e As EventArgs) Handles AdvancedBtn.Click
        Advanced.Show()
    End Sub
End Class
