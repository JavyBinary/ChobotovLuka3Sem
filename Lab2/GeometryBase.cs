public abstract class GeometricFigure
{
    public abstract double Area { get; }
    public override abstract string ToString();
}

public interface IPrint
{
    void Print();
}
