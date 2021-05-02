using System.Linq;
using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.CommandInvoking;
using Quewer.Core.DataAccess;

namespace Quewer.BotClient.Commands.QueamCommands
{
    public class GetQueamsCommand : IBotSyncCommand
    {
        public class Descriptor : BotCommandDescriptor<GetQueamsCommand>
        {
            public Descriptor() : base("get-queam", string.Empty)
            {
            }
        }

        private QuewerDbContext _context;

        public GetQueamsCommand(QuewerDbContext context)
        {
            _context = context;
        }

        public Result CanExecute(CommandArgumentContainer args)
        {
            return Result.Ok(true);
        }

        public Result<IBotMessage> Execute(CommandArgumentContainer args)
        {
            //TODO: it's temp solution
            string message = string.Join(", ", _context.Queams.ToList().Select(q => q.Name));
            return Result.Ok<IBotMessage>(new BotTextMessage($"Queams: {message}"));
        }
    }
}