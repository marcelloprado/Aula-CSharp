class Podcast
{
    private List<Episodio> episodios = new();
    private string v1;
    private string v2;

    public Podcast(string v1, string v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public Podcast(string host, string nome, int totalEpisodio)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio) 
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy( e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódio.");
    }
}