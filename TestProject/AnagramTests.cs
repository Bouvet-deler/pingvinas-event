using Microsoft.AspNetCore.Mvc;
using Pingvinas.Event.Api.Controllers;

namespace TestProject;

public class AnagramTests
{
    private readonly AnagramController _anagramController = new();


    [Fact]
    public async Task AreAnagramsReturnsTrueIfAnagram() =>
        Assert.True(await _anagramController.AreAnagrams("dusty", "study"));

    [Fact]
    public async Task AreAnagramsReturnsFalseIfNotAnagram() =>
        Assert.False(await _anagramController.AreAnagrams("apple", "banana"));

    [Fact]
    public async Task AreAnagramsReturnsTrueIfIdentical() =>
        Assert.True(await _anagramController.AreAnagrams("apple", "apple"));

    [Fact]
    public async Task AreAnagramsReturnsFalseIfOnlySimilarCharacters() =>
        Assert.False(await _anagramController.AreAnagrams("elephant", "elaphant"));

    [Fact]
    public async Task AreAnagramsReturnsFalseIfOnlyOneCharacters() =>
        Assert.False(await _anagramController.AreAnagrams("eeeeeeee", "elephant"));

    [Fact]
    public async Task AreAnagramsReturnsTrueIfAnagramWithSpaces() =>
        Assert.True(await _anagramController.AreAnagrams("the morse code", "here come dots"));

}