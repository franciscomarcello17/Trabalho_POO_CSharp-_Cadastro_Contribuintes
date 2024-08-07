namespace Exercise146_Abstract_Methods.Entities;

class LegalPerson : Person
{
    public int EmployeesQuantity { get; set; }

    public LegalPerson()
    {
    }

    public LegalPerson(string name, double annualIncome, int employeesQuantity) 
        : base(name, annualIncome)
    {
        this.EmployeesQuantity = employeesQuantity;
    }

    public override double TaxCalculation()
    {
        if (EmployeesQuantity > 10)
        {
            return AnnualIncome * 0.14;
        }
        else
        {
            return AnnualIncome * 0.16;
        }
    }
}