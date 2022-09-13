using System;

Database Client = new Database("Pascual",60000000,"Narnia","pascualveradev@gmail.com",true);
Console.WriteLine(Client.GetInfo());
public struct Database
{
    public Database(string name, int number, string address, string email, bool newClient)
    {
        Name = name;
        Number = number;
        Address = address;  
        Email = email;
        NewClient = newClient;
            
    }
    public string Name { get; set; }
    public int Number { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public bool NewClient { get; set; }

    public string GetInfo() { 
        return $"Nombre: {Name}\n" +
            $"Telefono: {Number} \n" +
            $"Direccion: {Address}\n" +
            $"Mail: {Email}\n" +
            $"Nuevo Cliente: {NewClient}";
    } 
    

}