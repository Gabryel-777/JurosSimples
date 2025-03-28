double Taxajuros,Capital,Tempo;

double Montante;

double JurosSimples;

 Console.Clear();

Console.Write("Capital [c] (R$)....:");
Capital = Convert.ToDouble (Console.ReadLine());
Thread.Sleep(1500);

Console.Write("Taxa de juros [i] (%)..: ");
 Taxajuros = Convert.ToDouble(Console.ReadLine());
Thread.Sleep(1500);

Console.Write ("Tempo [t] (meses)......: ");
 Tempo = Convert.ToDouble(Console.ReadLine());
Thread.Sleep(1500);

JurosSimples = Capital * Taxajuros /100* Tempo;

Montante = Capital + JurosSimples; 

Console.WriteLine ($"Juros: {Capital} * {Taxajuros} * {Tempo} = {JurosSimples}");
Thread.Sleep(2500);

Console.WriteLine ($"Montante: {Capital} + {JurosSimples} = {Montante}");