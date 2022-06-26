namespace Quewer.Core.Models;

public class Queser
{
    public long Id { get; set; }
    public string Name { get; set; }

    public Queser(long id, string name)
        : this()
    {
        Id = id;
        Name = name;
    }

    protected Queser() { }
}
