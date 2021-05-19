using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;
using WebMvc.Models.Enums;

namespace WebMvc.Data
{
    public class SeedingService
    {
        private WebMvcContext _context;

        public SeedingService(WebMvcContext context)
        {
            _context = context;
        }

        public void seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SaleRecords.Any())
            {
                return; //DB Caso ja tiver algo nas planilhas
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Fernando Jorge", "FF@gmail.com",new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "João Victor", "JV@gmail.com", new DateTime(1995, 6, 21), 1200.0, d1);
            Seller s3 = new Seller(3, "Julia Garcia", "JG@gmail.com", new DateTime(1992, 5, 01), 1900.0, d3);
            Seller s4 = new Seller(4, "Miguel Arcan", "MA@gmail.com", new DateTime(2000, 12, 31), 3000.0, d3);
            Seller s5 = new Seller(5, "Gabriel ILidio", "GI@gmail.com", new DateTime(1999, 4, 07), 10000.0, d2);
            Seller s6 = new Seller(6, "Marcio Luiz", "ML@gmail.com", new DateTime(1988, 7, 22), 1900.0, d2);
            Seller s7 = new Seller(7, "Isadora Lima", "IL@gmail.com", new DateTime(1999, 10, 15), 9000.0, d4);

            SaleRecord r1 = new SaleRecord(1, new DateTime(2020, 10, 10), 13000.0, SaleStatus.Billed, s1);
            SaleRecord r2 = new SaleRecord(2, new DateTime(2019, 08, 11), 51000.0, SaleStatus.Billed, s2);
            SaleRecord r3 = new SaleRecord(3, new DateTime(2018, 05, 31), 21000.0, SaleStatus.Billed, s4);
            SaleRecord r4 = new SaleRecord(4, new DateTime(2020, 02, 22), 14000.0, SaleStatus.Billed, s3);
            SaleRecord r5 = new SaleRecord(5, new DateTime(2021, 04, 01), 1800000.0, SaleStatus.Billed, s5);
            SaleRecord r6 = new SaleRecord(6, new DateTime(2018, 12, 26), 13000.0, SaleStatus.Billed, s6);
            SaleRecord r7 = new SaleRecord(7, new DateTime(2010, 11, 10), 16000.0, SaleStatus.Billed, s5);
            SaleRecord r8 = new SaleRecord(8, new DateTime(2011, 07, 11), 174000.0, SaleStatus.Billed, s7);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7);
            _context.SaleRecords.AddRange(r1, r2, r3, r4, r5, r6, r7, r8);

            _context.SaveChanges();

        }
    }


}
