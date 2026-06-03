using MusicAPI.Consumer.Modelos;
using System.Text.Json;
using MusicAPI.Consumer.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); //1° método.
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas); //2° método.
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");// 3° método.
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");// 4° método.

        //var musicasFavoritasDoGanho = new FavoriteSongs("Ganho");
        //musicasFavoritasDoGanho.AdicionarMusicasFavoritas(musicas[1]);
        //musicasFavoritasDoGanho.AdicionarMusicasFavoritas(musicas[2]);
        //musicasFavoritasDoGanho.AdicionarMusicasFavoritas(musicas[3]);
        //musicasFavoritasDoGanho.AdicionarMusicasFavoritas(musicas[4]);
        //musicasFavoritasDoGanho.AdicionarMusicasFavoritas(musicas[5]);


        //var musicasFavoritasDoGuilherme = new FavoriteSongs("Guilherme");
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[532]);
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[512]);
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[56]);
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[21]);
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[92]);

        //musicasFavoritasDoGuilherme.ExibirMusicasFavoritas();
        //musicasFavoritasDoGuilherme.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema {ex.Message}");
    }
}