using System;
using System.Net.Http.Headers;
using DotnetcoreLineBot.Configs;
using DotnetcoreLineBot.Interfaces;
using DotnetcoreLineBot.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetcoreLineBot
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLineBotSDK(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();

            services.Configure<LineSetting>(configuration.GetSection("LineSetting"));

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

            services.AddHttpClient("v2", c =>
            {
                c.BaseAddress = new Uri("https://api.line.me/v2/bot/");
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            });

            services.AddSingleton<ILineRichMenuService, LineRichMenuService>();

            services.AddSingleton<ILineProfileService, LineProfileService>();

            services.AddSingleton<ILineReplyMessageService, LineReplyMessageService>();

            services.AddTransient<ILineMessageService, LineMessageService>();

            return services;
        }
    }
}
