using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeesApp.Validation;

namespace MSUnitTest
{
    [TestClass]
    public class AccountNumberValidationTests
    {
        private readonly AccountNumberValidation _validation;
        public AccountNumberValidationTests()
        {
            _validation = new AccountNumberValidation();
        }
        [TestMethod]
        public void IsValid_ValidAccountNumber_ReturnsTrue()
        {
            Assert.IsTrue(_validation.IsValid("123-4543234576-23"));
        }
        
         [TestMethod]
        public void AddTwoNumbers_ReturnsInt()
        {
        Assert.AreEqual(5, _validation.addTwoNumbers(2,3));
        }

    }
    
   
}
