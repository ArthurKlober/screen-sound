class Podcast
{
    public Podcast(string nome, string host)
    {
        Host = host;
        Nome = nome;
    }
    public string Host {  get;}
    public string Nome { get;}
    public int TotalEpisodios => listaEpisodios.Count();

    public List<Episodio> listaEpisodios = new List<Episodio>();

    public void AdicionarEpisodio(Episodio episodio)
    {
        listaEpisodios.Add(episodio);
        Console.WriteLine($"O episódio {episodio.Titulo} foi adicionado ao podcast {Nome}!");
    }

    public void ExibirDetalhes()
    {
        // Nome e host
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        // Lista de episódios
        if (listaEpisodios.Count > 0)
        {
            foreach (Episodio episodio in listaEpisodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"{episodio.Resumo}");
                
            }
        } else
        {
            Console.WriteLine($"O podcast {Nome} ainda não possui episódios!");
        }
        // Total de episódios
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }
}