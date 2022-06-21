using System.Threading.Tasks;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Kysect.BotFramework.Core.Exceptions;
using Kysect.BotFramework.Core.Tools;
using Quewer.Core.DataAccess;
using Quewer.Core.Models;

namespace Quewer.BotClient.Commands.QueamCommands
{
    [BotCommandDescriptor("create-queam", "", "Queam name")]
    public class CreateQueamCommand : IBotCommand
    {
        private class Arguments
        {
            private readonly CommandContainer _command;

            public Arguments(CommandContainer command) => _command = command;
            public long SenderId => _command.SenderInfo.UserSenderId;
            public string QueamName => _command.Arguments[0];
        }

        private readonly QuewerDbContext _context;

        public CreateQueamCommand(QuewerDbContext context)
        {
            _context = context;
        }

        public Result CanExecute(CommandContainer args)
        {
            return Result.Ok();
        }

        public async Task<IBotMessage> Execute(CommandContainer args)
        {
            var arguments = new Arguments(args);
            Queser queser = await _context.Quesers.FindAsync(arguments.SenderId);
            if (queser is null)
                return new BotTextMessage("Queser was not registered");

            _context.Queams.Add(new Queam(arguments.QueamName, queser));
            await _context.SaveChangesAsync();

            return new BotTextMessage($"Created new queam: {args.Arguments[0]}");
        }
    }
}