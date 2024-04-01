using System;

namespace CadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcao;
            Console.WriteLine("Escolha a opção que deseja:\n 1) Adicionar Aluno\n 2) Buscar aluno pelo id\n 3) Exibir todos os alunos cadastrados\n 4) Sair");
            opcao = int.Parse(Console.ReadLine());

           while (opcao != 4)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você escolheu Adicionar Aluno.\n");
                        Console.WriteLine("Digite o nome do aluno:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite a turma do aluno:");
                        string turma = Console.ReadLine();
                        Aluno aluno = new Aluno(nome, turma);
                        Aluno.AdicionarAluno(aluno);
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu Buscar aluno pelo id.\n");
                        Console.WriteLine("Digite o numero do id:");
                        int id = int.Parse(Console.ReadLine());
                        Aluno alunoEncontrado = Aluno.BuscarAluno(id);
                        Console.WriteLine(alunoEncontrado);
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu Exibir todos os alunos cadastrados.\n"); 
                        Aluno.ExibirAlunos();
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
