// Teh. Ülesanne:
// Kasutajalt küsitakse vanust
// kasutaja sisestab vanuse
// Kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "Parental permission is needed, please ask permission from your parents"
// muul juhul
// "Welcome to DIGIlaiguline application, have a great time!"

Console.WriteLine("Enter your age:");

string UserAge = Console.ReadLine();

int UserAgeNum = 0;
//boolean - ainult true/false statements

bool IsAgeNumber = Int32.TryParse(UserAge, out UserAgeNum);

Console.WriteLine($"Parse result {IsAgeNumber}. User is {UserAgeNum} years old");

//int UserAge = Int32.Parse(Console.ReadLine()); // "13" - heap, ehk võtab vahemälust rohkem ruumi. Ilma jutumärkideta saab nr. salvestada stacki st. 13 - Stack
// Int funktsioon, Int 32+Parse (konverteerimine stringist arvuks).

//if(UserAge >= 18)
//{
//Console.WriteLine("Welcome to DIGIlaiguline application, have a great time!");
//}
//else
//{
//Console.WriteLine("Parental permission is needed, please ask permission from your parents!");
//}

if (IsAgeNumber == true)
{
    if (UserAgeNum >= 18)
    {
        Console.WriteLine("Welcome to DIGIlaiguline application, have a great time!");
    }
    else
    {
        Console.WriteLine("Parental permission is needed, please ask permission from your parents!");
    }
}
else
{
    Console.WriteLine("Could not read your age, please use only numbers!");
}