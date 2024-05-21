using System.ComponentModel.DataAnnotations;

public class Material
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    [StringLength(50)]
    public string Status { get; set; }

    [StringLength(500)]
    public string Note { get; set; }

    // Navigation property
    public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }

    public Material()
    {
        ProductMaterials = new HashSet<ProductMaterial>();
    }
}