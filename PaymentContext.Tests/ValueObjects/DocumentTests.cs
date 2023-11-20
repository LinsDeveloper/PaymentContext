using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
          var doc = new Document("123", EDocumentType.CNPJ);
          Assert.IsFalse(doc.Validate());
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsInvalid()
        {
          var doc = new Document("34110468000150", EDocumentType.CNPJ);
          Assert.IsTrue(doc.Validate());
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
          var doc = new Document("123", EDocumentType.CPF);
          Assert.IsFalse(doc.Validate());
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCPFIsInvalid()
        {
          var doc = new Document("34225545806", EDocumentType.CPF);
          Assert.IsTrue(doc.Validate());
        }
    }
}
