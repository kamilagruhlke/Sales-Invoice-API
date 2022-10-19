using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public int Quantity { get; set; }
        public decimal NetValue { get; set; }
        public int Vat { get; set; }
        public string Description { get; set; }
        public string Contractor { get; set; }

        public Invoice()
        {
        }

        public Invoice(int id, DateTime date, int number, int quantity, decimal netValue,int vat, string description,
            string contractor)
        {
            Id = id;
            Date = date;
            Number = number;
            Quantity = quantity;
            NetValue = netValue;
            Vat = vat;
            Description = description;
            Contractor = contractor;
        }
    }
}
