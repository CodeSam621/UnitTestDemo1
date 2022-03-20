using System;
using CustomerApi;
using Xunit;

namespace CustomerApiTests
{
    public class CustomerServiceTests3
    {
        private CustomerService _customerService;
     

        public CustomerServiceTests3()
        {
            _customerService = new CustomerService();

        }

        [Fact]
        public void GetCustomerName_ShouldReturnCustomerName()
        {
            // Arrange

            // Act
            var expectedResult =_customerService.GetCustomerName();

            // Assert
            Assert.Equal("John",expectedResult);
        }

        [Fact]
        public void GetCustomerAddress_ShouldReturnCustomerAddress()
        {
            // Arrange

            // Act
            var expectedResult = TestBase.CallMethod<string>(_customerService, "GetCustomerAddress", null);

            //// Assert
            Assert.Equal("10, Main Street, Melbourne VIC", expectedResult);
        }

        [Fact]
        public void GetCustomerBirthday_ShouldReturnCustomerBirthYear()
        {
            // Arrange

            // Act
            //var expectedResult = _customerService.GetCustomerAge();
            var expectedResult = TestBase
                .CallMethod<DateTime>(_customerService, "GetCustomerBirthday", null);

            //// Assert
            Assert.Equal(DateTime.Now.AddYears(-20).Year, expectedResult.Year);
        }

        [Fact]
        public void GetCustomerGreeting_ShouldReturnGetCustomerGreeting()
        {
            // Arrange
            var customerName = "Sam";
            var expectedResult = TestBase
                .CallMethod<string>(_customerService, "GetCustomerGreeting", customerName);

            //// Assert
            Assert.Equal($"Hello {customerName}", expectedResult);
        }

    }
}
