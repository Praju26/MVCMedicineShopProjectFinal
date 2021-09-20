using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCMedicineShopProjectFinal.Data.Model
{
    //public interface IMedicineRepository
    //{
    //    public class GetMedicineById : IMedicineRepository
    //    {
    //        public List<Medicine> medicines = new List<Medicine>()
    //    {
    //        new Medicine { ID = 101, Name = "Paracetamol Dolo-650", Quantity= 100,MedicineCode= "1023458", Use_in_case = "Headache",Contradication= " Undiagnosed pain", Price=9582 },
    //        new Medicine { ID = 102, Name = "Benylin", Quantity = 250,MedicineCode = "2035789", Use_in_case = "Feaver",Contradication = "Greater quantity effect weekness" ,Price= 2587},
    //        new Medicine { ID = 103, Name = "ACE Inhibier", Quantity = 50,MedicineCode = "3014575", Use_in_case = "Control blood pressure " ,Contradication= "High blood pressure ", Price=1579},
    //    new Medicine { ID = 104, Name = "Cardiolip", Quantity = 36, MedicineCode= "4025698", Use_in_case = "effect of cancer symptoms ",Contradication= " Cancer ", Price=1256},
    //    new Medicine { ID = 105, Name = " CARDICHECK-10", Quantity = 42,MedicineCode = "879654",Use_in_case = "Continue heart process ", Contradication= " Heart Problem", Price=8524},
    //    new Medicine { ID = 106, Name = "Zidax-M", Quantity = 58,MedicineCode = "214789", Use_in_case = " Increase sugar ", Contradication=" Diabetis" ,Price= 2587},
    //    new Medicine { ID = 107, Name = " OxyContin",Quantity = 68, MedicineCode = "5123458", Use_in_case= " Pain in body " ,Contradication= "traped or pinched nervers",Price=3578},
    //    new Medicine { ID = 108, Name = " AF-Kit", Quantity = 50, MedicineCode = "258940", Use_in_case= "Infection ", Contradication= " Gynecological infection", Price=6970},
    //    new Medicine { ID = 109, Name = " Brace-S", Quantity =89,MedicineCode = "2367895", Use_in_case = "Pain ", Contradication= " Oedema", Price=500},
    //    new Medicine { ID = 110, Name = "Genrof", Quantity = 70,MedicineCode = "2547893", Use_in_case = " less symptomes of cardiovascular disease", Contradication= " Cardio-vascular conditions",Price= 7000 }
    //};




    //    public List<Medicine> GetAllCustomers()

    //    return medicines;
    //}

    //public  GetMedicineById(int Id)
    //{
    //    var customer = medicines.FirstOrDefault(item => item.ID == Id); 
    //    return Medicine;
    //}

    //public bool CreateCustomer(Medicine medicine)
    //{
    //    try
    //    {
    //        medicine.ID = medicines.Select(item => item.ID).Max() + 1;
    //        medicines.Add(medicine);
    //    }
    //    catch (Exception)
    //    {
    //        return false;
    //    }
    //    return true;
    //}

    //public bool UpdateMedicine(Medicine medicine)
    //{
    //    try
    //    {
    //        Medicine _medicine = GetMedicineById(medicine.ID);
    //        _medicine.Name = medicine.Name;
    //        _medicine.Use_In_Case = medicine.Use_In_Case;
    //        _medicine.MedicineCode = medicine.MedicineCode;
    //        _medicine.Price = medicine.Price;
    //    }
    //    catch (Exception)
    //    {
    //        return false;
    //    }
    //    return true;
    //}

    //    public bool DeleteCustomer(int id)
    //    {
    //        try
    //        {
    //            medicines.Remove(GetMedicineById(id));
    //        }
    //        catch (Exception)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }

    //    private Medicine GetMedicineById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
