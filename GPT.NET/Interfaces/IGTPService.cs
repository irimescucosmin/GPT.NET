namespace GPT.NET.Interfaces;

public interface IGTPService
{
    Task<IEnumerable<string>> ModelsAsync();
    Task<IEnumerable<string>> GetResponseAsync(string prompt, string? model = "gpt-4o");
}