using App.Domain.Core.Products.Data.Repositories;
using App.Domain.Core.Products.DTOs;
using App.Domain.Core.Products.Services;
using System;
using System.Collections.Generic;
using System.Linq;
namespace App.Domain.Services.Products.Services;

public class ProductService : IProductService
{
    private readonly IProductCommandRepository _productCommandRepository;
    private readonly IProductQueryRepository _productQueryRepository;
    public ProductService(IProductCommandRepository productCommandRepository, IProductQueryRepository productQueryRepository)
    {
       _productCommandRepository = productCommandRepository;
       _productQueryRepository = productQueryRepository;
    }
    public async Task AddProduct(ProductDto product, CancellationToken cancellationToken)
    {
        await _productCommandRepository.Add(product, cancellationToken);
    }

    public async Task DeleteProduct(int productId, CancellationToken cancellationToken)
    {
        var product = _productQueryRepository.GetProduct(productId, cancellationToken);
        if (product != null)
            await _productCommandRepository.Delete(productId, cancellationToken);
        else
            throw new Exception($"ProductId = {productId} does not exist!");
    }

    public async Task<ProductDto> GetProduct(int productId, CancellationToken cancellationToken)
    {
        var product = _productQueryRepository.GetProduct(productId, cancellationToken);
        if (product is null)
            throw new Exception($"ProductId = {productId} does not exist!");

        return await product;
    }

    public async Task<List<ProductDto>?> GetProducts(CancellationToken cancellationToken)
    {
        return await _productQueryRepository.GetProducts(cancellationToken);
    }

    public async Task<List<ProductDto>?> GetProducts(int categoryId, CancellationToken cancellationToken)
    {
        return await _productQueryRepository.GetProducts(categoryId, cancellationToken);
    }

    public async Task UpdateProduct(ProductDto product, CancellationToken cancellationToken)
    {
         await _productCommandRepository.Update(product, cancellationToken);
    }
}
