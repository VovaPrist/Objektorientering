public class Enemy
{
    public string Name;
    public int Hp;
    public int Attack;
    public Enemy(string name, int hp, int attack)
    {
        Name = name;
        Hp = hp;
        Attack = attack;
    }
    public void AttackPlayer(Player playr)
    {
        playr.Hp -= Attack;
    }
}