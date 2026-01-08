using ChatBoxOpenAI.Models;
using EchoesOfTheRealms;
using System.Net.Http.Json;
using System.Text.Json;

namespace EchoesOfTheRealmsShared.Services
{
    public class AIService(HttpClient client,EotRContext _context)
    {
        public async Task<(string?, string?)> SendMessage(string newMessage, string role, string? preprompt = null)
        {
            var messages = new List<object>();
            {
                if (role == "marchand")
                {
                    messages.Add(
                        new
                        {
                            Role = "system",
                            Content = $"Tu es un marchand dans un monde héroique fantasie qui vit du commercer de la guerre et n'hésite pas à insulter l'utilisateur. Tu vis au moyen-age et si on te parle de chose dont tu n'es pas sencé avoir connaissance. Reponds toujours «...» Contexte: {preprompt}"
                        });
                }
                else if (role == "reine")
                {
                    messages.Add(
                        new
                        {
                            Role = "system",
                            Content = $"Tu es la reine du royaume de Libra et tu exige qu'on te parle avec déférence, dû à ton rang, digne descendante des Déesses. Contexte: {preprompt}"
                        });
                }

                messages = messages
                    .Append(new { Role = "user", Content = newMessage })
                    .ToList();

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

                    // partie pour recupérer un preprompt
                    object[] messagesPourResumeur = [
                        new
                        {
                            Role = "system",
                            Content = "Ton role est de résumer une conversation pour créer un nouveau preprompt system qui contextualisera une conversasion entre une user et un assistant"
                        },
                        ..messages[1..]
                    ];
                    var prepromptResponse = await client.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", new
                        {
                            Model = "gpt-4o",
                            Messages = messagesPourResumeur
                        }
                    );

                    CompletionResponse? data2 = JsonSerializer.Deserialize<CompletionResponse>(await prepromptResponse.Content.ReadAsStringAsync());
                    if (data2 != null)
                    {
                        return (assistantContent, data2.Choices.First().Message.Content);
                    }
                }
                return (null, null);
            }
        }
    }
}
