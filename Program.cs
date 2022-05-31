Console.Write("irányítószám: ");
string isz = Console.ReadLine();
Console.Write("város: ");
string varos = Console.ReadLine();
Console.Write("utca: ");
string utca = Console.ReadLine();

Console.WriteLine($"{isz} {varos} {utca}");
Console.WriteLine("{0} {1} {2}", isz, varos, utca);
Console.WriteLine(isz + " " + varos + " " + utca);

double pi = Math.PI;

Console.WriteLine(pi);
Console.WriteLine("{0:0.00}", pi);

string s1 = "fóla";
string s2 = "fűnyíró";
string s3 = "kv";

int a1 = 120000;
int a2 = 73999;
int a3 = 0;

Console.WriteLine("{0,-7} {1,6}Ft", s1, a1);
Console.WriteLine("{0,-7} {1,6}Ft", s2, a2);
Console.WriteLine("{0,-7} {1,6}Ft", s3, a3);

int d = (int)Math.Pow(2, 3);

int e1 = 10;
int e2 = 3;

Console.WriteLine(10 / (decimal)3);