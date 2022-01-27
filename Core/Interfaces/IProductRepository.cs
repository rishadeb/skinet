using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync(); // only ever read from what you are sending back
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync(); // only ever read from what you are sending back
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync(); // only ever read from what you are sending back
    }
}