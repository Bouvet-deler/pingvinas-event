using Pingvinas.Event.Api.Controllers;

namespace TestProject;

public class AnagramTests
{
    private readonly AnagramController _anagramController = new();


    [Fact]
    public void AreAnagramsReturnsTrueIfAnagram() =>
        Assert.True(_anagramController.AreAnagrams("dusty", "study").Value);

    [Fact]
    public void AreAnagramsReturnsFalseIfNotAnagram() =>
        Assert.False(_anagramController.AreAnagrams("apple", "banana").Value);

    [Fact]
    public void AreAnagramsReturnsTrueIfIdentical() =>
        Assert.True(_anagramController.AreAnagrams("apple", "apple").Value);

    [Fact]
    public void AreAnagramsReturnsFalseIfOnlySimilarCharacters() =>
        Assert.False(_anagramController.AreAnagrams("elephant", "elaphant").Value);

    [Fact]
    public void AreAnagramsReturnsFalseIfOnlyOneCharacters() =>
        Assert.False(_anagramController.AreAnagrams("eeeeeeee", "elephant").Value);

    [Fact]
    public void AreAnagramsReturnsTrueIfAnagramWithSpaces() =>
        Assert.True(_anagramController.AreAnagrams("the morse code", "here come dots").Value);

}