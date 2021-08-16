using System;
using Consult.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Consult.Domain.Tests.EntityTests
{
    [TestClass]
    public class ConsultingTests
    {
        private readonly Consulting _consulting = new Consulting("Consulta Pediatrica", "williamgsilva", DateTime.Now);

        [TestMethod]
        public void Given_a_new_medical_consultation_it_cannot_be_completed()
        {
            Assert.AreEqual(_consulting.Done, false);
        }

    }

}