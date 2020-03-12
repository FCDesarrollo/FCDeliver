Public Class cReporte
    Private _nomempresa As String
    Private _titulo As String
    Private _complemento As String
    Private _colA As String
    Private _colB As String
    Private _colC As String
    Private _colD As String
    Private _colE As String
    Private _colF As String
    Private _colG As String


    Private _tipos As New Dictionary(Of String, String)
    Private _datos As New Collection

    Public Property Nomempresa As String
        Get
            Return _nomempresa
        End Get
        Set(value As String)
            _nomempresa = value
        End Set
    End Property

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property

    Public Property ColA As String
        Get
            Return _colA
        End Get
        Set(value As String)
            _colA = value
        End Set
    End Property

    Public Property ColB As String
        Get
            Return _colB
        End Get
        Set(value As String)
            _colB = value
        End Set
    End Property

    Public Property ColC As String
        Get
            Return _colC
        End Get
        Set(value As String)
            _colC = value
        End Set
    End Property

    Public Property ColD As String
        Get
            Return _colD
        End Get
        Set(value As String)
            _colD = value
        End Set
    End Property

    Public Property ColE As String
        Get
            Return _colE
        End Get
        Set(value As String)
            _colE = value
        End Set
    End Property

    Public Property ColF As String
        Get
            Return _colF
        End Get
        Set(value As String)
            _colF = value
        End Set
    End Property

    Public Property ColG As String
        Get
            Return _colG
        End Get
        Set(value As String)
            _colG = value
        End Set
    End Property

    Public Property Tipos As Dictionary(Of String, String)
        Get
            Return _tipos
        End Get
        Set(value As Dictionary(Of String, String))
            _tipos = value
        End Set
    End Property

    Public Property Datos As Collection
        Get
            Return _datos
        End Get
        Set(value As Collection)
            _datos = value
        End Set
    End Property

    Public Property Complemento As String
        Get
            Return _complemento
        End Get
        Set(value As String)
            _complemento = value
        End Set
    End Property
End Class
