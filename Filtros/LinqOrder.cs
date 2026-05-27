using MusicAPI.Consumer.Modelos;

namespace MusicAPI.Consumer.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica =>
        musica.Artista).Distinct().ToList();
        Console.WriteLine("Lita de artistas ordenados:");
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"-`{artista}");
        }
    }
}
