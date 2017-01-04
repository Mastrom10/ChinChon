Imports BE

Friend Class Carta

    Private _palo As PALO
    Private _numero As Integer

    Friend Property Palo As PALO
        Get
            Return _palo
        End Get
        Set(value As PALO)
            _palo = value
        End Set
    End Property

    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property


    Sub New(Palo As PALO, Numero As Integer)
        Me.Palo = Palo
        Me.Numero = Numero
    End Sub


End Class

Enum PALO
    Espada = 0
    Basto = 1
    Oro = 2
    Copa = 3
    Comodin = 4
End Enum