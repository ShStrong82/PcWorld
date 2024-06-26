﻿using App.Domain.Core.Products.AppServices;
using App.Domain.Core.Products.DTOs;
using App.Domain.Core.Products.Services;

namespace App.Domain.AppServices.Products;

public class ProductAppService : IProductAppService
{
    private readonly IProductService _productService;
    public ProductAppService(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<ProductDto> GetProduct(int productId, CancellationToken cancellationToken)
    {
        return  await _productService.GetProduct(productId, cancellationToken);
    }

    public async Task<List<ProductDto>?> GetProducts(CancellationToken cancellationToken)
    {
        return await _productService.GetProducts(cancellationToken);
    }

    public async Task<List<ProductDto>?> GetProducts(int categoryId, CancellationToken cancellationToken)
    {
        return await _productService.GetProducts(categoryId, cancellationToken);
    }
}
