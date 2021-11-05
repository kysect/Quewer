using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Quewer.Core.DataAccess;
using Quewer.Core.Models;

namespace Quewer.BotClient.Commands.QueamCommands
{
    public class CreateQueamCommand : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<CreateQueamCommand>
        {
            public Descriptor() : base("create-queam", string.Empty, new[] { "Queam name" })
            {
            }
        }

        private class Arguments
        {
            private readonly CommandContainer _command;

            public Arguments(CommandContainer command) => _command = command;
            public long SenderId => _command.Context.SenderInfo.UserSenderId;
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

        public Result<IBotMessage> Execute(CommandContainer args)
        {
            var arguments = new Arguments(args);
            Queser queser = _context.Quesers.Find(arguments.SenderId);
            if (queser is null)
                return Result.Fail("Queser was not registered");

            _context.Queams.Add(new Queam(arguments.QueamName, queser));
            _context.SaveChanges();

            return Result.Ok<IBotMessage>(new BotTextMessage($"Created new queam: {args.Arguments[0]}"));
        }
    }
}