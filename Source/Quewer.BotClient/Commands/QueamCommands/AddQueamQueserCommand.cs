using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Kysect.BotFramework.Core.Tools;
using System.Threading.Tasks;

namespace Quewer.BotClient.Commands.QueamCommands
{
    [BotCommandDescriptor("add-queam-queser", "", "Queam name", "Queser id")]
    public class AddQueamQueserCommand : IBotCommand
    {
        public Result CanExecute(CommandContainer args)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IBotMessage> Execute(CommandContainer args)
        {
            throw new System.NotImplementedException();
        }
    }
}