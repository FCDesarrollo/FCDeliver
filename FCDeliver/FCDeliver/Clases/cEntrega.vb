Public Class cEntrega
    Private _correo As String
    Private _contra As String
    Private _rfc As String
    Private _tipodocumento As String
    Private _periodo As Integer
    Private _ejercicio As Integer
    Private _status As Integer
    Private _fechaentregado As Date
    Private _fechacorte As Date
    Private _idusuarioE As Integer

    Private _documento As New Collection

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Contra As String
        Get
            Return _contra
        End Get
        Set(value As String)
            _contra = value
        End Set
    End Property

    Public Property Rfc As String
        Get
            Return _rfc
        End Get
        Set(value As String)
            _rfc = value
        End Set
    End Property

    Public Property Tipodocumento As String
        Get
            Return _tipodocumento
        End Get
        Set(value As String)
            _tipodocumento = value
        End Set
    End Property

    Public Property Periodo As Integer
        Get
            Return _periodo
        End Get
        Set(value As Integer)
            _periodo = value
        End Set
    End Property

    Public Property Ejercicio As Integer
        Get
            Return _ejercicio
        End Get
        Set(value As Integer)
            _ejercicio = value
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

    Public Property Fechaentregado As Date
        Get
            Return _fechaentregado
        End Get
        Set(value As Date)
            _fechaentregado = value
        End Set
    End Property

    Public Property Documento As Collection
        Get
            Return _documento
        End Get
        Set(value As Collection)
            _documento = value
        End Set
    End Property

    Public Property IdusuarioE As Integer
        Get
            Return _idusuarioE
        End Get
        Set(value As Integer)
            _idusuarioE = value
        End Set
    End Property

    Public Property FechaCorte As Date
        Get
            Return _fechacorte
        End Get
        Set(value As Date)
            _fechacorte = value
        End Set
    End Property
End Class
