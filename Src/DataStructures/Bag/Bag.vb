Namespace Src.DataStructures.Bag
    Public Class Bag (Of T)
        Private ReadOnly _bag As ArrayList = New ArrayList()

        Public Function GetValue(index As Integer) As T
            Return _bag.Item(index := index)
        End Function

        Public Sub AddValue(value As T)
            _bag.Add(value := value)
        End Sub

        Public Function GetSize() As Integer
            Return _bag.Count
        End Function

        Public Function IsEmpty() As Boolean
            Return _bag.Count = 0
        End Function
    End Class
End Namespace
