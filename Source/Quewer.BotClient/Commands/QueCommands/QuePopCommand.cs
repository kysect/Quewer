using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class QuePopCommand : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<QuePopCommand>
        {
            public Descriptor() : base("que-pop", string.Empty, new[] { "Que name" })
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