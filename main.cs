using System;

class Program {
  public static void Main (string[] args) {
   double Alcool;
    double Gasolina;
    int verificar = 1;
    while (verificar == 1) {
    Console.WriteLine("Digite Valor Alcool:");
    Alcool = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite Valor Gasolina:");
    Gasolina = double.Parse(Console.ReadLine());

    if((Alcool/Gasolina) >  0.70) {
      Console.WriteLine ("Abastecer com Gasolina!");
    }    
    else if ((Alcool/Gasolina) <  0.70) {
      Console.WriteLine ("Abastecer com Alcool!");
    }
    else if ((Alcool/Gasolina) ==  0.70) {
      Console.WriteLine ("Abastecer com o que desejar!");
    }
    Console.WriteLine("Deseja consultar novamente?");
    Console.WriteLine("Digite 1 para iniciar, 2 para sair");
    verificar = int.Parse(Console.ReadLine());
    }
  }
  }