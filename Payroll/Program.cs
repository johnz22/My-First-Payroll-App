
namespace ClassDemo
{
    class Staff : PayrollMethods
    {
        public Staff(string name)
        {
            NameOfStaff = name;
            Console.WriteLine("\n" + NameOfStaff);
            Console.WriteLine("--------------------------");
        }

        public Staff(string firstName, string lastName)
        {
            NameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + NameOfStaff);
            Console.WriteLine("--------------------------");
        }

        static void Main()
        {
            int pay;
            var staff1 = new Staff("John");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Mark", "Hong");
            staff2.HoursWorked = 120;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            Staff staff3 = new Staff("Jackie");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
        }

    }
}

