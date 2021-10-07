using Consult.Domain.Commands;
using Consult.Domain.Entities;
using Consult.Domain.Handlers;
using Consult.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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

        [Route("done")]
        [HttpGet]
        public IEnumerable<Consulting> GetallDone(
            [FromServices]IConsultRepository repository    
        )
        {
            return repository.GetAllDone("williamvilela");
        }

        [Route("undone")]
        [HttpGet]
        public IEnumerable<Consulting> GetAllUndone(
            [FromServices] IConsultRepository repository
        )
        {
            return repository.GetAllDone("williamvilela");
        }

        [Route("done/today")]
        [HttpGet]
        public IEnumerable<Consulting> GetDoneForToday(
            [FromServices] IConsultRepository repository
        )
        {
            return repository.GetByPeriod(
                "williamvilela",
                DateTime.Now.Date,
                true
                );
        }

        [Route("undone/today")]
        [HttpGet]
        public IEnumerable<Consulting> GetInactiveForToday(
            [FromServices] IConsultRepository repository
        )
        {
            return repository.GetByPeriod(
                "williamvilela",
                DateTime.Now.Date,
                false
                );
        }

        [Route("done/tomorrow")]
        [HttpGet]
        public IEnumerable<Consulting> GetDoneForTomorrow(
           [FromServices] IConsultRepository repository
       )
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetByPeriod(
                user,
                DateTime.Now.Date.AddDays(1),
                true
            );
        }

        [Route("undone/tomorrow")]
        [HttpGet]
        public IEnumerable<Consulting> GetUndoneForTomorrow(
            [FromServices] IConsultRepository repository
        )
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repository.GetByPeriod(
                user,
                DateTime.Now.Date.AddDays(1),
                false
            );
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