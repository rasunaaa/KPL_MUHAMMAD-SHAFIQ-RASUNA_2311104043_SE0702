using System;
using System.Collections.Generic;

// Interface Observer
public interface IObserver
{
    void Update(string message);
}

// Interface Subject
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
}

// Concrete Subject
public class NewsAgency : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer) => observers.Add(observer);
    public void Detach(IObserver observer) => observers.Remove(observer);

    public void Notify(string message)
    {
        foreach (var observer in observers)
            observer.Update(message);
    }

    // Trigger perubahan
    public void AddNews(string news)
    {
        Console.WriteLine("News Added: " + news);
        Notify(news);
    }
}

// Concrete Observer
public class NewsReader : IObserver
{
    private string _name;

    public NewsReader(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received news: {message}");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Membuat subject
        var agency = new NewsAgency();

        // Membuat observers
        var reader1 = new NewsReader("Shafiq");
        var reader2 = new NewsReader("Alya");

        // Attach observers
        agency.Attach(reader1);
        agency.Attach(reader2);

        // Tambahkan berita
        agency.AddNews("Design Pattern Observer Telah Dipahami!");
    }
}
