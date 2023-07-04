using OpenAI_API;

namespace BlazorWasmTester
{
    public class ChatGptIntegration
    {
        private OpenAIAPI api;

        public ChatGptIntegration(string apiKey)
        {
            api = new OpenAIAPI(apiKey);
        }

        public async Task<string> SimpleQueryWithConditioning(string question, string systemMessage = null,
            List<(string exampleQuestion, string exampleResponse)> conditioning = null)
        {
            var chat = api.Chat.CreateConversation();
            /// give instruction as System
            chat.AppendSystemMessage(systemMessage);

            if (conditioning != null)
            {
                foreach (var condition in conditioning) 
                {
                    // give a few examples as user and assistant
                    chat.AppendUserInput(condition.exampleQuestion);
                    chat.AppendExampleChatbotOutput(condition.exampleResponse);
                }
            }            

            // now let's ask it a question'
            chat.AppendUserInput(question);
            // and get the response
            string response = await chat.GetResponseFromChatbotAsync();

            return response;
        }

    }
}
