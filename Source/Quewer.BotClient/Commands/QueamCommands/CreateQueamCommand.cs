using System.Threading.Tasks;
using FluentResults;
using Kysect.BotFramework.Core.CommandInvoking;

namespace Quewer.BotClient.Commands.QueamCommands
{
    public class CreateQueamCommand : IBotCommand
    {
        public class Descriptor : BotCommandDescriptor<CreateQueamCommand>
        {
            public Descriptor() : base("create-queam", string.Empty, new[] { "Queam name" })
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