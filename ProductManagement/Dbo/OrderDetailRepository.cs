using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Dbo
{
    public class OrderDetailRepository : IProductRepository<OrderDetail>
    {
        private readonly ProductManagementContext _productManagementContext;

        public OrderDetailRepository(string connectionString)
        {
            _productManagementContext = new(connectionString);
        }

        public void Create(OrderDetail entity)
        {
            _productManagementContext.OrderDetails.Add(entity);
            _productManagementContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var p = _productManagementContext.OrderDetails.Where(p => p.OrderId == id).FirstOrDefault();

            if (p != null)
            {
                _productManagementContext.OrderDetails.Remove(p);
                _productManagementContext.SaveChanges();
            }
        }

        public List<OrderDetail> Get()
        {
            return _productManagementContext.OrderDetails.ToList();
        }

        public OrderDetail GetById(int id)
        {
            return _productManagementContext.OrderDetails.Where(p => p.OrderId == id).FirstOrDefault();
        }

        public List<OrderDetail> CheckOrderDetail(int id)
        {
            return _productManagementContext.OrderDetails.Where(p => p.ProductId == id).ToList();
        }

        public List<OrderDetail> Search(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDetail entity)
        {
            var p = _productManagementContext.OrderDetails.Where(p => p.Id == entity.Id).FirstOrDefault();

            if (p != null)
            {
                p.ProductId = entity.ProductId;
                p.OrderId = entity.OrderId;
                p.Quantity = entity.Quantity;
                p.Price = entity.Price;
                _productManagementContext.Update(p);
                _productManagementContext.SaveChanges();
            }
        }
    }
}
