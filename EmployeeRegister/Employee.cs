namespace EmployeeRegister
{
    internal class Employee(int id, string name, double salary)
    {
        public int Id => id;
        public string Name => ValidateNameLenght(name);
        public double Salary => salary;

        public double IncreaseSalary(double percentage)
        {
            return salary += salary * (percentage / 100);
        }

        private string? ValidateNameLenght(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            if (name.Length > 1)
            {
                return name;
            }
            return name;
        }

        public override string ToString()
        {
            return "Name: "+Name+ " ID: " + id + " Salary: R$"+salary;
        }

    }
}
