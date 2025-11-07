namespace Inheritance
{
    public class Employee
    {
        private const int MinimumLoggedHours = 176;
        private const decimal OverTimeRat = 1.25m;

        protected Employee(string name, int id, decimal loggedHoures, decimal wage)
        {
            Name = name;
            Id = id;
            LoggedHoures = loggedHoures;
            Wage = wage;
        }

        protected string Name { get; set; }
        protected int Id { get; set; }
        protected decimal LoggedHoures { get; set; }
        protected decimal Wage { get; set; }
        private decimal CalculateBaseSalary()
        {
            return (LoggedHoures * Wage);
        }
        private decimal CalculateOverTime()
        {
            var additionalHours = ((LoggedHoures - MinimumLoggedHours) > 0 ? (LoggedHoures - MinimumLoggedHours) : 0);
            return additionalHours * OverTimeRat * Wage;
        }
        protected virtual decimal Calculate()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Inheritance", "");
            return $"{type}" +
                $"\nID : {Id}" +
                $"\nName : {Name}" +
                $"\nLogged Hours : {LoggedHoures} hrs" +
                $"\nWage : {Wage}$/hr" +
                $"\nBase Salary : ${Math.Round(CalculateBaseSalary(), 2):N0}" +
                $"\nOverTime : ${Math.Round(CalculateOverTime(), 2):N0}";
        }
    }

}
