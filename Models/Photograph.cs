using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab1.Models;

/// <summary>
/// Represents a photograph in the system.
/// </summary>
public class Photograph
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string File { get; set; }
    public DateTime Date { get; set; }
    public decimal price { get; set; }

    [ForeignKey(nameof(Category))]
    public int CategoryFK { get; set; }
    public Category Category { get; set; }

    public ICollection<Purchase> ListOfPurchases { get; set; }
}
