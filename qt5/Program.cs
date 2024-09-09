/*-------------------------------------------------------------------
Questão 5: Escolha de Habilidade Especial
• Contextualização: No jogo, o jogador pode usar habilidades especiais durante a 
batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de 
inimigo e da distância do alvo.
• Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo 
(Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira 
qual habilidade usar com base nos seguintes critérios:
• Mana maior que 50: Use Habilidade Poderosa.
• Inimigo Forte ou Boss: +10 mana necessária.
• Distância menor que 10 metros: Reduz a mana necessária em 5.
• Exiba a habilidade sugerida.

@Lista: 04 - Funções
@Autor: João Wagner
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int mana, distancia;
        string? tipoInimigo,habilidadeSugerida;
        /*int.TryParse(Console.ReadLine(), out );*/

        Console.Write("Digite a quantidade de mana: ");
        int.TryParse(Console.ReadLine(), out mana);

        Console.Write("Digite o tipo de inimigo (Normal, Forte, Boss): ");
        tipoInimigo = Console.ReadLine().ToLower();

        Console.Write("Digite a distância do alvo (em metros): ");
        int.TryParse(Console.ReadLine(), out distancia);

        habilidadeSugerida = SugerirHabilidade(mana, tipoInimigo, distancia);

        Console.WriteLine($"A habilidade sugerida é: {habilidadeSugerida}");

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }

    static string SugerirHabilidade(int mana, string tipoInimigo, int distancia)
    {
        int manaNecessaria = 50;

        if (tipoInimigo == "forte" || tipoInimigo == "boss")
        {
            manaNecessaria += 10;
        }

        if (distancia < 10)
        {
            manaNecessaria -= 5;
        }

        if (mana >= manaNecessaria)
        {
            return "Poderosa";
        }
        else
        {
            return "Outra habilidade";
        }
    }
}