Console.Clear();
Double numero1 , numero2 , numero3 , media;
Console.WriteLine("MEDIA ARITMÉTICA DE 3 NUMEROS \n");

Console.WriteLine("DIGITE SEU 1 NUMERO:");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("DIGITE SEU 1 NUMERO:");
numero2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("DIGITE SEU 1 NUMERO:");
numero3 = Convert.ToDouble(Console.ReadLine());

media = numero1 + numero2 + numero3 / 3;

Console.WriteLine($"\nmedia {media:N1}");