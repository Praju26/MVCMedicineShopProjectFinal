using MVCMedicineShopProjectFinal.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMedicineShopProjectFinal.ViewModel
{
    public class MedicineDetailsViewModel
    {
        public Medicine Medicine { get; set; }
        public MedicineDetailsViewModel medicineDetails { get; set; }
    }
}
