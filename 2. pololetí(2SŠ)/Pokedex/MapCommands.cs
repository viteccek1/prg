using Pokedex.Api;

namespace Pokedex;

public class MapCommands
{
    public static async Task Map(PokedexState state)
    {
        var response = await state.Api.GetLocationAreasAsync(state.NextLocationsUrl);
        if (response == null) return;

        state.NextLocationsUrl = response.Next;
        state.PreviousLocationsUrl = response.Previous;
        
        Console.WriteLine("Locations:");
        foreach (var location in response.Results)
        {
            Console.WriteLine(location.Name.ToString());
        }
    }
    
    public static async Task MapBack(PokedexState state)
    {
        if (state.PreviousLocationsUrl == null)
        {
            Console.WriteLine("You're on the first page.");
            return;
        }
        var response = await state.Api.GetLocationAreasAsync(state.PreviousLocationsUrl);
        if (response == null) return;

        state.NextLocationsUrl = response.Next;
        state.PreviousLocationsUrl = response.Previous;

        Console.WriteLine("Locations:");
        foreach (var location in response.Results)
        {
            Console.WriteLine(location.Name.ToString());
        }
    }
}