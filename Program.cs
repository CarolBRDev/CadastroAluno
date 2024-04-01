using System;

namespace CadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que de ao usuário três opções:
            //            *Adicionar aluno
            //           * Buscar aluno pelo índice
            //           * Exibir todos os alunos(Indice, Id, Nome, Turma)
            //O programa deve executar em loop até que o usuário peça para sair.
            //Utilizer atributos estáticos para incrementar o id do usuário.
            //Utilize uma classe estática com métodos estáticos para armazenar os alunos criados.
            //      
            int opcao;
            Console.WriteLine("Escolha a opção que deseja:\n 1) Adicionar Aluno\n 2) Buscar aluno pelo índice\n 3) Exibir todos os alunos cadastrados\n 4) Sair");
            opcao = int.Parse(Console.ReadLine());

           while (opcao != 4)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você escolheu Adicionar Aluno.\n"); 
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu Buscar aluno pelo índice.\n");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu Exibir todos os alunos cadastrados.\n");
                        break;
                    default:
                        Console.WriteLine("Você deve escolher uma opção. Tente novamente.\n");
                        break;
                }

                Console.WriteLine("Escolha a opção que deseja:\n 1) Adicionar Aluno\n 2) Buscar aluno pelo índice\n 3) Exibir todos os alunos cadastrados\n 4) Sair");
                opcao = int.Parse(Console.ReadLine());
            }
            







        }
    }
}
