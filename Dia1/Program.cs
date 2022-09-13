//Tomar Nombre por consola
Console.WriteLine("Escribe tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Hello " + nombre);
//Obtener hora actual
string time = DateTime.Now.ToString("h:mm:ss tt");
Console.WriteLine("The current time is {0}", time);