using System.ComponentModel.DataAnnotations;

namespace lab1.Models;

/// <summary>
/// Represents a category for organizing photographs.
/// </summary>
public class Category
{
    [Key]
    public int Id { get; set; }
    public string category { get; set; }
    public ICollection<Photograph> ListOfPhotos { get; set; }
}
