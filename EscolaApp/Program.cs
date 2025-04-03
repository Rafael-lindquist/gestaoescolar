using System.ComponentModel;
using Models;
using utils;

Database banco = new Database();

while (true){
    Menu.exibir();
    int opcao = Menu.escolherOpcao();
    switch (opcao) {
        case 1:
            banco.CadastrarProfessor();
            break;
        case 2:
            Console.WriteLine("Escolheu cadastrar Professor");
            break;
        default:
            return;
    }
}