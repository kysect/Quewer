using System;
using Quewer.BotClient.Commands.QueamCommands;
using Quewer.BotClient.Commands.QueCommands;
using Serilog;
using Tef.BotFramework.Abstractions;
using Tef.BotFramework.Core;

namespace Quewer.BotClient
{
    public class QueBot : IDisposable
    {
        private readonly Bot _botInstance;

        public QueBot(IBotApiProvider apiProvider, ILogger logger)
        {
            _botInstance = new Bot(apiProvider)
                .AddCommand(new AddQueamQueserCommand())
                .AddCommand(new CreateQueamCommand())
                .AddCommand(new DeleteQueamCommand())
                .AddCommand(new RemoveQueamQueserCommand())
                .AddCommand(new CreateQueCommand())
                .AddCommand(new DeleteQueCommand())
                .AddCommand(new QuePopCommand())
                .AddCommand(new QuePushCommand())
                .AddCommand(new QueSwapCommand())
                .AddLogger(logger)
                .SetPrefix('/');
        }

        public void Start()
        {
            _botInstance.Start();
        }

        public void Dispose()
        {
            _botInstance?.Dispose();
        }
    }
}