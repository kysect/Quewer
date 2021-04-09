﻿using System.Threading.Tasks;
using FluentResults;
using Kysect.BotFramework.Core.CommandInvoking;

namespace Quewer.BotClient.Commands.QueamCommands
{
    public class RemoveQueamQueserCommand : IBotCommand
    {
        public Result CanExecute(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<string>> ExecuteAsync(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }

        public string CommandName { get; } = "add-queam-queser";
        public string Description { get; }
        public string[] Args { get; } = { "Queam name", "Queser id" };
    }
}