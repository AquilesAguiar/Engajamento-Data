using System;

class Data{
  int dia,mes,ano;

  public int Dia{get{return dia;} set{dia=value;}}
  
  public int Mes{get{return mes;} set{mes=value;}}
  
  public int Ano{get{return ano;} set{ano=value;}}


  public Data(int d,int m,int a){
    dia = d;
    mes = m;
    ano = a;  
  }  
  

  public Data(){
    dia = int.Parse(DateTime.Now.Day.ToString());
    mes = int.Parse(DateTime.Now.Month.ToString());
    ano = int.Parse(DateTime.Now.Year.ToString());
  }

  public string MostraData(){
    return $"{dia}/{mes}/{ano}";
  }

  public int aumentaData(int num){
    if (dia == 31){
      dia = 0;
      return dia+=num;
    }
    return dia+=num;
    
  }


}

