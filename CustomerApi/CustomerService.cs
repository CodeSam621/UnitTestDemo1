using System;

namespace CustomerApi
{
    public class CustomerService
    {
        public string GetCustomerName()
        {
            return "John";
        }

        protected string GetCustomerAddress()
        {
            return "10, Main Street, Melbourne VIC";
        }

        private DateTime GetCustomerBirthday()
        {
            return DateTime.Now.AddYears(-20) ;
        }

        private string GetCustomerGreeting(string name)
        {
            return $"Hello {name}";
        }
    }
}
