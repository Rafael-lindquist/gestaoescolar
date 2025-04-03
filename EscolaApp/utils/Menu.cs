using System.Globalization;
namespace utils;

public class Menu{
    public static void exibir(){ // static permite usar sem instanciar 
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Cadastrar professor");
    }

    public static int escolherOpcao(){
        string? opcao = Console.ReadLine();
        return Int32.Parse(opcao);
    }
}