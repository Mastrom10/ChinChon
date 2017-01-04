Imports BE

Public Class Mazo


    Private _cartas As List(Of Carta)

    Friend Property Cartas As List(Of Carta)
        Get
            Return _cartas
        End Get
        Set(value As List(Of Carta))
            _cartas = value
        End Set
    End Property

    Public Sub New()

        For numero = 1 To 12
            For palo = 0 To 3
                _cartas.Add(New Carta(palo, numero))
            Next
        Next
        _cartas.Add(New Carta(4, 0))
        _cartas.Add(New Carta(4, 0))

    End Sub

    Public Sub MesclarMazo()
        Shuffle(_cartas)
    End Sub

    Function Shuffle(Of T)(collection As IEnumerable(Of T)) As List(Of T)
        Dim r As Random = New Random()
        Shuffle = collection.OrderBy(Function(a) r.Next()).ToList()
    End Function




End Class
