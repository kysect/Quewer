using System.Threading.Tasks;
using FluentResults;
using Kysect.BotFramework.Core.CommandInvoking;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class QuePopCommand : IBotCommand
    {
        public class Descriptor : BotCommandDescriptor<QuePopCommand>
        {
            public Descriptor() : base("que-pop", string.Empty, new[] { "Que name" })
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