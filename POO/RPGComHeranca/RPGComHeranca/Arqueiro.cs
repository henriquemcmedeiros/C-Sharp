public class Arqueiro : Heroi
{
    public int NumFlechas;
    public Arqueiro(int NumFlechas, int hp, int ataque, int defesa) : base(hp, ataque, defesa) {
        this.NumFlechas= NumFlechas;
    }

    public void Atacar(Monstro monstro)
    {
        if (this.NumFlechas > 0)
        {
            this.NumFlechas--;
            base.Atacar(monstro);
        }
        else
        {
            Console.WriteLine("Flechas insuficientes");
        }
    }
}

