public abstract class GeometricFigure : ITrigonometricFigure
{
    public abstract double GetSurfaceArea();
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Площа поверхні: {GetSurfaceArea():F2}");
    }
}