public class Selvagem : Animal
{
    public string habitat;

    public Selvagem(string nome, string cor, string espécie, string habitat) : base(nome, cor, espécie)
    {
        this.habitat = habitat;
    }

    public override void fazerSom()
    {
        throw new NotImplementedException();
    }
}
