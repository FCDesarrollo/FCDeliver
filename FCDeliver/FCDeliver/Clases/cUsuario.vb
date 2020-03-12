Public Class cUsuario
    Private _idusuario As Integer
    Private _nombre As String
    Private _apellidop As String
    Private _apellidom As String
    Private _cel As String
    Private _correo As String
    Private _password As String
    Private _status As Integer
    Private _tipo As Integer

    Private _empresas As New Collection
    Public Property Idusuario As Integer
        Get
            Return _idusuario
        End Get
        Set(value As Integer)
            _idusuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidop As String
        Get
            Return _apellidop
        End Get
        Set(value As String)
            _apellidop = value
        End Set
    End Property

    Public Property Apellidom As String
        Get
            Return _apellidom
        End Get
        Set(value As String)
            _apellidom = value
        End Set
    End Property

    Public Property Cel As String
        Get
            Return _cel
        End Get
        Set(value As String)
            _cel = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
        End Set
    End Property

    Public Property Empresas As Collection
        Get
            Return _empresas
        End Get
        Set(value As Collection)
            _empresas = value
        End Set
    End Property

    Public Sub Empresas_Usuarios()
        Dim uEmpresa As cEmpresa

        aMetodo = "empresasadmin"

        aDatos = "{ " & Chr(34) & "correo" & Chr(34) & ": " & Chr(34) & _correo & Chr(34) & "," &
                    Chr(34) & "contra" & Chr(34) & ": " & Chr(34) & _password & Chr(34) & "
                    }"
        Try
            aRespuesta = ConsumeAPI()
            If aRespuesta <> "" And ApimsjError() = False Then
                aJsonRespuesta = Newtonsoft.Json.Linq.JObject.Parse(aRespuesta)
                For Each Row In aJsonRespuesta("empresa")
                    uEmpresa = New cEmpresa
                    With uEmpresa
                        .Idempresa = Row("idempresa")
                        .Nombreempresa = Row("nombreempresa")
                        .Rutaempresa = Row("rutaempresa")
                        .Rfc = Row("RFC")
                        .Direccion = Row("direccion")
                        .Telefono = Row("telefono")
                        .Codigopostal = Row("codigopostal")
                        .Fecharegistro = Row("fecharegistro")
                        .Status = Row("status")
                        .Password = Row("password")
                        .Correo = Row("correo")
                        .EmpresaBD = Row("empresaBD")
                    End With
                    _empresas.Add(uEmpresa)
                    Servicios_Empresa(uEmpresa.Idempresa)
                Next
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las empresas." & vbCrLf & ex.Message, vbInformation, "Validación")
        End Try

    End Sub

    Private Sub Servicios_Empresa(ByVal sidempresa As Integer)
        Dim sEmpresa As cEmpresa, sServicio As cServicio, sNewServicio As cServicio
        Dim sServicioCom As cServicio, sSerExiste As Boolean
        Try
            For Each sEmpresa In gUsuario.Empresas
                If sEmpresa.Idempresa = sidempresa Then
                    sEmpresa.ServiciosMen.Clear()

                    aMetodo = "servicioscontratados"

                    aDatos = "{ " & Chr(34) & "correo" & Chr(34) & ": " & Chr(34) & _correo & Chr(34) & "," &
                        Chr(34) & "contra" & Chr(34) & ": " & Chr(34) & _password & Chr(34) & "," &
                        Chr(34) & "idempresa" & Chr(34) & ": " & Chr(34) & sidempresa & Chr(34) & "
                    }"
                    aRespuesta = ConsumeAPI()
                    If aRespuesta <> "" And ApimsjError() = False Then
                        aJsonRespuesta = Newtonsoft.Json.Linq.JObject.Parse(aRespuesta)
                        For Each Row In aJsonRespuesta("serviciocon")
                            For Each sServicio In gServicios
                                If sServicio.Id = CInt(Row("idservicio")) Then
                                    sNewServicio = New cServicio
                                    With sNewServicio
                                        .Id = sServicio.Id
                                        .Codigoservicio = sServicio.Codigoservicio
                                        .Nombreservicio = sServicio.Nombreservicio
                                        .Precio = sServicio.Precio
                                        .Descripcion = sServicio.Descripcion
                                        .Tipo = sServicio.Tipo
                                        .Actualizable = sServicio.Actualizable
                                        .Fecha = sServicio.Fecha
                                        .Status = sServicio.Status
                                        .Estado = "Contradado"
                                    End With
                                    If sServicio.Tipo = 3 Then
                                        sEmpresa.ServiciosMen.Add(sNewServicio)
                                    ElseIf sServicio.Tipo = 4 Then

                                    End If

                                    Exit For
                                End If
                            Next
                        Next
                    End If

                    For Each sServicio In gServicios
                        sSerExiste = False
                        For Each sServicioCom In sEmpresa.ServiciosMen
                            If sServicio.Id = sServicioCom.Id Then
                                sSerExiste = True
                                Exit For
                            End If
                        Next
                        If sSerExiste = False Then
                            sNewServicio = New cServicio
                            With sNewServicio
                                .Id = sServicio.Id
                                .Codigoservicio = sServicio.Codigoservicio
                                .Nombreservicio = sServicio.Nombreservicio
                                .Precio = sServicio.Precio
                                .Descripcion = sServicio.Descripcion
                                .Tipo = sServicio.Tipo
                                .Actualizable = sServicio.Actualizable
                                .Fecha = sServicio.Fecha
                                .Status = sServicio.Status
                                .Estado = "N/C"
                            End With
                            sEmpresa.ServiciosMen.Add(sNewServicio)
                        End If
                    Next

                    Exit For
                End If
            Next sEmpresa
        Catch ex As Exception
            MsgBox("Erro carga Servicio" & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try

    End Sub
End Class
