using Azure.Core;
using Bot.Builder.Community.Adapters.Infobip.WhatsApp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Builder;
using System.Threading.Tasks;

namespace InfoBipDemo1.Controllers
{
    [Route("api/infobip/whatsapp")]
    [ApiController]
    public class InfobipController : ControllerBase
    {
        private readonly InfobipWhatsAppAdapter Adapter;
        private readonly IBot Bot;

        public InfobipController(InfobipWhatsAppAdapter adapter, IBot bot)
        {
            Adapter = adapter;
            Bot = bot;
        }

        [HttpPost]
        public async Task PostAsync()
        {
            // Delegate the processing of the HTTP POST to the adapter.
            // The adapter will invoke the bot.
            await Adapter.ProcessAsync(Request, Response, Bot);
        }
    }
}
