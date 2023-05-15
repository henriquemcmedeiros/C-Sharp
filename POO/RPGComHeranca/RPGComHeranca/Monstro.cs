public class Monstro : Personagem
{
    public Monstro(int vida, int ataque, int defesa) : base(vida, ataque, defesa) { }

    public void Atacar(Heroi heroi)
    {
        if (this.vida <= 0)
        {
            Console.WriteLine("Ele não pode atacar, pois está morto! :)");
        }
        else
        {
            Console.WriteLine("Monstro ataca o Heroi");
            heroi.PerderVida(this.ataque);
        }

    }
}
