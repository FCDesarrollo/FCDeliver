Public Class cDocumento
    Private _nombreE As String
    Private _fechacorte As Date
    Public Property NombreE As String
        Get
            Return _nombreE
        End Get
        Set(value As String)
            _nombreE = value
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
