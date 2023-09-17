using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Maria";
        pessoa.Peso = 80.0;
        pessoa.Altura = 1.78;

        Console.WriteLine("Cálculo de IMC"); 

        Console.WriteLine($"O nome da pessoa é: {pessoa.Nome}");

        Console.WriteLine($"O seu índice de IMC é: {pessoa.IndiceIMC()}");
    }
}
