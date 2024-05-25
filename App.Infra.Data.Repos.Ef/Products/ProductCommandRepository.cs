using App.Domain.Core.Products.Data.Repositories;
using App.Domain.Core.Products.DTOs;
using App.Domain.Core.Products.Entities;
using App.Infra.Data.Db.SqlServer.Ef.DbCtx;

namespace App.Infra.Data.Repos.Ef.Products;

public class ProductCommandRepository : IProductCommandRepository
{
    private readonly AppDbContext _context;
    public ProductCommandRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task Add(ProductDto product, CancellationToken cancellationToken)
    {
        Product newProduct = new()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            ProductCategoryId = product.ProductCategoryId
        };

        await _context.Products.AddAsync(newProduct, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task Delete(int productId, CancellationToken cancellationToken)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == productId);
        if (product != null)
            _context.Products.Remove(product);
        await _context.SaveChangesAsync();
    }

    public async Task Update(ProductDto product, CancellationToken cancellationToken)
    {
        var oldProduct = _context.Products.FirstOrDefault(x => x.Id == product.Id);
        if (oldProduct != null) 
        {
            oldProduct.Name = product.Name;
            oldProduct.Description = product.Description;
            oldProduct.Price = product.Price;
            oldProduct.ProductCategoryId = product.ProductCategoryId;
        }
        await _context.SaveChangesAsync(cancellationToken);
    }
}
