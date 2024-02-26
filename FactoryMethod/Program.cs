#region TechBuddy

//PizzaStore ankaraPizzaStore = new AnkaraPizzaStore();
//PizzaStore istanbulPizzaStore = new IstanbulPizzaStore();

//IPizza cheesePizza = ankaraPizzaStore.OrderPizza("cheese"); 

//public interface IPizza
//{
//    void Prepare();
//    void Bake();
//    void Cut();
//}

//public class CheesePizza : IPizza
//{
//    public void Prepare()
//    {
//        Console.WriteLine("Cheese Pizza Prepared");
//    }

//    public void Bake()
//    {
//        Console.WriteLine("Cheese Pizza Baked");
//    }

//    public void Cut()
//    {
//        Console.WriteLine("Cheese Pizza But");
//    }
//}

//public class VeggiPizza : IPizza
//{
//    public void Prepare()
//    {
//        Console.WriteLine("Veggi Pizza Prepared");
//    }

//    public void Bake()
//    {
//        Console.WriteLine("Veggi Pizza Baked");
//    }

//    public void Cut()
//    {
//        Console.WriteLine("Veggi Pizza But");
//    }
//}

////Yapılan her iş base classta fakat pizzanın oluşturulma işlemi alt sınıflara yüklendi
////aslında bu design pattern nın amacıda tam olarak budur.
//public abstract class PizzaStore
//{
//    protected abstract IPizza CreatePizza(string type);
//    public IPizza OrderPizza(string type)
//    {
//        IPizza pizza = CreatePizza(type);
        
//        pizza.Prepare();
//        pizza.Bake();
//        pizza.Cut();

//        return pizza; 
//    }
//}

////Pizzanın oluşturulma işini alt sınıflara verdik
//public class AnkaraPizzaStore : PizzaStore 
//{
//    protected override IPizza CreatePizza(string type)
//    {
//        return type switch
//        {
//            "cheese" => new CheesePizza(),
//            "veggi" => new VeggiPizza(),
//            _ => throw new ArgumentException("Invalid pizza type",nameof(type))
//        };
//    }
//}



//public class IstanbulPizzaStore : PizzaStore
//{
//    protected override IPizza CreatePizza(string type)
//    {
//        return type switch
//        {
//            "cheese" => new CheesePizza(),
//            "veggi" => new VeggiPizza(),
//            _ => throw new ArgumentException("Invalid pizza type", nameof(type))
//        };
//    }
//}

#endregion

#region Guru

//Logistic logistic = new RoadLogistic();
//logistic.CreateTransport();
//logistic.StopTransport();

//Logistic logistic2 = new SeaLogistic();
//logistic2.CreateTransport();
//logistic2.StopTransport();


//public interface ITrasport
//{
//    public string Deliver { get; }
//}

//public class Truck : ITrasport
//{
//    public string Deliver => "Kamyon";
//}

//public class Ship : ITrasport
//{
//    public string Deliver => "Deniz";
//}


//public abstract class Logistic
//{
//    protected abstract ITrasport PlanDelivery();
//    private ITrasport _deliverType => PlanDelivery();
//    public void CreateTransport()
//    {
//        Console.WriteLine($"{_deliverType.Deliver} bu tipte bir transfer oluşturuldu");
//    }

//    public void StopTransport()
//    {
//        Console.WriteLine($"{_deliverType.Deliver} bu tipte bir transfer durduruldu");
//    }
//}

//public class RoadLogistic : Logistic
//{
//    protected override ITrasport PlanDelivery()
//    {
//        return new Truck();
//    }
//}


//public class SeaLogistic : Logistic
//{
//    protected override ITrasport PlanDelivery()
//    {
//        return new Ship();
//    }
//}

#endregion

DatabaseCreator creator = new MongoCreator();
creator.CreateConnection();
creator.StopConnection();


DatabaseCreator creator2 = new MsSqlCreator();
creator2.CreateConnection();
creator2.StopConnection();
     

public interface IDatabase
{
    public string Name { get;}
}

public class MongoDb : IDatabase
{
    public string Name => "Mongo Database";
}

public class MsSqlDb : IDatabase
{
    public string Name => "MsSql Database";
}

public abstract class DatabaseCreator
{
    protected abstract IDatabase FactoryMethod();
    private IDatabase GetDatabase => FactoryMethod();
    public void CreateConnection()
    {
        Console.WriteLine($"{GetDatabase.Name}  Connection is created");
    }
    public void StopConnection()
    {
        Console.WriteLine($"{GetDatabase.Name}  Connection is stopped");
    }
}

public class MongoCreator : DatabaseCreator
{
    protected override IDatabase FactoryMethod()
    {
        return new MongoDb();
    }
}

public class MsSqlCreator : DatabaseCreator
{
    protected override IDatabase FactoryMethod()
    {
        return new MsSqlDb();
    }
}





