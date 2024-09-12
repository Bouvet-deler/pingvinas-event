using Microsoft.AspNetCore.Mvc;

namespace Pingvinas.Event.Api.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AnagramController
{
    [HttpGet($"/{nameof(AreAnagrams)}")]
    public bool AreAnagrams(string word, string potentialAnagram)
    {
        // TODO: Eirik says this is not correct, whattodo?
        return word == potentialAnagram;
    }
}