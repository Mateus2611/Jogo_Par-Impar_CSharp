Random rdn = new Random();
int num_random = rdn.Next(0, 10);
string escolha;
int num, num2;
num2 = num_random;

do 
{
    Console.WriteLine("Par ou Impar?");
    escolha = Console.ReadLine().ToLower();

    if (escolha != "par" && escolha != "impar")
    {
        Console.WriteLine("Faça uma escolha válida: par ou impar ");
    }
}
while (escolha != "par" && escolha != "impar");

Console.WriteLine("Digite um número de 1 até 10:");
num = Convert.ToInt32(Console.ReadLine());

if (escolha == "par")
{
    Console.WriteLine($"O BOT escolheu  o valor {num2}");

    if ((num + num2) % 2 == 0)
    {
        Console.WriteLine("YOU WIN!!!");
    }
    else
    {
        Console.WriteLine("YOU LOSE!!!");
    }
}
else
{
    Console.WriteLine($"O BOT escolheu  o valor {num2}");
    
    if ((num + num2) % 2 != 0)
    {
        Console.WriteLine("YOU WIN!!!");
    }
    else
    {
        Console.WriteLine("YOU LOSE!!!");
    }
    
}