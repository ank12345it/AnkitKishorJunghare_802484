using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentService.Models;

namespace PaymentService.Repository
{
    public interface IPaymentRepository
    {
        void Payment_add(Payment item);
        List<Payment> Payment_GetAll();
    }
}
