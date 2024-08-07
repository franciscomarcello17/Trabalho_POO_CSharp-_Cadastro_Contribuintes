namespace Exercise146_Abstract_Methods.Entities;

class PhysicalPerson : Person
{
    public double HealthSpending { get; set; }

    public PhysicalPerson()
    {
    }

    public PhysicalPerson(string name, double annualIncome, double healthSpending) 
        : base(name, annualIncome)
    {
        this.HealthSpending = healthSpending;
    }

    public override double TaxCalculation()
    {
        if (AnnualIncome < 20000.0)
        {
            return AnnualIncome * 0.15 - HealthSpending * 0.5;
        }
        else
        {
            return AnnualIncome * 0.25 - HealthSpending * 0.5;
        }
    }
}