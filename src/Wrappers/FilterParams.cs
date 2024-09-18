namespace IATec.Shared.Application.Wrappers;

public abstract class FilterParams
{
    public int Page { get; set; } = 0;
    public int Limit { get; set; } = 20;
    public string OrderBy { get; set; } = "Id";
    public string OrderDirection { get; set; } = "asc";
}