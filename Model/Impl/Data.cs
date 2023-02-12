using System;
using System.Text.Json;

namespace tetofo.Model.Impl;
public class Data : IData
{
    public ISet<Tag>? Tags { get; set; }
    public string? Payload { get; set; }
    public IList<IData>? Members { get; set; }
    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}