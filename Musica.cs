class Musica
{
    public Musica(Banda artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public string Nome { get;}
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public int DuracaoMinutos => Duracao / 60;
    public int DuracaoRestanteSegundos => Duracao % 60;
    public string DuracaoTotalMusica => $"{DuracaoMinutos}:{DuracaoRestanteSegundos}";
    public bool Disponivel {  get; set; }
    public string DescricaoResumida => $"A música {Nome} pertende a banda {Artista}";
    public Genero Genero { get; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {DuracaoTotalMusica}");
        Console.WriteLine($"Gênero: {Genero.Nome}");

        if (Disponivel)
        {
            Console.WriteLine($"Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adiquira o plano.");
        }
    }
}