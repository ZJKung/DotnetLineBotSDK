using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DotnetcoreLineBot.Configs;
using DotnetcoreLineBot.Interfaces;
using DotnetcoreLineBot.Models;
using DotnetcoreLineBot.Models.Line;
using DotnetcoreLineBot.Models.Message;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DotnetcoreLineBot.Services
{
    public class LineReplyMessageService : ILineReplyMessageService
    {
        private readonly ILogger<LineReplyMessageService> _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly HttpClient _client;

        public LineReplyMessageService(IHttpClientFactory clientFactory,
        ILogger<LineReplyMessageService> logger)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            _client = _clientFactory.CreateClient("message");
        }

        public StringContent GetJsonPayload(string body)
        {
            return new StringContent(body, Encoding.UTF8, "application/json");
        }

        public async Task ReplyMessageAsync(string replyToken, params string[] messages)
        {
            //todo mapper
            LineMessageRequest req = new();

            req.ReplyToken = replyToken;

            foreach (var message in messages)
            {
                req.Messages.Add(new TextMessage()
                {
                    Text = message
                });
            }
            string postJson = JsonSerializer.Serialize(req);

            var response = await _client.PostAsync("", GetJsonPayload(postJson));

            response.EnsureSuccessStatusCode();
        }

        public async Task ReplyMessageAsync(string replyToken, IList<IMessage> messages)
        {
            LineMessageRequest req = new();
            req.ReplyToken = replyToken;

            req.Messages.AddRange(messages);

            string postJson = JsonSerializer.Serialize(req);

            _logger.LogInformation(postJson);

            var response = await _client.PostAsync("", GetJsonPayload(postJson));

            _logger.LogInformation(await response.Content.ReadAsStringAsync());

            response.EnsureSuccessStatusCode();
        }
        public async Task ReplyMessageAsync(string replyToken, IList<IRequestMessage> messages)
        {
            LineMessageRequest req = new();
            req.ReplyToken = replyToken;

            foreach (var message in messages)
            {
                if (message is IMessage)
                {
                    req.Messages.Add(message);
                }
                else if (message is ITemplate)
                {
                    req.Messages.Add(new TemplateMessageBase()
                    {
                        Template = message as ITemplate
                    });
                }
            }

            string postJson = JsonSerializer.Serialize(req);

            var response = await _client.PostAsync("", GetJsonPayload(postJson));

            response.EnsureSuccessStatusCode();
        }

        public async Task ReplyTemplateMessageAsync(string replyToken, IList<ITemplate> templates)
        {
            LineMessageRequest req = new();
            req.ReplyToken = replyToken;

            foreach (var template in templates)
            {
                req.Messages.Add(new TemplateMessageBase()
                {
                    Template = template
                });
            }
            string postJson = JsonSerializer.Serialize(req);

            var response = await _client.PostAsync("", GetJsonPayload(postJson));

            response.EnsureSuccessStatusCode();
        }

        public async Task ReplyTemplateMessageAsync(string replyToken, ITemplate template)
        {
            LineMessageRequest req = new();
            req.ReplyToken = replyToken;

            req.Messages.Add(new TemplateMessageBase()
            {
                Template = template
            });

            string postJson = JsonSerializer.Serialize(req);

            var response = await _client.PostAsync("", GetJsonPayload(postJson));

            response.EnsureSuccessStatusCode();

        }

        public async Task ReplyMessageByJsonAsync(string replyToken, string jsonString)
        {
            LineMessageRequest req = new();
            req.ReplyToken = replyToken;

            req.Messages.Add(new FlexMessage()
            {
                Contents = jsonString
            });

            string postJson = JsonSerializer.Serialize(req);

            var response = await _client.PostAsync("", GetJsonPayload(postJson));

            response.EnsureSuccessStatusCode();
        }
        public async Task<Stream> GetContentBytesAsync(string messageId)
        {
            var client = _clientFactory.CreateClient("v2");

            var res = await client.GetAsync($"message/{messageId}/content");

            res.EnsureSuccessStatusCode();

            return await res.Content.ReadAsStreamAsync();
        }

    }
}
