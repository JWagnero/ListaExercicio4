/*-------------------------------------------------------------------
Questão 3: Cálculo de Dano Crítico
• Contextualização: Em combates, o jogador pode realizar ataques críticos que causam 
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e 
da arma utilizada.
• Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico 
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o 
dano crítico da seguinte forma:
• Espada: +10 pontos ao dano total.
• Arco: +5 pontos ao dano total.
• Cajado: +15 pontos ao dano total.
• Exiba o dano total causado pelo ataque crítico.

@Lista: 04 - Funções
@Autor: João Wagner
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int ataqueBase, danoCritico;
        double multiplicadorCritico;
        string? tipoArma;

        Console.Write("Digite o valor do ataque base: ");
        int.TryParse(Console.ReadLine(), out ataqueBase);

        Console.Write("Digite o multiplicador crítico (1.5, 2, 3): ");
        double.TryParse(Console.ReadLine(), out multiplicadorCritico);

        Console.Write("Digite o tipo de arma (Espada, Arco, Cajado): ");
        tipoArma = Console.ReadLine();

        danoCritico = CalcularDanoCritico(ataqueBase, multiplicadorCritico, tipoArma);

        Console.WriteLine($"O dano total causado pelo ataque crítico é: {danoCritico}");

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }

    static int CalcularDanoCritico(int ataqueBase, double multiplicadorCritico, string? tipoArma)
    {
        int bonusArma = 0;

        switch (tipoArma)
        {
            case "espada":
                bonusArma = 10;
                break;
            case "arco":
                bonusArma = 5;
                break;
            case "cajado":
                bonusArma = 15;
                break;
            default:
                Console.WriteLine("Tipo de arma inválido.");
                return 0;
        }

        double danoBaseComMultiplicador = ataqueBase * multiplicadorCritico;
        int danoTotal = (int)Math.Round(danoBaseComMultiplicador) + bonusArma;
        return danoTotal;
    }
}