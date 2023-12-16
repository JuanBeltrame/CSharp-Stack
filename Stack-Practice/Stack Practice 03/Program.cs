using Stack_Practice_03;
using System.Drawing;

Auto auto01 = new Auto(1, 12, Color.Tan, 100);
Auto auto02 = new Auto(2, 12, Color.Tan, 100);
Auto auto03 = new Auto(3, 12, Color.Tan, 100);

Stack<Auto> autosPila = new Stack<Auto>();

Console.WriteLine("--------------------------------");
autosPila.Push(auto01);
autosPila.Push(auto02);
autosPila.Push(auto03);
foreach (var item in autosPila)
{
    Console.WriteLine(item.GetCarInfo());
}
Console.WriteLine("--------------------------------");
Console.WriteLine(autosPila.Peek().GetCarInfo());
Console.WriteLine("--------------------------------");
Console.WriteLine(autosPila.Pop().GetCarInfo());
Console.WriteLine("--------------------------------");
foreach (var item in autosPila)
{
    Console.WriteLine(item.GetCarInfo());
}
Console.WriteLine("--------------------------------");
if (autosPila.Contains(auto01))
{
    Console.WriteLine("Esta en la lista");
}
else
{
    Console.WriteLine("No esta en la lista");
}


