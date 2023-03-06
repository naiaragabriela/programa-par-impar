int numero;

int Numero()
{
    Console.WriteLine("Escreva um número: ");
    return int.Parse(Console.ReadLine());
}

numero = Numero();

void ParImpar()
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("O número digitado é par");
    }else
    {
        Console.WriteLine("O número digitado é ímpar");
    }
}
ParImpar();