using System;
using Consult.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace Consult.Domain.Commands
{
    //Consult Request has been completed
    public class MarkConsultDoneCommand : Notifiable, ICommand
    {
        public MarkConsultDoneCommand() { }
        public MarkConsultDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Usuário inválido! O nome do usuário deve ter pelo menos 6 caracteres")
            );
        }
    }
}