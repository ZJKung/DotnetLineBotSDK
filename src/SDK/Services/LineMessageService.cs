using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotnetcoreLineBot.Interfaces;
using DotnetcoreLineBot.Models.Line;
using DotnetcoreLineBot.Models.Message;
using DotnetcoreLineBot.Models.RichMenu;

namespace DotnetcoreLineBot.Services
{
    public class LineMessageService : ILineMessageService
    {
        private readonly ILineProfileService _profileService;
        private readonly ILineRichMenuService _richService;
        private readonly ILineReplyMessageService _messageService;

        public LineMessageService(ILineProfileService profileService,
        ILineRichMenuService richService,
        ILineReplyMessageService messageService
        )
        {
            _profileService = profileService;
            _richService = richService;
            _messageService = messageService;
        }
        public async Task<RichMenu> CreateRichMenuAsync(CreateRichMenu richmenu)
        {
            return await _richService.CreateRichMenuAsync(richmenu);
        }

        public async Task DeleteRichMenu(string richMenuId)
        {
            await _richService.DeleteRichMenuAsync(richMenuId);
        }

        public async Task<Stream> GetContentBytesAsync(string messageId)
        {
            return await _messageService.GetContentBytesAsync(messageId);
        }

        public async Task<List<string>> GetRichMenuListAsync()
        {
            var menus = await _richService.GetRichMenuListAsync();
            return menus.RichMenus.Count == 0 ? new List<string>() : menus.RichMenus.Select(x => x.RichMenuId).ToList();
        }

        public async Task<UserProfile> GetUserProfile(string userId)
        {
            return await _profileService.GetUserProfile(userId);
        }

        public async Task ReplyMessageAsync(string replyToken, IList<IMessage> messages)
        {
            await _messageService.ReplyMessageAsync(replyToken, messages);
        }

        public async Task ReplyMessageAsync(string replyToken, IList<IRequestMessage> messages)
        {
            await _messageService.ReplyMessageAsync(replyToken, messages);
        }

        public async Task ReplyMessageAsync(string replyToken, params string[] messages)
        {
            await _messageService.ReplyMessageAsync(replyToken, messages);
        }

        public async Task ReplyMessageByJsonAsync(string replyToken, string jsonString)
        {
            await _messageService.ReplyMessageByJsonAsync(replyToken, jsonString);
        }

        public async Task ReplyTemplateMessageAsync(string replyToken, ButtonTemplate template)
        {
            await _messageService.ReplyTemplateMessageAsync(replyToken, template);
        }

        public async Task ReplyTemplateMessageAsync(string replyToken, CarouselTemplate template)
        {
            await _messageService.ReplyTemplateMessageAsync(replyToken, template);
        }

        public async Task ReplyTemplateMessageAsync(string replyToken, ConfirmTemplate template)
        {
            await _messageService.ReplyTemplateMessageAsync(replyToken, template);
        }

        public async Task ReplyTemplateMessageAsync(string replyToken, IList<ITemplate> templates)
        {
            await _messageService.ReplyTemplateMessageAsync(replyToken, templates);
        }

        public async Task ReplyTemplateMessageAsync(string replyToken, ImageCarouselTemplate template)
        {
            await _messageService.ReplyTemplateMessageAsync(replyToken, template);
        }

        public async Task SetDefaultRichMenuAsync(string richMenuId)
        {
            await _richService.SetDefaultRichMenuAsync(richMenuId);
        }

        public async Task UploadRichMenuImage(string imgUrl, string richMenuId)
        {
            await _richService.UploadRichMenuImageAsync(imgUrl, richMenuId);
        }
    }
}
