namespace Week4ChallengeLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unit amount");
            double unit = Convert.ToInt32(Console.ReadLine());
            MonthlyAmount(unit);
            
            
        }
        static void MonthlyAmount(double unitUsed)
        {
            double chargePerUnit;
            double extrachargeRate = .15;
            bool Surcharge = false;
            double initalTotalAmount;          
            if (unitUsed <= 199) 
            {
                chargePerUnit = 1.2;
            }
            else if (200 <= unitUsed && unitUsed < 400)
            {
                chargePerUnit = 1.5;
            }
            else if (400 <= unitUsed && unitUsed < 600)
            {
                chargePerUnit = 1.8;
                Surcharge = true;
            }
            else 
            {
                chargePerUnit = 2;
                Surcharge = true;
            }
            initalTotalAmount = unitUsed * chargePerUnit;
            Console.WriteLine($"Unit consumed:{unitUsed}");
            Console.WriteLine($"Amount charges at ${chargePerUnit} per unit: {initalTotalAmount}");
            if (Surcharge == true)
            {               
                Console.WriteLine($"Surchage amount: {initalTotalAmount * extrachargeRate}");
                Console.WriteLine($"Net Amount Paid By the Customer :{(initalTotalAmount * extrachargeRate) + initalTotalAmount}");
            }
        }
    }
}

 