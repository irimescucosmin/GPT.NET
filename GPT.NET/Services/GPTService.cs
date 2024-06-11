using GPT.NET.Interfaces;
using OpenAI.Chat;
using OpenAI.Models;

namespace GPT.NET.Services;

public class GPTService(IConfiguration configuration) : IGTPService
{
    private string APIKey { get; } = configuration.GetSection("OpenAI:ApiKey").Get<string>() ?? throw new InvalidOperationException();

    public async Task<IEnumerable<string>> GetResponseAsync(string prompt, string? model = "gpt-4o")
    {
        var response = await new ChatClient(model, APIKey)
            .CompleteChatAsync([new UserChatMessage(prompt)]);

        return response.Value.Content.Select(x => x.Text);
    }

    public async Task<IEnumerable<string>> ModelsAsync()
    {
        var models = await new ModelClient(APIKey).GetModelsAsync();
        return models.Value.Select(x => x.Id);
    }
}