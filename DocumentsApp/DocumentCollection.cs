using System;
using System.Collections;
using System.Collections.Generic;

// 2.3 Реалізація IEnumerable для колекції документів
public class DocumentCollection : IEnumerable<Document>
{
    private List<Document> documents = new List<Document>();
    
    public void AddDocument(Document document)
    {
        documents.Add(document);
    }
    
    public void AddRange(Document[] documentsArray)
    {
        documents.AddRange(documentsArray);
    }
    
    public IEnumerator<Document> GetEnumerator()
    {
        return documents.GetEnumerator();
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public void SortByPageCount()
    {
        documents.Sort();
    }
    
    public void SortByImportanceAndPageCount()
    {
        documents.Sort(new DocumentComparer());
    }
    
    public void DisplayAll()
    {
        Console.WriteLine("Список документів:");
        Console.WriteLine(new string('-', 50));
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
        Console.WriteLine();
    }
    
    public int Count => documents.Count;
}