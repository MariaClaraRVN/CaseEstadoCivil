using System;

class Program {
  public static void Main (string[] args) {

    int op; // opção escolhida pelo usuario;
    Console.WriteLine("1- Solteiro");
    Console.WriteLine("2- Casado");
    Console.WriteLine("3- Divorciado");
    Console.WriteLine("4- Viuvo");
    Console.WriteLine("Escolha uma das opções: ");
    op = int.Parse(Console.ReadLine());

    switch (op) {
    case 1:
      Console.WriteLine("Você precisa sair mais!!");
      break;

    case 2:
      Console.WriteLine("Surpreenda a pessoa que te suporta, infeliz!!");
      break;

    case 3:
      Console.WriteLine("Procure um advogado em uma balada!!");
      break;

    case 4: 
      Console.WriteLine("Meus pesames, sinto muito... Mas, ninguem é uma ilha, vá em busca de novos amores!!");
      break;

    default:
      Console.WriteLine("Opção invalida!!");
      break;
      
      }
  }
}