using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using DotnetcoreLineBot.Configs;
using DotnetcoreLineBot.Interfaces;
using DotnetcoreLineBot.Models.Line;
using Microsoft.Extensions.Options;

namespace DotnetcoreLineBot.Services
{
    public class LineProfileService : ILineProfileService
    {
        private readonly IOptions<LineSetting> _lineSetting;
        private readonly HttpClient _client;

        public LineProfileService(IOptions<LineSetting> lineSetting, IHttpClientFactory clientFactory)
        {
            _lineSetting = lineSetting;
            _client = clientFactory.CreateClient("profile");
        }
        public async Task<UserProfile> GetUserProfile(string userId)
        {
            var response = await _client.GetAsync(userId);

            response.EnsureSuccessStatusCode();

            Stream responseBody = await response.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<UserProfile>(responseBody);
        }

    }
}
