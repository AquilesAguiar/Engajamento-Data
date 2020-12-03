using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Data dataAtual = new Data();
    List<Data> listaDatas = new List<Data>();

    string decis ="s";
    int dia,mes,ano;

    while(decis == "s"){
      try{
        Console.Write("Digite o Dia >> ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Digite o Mês >> ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Digite o Ano >> ");
        ano = int.Parse(Console.ReadLine());

        dataAtual = new Data(dia,mes,ano);
        listaDatas.Add(dataAtual);

        Console.WriteLine($"Data Criada >>{dataAtual.MostraData()}");

        Console.Write("Deseja Acrescentar Mais datas? >> ");
        decis = Console.ReadLine();
      }
      catch(System.FormatException){
      Console.WriteLine("Algum dos parametros teve o tipo de formato errado,verifique e tente novamente");
      }
      
    }

    //Teste Para Aumentar Datas
    /* dataAtual = new Data(2,4,3454);
    Console.WriteLine($"Data Criada >>{dataAtual.MostraData()}");

    dataAtual.aumentaData(1);
     Console.WriteLine($"Data Criada >>{dataAtual.MostraData()}"); */

  }
}