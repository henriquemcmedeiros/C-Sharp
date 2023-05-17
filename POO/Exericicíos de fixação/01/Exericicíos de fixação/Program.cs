Formas forma = new Formas();

while (true)
{
    int escolha = 0;
    double lado = 0;
    double altura = 0;
    double raio = 0;

    Console.WriteLine("Escolha a forma que deseja descobrir a área:");
    Console.WriteLine("[1] Triangulo");
    Console.WriteLine("[2] Quadrado/Retângulo");
    Console.WriteLine("[3] Circulo");
    Console.WriteLine("[4] Sair do programa");
    Console.Write("Escolha: ");

    escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1: 
            Console.Write("Digite o lado: ");
            lado = Convert.ToInt64(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"A área é: {forma.calcAreaTriangulo(lado, altura)}");
            break;
        case 2:
            Console.Write("Digite o lado: ");
            lado = Convert.ToInt64(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"A área é: {forma.calcAreaQuadrado(lado, altura)}");
            break;
        case 3:
            Console.Write("Digite o raio: ");
            raio = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"A área é: {forma.calcAreaCirculo(raio)}");
            break;
    }
    break;
}

