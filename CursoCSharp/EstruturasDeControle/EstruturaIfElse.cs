using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            string nota;

            Console.Write("Escreva a sua nota: ");
            nota = Console.ReadLine();
            Double.TryParse(nota, out double saida);

            if (saida >= 7.0) {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que sua obrigação...");
            } else {
                Console.WriteLine("Recuperação!");
            }
        }
    }
}
