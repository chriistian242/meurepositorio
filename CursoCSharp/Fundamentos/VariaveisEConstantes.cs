using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
        
    class VariaveisEConstantes {    
        public static void Executar() {
            // Area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            // Tipos internos 

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade = " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("Menor valor " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor do long " + menorValorLong);

            ulong populacaoMundial = 7_600_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoApple = 1000000000000.00;
            Console.WriteLine("O valor de mercado da apple é " + valorDeMercadoApple); // Mais usado dos reais

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância das estrelas é: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao meu universo";
            Console.WriteLine(texto);
        }
    }
}
