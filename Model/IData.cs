namespace tetofo.Model;
public interface IData
{
    ISet<Tag>? Tags {get; set;}
    string? Payload {get; set;}
    IList<IData>? Members {get; set;}
}