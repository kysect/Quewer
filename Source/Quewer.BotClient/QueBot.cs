using System;
using Kysect.BotFramework.ApiProviders;
using Kysect.BotFramework.Core;
using Quewer.BotClient.Commands.QueamCommands;
using Quewer.BotClient.Commands.QueCommands;
using Quewer.Tests;

namespace Quewer.BotClient
{
    public class QueBot : IDisposable
    {
        private readonly BotManager _botInstance;

        public QueBot(IBotApiProvider apiProvider/*, ILogger logger*/)
        {
            BotManagerBuilder builder = new BotManagerBuilder()
                //.AddLogger(logger)
                .SetPrefix('/')
                .AddCommand(new AddQueamQueserCommand.Descriptor())
                .AddCommand(new AddQueamQueserCommand.Descriptor())
                .AddCommand(new CreateQueamCommand.Descriptor())
                .AddCommand(new GetQuemsCommand.Descriptor())
                .AddCommand(new DeleteQueamCommand.Descriptor())
                .AddCommand(new RemoveQueamQueserCommand.Descriptor())
                .AddCommand(new CreateQueCommand.Descriptor())
                .AddCommand(new DeleteQueCommand.Descriptor())
                .AddCommand(new QuePopCommand.Descriptor())
                .AddCommand(new QuePushCommand.Descriptor())
                .AddCommand(new QueSwapCommand.Descriptor());

            builder.ServiceCollection
                .AddQuewerDatabase();

            _botInstance = builder.Build(apiProvider);
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