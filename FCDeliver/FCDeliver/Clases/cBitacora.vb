Public Class cBitacora
    Private _id As Integer
    Private _idsubmenu As Integer
    Private _tipodocumento As String
    Private _periodo As Integer
    Private _ejercicio As Integer
    Private _fecha As Date
    Private _fechamodifiacion As DateTime
    Private _archivo As String
    Private _nombrearchivoG As String
    Private _idusuarioG As Integer
    Private _status As Integer
    Private _idusuarioE As Integer
    Private _nombrearchivoE As String
    Private _fechaentregado As Date
    Private _fechacorte As Date
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Idsubmenu As Integer
        Get
            Return _idsubmenu
        End Get
        Set(value As Integer)
            _idsubmenu = value
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

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Fechamodifiacion As Date
        Get
            Return _fechamodifiacion
        End Get
        Set(value As Date)
            _fechamodifiacion = value
        End Set
    End Property

    Public Property Archivo As String
        Get
            Return _archivo
        End Get
        Set(value As String)
            _archivo = value
        End Set
    End Property

    Public Property NombrearchivoG As String
        Get
            Return _nombrearchivoG
        End Get
        Set(value As String)
            _nombrearchivoG = value
        End Set
    End Property

    Public Property IdusuarioG As Integer
        Get
            Return _idusuarioG
        End Get
        Set(value As Integer)
            _idusuarioG = value
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

    Public Property IdusuarioE As Integer
        Get
            Return _idusuarioE
        End Get
        Set(value As Integer)
            _idusuarioE = value
        End Set
    End Property

    Public Property NombrearchivoE As String
        Get
            Return _nombrearchivoE
        End Get
        Set(value As String)
            _nombrearchivoE = value
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

    Public Property Fechacorte As Date
        Get
            Return _fechacorte
        End Get
        Set(value As Date)
            _fechacorte = value
        End Set
    End Property
End Class
