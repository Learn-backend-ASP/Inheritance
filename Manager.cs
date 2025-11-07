namespace Inheritance
{
    public class Manager : Employee
    {
        protected decimal AllownanceRate = 0.05m;

        public Manager(string name, int id, decimal loggedHoures, decimal wage) : base(name, id, loggedHoures, wage)
        {
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }
        private decimal CalculateAllowance()
        {
            return AllownanceRate * base.Calculate();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nAllowance : ${Math.Round(CalculateAllowance(), 2):N0}" +
                $"\nNet Salary : ${Math.Round(this.Calculate(), 2):N0}";

        }
    }

}
