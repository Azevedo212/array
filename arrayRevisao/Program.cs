using System;

class Program
{
    static void Main(string[] args)
    {
        /*int[] notas = new int [4];

        Console.Write("Digite um número: ");
        notas[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite outro número: ");
        notas[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite outro número: ");
        notas[2] = Convert.ToInt32(Console.ReadLine());

        notas[3] = (notas[0] + notas[1] + notas[2]) / 3;
        Console.WriteLine($"A sua média é: {notas[3]}");*/

        List<string> lista1 = new List<string>();
        lista1.Add("Maria"); //adicionar elementos na lista
        lista1.Add("Alex");
        lista1.Add("Anna");
        lista1.Insert(2, "lucas"); //inserir o valor a algum liga especifico

        lista1.Remove("Alex");

        Console.WriteLine(lista1[2]); //usar posição
        int tamanho = lista1.Count; //contar quantas posições tem na lista
        Console.WriteLine(tamanho);

        foreach (string str in lista1) 
        {
            Console.WriteLine(str);
        }

    }
}