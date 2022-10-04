namespace Marketplace.Models;

/// <summary>
/// The filter to take specified amount of entities from the collection.
/// </summary>
public class SizeFilter
{
    private const int DefaultSize = 8;
    private const int MaxSize = 100;

    private int _limit = DefaultSize;

    /// <summary>
    /// Gets or sets the amount of entities to take from collection.
    /// </summary>
    public int Limit
    {
        get => _limit;

        set
        {
            _limit = value switch
            {
                <= 0 => DefaultSize,
                > MaxSize => MaxSize,
                _ => value
            };
        }
    }
}