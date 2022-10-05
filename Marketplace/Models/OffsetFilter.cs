using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models;

public class OffsetFilter : SizeFilter
{
    /// <summary>
    /// Gets or sets the amount of entities to skip before taking.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "Field value should be in a range from 0 to 2 147 483 647")]
    public int From { get; set; } = 1;
}