
using Consult.Domain.Commands;
using Consult.Domain.Commands.Contracts;
using Consult.Domain.Entities;
using Consult.Domain.Handlers.Contracts;
using Consult.Domain.Repositories;
using Flunt.Notifications;

namespace Consult.Domain.Handlers
{
    public class ConsultHandler :
        Notifiable,
        IHandler<CreateConsultCommand>,
        IHandler<UpdateConsultCommand>,
        IHandler<MarkConsultDoneCommand>,
        IHandler<MarkConsultUndoneCommand>
    {

        private readonly IConsultRepository _repository;

        public ConsultHandler(IConsultRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateConsultCommand command)
        {
            //Fail fast Validation
            command.Validate();
            if (command.Invalid)
            {
                return new GenericCommandResult(false, "Descrição da consulta está errada!", command.Notifications);
            }
            //Creater a new consult
            var consult = new Consulting(command.Description, command.User, command.Date);
            //Save on DB
            _repository.Create(consult);
            //Notify user
            return new GenericCommandResult(true, "Consulta criada com sucesso!", consult);

        }

        public ICommandResult Handle(UpdateConsultCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Descrição da consulta está errada!", command.Notifications);

            // Recupera o TodoItem (Rehidratação)
            var consult = _repository.GetById(command.Id, command.User);

            // Altera o título
            consult.UpdateDescription(command.Description);

            // Salva no banco
            _repository.Update(consult);

            // Retorna o resultado
            return new GenericCommandResult(true, "Consulta criada com sucesso!", consult);
        }

        public ICommandResult Handle(MarkConsultDoneCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Descrição da consulta está errada!", command.Notifications);

            // Recupera o TodoItem (Rehidratação)
            var consult = _repository.GetById(command.Id, command.User);

            // Altera o título
            consult.MarkAsDone();

            // Salva no banco
            _repository.Update(consult);

            // Retorna o resultado
            return new GenericCommandResult(true, "Consulta criada com sucesso!", consult);
        }

        public ICommandResult Handle(MarkConsultUndoneCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Descrição da consulta está errada!", command.Notifications);

            // Recupera o TodoItem (Rehidratação)
            var consult = _repository.GetById(command.Id, command.User);

            // Altera o título
            consult.MarkAsNotDone();

            // Salva no banco
            _repository.Update(consult);

            // Retorna o resultado
            return new GenericCommandResult(true, "Consulta criada com sucesso!", consult);
        }
    }

}