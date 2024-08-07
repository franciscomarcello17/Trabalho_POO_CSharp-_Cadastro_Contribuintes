using System.Globalization;

namespace Exercise146_Abstract_Methods.Entities;

class Program
{
    public static void Main(string[] args)
    {
        List<Person> list = new List<Person>();

        Console.Write("Enter the number of tax payers: ");
        int taxPayerQuantity = int.Parse(Console.ReadLine());

        for (int i = 1; i <= taxPayerQuantity; i++)
        {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write("Individual or company (i/c)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Annual income: ");
            double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 'i' || ch == 'I')
            {
                Console.Write("Health expenditures: ");
                double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new PhysicalPerson(name, annualIncome, healthSpending));
            }
            else if (ch == 'c' || ch == 'C')
            {
                Console.Write("Employees Quantity: ");
                int employeesQuantity = int.Parse(Console.ReadLine());

                list.Add(new LegalPerson(name, annualIncome, employeesQuantity));
            }
            else
            {
                Console.WriteLine("Type of tax payer invalid.");
            }
        }
        Console.WriteLine();
        Console.WriteLine("TAXES PAID:");

        double totalTaxes = 0.0;

        foreach (Person person in list) 
        {
            Console.WriteLine($"{person.Name}: $ {person.TaxCalculation().ToString("F2", CultureInfo.InvariantCulture)}");
            totalTaxes += person.TaxCalculation();
        }
        Console.WriteLine();
        Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
    }
}