using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models;

public class Counter
{
    public Counter()
    {
        
    }
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Income { get; set; }
    
    
    [Required]
    public string Status { get; set; }
    
    public virtual Account? Account { get; set; }

    
}