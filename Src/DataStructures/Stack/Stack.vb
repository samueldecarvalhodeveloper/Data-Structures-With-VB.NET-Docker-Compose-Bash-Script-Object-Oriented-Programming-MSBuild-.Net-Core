Namespace Src.DataStructures.Stack
    Public Class Stack (Of T)
        Private ReadOnly _stack As ArrayList = New ArrayList()

        Public Function GetValue() As T
            Dim value As T = _stack.Item(index := _stack.Count - 1)

            _stack.RemoveAt(_stack.Count - 1)

            Return value
        End Function

        Public Sub AddValue(value As T)
            _stack.Add(value := value)
        End Sub

        Public Function GetSize() As Integer
            Return _stack.Count
        End Function

        Public Function IsEmpty() As Boolean
            Return _stack.Count = 0
        End Function
    End Class
End Namespace
