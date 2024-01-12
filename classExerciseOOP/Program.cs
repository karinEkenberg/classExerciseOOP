using classExerciseOOP;

Car c1 = new Car();
Car c2 = new Car("DEF345", "Saab", "88", 2010, false);
//c1.regNr = "ABC123";
//c1.make = "Volvo";
//c1.model = "V40";
//c1.year = 1990;
//c1.forSale = true;
c1.RegNr = "ABC123";
c1.Make = "Volvo";
c1.Model = "V40";
c1.Year = 19;
c1.ForSale = true;
Console.WriteLine("Enter cars registration number:");
string regNr = Console.ReadLine();
Console.WriteLine("Enter cars make:");
string make = Console.ReadLine();
Console.WriteLine("Enter cars model:");
string model = Console.ReadLine();
Console.WriteLine("Enter cars production year:");
int year = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Is it for sale Y/N");
char ch = Convert.ToChar(Console.ReadLine());
bool forsale = false;
if(Char.ToUpper(ch) == 'J')
{
    forsale = true;
}
Car c = new Car(make, model, regNr, year, forsale);
Console.WriteLine("-------------------------");
Console.WriteLine("[Regnr] [Make & modell]");
Console.WriteLine("-------------------------");
Console.WriteLine($"{c1.RegNr} : {c1.Make} {c1.Model}");
Console.WriteLine(c1.ToString());
Console.WriteLine(c2.ToString());
Console.WriteLine(c.ToString());

