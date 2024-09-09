/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
• Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para 
recuperar a vida do seu personagem durante a batalha. A quantidade de vida 
recuperada depende do tipo de poção, do nível do personagem e da quantidade de 
poções usadas.
• Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o 
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a 
quantidade de vida recuperada com base nos seguintes critérios:
• Poção Pequena: 10 pontos de vida por poção.
• Poção Média: 20 pontos de vida por poção.
• Poção Grande: 30 pontos de vida por poção.
• Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
• Exiba o total de vida recuperada.

@Lista: 04 - Funções
@Autor: João Wagner
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int nivel, quantidade, vidaRecuperada;
        string? tipoPocao;

        Console.Write("Digite o tipo de poção (Pequena, Média, Grande): ");
        tipoPocao = Console.ReadLine();
        Console.Write("Digite o nível do personagem: ");
        int.TryParse(Console.ReadLine(), out nivel);

        Console.Write("Digite a quantidade de poções usadas: ");
        int.TryParse(Console.ReadLine(), out quantidade);

        vidaRecuperada = CalcularVidaRecuperada(tipoPocao, nivel, quantidade);

        Console.WriteLine($"A vida total recuperada é de {vidaRecuperada} pontos.");

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }

    

    static int CalcularVidaRecuperada(string tipoPocao, int nivel, int quantidade)
    {
        var pontosBase = new Dictionary<string, int>
            {
                {"pequena", 10},
                {"média", 20},
                {"grande", 30}
            };

        /*Bônus por nível acima de 5*/

        int bonusNivel = Math.Max(nivel - 5, 0) * 5;

        int vidaPorPocao = pontosBase[tipoPocao] + bonusNivel;

        return vidaPorPocao * quantidade;
    }
    }
