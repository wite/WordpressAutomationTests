using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void AdminUserCanLogin()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("wkryszax").WithPassword("X011T@phbA$TQ2KFZh").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
