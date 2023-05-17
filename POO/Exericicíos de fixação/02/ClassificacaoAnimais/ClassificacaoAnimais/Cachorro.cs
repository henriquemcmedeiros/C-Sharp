public class Cachorro : Domestico, IAndar
{
    public Cachorro(string nome, string cor, string espécie, string endereço) : base(nome, cor, espécie, endereço) { }

    public void FazerSom()
    {
        Console.WriteLine("O cachorro late.");
    }
}
