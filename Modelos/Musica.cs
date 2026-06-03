using System.Text.Json.Serialization;

namespace MusicAPI.Consumer.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? NomeMusica { get; set; }

    [JsonPropertyName("artist")]
    public String? Artista { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Musica: {NomeMusica}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Duração em segundos: {Duracao /1000}");
        Console.WriteLine($"Tonalidade: {Key}");
    }
}
