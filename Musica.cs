class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public int DuracaoMinutos => Duracao / 60;
    public int DuracaoRestanteSegundos => Duracao % 60;
    public string DuracaoTotalMusica => $"{DuracaoMinutos}:{DuracaoRestanteSegundos}";
    public bool Disponivel {  get; set; }
    public string DescricaoResumida => $"A música {Nome} pertende a banda {Artista}";


  

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {DuracaoTotalMusica}");

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