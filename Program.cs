class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    // Create a Human class with four public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    // Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }

    // Metodo de atacar
    public int Attack(Human target)
    {
        int damage = Strength * 3; 
        target.Health -= damage; 
        return target.Health; 
}

class Program
{
    static void Main(string[] args)
    {    
        Human attacker = new Human("Atacante", 5, 4, 6, 100); //Se crea un atacante con custom attributes     
        Human target = new Human("Objetivo"); // Se crea un objetivo con atributos por defecto

        int remainingHealth = attacker.Attack(target);

        Console.WriteLine($"{target.Name} Vida: {target.Health}");
        Console.WriteLine($"{attacker.Name} Vida: {attacker.Health}");
        Console.WriteLine($"Salud restante de: {target.Name}: {remainingHealth}");
    }
}
}