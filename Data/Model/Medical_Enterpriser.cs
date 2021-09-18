using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMedicineShopProjectFinal.Data.Model
{
    public class Medical_Enterpriser
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String MedName { get; set; }
        [Required]
        public String MedPescription { get; set; }
        public String MedAddress { get; set; }
        public String Time_at { get; set; }
    }
}
