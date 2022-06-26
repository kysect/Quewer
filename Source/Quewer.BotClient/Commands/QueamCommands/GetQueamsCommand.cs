using System.Linq;
using System.Threading.Tasks;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Kysect.BotFramework.Core.Tools;
using Quewer.Core.DataAccess;

namespace Quewer.BotClient.Commands.QueamCommands;

[BotCommandDescriptor("get-queam", "")]
public class GetQueamsCommand : IBotCommand
{
    private readonly QuewerDbContext _context;

    public GetQueamsCommand(QuewerDbContext context)
    {
        _context = context;
    }

    public Result CanExecute(CommandContainer args)
    {
        return Result.Ok();
    }

    public async Task<IBotMessage> Execute(CommandContainer args)
    {
        //TODO: it's temp solution
        string message = string.Join(", ", _context.Queams.ToList().Select(q => q.Name));
        return new BotTextMessage($"Queams: {message}");
    }
}
