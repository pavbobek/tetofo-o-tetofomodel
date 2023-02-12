using tetofo.Model;
using tetofo.Model.Impl;

namespace tetofo.DesignPattern.Impl;

public class DataFactory : IDataFactory
{
    public IData Create((ISet<Tag>?, string?, IList<IData>?)? s)
    {
        return new Data
        {
            Tags =  s?.Item1,
            Payload = s?.Item2,
            Members = s?.Item3
        };
    }
}