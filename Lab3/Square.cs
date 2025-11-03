public class Square : Rectangle, IPrint
{
    public Square(double side) : base(side, side) {}

    public override string ToString()
    {
        return $"Квадрат (сторона: {Width}), площадь: {Area():F2}";
    }
}
