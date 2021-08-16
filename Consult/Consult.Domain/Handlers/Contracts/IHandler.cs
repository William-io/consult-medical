using Consult.Domain.Commands.Contracts;

namespace Consult.Domain.Handlers.Contracts
{
    //T calls ICommand for T. to go through the contract.
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
