using System;
using System.Collections.Generic;
using System.Linq;


namespace WebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BrithDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SaleRecord> Sales { get; set; } = new List<SaleRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime brithDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BrithDate = brithDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addSales(SaleRecord sr)
        {
            Sales.Add(sr);
        }

        public void removeSales(SaleRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime inicial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= inicial && sr.Date <= final).Sum(sr => sr.Amount); 
        }
    }
}
