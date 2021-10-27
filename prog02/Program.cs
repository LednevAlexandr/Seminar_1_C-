int x,y,max;
Console.Write("x:");
x=Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
y=Convert.ToInt32(Console.ReadLine());

if (x<y)
{
    max=y;
}
else
{
    max=x;
}

Console.WriteLine("Max="+max);