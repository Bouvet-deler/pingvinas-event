using Microsoft.AspNetCore.Mvc;
using Pingvinas.Event.Api.Controllers;

namespace TestProject;

public class AnagramTests
{
    [Fact]
    public async void AreAnagramsReturnsTrueIfAnagram()
    {
        AnagramController? anagramController = new();

        Assert.False(await anagramController.AreAnagrams("apple", "banana"));
        Assert.True(await anagramController.AreAnagrams("dusty", "study"));
        Assert.False(await anagramController.AreAnagrams("elephant", "eeeeeeee"));
        Assert.True(await anagramController.AreAnagrams("the morse code", "here come dots"));
    }
}