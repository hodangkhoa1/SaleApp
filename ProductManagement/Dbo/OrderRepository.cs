using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Dbo
{
    public class OrderRepository : IProductRepository<Order>
    {
        private readonly ProductManagementContext _productManagementContext;

        public OrderRepository(string connectionString)
        {
            _productManagementContext = new(connectionString);
        }

        public void Create(Order entity)
        {
            _productManagementContext.Orders.Add(entity);
            _productManagementContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var p = _productManagementContext.Orders.Where(p => p.Id == id).FirstOrDefault();

            if (p != null)
            {
                _productManagementContext.Orders.Remove(p);
                _productManagementContext.SaveChanges();
            }
        }

        public List<Order> Get()
        {
            return _productManagementContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _productManagementContext.Orders.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Order> Search(string name)
        {
            return _productManagementContext.Orders.Where(p => p.CustomerName.Contains(name)).ToList();
        }

        public void Update(Order entity)
        {
            var p = _productManagementContext.Orders.Where(p => p.Id == entity.Id).FirstOrDefault();

            if (p != null)
            {
                p.Id = entity.Id;
                p.CustomerName = entity.CustomerName;
                p.OrderAddress = entity.OrderAddress;
                p.Price = entity.Price;
                p.OrderDate = entity.OrderDate;
                p.Status = entity.Status;
                _productManagementContext.Update(p);
                _productManagementContext.SaveChanges();
            }
        }
    }
}
