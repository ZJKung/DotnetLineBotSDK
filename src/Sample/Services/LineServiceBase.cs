using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Models.Line;

namespace Sample.Services
{
    public class LineServiceBase
    {
        public async Task RunAsync(IEnumerable<LineEvent> events)
        {
            foreach (var e in events)
            {
                switch (e.Type)
                {
                    case WebhookEventType.Message:
                        await OnMessageAsync(e);
                        break;
                    case WebhookEventType.Follow:
                        await OnFollowAsync(e);
                        break;
                    case WebhookEventType.Unfollow:
                        await OnUnfollowAsync(e);
                        break;
                    case WebhookEventType.Postback:
                        await OnUnPostbackAsync(e);
                        break;
                    case WebhookEventType.Beacon:
                        await OnBeaconAsync(e);
                        break;
                    default:
                        break;
                }
            }
        }

        protected virtual Task OnMessageAsync(LineEvent ev) => Task.CompletedTask;
        protected virtual Task OnFollowAsync(LineEvent ev) => Task.CompletedTask;
        protected virtual Task OnUnfollowAsync(LineEvent ev) => Task.CompletedTask;
        protected virtual Task OnUnPostbackAsync(LineEvent ev) => Task.CompletedTask;
        protected virtual Task OnBeaconAsync(LineEvent ev) => Task.CompletedTask;
    }
}