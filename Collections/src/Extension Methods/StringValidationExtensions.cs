using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Extension_Methods
{
    public static class StringValidationExtensions
    {
        public static bool IsValidEgyptianPhone(this string phone)
        {
            if (String.IsNullOrWhiteSpace(phone))
                return false;

            if (Regex.IsMatch(phone, @"^(\+2)\d{11}$"))
            {
                return Regex.IsMatch(phone, @"2(010|011|012|015)\d{8}$");
            }

            return Regex.IsMatch(phone, @"^(010|011|012|015)\d{8}$");



        }

        public static bool IsValidEgyptianNationalId(this string id)
        {
            if (String.IsNullOrWhiteSpace(id))
                return false;

            return Regex.IsMatch(id, @"^(2|3)\d{13}$");
        }

    }
}
