using System;
using Consult.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace Consult.Domain.Commands
{
    //Consult Request has been updated
    public class UpdateConsultCommand : Notifiable, ICommand
    {
        public UpdateConsultCommand() { }

        public UpdateConsultCommand(Guid id, string description, string user)
        {
            Id = id;
            Description = description;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }
        public string Description { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Description, 3, "Description", "Descreva a consulta corretamente deste usuario!")
                .HasMaxLen(User, 6, "User", "Usuário inválido!")
            );
        }
    }

}