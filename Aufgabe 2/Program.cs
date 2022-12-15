double x;
double y = 150;
double z;
double w;
Console.Write("How many year did you Work??:");
x= Convert.ToDouble(Console.ReadLine());
if (x < 3)
{
    Console.WriteLine("You will get nothing");
}
else if (x > 3 && x <= 10)
{
            x = (x - 3)*y;
    Console.WriteLine($"{ "You will get bonus: "}{x} {"EUR"}");
}
else  
{
    z = (x - 3);
    w = 10 * z;
    x= z*y+w;
    Console.WriteLine($"{"You will get bonus: "}{x}{"EUR"}");
}