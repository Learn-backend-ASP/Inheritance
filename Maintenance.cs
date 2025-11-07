namespace Inheritance
{
    public class Maintenance : Employee
    {
        private decimal hardship = 1005m;

        public Maintenance(string name, int id, decimal loggedHoures, decimal wage) : base(name, id, loggedHoures, wage)
        {
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + hardship;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nHardship : ${Math.Round(hardship, 2):N0}" +
                $"\nNet Salary : ${Math.Round(this.Calculate(), 2):N0}";

        }
    }

}
