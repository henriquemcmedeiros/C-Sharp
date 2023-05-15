public class Guerreiro : Heroi
{
    public Guerreiro(int hp, int ataque, int defesa) : base(hp, ataque, defesa) { }

    public void Atacar(Monstro monstro)
    {
        base.Atacar(monstro, false);
        base.Atacar(monstro, false);
    }
}
