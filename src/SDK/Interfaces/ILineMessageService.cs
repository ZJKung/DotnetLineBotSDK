using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using DotnetcoreLineBot.Models;
using DotnetcoreLineBot.Models.Line;
using DotnetcoreLineBot.Models.Message;
using DotnetcoreLineBot.Models.RichMenu;

namespace DotnetcoreLineBot.Interfaces
{
    public interface ILineMessageService
    {
        Task<RichMenu> CreateRichMenuAsync(CreateRichMenu richmenu);
        Task DeleteRichMenu(string richMenuId);
        Task<Stream> GetContentBytesAsync(string messageId);
        Task<List<string>> GetRichMenuListAsync();
        Task<UserProfile> GetUserProfile(string userId);
        Task ReplyMessageAsync(string replyToken, IList<IMessage> messages);
        Task ReplyMessageAsync(string replyToken, IList<IRequestMessage> messages);
        Task ReplyMessageAsync(string replyToken, params string[] messages);
        Task ReplyMessageByJsonAsync(string replyToken, string jsonString);
        Task ReplyTemplateMessageAsync(string replyToken, ButtonTemplate template);
        Task ReplyTemplateMessageAsync(string replyToken, CarouselTemplate template);
        Task ReplyTemplateMessageAsync(string replyToken, ConfirmTemplate template);
        Task ReplyTemplateMessageAsync(string replyToken, IList<ITemplate> templates);
        Task ReplyTemplateMessageAsync(string replyToken, ImageCarouselTemplate template);
        Task SetDefaultRichMenuAsync(string richMenuId);
        Task UploadRichMenuImage(string imgUrl, string richMenuId);
    }
}
