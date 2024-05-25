using App.Domain.Core.Products.DTOs;

namespace App.Domain.Core.Products.Data.Repositories;

public interface IProductQueryRepository
{
    public Task<List<ProductDto>?> GetProducts(CancellationToken cancellationToken);
    public Task<List<ProductDto>?> GetProducts(int categoryId, CancellationToken cancellationToken);
    public Task<ProductDto?> GetProduct(int productId, CancellationToken cancellationToken);
}
