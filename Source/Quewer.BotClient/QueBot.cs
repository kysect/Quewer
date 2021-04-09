using System;
using Kysect.BotFramework.ApiProviders;
using Kysect.BotFramework.Core;
using Quewer.BotClient.Commands.QueamCommands;
using Quewer.BotClient.Commands.QueCommands;
using Serilog;

namespace Quewer.BotClient
{
    public class QueBot : IDisposable
    {
        private readonly BotManager _botInstance;

        public QueBot(IBotApiProvider apiProvider, ILogger logger)
        {
            _botInstance = new BotManager(apiProvider)
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