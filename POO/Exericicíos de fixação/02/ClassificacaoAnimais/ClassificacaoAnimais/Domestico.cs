public class Domestico : Animal
{
    public string endereço;

    public Domestico(string nome, string cor, string espécie, string endereço) : base(nome, cor, espécie)
    {
        this.endereço = endereço;
    }

    public override void fazerSom()
    {
        throw new NotImplementedException();
    }
}
