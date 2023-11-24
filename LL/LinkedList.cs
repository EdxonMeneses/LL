namespace LL;
public class LinkedList
{
    private Node head;
    public int Count { get; private set; }

    public LinkedList()
    {
        head = null;
        Count = 0;
    }

    public void AddFirst(string value)
    {
        Node newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
        Count++;
    }

    public void AddLast(string value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Count++;
    }

    public void RemoveFirst()
    {
        if (head != null)
        {
            Node temp = head;
            head = head.Next;
            temp.Next = null;
            Count--;
        }
    }

    public void RemoveLast()
    {
        if (head != null)
        {
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while (current.Next?.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            Count--;
        }
    }

    public string GetValue(int index)
    {
        if (index < 0 || index >= Count || head == null)
        {
            return null;
        }
        else
        {
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
    }
}

