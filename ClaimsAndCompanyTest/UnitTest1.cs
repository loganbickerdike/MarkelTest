using ClaimsAndCompanyApi.Bl;
using System.Security.Cryptography.X509Certificates;

namespace ClaimsAndCompanyTest
{
    public class UnitTest1
    {
        [Fact]
        public void DaysOldTest()
        {
            //Arrange
            int expected = 30;
            // Act

            int actual = new ClaimBusinessLogic().GetDaysOld(new DateTime(2023, 1, 1), new DateTime(2023, 1, 31));

            //Assert                      
            Assert.Equal(expected, actual);
        }
    }
}