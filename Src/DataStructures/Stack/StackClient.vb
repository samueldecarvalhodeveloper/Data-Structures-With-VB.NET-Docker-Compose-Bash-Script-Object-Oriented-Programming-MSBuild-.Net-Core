Imports DataStructures.Src.Constants

Namespace Src.DataStructures.Stack
    Public Module StackClient
        Public Sub Execute()
            Dim stack = New Stack(Of Integer)()

            For Each value As Integer In Lists.List
                stack.AddValue(value)
            Next

            If stack.IsEmpty() Then
                Console.WriteLine("Stack Is Empty")

                Console.WriteLine()
            Else
                Console.WriteLine("Stack Is Not Empty")

                Console.WriteLine()
            End If

            Console.WriteLine("Stack Size Is: """ + stack.GetSize().ToString() + """")

            Console.WriteLine()

            Console.Write("[ ")

            For currentValueIndex = 0 To stack.GetSize() - 1
                Dim currentValue = stack.GetValue().ToString()

                if stack.IsEmpty() Then
                    Console.Write(currentValue)
                Else
                    Console.Write(currentValue + ", ")
                End If
            Next

            Console.Write(" ]")
        End Sub
    End Module
End Namespace
