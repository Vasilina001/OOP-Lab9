using System;
using System.Collections.Generic;

// 2.2 Реалізація IComparer для порівняння за кількістю сторінок та важливістю
public class DocumentComparer : IComparer<Document>
{
    public int Compare(Document x, Document y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        
        // Спочатку порівнюємо за важливістю (менше число - вища важливість)
        int importanceComparison = x.Importance.CompareTo(y.Importance);
        if (importanceComparison != 0)
            return importanceComparison;
        
        // Якщо важливість однакова - порівнюємо за кількістю сторінок
        return x.PageCount.CompareTo(y.PageCount);
    }
}