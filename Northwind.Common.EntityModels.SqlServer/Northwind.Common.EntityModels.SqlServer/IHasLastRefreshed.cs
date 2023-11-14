namespace Northwind.Shared;

public interface IHasLastRefreshed
{
    DateTimeOffset LastRefreshed { get; set; }
}
