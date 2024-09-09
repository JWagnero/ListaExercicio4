/*-------------------------------------------------------------------
Questão 4: Sistema de Resgate em Labirinto
• Contextualização: Em um jogo de exploração, o jogador precisa resgatar aliados 
perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da 
distância até o aliado e do nível de ameaça no caminho.
• Comando: Crie um programa que receba a energia do jogador, a distância até o aliado 
(em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine 
se o resgate é possível com base nas seguintes condições:
• Energia maior que 50: Resgate bem-sucedido.
• Distância menor que 20 metros: +10 de energia.
• Nível de ameaça:
o Baixo: Sem penalidade.
o Médio: -10 de energia.
o Alto: -20 de energia.
• Exiba se o resgate foi bem-sucedido ou falhou

@Lista: 04 - Funções
@Autor: João Wagner
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {   
        int energia, distancia;
        string? nivelAmeaca;

       /*int.TryParse(Console.ReadLine(), out );*/

        Console.Write("Digite a energia do jogador: ");
        int.TryParse(Console.ReadLine(), out energia);

        Console.Write("Digite a distância até o aliado (em metros): ");
        int.TryParse(Console.ReadLine(), out distancia);

        Console.Write("Digite o nível de ameaça (baixo, médio, alto): ");
        nivelAmeaca = Console.ReadLine().ToLower();

        bool resgateBemSucedido = RealizarResgate(energia, distancia, nivelAmeaca);

        if (resgateBemSucedido)
        {
            Console.WriteLine("Resgate bem-sucedido!");
        }
        else
        {
            Console.WriteLine("Resgate falhou.");
        }

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
    

    static bool RealizarResgate(int energia, int distancia, string nivelAmeaca)
    {
        if (energia <= 50)
        {
            return false; //Energia insuficiente
        }

        if (distancia < 20)
        {
            energia += 10;
        }

        switch (nivelAmeaca)
        {
            case "médio":
                energia -= 10;
                break;
                
            case "alto":
                energia -= 20;
                break;
        }

        return true;
    }
}