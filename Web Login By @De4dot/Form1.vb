Imports System.IO
Imports System.Net
Imports System.Text
'Coded and extracted by Ahmed Al-Jabari 
'Process.Start("https://t.me/YYxYY")
'Process.Start("https://www.instagram.com/de4dot")

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim Bytes As Byte() = Encoding.Default.GetBytes("username=" & TextBox1.Text & "&enc_password=#PWD_INSTAGRAM_BROWSER:0:1589682409:" & TextBox2.Text & "&queryParams={}&optIntoOneTap=false")

            Dim Request_Login As HttpWebRequest = DirectCast(WebRequest.Create("https://www.instagram.com/accounts/login/ajax/"), HttpWebRequest)

            With Request_Login
                .Method = "POST"
                .Host = "www.instagram.com"
                .KeepAlive = True
                .UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.73 Safari/537.36"
                .Accept = "*/*"
                .Referer = "https://www.instagram.com/de4dot"
                .ContentType = "application/x-www-form-urlencoded"
                .Headers.Add("X-Requested-With", "XMLHttpRequest")
                .Headers.Add("X-IG-App-ID", "936619743392459")
                .Headers.Add("X-Instagram-AJAX", "AJ")
                .Headers.Add("X-CSRFToken", "AJ")
                .Headers.Add("Origin", "https://www.instagram.com")
                .Headers.Add("Sec-Fetch-Site", "same-origin")
                .Headers.Add("Accept-Language", "en-US,en;q=0.9")
                .AutomaticDecompression = DecompressionMethods.Deflate Or DecompressionMethods.GZip
                .ContentLength = Bytes.Length
            End With

            Dim Stream As Stream = Request_Login.GetRequestStream()
            Stream.Write(Bytes, 0, Bytes.Length)
            Dim Responseee As HttpWebResponse = Request_Login.GetResponse
            Dim Reader As New StreamReader(Responseee.GetResponseStream())
            Dim AhmedAljabariS As String = Reader.ReadToEnd

            MsgBox(AhmedAljabariS)

        Catch ex As WebException
            Dim uu As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()
            MsgBox("Error : " & uu)
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://t.me/YYxYY")
        Process.Start("https://www.instagram.com/de4dot")
        Process.Start("https://www.youtube.com/de4dot")
    End Sub
End Class