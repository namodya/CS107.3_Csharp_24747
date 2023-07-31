// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your salary");
int sal= int. Parse(Console.ReadLine());
Console.WriteLine("Enter the tax rate");
double tax= double.Parse(Console.ReadLine());

double newSal =sal- tax;
Console.WriteLine("Your salary after taxes :" + newSal );
Console.ReadLine();
