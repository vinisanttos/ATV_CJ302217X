namespace ATV_CJ302217X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========MENU==========");
            Console.WriteLine("Digite 1 para Exercicio 1");
            Console.WriteLine("Digite 2 para Exercicio 2");
            Console.WriteLine("Digite 3 para Exercicio 3");
            Console.WriteLine("Digite 4 para Exercicio 4");
            Console.WriteLine("Digite 5 para Exercicio 5");
            Console.WriteLine("Digite 6 para Exercicio 6");
            Console.WriteLine("Digite 7 para Exercicio 7");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    int numero;
                    Console.Write("Digite um número inteiro: ");
                    numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números de 1 até {0} ", numero);

                    int a = 1;
                    while (a <= numero)
                    {
                        Console.WriteLine(a);
                        a++;
                    }
                    break;

                case 2:
                    int numeros;
                    Console.WriteLine("Digite um número inteiro:");
                    numeros = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números pares de 1 até {0} ", numeros);

                    int b = 1;
                    while (b <= numeros)
                    {
                        if (b % 2 == 0)
                        {
                            Console.WriteLine(b);
                        }
                        b++;
                    }
                    break;

                case 3:

                    int nu;

                    Console.WriteLine("Digite um número inteiro menor que 1000:");
                    nu = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números pares de 1000 até");

                    int c = 0;
                    while (c <= nu)
                    {
                        if (c % 2 == 0)
                        {
                            Console.WriteLine(c);
                        }
                        c++;
                    }
                    break;

                case 4:

                    int num;
                    Console.WriteLine("Digite um número inteiro:");
                    num = int.Parse(Console.ReadLine());

                    int somaPositivos = 0;
                    while (somaPositivos <= 200)
                    {
                        if (num >= 0)
                        {
                            Console.WriteLine(num);
                            somaPositivos += num;
                            Console.WriteLine("A soma dos números positivos é {0}.", somaPositivos);
                        }
                    }
                    break;

                case 5:
                    int n1;
                    Console.WriteLine("Digite um número inteiro:");
                    n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de {0}", n1);

                    int divisor = 1;
                    while (divisor <= n1)
                    {
                        if (n1 % divisor == 0)
                        {
                            Console.WriteLine(divisor);
                        }
                        divisor++;

                    }
                    break;


                case 6:

                    int contador = 0;
                    int quantidadeNumeros = 10;
                    int maiorNumero = 0;
                    int menorNumero = 0;

                    Console.WriteLine("Digite 10 números:");

                    while (contador <= quantidadeNumeros)
                    {
                        Console.Write("Número ");
                        Console.Write(contador + 1);
                        Console.Write(": ");
                        int n2 = int.Parse(Console.ReadLine());

                        if (n2 > maiorNumero)
                        {
                            maiorNumero = n2;
                        }
                        else
                        {
                            menorNumero = n2;
                        }
                        contador++;
                    }
                    Console.Write("O maior número digitado foi: ");
                    Console.WriteLine(maiorNumero);
                    Console.Write("O menor número digitado foi: ");
                    Console.WriteLine(menorNumero);
                    break;

                case 7:

                    int somaPares = 0;
                    int somaImpares = 0;

                    Console.WriteLine("Digite uma sequência de números. Digite 0 para encerrar.");

                    int n3 = 0;
                    while (n3 <= somaImpares)
                    {
                        if (n3 % 2 == 0)
                        {
                            somaPares += n3;
                        }
                        else
                        {
                            somaImpares += n3;
                        }
                    }

                    Console.WriteLine("A soma dos números pares é: {0}", somaPares);
                    Console.WriteLine("A soma dos números ímpares é: {0}", somaImpares);
                    break;

            }
        }
    }
}