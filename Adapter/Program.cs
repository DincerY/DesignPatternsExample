#region Guru

//Adaptee adaptee = new Adaptee();
//ITarget target = new Adapter(adaptee);

//Console.WriteLine("Adaptee interface is incompatible with the client.");
//Console.WriteLine("But with adapter client can call it's method.");

//Console.WriteLine(target.GetRequest());

//public interface ITarget
//{
//    string GetRequest();
//}

//class Adaptee
//{
//    public string GetSpecificRequest()
//    {
//        return "Specific request.";
//    }
//}

//class Adapter : ITarget
//{
//    private readonly Adaptee _adaptee;

//    public Adapter(Adaptee adaptee)
//    {
//        this._adaptee = adaptee;
//    }

//    public string GetRequest()
//    {
//        return $"This is '{this._adaptee.GetSpecificRequest()}'";
//    }
//}

#endregion



public interface IRequest
{
    void GetResultText();
}


public class Adapter : IRequest
{
    private readonly ExampleJson _example;
    public Adapter(ExampleJson example)
    {
        _example = example;
    }

    public void GetResultText()
    {
        _example.GetResultJson();
    }
}


public class ExampleJson
{
    public void GetResultJson()
    {
        //
    }

}

public class ExampleXml
{
    public void GetResultXml()
    {
        //
    }

    
}
public class ExampleText : IRequest
{

    public void GetResultText()
    {
        throw new NotImplementedException();
    }
}














