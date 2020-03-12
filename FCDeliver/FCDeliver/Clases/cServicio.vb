Public Class cServicio
    Private _id As Integer
    Private _codigoservicio As String
    Private _nombreservicio As String
    Private _precio As Double
    Private _descripcion As String
    Private _tipo As Integer
    Private _fecha As Date
    Private _status As Integer
    Private _actualizable As Integer
    Private _estado As String

    Private _sBitacora As New Collection
    Public Property Codigoservicio As String
        Get
            Return _codigoservicio
        End Get
        Set(value As String)
            _codigoservicio = value
        End Set
    End Property

    Public Property Nombreservicio As String
        Get
            Return _nombreservicio
        End Get
        Set(value As String)
            _nombreservicio = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
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

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
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

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Actualizable As Integer
        Get
            Return _actualizable
        End Get
        Set(value As Integer)
            _actualizable = value
        End Set
    End Property

    Public Property SBitacora As Collection
        Get
            Return _sBitacora
        End Get
        Set(value As Collection)
            _sBitacora = value
        End Set
    End Property

    Public Sub Bitacora_servicio(ByVal sEjercicio As Integer, ByVal sIDEmpresa As Integer)
        Dim bsBitacora As cBitacora
        _sBitacora.Clear()

        aMetodo = "bitacoraservicios"

        aDatos = "{ " & Chr(34) & "correo" & Chr(34) & ": " & Chr(34) & gUsuario.Correo & Chr(34) & "," &
            Chr(34) & "contra" & Chr(34) & ": " & Chr(34) & gUsuario.Password & Chr(34) & "," &
            Chr(34) & "codigoservicio" & Chr(34) & ": " & Chr(34) & _codigoservicio & Chr(34) & "," &
            Chr(34) & "ejercicio" & Chr(34) & ": " & Chr(34) & sEjercicio & Chr(34) & "," &
            Chr(34) & "idempresa" & Chr(34) & ": " & Chr(34) & sIDEmpresa & Chr(34) & "
                    }"
        aRespuesta = ConsumeAPI()
        If aRespuesta <> "" And ApimsjError() = False Then
            aJsonRespuesta = Newtonsoft.Json.Linq.JObject.Parse(aRespuesta)
            For Each Row In aJsonRespuesta("bitacora")
                bsBitacora = New cBitacora
                With bsBitacora
                    .Id = Row("id")
                    .Idsubmenu = Row("idsubmenu")
                    .Tipodocumento = Row("tipodocumento")
                    .Periodo = Row("periodo")
                    .Ejercicio = Row("ejercicio")
                    .Fecha = Row("fecha")
                    .Fechamodifiacion = Row("fechamodificacion")
                    .Archivo = Row("archivo")
                    .NombrearchivoG = Row("nombrearchivoG")
                    .IdusuarioG = Row("idusuarioG")
                    .Status = Row("status")
                    '.IdusuarioE = Row("idusuarioE")
                    '.NombrearchivoE = Row("nombreArchivoE")
                    If .Status = 1 Then
                        .IdusuarioE = Row("idusuarioE")
                        .Fechacorte = Row("fechacorte")

                        .Fechaentregado = Row("fechaentregado")
                    End If
                End With
                _sBitacora.Add(bsBitacora)
            Next
        End If
    End Sub

    Public Sub Bitacora_serviciosLocal(ByVal sEjercicio As Integer)
        Dim dQue As String
        Dim bsBitacora As cBitacora
        _sBitacora.Clear()

        dQue = "SELECT DISTINCT month(fecha),MAX(FECHA) FROM zIncControlXml 
                    WHERE YEAR(FECHA) =" & sEjercicio & " GROUP BY MONTH(fecha)"

    End Sub

End Class
