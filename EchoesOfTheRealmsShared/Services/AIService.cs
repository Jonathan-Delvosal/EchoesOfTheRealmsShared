using ChatBoxOpenAI.Models;
using EchoesOfTheRealms;
using System.Net.Http.Json;
using System.Text.Json;

namespace EchoesOfTheRealmsShared.Services
{
    public class AIService(HttpClient client)
    {
        public async Task<(string? assistant, string? newPreprompt)> SendMessage(string newMessage,string role, string? preprompt = null)
        {
            var messages = BuildConversation(role, preprompt, newMessage);

            var main = await CallChatAsync(messages);
            if (main?.Choices is null || main.Choices.Count == 0)
                throw new HttpRequestException();

            var assistantContent = main.Choices[0].Message.Content;

            messages.Add(new ChatMessage("assistant", assistantContent));

            var summaryMessages = BuildPrepromptSummarizer(messages.Skip(1));
            var summary = await CallChatAsync(summaryMessages);

            var newSystemPreprompt = summary?.Choices?.FirstOrDefault()?.Message.Content;
            return (assistantContent, newSystemPreprompt);
        }

        private List<ChatMessage> BuildConversation(string role, string? preprompt, string userMessage)
        {
            var system = role switch
            {
                "marchand" => $"Tu es un marchand dans un monde héroïque fantasy qui vit du commerce de la guerre et n'hésite pas à insulter l'utilisateur. Tu vis au moyen-âge et si on te parle de chose dont tu n'es pas censé avoir connaissance, réponds toujours «...». Contexte: {preprompt}",
                "reine" => $"Tu es la reine du royaume de Libra et tu exiges qu'on te parle avec déférence, dû à ton rang, digne descendante des Déesses. Contexte: {preprompt}",
                _ => $"Contexte: {preprompt}"
            };

            return new List<ChatMessage>
            {
                new("system", system),
                new("user", userMessage)
            };
        }

        private List<ChatMessage> BuildPrepromptSummarizer(IEnumerable<ChatMessage> conversationWithoutInitialSystem)
        {
            var messages = new List<ChatMessage>
            {
                new("system", "Ton rôle est de résumer une conversation pour créer un nouveau preprompt system qui contextualisera une conversation entre un user et un assistant.")
            };

            messages.AddRange(conversationWithoutInitialSystem);
            return messages;
        }

        private async Task<CompletionResponse?> CallChatAsync(List<ChatMessage> messages)
        {
            using var response = await client.PostAsJsonAsync(
                "https://api.openai.com/v1/chat/completions",
                new
                {
                    model = "gpt-4o-mini",
                    messages = messages.Select(m => new { role = m.Role, content = m.Content })
                });

            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CompletionResponse>(json);
        }

        public sealed record ChatMessage(string Role, string Content);
    }
}
