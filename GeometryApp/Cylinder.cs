public class Cylinder : GeometricFigure
{
    public double Radius { get; set; }
    public double Height { get; set; }
    
    public Cylinder(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }
    
    public override double GetSurfaceArea()
    {
        return 2 * Math.PI * Radius * (Radius + Height);
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Циліндр (радіус: {Radius}, висота: {Height})");
        base.DisplayInfo();
    }
}