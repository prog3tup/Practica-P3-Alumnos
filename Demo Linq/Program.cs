using Demo_Linq;

var juegos = await JuegosService.Instance.GetOfertasAsync();

Console.WriteLine("Solo juegos que tienen critica > 90");

var buenasCriticas = juegos.Where(j => Int32.Parse(j.SteamRatingPercent) > 90).Select(j => j.InternalName);

foreach (string? buenaCritica in buenasCriticas)
    Console.WriteLine(buenaCritica);