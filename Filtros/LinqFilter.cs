using MusicAPI.Consumer.Modelos;
namespace MusicAPI.Consumer.Filtros;

// nessse método será responsável por realizar determinados filtros na API.
//static para não preciar criar um objeto com "new"
internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var TodosGenerosMusicas = musicas.Select(generos => generos.Genero).Distinct().ToList();
        //Select para selecionar e O Distinct() para garantir que cada gênero apareça
        //apenas uma vez na lista final.
        //Então, se "pop" aparecia 50 vezes, depois do Distinct() ele aparece apenas uma vez.
        //E o ToList para o resultado (resposta) ser uma lista.
        Console.WriteLine($"Filtrando os gêneros musicais >>>");
            foreach (var generos in TodosGenerosMusicas)
        {
            Console.WriteLine($"- {generos}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => 
        musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
        Console.WriteLine(nomeArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.NomeMusica}");
        }
    }
}
