using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;
using DotnetcoreLineBot.Models.Line;

namespace Sample.Services
{
    public class LineService : LineServiceBase
    {
        private readonly ILineMessageService _lineMessageService;

        public LineService(ILineMessageService lineMessageService)
        {
            _lineMessageService = lineMessageService;
        }
        /// <summary>
        /// Basic Echo Robot
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        protected override async Task OnMessageAsync(LineEvent ev)
        {
            if (ev.Message.Type.Equals(LineMessageType.text))
            {
                await _lineMessageService.ReplyMessageAsync(ev.ReplyToken, ev.Message.Text);
            }
        }
    }
}