namespace Inheritance
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.03m;

        public Developer(string name, int id, decimal loggedHoures, decimal wage , bool taskCompleted) : base(name, id, loggedHoures, wage)
        {
            TaskCompleted = taskCompleted;
        }

        protected bool TaskCompleted { get; set; }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBones();
        }

        private decimal CalculateBones()
        {
            return TaskCompleted ? (base.Calculate() * Commission) : 0m;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nTask Completed : ${(TaskCompleted ? "YES" : "NO")}" +
                $"\nBones : ${Math.Round(CalculateBones(), 2):N0}" +
                $"\nNet Salary : ${Math.Round(this.Calculate(), 2):N0}";

        }
    }

}
namespace Inheritance
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.03m;

        public Developer(string name, int id, decimal loggedHoures, decimal wage , bool taskCompleted) : base(name, id, loggedHoures, wage)
        {
            TaskCompleted = taskCompleted;
        }

        protected bool TaskCompleted { get; set; }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBones();
        }

        private decimal CalculateBones()
        {
            return TaskCompleted ? (base.Calculate() * Commission) : 0m;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nTask Completed : ${(TaskCompleted ? "YES" : "NO")}" +
                $"\nBones : ${Math.Round(CalculateBones(), 2):N0}" +
                $"\nNet Salary : ${Math.Round(this.Calculate(), 2):N0}";

        }
    }

}
