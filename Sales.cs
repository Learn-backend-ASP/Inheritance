namespace Inheritance
{
    public class Sales : Employee
    {
        public Sales(string name, int id, decimal loggedHoures, decimal wage, decimal salesVolum, decimal commission) : base(name, id, loggedHoures, wage)
        {
            this.SalesVolum = salesVolum;
            Commission = commission;
        }

        protected decimal SalesVolum { get; set; }
        protected decimal Commission { get; set; }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBones();
        }

        private decimal CalculateBones()
        {
            return SalesVolum * Commission;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nCommission : ${Math.Round(Commission, 2):N0}" +
                $"\nBones : ${Math.Round(CalculateBones(), 2):N0}" +
                $"\nNet Salary : ${Math.Round(this.Calculate(), 2):N0}";

        }
    }

}
