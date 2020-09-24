using Telegram.Bot;
using Telegram.Bot.Types;

namespace RandomizingBot.Models.Commands
{
    public class RndCommand : Command
    {
        public override string Name => "Hello";
        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            //Logica
            await client.SendTextMessageAsync(chatId, "Hello, this is randomizer bot", replyToMessageId: messageId);
        }
    }
}
