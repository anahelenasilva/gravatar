using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestMethod("Should validate gravatar extension")]
        [TestCategory("Gravatar Tests")]
        [DataRow(null, 200, false)]
        [DataRow("", 200, false)]
        [DataRow(" ", 200, false)]
        [DataRow("a@a", 200, false)]
        [DataRow("a@ana.com", 200, false)]
        [DataRow("anahelenarp@hotmail.com", null, true)]
        [DataRow("anahelenarp@hotmail.com", 200, true)]
        public void ShouldValidateGravatar(string email, int? size, bool status)
        {
            var imageSize = size != null ? size.Value.ToString() : "80";
            var result = $"https://www.gravatar.com/avatar/0b9f9e883ee0a57d9130fae9650a9e18?s={imageSize}";
            Assert.AreEqual(email.ToGravatar(size ?? 80) == result, status);
        }
    }
}