public class CinematicBattleManagerState : IBattleManagerState
{
    public void OnEnter(BattleManager battleManager)
    {
        // fade out ui
    }

    public void OnExit()
    {
        // fade in ui
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
