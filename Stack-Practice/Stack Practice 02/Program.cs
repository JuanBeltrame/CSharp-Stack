Stack<string> paises = new Stack<string>();

Console.WriteLine("-------------");
paises.Push("Argentina");
paises.Push("Brasil");
paises.Push("Peru");
paises.Push("Bolivia");
foreach(string item in paises)
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------");
// El Metodo Pop(). Elimina el ultimo elemento en salir
paises.Pop();
foreach (string item in paises)
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------");
// El Metodo Peek(). Devuelve el elemento sin eliminarlo 
Console.WriteLine(paises.Peek());
Console.WriteLine("-------------");
foreach (string item in paises)
{
    Console.WriteLine(item);
}


