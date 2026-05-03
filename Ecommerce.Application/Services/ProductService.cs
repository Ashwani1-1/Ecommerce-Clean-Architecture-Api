using System;
using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<List<Product>> GetAllAsync()
        {
            var products = await _repo.GetAllAsync();
            return _mapper.Map<List<Product>>(products);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var product =await _repo.GetByIdAsync(id);
            return _mapper.Map<Product>(product);

        }

        public async Task AddAsync(CreateProductDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            await _repo.AddAsync(product);
        }
    }
}
