using System;
using System.Threading.Tasks;
using DotnetcoreLineBot.Models.RichMenu;

namespace DotnetcoreLineBot.Interfaces
{
    public interface ILineRichMenuService
    {
        Task<RichMenu> CreateRichMenuAsync(CreateRichMenu richmenu);
        Task DeleteRichMenuAsync(string richMenuId);
        Task<RichMenuResponse> GetRichMenuListAsync();
        Task SetDefaultRichMenuAsync(string richMenuId);
        Task<RichMenuResponse> UploadRichMenuImageAsync(string imgUrl, string richMenuId);
    }
}
