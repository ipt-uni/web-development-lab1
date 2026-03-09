using System.ComponentModel.DataAnnotations;

namespace lab1.Models;

/// <summary>
/// Represents a category for organizing photographs.
/// </summary>
public class Category
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Required(ErrorMessage = "Name can't be empty")]
    [Display(Name = "Name of the Category")]
    public string Name { get; set; } = "";
    public ICollection<Photograph> ListOfPhotos { get; set; }
}
