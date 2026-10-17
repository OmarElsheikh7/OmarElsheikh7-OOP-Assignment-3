namespace RefactoringLab.Part_1;

public class ShippingCostCalculator
{
    public decimal Calculate(IShippingCompany carrier, decimal weightKg)
    {
        ArgumentNullException.ThrowIfNull(carrier);
        return carrier.CalculateShipping(weightKg);
    }
}
