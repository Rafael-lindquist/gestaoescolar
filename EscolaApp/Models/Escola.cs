namespace Models;

public class Escola{
    private string Nome;
    private string Endereco;
    private List<Turma> Turmas = new List<Turma>();
    private Diretoria Diretoria;

    public Escola(string nome, string enderoco, Diretoria diretor){
        this.Nome = nome;
        this.Endereco = enderoco;
        this.Diretoria = diretor;
    }

    public void AdicionarTurma(Turma turma){
        this.Turmas.Add(turma);
    }

    public void ListarTurmas(){
        Console.WriteLine($"Turma: {this.Nome}\n");
        foreach (Turma turma in this.Turmas){
            Console.WriteLine(turma.getNome());
        }
    }
    public void ExibirInfo(){
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Idade: {this.Endereco}");
    }

}