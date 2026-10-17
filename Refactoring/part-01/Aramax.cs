namespace RefactoringLab.Part_1;

public class Aramax : IShippingCompany
{
    public decimal CalculateShipping(decimal weightKg)
    {
        return weightKg * 12m;
    }
}