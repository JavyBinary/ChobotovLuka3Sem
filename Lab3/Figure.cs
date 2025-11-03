public interface IPrint
{
    void Print();
}

public abstract class Figure : IComparable<Figure>
{
    public abstract double Area();

    public int CompareTo(Figure? other)
    {
        if (other == null)
        {
            return 1;
        }
        return this.Area().CompareTo(other.Area());
    }
}
