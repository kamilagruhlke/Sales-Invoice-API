using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ISet<Invoice> _invoice = new HashSet<Invoice>()
        {
            new Invoice(1, DateTime.UtcNow, "01/01/2022", 1, 10, 23, "Description", "P.H.U Firma")
        };

        public IEnumerable<Invoice> GetAll()
        {
            return _invoice;
        }

        public Invoice GetById(int id)
        {
            return _invoice.SingleOrDefault(x => x.Id == id);
        }

        public Invoice Add(Invoice invoice)
        {
            invoice.Id = _invoice.Count + 1;
            _invoice.Add(invoice);
            return invoice;
        }

        public Invoice Update(Invoice invoice)
        {
            Delete(invoice);
            return Add(invoice);
        }

        public void Delete(Invoice invoice)
        {
            _invoice.Remove(invoice);
        }
    }
}
