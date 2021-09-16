using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MVCMedicineShopProjectFinal.Data.Model;

namespace MVCMedicineShopProjectFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVCMedicineShopProjectFinal.Data.Model.Medicine> Medicine { get; set; }
    }
}
