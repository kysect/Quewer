using System;
using FluentResults;
using Kysect.BotFramework.Core.BotMessages;
using Kysect.BotFramework.Core.CommandInvoking;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Quewer.Core.DataAccess;
using Quewer.Core.Models;

namespace Quewer.BotClient.Commands.QueamCommands
{
    public class CreateQueamCommand : IBotSyncCommand
    {
        public static Guid TempKey = Guid.NewGuid();
        public class Descriptor : BotCommandDescriptor<CreateQueamCommand>
        {
            public Descriptor() : base("create-queam", string.Empty, new[] { "Queam name" })
            {
            }
        }

        private readonly QuewerDbContext _context;

        public CreateQueamCommand(QuewerDbContext context)
        {
            _context = context;
        }

        public Result CanExecute(CommandArgumentContainer args)
        {
            return Result.Ok(true);
        }

        public Result<IBotMessage> Execute(CommandArgumentContainer args)
        {
            //TODO: HACK
            Queser queser = _context.Quesers.Find(TempKey);
            if (queser is null)
            {
                EntityEntry<Queser> entityEntry = _context.Quesers.Add(Queser.Create("Fake"));
                queser = entityEntry.Entity;
            }

            _context.Queams.Add(Queam.Create(args.Arguments[0], queser));
            _context.SaveChanges();

            return Result.Ok<IBotMessage>(new BotTextMessage($"Created new queam: {args.Arguments[0]}"));
        }
    }
}