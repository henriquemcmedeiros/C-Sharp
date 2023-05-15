using System;
using System.Threading;
public class Program
{
    public static void Main(string[] args)
    {
        var Heroi = new Heroi();
        var monstro = new Monstro();

        Console.WriteLine($"Vida inicial do Monstro: {monstro.Vida}");

        while (monstro.Vida > 0)
        {
            Thread.Sleep(1000);
            Heroi.Ataque(monstro, Heroi);
        }
    }
}