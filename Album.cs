class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome {  get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public int DuracaoTotalAlbumMinutos => DuracaoTotal / 60;
    public int DuracaoRestanteAlbumSegundos => DuracaoTotal % 60;
    public string DuracaoTotalAlbum => $"{DuracaoTotalAlbumMinutos}:{DuracaoRestanteAlbumSegundos}";
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome} - Duração: {musica.DuracaoTotalMusica} - Gênero: {musica.Genero.Nome}");
        }
        Console.WriteLine($"Duração total do álbum: {DuracaoTotalAlbum}");
    }
}