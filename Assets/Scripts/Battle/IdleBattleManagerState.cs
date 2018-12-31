public class IdleBattleManagerState : IBattleManagerState
{
    public void OnEnter(BattleManager battleManager)
    {
        // do nothing
    }

    public void OnExit()
    {
        // do nothing
    }

    public void Update()
    {
        // for each actor in idle state, increase their progress bar by speed * deltaTime * BattleSpeed
    }

    public bool Pop
    {
        get { return false; }
    }
}
