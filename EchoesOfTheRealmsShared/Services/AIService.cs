using ChatBoxOpenAI.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace EchoesOfTheRealmsShared.Services
{
    public class AIService(HttpClient client)
    {
        public async Task<string?> SendMessage(string newMessage, string role)
        {
            var messages = new List<object>();
            {
                if (role == "marchand")
                {
                    messages.Add(
                        new
                        {
                            Role = "system",
                            Content = "Tu es un marchand dans un monde héroique fantasie qui vit du commercer de la guerre et n'hésite pas à insulter l'utilisateur"
                        });
                }
                else if (role == "reine")
                {
                    messages.Add(
                        new
                        {
                            Role = "system",
                            Content = "Tu es la reine du royaume de Libra et tu exige qu'on te parle avec déférence, dû à ton rang, digne descendante des Déesses"
                        });
                }

                messages = messages.Append(
                    new { Role = "user", Content = newMessage }
                ).ToList();

                var response = await client.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", new
                {
                    Model = "gpt-4o",
                    Messages = messages
                }
                );

                string content = await response.Content.ReadAsStringAsync();
                // déserialiser en object c#
                CompletionResponse? data = JsonSerializer.Deserialize<CompletionResponse>(content);
                if (data != null)
                {
                    string assistantContent = data.Choices.First().Message.Content;
                    messages = messages.Append(new
                    {
                        Role = "assistant",
                        Content = assistantContent
                    }).ToList();
                    return assistantContent;
                }
                return null;
            }
        }
    }
}
