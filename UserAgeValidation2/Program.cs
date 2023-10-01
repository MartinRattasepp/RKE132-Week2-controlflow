// See https://aka.ms/new-console-template for more information

//rakendus küsib kasjutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. (kasutaja perekonnanimi)" / "Welcome, Ms. (kasutaja perekonnanimi)"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("please enter your lastname:");
string UserLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"welcome, Ms.{UserLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {UserLastName}!");
}

     