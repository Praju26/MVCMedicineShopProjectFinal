using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMedicineShopProjectFinal.Data.Model
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public String CustomerName { get; set; }
        public String  Description { get; set; }
        public String CustomerAddress { get; set; }
       public String Time_at { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public DateTime? UpdatedOn { get; set; }

    }
}
