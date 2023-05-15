public class Mago : Heroi
{
    public int mana;
    public Mago(int mana, int hp, int ataque, int defesa) : base(hp, ataque, defesa)
    {
        this.mana = mana;
    }

    public void Atacar(Monstro monstro)
    {
        if (mana > 0)
        {
            mana = mana - 40;
            base.Atacar(monstro, true);
        }
        else
        {
            Console.WriteLine("Mana insuficiente");
        }
    }
}
