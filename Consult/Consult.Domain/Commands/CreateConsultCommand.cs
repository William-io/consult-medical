using System;
using Consult.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace Consult.Domain.Commands
{
    public class CreateConsultCommand : Notifiable, ICommand
    {
        //Contructor parameterless, prevent data corruption.
        public CreateConsultCommand() { }

        public CreateConsultCommand(string description, string user, DateTime date)
        {
            Description = description;
            User = user;
            Date = date;
        }

        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Description, 3, "Description", "Descreva a consulta corretamente deste usuario!")
                .HasMinLen(User, 6, "User", "Usuário inválido!")
            );
        }
    }
}
