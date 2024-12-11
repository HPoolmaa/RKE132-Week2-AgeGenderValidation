using System.ComponentModel.Design;

Console.WriteLine("Hello, Helary!");

// teh. ülesanne: Rakendus küsib sugu (mees/naine).
// Rakendus küsib kasutaja perekonnanime
// Lähtudes kasutaja valikust, rakendus tervitab teda:
// "Welcome Ms./Mr.[Kasutaja perekonnanimi]

Console.WriteLine("Please select your gender (m/f/x):");

char UserGender = Char.Parse(Console.ReadLine());
// loeb konsoolist andmed sõne formaadis (lause/string)
Console.WriteLine("Please enter your last name:");
string LastName = Console.ReadLine();

if (UserGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {LastName}!");
}
else if (UserGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {LastName}!");
}
else if (UserGender == 'x')
{
    Console.WriteLine($"Welcome, They/Them {LastName}!");
}
else
{
    Console.WriteLine($"Welcome, {LastName}!");
}