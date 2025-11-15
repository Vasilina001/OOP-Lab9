public class Cube : GeometricFigure
{
    public double Side { get; set; }
    
    public Cube(double side)
    {
        Side = side;
    }
    
    public override double GetSurfaceArea()
    {
        return 6 * Side * Side;
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Куб (сторона: {Side})");
        base.DisplayInfo();
    }
}