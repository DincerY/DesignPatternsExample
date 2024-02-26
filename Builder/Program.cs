#region Guru

//var director = new Director();
//var builder = new ConcreteBuilder();
//director.Builder = builder;

//Console.WriteLine("Standard basic product:");
//director.BuildMinimalViableProduct();
//Console.WriteLine(builder.GetProduct().ListParts());

//Console.WriteLine("Standard full featured product:");
//director.BuildFullFeaturedProduct();
//Console.WriteLine(builder.GetProduct().ListParts());

//Console.WriteLine("Custom product:");
//builder.BuildPartA();
//builder.BuildPartC();
//Console.Write(builder.GetProduct().ListParts());


//public interface IBuilder
//{
//    void BuildPartA();

//    void BuildPartB();

//    void BuildPartC();
//}

//public class ConcreteBuilder : IBuilder
//{
//    private Product _product = new Product();

//    public ConcreteBuilder()
//    {
//        this.Reset();
//    }

//    public void Reset()
//    {
//        this._product = new Product();
//    }

//    public void BuildPartA()
//    {
//        this._product.Add("PartA1");
//    }

//    public void BuildPartB()
//    {
//        this._product.Add("PartB1");
//    }

//    public void BuildPartC()
//    {
//        this._product.Add("PartC1");
//    }

//    public Product GetProduct()
//    {
//        Product result = this._product;

//        this.Reset();

//        return result;
//    }
//}

//public class Product
//{
//    private List<object> _parts = new List<object>();

//    public void Add(string part)
//    {
//        this._parts.Add(part);
//    }

//    public string ListParts()
//    {
//        string str = string.Empty;

//        for (int i = 0; i < this._parts.Count; i++)
//        {
//            str += this._parts[i] + ", ";
//        }

//        str = str.Remove(str.Length - 2); // removing last ",c"

//        return "Product parts: " + str + "\n";
//    }
//}

//public class Director
//{
//    private IBuilder _builder;

//    public IBuilder Builder
//    {
//        set { _builder = value; }
//    }

//    public void BuildMinimalViableProduct()
//    {
//        this._builder.BuildPartA();
//    }

//    public void BuildFullFeaturedProduct()
//    {
//        this._builder.BuildPartA();
//        this._builder.BuildPartB();
//        this._builder.BuildPartC();
//    }
//}


#endregion

Director director = new Director(new Builder());
Ev ev = director.CamliEv();
Ev ev2 = director.HavuzluCamliEv();
Ev ev3 = director.GarajliHavuzluCamliEv();
Console.WriteLine("");

public interface IBuilder
{
    IBuilder HavuzEkle();
    IBuilder BahceEkle();
    IBuilder CamEkle();
    IBuilder GarajEkle();
    Ev EviGetir();
}

public class Builder : IBuilder
{
    private Ev _ev = new Ev();
 
    public IBuilder HavuzEkle()
    {
        _ev.Havuz = true;
        return this;
    }

    public IBuilder BahceEkle()
    {
        _ev.Bahce = true;
        return this;
    }

    public IBuilder CamEkle()
    {
        _ev.Cam = true;
        return this;
    }

    public IBuilder GarajEkle()
    {
        _ev.Garaj = true;
        return this;
    }

    public Ev EviGetir()
    {
        var ev = _ev;
        _ev = new Ev();
        return ev;
    }
}


public class Director
{
    private IBuilder _builder;
    public Director(IBuilder builder)
    {
        _builder = builder;
    }
    public Ev CamliEv()
    {
        return _builder.CamEkle().EviGetir();
    }

    public Ev HavuzluCamliEv()
    {
        return _builder.CamEkle().HavuzEkle().EviGetir();

    }

    public Ev GarajliHavuzluCamliEv()
    {
        return _builder.GarajEkle().HavuzEkle().CamEkle().EviGetir();
    }
}



public class Ev
{
    public string Adi { get; set; }
    public bool Havuz { get; set; }
    public bool Bahce { get; set; }
    public bool Cam { get; set; }
    public bool Garaj { get; set; }
}



