using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DotnetcoreLineBot.Configs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

namespace DotnetcoreLineBot.Filters
{
    public class LineVerifySignatureFilter : IAsyncAuthorizationFilter
    {
        private readonly LineSetting _lineSetting;

        public LineVerifySignatureFilter(IOptions<LineSetting> lineSetting)
        {
            _lineSetting = lineSetting.Value;
        }
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            context.HttpContext.Request.EnableBuffering();
            string requestBody = await new StreamReader(context.HttpContext.Request.Body).ReadToEndAsync();
            context.HttpContext.Request.Body.Position = 0;

            string xLineSignature = context.HttpContext.Request.Headers["X-Line-Signature"].ToString();
            byte[] channelSecret = Encoding.UTF8.GetBytes(_lineSetting.ChannelSecret);
            byte[] body = Encoding.UTF8.GetBytes(requestBody);

            using (HMACSHA256 hmac = new HMACSHA256(channelSecret))
            {
                byte[] hash = hmac.ComputeHash(body, 0, body.Length);
                byte[] xLineBytes = Convert.FromBase64String(xLineSignature);
                if (SlowEquals(xLineBytes, hash) == false)
                {
                    context.Result = new ForbidResult();
                }
            }
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }
    }
}
