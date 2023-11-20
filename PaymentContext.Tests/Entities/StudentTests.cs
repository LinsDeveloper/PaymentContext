using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHadActivateSubscription()
        {
          var name = new Name("Bruce", "Wayne");
          var document = new Document("35111507734634", EDocumentType.CPF);
          var email = new Email("batman@dc.com");
          var student = new Student(name, document, email);


          Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadSubscriptionHasNoPayments()
        {
          Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadNoActivateSubscription()
        {
          Assert.Fail();
        }
    }
}
