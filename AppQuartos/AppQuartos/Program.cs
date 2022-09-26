using System;
using System.Numerics;

namespace AppQuartos {
    class Program {
        static void Main(string[] args) {

            Pessoa[] quartos = new Pessoa[10];

            Console.Write("How many rooms will be rented? ");
            int qtdQuartos = int.Parse(Console.ReadLine());



            for (int i = 1; i <= qtdQuartos; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i};");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                quartos[room] = new Pessoa(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
            }
        }
    }
}
