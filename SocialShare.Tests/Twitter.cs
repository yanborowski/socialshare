using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialShare.Tests
{
    [TestClass]
    class Twitter
    {
        [TestMethod]
        public void AuthWrongUser()
        {
            var userName = "";
            var userPassword = "";

            var isAuthenticated = SocialShare.Twitter.Twitter.AuthUser(userName, userPassword);

            Assert.AreEqual(isAuthenticated, true);
        }
    }
}
