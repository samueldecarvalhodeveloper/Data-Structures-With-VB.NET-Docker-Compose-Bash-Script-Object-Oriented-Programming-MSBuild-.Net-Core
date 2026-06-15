Namespace Src.DataStructures.StackWithLinkedList
    Public Class StackWithLinkedList (Of T)
        Private _head As LinkedListEntity(Of T)
        Private _size As Integer = 0

        Public Sub AddValue(value As T)
            Dim newHead As New LinkedListEntity(Of T) With {
                    .Value = value,
                    .ValueNext = _head
                    }

            _head = newHead

            _size += 1
        End Sub

        Public Function GetValue() As T
            Dim value As T = _head.Value

            _head = _head.ValueNext

            _size -= 1

            Return value
        End Function

        Public Function GetSize() As Integer
            Return _size
        End Function

        Public Function IsEmpty() As Boolean
            Return _size = 0
        End Function
    End Class
End NameSpace