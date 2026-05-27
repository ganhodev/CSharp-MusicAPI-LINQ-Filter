using System.Text.Json.Serialization;

namespace MusicAPI.Consumer.Modelos;

internal class Musica
{
    // Em outras linguagens chama-se Anotação. Mas em c#, chama-se Atributo esse código que serve
    // para indicar qual campo do JSON ela deve mapear [JsonPropertyName("")].
    [JsonPropertyName("song")]
    // essa linha a cima faz com que essa propriedade "NomeMusica" seja apontada para o
    // campo song do Json, (geralmente é necessario traduzir APIs para a linguagem determinada.
    public string? NomeMusica { get; set; }
    //Sem o ?, a propriedade NomeMusica seria obrigada a sempre ter um valor.
    //Com o ?, ela pode ter um valor ou ser nula.
    //Na prática, isso é importante porque nem sempre a API vai retornar todos os dados preenchidos.
    [JsonPropertyName("artist")]
    public String? Artista { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Musica: {NomeMusica}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Duração em segundos: {Duracao /1000}");
    }
}
