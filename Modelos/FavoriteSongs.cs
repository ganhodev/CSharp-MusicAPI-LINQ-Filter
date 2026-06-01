namespace MusicAPI.Consumer.Modelos;

internal class FavoriteSongs
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; set; }

    public FavoriteSongs(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas do usuário -> {Nome} ");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.NomeMusica} de {musica.Artista}");
        }
        Console.WriteLine();
    }
}
