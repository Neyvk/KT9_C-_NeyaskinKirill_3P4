using System;
using System.Collections.Generic;

class Stack<T> where T : IComparable<T>
{
    private List<T> elements = new List<T>();
    public void Push(T item)
    {
        elements.Add(item);
        Console.WriteLine("Добавлен элемент - " + item);
    }

    public T Pop()
    {
        if (elements.Count == 0)
        {
            Console.WriteLine("Стек пустой");
            return default(T);
        }

        T top = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return top;
    }

    public T Peek()
    {
        if (elements.Count == 0)
        {
            Console.WriteLine("Стек пустой");
            return default(T);
        }

        return elements[elements.Count - 1];
    }

    public int Count
    {
        get { return elements.Count; }
    }

    public T Max()
    {
        if (elements.Count == 0)
        {
            Console.WriteLine("Стек пустой");
            return default(T);
        }

        T max = elements[0];
        foreach (T item in elements)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }
}

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(5);
        stack.Push(3);
        stack.Push(10);

        Console.WriteLine("Верхний элемент: " + stack.Peek());
        Console.WriteLine("Максимальный элемент: " + stack.Max());

        stack.Pop();

        Console.WriteLine("Максимальный элемент после того как удалили верхний: " + stack.Max());

        Console.ReadLine();
    }
}

