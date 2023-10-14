using Serializable = NonSystemNamespace.Serializable;

public class Player
{
    [Serializable]
    public int Health
    {
        get;
        private set;
    }

    public void Hit(int damage)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException("Damage should be greater than zero!");

        Health -= Math.Min(Health, damage);
    }
}

public class Settings
{
    [Serializable]
    public int Damage { get; }
}

// Note: Static for simplicity 
static class PlayerFactory
{
    private const string NewPlayerPath = "NewPlayer.json";
    private static Player _playerPrototype;

    public static void Initialize()
    {
        _playerPrototype = Serializer.LoadFromFile<Player>(NewPlayerPath);
    }
    public static Player CreateNewPlayer()
    {
        return Serializer.CreateShallowCopy(_playerPrototype);
    }
}

static class SettingsManager
{
    private const string SettingsPath = "Settings.json";
    public static Settings SettingsInstance { get; private set; }

    public static void Initialize()
    {
        SettingsInstance = Serializer.LoadFromFile<Settings>(SettingsPath);
    }
}

class Program
{
    private static Player player;

    public static void Main(string[] args)
    {
        // Create new player.
        var player = PlayerFactory.CreateNewPlayer();
        // Hit player.
        player.Hit(SettingsManager.SettingsInstance.Damage);
    }
}
