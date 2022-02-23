using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InsuranceExercise
{
    class InsuranceManager
    {
        List<Insurance> insurancess = new List<Insurance>();
        private double fee;




        public void AddInsurance(string animal, string name, bool isNeutered) // metodilla 3 parametria
        {
            insurancess.Add(new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered)));
        }
        double GetFee(string species, bool isNeutered) // metodilla 2 parametria
        {
            if (species == "koira" && isNeutered == false)
            {
                fee = 50.00;
            }
            else if (species == "koira" && isNeutered == true)
            {
                fee = 80.00;
            }
            else if (species == "kissa" && isNeutered == false)
            {
                fee = 40;
            }
            else if (species == "kissa" && isNeutered == true)
            {
                fee = 60.00;
            }
            else if (species == "lintu" || species == "matelija")
            {
                fee = 0;
            }
            return fee;
        }
        public void PrintInsurances()
        {

            Console.WriteLine("Vakuutuksia yhteensä " + insurancess.Count);
            Console.WriteLine("Vakuutukset:");
            foreach (Insurance ainsurance in insurancess)
            {
                Console.WriteLine(ainsurance);
            }

        }
        public void FindInsurances(string species, bool isNeutered) // metodilla 2 parametria
        {
            Console.WriteLine("löytyi");
            foreach (Insurance insurance in insurancess)
            {
                if (insurance.species == species && insurance.neutered == isNeutered)
                {
                    
                    Console.WriteLine($"\n{insurance.species}: {insurance.name}, vakuutusmaksu {insurance.fee} ");
                }
            }

        }
    }
}
