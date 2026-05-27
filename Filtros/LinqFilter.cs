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
            foreach (var generos in TodosGenerosMusicas)
        {
            Console.WriteLine($"- {generos}");
        }
    }
}
