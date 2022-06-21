using System.Threading.Tasks;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Kysect.BotFramework.Core.Tools;

namespace Quewer.BotClient.Commands.QueCommands
{
    [BotCommandDescriptor("que-swap", "", "Que name", "Queser id")]
    public class QueSwapCommand : IBotCommand
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