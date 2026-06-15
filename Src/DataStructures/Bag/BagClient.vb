Imports DataStructures.Src.Constants

Namespace Src.DataStructures.Bag
    Public Module BagClient
        Public Sub Execute()
            Dim bag = New Bag(Of Integer)()

            For Each value As Integer In Lists.List
                bag.AddValue(value)
            Next

            If bag.IsEmpty() Then
                Console.WriteLine("Bag Is Empty")

                Console.WriteLine()
            Else
                Console.WriteLine("Bag Is Not Empty")

                Console.WriteLine()
            End If

            Console.WriteLine("Bag Size Is: """ + bag.GetSize().ToString() + """")

            Console.WriteLine()

            Console.Write("[ ")

            For currentValueIndex = 0 To bag.GetSize() - 1
                If currentValueIndex = bag.GetSize() - 1 Then
                    Console.Write(bag.GetValue(currentValueIndex))
                Else
                    Console.Write(bag.GetValue(currentValueIndex).ToString() + ", ")
                End If
            Next

            Console.Write(" ]")
        End Sub
    End Module
End NameSpace