using System;

public class Document : IComparable<Document>, IComparable
{
    public string Title { get; set; }
    public int PageCount { get; set; }
    public int Importance { get; set; } // 1 - найвища, 5 - найнижча
    
    public Document(string title, int pageCount, int importance)
    {
        Title = title;
        PageCount = pageCount;
        Importance = importance;
    }
    
    // 2.1 Реалізація IComparable для порівняння за кількістю сторінок
    public int CompareTo(Document other)
    {
        if (other == null) return 1;
        return PageCount.CompareTo(other.PageCount);
    }
    
    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        
        Document otherDocument = obj as Document;
        if (otherDocument != null)
            return this.CompareTo(otherDocument);
        else
            throw new ArgumentException("Object is not a Document");
    }
    
    public override string ToString()
    {
        return $"Документ: {Title}, Сторінок: {PageCount}, Важливість: {Importance}";
    }
}