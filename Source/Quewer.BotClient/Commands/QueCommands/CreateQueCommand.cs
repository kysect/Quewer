using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class CreateQueCommand : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<CreateQueCommand>
        {
            public Descriptor() : base("create-que", string.Empty, new[] { "Queam name" })
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