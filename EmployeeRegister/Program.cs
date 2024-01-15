namespace EmployeeRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double salary;

            Console.Write("How many employee will be registred: ");
            int qtdEmployee = int.Parse(Console.ReadLine());

            List<Employee> list = new();

            for(int i = 0; i < qtdEmployee; i++)
            {
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Salary: ");
                salary = int.Parse(Console.ReadLine());

                Employee employee = new(id, name, salary);
                list.Add(employee);
            }

            Console.WriteLine("Enter the employee id that will be salary increase");
            int employeeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the percentage");
            double percentage = double.Parse(Console.ReadLine());
            Employee employee1 = verifyID(employeeID, list);

            if (employee1 == null)
            {
                Console.WriteLine("This id doesn't exist!");
            } else
            {
                employee1.IncreaseSalary(percentage);
            }

            Console.WriteLine(employee1);
        }

        public static Employee verifyID(int id, List<Employee> list)
        {
            foreach (Employee employeeid in list)
            {
                return list.Find(x => x.Id == id);
            }

            return null;
        }
    }
}