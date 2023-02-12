using tetofo.Model;

namespace tetofo.DesignPattern;

public interface IDataFactory : IFactory<(ISet<Tag>?, string?, IList<IData>?)?, IData>{}