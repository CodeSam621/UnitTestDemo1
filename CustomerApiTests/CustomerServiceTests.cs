using Xunit;
using CustomerApi;

namespace CustomerApiTests
{
    public class CustomerServiceTests
    {
        private CustomerService _customerService;
        public CustomerServiceTests()
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
            //var expectedResult = _customerService.get();

            //// Assert
            //Assert.Equal("John", expectedResult);
        }
    }
}
