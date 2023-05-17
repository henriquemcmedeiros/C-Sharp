public class Formas
{
    double pi = Math.PI;
    public double calcAreaTriangulo(double lado, double altura)
    {
        return (lado * altura) / 2;
    }

    public double calcAreaQuadrado(double lado, double altura)
    {
        return (lado * altura);
    }
    public double calcAreaCirculo(double raio)
    {
        return pi * raio * raio;
    }
}

