public class Player
{
    public int Health
    {
        get; private set;
    }

    public Player(int health)
    {
        Health = health;
    }

    public void Hit(int damage)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException("Damage should be greater than zero!");

        Health -= Math.Min(Health, damage);
    }
}

class Program
{
    private const int NewPayerHealth = 100;
    private const int Damage = 10;

    private static Player player;

    public static void Main(string[] args)
    {
        // Create new player.
        player = new Player(NewPayerHealth);
        // Hit player.
        player.Hit(Damage);
    }
}