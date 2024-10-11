using System.Collections.Immutable;

namespace DesingPatern;

public class Warehouse
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Location { get; set; }
    public int Capacity { get; set; }
    public bool IsActive { get; set; }

    public class  Builder : WareHouseConsignmentBuilder<Builder>
    {
        
    }
    
    public static Builder New => new Builder();
    
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Location)}: {Location}, {nameof(Capacity)}: {Capacity}";
    }
}

public abstract class WareHouseBuilder
{
     protected Warehouse wareHouse = new();
     public Warehouse Build() => wareHouse;
}

public class WareHouseInfoBuilder<SELF> : WareHouseBuilder where SELF : WareHouseInfoBuilder<SELF>
{
    public SELF Called(string? name)
    {
        wareHouse.Name = name;
        return (SELF)this;
    }
}

public class WareHouseConsignmentBuilder<SELF>
    : WareHouseInfoBuilder<WareHouseConsignmentBuilder<SELF>>
    where SELF : WareHouseConsignmentBuilder<SELF>
{
    public SELF LocationNameIs(string? location)
    {
        wareHouse.Location = location;
        return (SELF)this;
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Warehouse.New
            .Called("Warehouse")
            .LocationNameIs("Punt-arenas")
            .Build();
    }
}