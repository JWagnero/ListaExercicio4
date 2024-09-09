/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação de Missões
• Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar 
missões. A pontuação é calculada com base na dificuldade da missão, na quantidade 
de inimigos derrotados e no tempo gasto para completar.
• Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil), 
o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para 
calcular a pontuação da missão usando os seguintes critérios:
• Fácil: 5 pontos por inimigo, sem penalidade de tempo.
• Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
• Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
• Exiba a pontuação final do jogador.

@Lista: 04 - Funções
@Autor: João Wagner
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {   
        int inimigosDerrotados, tempoGasto, pontuacao;
        string? dificuldade;

     /*int.TryParse(Console.ReadLine(), out quantidade);*/

        Console.Write("Digite a dificuldade da missão (Fácil, Média, Difícil): ");
        dificuldade = Console.ReadLine();

        Console.Write("Digite o número de inimigos derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigosDerrotados);

        Console.Write("Digite o tempo gasto (em minutos): ");
        int.TryParse(Console.ReadLine(), out tempoGasto);

        pontuacao = CalcularPontuacao(dificuldade, inimigosDerrotados, tempoGasto);

        Console.WriteLine($"A pontuação final do jogador é: {pontuacao}");

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }

    static int CalcularPontuacao(string? dificuldade, int inimigosDerrotados, int tempoGasto)
    {
        int pontosPorInimigo = 0;
        int penalidadePorMinuto = 0;

        switch (dificuldade)
        {
            case "fácil":
                pontosPorInimigo = 5;
                break;
            case "média":
                pontosPorInimigo = 10;
                penalidadePorMinuto = -2;
                break;
            case "difícil":
                pontosPorInimigo = 15;
                penalidadePorMinuto = -5;
                break;
            default:
                Console.WriteLine("Dificuldade inválida.");
                return 0;
        }

        int pontuacaoBase = inimigosDerrotados * pontosPorInimigo;
        int penalidadeTempo = Math.Max(0, tempoGasto - (dificuldade == "fácil" ? 10 : 15)) * penalidadePorMinuto;
        return pontuacaoBase + penalidadeTempo;
    }
}