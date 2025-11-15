public class Cone : GeometricFigure
{
    public double Radius { get; set; }
    public double Height { get; set; }
    
    public Cone(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }
    
    public override double GetSurfaceArea()
    {
        double slantHeight = Math.Sqrt(Radius * Radius + Height * Height);
        return Math.PI * Radius * (Radius + slantHeight);
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Конус (радіус: {Radius}, висота: {Height})");
        base.DisplayInfo();
    }
}