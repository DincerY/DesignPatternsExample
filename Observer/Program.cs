#region Guru

//var subject = new Subject();
//var observerA = new ConcreteObserverA();
//subject.Attach(observerA);

//var observerB = new ConcreteObserverB();
//subject.Attach(observerB);

//subject.SomeBusinessLogic();
//subject.SomeBusinessLogic();

//subject.Detach(observerB);

//subject.SomeBusinessLogic();

//public interface IObserver
//{
//    void Update(ISubject subject);
//}

//public interface ISubject
//{
//    void Attach(IObserver observer);

//    void Detach(IObserver observer);

//    void Notify();
//}

//public class Subject : ISubject
//{
//    public int State { get; set; } = -0;

//    private List<IObserver> _observers = new List<IObserver>();

//    public void Attach(IObserver observer)
//    {
//        Console.WriteLine("Subject: Attached an observer.");
//        this._observers.Add(observer);
//    }

//    public void Detach(IObserver observer)
//    {
//        this._observers.Remove(observer);
//        Console.WriteLine("Subject: Detached an observer.");
//    }

//    public void Notify()
//    {
//        Console.WriteLine("Subject: Notifying observers...");

//        foreach (var observer in _observers)
//        {
//            observer.Update(this);
//        }
//    }

//    public void SomeBusinessLogic()
//    {
//        Console.WriteLine("\nSubject: I'm doing something important.");
//        this.State = new Random().Next(0, 10);

//        Thread.Sleep(15);

//        Console.WriteLine("Subject: My state has just changed to: " + this.State);
//        this.Notify();
//    }
//}

//class ConcreteObserverA : IObserver
//{
//    public void Update(ISubject subject)
//    {
//        if ((subject as Subject).State < 3)
//        {
//            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
//        }
//    }
//}

//class ConcreteObserverB : IObserver
//{
//    public void Update(ISubject subject)
//    {
//        if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
//        {
//            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
//        }
//    }
//}

#endregion

Musteri musteri = new();
Musteri2 musteri2 = new();
Musteri3 musteri3 = new();


Market market = new();
market.Attach(musteri);
market.Attach(musteri2);

market.Notify();


public interface ISubject
{
    void Attach(IObserver observer);

    void Detach(IObserver observer);

    void Notify();
}


public interface IObserver
{
    void Update(ISubject subject);
}


public class Market : ISubject
{
    public List<IObserver> Observers = new List<IObserver>();
    public void Attach(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in Observers)
        {
            observer.Update(this);
        }
    }
}

public class Musteri : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine("müsteri1 tetiklendi");
    }
}

public class Musteri2 : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine("müsteri2 tetiklendi");

    }
}
public class Musteri3 : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine("müsteri3 tetiklendi");
    }
}