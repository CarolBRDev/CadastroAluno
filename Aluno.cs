using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAluno
{
    public class Aluno
    {
        private static int _indice = 0; //atributo privado da classe -> contará o numero de instancias do objeto
        private int _id; //atributo privado do objeto - numero identificador da instacia do objeto
        public string Nome;
        public string Turma;
        private static Aluno[] Alunos = new Aluno[10];//inicializa o array Alunos com abjetos da classe Aluno, com capacidade para armazenar até 10 objetos Aluno

        public int Id //propriedade do objeto que permite acesso ao atributo privado do objeto _id e nao permite modificação fora da classe
        {
            get
            {
                return _id;
            }
        }


        //contrutor da classe 
        public Aluno(string nome, string turma) 
        {
            
            _id = _indice + 1;
            Nome = nome;
            Turma = turma;
            //_indice++;
        }

        //metodos

        public static void AdicionarAluno(Aluno aluno)
        {
            Alunos[_indice]= aluno; //o array "Alunos", na posição "_indice" recebe "aluno"
            _indice++;
            
        }

        public static Aluno BuscarAluno(int _id) //metodo publico estático que retorna um objeto Aluno a partir do _id (numero identificador do objeto)
        {
            _indice = _id - 1; //transforma o numero de id do objeto no valor do´_indice (para localizar o obeto no array - que começa com 0 enquanto o primeiro numero identificador do objeto é 1)       
            return Alunos[_indice];
        }

        public static void ExibirAlunos() //metodo publico para exibir a lista completa de alunos cadastrados no array
        {
            foreach (var aluno in Alunos) //para cada objeto "aluno" no array "Alunos"
            {
                Console.WriteLine(aluno);
            }
        }

    public override string ToString()
        {
            return $"Id: {_id}\nAluno: {Nome} \nTurma: {Turma}"; //cda vez que pedir para descrever um objeto "aluno", essa sera a forma de representação
        }

    }

    
}
