namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mahmoud = new Manager("Mahmoud H.", 1, 180, 10);


            var salem = new Maintenance("Salem A.", 2, 176, 13);

            var saly = new Sales("Saly M.", 3, 200, 9, 10000m, 0.05m);

            var essam = new Developer("Sara A.", 4, 196, 13, true);

            Employee[] employees = { mahmoud, salem, saly, essam };
            foreach (Employee employee in employees)
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.WriteLine(employee);
            }

            Console.ReadKey();
        }
    }

}
