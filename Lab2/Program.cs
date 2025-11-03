class Program
{
    static void Main(string[] args)
    {
        IPrint[] figures = new IPrint[]
        {
            new Rectangle(3, 4),
            new Square(5),
            new Circle(2.5),
        };

        foreach (var figure in figures)
        {
            figure.Print();
        }
    }
}
