double y;
double m;
double l;
double BMI;
Console.Write("how tall are you ? (cm):");
y= Convert.ToDouble(Console.ReadLine());
Console.Write("Geben Sie ihre Gewicht?");
m= Convert.ToDouble(Console.ReadLine());
l = y / 100;
BMI = m / (l * l);
Console.WriteLine(BMI);
if (BMI < 18.5)
{
    Console.WriteLine("Untergewicht");
}
else if  (BMI > 25)
{
    Console.WriteLine("Ubergewicht");

}
else
{
    Console.WriteLine("Medium");
}