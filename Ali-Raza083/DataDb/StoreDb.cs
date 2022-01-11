using Microsoft.EntityFrameworkCore;
using Ali_Raza083.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ali_Raza083.DataDb
{
    public class StoreDb : DbContext
    {
        public StoreDb(DbContextOptions<StoreDb> options) : base(options)
        {

        }
        public DbSet<OrderModel> orders { get; set; }
    }
}
