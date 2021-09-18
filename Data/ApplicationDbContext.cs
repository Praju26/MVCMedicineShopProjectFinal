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
        public DbSet<MVCMedicineShopProjectFinal.Data.Model.Medical_Enterpriser> Medical_Enterpriser { get; set; }
        public DbSet<MVCMedicineShopProjectFinal.Data.Model.Customer> Customer { get; set; }
        public object MedicineDetails { get; set; }
        public object Medicines { get; set; }
    }
}
