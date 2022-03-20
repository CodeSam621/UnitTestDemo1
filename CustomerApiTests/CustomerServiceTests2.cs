using Xunit;
using CustomerApi;

namespace CustomerApiTests
{
    public class CustomerServiceTests2
    {
        private CustomerServiceWrapper _customerService;

        public CustomerServiceTests2()
        {
            _customerService = new CustomerServiceWrapper();

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
            var expectedResult = _customerService.GetCustomerAddress();

            //// Assert
            Assert.Equal("10, Main Street, Melbourne VIC", expectedResult);
        }
    }

    public class CustomerServiceWrapper: CustomerService
    {
        public CustomerServiceWrapper()
        {

        }

        public new string GetCustomerAddress()
        {
            return base.GetCustomerAddress();
        }

    }
}
