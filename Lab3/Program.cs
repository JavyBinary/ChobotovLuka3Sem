using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        var rect = new Rectangle(5, 10);
        var square = new Square(7);
        var circle = new Circle(4);

        var arrayList = new ArrayList { rect, square, circle };

        var list = new System.Collections.Generic.List<Figure> { rect, square, circle };

        Console.WriteLine("Коллекция до сортировки:");
        foreach (var fig in list)
        {
            Console.WriteLine(fig);
        }

        list.Sort();

        Console.WriteLine("\nКоллекция после сортировки по площади:");
        foreach (var fig in list)
        {
            Console.WriteLine(fig);
        }

        var matrix = new SparseMatrix<Figure>();

        matrix[0, 0, 1] = new Circle(3);
        matrix[1, 2, 3] = new Square(5);
        matrix[10, 5, 0] = new Rectangle(2, 4);
        

        Console.WriteLine(matrix);

        var stack = new Stack<Figure>();

        var fig1 = new Circle(2);
        var fig2 = new Square(3);
        var fig3 = new Rectangle(2, 5);
        
        stack.Push(fig1);
        Console.WriteLine($"Push: {fig1}");
        stack.Push(fig2);
        Console.WriteLine($"Push: {fig2}");
        stack.Push(fig3);
        Console.WriteLine($"Push: {fig3}");

        Console.WriteLine("\nСодержимое стека:");
        Console.WriteLine(stack);

        try
        {
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
