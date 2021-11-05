using System.Linq;
using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.Commands;
using Quewer.Core.DataAccess;
using Quewer.Core.Models;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class CreateQueCommand : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<CreateQueCommand>
        {
            public Descriptor() : base("create-que", string.Empty, new[] { "Queam name", "Que name" })
            {
            }
        }
        private class Arguments
        {
            private readonly CommandContainer _command;

            public Arguments(CommandContainer command) => _command = command;
            public long SenderId => _command.Context.SenderInfo.UserSenderId;
            public string QueamName => _command.Arguments[0];
            public string QueName => _command.Arguments[0];
        }

        private readonly QuewerDbContext _context;

        public CreateQueCommand(QuewerDbContext context)
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

            Queam queam = _context.Queams.SingleOrDefault(q => q.Name.Equals(arguments.QueamName));
            if (queam is null)
                return Result.Fail("Queam was not found");

            Que que = queam.CreateNewQue(queser, arguments.QueName);

            _context.Ques.Add(que);
            _context.SaveChanges();

            return Result.Ok<IBotMessage>(new BotTextMessage($"Que {que.Title} was crated."));
        }
    }
}