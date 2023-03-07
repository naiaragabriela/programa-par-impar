int numero;
Console.WriteLine("Informe um valor para verificar se é Par: ");
numero = int.Parse(Console.ReadLine());

imprime(1, 2.0);

if (ehPar(numero))
{
    Console.WriteLine("O valor é Par!");
}
else
{
    Console.WriteLine("O valor é Impar!");
}

bool ehPar(int valor)
{
    bool resposta = false;
    if (valor % 2 == 0)
    {
        resposta = true;
    }
    return resposta;

}
void imprime(int valor, double numero)
{
    Console.WriteLine("O valor é: " + valor);
    Console.WriteLine("O número é: " + numero);
}