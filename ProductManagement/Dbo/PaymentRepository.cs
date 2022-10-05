using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Dbo
{
    public class PaymentRepository : IProductRepository<Payment>
    {
        private readonly ProductManagementContext _productManagementContext;

        public PaymentRepository(string connectionString)
        {
            _productManagementContext = new(connectionString);
        }

        public void Create(Payment entity)
        {
            _productManagementContext.Payments.Add(entity);
            _productManagementContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var p = _productManagementContext.Payments.Where(p => p.Id == id).FirstOrDefault();

            if (p != null)
            {
                _productManagementContext.Payments.Remove(p);
                _productManagementContext.SaveChanges();
            }
        }

        public List<Payment> Get()
        {
            return _productManagementContext.Payments.ToList();
        }

        public Payment GetById(int id)
        {
            return _productManagementContext.Payments.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Payment> Search(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Payment entity)
        {
            var p = _productManagementContext.Payments.Where(p => p.Id == entity.Id).FirstOrDefault();

            if (p != null)
            {
                p.Id = entity.Id;
                p.PayTime = entity.PayTime;
                p.Amount = entity.Amount;
                p.PayType = entity.PayType;
                _productManagementContext.Update(p);
                _productManagementContext.SaveChanges();
            }
        }
    }
}
