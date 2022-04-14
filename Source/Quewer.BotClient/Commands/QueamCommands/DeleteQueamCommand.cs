using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;

namespace Quewer.BotClient.Commands.QueamCommands
{
    public class DeleteQueamCommand : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<DeleteQueamCommand>
        {
            public Descriptor() : base("delete-queam", string.Empty, new[] { "Queam name" })
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