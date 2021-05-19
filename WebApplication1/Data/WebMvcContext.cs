﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebMvc.Models
{
    public class WebMvcContext : DbContext
    {
        public WebMvcContext (DbContextOptions<WebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SaleRecord> SaleRecords { get; set; }

    }
}
