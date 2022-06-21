using System;
using Kysect.BotFramework.ApiProviders;
using Kysect.BotFramework.Core;
using Quewer.BotClient.Commands.QueamCommands;
using Quewer.BotClient.Commands.QueCommands;
using Quewer.BotClient.Commands.QueserCommands;
using Quewer.BotClient.Tools;

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
                .AddCommand<AddQueamQueserCommand>()
                .AddCommand<AddQueamQueserCommand>()
                .AddCommand<CreateQueamCommand>()
                .AddCommand<GetQueamsCommand>()
                .AddCommand<DeleteQueamCommand>()
                .AddCommand<RemoveQueamQueserCommand>()
                .AddCommand<CreateQueCommand>()
                .AddCommand<DeleteQueCommand>()
                .AddCommand<QuePopCommand>()
                .AddCommand<QuePushCommand>()
                .AddCommand<QueSwapCommand>()
                .AddCommand<RegisterQueser>()
                ;

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