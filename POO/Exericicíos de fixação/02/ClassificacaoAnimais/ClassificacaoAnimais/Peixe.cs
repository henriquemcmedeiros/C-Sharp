public class Peixe : Selvagem, INadar
{
    public enum TipoAgua
    {
        Salgada,
        Doce
    }
    public Peixe(string nome, string cor, string espécie, string habitat, TipoAgua tipoAgua) : base(nome, cor, espécie, habitat) { }

    public void FazerSom()
    {
        Console.WriteLine("O peixe borbulha.");
    }
}