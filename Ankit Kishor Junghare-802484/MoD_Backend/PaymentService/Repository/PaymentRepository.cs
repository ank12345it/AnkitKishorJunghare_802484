using PaymentService.Models;
using PaymentService.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Repository
{
    public class PaymentRepository:IPaymentRepository
    {
        private readonly paymentContext _context;
        public PaymentRepository(paymentContext Context)
        {
            _context = Context;
        }

        public void Payment_add(Payment item)
        {
            _context.Payment.Add(item);
          //_context.SaveChange
        }

        public List<Payment> Payment_GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
