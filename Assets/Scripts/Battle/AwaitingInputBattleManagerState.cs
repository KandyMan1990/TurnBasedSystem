public class AwaitingInputBattleManagerState : IBattleManagerState
{
    public void OnEnter(BattleManager battleManager)
    {
        // set active character
        // enable ui to select action
    }

    public void OnExit()
    {
        // queue action with battle manager
        // close select action ui
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
