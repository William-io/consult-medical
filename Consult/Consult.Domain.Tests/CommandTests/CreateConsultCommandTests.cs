using Consult.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Consult.Domain.Tests.CommandTests
{
    //Unit test class for the Command class, Test-driven development (TDD)
    [TestClass]
    public class CreateConsultCommandTests
    {
        private readonly CreateConsultCommand _invalidCommand = new CreateConsultCommand("", "", DateTime.Now);
        private readonly CreateConsultCommand _validCommand = new CreateConsultCommand("Consulta Pediatrica", "williamgsilva", DateTime.Now);


        public CreateConsultCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [TestMethod]
        public void Given_an_invalid_command()
        {
            //Failed
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Given_an_valid_command()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
