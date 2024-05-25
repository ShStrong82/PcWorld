namespace App.Domain.Core.Products.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public long Price { get; set; }
    public int ProductCategoryId { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
    public int? DeletedBy { get; set; }
    public string? Description { get; set; }

    public ProductCategory ProductCategory { get; set; }
    //public List<ProductAttribute> ProductAttributes { get; set; }
}
