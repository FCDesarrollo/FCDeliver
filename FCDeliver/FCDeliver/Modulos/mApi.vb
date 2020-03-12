Imports System.IO
Imports System.Net
Imports System.Text

Module mApi
    Public Const urlAPi As String = "http://apicrm.dublock.com/public/" '"http://localhost/ApiConsultorMX/miconsultor/public/" '

    Public aMetodo As String
    Public aDatos As String, aRespuesta As String
    Public aJsonRespuesta As Newtonsoft.Json.Linq.JObject

    Public Function ConsumeAPI() As String
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim response As HttpWebResponse
        Dim reader As StreamReader
        Dim rawresponse As String
        Dim postdata As String
        Dim postdatabytes As Byte()
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Try
            s = HttpWebRequest.Create(urlAPi & aMetodo)
            System.Net.ServicePointManager.UseNagleAlgorithm = False
            System.Net.ServicePointManager.Expect100Continue = False
            s.AllowReadStreamBuffering = False
            enc = New System.Text.UTF8Encoding()
            postdata = aDatos
            postdatabytes = enc.GetBytes(postdata)
            s.Method = "POST"
            's.ContentType = "application/x-www-form-urlencoded"
            s.KeepAlive = True
            s.ContentType = "application/json"

            s.ContentLength = postdatabytes.Length
            s.Timeout = System.Threading.Timeout.Infinite

            Using stream = s.GetRequestStream()
                stream.Write(postdatabytes, 0, postdatabytes.Length)
            End Using

            response = s.GetResponse()
            reader = New StreamReader(response.GetResponseStream())

            rawresponse = reader.ReadToEnd()
            ConsumeAPI = rawresponse
        Catch ex As Exception
            MsgBox("Error al Consumir API" & vbCrLf & ex.Message, vbExclamation, "Validación")
            ConsumeAPI = ""
        End Try

    End Function

    Public Function ApimsjError() As Boolean
        Select Case aRespuesta
            Case "2"
                MsgBox("Mensaje de Api FC " & vbCrLf & "El usuario es incorrecto.", vbExclamation, "Validación")
                ApimsjError = True
            Case "3"
                MsgBox("Mensaje de Api FC " & vbCrLf & "La contraseña del usuario es incorrecta.", vbExclamation, "Validación")
                ApimsjError = True
            Case Else
                ApimsjError = False
        End Select

    End Function
End Module
