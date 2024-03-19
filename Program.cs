// Banda queen = new Banda("Queem");

// Album albumDoQueen = new Album("A night at the opera");

// Musica musica1 = new Musica(queen, "love of my life") 
// { 
//     Duracao = 213, 
//     Disponivel = true, 
// };

// Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
// {
//     Duracao = 354,
//     Disponivel = false,

// };

// albumDoQueen.AdicionarMusica(musica1);
// albumDoQueen.AdicionarMusica(musica2);
// queen.AdicionarAlbum(albumDoQueen);

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumDoQueen.ExibirMusicasDoAlbum();
// queen.ExibirDiscografia();


Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Camila");
ep1.AdicionarConvidados("Marcello");

Episodio ep2 = new(2, "Técnicas de Aprendizado", 67);
ep2.AdicionarConvidados("Fernanda");
ep2.AdicionarConvidados("Flavia");
ep2.AdicionarConvidados("Marcos");

Podcast podcast = new("podcast especial", "Marcello");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();