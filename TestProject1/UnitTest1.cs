using FunctionApp4.Application.Services;

namespace TestProject1
{
    public class UnitTestShould
    {
        [Fact]
        public void ValidateMailValidator()
        {
            //Arrange
            var mailValidator = new MailValidator();
            var email = "juan.rodriguezc";
            //Act
            var result = mailValidator.IsSpam(email);
            //Assert
            Assert.False(result);


        }
    }
}