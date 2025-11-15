using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== ЗАВДАННЯ 2: СИСТЕМА УПРАВЛІННЯ ДОКУМЕНТАМИ ===");
        Console.WriteLine();

        // 2.1 Створення масиву об'єктів класу Документ
        Document[] documents = new Document[]
        {
            new Document("Звіт про продажі", 25, 2),
            new Document("Договір про надання послуг", 15, 1),
            new Document("Інструкція з експлуатації", 40, 4),
            new Document("Фінансовий звіт", 30, 1),
            new Document("Довідка", 5, 3),
            new Document("Технічне завдання", 20, 2),
            new Document("Презентація", 12, 3),
            new Document("Аналітичний огляд", 35, 2)
        };

        Console.WriteLine("2.1 Масив документів (початковий порядок):");
        Console.WriteLine("==========================================");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
        Console.WriteLine();

        // 2.1 Сортування за кількістю сторінок (IComparable)
        Array.Sort(documents);
        
        Console.WriteLine("2.1 Документи, відсортовані за кількістю сторінок (IComparable):");
        Console.WriteLine("==============================================================");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
        Console.WriteLine();

        // 2.2 Сортування за важливістю та кількістю сторінок (IComparer)
        Array.Sort(documents, new DocumentComparer());
        
        Console.WriteLine("2.2 Документи, відсортовані за важливістю та кількістю сторінок (IComparer):");
        Console.WriteLine("==========================================================================");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
        Console.WriteLine();

        // 2.3 Використання IEnumerable через DocumentCollection
        Console.WriteLine("2.3 Робота з IEnumerable через DocumentCollection:");
        Console.WriteLine("==================================================");
        
        DocumentCollection documentCollection = new DocumentCollection();
        documentCollection.AddRange(documents);
        
        Console.WriteLine("Початкова колекція документів:");
        documentCollection.DisplayAll();

        // Сортування за кількістю сторінок
        documentCollection.SortByPageCount();
        Console.WriteLine("Колекція після сортування за кількістю сторінок:");
        documentCollection.DisplayAll();

        // Сортування за важливістю та кількістю сторінок
        documentCollection.SortByImportanceAndPageCount();
        Console.WriteLine("Колекція після сортування за важливістю та кількістю сторінок:");
        documentCollection.DisplayAll();

        // Демонстрація використання foreach через IEnumerable
        Console.WriteLine("Демонстрація роботи foreach з IEnumerable:");
        Console.WriteLine("==========================================");
        int counter = 1;
        foreach (Document doc in documentCollection)
        {
            Console.WriteLine($"{counter}. {doc}");
            counter++;
        }
        Console.WriteLine();

        // Додаткові тести
        Console.WriteLine("Додаткові тести:");
        Console.WriteLine("=================");
        
        // Тест порівняння двох документів
        Document doc1 = new Document("Тестовий документ 1", 10, 1);
        Document doc2 = new Document("Тестовий документ 2", 20, 2);
        
        Console.WriteLine($"Порівняння '{doc1.Title}' з '{doc2.Title}':");
        Console.WriteLine($"Результат CompareTo: {doc1.CompareTo(doc2)} (0 - рівні, <0 - перший менший, >0 - перший більший)");
        Console.WriteLine();

        // Тест компаратора
        DocumentComparer comparer = new DocumentComparer();
        Console.WriteLine($"Порівняння через DocumentComparer: {comparer.Compare(doc1, doc2)}");
        Console.WriteLine();

        // Групування за важливістю
        Console.WriteLine("Документи згруповані за важливістю:");
        var groupedByImportance = new Dictionary<int, List<Document>>();
        foreach (var doc in documentCollection)
        {
            if (!groupedByImportance.ContainsKey(doc.Importance))
                groupedByImportance[doc.Importance] = new List<Document>();
            groupedByImportance[doc.Importance].Add(doc);
        }

        foreach (var group in groupedByImportance)
        {
            Console.WriteLine($"Важливість {group.Key}:");
            foreach (var doc in group.Value)
            {
                Console.WriteLine($"  - {doc.Title} ({doc.PageCount} стор.)");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}