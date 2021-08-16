using Consult.Domain.Commands;
using Consult.Domain.Handlers;
using Consult.Domain.Tests.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Consult.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateConsultHandlerTests
    {

        private readonly CreateConsultCommand _invalidCommand = new CreateConsultCommand("", "", DateTime.Now);
        private readonly CreateConsultCommand _validCommand = new CreateConsultCommand("Consulta Pediatrica", "williamgsilva", DateTime.Now);
        private readonly ConsultHandler _handler = new ConsultHandler(new FakeConsultRepository());

        private GenericCommandResult _result = new GenericCommandResult();
        public CreateConsultHandlerTests()
        {
           
        }

        [TestMethod]
        public void Given_an_invalid_command_must_interrupt_the_execution()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Sucess, false);
        }

        [TestMethod]
        public void Given_an_valid_must_create_a_clinical_consultation()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Sucess, true);
        }

    }

}