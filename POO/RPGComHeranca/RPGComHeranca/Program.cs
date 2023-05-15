Guerreiro guerreiro = new Guerreiro(500, 30, 20);
Arqueiro arqueiro = new Arqueiro(5, 230, 10, 20);
Mago mago = new Mago(100, 180, 35, 5);

Monstro monstro = new Monstro(800, 45, 10);

for (int i = 0; i < 10; i++)
{
    guerreiro.Atacar(monstro);
    arqueiro.Atacar(monstro);
    mago.Atacar(monstro);

    monstro.Atacar(guerreiro);
    monstro.Atacar(arqueiro);
    monstro.Atacar(mago);

    Console.WriteLine("------------------------------------------");
}