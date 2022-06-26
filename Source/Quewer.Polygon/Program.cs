using System.Threading.Tasks;
using Kysect.BotFramework.ApiProviders.Telegram;
using Kysect.BotFramework.Settings;
using Quewer.BotClient;

namespace Quewer.Polygon;

class Program
{
    static void Main()
    {
        var telegramToken = "";

        var settings = new ConstSettingsProvider<TelegramSettings>(new TelegramSettings(telegramToken));
        var api = new TelegramApiProvider(settings);

        var queBot = new QueBot(api);
        queBot.Start();

        Task.Delay(-1).Wait();
    }
}
