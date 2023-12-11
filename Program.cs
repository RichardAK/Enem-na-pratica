double D;

Console.WriteLine("Digite o desvio percentual:");
D= Convert.ToDouble(Console.ReadLine());

if(D >= 5.0){
  Console.Clear();
  Console.Beep();
  Console.ForegroundColor=ConsoleColor.Red;
  Console.WriteLine("Rejeitado");

  Console.ResetColor();
}

else if(D >= 3.0){
  Console.Clear();
  Console.Beep();
  Console.ForegroundColor=ConsoleColor.Yellow;
  Console.WriteLine("3º Classe");

  Console.ResetColor();
}

else if(D >= 1.0){
  Console.Clear();
  Console.Beep();
  Console.ForegroundColor=ConsoleColor.Blue;
  Console.WriteLine("2º Classe");

  Console.ResetColor();
}

else{
  Console.Clear();
  Console.Beep();
  Console.ForegroundColor=ConsoleColor.Blue;
  Console.WriteLine("1º Classe");

  Console.ResetColor();
}