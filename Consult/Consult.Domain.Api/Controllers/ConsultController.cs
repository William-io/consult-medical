using Consult.Domain.Commands;
using Consult.Domain.Entities;
using Consult.Domain.Handlers;
using Consult.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Consult.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/consults")]
    public class ConsultController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Consulting> Getall(
            [FromServices]IConsultRepository repository
        )
        {
            return repository.GetAll("williamvilela");
        }


        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] CreateConsultCommand command,
            [FromServices] ConsultHandler handler
        )
        {
            command.User = "williamvilela";
            return (GenericCommandResult)handler.Handle(command);
        }
    }

}