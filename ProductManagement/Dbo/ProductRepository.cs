using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Dbo
{
    public class ProductRepository : IProductRepository<Product>
    {
        private readonly ProductManagementContext _productManagementContext;

        public ProductRepository(string connectionString)
        {
            _productManagementContext = new(connectionString);
        }

        public void Create(Product entity)
        {
            _productManagementContext.Products.Add(entity);
            _productManagementContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var p = _productManagementContext.Products.Where(p => p.Id == id).FirstOrDefault();

            if (p != null)
            {
                _productManagementContext.Remove(p);
                _productManagementContext.SaveChanges();
            }
        }

        public List<Product> Get()
        {
            return _productManagementContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _productManagementContext.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Product> Search(string name)
        {
            return _productManagementContext.Products.Where(p => p.Name.Contains(name)).ToList();
        }

        public List<Product> CheckProduct(int id)
        {
            return _productManagementContext.Products.Where(p => p.CategoryId == id).ToList();
        }

        public void Update(Product entity)
        {
            var p = _productManagementContext.Products.Where(p => p.Id == entity.Id).FirstOrDefault();

            if (p != null)
            {
                p.Name = entity.Name;
                p.Price = entity.Price;
                p.Status = entity.Status;
                p.CategoryId = entity.CategoryId;
                p.CreatedDate = entity.CreatedDate;
                _productManagementContext.Update(p);
            }
        }
    }
}
