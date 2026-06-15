Namespace Src.DataStructures.Queue
    Public Class Queue (Of T)
        Private ReadOnly _queue As ArrayList = New ArrayList()

        Public Function GetValue() As T
            Dim value As T = _queue.Item(index := 0)

            _queue.RemoveAt(0)

            Return value
        End Function

        Public Sub AddValue(value As T)
            _queue.Add(value := value)
        End Sub

        Public Function GetSize() As Integer
            Return _queue.Count
        End Function

        Public Function IsEmpty() As Boolean
            Return _queue.Count = 0
        End Function
    End Class
End Namespace
