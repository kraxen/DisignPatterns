using System;

namespace SOLID.Single_Responsibility_Principle.Example2
{
    public class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone)
        {
            if (String.IsNullOrEmpty(phone.Model) || phone.Price <= 0)
                return false;

            return true;
        }
    }
}
