public class Player
{
    public string Name;
    public int Hp;
    public int Attack;
    private Random random = Random.Shared;
    public int randomAttack;
    public Player(string name, int hp, int attack)
    {
        Name = name;
        Hp = hp;
        Attack = attack;
    }
    public void AttackEnemy(Enemy enmy)
    {
        randomAttack = random.Next(Attack);
        enmy.Hp -= Attack;
    }
}