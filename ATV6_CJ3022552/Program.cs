//atividade 1
int soma = 0;
int contador0 = 0;
Console.WriteLine("digite um numero inteiro");
int n1 = int.Parse(Console.ReadLine());
while (contador0 < n1) 
    contador0++;
Console.WriteLine(contador0);
 
//atividade 2 

    
       Console.WriteLine("Digite um número inteiro:");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Números pares de 1 até " + numero + ":");
        for (int i = 1; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }

     //Atividade 3
    case 3:
    Console.WriteLine("Atividade 3");
    Console.WriteLine("Digite um número inteiro: ");
    int n3 = int.Parse(Console.ReadLine());
    int contador2 = 1000;

    while (contador2 >= n3)
    {
        if (contador2 % 2 == 0)
        {
            Console.WriteLine(contador2);
        }
        contador2 -= 1;
    }
    break;
//Atividade 4
case 4:
    Console.WriteLine("Atividade 4");
    int n4 = 0, soma = 0;

    while (soma != 200)
    {
        Console.WriteLine("Digite um número inteiro: ");
        n4 = int.Parse(Console.ReadLine());
        if (n4 > 0)
        {
            soma += n4;
            if (soma >= 200)
            {
                Console.WriteLine("A soma chegou a 200.");
            }
        }
    }
    break;
//Atividade 5
case 5:
    Console.WriteLine("Atividade 5");
    Console.Write("Digite um número inteiro: ");
    int n5 = int.Parse(Console.ReadLine());
    int contador3 = 1;

    Console.Write("Divisores de " + n5 + ": ");

    while (contador3 <= n5)
    {
        contador3++;
        if (n5 % contador3 == 0)
        {
            Console.WriteLine(contador3 + "");
        }
    }
    break;
//Atividade 6
case 6:
    Console.WriteLine("Atividade 6");
    Console.WriteLine("Digite 10 números, um por linha: ");
    int[] n6 = new int[10];
    int contador4 = 0;

    while (contador4 < 10)
    {
        Console.Write($"Digite um número {contador4 + 1}: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            n6[contador4] = number;
            contador4++;
        }
        else
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
    }

    int maior_num = n6.Max();
    int menor_num = n6.Min();

    Console.WriteLine($"O maior número é: {maior_num}");
    Console.WriteLine($"O menor número é: {menor_num}");
    break;

//Atividade 7
case 7:
    Console.WriteLine("Atividade 7");
    int numero, somaPar = 0, somaImpar = 0;

    Console.WriteLine("Digite uma sequência de números (digite 0 para encerrar):");

    while (true)
    {
        Console.Write("Número: ");
        numero = int.Parse(Console.ReadLine());

        if (numero == 0)
            break;

        if (numero % 2 == 0)
            somaPar += numero;
        else
            somaImpar += numero;
    }

    Console.WriteLine($"A soma dos números pares é: {somaPar}");
    Console.WriteLine($"A soma dos números ímpares é: {somaImpar}");
    break;
}




