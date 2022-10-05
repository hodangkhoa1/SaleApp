using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Dbo
{
    public class CategoryRepository : IProductRepository<Category>
    {
        private readonly ProductManagementContext _productManagementContext;

        public CategoryRepository(string connectionString)
        {
            _productManagementContext = new(connectionString);
        }

        public void Create(Category entity)
        {
            _productManagementContext.Categories.Add(entity);
            _productManagementContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var p = _productManagementContext.Categories.Where(p => p.Id == id).FirstOrDefault();

            if (p != null)
            {
                _productManagementContext.Remove(p);
                _productManagementContext.SaveChanges();
            }
        }

        public List<Category> Get()
        {
            return _productManagementContext.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _productManagementContext.Categories.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Category> Search(string name)
        {
            return _productManagementContext.Categories.Where(p => p.Name.Contains(name)).ToList();
        }

        public void Update(Category entity)
        {
            var p = _productManagementContext.Categories.Where(p => p.Id == entity.Id).FirstOrDefault();

            if (p != null)
            {
                p.Name = entity.Name;
                p.Status = entity.Status;
                _productManagementContext.Update(p);
                _productManagementContext.SaveChanges();
            }
        }
    }
}
