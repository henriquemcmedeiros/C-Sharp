public abstract class Animal
{
    public string nome;
    public string cor;
    public string espécie;

    public Animal(string nome, string cor, string espécie)
    {
        this.nome = nome;
        this.cor = cor;
        this.espécie = espécie;
    }

    public abstract void fazerSom();
}
