using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestMethod("Should validate gravatar extension")]
        [TestCategory("Gravatar Tests")]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("a@a", false)]
        [DataRow("a@ana.com", false)]
        [DataRow("anahelenarp@hotmail.com", true)]
        public void ShouldValidateGravatar(string email, bool status)
        {
            var result = "https://www.gravatar.com/avatar/0b9f9e883ee0a57d9130fae9650a9e18";
            Assert.AreEqual(email.ToGravatar() == result, status);
        }
    }
}