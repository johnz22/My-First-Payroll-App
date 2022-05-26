namespace ClassDemo
{
    internal class PayrollMethods
    {
        private const int hourlyRate = 27;
        private int _hoursWorked;
        private string? nameOfStaff;

        public int HoursWorked
        {
            get
            {
                return _hoursWorked;
            }
            set
            {
                if (value > 0)
                    _hoursWorked = value;
                else
                    _hoursWorked = 0;
            }
        }
        public string NameOfStaff
        {
            get { return nameOfStaff; }
            set { nameOfStaff = value; }
        }
        public int CalculatePay()
        {
            PrintMessage();
            int staffPay;
            staffPay = HoursWorked * hourlyRate;
            if (HoursWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            if (HoursWorked > 0)
                return HoursWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay…………");
        }

        public override string ToString()
        {
            return "Name of Staff = " + NameOfStaff + ", hourlyRate = " + hourlyRate + ", HoursWorked = " + HoursWorked;
        }
    }
}