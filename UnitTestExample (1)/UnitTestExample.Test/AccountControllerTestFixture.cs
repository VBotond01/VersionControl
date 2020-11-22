using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;





namespace UnitTestExample.Test
{
    class AccountControllerTestFixture
    {
        [Test, 
        TestCase("abcd1234", false),
        TestCase("irf@uni-corvinus", false),
        TestCase("irf.uni-corvinus.hu", false),
        TestCase("irf@uni-corvinus.hu", true),
        TestCase("abcdefgh", false),
            TestCase("ABCD1234", false),
            TestCase("abcd", false),
            TestCase("AbcD1234", true),


            ]

        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountController = new AccountController();

            var actualResult = accountController.ValidateEmail(email);
            Assert.AreEqual(expectedResult, actualResult);

        }


    }
}
