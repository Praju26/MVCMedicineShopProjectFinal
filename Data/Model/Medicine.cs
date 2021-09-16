using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMedicineShopProjectFinal.Data.Model
{
    public class Medicine
    {
        [Key]
        public int MedicineID { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public String Description { get; set; }
        public String MedicineCode { get; set; }
        public String Img { get; set; }
        public String Use_in_case { get; set; }
        public String Contradication { get; set; }
        public String Price { get; set; }

    }
}
