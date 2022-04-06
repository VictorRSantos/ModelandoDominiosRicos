
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor
        //[TestMethod]

        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsValid()
        {

            var doc = new Document("123", EDocumentType.CNPJ);

            Assert.IsTrue(doc.Invalid);

        }


        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValida()
        {

            var doc = new Document("34110468000150", EDocumentType.CNPJ);

            Assert.IsTrue(doc.Valid);

        }


        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsValida()
        {

            var doc = new Document("123", EDocumentType.CPF);

            Assert.IsTrue(doc.Invalid);

        }


        [TestMethod]
        public void ShouldReturnSuccessWhenCPFIsValida()
        {

            var doc = new Document("34225545806", EDocumentType.CPF);

            Assert.IsTrue(doc.Valid);

        }

    }
}