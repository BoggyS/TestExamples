public class Player
{
    private List<Vector2> activeWalkPath = new List<Vector2>();
    private bool isMoving => activeWalkPath.Count > 0;
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
            activeWalkPath.Clear();
            return;
        }

        TryBuildPathToCoordNonAlloc(currentEnemy.currentPosition, ref activeWalkPath);
    }

    private bool TryBuildPathToCoordNonAlloc(Vector2 target, ref List<Vector2> path)
    {
        return < много строк кода по созданию пути из currentPosition в target >;
    }
}