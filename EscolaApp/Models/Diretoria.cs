namespace Models;

public class Diretoria{
    private Professor Diretor;

    public Diretoria(Professor diretor){
        this.Diretor = diretor;
    }

    public void ExibitDiretoria(){
        this.Diretor.ExibirInfo();
    }
}