using Microsoft.AspNetCore.Mvc;

namespace Pingvinas.Event.Api.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AnagramController
{
    [HttpGet($"/{nameof(AreAnagram)}")]
    public async Task<bool> AreAnagram(string word, string potentialAnagram)
    {
        return word == potentialAnagram;
    }
}