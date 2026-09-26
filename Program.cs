using System;

namespace Calculadora_Gamer_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis para os status do Guerreiro
            int ataqueGuerreiro, defesaMonstro;
            double multiplicadorCritico;
            
            Console.Write("========================================\n");
            Console.Write("     SIMULADOR DE COMBATE RPG & MATH    \n");
            Console.Write("========================================\n");

            // 1. Entrada de dados e Conversão Explicita (Convert)
            Console.Write("\nDigite o valor de ATAQUE do Guerreiro = ");
            ataqueGuerreiro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de DEFESA do Monstro = ");
            defesaMonstro = Convert.ToInt32(Console.ReadLine());

            // 2. Uso de Double e Conversão Explícita (Casting de maior para menor tipo)
            multiplicadorCritico = 2.5;
            
            // Forçando o multiplicador que é double a virar um número inteiro (Casting explicito)
            int bonusCritico = (int)multiplicadorCritico; 

            // 3. Operações Matemáticas (Lógica do Combate)
            int danoSimples = ataqueGuerreiro - defesaMonstro;
            int danoCritico = (ataqueGuerreiro * bonusCritico) - defesaMonstro;
            int ataqueDuplo = ataqueGuerreiro + ataqueGuerreiro;
            
            // Divisão usando Casting para double para não perder as casas decimais
            double chanceDeAcerto = (double)ataqueGuerreiro / (ataqueGuerreiro + defesaMonstro);

            // 4. Exibição dos Resultados na Tela
            Console.Write("\n========================================");
            Console.Write("\n           RESULTADO DO TURNO           ");
            Console.Write("\n========================================");
            Console.Write("\nDano do Ataque Simples (Subtração) = " + danoSimples);
            Console.Write("\nDano do Ataque Crítico (Multiplicação) = " + danoCritico);
            Console.Write("\nPotencial de Ataque Duplo (Soma) = " + ataqueDuplo);
            Console.Write("\nChance de Acerto do Golpe (Divisão) = " + chanceDeAcerto);
            Console.Write("\n========================================\n");

            // Mensagem explicativa dos conceitos aplicados
            Console.Write("\n[CONCEITOS APLICADOS NESTE PROJETO]:");
            Console.Write("\n- Conversão Implícita e Explícita (Casting de maior para menor tipo)");
            Console.Write("\n- Operações Aritméticas Básicas de TI\n");
        }
    }
}

