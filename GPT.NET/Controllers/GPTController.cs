using GPT.NET.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GPT.NET.Controllers;

[Route("[controller]/[action]")]
public class GPTController(IGTPService gtpService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Models()
    {
        return Ok( await gtpService.ModelsAsync());
    }
    [HttpGet]
    public async Task<IActionResult> Ask(string prompt, string? model)
    {
        return Ok( await gtpService.GetResponseAsync(prompt, model));
    }
}