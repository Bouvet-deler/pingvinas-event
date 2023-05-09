using Microsoft.AspNetCore.Mvc;
using Pingvinas.Event.Api.Controllers;

namespace TestProject;

public class AnagramTests
{
    private readonly AnagramController _anagramController = new();


    [Fact]
    public async void AreAnagramsReturnsTrueIfAnagram() =>
        Assert.True(await _anagramController.AreAnagrams("dusty", "study"));

    [Fact]
    public async void AreAnagramsReturnsFalseIfNotAnagram() =>
        Assert.False(await _anagramController.AreAnagrams("apple", "banana"));

    [Fact]
    public async void AreAnagramsReturnsTrueIfIdentical() =>
        Assert.True(await _anagramController.AreAnagrams("apple", "apple"));

    [Fact]
    public async void AreAnagramsReturnsFalseIfOnlySimilarCharacters() =>
        Assert.False(await _anagramController.AreAnagrams("elephant", "elaphant"));

    [Fact]
    public async void AreAnagramsReturnsFalseIfOnlyOneCharacters() =>
        Assert.False(await _anagramController.AreAnagrams("eeeeeeee", "elephant"));

    [Fact]
    public async void AreAnagramsReturnsTrueIfAnagramWithSpaces() =>
        Assert.True(await _anagramController.AreAnagrams("the morse code", "here come dots"));

}