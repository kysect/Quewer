using System.Threading.Tasks;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Kysect.BotFramework.Core.Tools;

namespace Quewer.BotClient.Commands.QueamCommands;

[BotCommandDescriptor("delete-queam", "", "Queam name")]
public class DeleteQueamCommand : IBotCommand
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
