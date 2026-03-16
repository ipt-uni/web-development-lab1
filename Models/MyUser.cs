using System.ComponentModel.DataAnnotations;

namespace lab1.Models;

/// <summary>
/// Represents a user in the system.
/// </summary>
public class MyUser
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string TaxNumber { get; set; }
    public string TelephoneNumber { get; set; }
    public ICollection<Purchase> ListOfPurchases { get; set; }
}
