using System.Linq;
using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Quewer.Core.DataAccess;
using Quewer.Core.Models;

namespace Quewer.BotClient.Commands.QueserCommands
{
    public class RegisterQueser : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<RegisterQueser>
        {
            public Descriptor() : base("register", "Use this command for register in system.", new[] { "Queser name" })
            {
            }
        }

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

        public Result<IBotMessage> Execute(CommandContainer args)
        {
            var arguments = new Arguments(args);

            _context.Quesers.Add(new Queser(arguments.SenderId, arguments.Username));
            _context.SaveChanges();

            return Result.Ok<IBotMessage>(new BotTextMessage($"User {arguments.Username} with id {arguments.SenderId} registered"));
        }
    }
}