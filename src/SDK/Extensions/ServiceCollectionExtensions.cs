using System;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetcoreLineBot.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddLineClients(this IServiceCollection services, IConfiguration configuration)
        {
            string accessToken = configuration.GetSection("LineSetting").GetValue<string>("ChannelAccessToken");
            services.AddHttpClient("profile", c =>
            {
                c.BaseAddress = new Uri("https://api.line.me/v2/bot/profile/");
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            });
            services.AddHttpClient("message", c =>
            {
                c.BaseAddress = new Uri("https://api.line.me/v2/bot/message/reply/");
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            });
            services.AddHttpClient("richmenu", c =>
            {
                c.BaseAddress = new Uri("https://api.line.me/v2/bot/richmenu/");
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            });
        }

    }
}
