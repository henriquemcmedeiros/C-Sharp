public class Heroi : Personagem
{
    public Heroi(int vida, int ataque, int defesa) : base(vida, ataque, defesa) { }

    public void Atacar(Monstro monstro, bool danoDobrado = false)
    {
        int dano = this.ataque;

        if (danoDobrado)
        {
            dano *= 2;
        }

        if (this.vida <= 0)
        {
            Console.WriteLine("Ele não pode atacar, pois está morto! :(");
        }
        else
        {
            Console.WriteLine("Heroi atacou o Monstro");
            monstro.PerderVida(this.ataque);
        }
    }
}
