using Consult.Domain.Commands.Contracts;

namespace Consult.Domain.Commands
{
    //Pattern CreateConsultCommand
    public class GenericCommandResult : ICommandResult
    {
        //Constructor parameterless
        public GenericCommandResult() { }
        public GenericCommandResult(bool sucess, string message, object data)
        {
            Sucess = sucess;
            Message = message;
            Data = data;
        }

        public bool Sucess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }

}