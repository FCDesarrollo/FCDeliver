Imports System.Text.RegularExpressions

Module mFunciones
    Public Function fOnline() As Boolean
        fOnline = False
        If My.Computer.Network.IsAvailable() Then
            Try
                If My.Computer.Network.Ping("www.google.com", 2000) Then
                    fOnline = True
                End If
            Catch ex As Exception
                fOnline = False
            End Try
        End If
    End Function
    Public Function IsValidEmail(ByVal email As String) As Boolean
        Return Regex.IsMatch(email, "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]{2,4}$")
    End Function

    Public Sub UserForm(ByVal mFrm As Form, ByVal mNomfrm As String)
        mFrm.Text = mNomfrm & " - Usuario: " & gUsuario.Nombre & " " & gUsuario.Apellidop & " " & gUsuario.Apellidom
    End Sub

    Public Sub Carga_Servicios()
        Dim fServicio As cServicio
        gServicios.Clear()
        aMetodo = "serviciosfc"

        aDatos = "{ " & Chr(34) & "correo" & Chr(34) & ": " & Chr(34) & gUsuario.Correo & Chr(34) & "," &
                    Chr(34) & "contra" & Chr(34) & ": " & Chr(34) & gUsuario.Password & Chr(34) & "
                    }"

        aRespuesta = ConsumeAPI()
        If aRespuesta <> "" And ApimsjError() = False Then
            aJsonRespuesta = Newtonsoft.Json.Linq.JObject.Parse(aRespuesta)
            For Each Row In aJsonRespuesta("servicio")
                fServicio = New cServicio
                With fServicio
                    .Id = Row("id")
                    .Codigoservicio = Row("codigoservicio")
                    .Nombreservicio = Row("nombreservicio")
                    .Precio = Row("precio")
                    .Descripcion = Row("descripcion")
                    .Tipo = Row("tipo")
                    .Actualizable = Row("actualizable")
                    .Fecha = Row("fecha")
                    .Status = Row("status")
                End With
                gServicios.Add(fServicio)
            Next
        End If
    End Sub

    Public Function fGetTipo_Servicio(ByVal fTipo As Integer) As String
        Dim tiposervicio As String
        Select Case fTipo
            Case 1
                tiposervicio = "UNICO"
            Case 2
                tiposervicio = "DIARIO"
            Case 3
                tiposervicio = "MENSUAL"
            Case 4
                tiposervicio = "ANUAL"
            Case Else
                tiposervicio = ""
        End Select
        fGetTipo_Servicio = tiposervicio
    End Function

    Public Function Primer_Dia_Mes(ByVal dtmFecha As Date) As Date
        Primer_Dia_Mes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    Function Ultimo_Dia_Mes(ByVal dtmFecha As Date) As Date
        Ultimo_Dia_Mes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function
End Module
