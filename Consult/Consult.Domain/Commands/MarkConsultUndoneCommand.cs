using System;
using Consult.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace Consult.Domain.Commands
{
    //Consult Request has been cancelled
    public class MarkConsultUndoneCommand : Notifiable, ICommand
    {
        public MarkConsultUndoneCommand() { }
        public MarkConsultUndoneCommand(Guid id, string user)
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