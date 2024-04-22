char[] letra = new char[10];
char[] minusculas = new char[10];


for (int i = 0; i < 10; i++)
{
    Console.Write("Digite uma letra: ");
    letra[i] = char.Parse(Console.ReadLine());

}

for (int i = 0; i < 10; i++)
{

    if (letra[i] == 'a')
    {
        letra[i] = 'A';
    }

    if (letra[i] == 'e')
    {
        letra[i] = 'E';
    }

    if (letra[i] == 'i')
    {
        letra[i] = 'I';
    }

    if (letra[i] == 'o')
    {
        letra[i] = 'O';
    }

    if (letra[i] == 'u')
    {
        letra[i] = 'U';
    }

}

Console.Write("\nVogais convertidas em letras maiúsculas: ");
for (int i = 0; i < 10; i++)
{
    if (letra[i] == 'A' || letra[i] == 'E' || letra[i] == 'I' || letra[i] == 'O' || letra[i] == 'U')
    {
        Console.Write(letra[i] + " ");
    }
            
}

Console.ReadKey();

