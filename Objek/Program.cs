Console.WriteLine("\nWelcome to Bash-a-monster");
Console.WriteLine("Star Wars Edition \n");
Console.WriteLine("Do you wanna go first or let your opponent go first?\n");

Console.WriteLine("1. I wanna go first");
Console.WriteLine("2. Let that bitch go first\n");
string input;
while(true)
{
    Console.Write("1/2: ");
    input = Console.ReadLine();
    if(input == "1" || input == "2") break;
    else continue;
}
if (input == "2")
{
    Console.Clear();
    Console.WriteLine("Bold choice!");
    Console.Write("Choose your name: ");
    string name = Console.ReadLine();
    Player player = new(name, 100, 999);
    Enemy enemy = new("Darth Vader", 200, 99);
    Console.WriteLine($"Your enemy is: {enemy.Name} with {enemy.Hp}hp and {enemy.Attack} attack");
    Console.WriteLine($"You are {player.Name} with {player.Hp}hp and random attack");
    Console.WriteLine($"Press enter when you're ready to get clapped");
    Console.ReadLine();
    enemy.AttackPlayer(player);
    Console.WriteLine($"{enemy.Name} dealt {enemy.Attack} damage to you");
    Console.WriteLine($"You have {player.Hp}hp left");
    Console.WriteLine("Do you wish to attack?(Press enter)");
    Console.ReadLine();
    player.AttackEnemy(enemy);
    Console.WriteLine($"You dealt {player.randomAttack} which left {enemy.Name} with {enemy.Hp}");
    if (enemy.Hp <= 0)
    {
        Console.WriteLine("You won!");
    }
    else
    {
        Console.WriteLine("You lost");
    }
}
else
{
    
}