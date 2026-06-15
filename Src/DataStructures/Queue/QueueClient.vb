Imports DataStructures.Src.Constants

Namespace Src.DataStructures.Queue
    Public Module QueueClient
        Public Sub Execute()
            Dim queue = New Queue(Of Integer)()

            For Each value As Integer In Lists.List
                queue.AddValue(value)
            Next

            If queue.IsEmpty() Then
                Console.WriteLine("Queue Is Empty")

                Console.WriteLine()
            Else
                Console.WriteLine("Queue Is Not Empty")

                Console.WriteLine()
            End If

            Console.WriteLine("Queue Size Is: """ + queue.GetSize().ToString() + """")

            Console.WriteLine()

            Console.Write("[ ")

            For currentValueIndex = 0 To queue.GetSize() - 1
                Dim currentValue = queue.GetValue().ToString()

                if queue.IsEmpty() Then
                    Console.Write(currentValue)
                Else
                    Console.Write(currentValue + ", ")
                End If
            Next

            Console.Write(" ]")
        End Sub
    End Module
End NameSpace