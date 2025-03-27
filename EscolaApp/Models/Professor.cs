namespace Models;

public class Professor : Pessoa {
    private string Disciplina;

    public Professor(string nome, int idade, string disciplina) : base(nome, idade){
        this.Disciplina = disciplina;
    }

    public void Ensinar(){
        Console.WriteLine("Estou ensinando...");
    }
}