using Bot.Builder.Community.Adapters.Infobip.WhatsApp;
using Microsoft.Extensions.Logging;

namespace InfoBipDemo1.Adapters
{
    public class InfobipWhatsAppAdapterWithErrorHandler : InfobipWhatsAppAdapter
    {
        public InfobipWhatsAppAdapterWithErrorHandler(InfobipWhatsAppAdapterOptions infobipWhatsAppOptions, IInfobipWhatsAppClient infobipWhatsAppClient, ILogger<InfobipWhatsAppAdapterWithErrorHandler> logger)
            : base(infobipWhatsAppOptions, infobipWhatsAppClient, logger)
        {
            OnTurnError = async (turnContext, exception) =>
            {
                OnTurnError = async (turnContext, exception) =>
                {
                    // Log any leaked exception from the application.
                    logger.LogError($"Exception caught : {exception.Message}");

                    // Send a catch-all apology to the user.
                    await turnContext.SendActivityAsync("Sorry, it looks like something went wrong.");
                };
            };
        }
    }
}
