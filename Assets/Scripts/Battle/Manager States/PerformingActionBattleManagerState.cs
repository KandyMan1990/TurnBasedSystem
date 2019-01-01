public class PerformingActionBattleManagerState : IBattleManagerState
{
    public void OnEnter(BattleManager battleManager)
    {
        // allow actor with a queued action to perform it
    }

    public void OnExit()
    {
        // return to previous state
    }

    public void Update()
    {
        // do nothing
    }

    public bool Pop
    {
        get { return true; }
    }
}
