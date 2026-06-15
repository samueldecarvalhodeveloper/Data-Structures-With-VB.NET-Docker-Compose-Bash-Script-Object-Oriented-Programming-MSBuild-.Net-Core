Imports DataStructures.Src.Constants

Namespace Src.DataStructures.StackWithLinkedList
    Public Module StackWithLinkedListClient
        Public Sub Execute()
            Dim stackWithLinkedList = New StackWithLinkedList(Of Integer)()

            For Each value As Integer In Lists.List
                stackWithLinkedList.AddValue(value)
            Next

            If stackWithLinkedList.IsEmpty() Then
                Console.WriteLine("Stack Is Empty")

                Console.WriteLine()
            Else
                Console.WriteLine("Stack Is Not Empty")

                Console.WriteLine()
            End If

            Console.WriteLine("Stack Size Is: """ + stackWithLinkedList.GetSize().ToString() + """")

            Console.WriteLine()

            Console.Write("[ ")

            For currentValueIndex = 0 To stackWithLinkedList.GetSize() - 1
                Dim currentValue = stackWithLinkedList.GetValue().ToString()

                if stackWithLinkedList.IsEmpty() Then
                    Console.Write(currentValue)
                Else
                    Console.Write(currentValue + ", ")
                End If
            Next

            Console.Write(" ]")
        End Sub
    End Module
End NameSpace