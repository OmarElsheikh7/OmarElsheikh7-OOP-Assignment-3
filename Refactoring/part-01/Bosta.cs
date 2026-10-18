namespace RefactoringLab.Part_1;

public class Bosta : IShippingCompany
{
    public decimal CalculateShipping(decimal weightKg)
    {
        return weightKg * 10m;
    }
}