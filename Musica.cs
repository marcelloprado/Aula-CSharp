class Musica
{
    public string? Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero? Genero { get; set; }
    public string DescricaoResumida =>
     $"A música {Nome} pertence a banda {Artista}";
    

    //? Vamos criar um método
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Disponível no plano");
        }
        else
        {
            Console.WriteLine($"Adquira o plano Plus+");
        }
    }
}