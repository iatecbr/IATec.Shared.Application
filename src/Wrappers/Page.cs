namespace IATec.Shared.Application.Wrappers;

public class Page<T>
{
    public int Length { get; set; }
    public IEnumerable<T>? Rows { get; set; }

    public static Page<T> Set(int length, IEnumerable<T>? rows)
    {
        return new Page<T>
        {
            Length = length,
            Rows = rows
        };
    }
}