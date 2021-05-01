using System.Threading.Tasks;
using FluentResults;
using Kysect.BotFramework.Core.CommandInvoking;

namespace Quewer.BotClient.Commands.QueamCommands
{
    public class AddQueamQueserCommand : IBotCommand
    {
        public class Descriptor : BotCommandDescriptor<AddQueamQueserCommand>
        {
            public Descriptor() : base("add-queam-queser", string.Empty, new []{ "Queam name", "Queser id" })
            {
            }
        }

        public Result CanExecute(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<string>> ExecuteAsync(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }
    }
}