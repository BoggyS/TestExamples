public class ExtPlayer : Player
{
    public event Action Changed;
}

class ExtProgram : Program
{
    // Widjet showing the player's health amount
    private TextView healthView;

    private int? previousHealth;

    public static void ExtMain(string[] args)
    {
        // Calling the player creation methods
        Main(args);

        UpdateHealthView();
        player.Changed += UpdateHealthView;

        // Hit the player
        HitPlayer();
    }

    private void UpdateHealthView()
    {
        healthView.Text = player.Health.ToString();
        healthView.Color = player.Health - (previousHealth ?? player.Health) < -10 ? Color.Red : Color.White;
        previousHealth = player.Health;
    }
}
