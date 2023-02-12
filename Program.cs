using tetofo.Model;
using tetofo.Model.Impl;
namespace tetofo;
public static class Program
{
    public static void Main(string[] args)
    {
        IData data = new Data();
        data.Payload = "Hello TETOFO.";
        Console.WriteLine($"{data}");
    }
}
