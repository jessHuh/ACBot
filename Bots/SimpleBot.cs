using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace demo1.Bots
{
    public class SimpleBot : IBot
    {
        public SimpleBot()
        {
        }

        public async  Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {

            if (turnContext.Activity.Type is ActivityTypes.Message)
            {
                string input = turnContext.Activity.Text;
                await turnContext.SendActivityAsync($"SimpleBot: {input}");
            }
        }
    }
}
