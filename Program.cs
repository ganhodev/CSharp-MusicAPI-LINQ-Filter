using MusicAPI.Consumer.Modelos;
using System.Text.Json;
using MusicAPI.Consumer.Filtros;

using (HttpClient client = new HttpClient())
// por padrão a variável HttpClient é chamado de client
{
    //try indica o caminho a ser seguido primeiramente, caso tenha erro, entra o catch para ir por outaro caminho, exibindo o erro 
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Async é pq não sabemos de fato o tamanho do recurso que estaremos recebendo e ele garante
        //que vai ser possível receber todos esses recursos, sem o Async,
        //ele recebe uma parte e já passa para a próxima instrução.
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //Ao adicionar o ! no final, garante que o resultado do Deserialize não vai ser nulo".
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); //1° método.
        //Um filtro é um mecanismo que seleciona ou organiza dados de acordo com critérios específicos.
        //criei a classe LinqFilter justamente para isso: aplicar filtros na minha lista
        //de músicas. O primeiro filtro que desenvolvi foi FiltrarTodosOsGenerosMusicais(),
        //que pega todos os gêneros únicos da lista e os exibe.
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas); //2° método.
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");// 3° método.
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");// 4° método.
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema {ex.Message}");
    }
}