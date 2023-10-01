// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Martin!");

//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"welcome, Mr. (kasutajanimi) / "welcome, Ms. (kasutaja perekonnanimi)"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine($"Welcome, {userGender}");