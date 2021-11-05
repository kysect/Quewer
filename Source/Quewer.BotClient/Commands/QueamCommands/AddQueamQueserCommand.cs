using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;

namespace Quewer.BotClient.Commands.QueamCommands
{
    public class AddQueamQueserCommand : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<AddQueamQueserCommand>
        {
            public Descriptor() : base("add-queam-queser", string.Empty, new []{ "Queam name", "Queser id" })
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