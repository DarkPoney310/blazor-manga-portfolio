using PortFolio.Models;
using PortFolio.Services;
using Xunit;

namespace PortFolio.Tests;

public class BookRepositoryTests
{
    [Fact]
    public void GetAll_ReturnsNonEmptyCatalog()
    {
        var books = BookRepository.GetAll();

        Assert.NotEmpty(books);
    }

    [Fact]
    public void GetAll_HasNoDuplicateSlugs()
    {
        var slugs = BookRepository.GetAll().Select(b => b.Slug).ToList();

        Assert.Equal(slugs.Count, slugs.Distinct(StringComparer.OrdinalIgnoreCase).Count());
    }

    [Theory]
    [InlineData("melotogo")]
    [InlineData("MELOTOGO")]
    [InlineData("MeLoToGo")]
    public void GetBySlug_IsCaseInsensitive(string slug)
    {
        var book = BookRepository.GetBySlug(slug);

        Assert.NotNull(book);
        Assert.Equal("melotogo", book!.Slug);
    }

    [Fact]
    public void GetBySlug_UnknownSlug_ReturnsNull()
    {
        Assert.Null(BookRepository.GetBySlug("does-not-exist"));
    }

    [Fact]
    public void GetByCategory_ReturnsOnlyMatchingCategory()
    {
        var demos = BookRepository.GetByCategory("demo");

        Assert.NotEmpty(demos);
        Assert.All(demos, b => Assert.Equal("demo", b.Category, ignoreCase: true));
    }

    [Fact]
    public void GetNext_StaysWithinSameCategory()
    {
        foreach (var book in BookRepository.GetAll())
        {
            var next = BookRepository.GetNext(book.Slug);
            if (next is not null)
                Assert.Equal(book.Category, next.Category);
        }
    }

    [Fact]
    public void GetPrevious_StaysWithinSameCategory()
    {
        foreach (var book in BookRepository.GetAll())
        {
            var prev = BookRepository.GetPrevious(book.Slug);
            if (prev is not null)
                Assert.Equal(book.Category, prev.Category);
        }
    }

    [Fact]
    public void GetNext_OnLastOfCategory_ReturnsNull()
    {
        // The last "projet" in the catalog has no successor within its category.
        var projects = BookRepository.GetByCategory("projet");
        var last = projects[^1];

        Assert.Null(BookRepository.GetNext(last.Slug));
    }

    [Fact]
    public void GetPrevious_OnFirstOfCategory_ReturnsNull()
    {
        var projects = BookRepository.GetByCategory("projet");
        var first = projects[0];

        Assert.Null(BookRepository.GetPrevious(first.Slug));
    }

    [Fact]
    public void NextAndPrevious_AreSymmetric()
    {
        foreach (var book in BookRepository.GetAll())
        {
            var next = BookRepository.GetNext(book.Slug);
            if (next is null) continue;

            // Stepping forward then back must return to the original book.
            var back = BookRepository.GetPrevious(next.Slug);
            Assert.Equal(book.Slug, back!.Slug);
        }
    }
}
