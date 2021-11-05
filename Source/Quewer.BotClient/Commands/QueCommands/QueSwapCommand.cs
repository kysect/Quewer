using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class QueSwapCommand : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<QueSwapCommand>
        {
            public Descriptor() : base("que-swap", string.Empty, new[] { "Que name", "Queser id" })
            {
            }
        }

        public Result CanExecute(CommandContainer args)
        {
            throw new System.NotImplementedException();
        }

        public Result<IBotMessage> Execute(CommandContainer args)
        {
            throw new System.NotImplementedException();
        }
    }
}