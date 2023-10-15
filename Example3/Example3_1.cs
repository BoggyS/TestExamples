public class Player
{
    private List<Vector2> activeWalkPath = null;
    private bool isMoving => activeWalkPath != null;
    private Player currentEnemy;
    private Vector2 currentPosition;

    public void Update()
    {
        UpdatePathToEnemy();
    }

    private void UpdatePathToEnemy()
    {
        if (currentEnemy == null)
        {
            activeWalkPath = null;
            return;
        }

        activeWalkPath = TryBuildPathToCoord(currentEnemy.currentPosition);
    }

    private List<Vector2> TryBuildPathToCoord(Vector2 target)
    {
        return < много строк кода по созданию пути из currentPosition в target >;
    }
}