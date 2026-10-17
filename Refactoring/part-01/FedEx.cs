using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part_1
{
    public class FedEx : IShippingCompany
    {
        public decimal CalculateShipping(decimal weightKg)
        {
            return weightKg * 18m;
        }
    }
}
