namespace Pokedex.Api;
public record LocationAreaPage(
    int Count,
    string? Next,
    string? Previous,
    List<LocationAreaRef> Results);
public record LocationAreaRef(string Name, string Url);