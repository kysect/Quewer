using System.Threading.Tasks;
using FluentResults;
using Kysect.BotFramework.Core.CommandInvoking;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class QuePushCommand : IBotCommand
    {
        public class Descriptor : BotCommandDescriptor<QuePushCommand>
        {
            public Descriptor() : base("que-push", string.Empty, new[] { "Que name" })
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