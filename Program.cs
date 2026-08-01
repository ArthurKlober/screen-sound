Banda exaltasamba = new Banda("Exaltasamba");

Album albumExalta = new Album("Cartão Postal");

Genero pagode = new Genero("Pagode");

Musica musica1 = new Musica(exaltasamba, "Cartão Postal", pagode)
{
    Duracao = 256,
    Disponivel = true
};

Musica musica2 = new Musica(exaltasamba, "Carona do Amor", pagode)
{
    Duracao = 255,
    Disponivel = true
};

exaltasamba.AdicionarAlbum(albumExalta);
albumExalta.AdicionarMusica(musica1);
albumExalta.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumExalta.ExibirMusicaDoAlbum();

exaltasamba.ExibirDiscografia();

Console.WriteLine("\n ##### PODCASTS ##### \n");

Podcast podcast1 = new Podcast("SharpCast", "Arthur Klober");

Episodio episodio1 = new Episodio("Bem-vindos ao podcast!", 35, 1);
episodio1.AdicionarConvidados("Giulia");
episodio1.AdicionarConvidados("Pedro");

//Console.WriteLine(episodio1.Resumo);

Episodio episodio2 = new Episodio("Inicialização de um construtor.", 40, 2);
episodio2.AdicionarConvidados("Nuki");

//Console.WriteLine(episodio2.Resumo);

podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);

podcast1.ExibirDetalhes();