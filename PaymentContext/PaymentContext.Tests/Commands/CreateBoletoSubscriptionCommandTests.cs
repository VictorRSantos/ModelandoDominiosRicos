using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {


        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInvalid()
        {

            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "";

            command.Validate();

            Assert.AreEqual(false, command.Valid);

        }



    }
}