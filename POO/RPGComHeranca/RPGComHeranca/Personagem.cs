using System.Diagnostics.CodeAnalysis;

public class Personagem
{
    public int vida;
    public int ataque;
    public int defesa;

    public Personagem(int vida, int ataque, int defesa) {
        this.vida = vida;
        this.ataque = ataque;
        this.defesa = defesa;
    }

    public void PerderVida(int forcaAtaque)
    {
        int ataque = forcaAtaque + this.defesa;

        if (ataque > this.vida)
        {
            Console.WriteLine("Morreu!");
            if(this.vida > 0)
            {
                this.vida -= this.vida;
            }
        }
        else
        {
            this.vida -= ataque;
            Console.WriteLine("Dano sofrido: " + ataque + ", sobrou de hp: " + this.vida);
        }
    }
}
