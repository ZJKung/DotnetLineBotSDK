using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using DotnetcoreLineBot.Interfaces;
using DotnetcoreLineBot.Models.RichMenu;
using Microsoft.Extensions.Logging;

namespace DotnetcoreLineBot.Services
{
    public class LineRichMenuService : ILineRichMenuService
    {
        private readonly ILogger<LineRichMenuService> _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly HttpClient _client;

        public LineRichMenuService(IHttpClientFactory clientFactory,
        ILogger<LineRichMenuService> logger)
        {
            _clientFactory = clientFactory;
            _client = clientFactory.CreateClient("richmenu");
            _logger = logger;
        }

        public async Task<RichMenuResponse> GetRichMenuListAsync()
        {
            var res = await _client.GetAsync("list");

            res.EnsureSuccessStatusCode();

            _logger.LogInformation(await res.Content.ReadAsStringAsync());

            var richmenus = await JsonSerializer.DeserializeAsync<RichMenuResponse>(await res.Content.ReadAsStreamAsync());

            return richmenus;
        }
        public async Task<RichMenuResponse> UploadRichMenuImageAsync(string imgUrl, string richMenuId)
        {
            byte[] imgBytes = await (new HttpClient().GetByteArrayAsync(imgUrl));

            var res = await _client.PostAsync($"list/{richMenuId}/content", new ByteArrayContent(imgBytes));

            res.EnsureSuccessStatusCode();

            return await JsonSerializer.DeserializeAsync<RichMenuResponse>(await res.Content.ReadAsStreamAsync());
        }
        public async Task<RichMenu> CreateRichMenuAsync(CreateRichMenu richmenu)
        {
            var postJson = JsonSerializer.Serialize(richmenu);

            var res = await _client.PostAsync("", new StringContent(postJson));

            res.EnsureSuccessStatusCode();

            return await JsonSerializer.DeserializeAsync<RichMenu>(await res.Content.ReadAsStreamAsync());
        }
        public async Task DeleteRichMenuAsync(string richMenuId)
        {
            var res = await _client.DeleteAsync(richMenuId);

            res.EnsureSuccessStatusCode();
        }

        public async Task SetDefaultRichMenuAsync(string richMenuId)
        {
            var client = _clientFactory.CreateClient("v2");

            var res = await _client.PostAsync("/user/all/richmenu/"+richMenuId, null);

            if (res.StatusCode != HttpStatusCode.OK)
            {
                await DeleteRichMenuAsync(richMenuId);
            }
        }
    }
}
