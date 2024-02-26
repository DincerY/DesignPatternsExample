#region Guru

//var context = new Context();

//Console.WriteLine("Client: Strategy is set to normal sorting.");
//context.SetStrategy(new ConcreteStrategyA());
//context.DoSomeBusinessLogic();

//Console.WriteLine();

//Console.WriteLine("Client: Strategy is set to reverse sorting.");
//context.SetStrategy(new ConcreteStrategyB());
//context.DoSomeBusinessLogic();

//class Context
//{
//    private IStrategy _strategy;

//    public Context()
//    { }

//    public Context(IStrategy strategy)
//    {
//        this._strategy = strategy;
//    }

//    public void SetStrategy(IStrategy strategy)
//    {
//        this._strategy = strategy;
//    }

//    public void DoSomeBusinessLogic()
//    {
//        Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
//        var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

//        string resultStr = string.Empty;
//        foreach (var element in result as List<string>)
//        {
//            resultStr += element + ",";
//        }

//        Console.WriteLine(resultStr);
//    }
//}

//public interface IStrategy
//{
//    object DoAlgorithm(object data);
//}

//class ConcreteStrategyA : IStrategy
//{
//    public object DoAlgorithm(object data)
//    {
//        var list = data as List<string>;
//        list.Sort();

//        return list;
//    }
//}

//class ConcreteStrategyB : IStrategy
//{
//    public object DoAlgorithm(object data)
//    {
//        var list = data as List<string>;
//        list.Sort();
//        list.Reverse();

//        return list;
//    }
//}

#endregion

Context context = new();
context.SetStrategy(new StrategyB());
context.RunAlgo();

public class Context
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void RunAlgo()
    {
        _strategy.Do();
    }
    
}


public interface IStrategy
{
    public void Do();
}

public class StrategyA : IStrategy
{
    public void Do()
    {
        Console.WriteLine("Sorun A mantığı ile çözüldü");
    }
}

public class StrategyB : IStrategy
{
    public void Do()
    {
        Console.WriteLine("Sorun B mantığı ile çözüldü");
    }
}



