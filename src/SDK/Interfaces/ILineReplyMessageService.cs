using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DotnetcoreLineBot.Interfaces
{
    public interface ILineReplyMessageService
    {
        Task<Stream> GetContentBytesAsync(string messageId);
        Task ReplyMessageAsync(string replyToken, params string[] messages);
        Task ReplyMessageAsync(string replyToken, IList<IMessage> messages);
        Task ReplyMessageAsync(string replyToken, IList<IRequestMessage> messages);
        Task ReplyMessageByJsonAsync(string replyToken, string jsonString);
        Task ReplyTemplateMessageAsync(string replyToken, IList<ITemplate> templates);
        Task ReplyTemplateMessageAsync(string replyToken, ITemplate template);
    }
}