public class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T data)
    {
        Data = data;
    }
}

public class List<T>
{
    protected Node<T>? head;

    public void AddFirst(T item)
    {
        var newNode = new Node<T>(item) { Next = head };
        head = newNode;
    }

    public T RemoveFirst()
    {
        if (head == null)
        {
            throw new ArgumentException("Список пуст.");
        }
        T data = head.Data;
        head = head.Next;
        return data;
    }

    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        var current = head;
        while (current != null)
        {
            if (current.Data != null) sb.AppendLine(current.Data.ToString());
            current = current.Next;
        }
        return sb.ToString();
    }
}

public class Stack<T> : List<T>
{
    public void Push(T element)
    {
        AddFirst(element);
    }

    public T Pop()
    {
        if (head == null)
        {
            throw new ArgumentException("Стек пуст.");
        }
        return RemoveFirst();
    }
}
