using System;
using System.Collections.Generic;

namespace Fila
{
    class Program
    {
        static List<Contato> contatos;
        static void Main(string[] args)
        {   
            contatos = new List<Contato>();
            do
            {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("_______________________ Agenda de contatos __________________________________");
    
            Console.Clear();
            Console.WriteLine("1 - Inserir Contato");
            Console.WriteLine("2 - Lista Contato");
            Console.WriteLine("3 - Deletar Contato");

             switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            Console.Clear();
                            Console.WriteLine("Informe o nome do contato");
                            string nomeContato = Console.ReadLine();

                            Console.WriteLine("Digite o fone");
                            string foneContato = Console.ReadLine();

                            contatos.Add(new Contato(nomeContato, foneContato));
                        break;
                        case '2':
                            Console.Clear(); 
                            foreach (Contato c in contatos)
                            {
                                Console.WriteLine(c.Nome + " " + c.Fone);
                            } 
                        break;
                        case '3':
                         Console.Clear();
                         Console.WriteLine("Informe a posição do contato pra excluir");
                            int codigo = int.Parse(Console.ReadLine());
                            contatos.RemoveAt(codigo);

                            foreach (Contato c in contatos)
                            {
                                Console.WriteLine(c.Nome + " " + c.Fone);
                            } 
                            
                         break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Indisponível!");
                            break;
                    }
                        
                               

             Console.WriteLine("Você deseja continuar? s p/ sim ...");
            } while (Console.ReadKey().KeyChar == 's');


            
        }
    }
}
