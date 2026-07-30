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