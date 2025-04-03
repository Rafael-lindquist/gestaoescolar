using Models;
namespace utils;

public class Database{
    public List<Professor> Professores = new List<Professor>();
    public List<Aluno> Alunos = new List<Aluno>();


    public void CadastrarProfessor(){
        Console.WriteLine("Escolheu cadastrar Professor");
        Console.WriteLine("Cadastro de professor");
        Console.WriteLine("Digite o nome do professor");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a idade do professor");
        int idade = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Digite a disciplina do professor");
        string disciplina = Console.ReadLine();
        Professor professor = new Professor(nome, idade, disciplina);
        this.Professores.Add(professor);
    }

    public void CadastrarAluno(){
        Console.WriteLine("Escolheu cadastrar Aluno");
        Console.WriteLine("Cadastro de Aluno");
        Console.WriteLine("Digite o nome do Aluno");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a idade do Aluno");
        int idade = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Digite a Matricula");
        int matricula = Int32.Parse(Console.ReadLine());
        Aluno aluno = new Aluno(matricula, nome, idade);
        this.Alunos.Add(aluno);
    }
}