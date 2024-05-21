using System.ComponentModel.DataAnnotations;
using DiamondPlaze.BusinessObject.Models;

public class ProductMaterial
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [Required]
    public Guid MaterialId { get; set; }

    // Navigation properties
    public virtual Product Product { get; set; }
    public virtual Material Material { get; set; }

    public ProductMaterial()
    {
    }
}