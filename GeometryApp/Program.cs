using System;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== ЗАВДАННЯ 1: ГЕОМЕТРИЧНІ ФІГУРИ ===");
            Console.WriteLine();

            // Демонстрація роботи через інтерфейс ITrigonometricFigure
            Console.WriteLine("1. Демонстрація через інтерфейс ITrigonometricFigure:");
            Console.WriteLine("---------------------------------------------------");
            
            ITrigonometricFigure[] figures = new ITrigonometricFigure[]
            {
                new Cylinder(3, 5),
                new Cube(4),
                new Cone(3, 4),
                new Cylinder(2, 8),
                new Cube(6)
            };

            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine($"Фігура {i + 1}: Площа поверхні = {figures[i].GetSurfaceArea():F2}");
            }

            Console.WriteLine();
            
            // Демонстрація роботи через абстрактний клас GeometricFigure
            Console.WriteLine("2. Демонстрація через абстрактний клас GeometricFigure:");
            Console.WriteLine("------------------------------------------------------");
            
            GeometricFigure[] geometricFigures = new GeometricFigure[]
            {
                new Cylinder(3, 5),
                new Cube(4),
                new Cone(3, 4),
                new Cylinder(1.5, 10),
                new Cube(2.5),
                new Cone(2, 6)
            };

            foreach (var figure in geometricFigures)
            {
                figure.DisplayInfo();
                Console.WriteLine();
            }

            // Додатковий приклад з конкретними обчисленнями
            Console.WriteLine("3. Детальні розрахунки:");
            Console.WriteLine("----------------------");
            
            Cylinder cylinder = new Cylinder(5, 10);
            Cube cube = new Cube(7);
            Cone cone = new Cone(4, 9);

            Console.WriteLine("Циліндр:");
            Console.WriteLine($"  Радіус: 5, Висота: 10");
            Console.WriteLine($"  Формула: 2 * π * r * (r + h) = 2 * 3.14159 * 5 * (5 + 10)");
            Console.WriteLine($"  Результат: {cylinder.GetSurfaceArea():F2}");
            Console.WriteLine();

            Console.WriteLine("Куб:");
            Console.WriteLine($"  Сторона: 7");
            Console.WriteLine($"  Формула: 6 * a² = 6 * 7 * 7");
            Console.WriteLine($"  Результат: {cube.GetSurfaceArea():F2}");
            Console.WriteLine();

            Console.WriteLine("Конус:");
            Console.WriteLine($"  Радіус: 4, Висота: 9");
            double slantHeight = Math.Sqrt(4 * 4 + 9 * 9);
            Console.WriteLine($"  Твірна: √(r² + h²) = √(4² + 9²) = {slantHeight:F2}");
            Console.WriteLine($"  Формула: π * r * (r + l) = 3.14159 * 4 * (4 + {slantHeight:F2})");
            Console.WriteLine($"  Результат: {cone.GetSurfaceArea():F2}");
            Console.WriteLine();

            // Перевірка поліморфізму
            Console.WriteLine("4. Перевірка поліморфізму:");
            Console.WriteLine("-------------------------");
            
            GeometricFigure polyFigure1 = new Cylinder(2, 3);
            GeometricFigure polyFigure2 = new Cube(5);
            GeometricFigure polyFigure3 = new Cone(3, 4);

            Console.WriteLine("Поліморфізм через базовий клас:");
            polyFigure1.DisplayInfo();
            polyFigure2.DisplayInfo();
            polyFigure3.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}