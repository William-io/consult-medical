using Consult.Domain.Entities;
using Consult.Domain.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consult.Domain.Tests.QueryTests
{
    [TestClass]
    public class ConsultQueryTests
    {
        private List<Consulting> _consultings;

        public ConsultQueryTests()
        {
            _consultings = new List<Consulting>();
            _consultings.Add(new Consulting("Pediatra1", "usuarioA", DateTime.Now));
            _consultings.Add(new Consulting("Pediatra2", "usuarioA", DateTime.Now));
            _consultings.Add(new Consulting("Pediatra3", "williamsilva", DateTime.Now));
            _consultings.Add(new Consulting("Pediatra4", "usuarioA", DateTime.Now));
            _consultings.Add(new Consulting("Pediatra5", "williamsilva", DateTime.Now));
        }



        //Dada_a_consulta_deve_retonar_tarefas_apenas_do_usuario
        [TestMethod]
        public void Given_the_query_must_return_tasks_only_of_the_user()
        {
            var result = _consultings.AsQueryable().Where(ConsultQueries.GetAll("williamsilva"));
            Assert.AreEqual(2, result.Count());
        }
    }

}