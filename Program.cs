Album albumExalta = new Album();
albumExalta.Nome = "Cartão Postal";

Genero pagode = new Genero();
pagode.Nome = "Pagode";

Musica musica1 = new Musica();
musica1.Nome = "Cartão Postal";
musica1.Duracao = 256;
musica1.Genero = pagode;


Musica musica2 = new Musica();
musica2.Nome = "Carona do Amor";
musica2.Duracao = 255;
musica2.Genero = pagode;

albumExalta.AdicionarMusica(musica1);
albumExalta.AdicionarMusica(musica2);

albumExalta.ExibirMusicaDoAlbum();