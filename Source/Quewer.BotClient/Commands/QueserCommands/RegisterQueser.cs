using System.Linq;
using System.Threading.Tasks;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Kysect.BotFramework.Core.Tools;
using Quewer.Core.DataAccess;
using Quewer.Core.Models;

namespace Quewer.BotClient.Commands.QueserCommands
{
    [BotCommandDescriptor("register", "Use this command for register in system.", "Queser name")]
    public class RegisterQueser : IBotCommand
    {
        private class Arguments
        {
            private readonly CommandContainer _command;

            public Arguments(CommandContainer command) => _command = command;
            public long SenderId => _command.Context.SenderInfo.UserSenderId;
            public string Username => _command.Arguments[0];
        }

        private readonly QuewerDbContext _context;

        public RegisterQueser(QuewerDbContext context)
        {
            _context = context;
        }


        public Result CanExecute(CommandContainer args)
        {
            var arguments = new Arguments(args);

            Queser queser = _context.Quesers.Find(arguments.SenderId);
            if (queser is not null)
                return Result.Fail("User already registered");

            if (_context.Quesers.Any(q => q.Name.Equals(arguments.Username)))
                return Result.Fail("Username is already registered");

            return Result.Ok();
        }

        public async Task<IBotMessage> Execute(CommandContainer args)
        {
            var arguments = new Arguments(args);

            _context.Quesers.Add(new Queser(arguments.SenderId, arguments.Username));
            await _context.SaveChangesAsync();

            return new BotTextMessage($"User {arguments.Username} with id {arguments.SenderId} registered");
        }
    }
}