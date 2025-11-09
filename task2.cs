using System;

public class Node<T> where T : class
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T> where T : class
{
    private Node<T> head;
    private int count;

    public int Count => count;

    public LinkedList()
    {
        head = null;
        count = 0;
    }

    public void Add(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        count++;
    }

    public bool Remove(T item)
    {
        if (head == null) return false;

        if (head.Data == item)
        {
            head = head.Next;
            count--;
            return true;
        }

        Node<T> current = head;
        while (current.Next != null)
        {
            if (current.Next.Data == item)
            {
                current.Next = current.Next.Next;
                count--;
                return true;
            }
            current = current.Next;
        }

        return false;
    }

    public bool Contains(T item)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data == item)
                return true;
            current = current.Next;
        }
        return false;
    }

    public void Print()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.WriteLine($"  - {current.Data}");
            current = current.Next;
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Person: {Name}, {Age} years";
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"Book: '{Title}' by {Author}";
    }
}

public class DemoClass2
{
    public static void RunDemo()
    {
        Console.WriteLine("=== 2. LinkedList Demo ===");

        Console.WriteLine("String List:");
        LinkedList<string> stringList = new LinkedList<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        stringList.Add("C#");
        stringList.Print();

        Console.WriteLine("Person List:");
        LinkedList<Person> personList = new LinkedList<Person>();
        personList.Add(new Person("Alice", 25));
        personList.Add(new Person("Bob", 30));
        personList.Print();

        Console.WriteLine("Book List:");
        LinkedList<Book> bookList = new LinkedList<Book>();
        bookList.Add(new Book("1984", "George Orwell"));
        bookList.Add(new Book("Brave New World", "Aldous Huxley"));
        bookList.Print();

        Console.WriteLine();
    }
}