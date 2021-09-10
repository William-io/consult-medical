using Consult.Domain.Commands;
using Consult.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Consult.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/consults")]
    public class ConsultController : ControllerBase
    {
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