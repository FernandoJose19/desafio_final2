// See https://aka.ms/new-console-template for more information

using System;
class Program
{
    
    static void Main()
    {
        //📜 Missão 1.1: A Porta do Inventário(10 XP)
        string[] pocoes = { "Cura", "Mana" };

        // Verifique se pocoes.Length > 0
        if (pocoes.Length > 0)
        {
            // Se sim: Console.WriteLine("Poção consumida!");
            Console.WriteLine("Poção consumida !");
        }
        else
        {
            // Senão: Console.WriteLine("Inventário Vazio!");
            Console.WriteLine("Inventário Vazio!");
        }

        //📜 Missão 1.2: O Guardião da Fila (20 XP)

        int nivelJogador = 55;

        if (nivelJogador >= 55)
        {
            // Se nivelJogador >= 50: "Porta VIP liberada!"
            Console.WriteLine("Porta VIP liberada!");
        }
        else
        {
            // Senão: "Vá para treinamento!"
            Console.WriteLine("Vá para treinamento!");
        }


        //📜 Missão 1.3: Bifurcação na Árvore(30 XP)

        int noAtual = 50;
        int valorProcurado = 85;


        // Compare valorProcurado com noAtual
        if (valorProcurado >= noAtual)
        {
            // Maior: "Ir para DIREITA"
            Console.WriteLine("Ir para DIREITA!");
        }
        else
        {
            // Menor: "Ir para ESQUERDA"
            Console.WriteLine("Ir para ESQUERDA!");
        }

    }
}


