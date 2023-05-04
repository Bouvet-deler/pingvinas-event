using Microsoft.AspNetCore.Mvc;
using Pingvinas.Event.Api.Controllers;

namespace TestProject;

public class AnagramTests
{
    [Fact]
    public async void AreAnagramReturnsTrueIfAnagram()
    {
        AnagramController? anagramController = new();

        Assert.False(await anagramController.AreAnagram("apple", "banana"));
        Assert.True(await anagramController.AreAnagram("dusty", "study"));
        Assert.False(await anagramController.AreAnagram("elephant", "eeeeeeee"));
        Assert.True(await anagramController.AreAnagram("the morse code", "here come dots"));
    }
}