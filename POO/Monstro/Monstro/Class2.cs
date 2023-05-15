using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Heroi
{
    public int Vida { get; private set; } = 100;
    public int Dano { get; private set; } = 20;

    public void Ataque(Monstro monstro, Heroi heroi)
    {
        monstro.TomarDano(heroi.Dano);
        Console.WriteLine($"O herói ataca o monstro e causa {heroi.Dano} de dano");
        Console.WriteLine($"Vida atual do Monstro: {monstro.Vida}");
        if (monstro.Vida <= 0)
        {
            Console.WriteLine("O monstro foi derotado!");
        }
    }
}