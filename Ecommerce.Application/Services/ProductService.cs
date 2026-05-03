using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ecommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
        public Task<List<Product>> GetAllAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task AddAsync(Product product)
        {
            return _repo.AddAsync(product);
        }
    }
}
