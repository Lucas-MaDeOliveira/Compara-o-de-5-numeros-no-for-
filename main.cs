using System;

class Program {
  public static void Main (string[] args) {

    int i =0;
    for(int j = 0; j <5; i++)
    {
      Console.WriteLine("Coloque o numero ");
      int n = Convert.ToInt32(Console.ReadLine());
      if(j> i)
      {
        i = n;
      }
      {
        Console.WriteLine(i);
      }
    }  
  }
}
  