Imports DataStructures.Src.DataStructures.Bag
Imports DataStructures.Src.DataStructures.Queue
Imports DataStructures.Src.DataStructures.StackWithLinkedList
Imports DataStructures.Src.DataStructures.Stack

Module Program
    Sub Main()
        Console.WriteLine("Stack:")

        Console.WriteLine()

        StackClient.Execute()

        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("Stack With Linked List:")

        Console.WriteLine()

        StackWithLinkedListClient.Execute()

        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("Queue:")

        Console.WriteLine()

        QueueClient.Execute()

        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("Bag:")

        Console.WriteLine()

        BagClient.Execute()
    End Sub
End Module
