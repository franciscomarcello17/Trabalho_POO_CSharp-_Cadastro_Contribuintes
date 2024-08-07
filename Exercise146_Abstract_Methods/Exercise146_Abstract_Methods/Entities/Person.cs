namespace Exercise146_Abstract_Methods.Entities;

abstract class Person
{
    public string Name { get; set; }
    public double AnnualIncome { get; set; }

    public Person()
    {
    }

    public Person(string name, double annualIncome)
    {
        Name = name;
        this.AnnualIncome = annualIncome;
    }

    public abstract double TaxCalculation();
}